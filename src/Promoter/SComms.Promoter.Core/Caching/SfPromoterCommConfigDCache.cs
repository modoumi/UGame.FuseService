//using SComms.Promoter.Core.Repositories;
//using TinyFx;
//using TinyFx.Caching;
//using TinyFx.Extensions.StackExchangeRedis;

//namespace SComms.Promoter.Core.Caching;

//public class SfPromoterCommConfigDCache : RedisStringClient<List<Sf_promoter_comm_configEO>>
//{
//    public string OperatorId { get; }
//    public int PromoterType { get; }
//    public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
//    public SfPromoterCommConfigDCache(string operatorId, int promoterType)
//    {
//        if (string.IsNullOrWhiteSpace(operatorId))
//            throw new ArgumentNullException($"{nameof(operatorId)}不能为空！");
//        OperatorId = operatorId;
//        PromoterType = promoterType;
//        RedisKey = GetProjectRedisKey($"{operatorId}|{promoterType}");
//        EXPIRE_SPAN = TimeSpan.FromDays(3);
//    }

//    public async Task<List<Sf_promoter_comm_configEO>> GetDo()
//    {
//        var result = await GetOrLoadAsync(false, expire: EXPIRE_SPAN);
//        if (!result.HasValue)
//            throw new CustomException($"Sf_promoter_comm_configEO配置不能为空！operatorid:{OperatorId},promoterType:{PromoterType}");
//        return result.Value;
//    }

//    protected override async Task<CacheValue<List<Sf_promoter_comm_configEO>>> LoadValueWhenRedisNotExistsAsync()
//    {
//        var result = await new Sf_promoter_comm_configMO().GetAsync("OperatorID=@OperatorID and PromoterType=@PromoterType", OperatorId, PromoterType);
//        var hasValue = result != null && result.Any();
//        return new CacheValue<List<Sf_promoter_comm_configEO>>(hasValue, result);
//    }
//}