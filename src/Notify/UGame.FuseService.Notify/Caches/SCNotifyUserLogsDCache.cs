using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyFx.Caching;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.StackExchangeRedis;
using UGame.FuseService.Notify.Repositories.DAL.ing;

namespace UGame.FuseService.Notify.Caches;

public class SCNotifyUserLogsDCache : RedisHashExpireClient<Sc_notify_user_logPO>
{
    private const int EXPIRE_HOURS = 3;

    private string UserId { get; set; }

    public SCNotifyUserLogsDCache(string userId)
    {
        UserId = userId;
        RedisKey = GetProjectGroupRedisKey("Notifys", UserId);
        Options.SlidingExpiration = TimeSpan.FromHours(EXPIRE_HOURS);
    }

    public static string GetField(string userId, string notifyId) => $"{userId}|{notifyId}";

    protected override async Task<CacheValue<CacheItem<Sc_notify_user_logPO>>> LoadValueWhenRedisNotExistsAsync(string field)
    {
        var ret = new CacheValue<CacheItem<Sc_notify_user_logPO>>
        {
            Value = new CacheItem<Sc_notify_user_logPO>()
        };

        var notifyUserLog = await DbUtil.GetRepository<Sc_notify_user_logPO>().AsQueryable()
            .Where(x => x.UserID == UserId).FirstAsync();

        ret.HasValue = notifyUserLog != null;
        ret.Value = new CacheItem<Sc_notify_user_logPO>(notifyUserLog, TimeSpan.FromDays(EXPIRE_HOURS));

        return ret;
    }

    protected override async Task<CacheValue<Dictionary<string, CacheItem<Sc_notify_user_logPO>>>> LoadAllValuesWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<Dictionary<string, CacheItem<Sc_notify_user_logPO>>>
        {
            Value = new Dictionary<string, CacheItem<Sc_notify_user_logPO>>()
        };

        var notifyUserLogList = await DbUtil.GetRepository<Sc_notify_user_logPO>().AsQueryable()
            .Where(x => x.UserID == UserId).ToListAsync();

        if (notifyUserLogList != null && notifyUserLogList.Any())
        {
            foreach (var item in notifyUserLogList)
            {
                ret.Value.Add($"{item.UserID}|{item.NotifyID}", new CacheItem<Sc_notify_user_logPO>(item, TimeSpan.FromDays(EXPIRE_HOURS)));
            }
        }

        ret.HasValue = ret.Value.Count > 0;

        return ret;
    }

}
