//using SComms.Promoter.Core.Repositories;
//using TinyFx;
//using TinyFx.Caching;
//using TinyFx.Extensions.StackExchangeRedis;

//namespace SComms.Promoter.Core.Caching;

//public class SfPromoterVipDCache : RedisStringClient<List<Sf_promoter_vipEO>>
//{
//    public string OperatorId { get; }
//    public TimeSpan EXPIRE_SPAN { get; } // 缓存有效期3天
//    public SfPromoterVipDCache(string operatorId)
//    {
//        if (string.IsNullOrWhiteSpace(operatorId))
//            throw new ArgumentNullException($"{nameof(operatorId)}不能为空！");
//        OperatorId = operatorId;
//        RedisKey = GetProjectRedisKey(operatorId);
//        EXPIRE_SPAN = TimeSpan.FromDays(3);
//    }

//    public async Task<List<Sf_promoter_vipEO>> GetDo()
//    {
//        var result = await GetOrLoadAsync(false, expire: EXPIRE_SPAN);
//        if (!result.HasValue)
//            throw new CustomException($"Sf_promoter_vipEO配置不能为空！operatorid:{OperatorId}");
//        return result.Value;
//    }

//    protected override async Task<CacheValue<List<Sf_promoter_vipEO>>> LoadValueWhenRedisNotExistsAsync()
//    {
//        var result = await new Sf_promoter_vipMO().GetAsync("OperatorID=@OperatorID", OperatorId);
//        var hasValue = result != null && result.Any();
//        return new CacheValue<List<Sf_promoter_vipEO>>(hasValue, result);
//    }
//}