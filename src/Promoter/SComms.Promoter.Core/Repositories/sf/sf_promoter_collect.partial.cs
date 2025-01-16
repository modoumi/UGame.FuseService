using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    public partial class Sf_promoter_collectPO
    {
        #region tinyfx
        public static implicit operator Sf_promoter_collectEO(Sf_promoter_collectPO value)
        {
            if (value==null) return null;
            return new Sf_promoter_collectEO
            {
		        CollectID = value.CollectID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        CollectedComm = value.CollectedComm,
		        ContributionNum = value.ContributionNum,
		        IsCollectBonus = value.IsCollectBonus,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sf_promoter_collectPO(Sf_promoter_collectEO value)
        {
            if (value==null) return null;
            return new Sf_promoter_collectPO
            {
		        CollectID = value.CollectID,
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        CollectedComm = value.CollectedComm,
		        ContributionNum = value.ContributionNum,
		        IsCollectBonus = value.IsCollectBonus,
		        FlowMultip = value.FlowMultip,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}