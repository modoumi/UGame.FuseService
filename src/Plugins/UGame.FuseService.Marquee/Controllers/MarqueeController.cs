using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using UGame.FuseService.Marquee.Models.Dtos;
using UGame.FuseService.Marquee.Models.Ipos;
using UGame.FuseService.Marquee.Services;
using TinyFx.AspNet;
using TinyFx.AspNet.ClientSign;

namespace SComms.Plugins.Banner.Controllers;

/// <summary>
/// 跑马灯服务
/// </summary>
[EnableCors()]
[ClientSignFilter()]
public class MarqueeController : TinyFxControllerBase
{
    /// <summary>
    /// Marquee
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<SCMarqueeDto>> Marquee(SCMarqueeIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await new MarqueeService().Marquee(ipo);
    }
    //[HttpPost, AllowAnonymous]
    //public async Task Test()
    //{
    //    var json = "{\"MQMeta\":{\"RoutingKey\":null,\"Delay\":\"00:00:00\",\"MessageId\":\"658a4458f26282a72c395068\",\"Timestamp\":1703560280901,\"ErrorAction\":null,\"RepublishCount\":0},\"UserId\":\"4b8edab9-5601-4436-8d91-ef6259cb666a\",\"UserKind\":1,\"AppId\":\"super_phoenix\",\"OperatorId\":\"own_lobby_bra\",\"CountryId\":\"BRA\",\"CurrencyId\":\"BRL\",\"CurrencyType\":9,\"BetTime\":\"2023-12-26T03:11:20.8393963Z\",\"ProviderId\":\"own\",\"BetType\":3,\"IsFirst\":false,\"BetAmount\":1000000,\"BetBonus\":1000000,\"WinAmount\":5200000,\"WinBonus\":5200000,\"Amount\":4200000,\"OrderId\":\"658a4458f26282a72c395067\",\"ReferOrderIds\":null,\"RoundClosed\":true,\"RoundId\":\"3b298c38-9508-4cec-8f9e-a668dea9f542\"}";
    //    var message = JsonConvert.DeserializeObject<UserBetMsg>(json);
    //    var consumer = new MarqueeConsumer();
    //    await consumer.UpdateMarquee(message, CancellationToken.None);
    //}
}
