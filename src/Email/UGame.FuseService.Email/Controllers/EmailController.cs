using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using UGame.FuseService.Email.Core;
using System.Threading;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.AspNet;
using TinyFx.AspNet.ClientSign;
using UGame.FuseService.Email.Dtos.Requests;
using UGame.FuseService.Email.Dtos.Responses;
using UGame.FuseService.Email.Services;

namespace UGame.FuseService.Email.Controllers;

/// <summary>
/// 邮件接口
/// </summary>
[EnableCors()]
[ClientSignFilter()]
public class EmailController : TinyFxControllerBase
{
    private readonly EmailService emailService;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="emailService"></param>
    public EmailController(EmailService emailService)
        => this.emailService = emailService;

    /// <summary>
    /// 获取最新的消息列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<LatestMessageResponse> GetLatestMessage(LatestMessageRequest ipo)
    {
        ipo.UserId = UserId;
        return await emailService.GetLatestMessage(ipo);
    }

    /// <summary>
    /// 读取邮件信息
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    [HttpPost]
    public async Task<int> ReadMessage(ReadMessageRequest request)
        => await emailService.ReadMessages(request.Ids);

    /// <summary>
    /// 领取奖励
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    [HttpPost]
    public async Task TakeReward(DetailMessageRequest request)
    {
        request.UserId = UserId;
        await emailService.TakeReward(request.UserId, request.MessageId, request.OperatorId, request.CountryId, request.CurrencyId, request.AppId);
    }

    /// <summary>
    /// 删除邮件信息
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    [HttpPost]
    public async Task<bool> DeleteMessage(ReadMessageRequest request)
    {
        request.UserId = UserId;
        return await emailService.DeleteMessage(request.Ids);
    }

    /// <summary>
    /// 获取邮件详情
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<LatestMessageDto> DetailMessage(DetailMessageRequest request)
    {
        request.UserId = UserId;
        return await emailService.GetMessageDetail(request.MessageId, request.OperatorId, request.CurrencyId, request.LangId);
    }

    /// <summary>
    /// 获取最新的消息数量
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellation"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<int> LatestMessageCount(BaseIpo request, CancellationToken cancellation)
    {
        request.UserId = UserId;
        return await emailService.GetLatestMessageCount(request.UserId, cancellation);
    }
}
