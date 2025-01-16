using SComms.Promoter.Core.Models;
using SComms.Promoter.Core.Models.Dtos;
using SComms.Promoter.Core.Models.Ipos;
using SComms.Promoter.Core.Repositories;
using TinyFx;
using TinyFx.AspNet;
using TinyFx.Data;
using TinyFx.DbCaching;
using TinyFx.Extensions.RabbitMQ;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;

namespace SComms.Promoter.Core.Services;

public class PromoteService
{
    /// <summary>
    /// 获取等级列表
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<List<PromoteVipLevelDto>> GetVipLevels(string userId)
    {
        var user = await GlobalUserDCache.Create(userId);
        var currencyId = await user.GetCurrencyIdAsync();
        var operatorId = await user.GetOperatorIdAsync();

        //var rst = await new Sf_promoter_vipMO().GetSortAsync("OperatorID=@OperatorID", "PLevel ASC", values: new object[] { operatorId });

        var rst = DbCachingUtil.GetList<Sf_promoter_vipPO>(it => it.OperatorID, operatorId);
        //var vipConfig = new SfPromoterVipDCache(operatorId);
        //var rst = await vipConfig.GetDo();
        return rst.OrderBy(x => x.PLevel).Select(item => new PromoteVipLevelDto
        {
            OperatorID = item.OperatorID,
            PLevel = item.PLevel,
            NeedPerf = item.NeedPerf.AToM(currencyId)
        }).ToList();
    }

    /// <summary>
    /// 当前用户信息
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<PromoteUserDto> UserInfo(string userId)
    {
        var userCache = await GlobalUserDCache.Create(userId);
        var currencyId = await userCache.GetCurrencyIdAsync();
        var userId1 = await userCache.GetPUserID1Async();

        var userId1Name = string.Empty;
        var mobile1 = string.Empty;
        if (!string.IsNullOrWhiteSpace(userId1))
        {
            var userId1Info = await GlobalUserDCache.Create(userId1);
            userId1Name = await userId1Info.GetUsernameAsync();
            mobile1 = await userId1Info.GetMobileAsync();
        }

        var userPro = DbSink.BuildUserPromoterMo(userId);
        var todayDirectNum = 0L;
        if (userPro != null)
        {
            var todayUserNums = await new Sf_promoter_user_dayMO().GetCountAsync("DayID=@DayID AND UserID=@UserId", DateTime.UtcNow.Date, userId);

            todayDirectNum = todayUserNums > 0
                ? 0
                : await userPro.GetCountAsync("PUserID=@UserId AND PromoteTime>=@Today", userId, DateTime.UtcNow.Date);
        }

        var user = await new Sf_promoter_userMO().GetByPKAsync(userId);
        return user == null ? new PromoteUserDto
        {
            PLevel = 1,
            DirectSuperior = userId1Name,
            PUrl = userId,
            Mobile = mobile1,
        } : new PromoteUserDto
        {
            PUrl = userId,
            PLevel = user.PLevel,
            DirectSuperior = userId1Name,
            Mobile = mobile1,
            TotalComm = user.TotalComm.AToM(currencyId),
            TotalCollectComm = user.CollectComm.AToM(currencyId),
            CurrentComm = user.TotalComm.AToM(currencyId) - user.CollectComm.AToM(currencyId),
            LastComm = user.LastComm.AToM(currencyId),
            DirectNum = user.DirectNum + (int)todayDirectNum,
            OtherNum = user.OtherNum,
            TeamNum = user.DirectNum + user.OtherNum,
            TotalPerf = user.TotalPerf.AToM(currencyId),
            DirectPerf = user.DirectPerf.AToM(currencyId),
            OtherPerf = user.OtherPerf.AToM(currencyId)
        };
    }

