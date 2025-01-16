namespace SComms.Promoter.Core.Models.Dtos;

public class PromoteCommProportionsDto
{

    public PromoteConfigDto Config { get; set; }

    public List<PromoteCommProportionsIpoDto> CommProportions { get; set; }
}

public class PromoteConfigDto
{
    /// <summary>
    /// 业绩返佣时是否包含bonus
    /// </summary>
    public bool HasBonusPerf { get; set; }

    /// <summary>
    /// 有效存款
    /// </summary>
    public decimal CommMinDeposit { get; set; }

    /// <summary>
    /// 有效投注
    /// </summary>
    public decimal CommMinPerf { get; set; }
}

public class PromoteCommProportionsIpoDto
{
    public PromoteCommProportionsIpoDto() { }

    /// <summary>
    /// 运营商编码
    /// </summary>
    public string OperatorID { get; set; }

    /// <summary>
    /// 代理级别
    /// </summary>
    public int CommLevel { get; set; }

    /// <summary>
    /// 有效投注流水
    /// </summary>
    public decimal BetAmount { get; set; }

    /// <summary>
    /// 返还佣金（每一万有效投注流水返奖值）
    /// </summary>
    public decimal Comm { get; set; }
}