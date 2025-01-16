using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Notify.Repositories.DAL.ing
{
    ///<summary>
    ///活动通知模板
    ///</summary>
    [SugarTable("sa_notify_template")]
    public partial class Sa_notify_templatePO
    {
           public Sa_notify_templatePO(){

            this.NotifyType =0;
            this.ActivityType =0;
            this.Status =false;

           }
           /// <summary>
           /// Desc:模板ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string TempID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CountryId {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LangID {get;set;}

           /// <summary>
           /// Desc:通知类型0-默认1-活动2-站内Email
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NotifyType {get;set;}

           /// <summary>
           /// Desc:活动类型100001-注册、首充活动100002-幸运转盘100003-输返活动100004-新用户首充5奖励100005-签到活动100006-绑定手机领取奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ActivityType {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img1 {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img2 {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img3 {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img4 {get;set;}

           /// <summary>
           /// Desc:图片1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Img5 {get;set;}

           /// <summary>
           /// Desc:类型:0-位置1-图片2-html3-文字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Mode {get;set;}

           /// <summary>
           /// Desc:消息内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Content {get;set;}

           /// <summary>
           /// Desc:链接地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LinkUrl {get;set;}

           /// <summary>
           /// Desc:是否启用
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool Status {get;set;}

    }
}
