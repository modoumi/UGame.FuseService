using System.Text.RegularExpressions;
using TinyFx.Configuration;
using TinyFx.Data.SqlSugar;
using TinyFx.DbCaching;
using TinyFx.Randoms;
using TinyFx.Text;
using UGame.FuseService.Marquee.Caching;
using UGame.FuseService.Marquee.Extensions;
using UGame.FuseService.Marquee.Models;
using UGame.FuseService.Marquee.Models.Dtos;
using UGame.FuseService.Marquee.Models.Ipos;
using UGame.FuseService.Marquee.Repositories;
using Xxyy.Common.Caching;
using Xxyy.DAL;

namespace UGame.FuseService.Marquee.Services;

/// <summary>
/// 跑马灯服务
/// </summary>
public class MarqueeService
{
    /// <summary>
    /// 跑马灯
    /// </summary>
    /// <param name="ipo"></param>
    /// <returns></returns>
    public async Task<List<SCMarqueeDto>> Marquee(SCMarqueeIpo ipo)
    {
        var _marqueeDcache = new SCMarqueeDCache(ipo.OperatorId, ipo.LangId, ipo.MarqueeType);
        var scMarquee = await _marqueeDcache.GetAllOrLoadAsync();

        if (!scMarquee.HasValue) return new List<SCMarqueeDto>();

        var marqueeConfigList = await new ScMarqueeConfigDCache().GetAsync();
        if (!marqueeConfigList.HasValue) return new List<SCMarqueeDto>();

        var marqueeConfig = marqueeConfigList.Value.Where(_ => _.OperatorID == ipo.OperatorId).FirstOrDefault();
        if (marqueeConfig == null) return new List<SCMarqueeDto>();

        var requireCount = marqueeConfig.TextMaxNumber;
        var excludeAppIds = new List<string>();
        var retList = scMarquee.Value.ToList();
        if (ipo.MarqueeType == 1)
        {
            var picMarqueeApps = await GetMarqueePicApps(ipo.OperatorId);
            requireCount = picMarqueeApps.Count;
            excludeAppIds = retList.Select(r => r.AppId).ToList();//图片轮播时，排除已存在于缓存的游戏
        }

        if (retList.Count <= requireCount)
        {
            var templateLang = await GetTemplateLang(ipo.MarqueeType, ipo.OperatorId, ipo.LangId);
            if (templateLang != null)
            {
                var appendList = await GenerateFakeMarqueeDto(templateLang, ipo.OperatorId, requireCount - retList.Count, ipo.MarqueeType, excludeAppIds);
                retList.AddRange(appendList);
                foreach (var appendItem in appendList)
                {
                    await _marqueeDcache.UpdateCache(appendItem);
                }
            }
        }
        return retList;
    }

