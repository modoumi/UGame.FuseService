namespace SComms.Promoter.Core.Models.Ipos;

public class PromotePerformanceIpo
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
    /// 账号
    /// </summary>
    public string Account { get; set; }

    public int PageIndex { get; set; }

    public int PageSize { get; set; }
}