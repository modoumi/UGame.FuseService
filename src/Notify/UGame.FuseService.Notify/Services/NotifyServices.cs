using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.StackExchangeRedis;
using TinyFx.Logging;
using UGame.FuseService.Notify.Caches;
using UGame.FuseService.Notify.Dtos;
using UGame.FuseService.Notify.Repositories.DAL.ing;
using Xxyy.Common;

namespace UGame.FuseService.Notify.Services;

public class NotifyServices
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<SCNotifyDto>> LoadNotify(SCNotifyIpo ipo)
    {
        using var lockObj = await RedisUtil.LockAsync($"Notify.{ipo.UserId}", 30);
        if (!lockObj.IsLocked)
        {
            lockObj.Release();
            throw new CustomException(CommonCodes.UserConcurrent, $"Scommon:Notify:Request for lock failed.Key:Notify.{ipo.UserId}");
        }

        var ret = new List<SCNotifyDto>();

        //获取当前用户需要收到的通知
        var notifyUsersDCache = new SCNotifyUsersDCache(ipo.UserId, ipo.AppId, ipo.ActionAt, ipo.ShowAt, ipo.OperatorId);
        var notifyUsersDCacheData = await notifyUsersDCache.GetAllOrLoadAsync();
        var deleteFieldList = new List<string>();

        if (!notifyUsersDCacheData.HasValue) return ret;

        notifyUsersDCacheData.Value = notifyUsersDCacheData.Value.OrderByDescending(d => d.Key).ToDictionary(d => d.Key, d => d.Value);

        //当前用户已经收到的通知记录
        var notifyUserLogsDCache = new SCNotifyUserLogsDCache(ipo.UserId);
        var notifyUserLogsDCacheData = await notifyUserLogsDCache.GetAllOrLoadAsync();

        if (!notifyUserLogsDCacheData.HasValue)
            notifyUserLogsDCacheData.Value = new Dictionary<string, Sc_notify_user_logPO>();

        var utcTime = DateTime.UtcNow;

        var insertNotifyUserLogEoList = new List<Sc_notify_user_logPO>();

        //需要返回给前端的通知
        var retEntity = new List<Sc_notifyPO>();

        try
        {
            foreach (var item in notifyUsersDCacheData.Value)
            {
                if (notifyUserLogsDCacheData.Value.TryGetValue($"{ipo.UserId}|{item.Key}", out var result)) continue;

                if (!insertNotifyUserLogEoList.Any(_ => _.NotifyID == item.Key && _.UserID == ipo.UserId))
                {
                    insertNotifyUserLogEoList.Add(new Sc_notify_user_logPO
                    {
                        NotifyID = item.Key,
                        UserID = ipo.UserId,
                        ShowCount = 1,
                        LastShowDate = utcTime
                    });
                }

                if (item.Value.NotifyUsersCount <= 1)
                {
                    await DbUtil.GetRepository<Sc_notifyPO>().AsUpdateable()
                        .SetColumns(_ => _.NotifyedUsersCount, item.Value.NotifyUsersCount)
                        .Where(_ => _.OperatorID == ipo.OperatorId && _.NotifyID == item.Key)
                        .ExecuteCommandAsync();

                    await DbUtil.GetRepository<Sc_notifyPO>().AsUpdateable()
                       .SetColumns(_ => _.NotifyedUsersCount, item.Value.NotifyUsersCount)
                       .Where(_ => _.OperatorID == ipo.OperatorId && _.NotifyID == item.Key && _.UserScope == 1 && _.NotifyUsersCount <= _.NotifyedUsersCount)
                       .ExecuteCommandAsync();

                    deleteFieldList.Add(item.Key);
                }

                retEntity.Add(item.Value);

                if (retEntity.Count >= 5) break;
            }

            if (insertNotifyUserLogEoList.Any())
                await DbUtil.GetRepository<Sc_notify_user_logPO>().InsertRangeAsync(insertNotifyUserLogEoList);

            //更新NotifyUserLogsDCache
            foreach (var item in insertNotifyUserLogEoList)
                await notifyUserLogsDCache.SetAsync($"{item.UserID}|{item.NotifyID}", item);

            //更新SCNotifyUsersDCache
            foreach (var item in deleteFieldList)
                await notifyUsersDCache.DeleteAsync(item);

            if (retEntity.Any())
                ret = await BuildNotifyDto(retEntity, ipo.LangId);
        }
        catch (Exception ex)
        {
            if (ex is not CustomException)
                LogUtil.GetContextLogger().AddException(ex).AddMessage(ex.Message);
            return ret;
        }

        return ret;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="list"></param>
    /// <param name="langId"></param>
    /// <returns></returns>
    private async Task<List<SCNotifyDto>> BuildNotifyDto(List<Sc_notifyPO> list, string langId)
    {
        var ret = new List<SCNotifyDto>();
        foreach (var item in list)
        {

            var notifyDetailList = await DbUtil.GetRepository<Sc_notify_detailPO>().AsQueryable()
            .Where(_ => _.LangID == langId && _.NotifyID == item.NotifyID)
            .Select(_ => new Sc_notify_detailPO
            {
                NotifyID = _.NotifyID,
                LinkKind = _.LinkKind,
                LinkUrl = _.LinkUrl,
                Title = _.Title,
                Content = _.Content,
                ImageUrl = _.ImageUrl,
            }).ToListAsync();

            var notifyDetail = notifyDetailList.Where(d => d.NotifyID.Equals(item.NotifyID)).FirstOrDefault();
            if (notifyDetail != null)
            {
                ret.Add(new SCNotifyDto()
                {
                    NotifyId = item.NotifyID,
                    Position = item.Position,
                    CloseInterval = item.CloseInterval,
                    LinkKind = notifyDetail.LinkKind,
                    LinkUrl = notifyDetail.LinkUrl,
                    Title = notifyDetail.Title,
                    Content = notifyDetail.Content,
                    ImageUrl = notifyDetail.ImageUrl
                });
            }
        }
        return ret;
    }
}


