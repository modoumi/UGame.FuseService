using TinyFx.AspNet;

namespace UGame.FuseService.Marquee.Models.Ipos;

public class SCMarqueeIpo : LobbyBaseIpo
{

    /// <summary>
    /// 位置
    /// </summary>
    public int Position { get; set; }

    /// <summary>
    /// 轮播类型，0:文字，1:图片
    /// </summary>
    public int MarqueeType { get; set; }
}

public class LobbyBaseIpo
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
}

