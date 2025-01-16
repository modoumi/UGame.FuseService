using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    ///<summary>
    ///每天推广员邀请的用户的统计信息
    ///</summary>
    [SugarTable("sf_promoter_iuser_day")]
    public partial class Sf_promoter_iuser_dayPO
    {
           public Sf_promoter_iuser_dayPO(){

            this.FromMode =0;
            this.UserKind =0;
            this.PromoteTime =DateTime.Now;
            this.DirectNum =0;
            this.Perf =0;
            this.ContributionComm =0;
            this.Income =0;
            this.DepositAmount =0;
            this.CashAmount =0;
            this.BetCashAmount =0;
            this.WinCashAmount =0;
            this.BetBonusAmount =0;
            this.WinBonusAmount =0;
            this.OtherDepositAmount =0;
            this.OtherCashAmount =0;
            this.OtherBetCashAmount =0;
            this.OtherWinCashAmount =0;
            this.OtherBetBonusAmount =0;
            this.OtherWinBonusAmount =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:统计日
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public DateTime DayID {get;set;}

           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:被邀请用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string IUserID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:新用户来源方式
			///              0-获得运营商的新用户(s_operator)
			///              1-推广员获得的新用户（userid）
			///              2-推广渠道通过url获得的新用户（s_channel_url)
			///              3-推广渠道通过code获得的新用户（s_channel_code)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FromMode {get;set;}

           /// <summary>
           /// Desc:对应的编码（根据FromMode变化）
			///              FromMode=
			///              0-运营商的新用户(s_operator)==> OperatorID
			///              1-推广员获得的新用户（userid） ==> 邀请人的UserID
			///              2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
			///              3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? FromId {get;set;}

           /// <summary>
           /// Desc:用户类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserKind {get;set;}

           /// <summary>
           /// Desc:推广时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime PromoteTime {get;set;}

           /// <summary>
           /// Desc:直属人数（仅当天贡献的）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DirectNum {get;set;}

           /// <summary>
           /// Desc:业绩（被邀请人+其下级bet总和）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Perf {get;set;}

           /// <summary>
           /// Desc:贡献的佣金（被邀请人+其下级的总和）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ContributionComm {get;set;}

           /// <summary>
           /// Desc:总输赢（被邀请人的bet-win）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Income {get;set;}

           /// <summary>
           /// Desc:充值（被邀请人）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DepositAmount {get;set;}

           /// <summary>
           /// Desc:提现（被邀请人）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashAmount {get;set;}

           /// <summary>
           /// Desc:下注真金（被邀请人）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetCashAmount {get;set;}

           /// <summary>
           /// Desc:返奖真金（被邀请人）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinCashAmount {get;set;}

           /// <summary>
           /// Desc:下注bonus（被邀请人）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetBonusAmount {get;set;}

           /// <summary>
           /// Desc:返奖bonus（被邀请人）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinBonusAmount {get;set;}

           /// <summary>
           /// Desc:充值（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OtherDepositAmount {get;set;}

           /// <summary>
           /// Desc:提现（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OtherCashAmount {get;set;}

           /// <summary>
           /// Desc:下注真金（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OtherBetCashAmount {get;set;}

           /// <summary>
           /// Desc:返奖真金（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OtherWinCashAmount {get;set;}

           /// <summary>
           /// Desc:下注bonus（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OtherBetBonusAmount {get;set;}

           /// <summary>
           /// Desc:返奖bonus（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OtherWinBonusAmount {get;set;}

           /// <summary>
           /// Desc:订单时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
