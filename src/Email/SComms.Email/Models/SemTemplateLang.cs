using SqlSugar;

namespace SComms.Email.Models;

/// <summary>
/// 邮件模板语言表
/// </summary>
[SugarTable("sem_template_lang")]
public class SemTemplateLang
{
    /// <summary>
    /// 模板ID
    /// </summary>
    public string TemplateID { get; set; }
    /// <summary>
    /// 语言代码
    /// </summary>
    public string LangID { get; set; }
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }
}

