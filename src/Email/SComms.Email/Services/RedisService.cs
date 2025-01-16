using SComms.Email.Core;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;
using TinyFx.Configuration;

namespace SComms.Email.Services;

public class RedisService
{
    private readonly int databaseIndex = -1;
    private readonly string url;
    private readonly ConnectionMultiplexer connectionPool;

    public RedisService( )
    {
        this.url = ConfigUtil.Configuration["Redis:ConnectionStrings:default:ConnectionString"];
        //this.databaseIndex = configuration.GetValue("Redis:Database", -1); 
        if (string.IsNullOrEmpty(this.url))
            throw new ArgumentNullException("appsettings.json中缺少Redis:ConnectionStrings:default配置项");
        this.connectionPool = ConnectionMultiplexer.Connect(url);
    }
    public void Set(string key, object value, int lifetimeMinutes = 60)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(this.databaseIndex);
        database.StringSet(key, value.ToJson(), TimeSpan.FromMinutes(lifetimeMinutes));
    }
    public async Task SetAsync(string key, object value, int lifetimeMinutes = 60)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(this.databaseIndex);
        if (lifetimeMinutes == -1)
            await database.StringSetAsync(key, value.ToJson());
        else
            await database.StringSetAsync(key, value.ToJson(), TimeSpan.FromMinutes(lifetimeMinutes));
    }
    public bool TryGet<T>(string key, out T result)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(this.databaseIndex);
        var redisValue = database.StringGet(key);
        if (redisValue.IsNull)
        {
            result = default;
            return false;
        }
        result = redisValue.ToString().JsonTo<T>();
        return true;
    }
    public async Task<(bool, T)> GetAsync<T>(string key)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(this.databaseIndex);
        var redisValue = await database.StringGetAsync(key);
        if (redisValue.IsNull) return (false, default);
        return (true, redisValue.ToString().JsonTo<T>());
    }
    public async Task<long> IncrementAsync(string key, int lifetimeMinutes = 60)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(this.databaseIndex);
        if (!database.KeyExists(key))
            database.StringSet(key, 0, TimeSpan.FromMinutes(lifetimeMinutes));
        var result = await database.StringIncrementAsync(key);
        return result;
    }
    public async Task RemoveCache(string key)
    {
        if (string.IsNullOrEmpty(key))
            throw new ArgumentNullException(key);
        var database = connectionPool.GetDatabase(this.databaseIndex);
        await database.KeyDeleteAsync(key);
    }
}