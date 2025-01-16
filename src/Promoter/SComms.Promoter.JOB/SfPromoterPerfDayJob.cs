//using Microsoft.Extensions.Logging;
//using TinyFx.Data;
//using TinyFx.Logging;
//using Xxyy.Common;
//using Xxyy.Common.Caching;
//using Xxyy.SComms.Promoter.DAL;
//using DbCacheUtil = Xxyy.Quartz.BLL.Caching.DbCacheUtil;

//namespace Xxyy.Quartz.BLL.Services.SReport.PromoterWorker
//{
//    public class SfPromoterPerfDayJob : JobBase//ISRDayWorker
//    {
//        private OperatorDayContext _context;
//        private ILogger<SfPromoterPerfDayJob> _logger;
//        private const int BATCHCOUNT = 5000;
//        private readonly Sf_promoter_user_dayMO _sfPromoteruserDayMo = new();
//        private readonly Sf_promoter_iuser_dayMO _sfPromoterIuserDayMo = new();
//        private readonly Sf_promoter_ptype_dayMO _sfPromoterPtypeDayMo = new();
//        private readonly Sf_promoter_ptype_day_detailMO _sfPromoterPtypeDayDetailMo = new();
//        private readonly Sf_promoter_userMO _sfPromoterUserMo = new();
//        private Sf_promoter_configEO _promoterConfig;
        
//        private Xxyy.DAL.V_s_operatorEO _operatorEo;

//        public SfPromoterPerfDayJob()
//        {
//            _logger = LogUtil.CreateLogger<SfPromoterPerfDayJob>();
//        }


//        private void InitConfig(OperatorDayContext context)
//        {
//            this._context = context;
//            // _promoterConfig = DbCacheUtil.PromoterConfigDict().GetValueOrDefault(_context.OperatorId, null);
//            _promoterConfig = DbCacheUtil.GetPromoterConfig(_context.OperatorId);
//            if (null == _promoterConfig)
//                throw new Exception($"运营商:{_context.OperatorId}推广基础配置sc_promoter_configeo不存在！");
//            _operatorEo = Xxyy.Common.Caching.DbCacheUtil.GetOperator(_context.OperatorId);
//        }

//        public override async Task Execute(OperatorDayContext context)
//        {
//            try
//            {
//                _logger.LogInformation("开始执行SfPromoterPerfDayJob！dayid:{0},opeartorId:{1}",context.ReportDate,context.OperatorId);
//                InitConfig(context);
//                //执行逻辑
//                await DoJob();
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError(ex, "执行scpromoterperfdayjob.dojob异常！OperatorID:{0},reportdate:{1}", _context.OperatorId, _context.ReportDate);
//            }
//        }

//        private async Task DoJob()
//        {
//            //1.单用户结算周期内充值字典
//            var userPayDict = _context.BankOrderEos.Where(x => x.FromMode == 1).GroupBy(x => new { x.UserID, x.OrderType }).ToDictionary(x => string.Concat(x.Key.UserID, "|", x.Key.OrderType), x => x.Sum(_ => _.Amount));


//            //2.单用户下注返奖字典（isflowbonus是否统计bonus）
//            var userBetDict = _context.ProviderOrderEos.Where(x => x.FromMode == 1).Where(x => x.ReqMark != 4).GroupBy(x => x.UserID).ToDictionary(x => x.Key, x => new
//            {
//                Perf = _promoterConfig.HasBonusPerf ? x.Sum(_ => _.PlanBet) : x.Sum(_ => _.PlanBet - _.BetBonus),
//                Income = x.Sum(_ => _.Amount),
//                BetCashAmount = x.Sum(_ => _.PlanBet - _.BetBonus),
//                BetBonusAmount = x.Sum(_ => _.BetBonus),
//                WinBonusAmount = x.Sum(_ => _.WinBonus),
//                WinCashAmount = x.Sum(_ => _.PlanWin - _.WinBonus)
//            });
//            //有效的下注流水
//            var validEos = _context.ProviderOrderEos.Where(x => x.FromMode == 1).Where(x =>
//            {
//                return userBetDict.TryGetValue(x.UserID, out var v1) && v1.Perf >= _promoterConfig.CommMinPerf
//                 && userPayDict.TryGetValue(string.Concat(x.UserID, "|", 1), out var v2) && v2 >= _promoterConfig.CommMinDeposit;
//            });

