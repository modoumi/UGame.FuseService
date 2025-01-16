namespace SComms.Promoter.Core.Models.Dtos;

public class PromoteCollectRecordDto
{
    /// <summary>
    /// 领取的佣金 
    /// </summary> 
    public decimal CollectedComm { get; set; }

    /// <summary>
    /// 贡献人数
    /// </summary>
    public int ContributionNum { get; set; }

    /// <summary>
    /// 记录时间
    /// 【字段 datetime】
    /// </summary> 
    public DateTime RecDate { get; set; }

}