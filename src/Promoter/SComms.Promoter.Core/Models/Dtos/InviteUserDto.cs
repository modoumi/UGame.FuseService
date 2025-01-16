namespace SComms.Promoter.Core.Models.Dtos;

public class InviteUserDto
{
    /// <summary>
    /// 用户主键
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// 用户名
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// 手机号
    /// </summary>
    public string Mobile { get; set; }


    /// <summary>
    /// 加入时间
    /// </summary>
    public DateTime PromoteTime { get; set; }
}