using TinyFx.Caching;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.StackExchangeRedis;
using UGame.FuseService.Marquee.Repositories;

namespace UGame.FuseService.Marquee.Caching;

/// <summary>
/// 
/// </summary>
public class ScMarqueeConfigDCache : RedisStringClient<List<Sc_marquee_configPO>>
{
    private const int EXPIRE_DAY = 1;

    private string OperatorId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ScMarqueeConfigDCache()
    {
        RedisKey = GetProjectRedisKey($"AllScMarqueeConfig");
        Options.SlidingExpiration = TimeSpan.FromDays(EXPIRE_DAY);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override async Task<CacheValue<List<Sc_marquee_configPO>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<Sc_marquee_configPO>>
        {
            Value = await DbUtil.GetRepository<Sc_marquee_configPO>().AsQueryable()
            .ToListAsync()
        };

        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<Sc_marquee_configPO>>> GetAsync()
    {
        return await GetOrLoadAsync(false);
    }

    /// <summary>
    /// SetAsync
    /// </summary>
    /// <returns></returns>
    public async Task SetAsync()
    {
        await GetOrLoadAsync(true);
    }

}
