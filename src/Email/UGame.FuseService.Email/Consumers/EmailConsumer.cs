using EasyNetQ;
using System;
using System.Threading;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.BIZ.RabbitMQ;
using TinyFx.Extensions.RabbitMQ;
using UGame.FuseService.Email.Services;
using Xxyy.MQ.Email;

namespace UGame.FuseService.Email.Consumers;

/// <summary>
/// 
/// </summary>
public class EmailConsumer : MQBizSubConsumer<UserEmailMsg>
{
    /// <summary>
    /// 
    /// </summary>
    public EmailConsumer()
    {
        AddHandler(Handle);
    }

    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    public async Task Handle(UserEmailMsg message, CancellationToken cancellationToken)
    {
        if (message == null)
            return;

        var emailService = DIUtil.GetService<EmailService>();
        if (message.DisplayTag == 2)
        {
            await emailService.SendEmailNotice(new RewardNoticeEmail
            {
                AppId = message.AppId,
                DisplayTag = message.DisplayTag,
                FlowMultip = (int)message.FlowMultip,
                ReceiverId = message.UserId,
                TemplateId = message.TemplateId,
                TemplateKey = message.TemplateKey,
                SenderId = message.SenderId,
                SourceType = message.SourceType,
                AmountType = message.IsBouns ? 1 : 2,
                RewardAmount = message.RewardAmount,
                SourceTable = message.SourceTable,
                SourceId = message.SourceId,
                BeginDateUtc = message.BeginDateUtc ?? DateTime.UtcNow,
                EndDateUtc = message.EndDateUtc ?? DateTime.UtcNow.AddDays(30),
                Title = message.Title,
                Content = message.Content
            });
        }
        else
        {
            await emailService.SendEmailNotice(new NoticeEmail
            {
                AppId = message.AppId,
                DisplayTag = message.DisplayTag,
                ReceiverId = message.UserId,
                TemplateId = message.TemplateId,
                TemplateKey = message.TemplateKey,
                SenderId = message.SenderId,
                BeginDateUtc = message.BeginDateUtc ?? DateTime.UtcNow,
                EndDateUtc = message.EndDateUtc ?? DateTime.UtcNow.AddDays(30),
                Title = message.Title,
                Content = message.Content
            });
        }
    }

    protected override void Configuration(ISubscriptionConfiguration config)
    {        
    }

    protected override Task OnMessage(UserEmailMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
