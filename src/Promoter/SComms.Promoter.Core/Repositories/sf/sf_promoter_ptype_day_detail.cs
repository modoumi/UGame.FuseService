using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    ///<summary>
    ///每天推广人游戏类别统计的用户明细
    ///</summary>
    [SugarTable("sf_promoter_ptype_day_detail")]
    public partial class Sf_promoter_ptype_day_detailPO
    {
           public Sf_promoter_ptype_day_detailPO(){

            this.PromoterType =2;
            this.FromMode =0;
            this.UserKind =0;
            this.IsDirect =false;
            this.Perf =0;
            this.Comm =0;
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
           /// Desc:推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育
           /// Default:2
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int PromoterType {get;set;}

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
           /// Desc:是否是直属用户
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsDirect {get;set;}

           /// <summary>
           /// Desc:业绩
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Perf {get;set;}

           /// <summary>
           /// Desc:佣金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long Comm {get;set;}

           /// <summary>
           /// Desc:订单时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
