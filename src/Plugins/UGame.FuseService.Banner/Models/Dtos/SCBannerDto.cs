using TinyFx.Extensions.AutoMapper;
using UGame.FuseService.Banner.Repositories;

namespace UGame.FuseService.Banner.Models.Dtos;

/// <summary>
/// 
/// </summary>
public class SCBannerDto : IMapFrom<Sc_bannerPO>
{
    /// <summary>
    /// Banner编码
    /// </summary>
    public string BannerID { get; set; }

    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 提示信息
    /// </summary>
    public string Tip { get; set; }
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// 图片链接
    /// </summary>
    public string ImageUrl { get; set; }
    /// <summary>
    /// 链接类型
    /// 1-相对地址
    /// 2-绝对地址
    /// 3-游戏地址
    /// </summary>
    public int LinkType { get; set; }
    /// <summary>
    /// 链接地址
    /// </summary>
    public string LinkUrl { get; set; }
    /// <summary>
    /// 链接参数（json串，暂无示例）
    /// </summary>
    public string LinkParams { get; set; }
    /// <summary>
    /// 链接文字
    /// </summary>
    public string LinkContent { get; set; }
    /// <summary>
    /// 位置
    /// </summary>
    public int Position { get; set; }
    /// <summary>
    /// 语言编码
    /// </summary>
    public string LangID { get; set; }

    /// <summary>
    /// 10000X活动；50000XVIP
    /// </summary>
    public int Code { get; set; }

    /// <summary>
    /// (目前只针对position=7生效)
    /// 0-不参与规则
    /// 1-每天首次显示
    /// 2-每天非首次显示
    /// </summary>
    public int ShowDay { get; set; }

    /// <summary>
    /// banner显示间隔
    /// </summary>
    public int ShowInterval { get; set; } = 0;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="source"></param>
    public void MapFrom(Sc_bannerPO source)
    {
        this.LinkContent = source.Tip;
    }
}
