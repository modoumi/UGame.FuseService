using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Notify.Repositories.DAL.ing
{
    ///<summary>
    ///通知用户日志
    ///</summary>
    [SugarTable("sc_notify_user_log")]
    public partial class Sc_notify_user_logPO
    {
           public Sc_notify_user_logPO(){

            this.ShowCount =0;
            this.LastShowDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string NotifyID {get;set;}

           /// <summary>
           /// Desc:用户编码(GUID)
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:显示次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ShowCount {get;set;}

           /// <summary>
           /// Desc:最后一次展示时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime LastShowDate {get;set;}

    }
}
