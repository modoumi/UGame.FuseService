using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace UGame.FuseService.Email.Services;

/// <summary>
/// Redis服务
/// </summary>
public class RedisService
{
    private readonly int databaseIndex = -1;
    private readonly string url;
    private readonly ConnectionMultiplexer connectionPool;

    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="ArgumentNullException"></exception>
    public RedisService()
    {
        this.url = ConfigUtil.Configuration["Redis:ConnectionStrings:default:ConnectionString"];

        if (string.IsNullOrEmpty(this.url))
            throw new ArgumentNullException("appsettings.json中缺少Redis:ConnectionStrings:default配置项");

        this.connectionPool = ConnectionMultiplexer.Connect(url);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <param name="lifetimeMinutes"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public async Task SetAsync(string key, object value, int lifetimeMinutes = 60)
    {
        if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(key);

        var database = connectionPool.GetDatabase(this.databaseIndex);

        if (lifetimeMinutes == -1)
            await database.StringSetAsync(key, JsonConvert.SerializeObject(value));
        else
            await database.StringSetAsync(key, JsonConvert.SerializeObject(value), TimeSpan.FromMinutes(lifetimeMinutes));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="key"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public async Task<(bool, T)> GetAsync<T>(string key)
    {
        if (string.IsNullOrEmpty(key)) throw new ArgumentNullException(key);

        var database = connectionPool.GetDatabase(this.databaseIndex);
        var redisValue = await database.StringGetAsync(key);

        if (redisValue.IsNull) return (false, default);

        return (true, JsonConvert.DeserializeObject<T>(redisValue));
    }
}
