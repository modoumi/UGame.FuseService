using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    public partial class Sf_promoter_vipPO
    {
        #region tinyfx
        public static implicit operator Sf_promoter_vipEO(Sf_promoter_vipPO value)
        {
            if (value==null) return null;
            return new Sf_promoter_vipEO
            {
		        OperatorID = value.OperatorID,
		        PLevel = value.PLevel,
		        NeedPerf = value.NeedPerf,
            };
        }
        public static implicit operator Sf_promoter_vipPO(Sf_promoter_vipEO value)
        {
            if (value==null) return null;
            return new Sf_promoter_vipPO
            {
		        OperatorID = value.OperatorID,
		        PLevel = value.PLevel,
		        NeedPerf = value.NeedPerf,
            };
        }
        #endregion
    }
}