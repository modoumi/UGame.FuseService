using SComms.Email.Core;
using SComms.Email.Models;
using System;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data.SqlSugar;

namespace SComms.Email.Services;

public class DepositService
{ 
    public async Task<long> GetTotalDepositAmountDaily(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;
        if (!request.TryGetTo("userId", out string userId))
            throw new Exception("丢失请求参数userId");
        if (!request.TryGetTo("dayId", out DateTime dayId))
            throw new Exception("丢失请求参数dayId");
        if (!request.TryGetTo("itemId", out int itemId))
            throw new Exception("丢失请求参数itemId");
        using var sqlSugar = DbUtil.GetDb();
        return await sqlSugar.Queryable<SatDepositDay>()
            .Where(f => f.UserID == userId && f.DayID == dayId && f.ItemID == itemId)
            .SumAsync(f => f.DepositAmount);
        //var sql = "select IFNULL(sum(DepositAmount),0) from sat_deposit_day where UserId=@UserId and DayId=@DayId and ItemID=@ItemId";
        //return await database.QueryFirstAsync<long>(sql, new { UserId = userId, DayId = dayId, ItemId = itemId });
    }
    public async Task<long> GetTotalDepositAmountWeekly(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;
        if (!request.TryGetTo("userId", out string userId))
            throw new Exception("丢失请求参数userId");
        if (!request.TryGetTo("dayId", out DateTime dayId))
            throw new Exception("丢失请求参数dayId");
        if (!request.TryGetTo("itemId", out int itemId))
            throw new Exception("丢失请求参数itemId");
        if (itemId == 100023)
        {
            itemId = 100024;
            dayId = dayId.BeginDayOfWeek();
        }
        using var sqlSugar = DbUtil.GetDb();
        return await sqlSugar.Queryable<SatDepositDay>()
            .Where(f => f.UserID == userId && f.DayID == dayId && f.ItemID == itemId)
            .SumAsync(f => f.DepositAmount);
        //var sql = "select IFNULL(sum(DepositAmount),0) from sat_deposit_day where UserId=@UserId and DayId=@DayId and ItemID=@ItemId";
        //return await database.QueryFirstAsync<long>(sql, new { UserId = userId, DayId = dayId, ItemId = itemId });
    }
    public async Task<long> GetTotalDepositAmountMonthly(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;
        if (!request.TryGetTo("userId", out string userId))
            throw new Exception("丢失请求参数userId");
        if (!request.TryGetTo("dayId", out DateTime dayId))
            throw new Exception("丢失请求参数dayId");
        if (!request.TryGetTo("itemId", out int itemId))
            throw new Exception("丢失请求参数itemId");
        if (itemId == 100023)
        {
            itemId = 100025;
            dayId = dayId.LastDayOfPrdviousMonth().AddDays(1);
        }
        using var sqlSugar = DbUtil.GetDb();
        return await sqlSugar.Queryable<SatDepositDay>()
            .Where(f => f.UserID == userId && f.DayID == dayId && f.ItemID == itemId)
            .SumAsync(f => f.DepositAmount);
        //var sql = "select IFNULL(sum(DepositAmount),0) from sat_deposit_day where UserId=@UserId and DayId=@DayId and ItemID=@ItemId";
        //return await database.QueryFirstAsync<long>(sql, new { UserId = userId, DayId = dayId, ItemId = itemId });
    }
}