    /// <summary>
    /// 被邀请用户列表
    /// </summary>
    /// <returns></returns> 
    public async Task<PagerList<InviteUserDto>> GetInvitedUsers(InviteUserIpo ipo, string userId)
    {
        var user = await GlobalUserDCache.Create(userId);

        var paramters = new List<object>();

        var where = " PUserID=@UserID ";
        paramters.Add(userId);

        if (ipo.StartTime != null && ipo.EndTime != null)
        {
            where += " AND PromoteTime >= @StartTime AND PromoteTime<=@EndTime";
            paramters.Add(ipo.StartTime);
            paramters.Add(ipo.EndTime.Value.AddDays(1));
        }

        var userPromoterMo = DbSink.BuildUserPromoterMo(userId);

        var total = await userPromoterMo.GetCountAsync(where, values: paramters.ToArray());
        var rst = await userPromoterMo.GetPagerListAsync(ipo.PageSize, ipo.PageIndex, where, "PromoteTime Desc", values: paramters.ToArray());

        var inviteUsers = (await Task.WhenAll(rst.Select(async (item) =>
        {
            var directUserName = string.Empty;
            var mobile = string.Empty;
            if (!string.IsNullOrWhiteSpace(item.IUserID))
            {
                var directUser = await GlobalUserDCache.Create(item.IUserID);
                if (directUser != null)
                {
                    directUserName = await directUser.GetUsernameAsync();
                    mobile = await directUser.GetMobileAsync();
                }
            }

            return new InviteUserDto
            {
                UserId = item.IUserID,
                UserName = directUserName,
                Mobile = mobile,
                PromoteTime = item.PromoteTime
            };
        }))).ToList();

        return new PagerList<InviteUserDto>(ipo.PageIndex, ipo.PageSize, total, inviteUsers);
    }

    /// <summary>
    /// 我的佣金
    /// </summary>
    /// <param name="ipo"></param>
    /// <param name="userId"></param>
    /// <returns></returns>
    public async Task<PagerList<PromoteCommDto>> Commission(PromoteCommIpo ipo, string userId)
    {
        var user = await GlobalUserDCache.Create(userId);
        var currencyId = await user.GetCurrencyIdAsync();

        var paramters = new List<object>();

        var where = " UserID=@UserID ";
        paramters.Add(userId);

        if (ipo.StartTime != null && ipo.EndTime != null)
        {
            where += " AND DayId >= @StartTime AND DayId<=@EndTime";
            paramters.Add(ipo.StartTime);
            paramters.Add(ipo.EndTime.Value.AddDays(1));
        }

        if (ipo.PromoterType != null)
        {
            where += " AND PromoterType=@PromoterType";
            paramters.Add(ipo.PromoterType);
        }

        var scPromoterPTypeDayMO = new Sf_promoter_ptype_dayMO();

        var total = await scPromoterPTypeDayMO.GetCountAsync(where, values: paramters.ToArray());
        var rst = await scPromoterPTypeDayMO.GetPagerListAsync(ipo.PageSize, ipo.PageIndex, where, "DayID Desc", values: paramters.ToArray());
        var operatorId = await user.GetOperatorIdAsync();
        var commissions = rst.Select(item => new PromoteCommDto
        {
            DayID = item.DayID.ToUtcTime(operatorId).ToLocalTime(operatorId),
            UserID = item.UserID,
            PromoterType = item.PromoterType,
            Perf = item.Perf.AToM(currencyId),
            Contributors = item.Contributors,
            Comm = item.Comm.AToM(currencyId)
        });
        return new PagerList<PromoteCommDto>(ipo.PageIndex, ipo.PageSize, total, commissions);
    }

