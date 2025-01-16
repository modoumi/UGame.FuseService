//using SComms.Promoter.Core.Repositories;
//using TinyFx.Caching;
//using TinyFx.Extensions.StackExchangeRedis;

//namespace SComms.Promoter.Core.Caching;

//public class SfPromoterConfigDCache : RedisStringClient<Sf_promoter_configEO>
//{
//    public string OperatorId { get; }
//    public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
//    public SfPromoterConfigDCache(string operatorId)
//    {
//        if (string.IsNullOrWhiteSpace(operatorId))
//            throw new ArgumentNullException($"{nameof(operatorId)}不能为空！");
//        OperatorId = operatorId;
//        RedisKey = GetProjectRedisKey(operatorId);
//        EXPIRE_SPAN = TimeSpan.FromDays(3);
//    }

//    public async Task<Sf_promoter_configEO> GetDo()
//    {
//        var result = await GetOrLoadAsync(false, expire: EXPIRE_SPAN);
//        if (!result.HasValue)
//            throw new TinyFx.CustomException($"Sf_promoter_configEO配置不能为空！operatorid:{OperatorId}");
//        return result.Value;
//    }

//    protected override async Task<CacheValue<Sf_promoter_configEO>> LoadValueWhenRedisNotExistsAsync()
//    {
//        var result = await new Sf_promoter_configMO().GetByPKAsync(OperatorId);
//        var hasValue = result != null;
//        return new CacheValue<Sf_promoter_configEO>(hasValue, result);
//    }
//}