    /// <summary>
    /// 通过模板生成伪造轮播数据
    /// </summary>
    /// <param name="template"></param>
    /// <param name="operatorId"></param>
    /// <param name="dataCount">生成数量</param>
    /// <param name="marqueeType">0:文字轮播，1:带图的轮播</param>
    /// <param name="excludeAppIds">需要排除的游戏id</param>
    /// <returns></returns>
    public async Task<List<SCMarqueeDto>> GenerateFakeMarqueeDto(Sc_templ_langPO template, string operatorId, int dataCount, int marqueeType, List<string> excludeAppIds = null)
    {
        var ret = new List<SCMarqueeDto>();
        var marqueeConfig = DbCachingUtil.GetSingle<Sc_marquee_configPO>(f => f.OperatorID, operatorId);
        if (marqueeConfig != null)
        {

            var appList = DbCachingUtil.GetAllList<S_appPO>().ToArray();
            appList = appList.Where(d => d.Status == 1 && d.AppType == 2).ToArray();
            var originalRandomApps = RandomUtil.RandomNotRepeat(appList, 20);
            //await sappMo.GetTopSortAsync("`Status`=1 and AppType=2", 20, "RAND() asc");//原始游戏app
            var randomApps = new List<S_operator_appPO>();
            foreach (var _sapp in appList)
            {
                if (randomApps.Count >= 20) break;
                var _operApp = DbCacheUtil.GetOperatorApp(operatorId, _sapp.AppID, false);
                if (_operApp != null)
                {
                    randomApps.Add(_operApp);
                }
            }

            if (marqueeType == 1)
            {
                randomApps = await GetMarqueePicApps(operatorId, excludeAppIds);
                dataCount = dataCount < randomApps.Count ? dataCount : randomApps.Count;//图片轮播时，缓存中每款游戏只有一条数据
            }

            if (dataCount > 0 && randomApps.Any())
            {
                Random rand = new Random();
                var secondaryRandomApps = new List<S_operator_appEO>();
                var remainDataCount = dataCount;
                var j = 0;
                for (int i = 0; i < dataCount; i++)
                {
                    j = j > randomApps.Count - 1 ? 0 : j;
                    var curOperApp = randomApps[j];
                    var metaData = GenerateFakeMarqueeMetaData(curOperApp.AppID, marqueeConfig);
                    if (metaData != null)
                    {
                        ret.Add(await GenerateMarqueeDto(metaData, template, operatorId));
                        remainDataCount--;
                        secondaryRandomApps.Add(curOperApp);
                    }
                    j++;
                }

                if (remainDataCount > 0 && secondaryRandomApps.Any())//不够数量时，再生成一次
                {
                    j = 0;
                    for (int i = 0; i < remainDataCount; i++)
                    {
                        j = j > secondaryRandomApps.Count - 1 ? 0 : j;
                        var curOperApp = randomApps[j];
                        var metaData = GenerateFakeMarqueeMetaData(curOperApp.AppID, marqueeConfig);
                        if (metaData != null)
                        {
                            ret.Add(await GenerateMarqueeDto(metaData, template, operatorId));
                        }
                        j++;
                    }
                }
            }
        }

        return ret;
    }

    /// <summary>
    /// 通过模板生成真实轮播数据
    /// </summary>
    /// <param name="metaData"></param>
    /// <param name="template"></param>
    /// <param name="operatorId"></param>
    /// <returns></returns>
    public async Task<SCMarqueeDto> GenerateMarqueeDto(MarqueeMetaModel metaData, Sc_templ_langPO template, string operatorId)
    {
        var ret = new SCMarqueeDto();
        if (metaData != null)
        {
            var operatorApp = DbCacheUtil.GetOperatorApp(operatorId, metaData.appId);
            ret.AppName = metaData.appName;
            ret.AppIcon = metaData.appIcon;
            ret.AppId = metaData.appId;
            ret.IsSupportBonus = operatorApp.UseBonus;
            ret.WinAmount = metaData.amount;

            string marqueeText = Regex.Replace(template.Content, "\\{(\\w+)\\}", (match) =>
            {
                if (match.Success)
                {
                    var key = match.Result("$1");
                    string val = string.Empty;

                    var propertyInfo = metaData.GetType().GetProperty(key);
                    if (propertyInfo != null)
                        val = Convert.ToString(propertyInfo.GetValue(metaData, null));//.ToString();
                    if (!string.IsNullOrWhiteSpace(val))
                    {
                        if ("mobile" == key)
                        {
                            if (Regex.IsMatch(val, "^\\d+$"))
                            {
                                if (val.Length > 4)
                                {
                                    val = val.Substring(0, 2) + "******" + val.Substring(val.Length - 4);
                                }
                            }
                            else
                            {
                                val = val.Length > 3 ? "******" + val.Substring(val.Length - 3) : val;
                            }
                            ret.UserNameOrMobile = val;
                        }
                        else if ("userName" == key)
                        {
                            if (Regex.IsMatch(val, "^\\d+$"))
                            {
                                if (val.Length > 4)
                                {
                                    val = val.Substring(0, 2) + "******" + val.Substring(val.Length - 4);
                                }
                            }
                            else
                            {
                                val = val.Length > 3 ? "******" + val.Substring(val.Length - 3) : val;
                            }
                            ret.UserNameOrMobile = val;
                        }
                        return val;
                    }
                    else
                    {
                        return match.Value;
                    }
                }
                return match.Value;
            });

            ret.MessageContent = marqueeText;
        }

        return ret;
    }

