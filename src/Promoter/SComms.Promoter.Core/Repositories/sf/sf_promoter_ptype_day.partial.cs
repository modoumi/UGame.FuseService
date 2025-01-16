using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    public partial class Sf_promoter_ptype_dayPO
    {
        #region tinyfx
        public static implicit operator Sf_promoter_ptype_dayEO(Sf_promoter_ptype_dayPO value)
        {
            if (value==null) return null;
            return new Sf_promoter_ptype_dayEO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        PromoterType = value.PromoterType,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        Perf = value.Perf,
		        Contributors = value.Contributors,
		        Comm = value.Comm,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sf_promoter_ptype_dayPO(Sf_promoter_ptype_dayEO value)
        {
            if (value==null) return null;
            return new Sf_promoter_ptype_dayPO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        PromoterType = value.PromoterType,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        Perf = value.Perf,
		        Contributors = value.Contributors,
		        Comm = value.Comm,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}