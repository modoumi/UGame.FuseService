using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SComms.Promoter.Core.Models;
using SComms.Promoter.Core.Models.Dtos;
using SComms.Promoter.Core.Models.Ipos;
using SComms.Promoter.Core.Services;
using TinyFx.AspNet;
using TinyFx.AspNet.ClientSign;
using Xxyy.Common;

namespace UGame.Activity.Promoter;

/// <summary>
/// 推广接口
/// </summary>
[EnableCors()]
[ClientSignFilter()]
public class PromoteController : TinyFxControllerBase
{
    private PromoteService _promoteSvc = new();

    /// <summary>
    /// 等级列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<List<PromoteVipLevelDto>> VipLevel()
    {
        return await _promoteSvc.GetVipLevels(UserId);
    }

    /// <summary>
    /// 当前用户信息
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<PromoteUserDto> UserInfo()
    {
        return await _promoteSvc.UserInfo(UserId);
    }

    /// <summary>
    /// 被邀请用户列表
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<PagerList<InviteUserDto>> InvitedUsers([FromBody] InviteUserIpo ipo)
    {
        return await _promoteSvc.GetInvitedUsers(ipo, UserId);
    }

    /// <summary>
    /// 我的佣金
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<PagerList<PromoteCommDto>> Commission(PromoteCommIpo ipo)
    {
        return await _promoteSvc.Commission(ipo, UserId);
    }

    /// <summary>
    /// 佣金明细
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<PagerList<PromoteCommDetailDto>> CommissionDetail(PromoteCommDetailIpo ipo)
    {
        return await _promoteSvc.CommissionDetail(ipo, UserId);
    }

    /// <summary>
    /// 我的业绩
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<PagerList<PromotePerformanceDto>> Performance(PromotePerformanceIpo ipo)
    {
        return await _promoteSvc.Performance(ipo, UserId);
    }

    /// <summary>
    /// 返佣比例
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<PromoteCommProportionsDto> CommProportions(PromoteCommProportionsIpo ipo)
    {
        return await _promoteSvc.CommProportions(ipo, UserId);
    }

    /// <summary>
    /// 领取接口
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<decimal> Collect([FromBody] PromoterCollectIpo ipo)
    {
        return await _promoteSvc.Collect(UserId, ipo.AppId);
    }

    /// <summary>
    /// 领取记录
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<PagerList<PromoteCollectRecordDto>> CollectRecord(PromoteCollectRecordIpo ipo)
    {
        return await _promoteSvc.CollectRecord(ipo, UserId);
    }
}
