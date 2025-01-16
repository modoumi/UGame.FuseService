using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    public partial class Sf_promoter_configPO
    {
        #region tinyfx
        public static implicit operator Sf_promoter_configEO(Sf_promoter_configPO value)
        {
            if (value==null) return null;
            return new Sf_promoter_configEO
            {
		        OperatorID = value.OperatorID,
		        HasBonusPerf = value.HasBonusPerf,
		        CommMinDeposit = value.CommMinDeposit,
		        CommMinPerf = value.CommMinPerf,
		        IsCollectBonus = value.IsCollectBonus,
		        FlowMultip = value.FlowMultip,
            };
        }
        public static implicit operator Sf_promoter_configPO(Sf_promoter_configEO value)
        {
            if (value==null) return null;
            return new Sf_promoter_configPO
            {
		        OperatorID = value.OperatorID,
		        HasBonusPerf = value.HasBonusPerf,
		        CommMinDeposit = value.CommMinDeposit,
		        CommMinPerf = value.CommMinPerf,
		        IsCollectBonus = value.IsCollectBonus,
		        FlowMultip = value.FlowMultip,
            };
        }
        #endregion
    }
}