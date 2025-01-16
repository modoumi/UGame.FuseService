using TinyFx.Caching;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.AutoMapper;
using TinyFx.Extensions.StackExchangeRedis;
using UGame.FuseService.Banner.Models.Dtos;
using UGame.FuseService.Banner.Repositories;

namespace UGame.FuseService.Banner.Caching;

/// <summary>
/// 
/// </summary>
public class SCBannerDCache : RedisStringClient<List<SCBannerDto>>
{
    private const int EXPIRE_MINUTES = 60;

    /// <summary>
    /// banner类型
    /// 1-游客2-注册用户3-...
    /// </summary>
    private int BannerType { get; set; }
    /// <summary>
    /// 应用编码
    /// </summary>
    private string AppId { get; set; }
    /// <summary>
    /// 运营商编码
    /// </summary>
    private string OperatorId { get; set; }
    /// <summary>
    /// 语言编码
    /// </summary>
    private string LangId { get; set; }
    /// <summary>
    /// 位置
    /// </summary>
    public int Position { get; set; }


    public SCBannerDCache(int bannerType, string appId, string operatorId, string langId, int position)
    {
        this.BannerType = bannerType;
        this.AppId = appId;
        this.OperatorId = operatorId;
        this.LangId = langId;
        this.Position = position;

        RedisKey = GetProjectRedisKey($"{this.OperatorId}|{this.AppId}|{this.BannerType}|{this.LangId}|{this.Position}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected override async Task<CacheValue<List<SCBannerDto>>> LoadValueWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<List<SCBannerDto>>();

        var dbData = (await DbUtil.SelectAsync<Sc_bannerPO>(it =>
            it.BannerType == this.BannerType
            && AppId.Equals(this.AppId)
            && it.Position == this.Position
            && it.Status == 1
            && it.OperatorID.Equals(this.OperatorId)
            && it.LangID.Equals(this.LangId)))
            .OrderBy(d => d.OrderNum).ToList();

        ret.Value = dbData.Map<List<SCBannerDto>>();
        ret.HasValue = ret.Value != null && ret.Value.Any();

        return ret;
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <returns></returns>
    public async Task<CacheValue<List<SCBannerDto>>> GetAsync()
    {
        return await GetOrLoadAsync(false, TimeSpan.FromMinutes(EXPIRE_MINUTES));
    }

    /// <summary>
    /// GetAsync
    /// </summary>
    /// <param name="enforce"></param>
    /// <returns></returns>
    public async Task<List<SCBannerDto>> GetAsync(bool enforce = false)
    {
        var cacheData = await GetOrLoadAsync(enforce, TimeSpan.FromMinutes(EXPIRE_MINUTES));
        if (cacheData.HasValue)
        {
            cacheData.Value.ForEach(f => f.Content ??= "");
            return cacheData.Value;
        }
        return new List<SCBannerDto>();
    }

    /// <summary>
    /// SetAsync
    /// </summary>
    /// <returns></returns>
    public async Task SetAsync()
    {
        await GetOrLoadAsync(true, TimeSpan.FromMinutes(EXPIRE_MINUTES));
    }

}
