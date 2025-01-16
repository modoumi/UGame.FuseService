using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Extensions.StackExchangeRedis;

namespace UGame.FuseService.Banner.Caching
{
    /// <summary>
    /// SCBannerDayUserDCache
    /// </summary>
    public class SCBannerDayUserDCache : RedisStringClient<bool>
    {

        private const int EXPIRE_HOURS = 25;

        private string UserId { get; set; }

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
        private int Position { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private DateTime LocalDate { get; set; }

        /// <summary>
        /// SCBannerDayUserDCache
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="bannerType"></param>
        /// <param name="appId"></param>
        /// <param name="operatorId"></param>
        /// <param name="langId"></param>
        /// <param name="position"></param>
        /// <param name="localDate"></param>
        public SCBannerDayUserDCache(string userId, int bannerType, string appId, string operatorId, string langId, int position, DateTime localDate)
        {
            this.UserId = userId;
            this.BannerType = bannerType;
            this.LangId = langId;
            this.AppId = appId;
            this.Position = position;
            this.OperatorId = operatorId;
            this.LocalDate = localDate;
            RedisKey = GetProjectGroupRedisKey("Banners", $"{LocalDate.ToString("yyyyMMdd")}:{this.UserId}:{this.OperatorId}|{this.AppId}|{this.BannerType}|{this.LangId}|{this.Position}");
        }

        /// <summary>
        /// GetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<bool> GetAsync()
        {
            return await GetOrDefaultAsync(false);
        }

        /// <summary>
        /// SetAsync
        /// </summary>
        /// <returns></returns>
        public async Task<bool> SetAsync()
        {
            return await SetAsync(true, TimeSpan.FromHours(EXPIRE_HOURS));
        }

    }
}
