using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    public partial class Sf_promoter_ptype_day_detailPO
    {
        #region tinyfx
        public static implicit operator Sf_promoter_ptype_day_detailEO(Sf_promoter_ptype_day_detailPO value)
        {
            if (value==null) return null;
            return new Sf_promoter_ptype_day_detailEO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        PromoterType = value.PromoterType,
		        IUserID = value.IUserID,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        IsDirect = value.IsDirect,
		        Perf = value.Perf,
		        Comm = value.Comm,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sf_promoter_ptype_day_detailPO(Sf_promoter_ptype_day_detailEO value)
        {
            if (value==null) return null;
            return new Sf_promoter_ptype_day_detailPO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        PromoterType = value.PromoterType,
		        IUserID = value.IUserID,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        IsDirect = value.IsDirect,
		        Perf = value.Perf,
		        Comm = value.Comm,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}