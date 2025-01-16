﻿namespace SComms.Promoter.Core.Models;

public class PagerList<T> : IPagerBase
{

    public int PageIndex { get; set; }

    public int PageSize { get; set; }

    public long Total { get; set; }

    public int PageCount { get; set; }

    /// <summary>
    /// 内容
    /// </summary>
    public List<T> Rows { get; set; }

    #region 构造函数

    /// <summary>
    /// 初始化一个<see cref="PagerList{T}"/>类型的实例
    /// </summary>
    public PagerList() : this(0)
    {
    }

    /// <summary>
    /// 初始化一个<see cref="PagerList{T}"/>类型的实例
    /// </summary>
    /// <param name="data">数据</param>
    public PagerList(IEnumerable<T> data = null) : this(0, data)
    {
    }

    /// <summary>
    /// 初始化一个<see cref="PagerList{T}"/>类型的实例
    /// </summary>
    /// <param name="totalCount">总行数</param>
    /// <param name="data">数据</param>
    public PagerList(int totalCount, IEnumerable<T> data = null) : this(1, 10, totalCount, data)
    {
    }

    /// <summary>
    /// 初始化一个<see cref="PagerList{T}"/>类型的实例
    /// </summary>
    /// <param name="pageIndex"></param>
    /// <param name="pageSize"></param>
    /// <param name="totalCount"></param>
    /// <param name="data"></param>
    public PagerList(int pageIndex, int pageSize, long totalCount, IEnumerable<T> data = null)
    {
        Rows = data?.ToList() ?? new List<T>();
        Total = totalCount;
        PageIndex = pageIndex;
        PageSize = pageSize;
        PageCount = GetPageCount();
    }

    #endregion

    /// <summary>
    /// 获取总页数
    /// </summary>
    public int GetPageCount()
    {
        if ((int)Total % (PageSize == 0 ? 1 : PageSize) == 0)
            return (int)Total / (PageSize == 0 ? 1 : PageSize);
        return (int)Total / PageSize + 1;
    }
}