using UGame.FuseService.Banner.Caching;
using UGame.FuseService.Banner.Repositories;

namespace UGame.FuseService.Banner.Utilities;

public class OperatorAcvitityUtil
{
    /// <summary>
    /// 获取当前运营商配置的所有活动
    /// </summary>
    /// <param name="operatorId">运营商编码</param>
    /// <param name="currencyId">货币编码</param>
    /// <param name="IsEnable">true只查开启中的活动，false查所有</param>
    /// <returns></returns>
    public static async Task<List<L_activity_operatorPO>> GetOperatorActivity(string operatorId, string currencyId, bool IsEnable = true)
    {
        var ret = new List<L_activity_operatorPO>();

        var cache = await new ActivityOperatorBaseDCache(operatorId, currencyId).GetAsync();

        if (cache.HasValue)
            ret = cache.Value;

        if (IsEnable)
            ret = cache.Value.Where(d => d.Status).ToList();

        return ret;
    }
}
