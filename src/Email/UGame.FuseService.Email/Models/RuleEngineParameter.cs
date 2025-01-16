using SqlSugar;
using System;
using System.Collections.Generic;

namespace UGame.FuseService.Email.Models;

/// <summary>
/// 
/// </summary>
public class RuleEngineParameter
{
    /// <summary>
    /// 
    /// </summary>
    public Dictionary<string, object> RequestParameters { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public SSimpleUser User { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public SSimpleUser Referrer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long? TotalDepositAmountDaily { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long? TotalDepositAmountWeekly { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long? TotalDepositAmountMonthly { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long? TotalBetAmountDaily { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long? TotalBetAmountWeekly { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long? TotalBetAmountMonthly { get; set; }
}

/// <summary>
/// 
/// </summary>
[SugarTable("s_user")]
public class SSimpleUser
{
    /// <summary>
    /// 
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int UserMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string OperatorId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Mobile { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long Cash { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long Bonus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long Point { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int VIP { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string PUserID1 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime? RegistDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool HasBet { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool HasPay { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool HasCash { get; set; }

}
/// <summary>
/// 玩家每日充值累加表，记录每个玩家当天的累计充值金额
/// </summary>
[SugarTable("sat_deposit_day")]
public class SatDepositDay
{
    /// <summary>
    /// 
    /// </summary>
    public string UserID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime DayID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int ItemID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string OperatorID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string CurrencyID { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public long DepositAmount { get; set; }
}
