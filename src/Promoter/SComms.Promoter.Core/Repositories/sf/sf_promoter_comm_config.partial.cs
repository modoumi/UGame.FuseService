using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    public partial class Sf_promoter_comm_configPO
    {
        #region tinyfx
        public static implicit operator Sf_promoter_comm_configEO(Sf_promoter_comm_configPO value)
        {
            if (value==null) return null;
            return new Sf_promoter_comm_configEO
            {
		        OperatorID = value.OperatorID,
		        PromoterType = value.PromoterType,
		        CommLevel = value.CommLevel,
		        MinAmountPerf = value.MinAmountPerf,
		        MinCashPerf = value.MinCashPerf,
		        Comm = value.Comm,
            };
        }
        public static implicit operator Sf_promoter_comm_configPO(Sf_promoter_comm_configEO value)
        {
            if (value==null) return null;
            return new Sf_promoter_comm_configPO
            {
		        OperatorID = value.OperatorID,
		        PromoterType = value.PromoterType,
		        CommLevel = value.CommLevel,
		        MinAmountPerf = value.MinAmountPerf,
		        MinCashPerf = value.MinCashPerf,
		        Comm = value.Comm,
            };
        }
        #endregion
    }
}