//            var dict = new Dictionary<string, PromoterUserData>();
//            foreach (var eo in validEos)
//            {
//                var userDCache = await GlobalUserDCache.Create(eo.UserID);
//                //直属上级
//                var puserId1 = await userDCache.GetPUserID1Async();
//                if (string.IsNullOrWhiteSpace(puserId1))
//                    continue;
//                if (!dict.TryGetValue(puserId1, out var data))
//                {
//                    var puserId1DCache = await GlobalUserDCache.Create(puserId1);
//                    data = new PromoterUserData
//                    {
//                        UserId = puserId1,
//                        UserKind = (int)await puserId1DCache.GetUserKindAsync(),
//                        FromId = await puserId1DCache.GetFromIdAsync(),
//                        FromMode = await puserId1DCache.GetFromModeAsync()
//                    };
//                    dict.Add(puserId1, data);
//                }
//                if (!data.Details.TryGetValue(eo.UserID, out var subItem))
//                {
//                    subItem = new PromoterSub1Item();
//                    subItem.UserId = eo.UserID;
//                    subItem.RegistDate = await userDCache.GetRegistDateAsync();
//                    subItem.UserKind = eo.UserKind;
//                    subItem.FromMode = eo.FromMode;
//                    subItem.FromId = eo.FromId;
//                    data.Details.Add(eo.UserID, subItem);
//                }
//                subItem.Orders.Add(eo);
//                //2级上级
//                var puserId2 = await userDCache.GetPUserID2Async();
//                if (string.IsNullOrWhiteSpace(puserId2))
//                    continue;
//                if (!dict.TryGetValue(puserId2, out var data2))
//                {
//                    var puserId2DCache = await GlobalUserDCache.Create(puserId2);
//                    data2 = new PromoterUserData
//                    {
//                        UserId = puserId2,
//                        UserKind = (int)await puserId2DCache.GetUserKindAsync(),
//                        FromId = await puserId2DCache.GetFromIdAsync(),
//                        FromMode = await puserId2DCache.GetFromModeAsync()
//                    };
//                    dict.Add(puserId2, data2);
//                }
//                if (!data2.Details.TryGetValue(puserId1, out var subItem2))
//                {
//                    var puserId1DCache = await GlobalUserDCache.Create(puserId1);
//                    //var registerDate = await puserId1DCache.GetRegistDateAsync();
//                    subItem2 = new PromoterSub1Item
//                    {
//                        UserId = puserId1,
//                        RegistDate = await puserId1DCache.GetRegistDateAsync(),
//                        UserKind = (int)await puserId1DCache.GetUserKindAsync(),
//                        FromId = await puserId1DCache.GetFromIdAsync(),
//                        FromMode = await puserId1DCache.GetFromModeAsync()
//                    };
//                    data2.Details.Add(puserId1, subItem2);
//                }
//                if (!subItem2.SubOrders.TryGetValue(eo.UserID, out var subOrders))
//                {
//                    subOrders = new PromoterSub2Item
//                    {
//                        UserId = eo.UserID,
//                        UserKind = eo.UserKind,
//                        FromMode = eo.FromMode,
//                        FromId = eo.FromId
//                    };
//                    subItem2.SubOrders.Add(eo.UserID, subOrders);
//                }
//                subOrders.Orders.Add(eo);
//            }

//            //有效的充值流水
//            var validBankOrderEos = _context.BankOrderEos.Where(x => x.FromMode == 1).Where(x =>
//            {
//                return userBetDict.TryGetValue(x.UserID, out var v1) && v1.Perf >= _promoterConfig.CommMinPerf
//                 && userPayDict.TryGetValue(string.Concat(x.UserID, "|", 1), out var v2) && v2 >= _promoterConfig.CommMinDeposit;
//            });
//            foreach (var eo in validBankOrderEos)
//            {
//                var userDCache = await GlobalUserDCache.Create(eo.UserID);
//                //直属上级
//                var puserId1 = await userDCache.GetPUserID1Async();
//                if (string.IsNullOrWhiteSpace(puserId1))
//                    continue;
//                if (!dict.TryGetValue(puserId1, out var data))
//                {
//                    var puserId1DCache = await GlobalUserDCache.Create(puserId1);
//                    data = new PromoterUserData
//                    {
//                        UserId = puserId1,
//                        UserKind = (int)await puserId1DCache.GetUserKindAsync(),
//                        FromId = await puserId1DCache.GetFromIdAsync(),
//                        FromMode = await puserId1DCache.GetFromModeAsync()
//                    };
//                    dict.Add(puserId1, data);
//                }
//                if (!data.Details.TryGetValue(eo.UserID, out var subItem))
//                {
//                    subItem = new PromoterSub1Item();
//                    subItem.UserId = eo.UserID;
//                    subItem.RegistDate = await userDCache.GetRegistDateAsync();
//                    subItem.UserKind = eo.UserKind;
//                    subItem.FromMode = eo.FromMode;
//                    subItem.FromId = eo.FromId;
//                    data.Details.Add(eo.UserID, subItem);
//                }
//                subItem.BankOrders.Add(eo);
//                //2级上级
//                var puserId2 = await userDCache.GetPUserID2Async();
//                if (string.IsNullOrWhiteSpace(puserId2))
//                    continue;
//                if (!dict.TryGetValue(puserId2, out var data2))
//                {
//                    var puserId2DCache = await GlobalUserDCache.Create(puserId2);
//                    data2 = new PromoterUserData
//                    {
//                        UserId = puserId2,
//                        UserKind = (int)await puserId2DCache.GetUserKindAsync(),
//                        FromId = await puserId2DCache.GetFromIdAsync(),
//                        FromMode = await puserId2DCache.GetFromModeAsync()
//                    };
//                    dict.Add(puserId2, data2);
//                }
//                if (!data2.Details.TryGetValue(puserId1, out var subItem2))
//                {
//                    var puserId1DCache = await GlobalUserDCache.Create(puserId1);
//                    subItem2 = new PromoterSub1Item
//                    {
//                        UserId = puserId1,
//                        RegistDate = await puserId1DCache.GetRegistDateAsync(),
//                        UserKind = (int)await puserId1DCache.GetUserKindAsync(),
//                        FromId = await puserId1DCache.GetFromIdAsync(),
//                        FromMode = await puserId1DCache.GetFromModeAsync()
//                    };
//                    data2.Details.Add(puserId1, subItem2);
//                }
//                if (!subItem2.SubOrders.TryGetValue(eo.UserID, out var subOrders))
//                {
//                    subOrders = new PromoterSub2Item
//                    {
//                        UserId = eo.UserID,
//                        UserKind = eo.UserKind,
//                        FromMode = eo.FromMode,
//                        FromId = eo.FromId
//                    };
//                    subItem2.SubOrders.Add(eo.UserID, subOrders);
//                }
//                subOrders.BankOrders.Add(eo);
//            }

