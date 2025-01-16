namespace SComms.Promoter.Core.Models.Dtos;

public class PromoteCommDto
{
    /// <summary>
    /// 日期
    /// </summary>
    public DateTime DayID { get; set; }

    /// <summary>
    /// 用户编码
    /// </summary> 
    public string UserID { get; set; }

    /// <summary>
    /// 推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育
    /// </summary> 
    public int PromoterType { get; set; }

    /// <summary>
    /// 业绩
    /// </summary>
    public decimal Perf { get; set; }

    /// <summary>
    /// 贡献者人数
    /// </summary>
    public int Contributors { get; set; }

    /// <summary>
    /// 佣金
    /// </summary>
    public decimal Comm { get; set; }
}