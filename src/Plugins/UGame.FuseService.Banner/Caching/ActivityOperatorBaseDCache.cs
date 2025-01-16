using TinyFx.Caching;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.StackExchangeRedis;
using UGame.FuseService.Banner.Repositories;

namespace UGame.FuseService.Banner.Caching;

/// <summary>
/// 运营商活动配置数据
/// </summary>
public class ActivityOperatorBaseDCache : RedisStringClient<List<L_activity_operatorPO>>
{
    private const int EXPIRE_MINUTE = 10;

    private string OperatorId { get; set; }

    public string CurrencyId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="operatorId">运营商编码</param>
    /// <param name="currencyId">货币编码</param>
    public ActivityOperatorBaseDCache(string operatorId, string currencyId)
    {
        this.OperatorId = operatorId;
        this.CurrencyId = currencyId;
        RedisKey = GetProjectGroupRedisKey("Activity", $"{this.OperatorId}|{this.CurrencyId}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override async Task<CacheValue<List<L_activity_operatorPO>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<L_activity_operatorPO>>
        {
            Value = await DbUtil.SelectAsync<L_activity_operatorPO>(it =>
                    it.OperatorID.Equals(this.OperatorId) && it.CurrencyID.Equals(this.CurrencyId))
        };

        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<L_activity_operatorPO>>> GetAsync()
    {
        return await GetOrLoadAsync(false, TimeSpan.FromDays(EXPIRE_MINUTE));
    }

    /// <summary>
    /// SetAsync
    /// </summary>
    /// <returns></returns>
    public async Task SetAsync()
    {
        await GetOrLoadAsync(true, TimeSpan.FromDays(EXPIRE_MINUTE));
    }
}
