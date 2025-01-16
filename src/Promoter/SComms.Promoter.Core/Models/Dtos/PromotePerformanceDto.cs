using System.Runtime.Serialization;

namespace SComms.Promoter.Core.Models.Dtos;

public class PromotePerformanceDto
{

    /// <summary>
    /// 用户编码(GUID)
    /// </summary>
    [DataMember(Order = 2)]
    public string UserID { get; set; }

    /// <summary>
    /// 加入时间
    /// </summary>
    public DateTime PromoteTime { get; set; }

    /// <summary>
    /// 1级代理人
    /// </summary>
    public string DirectUserName { get; set; }

    /// <summary>
    /// 手机号
    /// </summary>
    public string Mobile { get; set; }

    /// <summary>
    /// 下级人数
    /// </summary>
    public int DirectNum { get; set; }

    /// <summary>
    /// 业绩
    /// </summary>
    public decimal Perf { get; set; }

    /// <summary>
    /// 贡献的佣金
    /// </summary>
    public decimal ContributionComm { get; set; }

}