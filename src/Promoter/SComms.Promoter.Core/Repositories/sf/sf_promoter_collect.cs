using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    ///<summary>
    ///用户佣金领取明细
    ///</summary>
    [SugarTable("sf_promoter_collect")]
    public partial class Sf_promoter_collectPO
    {
           public Sf_promoter_collectPO(){

            this.FromMode =0;
            this.UserKind =0;
            this.CollectedComm =0;
            this.ContributionNum =0;
            this.IsCollectBonus =true;
            this.FlowMultip =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CollectID {get;set;}

           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
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
           /// Desc:领取的佣金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CollectedComm {get;set;}

           /// <summary>
           /// Desc:贡献人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ContributionNum {get;set;}

           /// <summary>
           /// Desc:领取时是否是bonus
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public bool IsCollectBonus {get;set;}

           /// <summary>
           /// Desc:流水倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FlowMultip {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
