using EasyNetQ;
using Newtonsoft.Json;
using UGame.FuseService.Common.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TinyFx.BIZ.RabbitMQ;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using TinyFx.Text;
using UGame.FuseService.Notify.Caches;
using UGame.FuseService.Notify.Repositories.DAL.ing;
using Xxyy.Common;
using Xxyy.MQ.Email;
using Xxyy.MQ.Lobby.Notify;
using Xxyy.MQ.Xxyy;

namespace UGame.FuseService.Notify.Consumers;

/// <summary>
/// 奖励通知消费端
/// </summary>
public class NotifyRewardMQSub : MQBizSubConsumer<NotifyRewardMsg>
{
    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    public NotifyRewardMQSub()
    {
        AddHandler(Main);
    }

    private async Task Main(NotifyRewardMsg message, CancellationToken cancellationToken)
    {
        if (message == null)
        {
            LogUtil.Info($"Lobby:NotifyRewardMQSub:message 为null");
            return;
        }

        if (message.IsSendNotify)
        {
            await SendNotify(message);
        }

        if (message.IsSendNotifyEmail)
        {
            await SendNotifyEmail(message);
        }
    }

    /// <summary>
    /// 发首页通知
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    private async Task<bool> SendNotify(NotifyRewardMsg request)
    {
        //获取通知模板
        var notifyTmpList = await DbUtil.GetRepository<Sa_notify_templatePO>().AsQueryable()
            .Where(_ => _.OperatorID==request.OperatorId &&_.CurrencyID==request.CurrencyId
            &&_.ActivityType==request.RewardFlagId&&_.NotifyType==(int)NotifyTypeEnum.None)
            .ToListAsync();

        if (notifyTmpList == null || notifyTmpList.Count == 0)
        {
            //LogUtil.Info($"SendNotify.sa_notify_template配置不存在.OperatorId={request.OperatorId}|CurrencyId={request.CurrencyId}|ActivityType={request.RewardFlagId}");
            return false;
        }

        var notifyId = ObjectId.NewId();

        var Notifies = new List<Xxyy.MQ.Lobby.Notify.Notify>
        {
            new()
            {
                NotifyId = notifyId,
                AppId = "lobby",
                OperatorId = request.OperatorId,
                ActionAt = 3, //登录后
                ShowAt = 1, //首页
                UserScope = 1, //指定用户
                Position = 3, //底部
                ShowTimes = 1,
                ShowInterval = 0,
                CloseInterval = 5,
                OrderNum = 0, //排序
                BeginDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(1),
                Status = 1,
                RecDate = DateTime.UtcNow
            }
        };

        var NotifyUsers = new List<NotifyUser>
        {
            new(){ NotifyId = notifyId, UserId = request.UserId }
        };


        var NotifyDetails = new List<NotifyDetail>();
        foreach (var item in notifyTmpList)
        {
            NotifyDetails.Add(new NotifyDetail()
            {
                NotifyId = notifyId,
                LangId = item.LangID,
                Title = string.Format(item.Title, request.RewardAmount.AToM(request.CurrencyId), request.CurrencyId),
                ImageUrl = string.Empty,
                Content = string.Format(item.Content, request.RewardAmount.AToM(request.CurrencyId), request.CurrencyId),
                LinkKind = 2,
                LinkUrl = item.LinkUrl
            });
        }

        var notifyMsg = new NotifyMsg()
        {
            Notifies = Notifies,
            NotifyUsers = NotifyUsers,
            NotifyDetails = NotifyDetails
        };
        return await WriteNotifyForMQ(notifyMsg.Notifies, notifyMsg.NotifyUsers, notifyMsg.NotifyDetails);
    }

    /// <summary>
    /// 发邮件
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    private async Task<bool> SendNotifyEmail(NotifyRewardMsg request)
    {
        string messageId = null;
        string templateKey = $"ActivityRewardNotice{request.RewardFlagId}";

        await MQUtil.PublishAsync(new UserEmailMsg
        {
            DisplayTag = 2,
            UserId = request.UserId,
            //TemplateId = templateId,
            TemplateKey = templateKey,
            SenderId = request.SenderId,
            SourceType = request.RewardFlagId,
            IsBouns = true,
            RewardAmount = request.RewardAmount,
            FlowMultip = (int)request.FlowMultip,
            SourceTable = request.RewardSourceTable,
            SourceId = request.RewardSourceId,
            //变量名要与模板sem_template_lang表中一致
            Content = JsonConvert.SerializeObject(new { rewardAmount = request.RewardAmount.AToM(request.CurrencyId) }),
        });
        return !string.IsNullOrEmpty(messageId);
    }


    /// <summary>
    /// MQ写入通知
    /// </summary>
    /// <param name="notifies"></param>
    /// <param name="notifyUsers"></param>
    /// <param name="notifyDetails"></param>
    /// <returns></returns>
    public static async Task<bool> WriteNotifyForMQ(List<Xxyy.MQ.Lobby.Notify.Notify> notifies, List<NotifyUser> notifyUsers, List<NotifyDetail> notifyDetails)
    {
        DbTransactionManager tm = new();
        tm.Begin();
        try
        {
            // nofity
            List<Sc_notifyPO> insertNotifyEoList = new();            
            if (notifies != null && notifies.Any())
            {
                foreach (var item in notifies)
                {                    
                    insertNotifyEoList.Add(BuildNotifyEo(item));
                }
                await tm.GetRepository<Sc_notifyPO>().InsertRangeAsync(insertNotifyEoList);
            }

            //notify_user
            var notifyUserList = new List<Sc_notify_userPO>();
            if (notifyUsers != null && notifyUsers.Any())
            {
                foreach (var item in notifyUsers)
                {
                    notifyUserList.Add(new Sc_notify_userPO()
                    {
                        NotifyID = item.NotifyId,
                        UserID = item.UserId
                    });
                }
                await tm.GetRepository<Sc_notify_userPO>().InsertRangeAsync(notifyUserList);
            }

            //notify_detail
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
            LogUtil.Info($"SComms_Notify_API_Consumers_WriteNotifyForMQ_catch.error:{ex.Message}.notifies:{JsonConvert.SerializeObject(notifies)}.notifyUsers:{JsonConvert.SerializeObject(notifyUsers)}.notifyDetails:{JsonConvert.SerializeObject(notifyDetails)}");
            return false;
        }
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

    protected override void Configuration(ISubscriptionConfiguration config)
    {        
    }

    protected override Task OnMessage(NotifyRewardMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
