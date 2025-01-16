using EasyNetQ;
using System.ServiceModel.Channels;
using TinyFx;
using TinyFx.BIZ.RabbitMQ;
using TinyFx.Configuration;
using TinyFx.Data.SqlSugar;
using TinyFx.DbCaching;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Text;
using UGame.FuseService.Marquee.Caching;
using UGame.FuseService.Marquee.Extensions;
using UGame.FuseService.Marquee.Models;
using UGame.FuseService.Marquee.Models.Dtos;
using UGame.FuseService.Marquee.Repositories;
using UGame.FuseService.Marquee.Services;
using Xxyy.Common;
using Xxyy.Common.Caching;
using Xxyy.DAL;
using Xxyy.MQ.Xxyy;

namespace UGame.FuseService.Marquee.Consumer;

/// <summary>
/// 跑马灯消费者
/// </summary>
public class MarqueeConsumer : MQBizSubConsumer<UserBetMsg>
{
    private readonly MarqueeService marqueeService = new();

    /// <summary>
    /// 构造
    /// </summary>
    public MarqueeConsumer()
    {
        AddHandler(UpdateMarquee);
    }

    /// <summary>
    /// 
    /// </summary>
    public override MQSubscribeMode SubscribeMode => MQSubscribeMode.OneQueue;

