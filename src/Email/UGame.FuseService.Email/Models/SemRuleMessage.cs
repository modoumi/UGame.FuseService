using SqlSugar;
using System;

namespace UGame.FuseService.Email.Models;

/// <summary>
/// 规则邮件，通常是给一批人发的邮件，当前人执行规则，满足时才会捞取当前邮件
/// </summary>
[SugarTable("sem_rule_message")]
public class SemRuleMessage
{
    /// <summary>
    /// 消息ID
    /// </summary>
    public string MessageID { get; set; }

    /// <summary>
    /// 应用编码
    /// </summary>
    public string AppID { get; set; }

    /// <summary>
    /// 模板ID（null表示Data为最终信息）
    /// </summary>
    public string TemplateID { get; set; }

    /// <summary>
    /// 发送人ID
    /// </summary>
    public string SenderID { get; set; }

    /// <summary>
    /// 显示分类
    /// </summary>
    public int DisplayTag { get; set; }

    /// <summary>
    /// 内容（模板数据JSON或者最终内容）
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 捞取规则表达式（如：User.RegisterDate.Subtract(DateTime.UtcNow).TotalDays>2）
    /// </summary>
    public int RuleExpr { get; set; }

    /// <summary>
    /// 生效日期，邮件本身的生效时间
    /// </summary>
    public DateTime BeginDate { get; set; }

    /// <summary>
    /// 失效日期，邮件本身的生效时间
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// 记录时间
    /// </summary>
    public DateTime RecDate { get; set; }
}
