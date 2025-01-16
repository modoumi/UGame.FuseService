namespace SComms.Promoter.Core.Models.Dtos;

public class PromoteCommDetailDto
{
    /// <summary>
    /// 账号
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// 手机号
    /// </summary>
    public string Mobile { get; set; }

    /// <summary>
    /// 类型
    /// </summary>
    public int PromoterType { get; set; }

    /// <summary>
    /// 业绩
    /// </summary>
    public decimal Perf { get; set; }

    /// <summary>
    /// 佣金
    /// </summary>
    public decimal Comm { get; set; }
}