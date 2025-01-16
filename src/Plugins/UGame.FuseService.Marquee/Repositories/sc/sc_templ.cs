using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Marquee.Repositories
{
    ///<summary>
    ///通用模板定义
    ///</summary>
    [SugarTable("sc_templ")]
    public partial class Sc_templPO
    {
           public Sc_templPO(){

            this.TemplateType =0;

           }
           /// <summary>
           /// Desc:模板编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int SCTemplateID {get;set;}

           /// <summary>
           /// Desc:模板类型0-文字marquee，1图片marquee
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TemplateType {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Title {get;set;}

           /// <summary>
           /// Desc:参数对应的实体类
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ParamsTypeName {get;set;}

           /// <summary>
           /// Desc:应用程序集
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? ParamsNameSpace {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Note {get;set;}

    }
}
