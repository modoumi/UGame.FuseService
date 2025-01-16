using SqlSugar.Extensions;
using System;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data.SqlSugar;
using UGame.FuseService.Email.Models;

namespace UGame.FuseService.Email.Services;

/// <summary>
/// 
/// </summary>
public class DepositService
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="engineParameter"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<long> GetTotalDepositAmountDaily(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;

        if (!request.TryGetValue("userId", out var userId)) throw new Exception("丢失请求参数userId");

        if (!request.TryGetValue("dayId", out var dayId)) throw new Exception("丢失请求参数dayId");

        if (!request.TryGetValue("itemId", out var itemId)) throw new Exception("丢失请求参数itemId");


        return await DbUtil.GetRepository<SatDepositDay>().AsQueryable()
            .Where(f => f.UserID == userId.ToString() && f.DayID == dayId.ObjToDate() && f.ItemID == itemId.ObjToInt())
            .SumAsync(f => f.DepositAmount);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="engineParameter"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<long> GetTotalDepositAmountWeekly(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;
        if (!request.TryGetValue("userId", out var userId)) throw new Exception("丢失请求参数userId");

        if (!request.TryGetValue("dayId", out var dayId)) throw new Exception("丢失请求参数dayId");

        if (!request.TryGetValue("itemId", out var itemId)) throw new Exception("丢失请求参数itemId");

        if (itemId.ObjToInt() == 100023)
        {
            itemId = 100024;
            dayId = DateTimeUtil.BeginDayOfWeek(dayId.ObjToDate());
        }

        return await DbUtil.GetRepository<SatDepositDay>().AsQueryable()
            .Where(f => f.UserID == userId.ToString() && f.DayID == dayId.ObjToDate() && f.ItemID == itemId.ObjToInt())
            .SumAsync(f => f.DepositAmount);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="engineParameter"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<long> GetTotalDepositAmountMonthly(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;

        if (!request.TryGetValue("userId", out var userId)) throw new Exception("丢失请求参数userId");

        if (!request.TryGetValue("dayId", out var dayId)) throw new Exception("丢失请求参数dayId");

        if (!request.TryGetValue("itemId", out var itemId)) throw new Exception("丢失请求参数itemId");

        if (itemId.ObjToInt() == 100023)
        {
            itemId = 100025;
            dayId = DateTimeUtil.LastDayOfPrdviousMonth(dayId.ObjToDate()).AddDays(1);
        }

        return await DbUtil.GetRepository<SatDepositDay>().AsQueryable()
            .Where(f => f.UserID == userId.ToString() && f.DayID == dayId.ObjToDate() && f.ItemID == itemId.ObjToInt())
            .SumAsync(f => f.DepositAmount);
    }
}
