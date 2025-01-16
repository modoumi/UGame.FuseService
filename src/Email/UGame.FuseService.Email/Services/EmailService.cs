using Newtonsoft.Json;
using UGame.FuseService.Common.Core;
using SComms.Notify.DAL.ing;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Collections;
using TinyFx.Data;
using TinyFx.Data.MySql;
using TinyFx.Data.SqlSugar;
using TinyFx.DbCaching;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Extensions.StackExchangeRedis;
using TinyFx.Text;
using UGame.FuseService.Email.Dtos.Requests;
using UGame.FuseService.Email.Dtos.Responses;
using UGame.FuseService.Email.Models;
using UGame.FuseService.Email.Repositories;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.Common.Services;
using Xxyy.MQ.Lobby.Activity;
using Xxyy.MQ.Lobby.Notify;
using Xxyy.MQ.Xxyy;

namespace UGame.FuseService.Email.Services;

/// <summary>
/// 邮件消息服务
/// </summary>
public class EmailService
{
    private readonly RedisService redisService;
    private readonly TaskRuleEnginer ruleEnginer;
    private readonly MySqlDatabase database = new();


    /// <summary>
    /// 邮件消息服务
    /// </summary>
    /// <param name="redisService"></param>
    /// <param name="ruleEnginer"></param>
    public EmailService(RedisService redisService, TaskRuleEnginer ruleEnginer)
    {
        this.redisService = redisService;
        this.ruleEnginer = ruleEnginer;
    }

