using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Marquee.Repositories
{
    ///<summary>
    ///通用多语言模板
    ///</summary>
    [SugarTable("sc_templ_lang")]
    public partial class Sc_templ_langPO
    {
           public Sc_templ_langPO(){


           }
           /// <summary>
           /// Desc:模板编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int SCTemplateID {get;set;}

           /// <summary>
           /// Desc:运营商ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:语言代码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string LangID {get;set;}

           /// <summary>
           /// Desc:内容，如:恭喜{userId}你获得{amount}金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Content {get;set;}

    }
}