//            var perfResult = new List<Sf_promoter_iuser_dayEO>();
//            var commResult = new List<Sf_promoter_ptype_dayEO>();
//            var commDetailResult = new List<Sf_promoter_ptype_day_detailEO>();
//            var promoterUserResult = new List<Sf_promoter_userEO>();
//            var utcNow = DateTime.UtcNow;
//            foreach (var item in dict.Values)
//            {
//                //计算当前node分类累计流水
//                var totalProtomtertypePerf = GetProtomtertypePerfDict(item);
//                #region 获取当前node对应的comm_day_eo
//                //获取当前node对应的comm_day_eo
//                commResult.AddRange(totalProtomtertypePerf.Select(promoterTypePerf =>
//                {
//                    //根据当前分类级operatorid和业绩从缓存获取配置
//                    var p1PromoterCommConfig = DbCacheUtil.GetPromoterCommConfig(promoterTypePerf.Value, promoterTypePerf.Key, _context.OperatorId);

//                    //构造佣金Sc_promoter_comm_dayEO对象
//                    var promoterCommDayEo = new Sf_promoter_ptype_dayEO
//                    {
//                        DayID = _context.ReportDate.Date,
//                        UserID = item.UserId,
//                        OperatorID = _context.OperatorId,
//                        PromoterType = promoterTypePerf.Key,
//                        FromId = item.FromId,
//                        FromMode = item.FromMode,
//                        UserKind = item.UserKind,
//                        Perf = promoterTypePerf.Value,
//                        Contributors = item.Details.Count(p1 => p1.Value.Orders.Any(p1order => p1order.PromoterType == promoterTypePerf.Key)) + item.Details.Sum(p1 => p1.Value.SubOrders.Count(p2 => p2.Value.Orders.Any(p2order => p2order.PromoterType == promoterTypePerf.Key))),
//                        Comm = (long)((p1PromoterCommConfig.Comm * (item.Details.Sum(p1 => GetP1PromoterPerf(p1, promoterTypePerf.Key))) +
//                        item.Details.Sum(p1 => GetP2PromoterCommon(p1, promoterTypePerf.Key, p1PromoterCommConfig.Comm))
//                        )),
//                        RecDate = utcNow
//                    };

//                    return promoterCommDayEo;
//                }));
//                #endregion

//                #region 获取当前node对应的佣金明细comm_detail_eo
//                //获取当前node对应的佣金明细comm_detail_eo
//                commDetailResult.AddRange(totalProtomtertypePerf.SelectMany(promoterTypePerf =>
//                {
//                    //根据当前分类级operatorid和业绩从缓存获取配置
//                    var p1PromoterCommConfig = DbCacheUtil.GetPromoterCommConfig(promoterTypePerf.Value, promoterTypePerf.Key, _context.OperatorId);
//                    //直属下级贡献的佣金明细
//                    var p1DirectPromoterDetails = item.Details.Select(p1 =>
//                    {
//                        var p1Perf = GetP1PromoterPerf(p1, promoterTypePerf.Key);
//                        return new Sf_promoter_ptype_day_detailEO
//                        {
//                            DayID = _context.ReportDate.Date,
//                            UserID = item.UserId,
//                            PromoterType = promoterTypePerf.Key,
//                            IUserID = p1.Key,
//                            OperatorID = _context.OperatorId,
//                            FromMode = p1.Value.FromMode,
//                            FromId = p1.Value.FromId,
//                            UserKind = p1.Value.UserKind,
//                            IsDirect = true,
//                            Perf = p1Perf,
//                            Comm = (long)(p1PromoterCommConfig.Comm * p1Perf),
//                            RecDate = utcNow
//                        };
//                    }) ?? new List<Sf_promoter_ptype_day_detailEO>();

//                    //2级贡献的佣金明细
//                    var p2PromoterDetails = item.Details.SelectMany(o1 =>
//                    {
//                        //2级代理累计业绩
//                        var p2PromoterTotalPerf = GetP2PromoterPerf(o1, promoterTypePerf.Key);
//                        //2级代理累计业绩对应的返佣比例
//                        var p2PromoterCommConfig = DbCacheUtil.GetPromoterCommConfig(p2PromoterTotalPerf, promoterTypePerf.Key, _context.OperatorId);
//                        //每一个2级代理贡献的佣金明细
//                        return o1.Value.SubOrders.Select(o2 =>
//                        {
//                            var currentO2Perf = GetP2PromoterPerf(o2, promoterTypePerf.Key);
//                            var currentO2Comm = (long)((p1PromoterCommConfig.Comm - p2PromoterCommConfig.Comm) *currentO2Perf);
//                            return new Sf_promoter_ptype_day_detailEO
//                            {
//                                DayID = _context.ReportDate.Date,
//                                UserID = item.UserId,
//                                PromoterType = promoterTypePerf.Key,
//                                IUserID = o2.Key,
//                                OperatorID = _context.OperatorId,
//                                FromMode = o2.Value.FromMode,
//                                FromId = o2.Value.FromId,
//                                UserKind = o2.Value.UserKind,
//                                IsDirect = false,
//                                Perf = currentO2Perf,
//                                Comm = currentO2Comm < 0 ? 0 : currentO2Comm,
//                                RecDate = utcNow
//                            };
//                        });
//                    }) ?? new List<Sf_promoter_ptype_day_detailEO>();
//                    //合并1级代理和2级代理并返回
//                    return p1DirectPromoterDetails.Concat(p2PromoterDetails);
//                }));
//                #endregion

