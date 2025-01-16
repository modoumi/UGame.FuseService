using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Banner.Repositories
{
    ///<summary>
    ///活动100007，注册送bonus配置
    ///</summary>
    [SugarTable("sa_register100007_config")]
    public partial class Sa_register100007_configPO
    {
           public Sa_register100007_configPO(){

            this.SendBonus =0;
            this.FlowMultip =0f;
            this.IsSendBonus =false;
            this.IPSendNum =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:国家编码ISO 3166-1三位字母
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CountryId {get;set;}

           /// <summary>
           /// Desc:货币类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:赠送奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SendBonus {get;set;}

           /// <summary>
           /// Desc:提现时候需要完成的下注流水倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public float FlowMultip {get;set;}

           /// <summary>
           /// Desc:是否赠送bonus
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsSendBonus {get;set;}

           /// <summary>
           /// Desc:同ip赠送注册奖励次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int IPSendNum {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
