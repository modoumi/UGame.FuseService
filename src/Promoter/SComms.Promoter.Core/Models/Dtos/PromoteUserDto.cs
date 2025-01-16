namespace SComms.Promoter.Core.Models.Dtos;

public class PromoteUserDto
{
    /// <summary>
    /// 推广链接
    /// </summary>
    public string PUrl { get; set; }

    /// <summary>
    /// 直属上级名称
    /// </summary>
    public string DirectSuperior { get; set; }

    /// <summary>
    /// 手机号
    /// </summary>
    public string Mobile { get; set; }

    /// <summary>
    /// 代理级别
    /// </summary>
    public int PLevel { get; set; }

    /// <summary>
    /// 累计佣金
    /// </summary>
    public decimal TotalComm { get; set; }

    /// <summary>
    /// 已领取的佣金
    /// </summary>
    public decimal TotalCollectComm { get; set; }

    /// <summary>
    /// 当前可领取佣金
    /// </summary>
    public decimal CurrentComm { get; set; }

    /// <summary>
    /// 上次佣金
    /// </summary>
    public decimal LastComm { get; set; }

    /// <summary>
    /// 团队总人数
    /// </summary>
    public int TeamNum { get; set; }

    /// <summary>
    /// 直属人数
    /// </summary>
    public int DirectNum { get; set; }

    /// <summary>
    /// 其他人数
    /// </summary>
    public int OtherNum { get; set; }

    /// <summary>
    /// 总业绩
    /// </summary>
    public decimal TotalPerf { get; set; }

    /// <summary>
    /// 直属业绩
    /// </summary>
    public decimal DirectPerf { get; set; }

    /// <summary>
    /// 其他业绩
    /// </summary>
    public decimal OtherPerf { get; set; }
}