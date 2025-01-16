using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;
using UGame.FuseService.Marquee.Models.Dtos;
using UGame.FuseService.Marquee.Services;

namespace UGame.FuseService.Marquee.Caching;

/// <summary>
/// 跑马灯缓存
/// </summary>
public class SCMarqueeDCache : RedisListClient<SCMarqueeDto>
{
    private readonly int EXPIRE_MINUTES = 30;

    private string OperatorId { get; set; }

    private string LangId { get; set; }

    private int MarqueeType { get; set; }

    /// <summary>
    /// 构造方法
    /// </summary>
    /// <param name="operatorId"></param>
    /// <param name="langId">en,es,pt</param>
    /// <param name="marqueeType">0:文字类跑马灯，1:带图片跑马灯</param>
    public SCMarqueeDCache(string operatorId, string langId, int marqueeType)
    {
        OperatorId = operatorId;
        LangId = langId;
        MarqueeType = marqueeType != 0 && marqueeType != 1 ? 0 : marqueeType;
        RedisKey = GetProjectGroupRedisKey("Marquee", $"{OperatorId}|{MarqueeType}|{LangId}");
    }

    /// <summary>
    /// 加载
    /// </summary>
    /// <returns></returns>
    protected override async Task<CacheValue<IEnumerable<SCMarqueeDto>>> LoadAllValuesWhenRedisNotExistsAsync()
    {
        var ret = new CacheValue<IEnumerable<SCMarqueeDto>>();
        var marqueeConfigList = await new ScMarqueeConfigDCache().GetAsync();
        if (!marqueeConfigList.HasValue) return ret;

        var marqueeConfig = marqueeConfigList.Value.Where(_ => _.OperatorID == OperatorId).FirstOrDefault();

        var curTemplateLang = await new MarqueeService().GetTemplateLang(MarqueeType, OperatorId, LangId);
        if (curTemplateLang != null)
        {
            var dataCount = MarqueeType == 0 ? marqueeConfig.TextMaxNumber : marqueeConfig.PicMaxNumber;
            var dtoList = await new MarqueeService().GenerateFakeMarqueeDto(curTemplateLang, OperatorId, dataCount, MarqueeType);
            ret.Value = dtoList;
            ret.HasValue = dtoList != null && dtoList.Any();
        }

        Database.KeyExpire(RedisKey, TimeSpan.FromMinutes(EXPIRE_MINUTES));
        return ret;
    }

    /// <summary>
    /// 更新缓存
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    public async Task UpdateCache(SCMarqueeDto dto)
    {
        var marqueeConfigList = await new ScMarqueeConfigDCache().GetAsync();

        if (!marqueeConfigList.HasValue) return;

        var dataCount = marqueeConfigList.Value.Where(_ => _.OperatorID == OperatorId).FirstOrDefault()?.TextMaxNumber;
        if (MarqueeType == 1)
        {
            var picMarqueeApps = await new MarqueeService().GetMarqueePicApps(OperatorId);
            dataCount = picMarqueeApps.Count;
            var curDtoList = (await GetAllAsync()).ToList();
            var existAppDtoList = curDtoList.Where(d => d.AppId == dto.AppId).ToList();
            if (existAppDtoList.Any())
            {
                foreach (var cdto in existAppDtoList)
                {
                    await RemoveAsync(cdto);
                }
            }
        }

        await LeftPushAsync(dto);

        if (await GetLengthAsync() > dataCount) await RightPopAsync();
    }
}
