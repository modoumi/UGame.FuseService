using TinyFx;
using TinyFx.AspNet;
using TinyFx.Data.SqlSugar;
using TinyFx.DbCaching;
using UGame.FuseService.Banner.Caching;
using UGame.FuseService.Banner.Common;
using UGame.FuseService.Banner.Models.Dtos;
using UGame.FuseService.Banner.Models.Ipos;
using UGame.FuseService.Banner.Repositories;
using UGame.FuseService.Banner.Utilities;
using Xxyy.Common;
using Xxyy.Common.Caching;

namespace UGame.FuseService.Banner.Services;

/// <summary>
/// 
/// </summary>
public class BannerService
{

    /// <summary>
    /// Banner
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<Dictionary<int, List<SCBannerDto>>> Banner(SCBannerIpo ipo)
    {
        var result = new Dictionary<int, List<SCBannerDto>>();

        var globalUserDCache = await GlobalUserDCache.Create(ipo.UserId);

        ipo.UserMode = await globalUserDCache.GetUserModeAsync();
        ipo.OperatorId = await globalUserDCache.GetOperatorIdAsync();
        ipo.CurrencyId = await globalUserDCache.GetCurrencyIdAsync();
        ipo.HasPay = await globalUserDCache.GetHasPayAsync();
        ipo.BannerType = ipo.UserMode == UserMode.Visitor ? BannerTypeEnum.Visitor : BannerTypeEnum.Register;

        foreach (var item in ipo.Position)
        {
            var cahce = new SCBannerDCache((int)ipo.BannerType, ipo.AppId, ipo.OperatorId, ipo.LangId, (int)item);
            var ret = await cahce.GetAsync(false);

            if (ipo.UserMode != UserMode.Visitor)
            {
                //根据用户是否充过值，加载banner
                var customBanner = await GetCustomBanner(ipo, item);

                if (customBanner.Any()) ret.AddRange(customBanner);
            }

            if (ret.Any())
            {
                foreach (var retItem in ret)
                {
                    retItem.ImageUrl = IconUtil.GetIcon(retItem.ImageUrl);
                }

                switch (item)
                {
                    //充值页
                    case BannerPositionEnum.Pay:
                        ret = await PayBanner(ret, ipo);
                        break;
                    //首页弹框
                    case BannerPositionEnum.IndexPopupBox:
                        ret = await IndexPopBox(ret, ipo);
                        break;
                    //首页浮动窗口
                    case BannerPositionEnum.IndexFloatingWindow:
                        ret = await IndexFloatingWindow(ret, ipo);
                        break;
                    default: break;
                }

                result.Add((int)item, ret);
            }
        }
        return result;
    }

    private async Task<List<SCBannerDto>> GetCustomBanner(SCBannerIpo ipo, BannerPositionEnum position)
    {
        var bannerType = ipo.HasPay ? (int)BannerTypeEnum.RegisterPayed : (int)BannerTypeEnum.RegisterNoPay;

        var cahce = new SCBannerDCache(bannerType, ipo.AppId, ipo.OperatorId, ipo.LangId, (int)position);
        return await cahce.GetAsync(false);
    }

    /// <summary>
    /// 充值页banner
    /// </summary>
    /// <param name="bannerDtoList"></param>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private async Task<List<SCBannerDto>> PayBanner(List<SCBannerDto> bannerDtoList, SCBannerIpo ipo)
    {
        //获取l_activity_operator
        var operatorActivityEoList = await OperatorAcvitityUtil.GetOperatorActivity(ipo.OperatorId, ipo.CurrencyId, false);
        ipo.UserActivityEo = await DbUtil.SelectAsync<L_user_activityPO>(it => it.UserID.Equals(ipo.UserId));

        var ret = new List<SCBannerDto>();
        foreach (var item in bannerDtoList)
        {
            if (operatorActivityEoList.Any(d => d.Status && d.ActivityID == item.Code))
            {
                //当前活动已完成
                if (ipo.UserActivityEo.Any(d => d.ActivityId == item.Code && d.IsEnd))
                    continue;

                //如果l_user_activity不包含此活动
                //或包含此活动并且当前活动未完成时
                if (!ipo.UserActivityEo.Any(d => d.ActivityId == item.Code) || ipo.UserActivityEo.Any(d => d.ActivityId == item.Code && !d.IsEnd))
                {
                    ret.Add(item);
                    break;
                }
            }
        }
        return ret;
    }