    /// <summary>
    /// 佣金明细
    /// </summary>
    /// <returns></returns>
    public async Task<PagerList<PromoteCommDetailDto>> CommissionDetail(PromoteCommDetailIpo ipo, string userId)
    {
        var user = await GlobalUserDCache.Create(userId);
        var currencyId = await user.GetCurrencyIdAsync();

        var paramters = new List<object>();

        var where = " UserID=@UserID ";
        paramters.Add(userId);

        if (ipo.StartTime != null && ipo.EndTime != null)
        {
            where += " AND DayId >= @StartTime AND DayId<=@EndTime";
            paramters.Add(ipo.StartTime);
            paramters.Add(ipo.EndTime.Value.AddDays(1));
        }

        if (ipo.PromoterType != null)
        {
            where += " AND PromoterType=@PromoterType";
            paramters.Add(ipo.PromoterType);
        }

        var promoterPTypeDayDetailMO = new Sf_promoter_ptype_day_detailMO();

        var total = await promoterPTypeDayDetailMO.GetCountAsync(where, values: paramters.ToArray());
        var rst = await promoterPTypeDayDetailMO.GetPagerListAsync(ipo.PageSize, ipo.PageIndex, where, "DayID Desc", values: paramters.ToArray());

        var commissions = (await Task.WhenAll(rst.Select(async (item) =>
        {
            var directUserName = string.Empty;
            var mobile = string.Empty;
            var directUser = await GlobalUserDCache.Create(item.IUserID);
            if (directUser != null)
            {
                directUserName = await directUser.GetUsernameAsync();
                mobile = await directUser.GetMobileAsync();
            }
            return new PromoteCommDetailDto
            {
                UserName = directUserName,
                Mobile = mobile,
                PromoterType = item.PromoterType,
                Perf = item.Perf.AToM(currencyId),
                Comm = item.Comm.AToM(currencyId)
            };
        }))).ToList();
        return new PagerList<PromoteCommDetailDto>(ipo.PageIndex, ipo.PageSize, total, commissions);

    }

    /// <summary>
    /// 我的业绩
    /// </summary>
    /// <returns></returns>
    public async Task<PagerList<PromotePerformanceDto>> Performance(PromotePerformanceIpo ipo, string userId)
    {
        var user = await GlobalUserDCache.Create(userId);
        var currencyId = await user.GetCurrencyIdAsync();
        var operatorId = await user.GetOperatorIdAsync();

        var paramters = new List<object>();
        var where = " UserID = @UserID ";
        paramters.Add(userId);

        if (ipo.StartTime != null && ipo.EndTime != null)
        {
            where += " AND DayId >= @StartTime AND DayId<=@EndTime ";
            paramters.Add(ipo.StartTime);
            paramters.Add(ipo.EndTime);
        }

        if (!string.IsNullOrWhiteSpace(ipo.Account))
        {
            var userMos = DbSink.GetUserMoList();
            var iUserId = string.Empty;

            foreach (var userMo in userMos)
            {
                var userEo = await userMo.GetSingleAsync($"Username=@UserName OR Mobile=@Mobile", ipo.Account, ipo.Account);
                if (userEo != null)
                {
                    iUserId = userEo.UserID;
                    break;
                }
            }
            // 下级空直接返回空列表
            if (string.IsNullOrWhiteSpace(iUserId))
                return new PagerList<PromotePerformanceDto>(ipo.PageIndex, ipo.PageSize, 0, new List<PromotePerformanceDto>());


            where += " AND IUserID = @IUserID ";
            paramters.Add(iUserId);
        }

        var scPromoterIUserDay = new Sf_promoter_iuser_dayMO();

        var total = await scPromoterIUserDay.GetCountAsync(where, values: paramters.ToArray());
        var rst = await scPromoterIUserDay.GetPagerListAsync(ipo.PageSize, ipo.PageIndex, where, "DayID Desc", values: paramters.ToArray());
        var list = (await Task.WhenAll(rst.Select(async (item) =>
        {
            var directUserName = string.Empty;
            var mobile = string.Empty;
            if (!string.IsNullOrWhiteSpace(item.IUserID))
            {
                var directUser = await GlobalUserDCache.Create(item.IUserID);
                if (directUser != null)
                {
                    directUserName = await directUser.GetUsernameAsync();
                    mobile = await directUser.GetMobileAsync();
                }
            }

            return new PromotePerformanceDto
            {
                UserID = item.UserID,
                DirectUserName = directUserName,
                Mobile = mobile,
                PromoteTime = item.PromoteTime.ToUtcTime(operatorId),
                DirectNum = item.DirectNum,
                Perf = item.Perf.AToM(currencyId),
                ContributionComm = item.ContributionComm.AToM(currencyId),
                // DepositAmount = item.DepositAmount.AToM(currencyId),
                // Income = item.Income.AToM(currencyId)
            };
        }))).ToList();

        return new PagerList<PromotePerformanceDto>(ipo.PageIndex, ipo.PageSize, total, list);
    }

