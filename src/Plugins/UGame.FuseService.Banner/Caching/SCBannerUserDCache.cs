using TinyFx.Extensions.StackExchangeRedis;

namespace UGame.FuseService.Banner.Caching
{
    /// <summary>
    /// SCBannerUserDCache
    /// </summary>
    public class SCBannerUserDCache : RedisHashExpireClient
    {
        private string OperatorId { get; set; }

        private string UserId { get; set; }

        /// <summary>
        /// SCBannerUserDCache
        /// </summary>
        public SCBannerUserDCache(string operatorId, string userId)
        {
            this.UserId = userId;
            this.OperatorId = operatorId;
            RedisKey = GetProjectGroupRedisKey("Banners", $"{this.OperatorId}:{this.UserId}");
        }

        /// <summary>
        /// GetValueAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <returns></returns>
        public async Task<T> GetValueAsync<T>(string field)
        {
            return await GetOrDefaultAsync<T>(field, default(T));
        }
    }
}
