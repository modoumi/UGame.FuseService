/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-10-24 18: 05:16
 ******************************************************/
using System;
using System.Data;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using TinyFx;
using TinyFx.Data;
using MySql.Data.MySqlClient;
using TinyFx.Data.MySql;

namespace UGame.FuseService.Notify.Repositories.DAL.ing
{
	#region EO
	/// <summary>
	/// 
	/// 【视图 v_sc_notify_detail 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_sc_notify_detailEO : IRowMapper<V_sc_notify_detailEO>
	{
		#region 所有字段
		/// <summary>
		/// 主键GUID
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string NotifyID { get; set; }
		/// <summary>
		/// 语言代码
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 2)]
		public string LangID { get; set; }
		/// <summary>
		/// 标题
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Title { get; set; }
		/// <summary>
		/// 图片地址
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 4)]
		public string ImageUrl { get; set; }
		/// <summary>
		/// 内容
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 5)]
		public string Content { get; set; }
		/// <summary>
		/// 链接类型1-email 2-url
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int LinkKind { get; set; }
		/// <summary>
		/// 链接
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string LinkUrl { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 8)]
		public string Txt1 { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 9)]
		public string Txt2 { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 10)]
		public string Txt3 { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 11)]
		public string Txt4 { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 12)]
		public string Txt5 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 13)]
		public string Img1 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 14)]
		public string Img2 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 15)]
		public string Img3 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 16)]
		public string Img4 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 17)]
		public string Img5 { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 18)]
		public string AppID { get; set; }
		/// <summary>
		/// 何时显示1-登录前2-注册后第一次登录3登录后
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 19)]
		public int ActionAt { get; set; }
		/// <summary>
		/// 显示页面FLAG值0-全部1-首页2-4-8
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 20)]
		public int ShowAt { get; set; }
		/// <summary>
		/// 运营商编码（null意味着全部）
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 21)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 用户范围0-全部用户1-指定具体用户
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 22)]
		public int UserScope { get; set; }
		/// <summary>
		/// 需要通知的用户人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 23)]
		public int NotifyUsersCount { get; set; }
		/// <summary>
		/// 已通知用户人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 24)]
		public int NotifyedUsersCount { get; set; }
		/// <summary>
		/// 显示位置1-顶部2-中部3-下部
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 25)]
		public int Position { get; set; }
		/// <summary>
		/// 展示次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 26)]
		public int ShowTimes { get; set; }
		/// <summary>
		/// 展示间隔（分钟）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 27)]
		public int ShowInterval { get; set; }
		/// <summary>
		/// 自动关闭间隔（秒）0-手动关闭
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 28)]
		public int CloseInterval { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 29)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 起始日期（默认2016-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 30)]
		public DateTime BeginDate { get; set; }
		/// <summary>
		/// 截止日期（默认2099-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 31)]
		public DateTime EndDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_sc_notify_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_sc_notify_detailEO MapDataReader(IDataReader reader)
		{
		    V_sc_notify_detailEO ret = new V_sc_notify_detailEO();
			ret.NotifyID = reader.ToString("NotifyID");
			ret.LangID = reader.ToString("LangID");
			ret.Title = reader.ToString("Title");
			ret.ImageUrl = reader.ToString("ImageUrl");
			ret.Content = reader.ToString("Content");
			ret.LinkKind = reader.ToInt32("LinkKind");
			ret.LinkUrl = reader.ToString("LinkUrl");
			ret.Txt1 = reader.ToString("Txt1");
			ret.Txt2 = reader.ToString("Txt2");
			ret.Txt3 = reader.ToString("Txt3");
			ret.Txt4 = reader.ToString("Txt4");
			ret.Txt5 = reader.ToString("Txt5");
			ret.Img1 = reader.ToString("Img1");
			ret.Img2 = reader.ToString("Img2");
			ret.Img3 = reader.ToString("Img3");
			ret.Img4 = reader.ToString("Img4");
			ret.Img5 = reader.ToString("Img5");
			ret.AppID = reader.ToString("AppID");
			ret.ActionAt = reader.ToInt32("ActionAt");
			ret.ShowAt = reader.ToInt32("ShowAt");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.UserScope = reader.ToInt32("UserScope");
			ret.NotifyUsersCount = reader.ToInt32("NotifyUsersCount");
			ret.NotifyedUsersCount = reader.ToInt32("NotifyedUsersCount");
			ret.Position = reader.ToInt32("Position");
			ret.ShowTimes = reader.ToInt32("ShowTimes");
			ret.ShowInterval = reader.ToInt32("ShowInterval");
			ret.CloseInterval = reader.ToInt32("CloseInterval");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.BeginDate = reader.ToDateTime("BeginDate");
			ret.EndDate = reader.ToDateTime("EndDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【视图 v_sc_notify_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class V_sc_notify_detailMO : MySqlViewMO<V_sc_notify_detailEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_sc_notify_detail`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_sc_notify_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_sc_notify_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_sc_notify_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByNotifyID
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyID(string notifyID)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyID(string notifyID, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyID(string notifyID, int top_)
		{
			return GetByNotifyID(notifyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyID(string notifyID, int top_, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyID(string notifyID, string sort_)
		{
			return GetByNotifyID(notifyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyID(string notifyID, string sort_, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyID(string notifyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyID` = @NotifyID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByNotifyID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Title` = @Title", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByImageUrl
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImageUrl(string imageUrl)
		{
			return GetByImageUrl(imageUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImageUrl(string imageUrl, TransactionManager tm_)
		{
			return GetByImageUrl(imageUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImageUrl(string imageUrl, int top_)
		{
			return GetByImageUrl(imageUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImageUrl(string imageUrl, int top_, TransactionManager tm_)
		{
			return GetByImageUrl(imageUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImageUrl(string imageUrl, string sort_)
		{
			return GetByImageUrl(imageUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImageUrl(string imageUrl, string sort_, TransactionManager tm_)
		{
			return GetByImageUrl(imageUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImageUrl(string imageUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ImageUrl` = @ImageUrl", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ImageUrl", imageUrl != null ? imageUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImageUrl
		#region GetByContent
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByContent(string content)
		{
			return GetByContent(content, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByContent(string content, TransactionManager tm_)
		{
			return GetByContent(content, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByContent(string content, int top_)
		{
			return GetByContent(content, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByContent(string content, int top_, TransactionManager tm_)
		{
			return GetByContent(content, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByContent(string content, string sort_)
		{
			return GetByContent(content, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByContent(string content, string sort_, TransactionManager tm_)
		{
			return GetByContent(content, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByContent(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Content` = @Content", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByContent
		#region GetByLinkKind
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkKind(int linkKind)
		{
			return GetByLinkKind(linkKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkKind(int linkKind, TransactionManager tm_)
		{
			return GetByLinkKind(linkKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkKind(int linkKind, int top_)
		{
			return GetByLinkKind(linkKind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkKind(int linkKind, int top_, TransactionManager tm_)
		{
			return GetByLinkKind(linkKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkKind(int linkKind, string sort_)
		{
			return GetByLinkKind(linkKind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkKind(int linkKind, string sort_, TransactionManager tm_)
		{
			return GetByLinkKind(linkKind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkKind(int linkKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LinkKind` = @LinkKind", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LinkKind", linkKind, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByLinkKind
		#region GetByLinkUrl
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkUrl(string linkUrl)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkUrl(string linkUrl, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkUrl(string linkUrl, int top_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkUrl(string linkUrl, int top_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkUrl(string linkUrl, string sort_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkUrl(string linkUrl, string sort_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByLinkUrl(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LinkUrl` = @LinkUrl", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByLinkUrl
		#region GetByTxt1
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt1(string txt1)
		{
			return GetByTxt1(txt1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt1(string txt1, TransactionManager tm_)
		{
			return GetByTxt1(txt1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt1(string txt1, int top_)
		{
			return GetByTxt1(txt1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt1(string txt1, int top_, TransactionManager tm_)
		{
			return GetByTxt1(txt1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt1(string txt1, string sort_)
		{
			return GetByTxt1(txt1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt1(string txt1, string sort_, TransactionManager tm_)
		{
			return GetByTxt1(txt1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt1(string txt1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Txt1` = @Txt1", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Txt1", txt1 != null ? txt1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt1
		#region GetByTxt2
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt2(string txt2)
		{
			return GetByTxt2(txt2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt2(string txt2, TransactionManager tm_)
		{
			return GetByTxt2(txt2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt2(string txt2, int top_)
		{
			return GetByTxt2(txt2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt2(string txt2, int top_, TransactionManager tm_)
		{
			return GetByTxt2(txt2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt2(string txt2, string sort_)
		{
			return GetByTxt2(txt2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt2(string txt2, string sort_, TransactionManager tm_)
		{
			return GetByTxt2(txt2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt2(string txt2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Txt2` = @Txt2", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Txt2", txt2 != null ? txt2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt2
		#region GetByTxt3
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt3(string txt3)
		{
			return GetByTxt3(txt3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt3(string txt3, TransactionManager tm_)
		{
			return GetByTxt3(txt3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt3(string txt3, int top_)
		{
			return GetByTxt3(txt3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt3(string txt3, int top_, TransactionManager tm_)
		{
			return GetByTxt3(txt3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt3(string txt3, string sort_)
		{
			return GetByTxt3(txt3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt3(string txt3, string sort_, TransactionManager tm_)
		{
			return GetByTxt3(txt3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt3(string txt3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Txt3` = @Txt3", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Txt3", txt3 != null ? txt3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt3
		#region GetByTxt4
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt4(string txt4)
		{
			return GetByTxt4(txt4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt4(string txt4, TransactionManager tm_)
		{
			return GetByTxt4(txt4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt4(string txt4, int top_)
		{
			return GetByTxt4(txt4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt4(string txt4, int top_, TransactionManager tm_)
		{
			return GetByTxt4(txt4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt4(string txt4, string sort_)
		{
			return GetByTxt4(txt4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt4(string txt4, string sort_, TransactionManager tm_)
		{
			return GetByTxt4(txt4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt4(string txt4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Txt4` = @Txt4", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Txt4", txt4 != null ? txt4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt4
		#region GetByTxt5
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt5(string txt5)
		{
			return GetByTxt5(txt5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt5(string txt5, TransactionManager tm_)
		{
			return GetByTxt5(txt5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt5(string txt5, int top_)
		{
			return GetByTxt5(txt5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt5(string txt5, int top_, TransactionManager tm_)
		{
			return GetByTxt5(txt5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt5(string txt5, string sort_)
		{
			return GetByTxt5(txt5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt5(string txt5, string sort_, TransactionManager tm_)
		{
			return GetByTxt5(txt5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByTxt5(string txt5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Txt5` = @Txt5", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Txt5", txt5 != null ? txt5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt5
		#region GetByImg1
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg1(string img1)
		{
			return GetByImg1(img1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg1(string img1, TransactionManager tm_)
		{
			return GetByImg1(img1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg1(string img1, int top_)
		{
			return GetByImg1(img1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg1(string img1, int top_, TransactionManager tm_)
		{
			return GetByImg1(img1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg1(string img1, string sort_)
		{
			return GetByImg1(img1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg1(string img1, string sort_, TransactionManager tm_)
		{
			return GetByImg1(img1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg1(string img1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Img1` = @Img1", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Img1", img1 != null ? img1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg1
		#region GetByImg2
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg2(string img2)
		{
			return GetByImg2(img2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg2(string img2, TransactionManager tm_)
		{
			return GetByImg2(img2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg2(string img2, int top_)
		{
			return GetByImg2(img2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg2(string img2, int top_, TransactionManager tm_)
		{
			return GetByImg2(img2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg2(string img2, string sort_)
		{
			return GetByImg2(img2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg2(string img2, string sort_, TransactionManager tm_)
		{
			return GetByImg2(img2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg2(string img2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Img2` = @Img2", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Img2", img2 != null ? img2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg2
		#region GetByImg3
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg3(string img3)
		{
			return GetByImg3(img3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg3(string img3, TransactionManager tm_)
		{
			return GetByImg3(img3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg3(string img3, int top_)
		{
			return GetByImg3(img3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg3(string img3, int top_, TransactionManager tm_)
		{
			return GetByImg3(img3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg3(string img3, string sort_)
		{
			return GetByImg3(img3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg3(string img3, string sort_, TransactionManager tm_)
		{
			return GetByImg3(img3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg3(string img3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Img3` = @Img3", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Img3", img3 != null ? img3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg3
		#region GetByImg4
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg4(string img4)
		{
			return GetByImg4(img4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg4(string img4, TransactionManager tm_)
		{
			return GetByImg4(img4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg4(string img4, int top_)
		{
			return GetByImg4(img4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg4(string img4, int top_, TransactionManager tm_)
		{
			return GetByImg4(img4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg4(string img4, string sort_)
		{
			return GetByImg4(img4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg4(string img4, string sort_, TransactionManager tm_)
		{
			return GetByImg4(img4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg4(string img4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Img4` = @Img4", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Img4", img4 != null ? img4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg4
		#region GetByImg5
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg5(string img5)
		{
			return GetByImg5(img5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg5(string img5, TransactionManager tm_)
		{
			return GetByImg5(img5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg5(string img5, int top_)
		{
			return GetByImg5(img5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg5(string img5, int top_, TransactionManager tm_)
		{
			return GetByImg5(img5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg5(string img5, string sort_)
		{
			return GetByImg5(img5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg5(string img5, string sort_, TransactionManager tm_)
		{
			return GetByImg5(img5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByImg5(string img5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Img5` = @Img5", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Img5", img5 != null ? img5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg5
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByActionAt
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByActionAt(int actionAt)
		{
			return GetByActionAt(actionAt, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByActionAt(int actionAt, TransactionManager tm_)
		{
			return GetByActionAt(actionAt, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByActionAt(int actionAt, int top_)
		{
			return GetByActionAt(actionAt, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByActionAt(int actionAt, int top_, TransactionManager tm_)
		{
			return GetByActionAt(actionAt, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByActionAt(int actionAt, string sort_)
		{
			return GetByActionAt(actionAt, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByActionAt(int actionAt, string sort_, TransactionManager tm_)
		{
			return GetByActionAt(actionAt, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByActionAt(int actionAt, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActionAt` = @ActionAt", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ActionAt", actionAt, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByActionAt
		#region GetByShowAt
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowAt(int showAt)
		{
			return GetByShowAt(showAt, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowAt(int showAt, TransactionManager tm_)
		{
			return GetByShowAt(showAt, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowAt(int showAt, int top_)
		{
			return GetByShowAt(showAt, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowAt(int showAt, int top_, TransactionManager tm_)
		{
			return GetByShowAt(showAt, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowAt(int showAt, string sort_)
		{
			return GetByShowAt(showAt, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowAt(int showAt, string sort_, TransactionManager tm_)
		{
			return GetByShowAt(showAt, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowAt(int showAt, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowAt` = @ShowAt", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ShowAt", showAt, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByShowAt
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByUserScope
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByUserScope(int userScope)
		{
			return GetByUserScope(userScope, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByUserScope(int userScope, TransactionManager tm_)
		{
			return GetByUserScope(userScope, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByUserScope(int userScope, int top_)
		{
			return GetByUserScope(userScope, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByUserScope(int userScope, int top_, TransactionManager tm_)
		{
			return GetByUserScope(userScope, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByUserScope(int userScope, string sort_)
		{
			return GetByUserScope(userScope, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByUserScope(int userScope, string sort_, TransactionManager tm_)
		{
			return GetByUserScope(userScope, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByUserScope(int userScope, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserScope` = @UserScope", top_, sort_);
			var parameter_ = Database.CreateInParameter("@UserScope", userScope, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByUserScope
		#region GetByNotifyUsersCount
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyUsersCount(int notifyUsersCount)
		{
			return GetByNotifyUsersCount(notifyUsersCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyUsersCount(int notifyUsersCount, TransactionManager tm_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyUsersCount(int notifyUsersCount, int top_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyUsersCount(int notifyUsersCount, int top_, TransactionManager tm_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyUsersCount(int notifyUsersCount, string sort_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyUsersCount(int notifyUsersCount, string sort_, TransactionManager tm_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyUsersCount(int notifyUsersCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyUsersCount` = @NotifyUsersCount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NotifyUsersCount", notifyUsersCount, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByNotifyUsersCount
		#region GetByNotifyedUsersCount
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyedUsersCount(int notifyedUsersCount)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyedUsersCount(int notifyedUsersCount, TransactionManager tm_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyedUsersCount(int notifyedUsersCount, int top_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyedUsersCount(int notifyedUsersCount, int top_, TransactionManager tm_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyedUsersCount(int notifyedUsersCount, string sort_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyedUsersCount(int notifyedUsersCount, string sort_, TransactionManager tm_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByNotifyedUsersCount(int notifyedUsersCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyedUsersCount` = @NotifyedUsersCount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NotifyedUsersCount", notifyedUsersCount, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByNotifyedUsersCount
		#region GetByPosition
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByPosition(int position)
		{
			return GetByPosition(position, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByPosition(int position, TransactionManager tm_)
		{
			return GetByPosition(position, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByPosition(int position, int top_)
		{
			return GetByPosition(position, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByPosition(int position, int top_, TransactionManager tm_)
		{
			return GetByPosition(position, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByPosition(int position, string sort_)
		{
			return GetByPosition(position, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByPosition(int position, string sort_, TransactionManager tm_)
		{
			return GetByPosition(position, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByPosition(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Position", position, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByPosition
		#region GetByShowTimes
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowTimes(int showTimes)
		{
			return GetByShowTimes(showTimes, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowTimes(int showTimes, TransactionManager tm_)
		{
			return GetByShowTimes(showTimes, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowTimes(int showTimes, int top_)
		{
			return GetByShowTimes(showTimes, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowTimes(int showTimes, int top_, TransactionManager tm_)
		{
			return GetByShowTimes(showTimes, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowTimes(int showTimes, string sort_)
		{
			return GetByShowTimes(showTimes, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowTimes(int showTimes, string sort_, TransactionManager tm_)
		{
			return GetByShowTimes(showTimes, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowTimes(int showTimes, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowTimes` = @ShowTimes", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ShowTimes", showTimes, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByShowTimes
		#region GetByShowInterval
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowInterval(int showInterval)
		{
			return GetByShowInterval(showInterval, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowInterval(int showInterval, TransactionManager tm_)
		{
			return GetByShowInterval(showInterval, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowInterval(int showInterval, int top_)
		{
			return GetByShowInterval(showInterval, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowInterval(int showInterval, int top_, TransactionManager tm_)
		{
			return GetByShowInterval(showInterval, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowInterval(int showInterval, string sort_)
		{
			return GetByShowInterval(showInterval, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowInterval(int showInterval, string sort_, TransactionManager tm_)
		{
			return GetByShowInterval(showInterval, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByShowInterval(int showInterval, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowInterval` = @ShowInterval", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ShowInterval", showInterval, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByShowInterval
		#region GetByCloseInterval
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByCloseInterval(int closeInterval)
		{
			return GetByCloseInterval(closeInterval, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByCloseInterval(int closeInterval, TransactionManager tm_)
		{
			return GetByCloseInterval(closeInterval, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByCloseInterval(int closeInterval, int top_)
		{
			return GetByCloseInterval(closeInterval, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByCloseInterval(int closeInterval, int top_, TransactionManager tm_)
		{
			return GetByCloseInterval(closeInterval, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByCloseInterval(int closeInterval, string sort_)
		{
			return GetByCloseInterval(closeInterval, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByCloseInterval(int closeInterval, string sort_, TransactionManager tm_)
		{
			return GetByCloseInterval(closeInterval, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByCloseInterval(int closeInterval, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CloseInterval` = @CloseInterval", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CloseInterval", closeInterval, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByCloseInterval
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByBeginDate
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByBeginDate(DateTime beginDate)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByBeginDate(DateTime beginDate, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByBeginDate(DateTime beginDate, int top_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByBeginDate(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByBeginDate(DateTime beginDate, string sort_)
		{
			return GetByBeginDate(beginDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByBeginDate(DateTime beginDate, string sort_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByBeginDate(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByBeginDate
		#region GetByEndDate
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByEndDate(DateTime endDate)
		{
			return GetByEndDate(endDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByEndDate(DateTime endDate, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByEndDate(DateTime endDate, int top_)
		{
			return GetByEndDate(endDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByEndDate(DateTime endDate, int top_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByEndDate(DateTime endDate, string sort_)
		{
			return GetByEndDate(endDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByEndDate(DateTime endDate, string sort_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_detailEO> GetByEndDate(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByEndDate
		#endregion // Get
	}
	#endregion // MO
}
