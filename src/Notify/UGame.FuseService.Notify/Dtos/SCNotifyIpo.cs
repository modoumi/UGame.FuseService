using Newtonsoft.Json;
using SCommon.Common.Dtos;
using System.Collections.Generic;
using TinyFx.AspNet;
using TinyFx.Extensions.AutoMapper;
using UGame.FuseService.Notify.Repositories.DAL.ing;

namespace UGame.FuseService.Notify.Dtos;

public class SCNotifyIpo : LobbyBaseIpo
{
    /// <summary>
    /// 应用编码
    /// </summary>
    [RequiredEx("", "AppId cannot be empty.")]
    public string AppId { get; set; }
    /// <summary>
    /// 何时显示
    /// 1-登录前
    /// 2-注册后第一次登录
    /// 3-登录后
    /// </summary>
    public int ActionAt { get; set; }
    /// <summary>
    /// 显示页面FLAG值
    /// 1-首页
    /// 2-
    /// 4-
    /// 8-
    /// </summary>
    public int ShowAt { get; set; }
}
public class SCNotifyDto : IMapFrom<V_sc_notify_detailEO>, IMapFrom<Sc_notifyEO>
{
    /// <summary>
    /// 通知编码
    /// </summary>
    public string NotifyId { get; set; }
    /// <summary>
    /// 显示位置
    /// 1-顶部
    /// 2-中部
    /// 3-下部
    /// </summary>
    public int Position { get; set; }
    /// <summary>
    /// 自动关闭间隔（秒）
    /// 0-手动关闭
    /// </summary>
    public int CloseInterval { get; set; }
    /// <summary>
    /// 链接类型
    /// 1-email
    /// 2-url
    /// </summary>
    public int LinkKind { get; set; }
    /// <summary>
    /// 链接地址
    /// </summary>
    public string LinkUrl { get; set; }
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// 图片链接
    /// </summary>
    public string ImageUrl { get; set; }
    /// <summary>
    /// 文本集合
    /// </summary>
    public List<string> Txts { get; set; }
    /// <summary>
    /// 图片集合
    /// </summary>
    public List<string> Imgs { get; set; }
    /// <summary>
    /// 需要通知的用户人数
    /// </summary>
    [JsonIgnore]
    public int NotifyUsersCount { get; set; }
    /// <summary>
    /// 已通知用户人数
    /// </summary>
    [JsonIgnore]
    public int NotifyedUsersCount { get; set; }

    /// <summary>
    /// 是否更新缓存
    /// </summary>
    [JsonIgnore]
    public bool IsUpdateCache { get; set; }

    public void MapFrom(V_sc_notify_detailEO source)
    {
        NotifyId = source.NotifyID;
        Position = source.Position;
        CloseInterval = source.CloseInterval;
        LinkKind = source.LinkKind;
        LinkUrl = source.LinkUrl;
        Title = source.Title;
        Content = source.Content;
        ImageUrl = source.ImageUrl;
        Txts = new List<string>();
        if (!string.IsNullOrWhiteSpace(source.Txt1))
            Txts.Add(source.Txt1);
        if (!string.IsNullOrWhiteSpace(source.Txt2))
            Txts.Add(source.Txt2);
        if (!string.IsNullOrWhiteSpace(source.Txt3))
            Txts.Add(source.Txt3);
        if (!string.IsNullOrWhiteSpace(source.Txt4))
            Txts.Add(source.Txt4);
        if (!string.IsNullOrWhiteSpace(source.Txt5))
            Txts.Add(source.Txt5);
        Imgs = new List<string>();
        if (!string.IsNullOrWhiteSpace(source.Img1))
            Imgs.Add(source.Img1);
        if (!string.IsNullOrWhiteSpace(source.Img2))
            Imgs.Add(source.Img2);
        if (!string.IsNullOrWhiteSpace(source.Img3))
            Imgs.Add(source.Img3);
        if (!string.IsNullOrWhiteSpace(source.Img4))
            Imgs.Add(source.Img4);
        if (!string.IsNullOrWhiteSpace(source.Img5))
            Imgs.Add(source.Img5);
        if (source.NotifyUsersCount <= source.NotifyedUsersCount)
            this.IsUpdateCache = true;
    }

    public void MapFrom(Sc_notifyEO source)
    {

    }
}
