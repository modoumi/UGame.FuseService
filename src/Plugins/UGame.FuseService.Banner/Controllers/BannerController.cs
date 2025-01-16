using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TinyFx;
using TinyFx.AspNet;
using TinyFx.AspNet.ClientSign;
using UGame.FuseService.Banner.Models.Dtos;
using UGame.FuseService.Banner.Models.Ipos;
using UGame.FuseService.Banner.Services;

namespace UGame.FuseService.Banner.Controllers;

/// <summary>
/// 
/// </summary>
[EnableCors()]
[ClientSignFilter()]
public class BannerController : TinyFxControllerBase
{
    /// <summary>
    /// 广告管理
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    [HttpPost]
    public async Task<Dictionary<int, List<SCBannerDto>>> Banner(SCBannerIpo ipo)
    {
        ipo.UserId = base.UserId;

        if (ipo.Position == null || !ipo.Position.Any()) throw new CustomException("RS_PARAMETER_ERROR", $"parameter error.");

        return await new BannerService().Banner(ipo);
    }
}