    /// <summary>
    /// 伪造轮播元数据
    /// </summary>
    /// <param name="appId"></param>
    /// <param name="marqueeConfig"></param>
    /// <returns></returns>
    private static MarqueeMetaModel GenerateFakeMarqueeMetaData(string appId, Sc_marquee_configPO marqueeConfig)
    {
        Random rand = new();
        var curSapp = DbCacheUtil.GetApp(appId, false);
        var curLapp = DbCachingUtil.GetSingle<L_appPO>(f => f.AppID, appId);
        if (curSapp == null || curLapp == null) return null;
        var lobbyAppOptions = ConfigUtil.GetSection<OptionsSection>();
        var baseImageUrl = lobbyAppOptions.ImageBaseUrl;
        var metaData = new MarqueeMetaModel
        {
            appId = curSapp.AppID,
            appName = curSapp.AppName,
            userId = ObjectId.NewId(),
            userName = "******" + GetRdmCode(3),
            mobile = "55******" + rand.Next(1000, 9999),
            amount = rand.Next(100, 1000) * marqueeConfig.FakeWinMultiple,
            recDate = DateTime.UtcNow,
            appIcon = baseImageUrl + curLapp.MarqueeIcon
        };
        return metaData;
    }

    /// <summary>
    /// 获取随机字符
    /// </summary>
    /// <param name="len"></param>
    /// <returns></returns>
    private static string GetRdmCode(int len)
    {
        string rndCode = string.Empty;
        var character = new char[] { '2', '3', '4', '5', '6', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'W', 'X', 'Y' };
        Random rnd = new();
        for (int i = 0; i < len; i++)
        {
            rndCode += character[rnd.Next(character.Length)];
        }
        return rndCode;
    }

    /// <summary>
    /// 获取轮播图片的游戏app
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="excludeAppIds"></param>
    /// <returns></returns>
    public async Task<List<S_operator_appPO>> GetMarqueePicApps(string operatorId, List<string> excludeAppIds = null)
    {
        var ret = new List<S_operator_appPO>();
        //var picRandomApps = await lappMo.GetTopSortAsync("MarqueeStatus=1", 20, "RAND() asc");//支持轮播的app
        var picRandomApps = await DbUtil.GetRepository<L_appPO>().AsQueryable()
            .Where(f => f.MarqueeStatus == 1 && !string.IsNullOrEmpty(f.MarqueeIcon))
            .Take(50)
            .ToListAsync(); //支持轮播的app
        foreach (var _lapp in picRandomApps)
        {
            if (ret.Count >= 20) break;
            var _operApp = DbCacheUtil.GetOperatorApp(operatorId, _lapp.AppID, false);
            if (_operApp != null)
            {
                ret.Add(_operApp);
            }
        }

        if (excludeAppIds != null && excludeAppIds.Any())
            ret = ret.Where(a => !excludeAppIds.Contains(a.AppID)).ToList();

        return ret;
    }

    /// <summary>
    /// 获取轮播模板
    /// </summary>
    /// <param name="marqueeType"></param>
    /// <param name="operatorId"></param>
    /// <param name="langId"></param>
    /// <returns></returns>
    public async Task<Sc_templ_langPO> GetTemplateLang(int marqueeType, string operatorId, string langId)
    {
        var curTemplate = await DbUtil.GetRepository<Sc_templPO>()
            .GetFirstAsync(f => f.TemplateType == marqueeType);
        if (curTemplate != null)
        {
            return await DbUtil.GetRepository<Sc_templ_langPO>()
                .GetFirstAsync(f => f.SCTemplateID == curTemplate.SCTemplateID && f.OperatorID == operatorId && f.LangID == langId);
        }
        return null;
    }
}
