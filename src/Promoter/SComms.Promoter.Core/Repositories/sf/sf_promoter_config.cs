using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    ///<summary>
    ///推广基础配置
    ///</summary>
    [SugarTable("sf_promoter_config")]
    public partial class Sf_promoter_configPO
    {
           public Sf_promoter_configPO(){

            this.HasBonusPerf =false;
            this.CommMinDeposit =0;
            this.CommMinPerf =0;
            this.IsCollectBonus =true;
            this.FlowMultip =0;

           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:业绩返佣时是否包含bonus
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool HasBonusPerf {get;set;}

           /// <summary>
           /// Desc:返佣时最低存款要求
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CommMinDeposit {get;set;}

           /// <summary>
           /// Desc:返佣时最低业绩要求
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CommMinPerf {get;set;}

           /// <summary>
           /// Desc:领取时是否是bonus
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public bool IsCollectBonus {get;set;}

           /// <summary>
           /// Desc:流水倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int FlowMultip {get;set;}

    }
}