//                #region 获取业绩perf_day_eo
//                //获取业绩perf_day_eo
//                perfResult.AddRange(item.Details.Select(o1 =>
//                {
//                    //汇总每个分类的佣金
//                    var itemTotalComm = totalProtomtertypePerf.Sum(x =>
//                    {
//                        //根据当前分类及operatorid和业绩从缓存获取配置
//                        var p1PromoterCommConfig = DbCacheUtil.GetPromoterCommConfig(x.Value, x.Key, _context.OperatorId);

//                        //1级代理业绩
//                        var p1TotalPerf = GetP1PromoterPerf(o1, x.Key);
//                        //2级代理佣金
//                        var p2PromoterComm = GetP2PromoterCommon(o1, x.Key, p1PromoterCommConfig.Comm);

//                        //1级分类佣金+2级分类佣金
//                        return (long)(p1PromoterCommConfig.Comm * p1TotalPerf) + p2PromoterComm;
//                    });
//                    var hasUserBet = userBetDict.TryGetValue(o1.Key, out var IUserBet);
//                    var promoterPerfDayEo = new Sf_promoter_iuser_dayEO
//                    {
//                        DayID = _context.ReportDate.Date,
//                        UserID = item.UserId,
//                        IUserID = o1.Key,
//                        OperatorID = _context.OperatorId,
//                        FromMode = o1.Value.FromMode,
//                        FromId = o1.Value.FromId,
//                        UserKind = o1.Value.UserKind,
//                        PromoteTime = o1.Value.RegistDate.Value,
//                        DirectNum = o1.Value.SubOrders.Count,
//                        Perf = o1.Value.Orders.Sum(o => GetBetAmount(o)) + o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Sum(o => GetBetAmount(o))),
//                        ContributionComm = itemTotalComm,
//                        Income = hasUserBet ? IUserBet.Income : 0,
//                        DepositAmount = userPayDict.GetValueOrDefault(string.Concat(o1.Key, "|", 1), 0),
//                        CashAmount = userPayDict.GetValueOrDefault(string.Concat(o1.Key, "|", 2), 0),
//                        BetCashAmount = hasUserBet ? IUserBet.BetCashAmount : 0,
//                        WinCashAmount = hasUserBet ? IUserBet.WinCashAmount : 0,
//                        BetBonusAmount = hasUserBet ? IUserBet.BetBonusAmount : 0,
//                        WinBonusAmount = hasUserBet ? IUserBet.WinBonusAmount : 0,
//                        OtherDepositAmount = o1.Value.SubOrders.Sum(o2 => o2.Value.BankOrders.Where(x => x.OrderType == 1).Sum(o => o.Amount)),
//                        OtherCashAmount = o1.Value.SubOrders.Sum(o2 => o2.Value.BankOrders.Where(x => x.OrderType == 2).Sum(o => o.Amount)),
//                        OtherBetBonusAmount = o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Sum(o => o.BetBonus)),
//                        OtherBetCashAmount = o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Sum(o => o.PlanBet - o.BetBonus)),
//                        OtherWinBonusAmount = o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Sum(o => o.WinBonus)),
//                        OtherWinCashAmount = o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Sum(o => o.PlanWin - o.WinBonus)),
//                        RecDate = utcNow
//                    };
//                    return promoterPerfDayEo;
//                }));
//                #endregion

//                #region 获取推广用户累计佣金和业绩
//                //直属业绩
//                var directPerf = item.Details.Sum(p1 => p1.Value.Orders.Sum(p1order => GetBetAmount(p1order)));
//                //其他业绩
//                var otherPerf = item.Details.Sum(p1 => p1.Value.SubOrders.Sum(p2 => p2.Value.Orders.Sum(p2order => GetBetAmount(p2order))));