    /// <summary>
    /// 获取最新的消息列表
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<LatestMessageResponse> GetLatestMessage(LatestMessageRequest ipo)
    {
        ipo.PageIndex = ipo.PageIndex > 0 ? ipo.PageIndex - 1 : 0;

        var templateLangs = await this.GetSemTemplateLangsAndCache();
        templateLangs = templateLangs.FindAll(f => f.OperatorID == ipo.OperatorId);

        var maps = await DbUtil.GetRepository<SemUserMessage>().AsQueryable()
            .Where(f => f.ReceiverID == ipo.UserId && f.Status == 0 && f.BeginDate <= DateTime.UtcNow && f.EndDate > DateTime.UtcNow)
            .GroupBy(f => f.DisplayTag)
            .Select(f => new ReadingTagMapDto { DisplayTag = f.DisplayTag, Count = SqlFunc.AggregateCount(f.MessageID) })
            .ToListAsync();

        var latestMessages = await DbUtil.GetRepository<SemUserMessage>().AsQueryable()
            .WhereIF(ipo.Type != null, f => f.ReceiverID == ipo.UserId && f.DisplayTag == ipo.Type && f.BeginDate <= DateTime.UtcNow && f.EndDate > DateTime.UtcNow)
            .WhereIF(ipo.Type == null, f => f.ReceiverID == ipo.UserId && f.BeginDate <= DateTime.UtcNow && f.EndDate > DateTime.UtcNow)
            .OrderByDescending(f => f.RecDate)
            .Select(f => new LatestMessageDto
            {
                MessageId = f.MessageID,
                Content = f.Content,
                DisplayTag = f.DisplayTag,
                RecDate = f.RecDate.ToString("yyyy-MM-dd HH:mm:ss"),
                Status = f.Status,
                TemplateID = f.TemplateID,
                Title = f.Title,
                SenderId = f.SenderID,
                ReceiverId = f.ReceiverID,
            }).ToOffsetPageAsync(ipo.PageIndex, ipo.PageSize);

        latestMessages.ForEach(f => f.RecDate = DateTime.Parse(f.RecDate).ToString("yyyy-MM-dd'T'HH:mm:ss'Z'"));

        List<RewardInfo> rewardInfos = null;
        if (latestMessages.Any(_ => _.DisplayTag == 2))
        {
            var messageIds = string.Join(',', latestMessages.Where(_ => _.DisplayTag == 2)
                .Select(f => "'" + f.MessageId + "'").ToList());

            rewardInfos = await DbUtil.GetRepository<SemMessageReward>().AsQueryable()
               .Where(f => messageIds.Contains(f.MessageID))
               .Select(f => new RewardInfo
               {
                   MessageId = f.MessageID,
                   RewardAmount = f.RewardAmount,
                   AmountType = f.AmountType,
                   SourceId = f.SourceId,
                   ReceiveStatus = f.Status
               }).ToListAsync();
        }

        for (int i = 0; i < 4; i++)
        {
            if (!maps.Exists(f => f.DisplayTag == i))
                maps.Add(new ReadingTagMapDto { DisplayTag = i, Count = 0 });
        }
        maps.Sort((x, y) => x.DisplayTag.CompareTo(y.DisplayTag));

        latestMessages.ForEach(async f =>
        {
            if (!string.IsNullOrEmpty(f.TemplateID))
                await this.ReplaceMessageText(f, ipo.UserId, ipo.LangId, templateLangs);

            if (latestMessages.Any(_ => _.DisplayTag == 2))
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

    /// <summary>
    /// 获取消息详情
    /// </summary>
    /// <param name="messageId"></param>
    /// <param name="operatorId"></param>
    /// <param name="currencyId"></param>
    /// <param name="langId"></param>
    /// <returns></returns>
    public async Task<LatestMessageDto> GetMessageDetail(string messageId, string operatorId, string currencyId, string langId)
    {
        var templateLangs = await this.GetSemTemplateLangsAndCache();
        templateLangs = templateLangs.FindAll(f => f.OperatorID == operatorId);

        var result = await DbUtil.GetRepository<SemUserMessage>().AsQueryable()
            .Where(f => f.MessageID == messageId)
            .Select<LatestMessageDto>()
            .FirstAsync();

        if (result == null) return null;

        var rewardInfo = await DbUtil.GetRepository<SemMessageReward>().AsQueryable()
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
            return await this.ReplaceMessageText(result, result.ReceiverId, langId, templateLangs);

        return result;
    }

    /// <summary>
    /// 读取消息
    /// </summary>
    /// <param name="messageIds"></param>
    /// <returns></returns>
    public async Task<int> ReadMessages(List<string> messageIds)
    {
        var parameters = messageIds.Select(f => new { Status = 1, UpdateTime = DateTime.UtcNow, MessageID = f }).ToList();

        return await DbUtil.GetRepository<SemUserMessage>().AsUpdateable()
            .SetColumns(f => f.Status, 1)
            .SetColumns(f => f.UpdateTime, DateTime.UtcNow)
            .Where(f => messageIds.Contains(f.MessageID))
            .ExecuteCommandAsync();
    }

    /// <summary>
    /// 删除消息
    /// </summary>
    /// <param name="messageIds"></param>
    /// <returns></returns>
    public async Task<bool> DeleteMessage(List<string> messageIds)
    {
        var parameters = messageIds.Select(f => new { MessageID = f }).ToArray();
        var result = await this.database.DeleteAsync<SemUserMessage>("sem_user_message", parameters, new string[] { "MessageID" });
        result += await this.database.DeleteAsync<SemMessageReward>("sem_message_reward", parameters, new string[] { "MessageID" });
        return result > 0;
    }

    /// <summary>
    /// 发送邮件提醒
    /// </summary>
    /// <param name="noticeEmail"></param>
    /// <returns></returns>
    public async Task<string> SendEmailNotice(NoticeEmail noticeEmail)
    {
        (var hasTemplateId, var templateId, var title) = await this.TryGetTemplateId(noticeEmail.ReceiverId, noticeEmail.TemplateId, noticeEmail.TemplateKey);
        if (!hasTemplateId) return null;

        var messageId = ObjectId.NewId();

        var result = await DbUtil.GetRepository<SemUserMessage>().AsInsertable(new SemUserMessage
        {
            MessageID = messageId,
            AppID = noticeEmail.AppId,
            BeginDate = noticeEmail.BeginDateUtc,
            EndDate = noticeEmail.EndDateUtc,
            SenderID = noticeEmail.SenderId,
            ReceiverID = noticeEmail.ReceiverId,
            DisplayTag = noticeEmail.DisplayTag,
            TemplateID = templateId,
            Title = noticeEmail.Title ?? title,
            Content = noticeEmail.Content,
            Status = 0,
            RecDate = DateTime.UtcNow,
            UpdateTime = DateTime.UtcNow
        }).ExecuteCommandAsync();

        if (result > 0) return messageId;

        return null;
    }

    /// <summary>
    /// 发送奖励邮件提醒
    /// </summary>
    /// <param name="rewardNoticeEmail"></param>
    /// <returns></returns>
    public async Task<string> SendEmailNotice(RewardNoticeEmail rewardNoticeEmail)
    {
        (var hasTemplateId, var templateId, var title) = await this.TryGetTemplateId(rewardNoticeEmail.ReceiverId, rewardNoticeEmail.TemplateId, rewardNoticeEmail.TemplateKey);
        if (!hasTemplateId) return null;

        var messageId = ObjectId.NewId();
        var result = await DbUtil.GetRepository<SemUserMessage>().AsInsertable(new SemUserMessage
        {
            MessageID = messageId,
            AppID = rewardNoticeEmail.AppId,
            BeginDate = DateTime.UtcNow,
            EndDate = DateTime.UtcNow.AddDays(30),
            SenderID = rewardNoticeEmail.SenderId,
            ReceiverID = rewardNoticeEmail.ReceiverId,
            DisplayTag = rewardNoticeEmail.DisplayTag,
            TemplateID = templateId,
            Title = rewardNoticeEmail.Title ?? title,
            Content = rewardNoticeEmail.Content,
            Status = 0,
            RecDate = DateTime.UtcNow,
            UpdateTime = DateTime.UtcNow
        }).ExecuteCommandAsync();

        result += await DbUtil.GetRepository<SemMessageReward>().AsInsertable(new SemMessageReward
        {
            MessageID = messageId,
            AmountType = rewardNoticeEmail.AmountType,
            ReceiverID = rewardNoticeEmail.ReceiverId,
            FlowMultip = rewardNoticeEmail.FlowMultip,
            RewardAmount = rewardNoticeEmail.RewardAmount,
            SourceType = rewardNoticeEmail.SourceType,
            SourceTable = rewardNoticeEmail.SourceTable,
            SourceId = rewardNoticeEmail.SourceId,
            Status = 0,
            RecDate = DateTime.UtcNow,
            UpdateTime = DateTime.UtcNow
        }).ExecuteCommandAsync();

        if (result > 0) return messageId;

        return null;
    }

    /// <summary>
    /// 领取奖励
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="messageId"></param>
    /// <param name="operatorId"></param>
    /// <param name="countryId"></param>
    /// <param name="currencyId"></param>
    /// <param name="appId"></param>
    /// <returns></returns>
    /// <exception cref="CustomException"></exception>
    public async Task<bool> TakeReward(string userId, string messageId, string operatorId, string countryId, string currencyId, string appId)
    {
        var message = await DbUtil.GetRepository<SemUserMessage>().AsQueryable()
           .Where(f => f.MessageID == messageId)
           .FirstAsync();

        var messageReward = await DbUtil.GetRepository<SemMessageReward>().AsQueryable()
            .Where(f => f.MessageID == messageId)
            .FirstAsync();

        if (messageReward == null) throw new CustomException($"奖励MessageId:{messageId}不存在");

        //活动奖励，发送通知消息到消息队列，Lobby去订阅并消费，消费时，要判断是否发送通知
        if (messageReward.SourceType > 0)
        {
            //发送给lobby消息，处理领奖
            await MQUtil.PublishAsync(new EmailActivityNotifyMsg
            {
                ActivityId = messageReward.SourceType,
                Amount = messageReward.RewardAmount,
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
            var sql = "UPDATE sem_user_message SET Status=1,EndDate=@EndDate,UpdateTime=UTC_TIMESTAMP() WHERE MessageID=@MessageId;UPDATE sem_message_reward SET Status=1,UpdateTime=UTC_TIMESTAMP() WHERE MessageID=@MessageId";
            await this.database.ExecuteAsync(sql, new { MessageId = messageId, EndDate = DateTime.UtcNow.AddDays(7) });
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

            var endTime = message.EndDate;
            if (message.EndDate > DateTime.UtcNow.AddDays(7))
                endTime = DateTime.UtcNow.AddDays(7);

            var userMessageMo = new Sem_user_messageMO();
            var setSql1 = $"Status=1,EndDate='{endTime:yyyy-MM-dd HH:mm:ss}',UpdateTime=UTC_TIMESTAMP()";
            await userMessageMo.PutAsync(setSql1, $"MessageId='{messageId}'", tm);

            var setSql2 = $"Status=1,UpdateTime=UTC_TIMESTAMP()";
            await userMessageMo.PutAsync(setSql2, $"MessageId='{messageId}'", tm);
            tm.Commit();
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

    /// <summary>
    /// 获取最新的消息数量
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="cancellation"></param>
    /// <returns></returns>
    public async Task<int> GetLatestMessageCount(string userId, CancellationToken cancellation)
    {
        return await DbUtil.GetRepository<SemUserMessage>().AsQueryable()
            .Where(f => f.ReceiverID == userId
                && f.Status == 0 && f.BeginDate <= DateTime.UtcNow && f.EndDate > DateTime.UtcNow)
            .Select(f => SqlFunc.AggregateCount(f.MessageID))
            .FirstAsync();
    }

    /// <summary>
    /// 获取模板语言并缓存
    /// </summary>
    /// <param name="isForceRefresh"></param>
    /// <returns></returns>
    private async Task<List<SemTemplateLang>> GetSemTemplateLangsAndCache(bool isForceRefresh = false)
    {
        var cacheKey = RedisUtil.GetProjectGroupRedisKey("SemTemplateLang", typeof(SemTemplateLang), "all");
        (var hasCache, var cacheValues) = await this.redisService.GetAsync<List<SemTemplateLang>>(cacheKey);
        if (!hasCache || cacheValues == null || cacheValues.Count == 0 || isForceRefresh)
        {
            cacheValues = await DbUtil.GetRepository<SemTemplateLang>().AsQueryable().ToListAsync();
            await this.redisService.SetAsync(cacheKey, cacheValues);
        }
        return cacheValues;
    }

    /// <summary>
    /// 获取模板Id
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="templateId"></param>
    /// <param name="templateKey"></param>
    /// <returns></returns>
    private async Task<(bool, string, string)> TryGetTemplateId(string userId, string templateId, string templateKey)
    {
        if (string.IsNullOrEmpty(templateId) && string.IsNullOrEmpty(templateKey))
            return (false, null, null);

        var templateCaches = await this.GetSemTemplatesAndCache();
        var engineParameter = new RuleEngineParameter
        {
            RequestParameters = new Dictionary<string, object> { { "userId", userId } }
        };

        string title = null;
        if (string.IsNullOrEmpty(templateId) && !string.IsNullOrEmpty(templateKey))
        {
            var myTemplates = templateCaches.FindAll(f => f.TemplateKey == templateKey);
            foreach (var myTemplate in myTemplates)
            {
                var hashKey = HashCode.Combine(templateKey, myTemplate.ConditionExpr);
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
        if (string.IsNullOrEmpty(templateId)) return (false, null, null);

        return (true, templateId, title);
    }

    /// <summary>
    /// 获取模板并缓存
    /// </summary>
    /// <param name="isForceRefresh"></param>
    /// <returns></returns>
    private async Task<List<TemplateCache>> GetSemTemplatesAndCache(bool isForceRefresh = false)
    {
        var cacheKey = RedisUtil.GetProjectGroupRedisKey("SemTemplate", typeof(SemTemplate), "all");
        (var hasCache, var cacheValues) = await this.redisService.GetAsync<List<TemplateCache>>(cacheKey);
        if (!hasCache || cacheValues == null || cacheValues.Count == 0 || isForceRefresh)
        {
            cacheValues = await DbUtil.GetRepository<SemTemplate>().AsQueryable()
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

    /// <summary>
    /// 替换消息文本
    /// </summary>
    /// <param name="message"></param>
    /// <param name="userId"></param>
    /// <param name="langId"></param>
    /// <param name="templateLangs"></param>
    /// <returns></returns>
    private async Task<LatestMessageDto> ReplaceMessageText(LatestMessageDto message, string userId, string langId, List<SemTemplateLang> templateLangs)
    {
        if (!string.IsNullOrEmpty(message.TemplateID))
        {
            var parameters = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(message.Content))
                parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(message.Content).ToLowerKeys();

            var templateIds = new List<string> { "DepositNotice800001", "WithdrawNotice900001" };
            if (parameters == default && templateIds.Contains(message.TemplateID))
            {
                var userCache = await GlobalUserDCache.Create(userId);
                var domainUrl = await userCache.GetRegistClientUrlAsync();
                if (string.IsNullOrEmpty(domainUrl))
                {
                    var operatorId = await userCache.GetOperatorIdAsync();
                    var sOperator = DbCachingUtil.GetSingle<S_operatorPO>(operatorId);
                    var domainUrls = sOperator.MapDomain.Split('|');
                    domainUrl = domainUrls[0];
                }
                else
                {
                    var index = domainUrl.IndexOf("/", 8);
                    domainUrl = domainUrl.Substring(0, index);
                }
                parameters = new Dictionary<string, object> { { "domainurl", domainUrl } };
            }

            var templateLang = templateLangs.Find(t => t.LangID == langId && t.TemplateID == message.TemplateID);
            if (templateLang == null)
                templateLang = templateLangs.FirstOrDefault(t => t.TemplateID == message.TemplateID);

            if (templateLang != null)
            {
                message.Title = templateLang.Title;
                message.Content = templateLang.Content;

                var pattern = @"(\{\{(\w+)\}\})";
                message.Title = Regex.Replace(message.Title, pattern, match =>
                {
                    var variableName = match.Groups[2].Value;
                    var tempVariable = $"{{{variableName}}}";

                    if (parameters != null && parameters.TryGetValue(variableName.ToLower(), out var itemValue))
                        return itemValue.ToString();
                    return tempVariable;
                });

                message.Content = Regex.Replace(message?.Content, pattern, match =>
                {
                    var variableName = match.Groups[2].Value;
                    var tempVariable = $"{{{variableName}}}";
                    if (parameters != null && parameters.TryGetValue(variableName.ToLower(), out var itemValue))
                        return itemValue.ToString();
                    return tempVariable;
                });
            }
        }
        else
        {
            if (!string.IsNullOrWhiteSpace(message.Content))
            {
                var contentJson = JsonConvert.DeserializeObject<MessageContentJson>(message.Content);
                message.Title = contentJson.Title;
                message.Content = contentJson.Content;
            }
        }
        return message;
    }
}

/// <summary>
/// 消息体
/// </summary>
class MessageContentJson
{
    public string Title { get; set; }

    public string Content { get; set; }
}

/// <summary>
/// 奖励信息
/// </summary>
class RewardInfo
{
    /// <summary>
    /// 消息Id
    /// </summary>
    public string MessageId { get; set; }

    /// <summary>
    /// 货币类型
    /// </summary>
    public int AmountType { get; set; }

    /// <summary>
    /// 奖励金额
    /// </summary>
    public long RewardAmount { get; set; }

    /// <summary>
    /// 来源Id
    /// </summary>
    public string SourceId { get; set; }

    /// <summary>
    /// 接受状态
    /// </summary>
    public int ReceiveStatus { get; set; }
}

/// <summary>
/// 模板缓存
/// </summary>
class TemplateCache
{
    public string TemplateId { get; set; }

    public string TemplateKey { get; set; }

    public string Title { get; set; }

    public string ConditionExpr { get; set; }

    public int DisplayTag { get; set; }

    public int ContentType { get; set; }
}

/// <summary>
/// 提醒邮件
/// </summary>
public class NoticeEmail
{
    /// <summary>
    /// 
    /// </summary>
    public string AppId { get; set; }

    /// <summary>
    /// 发送人Id
    /// </summary>
    public string SenderId { get; set; }

    /// <summary>
    /// 接受人Id
    /// </summary>
    public string ReceiverId { get; set; }

    /// <summary>
    /// 模板Id
    /// </summary>
    public string TemplateId { get; set; }

    /// <summary>
    /// 模板Key
    /// </summary>
    public string TemplateKey { get; set; }

    /// <summary>
    /// 展示标识
    /// </summary>
    public int DisplayTag { get; set; }

    /// <summary>
    /// 开始时间
    /// </summary>
    public DateTime BeginDateUtc { get; set; }

    /// <summary>
    /// 结束时间
    /// </summary>
    public DateTime EndDateUtc { get; set; }

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }
}

/// <summary>
/// 奖励提醒邮件
/// </summary>
public class RewardNoticeEmail : NoticeEmail
{
    ///
    /// <summary>
    /// 金额类型 1-Bonus 2-真金
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
}
