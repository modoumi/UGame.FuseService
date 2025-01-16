using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyFx.Caching;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.StackExchangeRedis;
using UGame.FuseService.Notify.Repositories.DAL.ing;

namespace UGame.FuseService.Notify.Caches;

public class SCNotifyUsersDCache : RedisHashExpireClient<Sc_notifyPO>
{
    private const int EXPIRE_HOURS = 3;

    private string UserId { get; set; }

    public string AppId { get; set; }

    public int ActionAt { get; set; }

    public int ShowAt { get; set; }

    public string OperatorId { get; set; }

    public SCNotifyUsersDCache(string userId, string appId, int actionAt, int showAt, string operatorId)
    {
        UserId = userId;
        AppId = appId;
        ActionAt = actionAt;
        ShowAt = showAt;
        OperatorId = operatorId;
        RedisKey = GetProjectGroupRedisKey("Notifys", $"{userId}:{AppId}|{ActionAt}|{ShowAt}|{OperatorId}");
        Options.SlidingExpiration = TimeSpan.FromHours(EXPIRE_HOURS);
    }

    protected override async Task<CacheValue<CacheItem<Sc_notifyPO>>> LoadValueWhenRedisNotExistsAsync(string field)
    {
        var ret = new CacheValue<CacheItem<Sc_notifyPO>>
        {
            Value = new CacheItem<Sc_notifyPO>()
        };
        var notifyList = await GetSsc_notify(AppId, ActionAt, ShowAt, UserId, field, false);
        var notifyEo = notifyList.FirstOrDefault();
        ret.HasValue = notifyEo != null;
        ret.Value = new CacheItem<Sc_notifyPO>(notifyEo, TimeSpan.FromHours(EXPIRE_HOURS));
        return ret;
    }

    protected override async Task<CacheValue<Dictionary<string, CacheItem<Sc_notifyPO>>>> LoadAllValuesWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<Dictionary<string, CacheItem<Sc_notifyPO>>>
        {
            Value = new Dictionary<string, CacheItem<Sc_notifyPO>>()
        };

        var notifyUsersList = await GetSsc_notify(AppId, ActionAt, ShowAt, UserId, null, true);
        if (notifyUsersList != null && notifyUsersList.Any())
        {
            ret.Value = notifyUsersList.GroupBy(d => d.NotifyID).ToDictionary(d => d.Key, d =>
            new CacheItem<Sc_notifyPO>(d.FirstOrDefault(), TimeSpan.FromHours(EXPIRE_HOURS)));
        }
        ret.HasValue = ret.Value.Count > 0;
        return ret;
    }

    public async Task<bool> ProcessSetAsync(string field, Sc_notifyPO notifyEO)
    {
        return await SetAsync(field, notifyEO, TimeSpan.FromHours(EXPIRE_HOURS), false);
    }

    /// <summary>
    /// 获取用户消息列表
    /// </summary>
    /// <param name="appId"></param>
    /// <param name="actionAt"></param>
    /// <param name="showAt"></param>
    /// <param name="userId"></param>
    /// <param name="notifyID"></param>
    /// <param name="isAll"></param>
    /// <returns></returns>
    private async Task<List<Sc_notifyPO>> GetSsc_notify(string appId, int actionAt, int showAt, string userId, string notifyID = default, bool isAll = true)
    {
        var notifyList = await DbUtil.GetRepository<Sc_notify_userPO>().AsQueryable()
           .LeftJoin<Sc_notifyPO>((notifyUser, notify) => notify.NotifyID==notifyUser.NotifyID)
           .WhereIF(isAll==false, (notifyUser, notify) => notify.NotifyID==notifyID)
           .Where((notifyUser, notify) => notify.Status==1 && DateTime.UtcNow>=notify.BeginDate && DateTime.UtcNow<=notify.EndDate
               && notify.AppID==appId  && notify.ActionAt==actionAt && notify.ShowAt==showAt && notifyUser.UserID==userId)
           .Select((notifyUser, notify) => new Sc_notifyPO { }, true)
           .ToListAsync();
        return notifyList.OrderBy(_ => _.RecDate).ToList();
    }
}