//                //当前推广用户在每个分类下的佣金汇总
//                var itemTotalComm = (long)totalProtomtertypePerf.Sum(promoterTypePerf =>
//                {
//                    //根据当前分类级operatorid和业绩从缓存获取配置
//                    var p1PromoterCommConfig = DbCacheUtil.GetPromoterCommConfig(promoterTypePerf.Value, promoterTypePerf.Key, _context.OperatorId);
//                    return (p1PromoterCommConfig.Comm * (item.Details.Sum(p1 => GetP1PromoterPerf(p1, promoterTypePerf.Key))) +
//                        item.Details.Sum(p1 => GetP2PromoterCommon(p1, promoterTypePerf.Key, p1PromoterCommConfig.Comm))
//                        );
//                });
//                //var totalPerf = directPerf + otherPerf;
//                //var promoterVipConfig = DbCacheUtil.GetPromoterVipConfig(totalPerf,_context.OperatorId);
//                //构造每个推广用户的Sc_promoter_userEO
//                //获取直属代理eo列表
//                var directUserPromoterEos = await GetNewSubEos(item.UserId);
//                //汇总其他代理人员
//                var otherSubNum = directUserPromoterEos.Any() ? (await Task.WhenAll(directUserPromoterEos.Select(async x => await GetNewSubNum(x.IUserID)))).Sum() : 0;
//                promoterUserResult.Add(new Sf_promoter_userEO
//                {
//                    UserID = item.UserId,
//                    OperatorID = _context.OperatorId,
//                    FromMode = item.FromMode,
//                    FromId = item.FromId,
//                    UserKind = item.UserKind,
//                    PUrl = $"uid={item.UserId}",
//                    PLevel = 0, //promoterVipConfig.PLevel,// todo insert or update(累计)
//                    TotalComm = itemTotalComm,//todo insert or update(累计)
//                                              //CurrentComm = itemTotalComm,//todo insert or update（累计）
//                    LastComm = 0,//todo insert
//                    DirectNum = directUserPromoterEos.Count,
//                    OtherNum = otherSubNum,
//                    TotalPerf = directPerf + otherPerf,
//                    DirectPerf = directPerf,
//                    OtherPerf = otherPerf,
//                    DepositNum=item.Details.Sum(o1=> o1.Value.BankOrders.Where(o => o.OrderType == 1).Select(o => o.UserID).Distinct().Count()),
//                    DepositAmount = item.Details.Sum(o1 => o1.Value.BankOrders.Where(o => o.OrderType == 1).Sum(o => o.Amount)),
//                    CashNum = item.Details.Sum(o1 => o1.Value.BankOrders.Where(o => o.OrderType == 2).Select(o => o.UserID).Distinct().Count()),
//                    CashAmount = item.Details.Sum(o1 => o1.Value.BankOrders.Where(o => o.OrderType == 2).Sum(o => o.Amount)),
//                    BetNum= item.Details.Sum(o1 => o1.Value.Orders.Where(o => o.ReqMark==1||o.ReqMark==3).Select(o => o.UserID).Distinct().Count()),
//                    BetCashAmount = item.Details.Sum(o1 => o1.Value.Orders.Sum(o => o.PlanBet - o.BetBonus)),
//                    WinCashAmount = item.Details.Sum(o1 => o1.Value.Orders.Sum(o => o.PlanWin - o.WinBonus)),
//                    BetBonusAmount = item.Details.Sum(o1 => o1.Value.Orders.Sum(o => o.BetBonus)),
//                    WinBonusAmount = item.Details.Sum(o1 => o1.Value.Orders.Sum(o => o.WinBonus)),
//                    OtherDepositNum= item.Details.Sum(o1 => o1.Value.SubOrders.Sum(o2 => o2.Value.BankOrders.Where(o => o.OrderType == 1).Select(o => o.UserID).Distinct().Count())),
//                    OtherDepositAmount = item.Details.Sum(o1 => o1.Value.SubOrders.Sum(o2 => o2.Value.BankOrders.Where(o => o.OrderType == 1).Sum(o => o.Amount))),
//                    OtherCashNum= item.Details.Sum(o1 => o1.Value.SubOrders.Sum(o2 => o2.Value.BankOrders.Where(o => o.OrderType == 2).Select(o => o.UserID).Distinct().Count())),
//                    OtherCashAmount = item.Details.Sum(o1 => o1.Value.SubOrders.Sum(o2 => o2.Value.BankOrders.Where(o => o.OrderType == 2).Sum(o => o.Amount))),
//                    OtherBetNum= item.Details.Sum(o1 => o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Where(o => o.ReqMark == 1||o.ReqMark==3).Select(o => o.UserID).Distinct().Count())),
//                    OtherBetCashAmount = item.Details.Sum(o1 => o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Sum(o => o.PlanBet - o.BetBonus))),
//                    OtherWinCashAmount = item.Details.Sum(o1 => o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Sum(o => o.PlanWin - o.WinBonus))),
//                    OtherBetBonusAmount = item.Details.Sum(o1 => o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Sum(o => o.BetBonus))),
//                    OtherWinBonusAmount = item.Details.Sum(o1 => o1.Value.SubOrders.Sum(o2 => o2.Value.Orders.Sum(o => o.WinBonus))),
//                    LastUpdateTime = utcNow,
//                    RecDate = utcNow
//                });
//                #endregion
//            }
//            //add
//            var tm = new TransactionManager(System.Data.IsolationLevel.RepeatableRead);
//            try
//            {
//                //每日业绩
//                var rows = await _sfPromoterIuserDayMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm, _context.ReportDate.Date, _context.OperatorId);
//                if (perfResult.Any())
//                    rows = await _sfPromoterIuserDayMo.AddByBatchAsync(perfResult, BATCHCOUNT, tm);
//                //每日佣金
//                rows = await _sfPromoterPtypeDayMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm, _context.ReportDate.Date, _context.OperatorId);
//                if (commResult.Any())
//                    rows = await _sfPromoterPtypeDayMo.AddByBatchAsync(commResult, BATCHCOUNT, tm);
//                //每日佣金明细
//                rows = await _sfPromoterPtypeDayDetailMo.RemoveAsync("DayID=@DayID and OperatorID=@OperatorID", tm, _context.ReportDate.Date, _context.OperatorId);
//                if (commDetailResult.Any())
//                    rows = await _sfPromoterPtypeDayDetailMo.AddByBatchAsync(commDetailResult, BATCHCOUNT, tm);

