using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Notify.Repositories.DAL.ing
{
    ///<summary>
    ///通知明细
    ///</summary>
    [SugarTable("sc_notify_detail")]
    public partial class Sc_notify_detailPO
    {
           public Sc_notify_detailPO(){

            this.LinkKind =0;

           }
           /// <summary>
           /// Desc:主键GUID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string NotifyID {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LangID {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

           /// <summary>
           /// Desc:图片地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ImageUrl {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Content {get;set;}

           /// <summary>
           /// Desc:链接类型1-email 2-url
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LinkKind {get;set;}

           /// <summary>
           /// Desc:链接
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? LinkUrl {get;set;}

           /// <summary>
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt1 {get;set;}

           /// <summary>
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt2 {get;set;}

           /// <summary>
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt3 {get;set;}

           /// <summary>
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt4 {get;set;}

           /// <summary>
           /// Desc:文本1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Txt5 {get;set;}

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

    }
}
