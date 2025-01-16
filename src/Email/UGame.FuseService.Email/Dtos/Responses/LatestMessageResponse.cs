using System.Collections.Generic;

namespace UGame.FuseService.Email.Dtos.Responses;

/// <summary>
/// 最新消息
/// </summary>
public class LatestMessageResponse
{
    /// <summary>
    /// 读取消息列表
    /// </summary>
    public List<ReadingTagMapDto> Maps { get; set; }

    /// <summary>
    /// 消息列表
    /// </summary>
    public List<LatestMessageDto> Messages { get; set; }
}

/// <summary>
/// 读取标识
/// </summary>
public class ReadingTagMapDto
{
    /// <summary>
    /// 展示标识
    /// </summary>
    public int DisplayTag { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    public int Count { get; set; }
}

/// <summary>
/// 最新消息
/// </summary>
public class LatestMessageDto
{
    /// <summary>
    /// 消息Id
    /// </summary>
    public string MessageId { get; set; }

    /// <summary>
    /// 发送人Id
    /// </summary>
    public string SenderId { get; set; }

    /// <summary>
    /// 接收人Id
    /// </summary>
    public string ReceiverId { get; set; }

    /// <summary>
    /// 展示标签
    /// </summary>
    public int DisplayTag { get; set; }

    /// <summary>
    /// 模板Id
    /// </summary>
    public string TemplateID { get; set; }

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    public int Status { get; set; }

    /// <summary>
    /// 接收时间
    /// </summary>
    public string RecDate { get; set; }

    /// <summary>
    /// 金额类型
    /// </summary>
    public int AmountType { get; set; }

    /// <summary>
    /// 奖励金额
    /// </summary>
    public decimal RewardAmount { get; set; }

    /// <summary>
    /// 来源Id
    /// </summary>
    public string SourceId { get; set; }

    /// <summary>
    /// 接收状态
    /// </summary>
    public int ReceiveStatus { get; set; }
}