//                //获取指定天变化量的集合
//                var promoterUserDayEos = await GetPromoterUserDayEosByDay(tm);
//                if (null != promoterUserDayEos && promoterUserDayEos.Any())
//                {
//                    foreach (var pUserDayEo in promoterUserDayEos)
//                    {
//                        var promoterUserEo = await _sfPromoterUserMo.GetByPKAsync(pUserDayEo.UserID, tm);
//                        if (null == promoterUserEo)
//                            continue;
//                        promoterUserEo.TotalComm -= pUserDayEo.TotalComm;
//                        promoterUserEo.DirectNum -= pUserDayEo.DirectNum;
//                        promoterUserEo.OtherNum -= pUserDayEo.OtherNum;
//                        promoterUserEo.TotalPerf -= pUserDayEo.TotalPerf;
//                        promoterUserEo.DirectPerf -= pUserDayEo.DirectPerf;
//                        promoterUserEo.OtherPerf -= pUserDayEo.OtherPerf;
//                        promoterUserEo.DepositNum -= pUserDayEo.DepositNum;
//                        promoterUserEo.DepositAmount -= pUserDayEo.DepositAmount;
//                        promoterUserEo.CashNum -= pUserDayEo.CashNum;
//                        promoterUserEo.CashAmount -= pUserDayEo.CashAmount;
//                        promoterUserEo.BetNum -= pUserDayEo.BetNum;
//                        promoterUserEo.BetCashAmount -= pUserDayEo.BetCashAmount;
//                        promoterUserEo.WinCashAmount -= pUserDayEo.WinCashAmount;
//                        promoterUserEo.BetBonusAmount -= pUserDayEo.BetBonusAmount;
//                        promoterUserEo.WinBonusAmount -= pUserDayEo.WinBonusAmount;
//                        promoterUserEo.OtherDepositNum -= pUserDayEo.OtherDepositNum;
//                        promoterUserEo.OtherDepositAmount -= pUserDayEo.OtherDepositAmount;
//                        promoterUserEo.OtherCashNum -= pUserDayEo.OtherCashNum;
//                        promoterUserEo.OtherCashAmount -= pUserDayEo.OtherCashAmount;
//                        promoterUserEo.OtherBetNum -= pUserDayEo.OtherBetNum;
//                        promoterUserEo.OtherBetCashAmount -= pUserDayEo.OtherBetCashAmount;
//                        promoterUserEo.OtherWinCashAmount -= pUserDayEo.OtherWinCashAmount;
//                        promoterUserEo.OtherBetBonusAmount -= pUserDayEo.OtherBetBonusAmount;
//                        promoterUserEo.OtherWinBonusAmount -= pUserDayEo.OtherWinBonusAmount;
//                        var sfPromoterVipEo = DbCacheUtil.GetPromoterVipConfig(promoterUserEo.TotalPerf, _context.OperatorId);
//                        promoterUserEo.PLevel = sfPromoterVipEo.PLevel;
//                        promoterUserEo.LastUpdateTime = utcNow;
//                        rows = await _sfPromoterUserMo.PutAsync(promoterUserEo,tm);
//                    }
//                    foreach (var item in promoterUserDayEos)
//                    {
//                        rows = await _sfPromoteruserDayMo.RemoveAsync(item, tm);
//                    }
//                }

