using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace SComms.Promoter.Core.Repositories
{
    public partial class Sf_promoter_iuser_dayPO
    {
        #region tinyfx
        public static implicit operator Sf_promoter_iuser_dayEO(Sf_promoter_iuser_dayPO value)
        {
            if (value==null) return null;
            return new Sf_promoter_iuser_dayEO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        IUserID = value.IUserID,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        PromoteTime = value.PromoteTime,
		        DirectNum = value.DirectNum,
		        Perf = value.Perf,
		        ContributionComm = value.ContributionComm,
		        Income = value.Income,
		        DepositAmount = value.DepositAmount,
		        CashAmount = value.CashAmount,
		        BetCashAmount = value.BetCashAmount,
		        WinCashAmount = value.WinCashAmount,
		        BetBonusAmount = value.BetBonusAmount,
		        WinBonusAmount = value.WinBonusAmount,
		        OtherDepositAmount = value.OtherDepositAmount,
		        OtherCashAmount = value.OtherCashAmount,
		        OtherBetCashAmount = value.OtherBetCashAmount,
		        OtherWinCashAmount = value.OtherWinCashAmount,
		        OtherBetBonusAmount = value.OtherBetBonusAmount,
		        OtherWinBonusAmount = value.OtherWinBonusAmount,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Sf_promoter_iuser_dayPO(Sf_promoter_iuser_dayEO value)
        {
            if (value==null) return null;
            return new Sf_promoter_iuser_dayPO
            {
		        DayID = value.DayID,
		        UserID = value.UserID,
		        IUserID = value.IUserID,
		        OperatorID = value.OperatorID,
		        FromMode = value.FromMode,
		        FromId = value.FromId,
		        UserKind = value.UserKind,
		        PromoteTime = value.PromoteTime,
		        DirectNum = value.DirectNum,
		        Perf = value.Perf,
		        ContributionComm = value.ContributionComm,
		        Income = value.Income,
		        DepositAmount = value.DepositAmount,
		        CashAmount = value.CashAmount,
		        BetCashAmount = value.BetCashAmount,
		        WinCashAmount = value.WinCashAmount,
		        BetBonusAmount = value.BetBonusAmount,
		        WinBonusAmount = value.WinBonusAmount,
		        OtherDepositAmount = value.OtherDepositAmount,
		        OtherCashAmount = value.OtherCashAmount,
		        OtherBetCashAmount = value.OtherBetCashAmount,
		        OtherWinCashAmount = value.OtherWinCashAmount,
		        OtherBetBonusAmount = value.OtherBetBonusAmount,
		        OtherWinBonusAmount = value.OtherWinBonusAmount,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}