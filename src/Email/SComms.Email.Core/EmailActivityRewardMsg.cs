using TinyFx.Extensions.RabbitMQ;

namespace SComms.Email.Core;

public class EmailActivityRewardMsg : IMQMessage
{
    /// <summary>
    /// 活动ID
    /// </summary>
    public int ActivityId { get; set; }
    /// <summary>
    /// 用户编码
    /// </summary>
    public string UserId { get; set; }
    /// <summary>
    /// 运营商编码
    /// </summary>
    public string OperatorId { get; set; }
    /// <summary>
    /// 国家编码
    /// </summary>
    public string CountryId { get; set; }
    /// <summary>
    /// 货币编码
    /// </summary>
    public string CurrencyId { get; set; }
    /// <summary>
    /// 应用编码
    /// </summary>
    public string AppId { get; set; }
    /// <summary>
    /// 领取奖金
    /// </summary>
    public decimal RewardAmount { get; set; }
    /// <summary>
    /// 是否bouns
    /// </summary>
    public bool IsBouns { get; set; }
    /// <summary>
    /// 赠金提现所需要的流水倍数
    /// </summary>
    public float FlowMultip { get; set; }
    /// <summary>
    /// 活动类型
    /// </summary>
    public int SourceType { get; set; }
    /// <summary>
    /// 活动详情表名
    /// </summary>
    public string SourceTable { get; set; }
    /// <summary>
    /// 活动详情表Id
    /// </summary>
    public string SourceId { get; set; }
    public MQMessageMeta MQMeta { get; set; }
}