    private async Task<List<SCBannerDto>> IndexPopBox(List<SCBannerDto> bannerDtoList, SCBannerIpo ipo)
    {
        var ret = new List<SCBannerDto>();

        ipo.LocalDate = ipo.UtcTime.ToLocalTime(ipo.OperatorId).Date;
        var bannerDayUser = new SCBannerDayUserDCache(ipo.UserId, (int)ipo.BannerType, ipo.AppId, ipo.OperatorId, ipo.LangId, (int)BannerPositionEnum.IndexPopupBox, ipo.LocalDate);
        ipo.IsDayFirstLoad = await bannerDayUser.GetAsync();
        ipo.BannerUserDCache = new SCBannerUserDCache(ipo.OperatorId, ipo.UserId);

        ipo.OperatorActivityEoList = await OperatorAcvitityUtil.GetOperatorActivity(ipo.OperatorId, ipo.CurrencyId, false);


        //先判断注册送奖励任务，如果开启返回这个任务奖励
        //var itemOperator = await DbUtil.GetRepository<Sat_item_operatorPO>()
        //     .GetFirstAsync(f => f.OperatorID == ipo.OperatorId && f.ItemID == (int)ActivityTypeEnum.RegisterRewardTask);

        //var myTask = await DbUtil.GetRepository<Sat_taskPO>()
        //    .GetFirstAsync(f => f.ItemID == (int)ActivityTypeEnum.RegisterRewardTask);

        var userIp = AspNetUtil.GetRemoteIpString();

        using (var client = DbUtil.GetDb())
        {
            if (ipo.UserMode != UserMode.Visitor && (ipo.UserActivityEo == null || !ipo.UserActivityEo.Any()))
            {
                ipo.UserActivityEo = await client.Queryable<L_user_activityPO>().Where(d => d.UserID.Equals(ipo.UserId)).ToListAsync();
            }

            //注册送活动逻辑
            if (ipo.UserMode == UserMode.Visitor && bannerDtoList.Any(d => d.Code == (int)ActivityTypeEnum.Register7)
                && ipo.OperatorActivityEoList.Any(d => d.Status && d.ActivityID == (int)ActivityTypeEnum.Register7))
            {
                //获取配置
                var field = Register7ConfigDCache.GetField(ipo.OperatorId, ipo.CurrencyId);
                var register7Config = await new Register7ConfigDCache().GetOrLoadAsync(field);

                if (register7Config.HasValue && register7Config.Value.IsSendBonus && !string.IsNullOrWhiteSpace(userIp))
                {
                    //当前ip是否送出了注册奖励
                    var exists = (await DbUtil.SelectAsync<Sa_ip_recordPO>(it =>
                            it.IpAddress.Equals(userIp) && it.OperatorID.Equals(ipo.OperatorId)
                            && it.CurrencyID.Equals(ipo.CurrencyId) && it.ActivityID == (int)ActivityTypeEnum.Register7)).Count;

                    if (exists < register7Config.Value.IPSendNum)
                    {
                        foreach (var item in bannerDtoList)
                        {
                            if (item.Code == (int)ActivityTypeEnum.Register7)
                            {
                                item.Tip = string.Format(item.LinkContent, register7Config.Value.SendBonus.AToM(ipo.CurrencyId));
                                item.LinkContent = item.Tip;
                            }
                        }
                    }
                    else
                        bannerDtoList = bannerDtoList.Where(d => d.Code != (int)ActivityTypeEnum.Register7).ToList();
                }
                else
                    bannerDtoList = bannerDtoList.Where(d => d.Code != (int)ActivityTypeEnum.Register7).ToList();

            }
        }

        var allItems = DbCachingUtil.GetAllList<Sat_itemPO>();
        foreach (var item in bannerDtoList)
        {
            var activityTypeEnum = item.Code.ToEnumN<ActivityTypeEnum>();
            if (activityTypeEnum.HasValue)
            {
                var myItem = allItems.Find(f => f.ItemID == item.Code);
                //活动有这个逻辑判断，任务跳过这个判断
                if (myItem?.Category == 1)
                {
                    if (!ipo.OperatorActivityEoList.Any(d => d.Status && d.ActivityID == item.Code))
                        continue;

                    //如果l_user_activity不包含此活动
                    //或包含此活动并且当前活动未完成时
                    if (!ipo.UserActivityEo.Any(d => d.ActivityId == item.Code)
                        || ipo.UserActivityEo.Any(d => d.ActivityId == item.Code && !d.IsEnd))
                    {
                        if (await IsShowBanner(item, ipo)) ret.Add(item);

                        continue;
                    }
                }
            }
            //非活动
            if (await IsShowBanner(item, ipo)) ret.Add(item);
        }

        await bannerDayUser.SetAsync();

        return ret;
    }

