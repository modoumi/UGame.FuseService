using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    ///<summary>
    ///推广员vip等级设置
    ///</summary>
    [SugarTable("sf_promoter_vip")]
    public partial class Sf_promoter_vipPO
    {
           public Sf_promoter_vipPO(){


           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:推广员级别
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int PLevel {get;set;}

           /// <summary>
           /// Desc:需要业绩数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long NeedPerf {get;set;}

    }
}
