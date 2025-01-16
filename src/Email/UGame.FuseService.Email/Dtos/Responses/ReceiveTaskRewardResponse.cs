namespace UGame.FuseService.Email.Dtos.Responses;

/// <summary>
/// 接收奖励响应
/// </summary>
public class ReceiveTaskRewardResponse
{
    /// <summary>
    /// 是否成功
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// 响应码
    /// </summary>
    public int Code { get; set; }

    /// <summary>
    /// 响应消息
    /// </summary>
    public string Message { get; set; }
}