using System.Text.Json.Serialization;
using TinyFx.AspNet;
using UGame.FuseService.Banner.Caching;
using UGame.FuseService.Banner.Common;
using UGame.FuseService.Banner.Repositories;
using Xxyy.Common;

namespace UGame.FuseService.Banner.Models.Ipos;

public class SCBannerIpo
{
    /// <summary>
    /// 用户编码
    /// </summary>
    [RequiredEx("", "UserId cannot be empty.")]
    public string UserId { get; set; }
    /// <summary>
    /// 运营商编码
    /// </summary>
    [RequiredEx("", "OperatorId cannot be empty.")]
    public string OperatorId { get; set; }
    /// <summary>
    /// 国家编码
    /// </summary>
    [RequiredEx("", "CountryId cannot be empty.")]
    public string CountryId { get; set; }
    /// <summary>
    /// 货币编码
    /// </summary>
    [RequiredEx("", "CurrencyId cannot be empty.")]
    public string CurrencyId { get; set; }
    /// <summary>
    /// 语言编码
    /// </summary>
    [RequiredEx("", "LangId cannot be empty.")]
    public string LangId { get; set; }
    /// <summary>
    /// 应用ID
    /// </summary>
    [RequiredEx("", "LangId cannot be empty.")]
    public string AppId { get; set; } 

    /// <summary>
    /// 位置
    /// </summary>
    public List<BannerPositionEnum> Position { get; set; } = new List<BannerPositionEnum>();

    /// <summary>
    /// 当前值只可能是BannerTypeEnum.Visitor或BannerTypeEnum.Register
    /// </summary>
    public BannerTypeEnum BannerType { get; set; }
    /// <summary>
    /// UserMode
    /// </summary>
    [JsonIgnore]
    public UserMode UserMode { get; set; }
    /// <summary>
    /// 用户是否充过值
    /// </summary>
    [JsonIgnore]
    public bool HasPay { get; set; } = false;
    /// <summary>
    /// 用户参与活动明细表
    /// </summary>
    [JsonIgnore]
    public List<L_user_activityPO> UserActivityEo { get; set; } = new List<L_user_activityPO>();

    /// <summary>
    /// utc时间
    /// </summary>
    [JsonIgnore]
    public DateTime UtcTime { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// 运营商当地日期
    /// </summary>
    [JsonIgnore]
    public DateTime LocalDate { get; set; }

    /// <summary>
    /// 用户当天是否查看过当前位置banner
    /// </summary>
    [JsonIgnore]
    public bool IsDayFirstLoad { get; set; }

    /// <summary>
    /// Banner用户缓存
    /// </summary>
    [JsonIgnore]
    public SCBannerUserDCache BannerUserDCache { get; set; }

    /// <summary>
    /// 当前运营商配置的所有活动
    /// </summary>
    [JsonIgnore]
    public List<L_activity_operatorPO> OperatorActivityEoList { get; set; } = new List<L_activity_operatorPO>();
}
