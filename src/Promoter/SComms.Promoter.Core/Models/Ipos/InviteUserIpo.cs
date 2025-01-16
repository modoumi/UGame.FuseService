namespace SComms.Promoter.Core.Models.Ipos;

public class InviteUserIpo
{
    /// <summary>
    /// 开始时间 format = YYYY-MM-DD
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// 结束时间 format = YYYY-MM-DD
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// 当前页 从1开始
    /// </summary>
    public int PageIndex { get; set; } = 1;

    /// <summary>
    /// 每页数据
    /// </summary>
    public int PageSize { get; set; } = 10;
}