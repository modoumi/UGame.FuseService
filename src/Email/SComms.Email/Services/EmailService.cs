using Lobby.DAL.ing;
using Microsoft.Extensions.DependencyInjection;
using SComms.Email.Core;
using SComms.Email.Dtos.Responses;
using SComms.Email.Models;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using TinyFx.Data.SqlSugar;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Extensions.StackExchangeRedis;
using TinyFx.Text;
using Xxyy.Common;
using Xxyy.Common.Services;
using Xxyy.MQ.Activity;
using Xxyy.MQ.Email;
using Xxyy.MQ.Xxyy;

namespace SComms.Email.Services;

public class EmailService
{
    private readonly IServiceProvider serviceProvider;
    private readonly RedisService redisService;
    private readonly TaskRuleEnginer ruleEnginer;

    public EmailService()
    {
        this.serviceProvider = GlobalServiceProvider.ServiceProvider;
        this.redisService = this.serviceProvider.GetService<RedisService>();
        this.ruleEnginer = this.serviceProvider.GetService<TaskRuleEnginer>();
    }

    public async Task<LatestMessageResponse> GetLatestMessage(string userId, string appId, string langId, int type, int pageIndex, int pageSize = 20)
    {
        pageIndex = pageIndex > 0 ? pageIndex - 1 : 0;
        var offset = pageIndex * pageSize;
        var templateLangs = await this.GetSemTemplateLangsAndCache();
        using var sqlSugar = DbUtil.GetDb();
        var maps = await sqlSugar.Queryable<SemUserMessage>()
            .Where(f => f.ReceiverID == userId && (f.AppID == appId || string.IsNullOrEmpty(f.AppID))
                && f.Status == 0 && f.BeginDate <= DateTime.UtcNow && f.EndDate > DateTime.UtcNow)
            .GroupBy(f => f.DisplayTag)
            .Select(f => new ReadingTagMapDto { DisplayTag = f.DisplayTag, Count = SqlFunc.AggregateCount(f.MessageID) })
            .ToListAsync();
        var latestMessages = await sqlSugar.Queryable<SemUserMessage>()
            .Where(f => f.ReceiverID == userId && (f.AppID == appId || string.IsNullOrEmpty(f.AppID))
               && f.Status == 0 && f.BeginDate <= DateTime.UtcNow && f.EndDate > DateTime.UtcNow)
            .Select(f => new LatestMessageDto
            {
                MessageId = f.MessageID,
                Content = f.Content,
                DisplayTag = f.DisplayTag,
                RecDate = f.RecDate.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'"),
                Status = f.Status,
                TemplateID = f.TemplateID,
                Title = f.Title,
                SenderId = f.SenderID
            })
            .ToOffsetPageAsync(pageIndex, pageSize);

        List<RewardInfo> rewardInfos = null;
        if (type == 2 && latestMessages.Count > 0)
        {
            var messageIds = string.Join(',', latestMessages.Select(f => "'" + f.MessageId + "'").ToList());
            //var sql = $"select MessageId,AmountType,RewardAmount,SourceId,Status ReceiveStatus from sem_message_reward where MessageId in ({messageIds})";
            rewardInfos = await sqlSugar.Queryable<SemMessageReward>()
                .Where(f => messageIds.Contains(f.MessageID))
                .Select(f => new RewardInfo
                {
                    MessageId = f.MessageID,
                    RewardAmount = f.RewardAmount,
                    AmountType = f.AmountType,
                    SourceId = f.SourceId,
                    ReceiveStatus = f.Status
                })
                .ToListAsync();
            //await this.database.QueryAsync<RewardInfo>(sql, new { UserId = userId, AppId = appId, DisplayTag = type });
        }

        for (int i = 0; i < 4; i++)
        {
            if (!maps.Exists(f => f.DisplayTag == i))
                maps.Add(new ReadingTagMapDto { DisplayTag = i, Count = 0 });
        }
        maps.Sort((x, y) => x.DisplayTag.CompareTo(y.DisplayTag));
        latestMessages.ForEach(f =>
        {
            if (!string.IsNullOrEmpty(f.TemplateID))
                this.ReplaceMessageText(f, langId, templateLangs);
            if (type == 2)
            {
                var myRewardInfo = rewardInfos.Find(r => f.MessageId == r.MessageId);
                if (myRewardInfo != null)
                {
                    f.SourceId = myRewardInfo.SourceId;
                    f.ReceiveStatus = myRewardInfo.ReceiveStatus;
                    f.AmountType = myRewardInfo.AmountType;
                    f.RewardAmount = myRewardInfo.RewardAmount;
                }
            }
        });
        return new LatestMessageResponse
        {
            Maps = maps,
            Messages = latestMessages
        };
    }
    public async Task<LatestMessageDto> GetMessageDetail(string messageId, string currencyId, string langId)
    {
        var templateLangs = await this.GetSemTemplateLangsAndCache();
        //var sql = "select * from sem_user_message where MessageID=@MessageId;select RewardAmount,SourceId,Status ReceiveStatus from sem_message_reward where MessageID=@MessageId";
        //var reader = await this.database.QueryMultipleAsync(sql, new { MessageID = messageId });
        //var result = await reader.ReadFirstAsync<DetailMessageResponse>();
        //var rewardInfo = await reader.ReadFirstAsync<RewardInfo>();
        using var sqlSugar = DbUtil.GetDb();
        var result = await sqlSugar.Queryable<SemUserMessage>()
            .Where(f => f.MessageID == messageId)
            .Select<LatestMessageDto>()
            .FirstAsync();
        var rewardInfo = await sqlSugar.Queryable<SemMessageReward>()
            .Where(f => f.MessageID == messageId)
            .Select(f => new RewardInfo
            {
                MessageId = f.MessageID,
                ReceiveStatus = f.Status,
                RewardAmount = f.RewardAmount,
                SourceId = f.SourceId,
                AmountType = f.AmountType
            })
            .FirstAsync();

        if (rewardInfo != null)
        {
            result.AmountType = rewardInfo.AmountType;
            result.RewardAmount = rewardInfo.RewardAmount.AToM(currencyId);
            result.SourceId = rewardInfo.SourceId;
            result.ReceiveStatus = rewardInfo.ReceiveStatus;
        }
        if (!string.IsNullOrEmpty(result.TemplateID))
            return this.ReplaceMessageText(result, langId, templateLangs);
        return result;
    }
    public async Task<int> ReadMessages(List<string> messageIds)
    {
        var parameters = messageIds.Select(f => new { Status = 1, UpdateTime = DateTime.UtcNow, MessageId = f }).ToList();
        using var sqlSugar = DbUtil.GetDb();
        return await sqlSugar.Updateable<SemUserMessage>(parameters).ExecuteCommandAsync();
        //return await this.database.UpdateAsync<SemUserMessage>("sem_user_message", parameters, new string[] { "MessageId" });
    }
    public async Task<bool> DeleteMessage(List<string> messageIds)
    {
        var parameters = messageIds.Select(f => new { MessageID = f }).ToArray();
        using var sqlSugar = DbUtil.GetDb();
        var result = await sqlSugar.Deleteable<SemUserMessage>(parameters).ExecuteCommandAsync();
        //var result = await this.database.DeleteAsync<SemUserMessage>("sem_user_message", parameters, new string[] { "MessageID" });
        //result += await this.database.DeleteAsync<SemMessageReward>("sem_message_reward", parameters, new string[] { "MessageID" });
        return result > 0;
    }
    public async Task<string> SendEmailNotice(NoticeEmail noticeEmail)
    {
        (var hasTemplateId, var templateId, var title) = await this.TryGetTemplateId(noticeEmail.ReceiverId, noticeEmail.TemplateId, noticeEmail.TemplateKey);
        if (!hasTemplateId) return null;

        var messageId = ObjectId.NewId();
        using var sqlSugar = DbUtil.GetDb();
        var result = await sqlSugar.Insertable(new SemUserMessage
        {
            MessageID = messageId,
            AppID = noticeEmail.AppId,
            BeginDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddDays(30),
            SenderID = noticeEmail.SenderId,
            ReceiverID = noticeEmail.ReceiverId,
            DisplayTag = noticeEmail.DisplayTag,
            TemplateID = templateId,
            Title = title,
            Content = noticeEmail.Parameters.ToJson(),
            Status = 0,
            RecDate = DateTime.UtcNow,
            UpdateTime = DateTime.UtcNow
        }).ExecuteCommandAsync();
        if (result > 0)
            return messageId;
        return null;
    }
    public async Task<string> SendEmailNotice(RewardNoticeEmail rewardNoticeEmail)
    {
        (var hasTemplateId, var templateId, var title) = await this.TryGetTemplateId(rewardNoticeEmail.ReceiverId, rewardNoticeEmail.TemplateId, rewardNoticeEmail.TemplateKey);
        if (!hasTemplateId) return null;

        var messageId = ObjectId.NewId();
        using var sqlSugar = DbUtil.GetDb();
        var result = await sqlSugar.Insertable(new SemUserMessage
        {
            MessageID = messageId,
            AppID = rewardNoticeEmail.AppId,
            BeginDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddDays(30),
            SenderID = rewardNoticeEmail.SenderId,
            ReceiverID = rewardNoticeEmail.ReceiverId,
            DisplayTag = rewardNoticeEmail.DisplayTag,
            TemplateID = templateId,
            Title = title,
            Content = rewardNoticeEmail.Parameters.ToJson(),
            Status = 0,
            RecDate = DateTime.UtcNow,
            UpdateTime = DateTime.UtcNow
        }).ExecuteCommandAsync();
        //await this.database.CreateAsync<SemMessageReward>("sem_message_reward", new SemMessageReward
        //{
        //    MessageID = messageId,
        //    AmountType = rewardNoticeEmail.AmountType,
        //    ReceiverID = rewardNoticeEmail.ReceiverId,
        //    FlowMultip = rewardNoticeEmail.FlowMultip,
        //    RewardAmount = rewardNoticeEmail.RewardAmount,
        //    SourceType = rewardNoticeEmail.SourceType,
        //    SourceTable = rewardNoticeEmail.SourceTable,
        //    SourceId = rewardNoticeEmail.SourceId,
        //    Status = 0,
        //    RecDate = DateTime.UtcNow,
        //    UpdateTime = DateTime.UtcNow
        //});
        if (result > 0)
            return messageId;
        return null;
    }
    public async Task<bool> TakeReward(string userId, string messageId, string operatorId, string countryId, string currencyId, string appId)
    {
        //var sql = "select * from sem_message_reward where MessageID=@MessageId";
        using var sqlSugar = DbUtil.GetDb();
        var message = await sqlSugar.Queryable<SemUserMessage>()
           .Where(f => f.MessageID == messageId)
           .FirstAsync();
        var messageReward = await sqlSugar.Queryable<SemMessageReward>()
            .Where(f => f.MessageID == messageId)
            .FirstAsync();
        //var messageReward = await this.database.QueryFirstAsync<SemMessageReward>(sql, new { MessageID = messageId });
        if (messageReward == null)
            throw new CustomException($"奖励MessageId:{messageId}不存在");

        //活动奖励，发送消息到消息队列，Lobby去订阅并消费
        if (messageReward.SourceType > 0)
        {
            await MQUtil.PublishAsync(new EmailActivityRewardMsg
            {
                ActivityId = messageReward.SourceType,
                RewardAmount = messageReward.RewardAmount,
                AppId = appId,
                CountryId = countryId,
                CurrencyId = currencyId,
                FlowMultip = messageReward.FlowMultip,
                IsBouns = messageReward.AmountType == 1,
                OperatorId = operatorId,
                SourceId = messageReward.SourceId,
                SourceTable = messageReward.SourceTable,
                SourceType = messageReward.SourceType,
                UserId = userId
            });
            return true;
        }
        bool isSuccess = false;
        CurrencyChangeMsg changedMessage = null;
        var tm = new TransactionManager();
        try
        {
            var currencyChangeReq = new CurrencyChangeReq()
            {
                UserId = userId,
                Amount = messageReward.RewardAmount,
                AppId = appId,
                ChangeTime = DateTime.UtcNow,
                CurrencyId = currencyId,
                OperatorId = operatorId,
                ChangeBalance = messageReward.AmountType == 1 ? CurrencyChangeBalance.Bonus : CurrencyChangeBalance.Cash,
                FlowMultip = messageReward.FlowMultip,
                TM = tm,
                Reason = "邮件中心bouns补偿",
                SourceType = messageReward.SourceType,
                SourceTable = "sem_message_reward",
                SourceId = messageReward.MessageID
            };
            var currencyChangeService = new CurrencyChangeService(userId);
            changedMessage = await currencyChangeService.Add(currencyChangeReq);
            if (changedMessage != null)
                isSuccess = true;
            //throw new CustomException("写入s_currency_change失败");

            var endTime = message.EndDate;
            if (message.EndDate > DateTime.UtcNow.AddDays(7))
                endTime = DateTime.UtcNow.AddDays(7);

            var userMessageMo = new Sem_user_messageMO();
            var setSql1 = $"Status=1,EndDate='{endTime:yyyy-MM-dd HH:mm:ss}',UpdateTime=UTC_TIMESTAMP()";
            await userMessageMo.PutAsync(setSql1, $"MessageId='{messageId}'", tm);

            var setSql2 = $"Status=1,UpdateTime=UTC_TIMESTAMP()";
            await userMessageMo.PutAsync(setSql2, $"MessageId='{messageId}'", tm);
            tm.Commit();
            //sql = "UPDATE sem_user_message SET Status=1,EndDate=@EndDate,UpdateTime=UTC_TIMESTAMP() WHERE MessageID=@MessageId;UPDATE sem_message_reward SET Status=@Status,UpdateTime=UTC_TIMESTAMP() WHERE MessageID=@MessageId";
            //await this.database.ExecuteAsync(sql, new { MessageId = messageId, Status = status, EndDate = DateTime.UtcNow.AddDays(7) }, tm);
        }
        catch (Exception ex)
        {
            tm.Rollback();
            throw new CustomException(ex.Message);
        }

        if (changedMessage != null)
            await MQUtil.PublishAsync(changedMessage);
        await MQUtil.PublishAsync(new UserActivityMsg()
        {
            UserId = userId,
            ActivityType = messageReward.SourceType
        });
        return isSuccess;
    }
    public async Task<int> GetLatestMessageCount(string userId, string appId)
    {
        //var sql = "select count(1) from sem_user_message WHERE ReceiverID=@UserId and Status=0";
        //return await this.database.QueryFirstAsync<int>(sql, new { UserId = userId });
        using var sqlSugar = DbUtil.GetDb();
        return await sqlSugar.Queryable<SemUserMessage>()
         .Where(f => f.ReceiverID == userId && (f.AppID == appId || string.IsNullOrEmpty(f.AppID))
             && f.Status == 0 && f.BeginDate <= DateTime.UtcNow && f.EndDate > DateTime.UtcNow)
          .Select(f => SqlFunc.AggregateCount(f.MessageID))
         .FirstAsync();
    }
    private async Task<List<SemTemplateLang>> GetSemTemplateLangsAndCache(bool isForceRefresh = false)
    {
        var cacheKey = RedisUtil.GetProjectGroupRedisKey("SemTemplateLang", typeof(SemTemplateLang), "all");
        (var hasCache, var cacheValues) = await this.redisService.GetAsync<List<SemTemplateLang>>(cacheKey);
        if (!hasCache || cacheValues == null || cacheValues.Count == 0 || isForceRefresh)
        {
            using var sqlSugar = DbUtil.GetDb();
            cacheValues = await sqlSugar.Queryable<SemTemplateLang>().ToListAsync();
            //var sql = "SELECT * FROM sem_template_lang";
            //cacheValues = await this.database.QueryAsync<SemTemplateLang>(sql);
            await this.redisService.SetAsync(cacheKey, cacheValues);
        }
        return cacheValues;
    }
    private async Task<(bool, string, string)> TryGetTemplateId(string userId, string templateId, string templateKey)
    {
        var templateCaches = await this.GetSemTemplatesAndCache();
        var engineParameter = new RuleEngineParameter
        {
            RequestParameters = new Dictionary<string, object> { { "userId", userId } }
        };
        if (string.IsNullOrEmpty(templateId) && string.IsNullOrEmpty(templateKey))
            return (false, null, null);
        string title = null;
        if (string.IsNullOrEmpty(templateId) && !string.IsNullOrEmpty(templateKey))
        {
            var myTemplates = templateCaches.FindAll(f => f.TemplateKey == templateKey);
            foreach (var myTemplate in myTemplates)
            {
                var hashKey = HashCode.Combine(myTemplate.TemplateId);
                var isSatisfied = await this.ruleEnginer.Execute(hashKey, myTemplate.ConditionExpr, engineParameter);
                if (isSatisfied)
                {
                    templateId = myTemplate.TemplateId;
                    title = myTemplate.Title;
                    break;
                }
            }
        }
        //如果没有一个模板符合，则不发邮件
        if (string.IsNullOrEmpty(templateId))
            return (false, null, null);
        return (true, templateId, title);
    }
    private async Task<List<TemplateCache>> GetSemTemplatesAndCache(bool isForceRefresh = false)
    {
        var cacheKey = RedisUtil.GetProjectGroupRedisKey("SemTemplate", typeof(SemTemplate), "all");
        (var hasCache, var cacheValues) = await this.redisService.GetAsync<List<TemplateCache>>(cacheKey);
        if (!hasCache || cacheValues == null || cacheValues.Count == 0 || isForceRefresh)
        {
            //var sql = "SELECT TemplateId,TemplateKey,ConditionExpr,DisplayTag,ContentType FROM sem_template WHERE Status=1";
            //cacheValues = await this.database.QueryAsync<TemplateCache>(sql);
            using var sqlSugar = DbUtil.GetDb();
            cacheValues = await sqlSugar.Queryable<SemTemplate>()
                .Select(f => new TemplateCache
                {
                    TemplateId = f.TemplateID,
                    ConditionExpr = f.ConditionExpr,
                    ContentType = f.ContentType,
                    DisplayTag = f.DisplayTag,
                    TemplateKey = f.TemplateKey,
                    Title = f.Title
                }).ToListAsync();
            cacheValues.Sort((x, y) => x.TemplateId.CompareTo(y.TemplateId));
            await this.redisService.SetAsync(cacheKey, cacheValues);
        }
        return cacheValues;
    }
    private LatestMessageDto ReplaceMessageText(LatestMessageDto message, string langId, List<SemTemplateLang> templateLangs)
    {
        var contentJson = message.Content.JsonTo<MessageContentJson>();
        if (!string.IsNullOrEmpty(message.TemplateID))
        {
            var parameters = message.Content.JsonTo<Dictionary<string, object>>();
            var templateLang = templateLangs.Find(t => t.LangID == langId && t.TemplateID == message.TemplateID);
            message.Title = templateLang.Title;
            message.Content = templateLang.Content;
            var pattern = @"(\{\{(\w+)\}\})";
            message.Title = Regex.Replace(message.Title, pattern, match =>
            {
                var variableName = match.Groups[2].Value;
                var tempVariable = $"{{{variableName}}}";
                return parameters[variableName].ToString();
            });
            message.Content = Regex.Replace(message.Content, pattern, match =>
            {
                var variableName = match.Groups[2].Value;
                var tempVariable = $"{{{variableName}}}";
                return parameters[variableName].ToString();
            });
        }
        else
        {
            message.Title = contentJson.Title;
            message.Content = contentJson.Content;
        }
        return message;
    }
    class MessageContentJson
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
    class RewardInfo
    {
        public string MessageId { get; set; }
        public int AmountType { get; set; }
        public long RewardAmount { get; set; }
        public string SourceId { get; set; }
        public int ReceiveStatus { get; set; }
    }
    class TemplateCache
    {
        public string TemplateId { get; set; }
        public string TemplateKey { get; set; }
        public string Title { get; set; }
        public string ConditionExpr { get; set; }
        public int DisplayTag { get; set; }
        public int ContentType { get; set; }
    }
}
public class NoticeEmail
{
    public string AppId { get; set; }
    public string SenderId { get; set; }
    public string ReceiverId { get; set; }
    public string TemplateId { get; set; }
    public string TemplateKey { get; set; }
    public int DisplayTag { get; set; }
    public object Parameters { get; set; }
}
public class RewardNoticeEmail
{
    public string AppId { get; set; }
    public string SenderId { get; set; }
    public string ReceiverId { get; set; }
    public string TemplateId { get; set; }
    public string TemplateKey { get; set; }
    public int DisplayTag { get; set; }
    /// <summary>
    /// 金额类型 1-真金 2-Bonus
    /// </summary>
    public int AmountType { get; set; }
    /// <summary>
    /// 奖励金额
    /// </summary>
    public long RewardAmount { get; set; }
    /// <summary>
    /// 赠金提现所需要的流水倍数
    /// </summary>
    public int FlowMultip { get; set; }
    /// <summary>
    /// 数据来源类型,1：后台奖励 其他的情况都是各种活动ID
    /// </summary>
    public int SourceType { get; set; }
    /// <summary>
    /// 数据来源表名
    /// </summary>
    public string SourceTable { get; set; }
    /// <summary>
    /// 数据ID
    /// </summary>
    public string SourceId { get; set; }
    /// <summary>
    /// 模板数据参数
    /// </summary>
    public object Parameters { get; set; }
}