    /// <summary>
    /// 更新跑马灯
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task UpdateMarquee(UserBetMsg message, CancellationToken cancellationToken)
    {
        if ((message.BetType != 2 && message.BetType != 3) || message.WinAmount <= 0) return;

        //读取marquee配置
        var marqueeConfig = DbCachingUtil.GetSingle<Sc_marquee_configPO>(f => f.OperatorID, message.OperatorId);
        if (marqueeConfig == null) return;

        //语种对应的marquee展示数据
        var marqueeTextDtos = new Dictionary<string, SCMarqueeDto>();
        var marqueePicDtos = new Dictionary<string, SCMarqueeDto>();

        //构造marquee数据
        if (message.WinAmount < marqueeConfig.WinMinAmount) return;

        var marqueeTextTempl = await DbUtil.GetRepository<Sc_templPO>()
            .GetFirstAsync(f => f.TemplateType == 0);

        if (marqueeTextTempl == null) return;

        //模板需要的元数据独立存储，抽离根据模板语言构造展示数据的逻辑，构造好的展示数据直接推送到缓存

        var userDcache = await GlobalUserDCache.Create(message.UserId);
        var lApp = DbCachingUtil.GetSingle<L_appPO>(f => f.AppID, message.AppId);
        var sApp = DbCachingUtil.GetSingle<S_appPO>(f => f.AppID, message.AppId);

        var userMobile = await GetUserNameOrMobile(message.UserId);

        #region 文字轮播
        var marqueeMetaData = new MarqueeMetaModel()
        {
            appId = message.AppId,
            appName = sApp.AppName,
            userId = message.UserId,
            userName = !string.IsNullOrEmpty(await userDcache.GetUsernameAsync()) ? await userDcache.GetUsernameAsync() : await userDcache.GetNicknameAsync(),
            mobile = userMobile,
            amount = message.WinAmount.AToM(message.CurrencyId),
            recDate = DateTime.UtcNow
        };

        var marqueeTextInfo = new Sc_marqueePO()
        {
            MarqueeID = ObjectId.NewId(),
            AppID = message.AppId,
            OperatorID = message.OperatorId,
            RecDate = DateTime.UtcNow,
            SCTemplateID = marqueeTextTempl.SCTemplateID,
            SCTemplateParams = await SerializerUtil.SerializeJsonAsync(marqueeMetaData),//JsonConvert.SerializeObject(marqueeMetaTextData),
            Status = 1,
            Position = 0,
            MarqueeType = 0
        };


        #region 生成文字marquee展示数据
        var templateTxtLangs = await DbUtil.GetRepository<Sc_templ_langPO>()
            .GetListAsync(f => f.SCTemplateID == marqueeTextTempl.SCTemplateID && f.OperatorID == message.OperatorId);

        if (templateTxtLangs != null && templateTxtLangs.Any())
        {
            foreach (var _templLang in templateTxtLangs)
            {
                var _marqueeDto = await marqueeService.GenerateMarqueeDto(marqueeMetaData, _templLang, message.OperatorId);
                marqueeTextDtos.TryAdd(_templLang.LangID, _marqueeDto);
            }
        }
        #endregion

        #endregion

        #region 图片类轮播
        if (lApp != null && lApp.MarqueeStatus == 1)
        {
            var marqueePicTempl = await DbUtil.GetRepository<Sc_templPO>()
                .GetFirstAsync(f => f.TemplateType == 1);

            if (marqueePicTempl != null)
            {
                var marqueeMetaPicData = marqueeMetaData;
                var lobbyAppOptions = ConfigUtil.GetSection<OptionsSection>();
                var baseImageUrl = lobbyAppOptions.ImageBaseUrl;
                var relativeIcon = string.IsNullOrWhiteSpace(lApp.MarqueeIcon) ? lApp.MiddleIcon : lApp.MarqueeIcon;//todo,去掉取middleicon的逻辑
                marqueeMetaPicData.appIcon = relativeIcon.StartsWith("http") ? relativeIcon : baseImageUrl + relativeIcon;

                var marqueePicInfo = new Sc_marqueePO()
                {
                    MarqueeID = ObjectId.NewId(),
                    AppID = message.AppId,
                    OperatorID = message.OperatorId,
                    RecDate = DateTime.UtcNow,
                    SCTemplateID = marqueePicTempl.SCTemplateID,
                    SCTemplateParams = await SerializerUtil.SerializeJsonAsync(marqueeMetaPicData),//JsonConvert.SerializeObject(marqueeMetaTextData),
                    Status = 1,
                    Position = 0,
                    MarqueeType = 1
                };

                #region 生成带图片marquee展示数据
                var templatePicLangs = await DbUtil.GetRepository<Sc_templ_langPO>()
                    .GetListAsync(f => f.SCTemplateID == marqueePicTempl.SCTemplateID && f.OperatorID == message.OperatorId);
                if (templatePicLangs != null && templatePicLangs.Any())
                {
                    foreach (var _templLang in templatePicLangs)
                    {
                        var _marqueeDto = await marqueeService.GenerateMarqueeDto(marqueeMetaPicData, _templLang, message.OperatorId);
                        marqueePicDtos.TryAdd(_templLang.LangID, _marqueeDto);
                    }
                }
                #endregion
            }
        }
        #endregion

        #region 更新marquee缓存

        if (marqueeTextDtos.Any())
        {
            foreach (var _marqueeDto in marqueeTextDtos)
            {
                var _marqueeDcache = new SCMarqueeDCache(message.OperatorId, _marqueeDto.Key, 0);
                await _marqueeDcache.UpdateCache(_marqueeDto.Value);
            }
        }

        if (marqueePicDtos.Any())
        {
            foreach (var _marqueeDto in marqueePicDtos)
            {
                var _marqueeDcache = new SCMarqueeDCache(message.OperatorId, _marqueeDto.Key, 1);
                await _marqueeDcache.UpdateCache(_marqueeDto.Value);
            }
        }
        #endregion
    }

    private async Task<string> GetUserNameOrMobile(string userId)
    {
        var userDcache = await GlobalUserDCache.Create(userId);
        var userMobile = !string.IsNullOrEmpty(await userDcache.GetMobileAsync())
            ? await userDcache.GetMobileAsync() : !string.IsNullOrEmpty(await userDcache.GetUsernameAsync())
            ? await userDcache.GetUsernameAsync() : !string.IsNullOrEmpty(await userDcache.GetNicknameAsync())
            ? await userDcache.GetNicknameAsync() : await userDcache.GetEmailAsync();
        return userMobile;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="config"></param>
    protected override void Configuration(ISubscriptionConfiguration config)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    protected override Task OnMessage(UserBetMsg message, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