    /// <summary>
    /// 判断当前
    /// </summary>
    /// <param name="item"></param>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private async Task<bool> IsShowBanner(SCBannerDto item, SCBannerIpo ipo)
    {
        if (item.ShowDay == (int)BannerShowDayEnum.None && item.ShowInterval == 0) return true;

        //当前日期
        var currDate = ipo.UtcTime.ToLocalTime(ipo.OperatorId).Date;

        //当前日期，用户有没有看过banner
        var isShow = await ipo.BannerUserDCache.GetValueAsync<bool>($"{currDate.ToString("yyyyMMdd")}_{item.BannerID}");

        //没看过
        if (!isShow)
        {
            if (item.ShowDay == (int)BannerShowDayEnum.None)
            {
                var bannerExpireProcess = await BannerExpireProcess(item, ipo);

                if (bannerExpireProcess)
                    await ipo.BannerUserDCache.SetAsync($"{currDate.ToString("yyyyMMdd")}_{item.BannerID}", true, TimeSpan.FromHours(25));

                return bannerExpireProcess;
            }
            else if (item.ShowDay == (int)BannerShowDayEnum.First)
            {
                //更新缓存，用户已看过banner
                await ipo.BannerUserDCache.SetAsync($"{currDate.ToString("yyyyMMdd")}_{item.BannerID}", true, TimeSpan.FromHours(25));

                //更新缓存，用户查看banner的时间
                await ipo.BannerUserDCache.SetAsync(item.BannerID, ipo.UtcTime.AddMinutes(item.ShowInterval));
                return true;
            }
            else if (item.ShowDay == (int)BannerShowDayEnum.NotFirst)
            {
                if (!ipo.IsDayFirstLoad) return false;

                if (item.ShowInterval == 0) return true;

                var bannerExpireProcess = await BannerExpireProcess(item, ipo);

                if (bannerExpireProcess)
                    await ipo.BannerUserDCache.SetAsync($"{currDate.ToString("yyyyMMdd")}_{item.BannerID}", true, TimeSpan.FromHours(25));

                return bannerExpireProcess;
            }

            return false;
        }
        //已看过
        else
        {
            //banner只在当天首次显示
            if (item.ShowDay == (int)BannerShowDayEnum.First) return false;

            //如果当前banner未设置显示间隔，则显示
            if (item.ShowInterval == 0) return true;

            return await BannerExpireProcess(item, ipo);
        }
    }

    /// <summary>
    /// 计算banner显示间隔
    /// </summary>
    /// <param name="item"></param>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private async Task<bool> BannerExpireProcess(SCBannerDto item, SCBannerIpo ipo)
    {
        var expireTime = await ipo.BannerUserDCache.GetValueAsync<DateTime>(item.BannerID);
        if (expireTime == DateTime.MinValue || (expireTime != DateTime.MinValue && ipo.UtcTime > expireTime))
        {
            await ipo.BannerUserDCache.SetAsync(item.BannerID, ipo.UtcTime.AddMinutes(item.ShowInterval));
            return true;
        }
        return false;
    }

    /// <summary>
    /// 首页浮动窗口
    /// </summary>
    /// <param name="bannerDtoList"></param>
    /// <param name="ipo"></param>
    /// <returns></returns>
    private async Task<List<SCBannerDto>> IndexFloatingWindow(List<SCBannerDto> bannerDtoList, SCBannerIpo ipo)
    {
        var ret = new List<SCBannerDto>();

        ipo.OperatorActivityEoList = await OperatorAcvitityUtil.GetOperatorActivity(ipo.OperatorId, ipo.CurrencyId, false);

        if (ipo.UserMode == UserMode.Visitor) return ret;

        foreach (var item in bannerDtoList)
        {

            //有效活动
            if (ipo.OperatorActivityEoList.Any(d => d.Status && d.ActivityID == item.Code))
            {
                if (ipo.UserActivityEo.Any(d => d.ActivityId == item.Code && d.IsEnd)) continue;

                //如果l_user_activity不包含此活动
                //或包含此活动并且当前活动未完成时
                if (!ipo.UserActivityEo.Any(d => d.ActivityId == item.Code)
                    || ipo.UserActivityEo.Any(d => d.ActivityId == item.Code && !d.IsEnd))
                {
                    ret.Add(item);
                    continue;
                }
            }
            //非活动弹框
            ret.Add(item);
        }
        return ret;
    }
}
