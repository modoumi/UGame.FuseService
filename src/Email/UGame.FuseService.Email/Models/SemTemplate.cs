using SqlSugar;
using System;

namespace UGame.FuseService.Email.Models;

/// <summary>
/// 邮件模板，通常是常用的邮件，例如：通知类，固定业务类等邮件，才会有模板
/// </summary>
[SugarTable("sem_template")]
public class SemTemplate
{
    /// <summary>
    /// 模板ID
    /// </summary>
    public string TemplateID { get; set; }

    /// <summary>
    /// 模板KEY
    /// </summary>
    public string TemplateKey { get; set; }

    /// <summary>
    /// 模板名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 筛选条件表达式，如：User.OperatorId="own_lobby_bra"
    /// </summary>
    public string ConditionExpr { get; set; }

    /// <summary>
    /// 显示分类
    /// </summary>
    public int DisplayTag { get; set; }

    /// <summary>
    /// 内容类型 0-文本 1-富文本2-JSON格式
    /// </summary>
    public int ContentType { get; set; }

    /// <summary>
    /// 显示标题，后台显示使用
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 状态(0-无效1-有效)
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