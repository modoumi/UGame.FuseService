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
	/// 【视图 v_sc_notify_user 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_sc_notify_userEO : IRowMapper<V_sc_notify_userEO>
	{
		#region 所有字段
		/// <summary>
		/// 主键GUID
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string NotifyID { get; set; }
		/// <summary>
		/// 用户编码
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 起始日期（默认2016-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 3)]
		public DateTime BeginDate { get; set; }
		/// <summary>
		/// 截止日期（默认2099-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 4)]
		public DateTime EndDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_sc_notify_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_sc_notify_userEO MapDataReader(IDataReader reader)
		{
		    V_sc_notify_userEO ret = new V_sc_notify_userEO();
			ret.NotifyID = reader.ToString("NotifyID");
			ret.UserID = reader.ToString("UserID");
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
	/// 【视图 v_sc_notify_user 的操作类】
	/// </summary>
	[Obsolete]
	public class V_sc_notify_userMO : MySqlViewMO<V_sc_notify_userEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_sc_notify_user`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_sc_notify_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_sc_notify_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_sc_notify_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByNotifyID
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByNotifyID(string notifyID)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByNotifyID(string notifyID, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByNotifyID(string notifyID, int top_)
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
		public List<V_sc_notify_userEO> GetByNotifyID(string notifyID, int top_, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByNotifyID(string notifyID, string sort_)
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
		public List<V_sc_notify_userEO> GetByNotifyID(string notifyID, string sort_, TransactionManager tm_)
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
		public List<V_sc_notify_userEO> GetByNotifyID(string notifyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyID` = @NotifyID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_userEO.MapDataReader);
		}
		#endregion // GetByNotifyID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_userEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByBeginDate
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByBeginDate(DateTime beginDate)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByBeginDate(DateTime beginDate, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByBeginDate(DateTime beginDate, int top_)
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
		public List<V_sc_notify_userEO> GetByBeginDate(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByBeginDate(DateTime beginDate, string sort_)
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
		public List<V_sc_notify_userEO> GetByBeginDate(DateTime beginDate, string sort_, TransactionManager tm_)
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
		public List<V_sc_notify_userEO> GetByBeginDate(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_userEO.MapDataReader);
		}
		#endregion // GetByBeginDate
		#region GetByEndDate
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByEndDate(DateTime endDate)
		{
			return GetByEndDate(endDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByEndDate(DateTime endDate, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByEndDate(DateTime endDate, int top_)
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
		public List<V_sc_notify_userEO> GetByEndDate(DateTime endDate, int top_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_sc_notify_userEO> GetByEndDate(DateTime endDate, string sort_)
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
		public List<V_sc_notify_userEO> GetByEndDate(DateTime endDate, string sort_, TransactionManager tm_)
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
		public List<V_sc_notify_userEO> GetByEndDate(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_sc_notify_userEO.MapDataReader);
		}
		#endregion // GetByEndDate
		#endregion // Get
	}
	#endregion // MO
}
