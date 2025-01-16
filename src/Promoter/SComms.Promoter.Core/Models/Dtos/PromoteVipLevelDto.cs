namespace SComms.Promoter.Core.Models.Dtos;

public class PromoteVipLevelDto
{
    /// <summary>
    /// 运营商编码
    /// </summary>
    public string OperatorID { get; set; }

    /// <summary>
    /// 推广员vip等级
    /// </summary>
    public int PLevel { get; set; }

    /// <summary>
    /// 需要业绩数
    /// </summary>
    public decimal NeedPerf { get; set; }
}