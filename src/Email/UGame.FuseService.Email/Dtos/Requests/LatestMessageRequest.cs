using UGame.FuseService.Email.Core;

namespace UGame.FuseService.Email.Dtos.Requests;

/// <summary>
/// 
/// </summary>
public class LatestMessageRequest : BaseIpo
{
    /// <summary>
    /// 页码，默认20
    /// </summary>
    public int PageSize { get; } = 20;

    /// <summary>
    /// 分页，第一页以1开始
    /// </summary>
    public int PageIndex { get; set; }

    /// <summary>
    /// 邮件类型0系统消息1最新动态2奖励邮件3私信
    /// </summary>
    public int? Type { get; set; }
}