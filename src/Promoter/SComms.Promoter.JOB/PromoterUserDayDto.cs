//using System.Runtime.Serialization;
//using TinyFx.Extensions.AutoMapper;
//using Xxyy.SComms.Promoter.DAL;

//namespace Xxyy.Quartz.BLL.Services.SReport.PromoterWorker
//{
//    public class PromoterUserDayDto : IMapTo<Sf_promoter_userEO>
//    {
//        #region 所有字段
//        /// <summary>
//        /// 用户编码
//        /// 【主键 varchar(38)】
//        /// </summary>
//        [DataMember(Order = 1)]
//        public string UserID { get; set; }

//        /// <summary>
//        /// 运营商编码
//        /// 【字段 varchar(50)】
//        /// </summary>
//        [DataMember(Order = 2)]
//        public string OperatorID { get; set; }

//        /// <summary>
//        /// 新用户来源方式
//        ///              0-获得运营商的新用户(s_operator)
//        ///              1-推广员获得的新用户（userid）
//        ///              2-推广渠道通过url获得的新用户（s_channel_url)
//        ///              3-推广渠道通过code获得的新用户（s_channel_code)
//        /// 【字段 int】
//        /// </summary>
//        [DataMember(Order = 3)]
//        public int FromMode { get; set; }

//        /// <summary>
//        /// 对应的编码（根据FromMode变化）
//        ///              FromMode=
//        ///              0-运营商的新用户(s_operator)==> OperatorID
//        ///              1-推广员获得的新用户（userid） ==> 邀请人的UserID
//        ///              2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
//        ///              3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
//        /// 【字段 varchar(100)】
//        /// </summary>
//        [DataMember(Order = 4)]
//        public string FromId { get; set; }

//        /// <summary>
//        /// 用户类型
//        /// 【字段 int】
//        /// </summary>
//        [DataMember(Order = 5)]
//        public int UserKind { get; set; }

//        /// <summary>
//        /// 推广链接
//        /// 【字段 varchar(255)】
//        /// </summary>
//        [DataMember(Order = 6)]
//        public string PUrl { get; set; }

//        /// <summary>
//        /// 推广员级别
//        /// 【字段 int】
//        /// </summary>
//        [DataMember(Order = 7)]
//        public int PLevel { get; set; }

//        /// <summary>
//        /// 累计佣金
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 8)]
//        public long TotalComm { get; set; }

//        /// <summary>
//        /// 已取佣金
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 9)]
//        public long CollectComm { get; set; }

//        /// <summary>
//        /// 上次领取的佣金
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 10)]
//        public long LastComm { get; set; }

//        /// <summary>
//        /// 直属人数
//        /// 【字段 int】
//        /// </summary>
//        [DataMember(Order = 11)]
//        public int DirectNum { get; set; }

//        /// <summary>
//        /// 其他人数
//        /// 【字段 int】
//        /// </summary>
//        [DataMember(Order = 12)]
//        public int OtherNum { get; set; }

//        /// <summary>
//        /// 总业绩（流水）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 13)]
//        public long TotalPerf { get; set; }

//        /// <summary>
//        /// 直属业绩
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 14)]
//        public long DirectPerf { get; set; }

//        /// <summary>
//        /// 其他业绩
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 15)]
//        public long OtherPerf { get; set; }

//        //充值人数（直属）
//        public int DepositNum { get; set; }

//        /// <summary>
//        /// 充值（被邀请人）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 16)]
//        public long DepositAmount { get; set; }

//        /// <summary>
//        /// 提现人数（直属）
//        /// </summary>
//        public int CashNum { get; set; }

//        /// <summary>
//        /// 提现（被邀请人）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 17)]
//        public long CashAmount { get; set; }

//        /// <summary>
//        /// 下注人数（直属）
//        /// </summary>
//        public int BetNum { get; set; }

//        /// <summary>
//        /// 下注真金（被邀请人）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 18)]
//        public long BetCashAmount { get; set; }
//        /// <summary>
//        /// 返奖真金（被邀请人）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 19)]
//        public long WinCashAmount { get; set; }
//        /// <summary>
//        /// 下注bonus（被邀请人）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 20)]
//        public long BetBonusAmount { get; set; }
//        /// <summary>
//        /// 返奖bonus（被邀请人）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 21)]
//        public long WinBonusAmount { get; set; }

//        /// <summary>
//        /// 充值人数（其下级）
//        /// </summary>
//        public int OtherDepositNum { get; set; }

//        /// <summary>
//        /// 充值（其下级）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 22)]
//        public long OtherDepositAmount { get; set; }

//        /// <summary>
//        /// 提现人数（其下级）
//        /// </summary>
//        public int OtherCashNum { get; set; }

//        /// <summary>
//        /// 提现（其下级）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 23)]
//        public long OtherCashAmount { get; set; }

//        /// <summary>
//        /// 下注人数（其下级）
//        /// </summary>
//        public int OtherBetNum { get; set; }

//        /// <summary>
//        /// 下注真金（其下级）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 24)]
//        public long OtherBetCashAmount { get; set; }
//        /// <summary>
//        /// 返奖真金（其下级）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 25)]
//        public long OtherWinCashAmount { get; set; }
//        /// <summary>
//        /// 下注bonus（其下级）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 26)]
//        public long OtherBetBonusAmount { get; set; }
//        /// <summary>
//        /// 返奖bonus（其下级）
//        /// 【字段 bigint】
//        /// </summary>
//        [DataMember(Order = 27)]
//        public long OtherWinBonusAmount { get; set; }
//        /// <summary>
//        /// 最后一次更新时间
//        /// 【字段 datetime】
//        /// </summary>
//        [DataMember(Order = 28)]
//        public DateTime LastUpdateTime { get; set; }
//        /// <summary>
//        /// 订单时间
//        /// 【字段 datetime】
//        /// </summary>
//        [DataMember(Order = 29)]
//        public DateTime RecDate { get; set; }

//        public void MapTo(Sf_promoter_userEO destination)
//        {

//        }
//        #endregion // 所有列
//    }
//}
