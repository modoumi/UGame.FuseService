using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TinyFx.AspNet;
using TinyFx.AspNet.ClientSign;
using UGame.FuseService.Notify.Dtos;
using UGame.FuseService.Notify.Services;

namespace UGame.FuseService.Notify.Controllers;


[EnableCors()]
[ClientSignFilter()]
public class NotifyController : TinyFxControllerBase
{
    private readonly NotifyServices _services = new();


    [HttpPost]
    public async Task<List<SCNotifyDto>> Notify(SCNotifyIpo ipo)
    {
        ipo.UserId = base.UserId;
        return await _services.LoadNotify(ipo);
    }
}