    /// <summary>
    /// 返佣比例
    /// </summary>
    /// <returns></returns>
    public async Task<PromoteCommProportionsDto> CommProportions(PromoteCommProportionsIpo ipo, string userId)
    {
        var user = await GlobalUserDCache.Create(userId);
        var currencyId = await user.GetCurrencyIdAsync();
        var operatorId = await user.GetOperatorIdAsync();

        //var where = " PromoterType=@PromoterType AND OperatorID = @OperatorID ";
        //var paramters = new List<object>() { ipo.PromoterType, operatorId };

        //var config = await new Sf_promoter_configMO().GetSingleAsync("OperatorID=@OperatorID", operatorId);

        //if (config == null)
        //    throw new Exception("promete config not found");
        var config = DbCachingUtil.GetSingle<Sf_promoter_configPO>(operatorId);
        //var configDCache = new SfPromoterConfigDCache(operatorId);
        //var config = await configDCache.GetDo();

        //var commConfigs = await new Sf_promoter_comm_configMO().GetSortAsync(where, "CommLevel ASC", paramters.ToArray());
        var commConfigs = DbCachingUtil.GetList<Sf_promoter_comm_configPO>(it => new {
            it.OperatorID,
            it.PromoterType
        }, new
        {
            OperatorID = operatorId,
            ipo.PromoterType
        });
        if(null==config)
        {
            return new PromoteCommProportionsDto();
        }
        //var commConfigsDCache = new SfPromoterCommConfigDCache(operatorId, ipo.PromoterType);
        //var commConfigs = await commConfigsDCache.GetDo();
        var commProportions = commConfigs.OrderBy(x => x.CommLevel).Select(item => new PromoteCommProportionsIpoDto
        {
            OperatorID = item.OperatorID,
            CommLevel = item.CommLevel,
            Comm = item.Comm.MToA(currencyId),
            BetAmount = config.HasBonusPerf ? item.MinAmountPerf.AToM(currencyId) : item.MinCashPerf.AToM(currencyId)
        }).ToList();

        return new PromoteCommProportionsDto
        {
            Config = new PromoteConfigDto
            {
                HasBonusPerf = config.HasBonusPerf,
                CommMinDeposit = config.CommMinDeposit.AToM(currencyId),
                CommMinPerf = config.CommMinPerf.AToM(currencyId)
            },
            CommProportions = commProportions,
        };

    }

