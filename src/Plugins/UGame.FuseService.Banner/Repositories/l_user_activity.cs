using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Banner.Repositories
{
    ///<summary>
    ///用户活动数据总表
    ///</summary>
    [SugarTable("l_user_activity")]
    public partial class L_user_activityPO
    {
           public L_user_activityPO(){

            this.UserKind =0;
            this.IsInvolved =false;
            this.IsEnd =false;
            this.RecDate =DateTime.Now;
            this.UpdateTime =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CountryID {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:用户类型
			///              0-未知
			///              1-普通用户
			///              2-开发用户
			///              3-线上测试用户（调用第三方扣减）
			///              4-线上测试用户（不调用第三方扣减）
			///              5-仿真用户
			///              6-接口联调用户
			///              9-管理员
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserKind {get;set;}

           /// <summary>
           /// Desc:活动编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ActivityId {get;set;}

           /// <summary>
           /// Desc:活动描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ActivityName {get;set;}

           /// <summary>
           /// Desc:是否参与
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsInvolved {get;set;}

           /// <summary>
           /// Desc:活动是否已完成
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsEnd {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime UpdateTime {get;set;}

    }
}
