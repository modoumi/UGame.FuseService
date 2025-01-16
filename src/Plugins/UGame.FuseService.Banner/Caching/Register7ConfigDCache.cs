using TinyFx.Caching;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.StackExchangeRedis;
using UGame.FuseService.Banner.Repositories;

namespace UGame.FuseService.Banner.Caching
{
    /// <summary>
    /// Register7ConfigDCache
    /// </summary>
    public class Register7ConfigDCache : RedisHashExpireClient<Sa_register100007_configPO>
    {
        private const int EXPIRE_DAY = 5;

        /// <summary>
        /// Register7ConfigDCache
        /// </summary>
        public Register7ConfigDCache()
        {
            RedisKey = GetProjectGroupRedisKey("Activity");
        }

        public static string GetField(string operatorId, string currencyId) => $"{operatorId}|{currencyId}";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        protected override async Task<CacheValue<CacheItem<Sa_register100007_configPO>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var keys = field.Split('|');
            var operatorId = keys[0];
            var currencyId = keys[1];

            var value = (await DbUtil.SelectAsync<Sa_register100007_configPO>(it =>
            it.OperatorID.Equals(operatorId) && it.CurrencyID.Equals(currencyId))).FirstOrDefault();

            var ret = new CacheValue<CacheItem<Sa_register100007_configPO>>
            {
                HasValue = value != null,
                Value = new CacheItem<Sa_register100007_configPO>(value, TimeSpan.FromMinutes(EXPIRE_DAY))
            };

            return ret;
        }

    }
}
