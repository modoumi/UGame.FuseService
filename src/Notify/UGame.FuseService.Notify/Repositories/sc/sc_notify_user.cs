using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Notify.Repositories.DAL.ing
{
    ///<summary>
    ///通知具体用户
    ///</summary>
    [SugarTable("sc_notify_user")]
    public partial class Sc_notify_userPO
    {
           public Sc_notify_userPO(){


           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string NotifyID {get;set;}

           /// <summary>
           /// Desc:用户编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

    }
}
