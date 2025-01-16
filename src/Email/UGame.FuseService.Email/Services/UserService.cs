using System;
using System.Threading.Tasks;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.StackExchangeRedis;
using UGame.FuseService.Email.Models;

namespace UGame.FuseService.Email.Services;

/// <summary>
/// 
/// </summary>
public class UserService
{
    private readonly RedisService _redisService;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="redisService"></param>
    public UserService(RedisService redisService)
    {
        _redisService = redisService;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="engineParameter"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<SSimpleUser> Get(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;
        if (!request.TryGetValue("userId", out var userId)) throw new Exception("丢失请求参数userId");

        var cacheKey = RedisUtil.GetProjectGroupRedisKey("UserInfo", typeof(SSimpleUser), userId.ToString());

        (var hasCache, var cacheValue) = await _redisService.GetAsync<SSimpleUser>(cacheKey);

        if (!hasCache || cacheValue == null)
        {
            cacheValue = await DbUtil.GetRepository<SSimpleUser>().AsQueryable()
                .Where(f => f.UserId == userId.ToString())
                .FirstAsync();

            await _redisService.SetAsync(cacheKey, cacheValue);
        }
        return cacheValue;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="engineParameter"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<SSimpleUser> GetReferrer(RuleEngineParameter engineParameter)
    {
        var request = engineParameter.RequestParameters;
        if (!request.TryGetValue("referrerId", out var referrerId)) throw new Exception("丢失请求参数referrerId");

        var cacheKey = RedisUtil.GetProjectGroupRedisKey("UserInfo", typeof(SSimpleUser), referrerId.ToString());

        (var hasCache, var cacheValue) = await _redisService.GetAsync<SSimpleUser>(cacheKey);

        if (!hasCache || cacheValue == null)
        {
            cacheValue = await DbUtil.GetRepository<SSimpleUser>().AsQueryable()
                .Where(f => f.UserId == referrerId.ToString())
                .FirstAsync();

            await _redisService.SetAsync(cacheKey, cacheValue);
        }
        return cacheValue;
    }
}