//                //遍历promoterUserResult并保存(直接插入已存在则更新)
//                if (promoterUserResult.Any())
//                {
//                    Sf_promoter_userEO promoterUserEo = null;
//                    Sf_promoter_vipEO sfPromoterVipEo = null;
//                    foreach (var item in promoterUserResult)
//                    {
//                        promoterUserEo = await _sfPromoterUserMo.GetByPKAsync(item.UserID, tm);
//                        if (promoterUserEo == null)
//                        {
//                            sfPromoterVipEo = DbCacheUtil.GetPromoterVipConfig(item.TotalPerf, _context.OperatorId);
//                            item.PLevel = sfPromoterVipEo.PLevel;
//                            promoterUserEo = item;
//                            rows = await _sfPromoterUserMo.AddAsync(promoterUserEo, tm);
//                        }
//                        else
//                        {
//                            promoterUserEo.FromId = item.FromId;
//                            promoterUserEo.FromMode = item.FromMode;
//                            promoterUserEo.UserKind = item.UserKind;
//                            promoterUserEo.TotalComm += item.TotalComm;
//                            promoterUserEo.DirectNum += item.DirectNum;
//                            promoterUserEo.OtherNum += item.OtherNum;
//                            promoterUserEo.TotalPerf += item.TotalPerf;
//                            promoterUserEo.DirectPerf += item.DirectPerf;
//                            promoterUserEo.OtherPerf += item.OtherPerf;
//                            promoterUserEo.DepositNum += item.DepositNum;
//                            promoterUserEo.DepositAmount += item.DepositAmount;
//                            promoterUserEo.CashNum += item.CashNum;
//                            promoterUserEo.CashAmount += item.CashAmount;
//                            promoterUserEo.BetNum += item.BetNum;
//                            promoterUserEo.BetCashAmount += item.BetCashAmount;
//                            promoterUserEo.WinCashAmount += item.WinCashAmount;
//                            promoterUserEo.BetBonusAmount += item.BetBonusAmount;
//                            promoterUserEo.WinBonusAmount += item.WinBonusAmount;
//                            promoterUserEo.OtherDepositNum += item.OtherDepositNum;
//                            promoterUserEo.OtherDepositAmount += item.OtherDepositAmount;
//                            promoterUserEo.OtherCashNum += item.OtherCashNum;
//                            promoterUserEo.OtherCashAmount += item.OtherCashAmount;
//                            promoterUserEo.OtherBetNum += item.OtherBetNum;
//                            promoterUserEo.OtherBetCashAmount += item.OtherBetCashAmount;
//                            promoterUserEo.OtherWinCashAmount += item.OtherWinCashAmount;
//                            promoterUserEo.OtherBetBonusAmount += item.OtherBetBonusAmount;
//                            promoterUserEo.OtherWinBonusAmount += item.OtherWinBonusAmount;
//                            sfPromoterVipEo = DbCacheUtil.GetPromoterVipConfig(promoterUserEo.TotalPerf, _context.OperatorId);
//                            promoterUserEo.PLevel = sfPromoterVipEo.PLevel;
//                            promoterUserEo.LastUpdateTime = utcNow;
//                            rows = await _sfPromoterUserMo.PutAsync(promoterUserEo, tm);
//                        }
//                    }
//                    //添加promoter_user_dayeo
//                    rows = await _sfPromoteruserDayMo.AddByBatchAsync(promoterUserResult.Select(x =>
//                    {
//                        return new Sf_promoter_user_dayEO
//                        {
//                            DayID = _context.ReportDate,
//                            UserID = x.UserID,
//                            OperatorID = _context.OperatorId,
//                            FromMode = x.FromMode,
//                            FromId = x.FromId,
//                            UserKind = x.UserKind,
//                            TotalComm = x.TotalComm,
//                            DirectNum = x.DirectNum,
//                            OtherNum = x.OtherNum,
//                            TotalPerf = x.TotalPerf,
//                            DirectPerf = x.DirectPerf,
//                            OtherPerf = x.OtherPerf,
//                            DepositNum=x.DepositNum,
//                            DepositAmount = x.DepositAmount,
//                            CashNum=x.CashNum,
//                            CashAmount = x.CashAmount,
//                            BetNum=x.BetNum,
//                            BetCashAmount = x.BetCashAmount,
//                            WinCashAmount = x.WinCashAmount,
//                            BetBonusAmount = x.BetBonusAmount,
//                            WinBonusAmount = x.WinBonusAmount,
//                            OtherDepositNum=x.OtherDepositNum,
//                            OtherDepositAmount = x.OtherDepositAmount,
//                            OtherCashNum=x.OtherCashNum,
//                            OtherCashAmount = x.OtherCashAmount,
//                            OtherBetNum=x.OtherBetNum,
//                            OtherBetCashAmount = x.OtherBetCashAmount,
//                            OtherWinCashAmount = x.OtherWinCashAmount,
//                            OtherBetBonusAmount = x.OtherBetBonusAmount,
//                            OtherWinBonusAmount = x.OtherWinBonusAmount,
//                            RecDate = utcNow
//                        };
//                    }), BATCHCOUNT, tm);
//                }
//                else
//                {
//                    rows = await _sfPromoteruserDayMo.AddAsync(new Sf_promoter_user_dayEO { 
//                     DayID= _context.ReportDate,
//                     UserID="test",
//                     OperatorID= _context.OperatorId,
//                     RecDate=utcNow
//                    });
//                }
//                tm.Commit();
//            }
//            catch (Exception ex)
//            {
//                tm.Rollback();
//                _logger.LogError(ex, "执行scpromoterperfdayjob异常！OperatorID:{0},reportdate:{1}", _context.OperatorId, _context.ReportDate);
//            }
//        }



//        /// <summary>
//        /// 获取运营商指定某天的变化量的集合
//        /// </summary>
//        /// <returns></returns>
//        private async Task<List<Sf_promoter_user_dayEO>> GetPromoterUserDayEosByDay(TransactionManager tm)
//        {
//            return await _sfPromoteruserDayMo.GetAsync($"DayID=@dayid and OperatorID=@OperatorID", tm, _context.ReportDate, _context.OperatorId);
//        }


//        /// <summary>
//        /// 查询推广员userId下_context.reportdate新增的推广人数
//        /// </summary>
//        /// <param name="userId"></param>
//        /// <returns></returns>
//        private async Task<int> GetNewSubNum(string userId)
//        {
//            var sUserPromoterMo = DbSink.BuildUserPromoterMo(userId);

//            var utcStartTime = _context.ReportDate.ToUtcTime(_context.OperatorId);
//            var utcEndTime = _context.ReportDate.AddDays(1).ToUtcTime(_context.OperatorId);