    /// <summary>
    /// 领取接口
    /// </summary>
    /// <param name="userId"></param> 
    /// <param name="appId"></param>
    public async Task<decimal> Collect(string userId, string appId)
    {
        var tm = new TransactionManager();

        try
        {

            var scPromoterUserMo = new Sf_promoter_userMO();
            var scCollectMo = new Sf_promoter_collectMO();
            var currencyChangeSvc = new CurrencyChangeService(userId);

            var userMo = await scPromoterUserMo.GetByPKAsync(userId, tm, true);
            if (userMo == null)
            {
                throw new CustomException(PromoteCodes.RS_NOT_ENOUGH_COMM_MONEY, "not found promote user");
            }

            var currentComm = userMo.TotalComm - userMo.CollectComm;
            if (currentComm == 0)
            {
                throw new CustomException(PromoteCodes.RS_NOT_ENOUGH_COMM_MONEY, "insufficient balance");
            }

            userMo.LastComm = currentComm;
            userMo.CollectComm = userMo.CollectComm + currentComm;

            await scPromoterUserMo.PutAsync(userMo, tm);

            // 计算贡献人数
            var scCols = await scCollectMo.GetByUserIDAsync(userId, tm);
            var scColsContributionNum = scCols.Sum(w => w.ContributionNum);
            var currentCollectedComm = userMo.OtherNum + userMo.DirectNum - scColsContributionNum;
            //当前用户缓存
            var userDCache = await GlobalUserDCache.Create(userId);
            var currencyId = await userDCache.GetCurrencyIdAsync();
            var operatorId = await userDCache.GetOperatorIdAsync();
            //var config = await new Sf_promoter_configMO().GetSingleAsync("OperatorID=@OperatorID", operatorId);
            //if (config == null)
            //    throw new Exception("promete config not found");
            //var configDCache = new SfPromoterConfigDCache(operatorId);
            //var configEo = await configDCache.GetDo();
            var configEo = DbCachingUtil.GetSingle<Sf_promoter_configPO>(operatorId);
            var scCollectEo = new Sf_promoter_collectEO
            {
                CollectID = Guid.NewGuid().ToString(),
                UserID = userId,
                FromMode = await userDCache.GetFromModeAsync(),
                FromId = await userDCache.GetFromIdAsync(),
                UserKind = (int)await userDCache.GetUserKindAsync(),
                RecDate = DateTime.UtcNow,
                IsCollectBonus = configEo.IsCollectBonus,
                FlowMultip = configEo.FlowMultip,
                ContributionNum = currentCollectedComm,
                CollectedComm = currentComm,
                OperatorID = userMo.OperatorID
            };
            await scCollectMo.AddAsync(scCollectEo, tm);

            var changeMsg = await currencyChangeSvc.Add(new CurrencyChangeReq
            {
                UserId = userId,
                AppId = appId,
                UserIp = AspNetUtil.GetRemoteIpString(),
                Amount = currentComm,
                OperatorId = operatorId,
                ChangeTime = DateTime.UtcNow,
                CurrencyId = currencyId,
                FlowMultip = configEo.FlowMultip,
                //IsBonus = configEo.IsCollectBonus,
                ChangeBalance = configEo.IsCollectBonus ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                Reason = "推广员领取佣金",
                SourceType = 500008,
                SourceId = scCollectEo.CollectID,
                SourceTable = "Sf_promoter_collect",
                TM = tm
            });

            tm.Commit();
            if (changeMsg != null)
                await MQUtil.PublishAsync(changeMsg);
            return currentComm.AToM(currencyId);
        }
        catch (CustomException ex)
        {
            tm.Rollback();
            throw ex;
        }
    }

    /// <summary>
    /// 领取记录
    /// </summary>
    /// <returns></returns>
    public async Task<PagerList<PromoteCollectRecordDto>> CollectRecord(PromoteCollectRecordIpo ipo, string userId)
    {
        var user = await GlobalUserDCache.Create(userId);
        var currencyId = await user.GetCurrencyIdAsync();
        var operatorId = await user.GetOperatorIdAsync();

        var paramters = new List<object>();
        var where = " UserId=@UserId";
        paramters.Add(userId);


        if (ipo.StartTime != null && ipo.EndTime != null)
        {
            where += " AND RecDate >= @StartTime AND RecDate<=@EndTime ";
            paramters.Add(ipo.StartTime.Value.ToUtcTime(operatorId));
            paramters.Add(ipo.EndTime.Value.ToUtcTime(operatorId).AddDays(1));
        }
        var sfPromoterCollect = new Sf_promoter_collectMO();

        var total = await sfPromoterCollect.GetCountAsync(where, values: paramters.ToArray());
        var rst = await sfPromoterCollect.GetPagerListAsync(ipo.PageSize, ipo.PageIndex, where, "RecDate Desc", values: paramters.ToArray());

        var list = rst.Select(item => new PromoteCollectRecordDto
        {
            ContributionNum = item.ContributionNum,
            CollectedComm = item.CollectedComm.AToM(currencyId),
            RecDate = item.RecDate.ToLocalTime(operatorId),
        }).ToList();

        return new PagerList<PromoteCollectRecordDto>(ipo.PageIndex, ipo.PageSize, total, list);
    }

}