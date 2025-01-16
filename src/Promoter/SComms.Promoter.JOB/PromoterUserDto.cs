//using Xxyy.DAL;

//namespace Xxyy.Quartz.BLL.Services.SReport.PromoterWorker
//{
//    public class PromoterUserData
//    {
//        /// <summary>
//        /// 当前用户编码
//        /// </summary>
//        public string UserId { get; set; }

//        /// <summary>
//        /// 新用户来源方式0-获得运营商的新用户(s_operator)1-推广员获得的新用户（userid）uid=xxx2-推广渠道通过url获得的新用户（s_channel)  cid=xxx        /// </summary>
//        public int FromMode { get; set; }

//        /// <summary>
//        /// 对应的编码（根据FromMode变化）        FromMode=0-运营商的新用户(s_operator)==> OperatorID1-推广员获得的新用户（userid） ==> 邀请人的UserID2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
//        /// </summary>
//        public string FromId { get; set; }

//        /// <summary>
//        /// 
//        /// </summary>
//        public int UserKind { get; set; }

//        /// <summary>
//        /// 
//        /// </summary>
//        public Dictionary<string, PromoterSub1Item> Details { get; set; } = new();
//    }

//    public class PromoterSub1Item
//    {
//        public string UserId { get; set; }

//        /// <summary>
//        /// 推广时间
//        /// </summary>
//        public DateTime? RegistDate { get; set; }

//        /// <summary>
//        /// 新用户来源方式0-获得运营商的新用户(s_operator)1-推广员获得的新用户（userid）uid=xxx2-推广渠道通过url获得的新用户（s_channel)  cid=xxx        /// </summary>
//        public int FromMode { get; set; }

//        /// <summary>
//        /// 对应的编码（根据FromMode变化）        FromMode=0-运营商的新用户(s_operator)==> OperatorID1-推广员获得的新用户（userid） ==> 邀请人的UserID2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
//        /// </summary>
//        public string FromId { get; set; }

//        /// <summary>
//        /// 
//        /// </summary>
//        public int UserKind { get; set; }

//        /// <summary>
//        /// 流水订单
//        /// </summary>
//        public List<S_provider_orderEO> Orders { get; set; } = new();

//        /// <summary>
//        /// 充值提现订单
//        /// </summary>
//        public List<Sb_bank_orderEO> BankOrders { get; set; } = new();

//        /// <summary>
//        /// 2级代理订单
//        /// </summary>
//        public Dictionary<string, PromoterSub2Item> SubOrders { get; set; } = new();
//    }

//    public class PromoterSub2Item
//    {
//        public string UserId { get; set; }

//        /// <summary>
//        /// 新用户来源方式0-获得运营商的新用户(s_operator)1-推广员获得的新用户（userid）uid=xxx2-推广渠道通过url获得的新用户（s_channel)  cid=xxx        /// </summary>
//        public int FromMode { get; set; }

//        /// <summary>
//        /// 对应的编码（根据FromMode变化）        FromMode=0-运营商的新用户(s_operator)==> OperatorID1-推广员获得的新用户（userid） ==> 邀请人的UserID2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
//        /// </summary>
//        public string FromId { get; set; }

//        /// <summary>
//        /// 
//        /// </summary>
//        public int UserKind { get; set; }

//        /// <summary>
//        /// 流水订单
//        /// </summary>
//        public List<S_provider_orderEO> Orders { get; set; } = new();

//        /// <summary>
//        /// 充值提现订单
//        /// </summary>
//        public List<Sb_bank_orderEO> BankOrders { get; set; } = new();
//    }
//}
