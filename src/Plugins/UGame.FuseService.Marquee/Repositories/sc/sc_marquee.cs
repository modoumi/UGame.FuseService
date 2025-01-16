using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Marquee.Repositories
{
    ///<summary>
    ///系统跑马灯（只保存系统固定消息，其他放入redis）
    ///</summary>
    [SugarTable("sc_marquee")]
    public partial class Sc_marqueePO
    {
           public Sc_marqueePO(){

            this.Position =0;
            this.Status =0;
            this.MarqueeType =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:跑马灯编码GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string MarqueeID {get;set;}

           /// <summary>
           /// Desc:应用编码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? AppID {get;set;}

           /// <summary>
           /// Desc:使用位置（app客户端分别自定义）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Position {get;set;}

           /// <summary>
           /// Desc:运营商编码（null意味着默认）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? OperatorID {get;set;}

           /// <summary>
           /// Desc:模板编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SCTemplateID {get;set;}

           /// <summary>
           /// Desc:模板参数值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? SCTemplateParams {get;set;}

           /// <summary>
           /// Desc:跳转路径
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LinkUrl {get;set;}

           /// <summary>
           /// Desc:状态(0-无效1-有效)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:是否虚拟数据
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Flag {get;set;}

           /// <summary>
           /// Desc:滚动数据类型：0文字，1图片
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MarqueeType {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
