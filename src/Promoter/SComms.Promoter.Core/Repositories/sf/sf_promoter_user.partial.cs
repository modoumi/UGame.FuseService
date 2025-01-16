using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    public partial class Sf_promoter_userPO
    {
        #region tinyfx
        public static implicit operator Sf_promoter_userEO(Sf_promoter_userPO value)
        {
            if (value==null) return null;
            return new Sf_promoter_userEO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        PUrl = value.PUrl,
		        PLevel = value.PLevel,
		        TotalComm = value.TotalComm,
		        CollectComm = value.CollectComm,
		        LastComm = value.LastComm,
		        DirectNum = value.DirectNum,
		        OtherNum = value.OtherNum,
		        TotalPerf = value.TotalPerf,
		        DirectPerf = value.DirectPerf,
		        OtherPerf = value.OtherPerf,
		        DepositNum = value.DepositNum,
		        DepositAmount = value.DepositAmount,
		        CashNum = value.CashNum,
		        CashAmount = value.CashAmount,
		        BetNum = value.BetNum,
		        BetCashAmount = value.BetCashAmount,
		        WinCashAmount = value.WinCashAmount,
		        BetBonusAmount = value.BetBonusAmount,
		        WinBonusAmount = value.WinBonusAmount,
		        OtherDepositNum = value.OtherDepositNum,
		        OtherDepositAmount = value.OtherDepositAmount,
		        OtherCashNum = value.OtherCashNum,
		        OtherCashAmount = value.OtherCashAmount,
		        OtherBetNum = value.OtherBetNum,
		        OtherBetCashAmount = value.OtherBetCashAmount,
		        OtherWinCashAmount = value.OtherWinCashAmount,
		        OtherBetBonusAmount = value.OtherBetBonusAmount,
		        OtherWinBonusAmount = value.OtherWinBonusAmount,
		        LastUpdateTime = value.LastUpdateTime,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sf_promoter_userPO(Sf_promoter_userEO value)
        {
            if (value==null) return null;
            return new Sf_promoter_userPO
            {
		        UserID = value.UserID,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        PUrl = value.PUrl,
		        PLevel = value.PLevel,
		        TotalComm = value.TotalComm,
		        CollectComm = value.CollectComm,
		        LastComm = value.LastComm,
		        DirectNum = value.DirectNum,
		        OtherNum = value.OtherNum,
		        TotalPerf = value.TotalPerf,
		        DirectPerf = value.DirectPerf,
		        OtherPerf = value.OtherPerf,
		        DepositNum = value.DepositNum,
		        DepositAmount = value.DepositAmount,
		        CashNum = value.CashNum,
		        CashAmount = value.CashAmount,
		        BetNum = value.BetNum,
		        BetCashAmount = value.BetCashAmount,
		        WinCashAmount = value.WinCashAmount,
		        BetBonusAmount = value.BetBonusAmount,
		        WinBonusAmount = value.WinBonusAmount,
		        OtherDepositNum = value.OtherDepositNum,
		        OtherDepositAmount = value.OtherDepositAmount,
		        OtherCashNum = value.OtherCashNum,
		        OtherCashAmount = value.OtherCashAmount,
		        OtherBetNum = value.OtherBetNum,
		        OtherBetCashAmount = value.OtherBetCashAmount,
		        OtherWinCashAmount = value.OtherWinCashAmount,
		        OtherBetBonusAmount = value.OtherBetBonusAmount,
		        OtherWinBonusAmount = value.OtherWinBonusAmount,
		        LastUpdateTime = value.LastUpdateTime,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}