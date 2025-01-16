using Microsoft.Extensions.DependencyInjection;
using SComms.Email.Core;
using SComms.Email.Models;
using System;
using System.Threading.Tasks;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.StackExchangeRedis;

namespace SComms.Email.Services;

public class UserService
{
    private readonly IServiceProvider serviceProvider = GlobalServiceProvider.ServiceProvider;

    public async Task<SSimpleUser> Get(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;
        if (!request.TryGetTo("userId", out string userId))
            throw new Exception("丢失请求参数userId");

        var redisService = this.serviceProvider.GetService<RedisService>();
        var cacheKey = RedisUtil.GetProjectGroupRedisKey("UserInfo", typeof(SSimpleUser), userId);
        (var hasCache, var cacheValue) = await redisService.GetAsync<SSimpleUser>(cacheKey);
        if (!hasCache || cacheValue == null)
        {
            using var sqlSugar = DbUtil.GetDb();
            cacheValue = await sqlSugar.Queryable<SSimpleUser>()
                .Where(f => f.UserId == userId)
                .FirstAsync();
            await redisService.SetAsync(cacheKey, cacheValue);
        }
        return cacheValue;
    }
    public async Task<SSimpleUser> GetReferrer(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;
        if (!request.TryGetTo("referrerId", out string referrerId))
            throw new Exception("丢失请求参数referrerId");

        var redisService = this.serviceProvider.GetService<RedisService>();
        var cacheKey = RedisUtil.GetProjectGroupRedisKey("UserInfo", typeof(SSimpleUser), referrerId);
        (var hasCache, var cacheValue) = await redisService.GetAsync<SSimpleUser>(cacheKey);
        if (!hasCache || cacheValue == null)
        {
            using var sqlSugar = DbUtil.GetDb();
            cacheValue = await sqlSugar.Queryable<SSimpleUser>()
                .Where(f => f.UserId == referrerId)
                .FirstAsync();
            await redisService.SetAsync(cacheKey, cacheValue);
        }
        return cacheValue;
    }
}
