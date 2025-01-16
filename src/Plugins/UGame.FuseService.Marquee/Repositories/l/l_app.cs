using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Marquee.Repositories
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("l_app")]
    public partial class L_appPO
    {
           public L_appPO(){

            this.Flag =0;
            this.RouletteIcon ="";
            this.MarqueeStatus =0;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string PrimaryKeyID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppID {get;set;}

           /// <summary>
           /// Desc:应用标志 0-默认1-Hot2-New
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Flag {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SmallIcon {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MiddleIcon {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? BigIcon {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? RouletteIcon {get;set;}

           /// <summary>
           /// Desc:是否在跑马灯展示：0不展示，1展示
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MarqueeStatus {get;set;}

           /// <summary>
           /// Desc:跑马灯展示的游戏图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MarqueeIcon {get;set;}

    }
}