//            return await DbSink.MainDb.ExecSqlScalarAsync<int>($"select count(1) from {sUserPromoterMo.TableName} where PUserID=@PUserID and PromoteTime>=@start and PromoteTime<@end and frommode=1", userId, utcStartTime, utcEndTime);
//        }

//        /// <summary>
//        /// 查询推广员userId下_context.reportdate新增的推广人数
//        /// </summary>
//        /// <param name="userId"></param>
//        /// <returns></returns>
//        private async Task<List<Xxyy.DAL.S_user_promoterEO>> GetNewSubEos(string userId)
//        {
//            var sUserPromoterMo = DbSink.BuildUserPromoterMo(userId);

//            var utcStartTime = _context.ReportDate.ToUtcTime(_context.OperatorId);
//            var utcEndTime = _context.ReportDate.AddDays(1).ToUtcTime(_context.OperatorId);

//            return (await sUserPromoterMo.GetAsync("PUserID=@PUserID and PromoteTime>=@start and PromoteTime<@end and frommode=1", userId, utcStartTime, utcEndTime)) ?? new List<Xxyy.DAL.S_user_promoterEO>();
//        }

//        private long GetBetAmount(Xxyy.DAL.S_provider_orderEO order)
//        {
//            if (_promoterConfig.HasBonusPerf)
//            {
//                return order.PlanBet;
//            }
//            return order.PlanBet - order.BetBonus;
//        }

//        /// <summary>
//        /// 1级直属代理的业绩
//        /// </summary>
//        /// <param name="o1"></param>
//        /// <returns></returns>
//        private long GetP1PromoterPerf(KeyValuePair<string, PromoterSub1Item> o1, int promoterType) => o1.Value.Orders.Where(_ => _.PromoterType == promoterType).Sum(p1order => GetBetAmount(p1order));

//        /// <summary>
//        /// 获取1级代理下的2级代理的业绩
//        /// </summary>
//        /// <param name="o1"></param>
//        /// <param name="promoterType"></param>
//        /// <returns></returns>
//        private long GetP2PromoterPerf(KeyValuePair<string, PromoterSub1Item> o1, int promoterType) => o1.Value.SubOrders.Sum(p2 => p2.Value.Orders.Where(p2order => p2order.PromoterType == promoterType).Sum(p2order => GetBetAmount(p2order)));

//        /// <summary>
//        /// 获取当前2级代理的业绩
//        /// </summary>
//        /// <param name="o1"></param>
//        /// <param name="promoterType"></param>
//        /// <returns></returns>
//        private long GetP2PromoterPerf(KeyValuePair<string, PromoterSub2Item> o2, int promoterType) => o2.Value.Orders.Where(p2order => p2order.PromoterType == promoterType).Sum(p2order => GetBetAmount(p2order));

//        /// <summary>
//        /// 2级代理所贡献的佣金
//        /// </summary>
//        /// <param name="o1">1级代理</param>
//        /// <param name="promoterType">佣金分类</param>
//        /// <param name="p1PromoterConfigComm">1级代理相应分类的业绩所对应的佣金比例</param>
//        /// <returns></returns>
//        private long GetP2PromoterCommon(KeyValuePair<string, PromoterSub1Item> o1, int promoterType, double p1PromoterConfigComm)
//        {
//            //2级代理的业绩
//            var p2PromoterTotalPerf = GetP2PromoterPerf(o1, promoterType);

//            //2级代理业绩对应的返佣比例
//            var p2PromoterCommConfig = DbCacheUtil.GetPromoterCommConfig(p2PromoterTotalPerf, promoterType, _context.OperatorId);

//            var p2PromoterComm = (long)((p1PromoterConfigComm - p2PromoterCommConfig.Comm) * p2PromoterTotalPerf);
//            return p2PromoterComm < 0 ? 0 : p2PromoterComm;
//        }

//        /// <summary>
//        /// 当前推广员item的1级和2级分类累计流水
//        /// </summary>
//        /// <param name="item"></param>
//        /// <returns></returns>
//        private Dictionary<int, long> GetProtomtertypePerfDict(PromoterUserData item)
//        {
//            //计算当前node累计流水
//            return item.Details.SelectMany(p1 =>
//            {
//                var p1orders = p1.Value.Orders ?? new List<Xxyy.DAL.S_provider_orderEO>();
//                var p2orders = p1.Value.SubOrders.SelectMany(p2 => p2.Value.Orders) ?? new List<Xxyy.DAL.S_provider_orderEO>();
//                return p1orders.Concat(p2orders);
//            }).GroupBy(x => x.PromoterType).ToDictionary(x => x.Key, x => x.Sum(o => GetBetAmount(o)));
//        }

//        /// <summary>
//        /// 获取运营商指定某天的最大dayId
//        /// </summary>
//        /// <returns></returns>
//        protected override async Task<DateTime?> GetMaxDayId(string operatorId)
//        {
//            var maxDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_sfPromoteruserDayMo.TableName} where OperatorID=@OperatorID order by DayID desc limit 1", operatorId);
//            return maxDayId;
//        }

//        protected override async Task<DateTime?> GetMinDayId(string operatorId)
//        {
//            var minDayId = await DbSink.MainDb.ExecSqlScalarAsync<DateTime?>($"select DayID from {_sfPromoteruserDayMo.TableName} where OperatorID=@OperatorID order by DayID asc limit 1", operatorId);
//            return minDayId;
//        }
//    }
//}
