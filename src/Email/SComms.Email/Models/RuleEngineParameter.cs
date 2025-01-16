using SqlSugar;
using System;
using System.Collections.Generic;

namespace SComms.Email.Models;

public class RuleEngineParameter
{
    public Dictionary<string, object> RequestParameters { get; set; }

    public SSimpleUser User { get; set; }
    public SSimpleUser Referrer { get; set; }

    public long? TotalDepositAmountDaily { get; set; }
    public long? TotalDepositAmountWeekly { get; set; }
    public long? TotalDepositAmountMonthly { get; set; }

    public long? TotalBetAmountDaily { get; set; }
    public long? TotalBetAmountWeekly { get; set; }
    public long? TotalBetAmountMonthly { get; set; }
}
[SugarTable("s_user")]
public class SSimpleUser
{
    public string UserId { get; set; }
    public int UserMode { get; set; }
    public string OperatorId { get; set; }
    public string Mobile { get; set; }
    public long Cash { get; set; }
    public long Bonus { get; set; }
    public long Point { get; set; }
    public int VIP { get; set; }
    public string PUserID1 { get; set; }
    public DateTime? RegistDate { get; set; }
    public bool HasBet { get; set; }
    public bool HasPay { get; set; }
    public bool HasCash { get; set; }
}
[SugarTable("sat_deposit_day")]
public class SatDepositDay
{
    public string UserID { get; set; }
    public DateTime DayID { get; set; }
    public int ItemID { get; set; }
    public string OperatorID { get; set; }
    public string CurrencyID { get; set; }
    public long DepositAmount { get; set; }
}
