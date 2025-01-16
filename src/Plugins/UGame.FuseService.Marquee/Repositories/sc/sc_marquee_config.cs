using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace UGame.FuseService.Marquee.Repositories
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sc_marquee_config")]
    public partial class Sc_marquee_configPO
    {
           public Sc_marquee_configPO(){

            this.FakeWinMultiple =1;
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
           /// Desc:返奖的最小额度
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long WinMinAmount {get;set;}

           /// <summary>
           /// Desc:文字滚动的最大数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TextMaxNumber {get;set;}

           /// <summary>
           /// Desc:图片滚动的最大数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PicMaxNumber {get;set;}

           /// <summary>
           /// Desc:返奖伪造多少倍
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int FakeWinMultiple {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
