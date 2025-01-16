using SqlSugar;
using System;

namespace UGame.FuseService.Email.Models;

/// <summary>
/// 用户邮件表，描述发给指定用户的邮件，通常是不批量的，或是私信
/// </summary>
[SugarTable("sem_user_message")]
public class SemUserMessage
{
    /// <summary>
    /// 消息ID
    /// </summary>
    [SugarColumn(IsPrimaryKey = true)]
    public string MessageID { get; set; }

    /// <summary>
    /// 应用编码
    /// </summary>
    public string AppID { get; set; }

    /// <summary>
    /// 发送人ID
    /// </summary>
    public string SenderID { get; set; }

    /// <summary>
    /// 接收人ID
    /// </summary>
    public string ReceiverID { get; set; }

    /// <summary>
    /// 模板ID（null表示Data为最终信息）
    /// </summary>
    public string TemplateID { get; set; }

    /// <summary>
    /// 显示分类
    /// </summary>
    public int DisplayTag { get; set; }

    /// <summary>
    /// 标题，不是模板邮件此栏位有值
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 内容（模板数据JSON或者最终内容字符串)
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 生效日期
    /// </summary>
    public DateTime BeginDate { get; set; }

    /// <summary>
    /// 失效日期
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// 状态 0-无读1-已读
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
