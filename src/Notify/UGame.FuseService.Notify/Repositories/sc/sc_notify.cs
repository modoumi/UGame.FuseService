using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Notify.Repositories.DAL.ing
{
    ///<summary>
    ///通知
    ///</summary>
    [SugarTable("sc_notify")]
    public partial class Sc_notifyPO
    {
           public Sc_notifyPO(){

            this.ActionAt =0;
            this.ShowAt =0;
            this.UserScope =0;
            this.NotifyUsersCount =1;
            this.NotifyedUsersCount =0;
            this.Position =0;
            this.ShowTimes =0;
            this.ShowInterval =0;
            this.CloseInterval =0;
            this.OrderNum =0;
            this.BeginDate =Convert.ToDateTime("2000-01-01 00:00:00");
            this.EndDate =Convert.ToDateTime("9999-12-31 00:00:00");
            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string NotifyID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppID {get;set;}

           /// <summary>
           /// Desc:运营商编码（null意味着全部）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:何时显示1-登录前2-注册后第一次登录3登录后
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ActionAt {get;set;}

           /// <summary>
           /// Desc:显示页面FLAG值0-全部1-首页2-4-8
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ShowAt {get;set;}

           /// <summary>
           /// Desc:用户范围0-全部用户1-指定具体用户
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserScope {get;set;}

           /// <summary>
           /// Desc:需要通知的用户人数
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int NotifyUsersCount {get;set;}

           /// <summary>
           /// Desc:已通知用户人数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NotifyedUsersCount {get;set;}

           /// <summary>
           /// Desc:显示位置1-顶部2-中部3-下部
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Position {get;set;}

           /// <summary>
           /// Desc:展示次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ShowTimes {get;set;}

           /// <summary>
           /// Desc:展示间隔（分钟）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ShowInterval {get;set;}

           /// <summary>
           /// Desc:自动关闭间隔（秒）0-手动关闭
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CloseInterval {get;set;}

           /// <summary>
           /// Desc:排序（从小到大）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:起始日期（默认2016-01-01）
           /// Default:2000-01-01 00:00:00
           /// Nullable:False
           /// </summary>           
           public DateTime BeginDate {get;set;}

           /// <summary>
           /// Desc:截止日期（默认2099-01-01）
           /// Default:9999-12-31 00:00:00
           /// Nullable:False
           /// </summary>           
           public DateTime EndDate {get;set;}

           /// <summary>
           /// Desc:状态(0-无效1-有效)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
