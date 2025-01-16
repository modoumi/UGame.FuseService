using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    ///<summary>
    ///推广用户基本信息
    ///</summary>
    [SugarTable("sf_promoter_user")]
    public partial class Sf_promoter_userPO
    {
           public Sf_promoter_userPO(){

            this.FromMode =0;
            this.UserKind =0;
            this.PLevel =0;
            this.TotalComm =0;
            this.CollectComm =0;
            this.LastComm =0;
            this.DirectNum =0;
            this.OtherNum =0;
            this.TotalPerf =0;
            this.DirectPerf =0;
            this.OtherPerf =0;
            this.DepositNum =0;
            this.DepositAmount =0;
            this.CashNum =0;
            this.CashAmount =0;
            this.BetNum =0;
            this.BetCashAmount =0;
            this.WinCashAmount =0;
            this.BetBonusAmount =0;
            this.WinBonusAmount =0;
            this.OtherDepositNum =0;
            this.OtherDepositAmount =0;
            this.OtherCashNum =0;
            this.OtherCashAmount =0;
            this.OtherBetNum =0;
            this.OtherBetCashAmount =0;
            this.OtherWinCashAmount =0;
            this.OtherBetBonusAmount =0;
            this.OtherWinBonusAmount =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

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
           /// Desc:推广链接
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? PUrl {get;set;}

           /// <summary>
           /// Desc:推广员级别
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int PLevel {get;set;}

           /// <summary>
           /// Desc:累计佣金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalComm {get;set;}

           /// <summary>
           /// Desc:已取佣金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CollectComm {get;set;}

           /// <summary>
           /// Desc:上次领取的佣金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long LastComm {get;set;}

           /// <summary>
           /// Desc:直属人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DirectNum {get;set;}

           /// <summary>
           /// Desc:其他人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OtherNum {get;set;}

           /// <summary>
           /// Desc:总业绩（流水）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TotalPerf {get;set;}

           /// <summary>
           /// Desc:直属业绩
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DirectPerf {get;set;}

           /// <summary>
           /// Desc:其他业绩
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OtherPerf {get;set;}

           /// <summary>
           /// Desc:充值人数（直属）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DepositNum {get;set;}

           /// <summary>
           /// Desc:充值（被邀请人）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long DepositAmount {get;set;}

           /// <summary>
           /// Desc:提现人数（直属）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CashNum {get;set;}

           /// <summary>
           /// Desc:提现（被邀请人）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashAmount {get;set;}

           /// <summary>
           /// Desc:下注人数（直属）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int BetNum {get;set;}

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
           /// Desc:充值人数（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OtherDepositNum {get;set;}

           /// <summary>
           /// Desc:充值（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OtherDepositAmount {get;set;}

           /// <summary>
           /// Desc:提现人数（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OtherCashNum {get;set;}

           /// <summary>
           /// Desc:提现（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long OtherCashAmount {get;set;}

           /// <summary>
           /// Desc:下注人数（其下级）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OtherBetNum {get;set;}

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
           /// Desc:最后一次更新时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime LastUpdateTime {get;set;}

           /// <summary>
           /// Desc:订单时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
