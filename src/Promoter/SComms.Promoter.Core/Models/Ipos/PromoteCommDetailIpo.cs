namespace SComms.Promoter.Core.Models.Ipos;

public class PromoteCommDetailIpo
{
    /// <summary>
    /// 开始时间
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// 结束时间
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// 推广类型
    /// </summary>
    public int? PromoterType { get; set; }

    /// <summary>
    /// 当前页
    /// </summary>
    public int PageIndex { get; set; } = 1;

    /// <summary>
    /// 每页数据
    /// </summary>
    public int PageSize { get; set; } = 10;

}