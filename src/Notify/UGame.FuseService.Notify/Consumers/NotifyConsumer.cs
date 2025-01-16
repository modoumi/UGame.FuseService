using EasyNetQ;
using Newtonsoft.Json;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TinyFx.BIZ.RabbitMQ;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using UGame.FuseService.Notify.Caches;
using UGame.FuseService.Notify.Repositories.DAL.ing;
using Xxyy.MQ.Lobby.Notify;

namespace UGame.FuseService.Notify.Consumers;

public class NotifyConsumer : MQBizSubConsumer<NotifyMsg>
{
    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    public NotifyConsumer()
    {
        AddHandler(Handle);
    }

    public async Task<bool> Handle(NotifyMsg message, CancellationToken cancellationToken)
    {
        var notifies = message.Notifies;
        var notifyUsers = message.NotifyUsers;
        var notifyDetails = message.NotifyDetails;

        var insertNotifyEoList = new List<Sc_notifyPO>();
        DbTransactionManager tm = new();
        tm.Begin();
        try
        {
            // sc_notify
            if (notifies != null && notifies.Any())
            {
                foreach (var item in notifies)
                {
                    insertNotifyEoList.Add(BuildNotifyEo(item));
                }
                await tm.GetRepository<Sc_notifyPO>().InsertRangeAsync(insertNotifyEoList);
            }

            // sc_notify_user
            var notify_userList = new List<Sc_notify_userPO>();
            if (notifyUsers != null)
            {
                foreach (var item in notifyUsers)
                {
                    notify_userList.Add(new Sc_notify_userPO()
                    {
                        NotifyID = item.NotifyId,
                        UserID = item.UserId
                    });
                }
                await tm.GetRepository<Sc_notify_userPO>().InsertRangeAsync(notify_userList);
            }

            // sc_notify_detail
            var notifyDetailList = new List<Sc_notify_detailPO>();
            if (notifyDetails != null && notifyDetails.Any())
            {
                foreach (var item in notifyDetails)
                {
                    notifyDetailList.Add(BuildNotifyDetailEo(item));
                }
                await tm.GetRepository<Sc_notify_detailPO>().InsertRangeAsync(notifyDetailList);
            }
            tm.Commit();

            #region 更新缓存new

            foreach (var item in notifyUsers)
            {
                var insertNotifyEo = insertNotifyEoList.Where(d => d.NotifyID.Equals(item.NotifyId)).FirstOrDefault();
                if (insertNotifyEo != null)
                {
                    var notifyUsersDCache = new SCNotifyUsersDCache(item.UserId, insertNotifyEo.AppID, insertNotifyEo.ActionAt, insertNotifyEo.ShowAt, insertNotifyEo.OperatorID);
                    await notifyUsersDCache.ProcessSetAsync(item.NotifyId, insertNotifyEo);
                }
            }

            #endregion

            return true;
        }
        catch (Exception ex)
        {
            tm.Rollback();
            LogUtil.Error($"AddNotify_异常.error:{ex.Message}.notifyEOList:{JsonConvert.SerializeObject(notifies)}.notifyUserEoList:{JsonConvert.SerializeObject(notifyUsers)}.notifyDetailEoList:{JsonConvert.SerializeObject(notifyDetails)}");
            return false;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="notify"></param>
    /// <returns></returns>
    private static Sc_notifyPO BuildNotifyEo(Xxyy.MQ.Lobby.Notify.Notify notify)
    {
        return new Sc_notifyPO()
        {
            NotifyID = notify.NotifyId,
            AppID = notify.AppId,
            OperatorID = notify.OperatorId,
            ActionAt = notify.ActionAt,
            ShowAt = notify.ShowAt,
            UserScope = notify.UserScope,
            Position = notify.Position,
            ShowTimes = notify.ShowTimes,
            ShowInterval = notify.ShowInterval,
            CloseInterval = notify.CloseInterval,
            OrderNum = notify.OrderNum,
            BeginDate = notify.BeginDate,
            EndDate = notify.BeginDate.AddDays(1),
            Status = notify.Status,
            RecDate = notify.RecDate
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="notifyDetail"></param>
    /// <returns></returns>
    private static Sc_notify_detailPO BuildNotifyDetailEo(NotifyDetail notifyDetail)
    {
        return new Sc_notify_detailPO()
        {
            NotifyID = notifyDetail.NotifyId,
            LangID = notifyDetail.LangId,
            Title = notifyDetail.Title,
            ImageUrl = notifyDetail.ImageUrl,
            Content = notifyDetail.Content,
            LinkKind = notifyDetail.LinkKind,
            LinkUrl = notifyDetail.LinkUrl
        };
    }

    protected override void Configuration(ISubscriptionConfiguration config)
    {        
    }

    protected override Task OnMessage(NotifyMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
