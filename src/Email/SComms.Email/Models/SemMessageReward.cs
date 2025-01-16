using SqlSugar;
using System;

namespace SComms.Email.Models;

/// <summary>
/// 用户邮件奖励表，描述发给指定用户的奖励邮件相关的数据
/// </summary>
[SugarTable("sem_message_reward")]
public class SemMessageReward
{
    /// <summary>
    /// 消息ID
    /// </summary>
    public string MessageID { get; set; }
    /// <summary>
    /// 接收人ID
    /// </summary>
    public string ReceiverID { get; set; }
    /// <summary>
    /// 金额类型 1-Bonus 2-真金
    /// </summary>
    public int AmountType { get; set; }
    /// <summary>
    /// 奖励金额
    /// </summary>
    public long RewardAmount { get; set; }
    /// <summary>
    /// 赠金提现所需要的流水倍数
    /// </summary>
    public int FlowMultip { get; set; }
    /// <summary>
    /// 数据来源类型
    /// </summary>
    public int SourceType { get; set; }
    /// <summary>
    /// 数据来源表名
    /// </summary>
    public string SourceTable { get; set; }
    /// <summary>
    /// 数据ID
    /// </summary>
    public string SourceId { get; set; }
    /// <summary>
    /// 状态 0-未领取 1-已领取
    /// </summary>
    public int Status { get; set; }
    /// <summary>
    /// 记录时间
    /// </summary>
    public DateTime RecDate { get; set; }
    /// <summary>
    /// 更新时间
    /// </summary>
    public DateTime UpdateTime { get; set; }
}
