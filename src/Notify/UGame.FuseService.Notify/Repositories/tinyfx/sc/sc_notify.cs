/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-10-24 18: 05:07
 ******************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using MySql.Data.MySqlClient;
using System.Text;
using TinyFx.Data.MySql;

namespace UGame.FuseService.Notify.Repositories.DAL.ing
{
	#region EO
	/// <summary>
	/// 通知
	/// 【表 sc_notify 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_notifyEO : IRowMapper<Sc_notifyEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_notifyEO()
		{
			this.ActionAt = 0;
			this.ShowAt = 0;
			this.UserScope = 0;
			this.NotifyUsersCount = 1;
			this.NotifyedUsersCount = 0;
			this.Position = 0;
			this.ShowTimes = 0;
			this.ShowInterval = 0;
			this.CloseInterval = 0;
			this.OrderNum = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalNotifyID;
		/// <summary>
		/// 【数据库中的原始主键 NotifyID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalNotifyID
		{
			get { return _originalNotifyID; }
			set { HasOriginal = true; _originalNotifyID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "NotifyID", NotifyID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 主键GUID
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string NotifyID { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string AppID { get; set; }
		/// <summary>
		/// 运营商编码（null意味着全部）
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 何时显示1-登录前2-注册后第一次登录3登录后
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int ActionAt { get; set; }
		/// <summary>
		/// 显示页面FLAG值0-全部1-首页2-4-8
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int ShowAt { get; set; }
		/// <summary>
		/// 用户范围0-全部用户1-指定具体用户
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int UserScope { get; set; }
		/// <summary>
		/// 需要通知的用户人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int NotifyUsersCount { get; set; }
		/// <summary>
		/// 已通知用户人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int NotifyedUsersCount { get; set; }
		/// <summary>
		/// 显示位置1-顶部2-中部3-下部
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int Position { get; set; }
		/// <summary>
		/// 展示次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int ShowTimes { get; set; }
		/// <summary>
		/// 展示间隔（分钟）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int ShowInterval { get; set; }
		/// <summary>
		/// 自动关闭间隔（秒）0-手动关闭
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int CloseInterval { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int OrderNum { get; set; }
		/// <summary>
		/// 起始日期（默认2016-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 14)]
		public DateTime BeginDate { get; set; }
		/// <summary>
		/// 截止日期（默认2099-01-01）
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 15)]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 17)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sc_notifyEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_notifyEO MapDataReader(IDataReader reader)
		{
		    Sc_notifyEO ret = new Sc_notifyEO();
			ret.NotifyID = reader.ToString("NotifyID");
			ret.OriginalNotifyID = ret.NotifyID;
			ret.AppID = reader.ToString("AppID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.ActionAt = reader.ToInt32("ActionAt");
			ret.ShowAt = reader.ToInt32("ShowAt");
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
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 通知
	/// 【表 sc_notify 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_notifyMO : MySqlTableMO<Sc_notifyEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_notify`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_notifyMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_notifyMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_notifyMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_notifyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_notifyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_notifyEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`NotifyID`, `AppID`, `OperatorID`, `ActionAt`, `ShowAt`, `UserScope`, `NotifyUsersCount`, `NotifyedUsersCount`, `Position`, `ShowTimes`, `ShowInterval`, `CloseInterval`, `OrderNum`, `BeginDate`, `EndDate`, `Status`, `RecDate`) VALUE (@NotifyID, @AppID, @OperatorID, @ActionAt, @ShowAt, @UserScope, @NotifyUsersCount, @NotifyedUsersCount, @Position, @ShowTimes, @ShowInterval, @CloseInterval, @OrderNum, @BeginDate, @EndDate, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActionAt", item.ActionAt, MySqlDbType.Int32),
				Database.CreateInParameter("@ShowAt", item.ShowAt, MySqlDbType.Int32),
				Database.CreateInParameter("@UserScope", item.UserScope, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyUsersCount", item.NotifyUsersCount, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyedUsersCount", item.NotifyedUsersCount, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@ShowTimes", item.ShowTimes, MySqlDbType.Int32),
				Database.CreateInParameter("@ShowInterval", item.ShowInterval, MySqlDbType.Int32),
				Database.CreateInParameter("@CloseInterval", item.CloseInterval, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sc_notifyEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_notifyEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_notifyEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`NotifyID`, `AppID`, `OperatorID`, `ActionAt`, `ShowAt`, `UserScope`, `NotifyUsersCount`, `NotifyedUsersCount`, `Position`, `ShowTimes`, `ShowInterval`, `CloseInterval`, `OrderNum`, `BeginDate`, `EndDate`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.NotifyID}','{item.AppID}','{item.OperatorID}',{item.ActionAt},{item.ShowAt},{item.UserScope},{item.NotifyUsersCount},{item.NotifyedUsersCount},{item.Position},{item.ShowTimes},{item.ShowInterval},{item.CloseInterval},{item.OrderNum},'{item.BeginDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.EndDate.ToString("yyyy-MM-dd HH:mm:ss")}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
				if (count == batchCount)
				{
					count = 0;
					sql.Insert(0, insertSql);
					var ret = sql.ToString().TrimEnd(',');
					sql.Clear();
	                yield return ret;
				}
			}
			if (sql.Length > 0)
			{
	            sql.Insert(0, insertSql);
	            yield return sql.ToString().TrimEnd(',');
	        }
	    }
	    #endregion // Add
	    
		#region Remove
		#region RemoveByPK
		/// <summary>
		/// 按主键删除
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string notifyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(notifyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(notifyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string notifyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sc_notifyEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.NotifyID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_notifyEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.NotifyID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByAppID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppID(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByActionAt
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActionAt(int actionAt, TransactionManager tm_ = null)
		{
			RepairRemoveByActionAtData(actionAt, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActionAtAsync(int actionAt, TransactionManager tm_ = null)
		{
			RepairRemoveByActionAtData(actionAt, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActionAtData(int actionAt, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ActionAt` = @ActionAt";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActionAt", actionAt, MySqlDbType.Int32));
		}
		#endregion // RemoveByActionAt
		#region RemoveByShowAt
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByShowAt(int showAt, TransactionManager tm_ = null)
		{
			RepairRemoveByShowAtData(showAt, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByShowAtAsync(int showAt, TransactionManager tm_ = null)
		{
			RepairRemoveByShowAtData(showAt, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByShowAtData(int showAt, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ShowAt` = @ShowAt";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowAt", showAt, MySqlDbType.Int32));
		}
		#endregion // RemoveByShowAt
		#region RemoveByUserScope
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserScope(int userScope, TransactionManager tm_ = null)
		{
			RepairRemoveByUserScopeData(userScope, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserScopeAsync(int userScope, TransactionManager tm_ = null)
		{
			RepairRemoveByUserScopeData(userScope, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserScopeData(int userScope, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserScope` = @UserScope";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserScope", userScope, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserScope
		#region RemoveByNotifyUsersCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNotifyUsersCount(int notifyUsersCount, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyUsersCountData(notifyUsersCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNotifyUsersCountAsync(int notifyUsersCount, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyUsersCountData(notifyUsersCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNotifyUsersCountData(int notifyUsersCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NotifyUsersCount` = @NotifyUsersCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyUsersCount", notifyUsersCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByNotifyUsersCount
		#region RemoveByNotifyedUsersCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNotifyedUsersCount(int notifyedUsersCount, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyedUsersCountData(notifyedUsersCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNotifyedUsersCountAsync(int notifyedUsersCount, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyedUsersCountData(notifyedUsersCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNotifyedUsersCountData(int notifyedUsersCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NotifyedUsersCount` = @NotifyedUsersCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyedUsersCount", notifyedUsersCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByNotifyedUsersCount
		#region RemoveByPosition
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPosition(int position, TransactionManager tm_ = null)
		{
			RepairRemoveByPositionData(position, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPositionAsync(int position, TransactionManager tm_ = null)
		{
			RepairRemoveByPositionData(position, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPositionData(int position, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Position` = @Position";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
		}
		#endregion // RemoveByPosition
		#region RemoveByShowTimes
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByShowTimes(int showTimes, TransactionManager tm_ = null)
		{
			RepairRemoveByShowTimesData(showTimes, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByShowTimesAsync(int showTimes, TransactionManager tm_ = null)
		{
			RepairRemoveByShowTimesData(showTimes, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByShowTimesData(int showTimes, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ShowTimes` = @ShowTimes";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowTimes", showTimes, MySqlDbType.Int32));
		}
		#endregion // RemoveByShowTimes
		#region RemoveByShowInterval
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByShowInterval(int showInterval, TransactionManager tm_ = null)
		{
			RepairRemoveByShowIntervalData(showInterval, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByShowIntervalAsync(int showInterval, TransactionManager tm_ = null)
		{
			RepairRemoveByShowIntervalData(showInterval, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByShowIntervalData(int showInterval, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ShowInterval` = @ShowInterval";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowInterval", showInterval, MySqlDbType.Int32));
		}
		#endregion // RemoveByShowInterval
		#region RemoveByCloseInterval
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCloseInterval(int closeInterval, TransactionManager tm_ = null)
		{
			RepairRemoveByCloseIntervalData(closeInterval, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCloseIntervalAsync(int closeInterval, TransactionManager tm_ = null)
		{
			RepairRemoveByCloseIntervalData(closeInterval, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCloseIntervalData(int closeInterval, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CloseInterval` = @CloseInterval";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CloseInterval", closeInterval, MySqlDbType.Int32));
		}
		#endregion // RemoveByCloseInterval
		#region RemoveByOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderNumData(int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderNum` = @OrderNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderNum
		#region RemoveByBeginDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBeginDate(DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBeginDateData(DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BeginDate` = @BeginDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByBeginDate
		#region RemoveByEndDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEndDate(DateTime endDate, TransactionManager tm_ = null)
		{
			RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
		{
			RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEndDateData(DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EndDate` = @EndDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByEndDate
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
		}
		#endregion // RemoveByStatus
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#endregion // RemoveByFKOrUnique
		#endregion //Remove
	    
		#region Put
		#region PutItem
		/// <summary>
		/// 更新实体到数据库
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(Sc_notifyEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_notifyEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_notifyEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NotifyID` = @NotifyID, `AppID` = @AppID, `OperatorID` = @OperatorID, `ActionAt` = @ActionAt, `ShowAt` = @ShowAt, `UserScope` = @UserScope, `NotifyUsersCount` = @NotifyUsersCount, `NotifyedUsersCount` = @NotifyedUsersCount, `Position` = @Position, `ShowTimes` = @ShowTimes, `ShowInterval` = @ShowInterval, `CloseInterval` = @CloseInterval, `OrderNum` = @OrderNum, `BeginDate` = @BeginDate, `EndDate` = @EndDate, `Status` = @Status WHERE `NotifyID` = @NotifyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ActionAt", item.ActionAt, MySqlDbType.Int32),
				Database.CreateInParameter("@ShowAt", item.ShowAt, MySqlDbType.Int32),
				Database.CreateInParameter("@UserScope", item.UserScope, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyUsersCount", item.NotifyUsersCount, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyedUsersCount", item.NotifyedUsersCount, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@ShowTimes", item.ShowTimes, MySqlDbType.Int32),
				Database.CreateInParameter("@ShowInterval", item.ShowInterval, MySqlDbType.Int32),
				Database.CreateInParameter("@CloseInterval", item.CloseInterval, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID_Original", item.HasOriginal ? item.OriginalNotifyID : item.NotifyID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_notifyEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_notifyEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += await PutAsync(item, tm_);
			}
			return ret;
		}
		#endregion // PutItem
		
		#region PutByPK
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string notifyID, string set_, params object[] values_)
		{
			return Put(set_, "`NotifyID` = @NotifyID", ConcatValues(values_, notifyID));
		}
		public async Task<int> PutByPKAsync(string notifyID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`NotifyID` = @NotifyID", ConcatValues(values_, notifyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string notifyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`NotifyID` = @NotifyID", tm_, ConcatValues(values_, notifyID));
		}
		public async Task<int> PutByPKAsync(string notifyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`NotifyID` = @NotifyID", tm_, ConcatValues(values_, notifyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string notifyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`NotifyID` = @NotifyID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string notifyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`NotifyID` = @NotifyID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string notifyID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(notifyID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string notifyID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(notifyID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string notifyID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppID(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string notifyID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(notifyID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string notifyID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(notifyID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string notifyID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutActionAt
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionAtByPK(string notifyID, int actionAt, TransactionManager tm_ = null)
		{
			RepairPutActionAtByPKData(notifyID, actionAt, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActionAtByPKAsync(string notifyID, int actionAt, TransactionManager tm_ = null)
		{
			RepairPutActionAtByPKData(notifyID, actionAt, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActionAtByPKData(string notifyID, int actionAt, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActionAt` = @ActionAt  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActionAt", actionAt, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActionAt(int actionAt, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionAt` = @ActionAt";
			var parameter_ = Database.CreateInParameter("@ActionAt", actionAt, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActionAtAsync(int actionAt, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActionAt` = @ActionAt";
			var parameter_ = Database.CreateInParameter("@ActionAt", actionAt, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActionAt
		#region PutShowAt
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutShowAtByPK(string notifyID, int showAt, TransactionManager tm_ = null)
		{
			RepairPutShowAtByPKData(notifyID, showAt, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutShowAtByPKAsync(string notifyID, int showAt, TransactionManager tm_ = null)
		{
			RepairPutShowAtByPKData(notifyID, showAt, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutShowAtByPKData(string notifyID, int showAt, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ShowAt` = @ShowAt  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ShowAt", showAt, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutShowAt(int showAt, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ShowAt` = @ShowAt";
			var parameter_ = Database.CreateInParameter("@ShowAt", showAt, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutShowAtAsync(int showAt, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ShowAt` = @ShowAt";
			var parameter_ = Database.CreateInParameter("@ShowAt", showAt, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutShowAt
		#region PutUserScope
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserScopeByPK(string notifyID, int userScope, TransactionManager tm_ = null)
		{
			RepairPutUserScopeByPKData(notifyID, userScope, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserScopeByPKAsync(string notifyID, int userScope, TransactionManager tm_ = null)
		{
			RepairPutUserScopeByPKData(notifyID, userScope, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserScopeByPKData(string notifyID, int userScope, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserScope` = @UserScope  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserScope", userScope, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserScope(int userScope, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserScope` = @UserScope";
			var parameter_ = Database.CreateInParameter("@UserScope", userScope, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserScopeAsync(int userScope, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserScope` = @UserScope";
			var parameter_ = Database.CreateInParameter("@UserScope", userScope, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserScope
		#region PutNotifyUsersCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyUsersCountByPK(string notifyID, int notifyUsersCount, TransactionManager tm_ = null)
		{
			RepairPutNotifyUsersCountByPKData(notifyID, notifyUsersCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNotifyUsersCountByPKAsync(string notifyID, int notifyUsersCount, TransactionManager tm_ = null)
		{
			RepairPutNotifyUsersCountByPKData(notifyID, notifyUsersCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNotifyUsersCountByPKData(string notifyID, int notifyUsersCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NotifyUsersCount` = @NotifyUsersCount  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyUsersCount", notifyUsersCount, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyUsersCount(int notifyUsersCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyUsersCount` = @NotifyUsersCount";
			var parameter_ = Database.CreateInParameter("@NotifyUsersCount", notifyUsersCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNotifyUsersCountAsync(int notifyUsersCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyUsersCount` = @NotifyUsersCount";
			var parameter_ = Database.CreateInParameter("@NotifyUsersCount", notifyUsersCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNotifyUsersCount
		#region PutNotifyedUsersCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyedUsersCountByPK(string notifyID, int notifyedUsersCount, TransactionManager tm_ = null)
		{
			RepairPutNotifyedUsersCountByPKData(notifyID, notifyedUsersCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNotifyedUsersCountByPKAsync(string notifyID, int notifyedUsersCount, TransactionManager tm_ = null)
		{
			RepairPutNotifyedUsersCountByPKData(notifyID, notifyedUsersCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNotifyedUsersCountByPKData(string notifyID, int notifyedUsersCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NotifyedUsersCount` = @NotifyedUsersCount  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyedUsersCount", notifyedUsersCount, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyedUsersCount(int notifyedUsersCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyedUsersCount` = @NotifyedUsersCount";
			var parameter_ = Database.CreateInParameter("@NotifyedUsersCount", notifyedUsersCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNotifyedUsersCountAsync(int notifyedUsersCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyedUsersCount` = @NotifyedUsersCount";
			var parameter_ = Database.CreateInParameter("@NotifyedUsersCount", notifyedUsersCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNotifyedUsersCount
		#region PutPosition
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPositionByPK(string notifyID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(notifyID, position, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPositionByPKAsync(string notifyID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(notifyID, position, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPositionByPKData(string notifyID, int position, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Position` = @Position  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPosition(int position, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Position` = @Position";
			var parameter_ = Database.CreateInParameter("@Position", position, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPositionAsync(int position, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Position` = @Position";
			var parameter_ = Database.CreateInParameter("@Position", position, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPosition
		#region PutShowTimes
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutShowTimesByPK(string notifyID, int showTimes, TransactionManager tm_ = null)
		{
			RepairPutShowTimesByPKData(notifyID, showTimes, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutShowTimesByPKAsync(string notifyID, int showTimes, TransactionManager tm_ = null)
		{
			RepairPutShowTimesByPKData(notifyID, showTimes, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutShowTimesByPKData(string notifyID, int showTimes, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ShowTimes` = @ShowTimes  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ShowTimes", showTimes, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutShowTimes(int showTimes, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ShowTimes` = @ShowTimes";
			var parameter_ = Database.CreateInParameter("@ShowTimes", showTimes, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutShowTimesAsync(int showTimes, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ShowTimes` = @ShowTimes";
			var parameter_ = Database.CreateInParameter("@ShowTimes", showTimes, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutShowTimes
		#region PutShowInterval
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutShowIntervalByPK(string notifyID, int showInterval, TransactionManager tm_ = null)
		{
			RepairPutShowIntervalByPKData(notifyID, showInterval, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutShowIntervalByPKAsync(string notifyID, int showInterval, TransactionManager tm_ = null)
		{
			RepairPutShowIntervalByPKData(notifyID, showInterval, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutShowIntervalByPKData(string notifyID, int showInterval, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ShowInterval` = @ShowInterval  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ShowInterval", showInterval, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutShowInterval(int showInterval, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ShowInterval` = @ShowInterval";
			var parameter_ = Database.CreateInParameter("@ShowInterval", showInterval, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutShowIntervalAsync(int showInterval, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ShowInterval` = @ShowInterval";
			var parameter_ = Database.CreateInParameter("@ShowInterval", showInterval, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutShowInterval
		#region PutCloseInterval
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCloseIntervalByPK(string notifyID, int closeInterval, TransactionManager tm_ = null)
		{
			RepairPutCloseIntervalByPKData(notifyID, closeInterval, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCloseIntervalByPKAsync(string notifyID, int closeInterval, TransactionManager tm_ = null)
		{
			RepairPutCloseIntervalByPKData(notifyID, closeInterval, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCloseIntervalByPKData(string notifyID, int closeInterval, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CloseInterval` = @CloseInterval  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CloseInterval", closeInterval, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCloseInterval(int closeInterval, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CloseInterval` = @CloseInterval";
			var parameter_ = Database.CreateInParameter("@CloseInterval", closeInterval, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCloseIntervalAsync(int closeInterval, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CloseInterval` = @CloseInterval";
			var parameter_ = Database.CreateInParameter("@CloseInterval", closeInterval, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCloseInterval
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(string notifyID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(notifyID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(string notifyID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(notifyID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(string notifyID, int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNum(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderNumAsync(int orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderNum
		#region PutBeginDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBeginDateByPK(string notifyID, DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairPutBeginDateByPKData(notifyID, beginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBeginDateByPKAsync(string notifyID, DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairPutBeginDateByPKData(notifyID, beginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBeginDateByPKData(string notifyID, DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBeginDate(DateTime beginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBeginDate
		#region PutEndDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndDateByPK(string notifyID, DateTime endDate, TransactionManager tm_ = null)
		{
			RepairPutEndDateByPKData(notifyID, endDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndDateByPKAsync(string notifyID, DateTime endDate, TransactionManager tm_ = null)
		{
			RepairPutEndDateByPKData(notifyID, endDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndDateByPKData(string notifyID, DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndDate(DateTime endDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEndDate
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string notifyID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(notifyID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string notifyID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(notifyID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string notifyID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string notifyID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(notifyID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string notifyID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(notifyID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string notifyID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sc_notifyEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.NotifyID) == null)
			{
				Add(item, tm);
			}
			else
			{
				Put(item, tm);
				ret = false;
			}
			return ret;
		}
		public async Task<bool> SetAsync(Sc_notifyEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.NotifyID) == null)
			{
				await AddAsync(item, tm);
			}
			else
			{
				await PutAsync(item, tm);
				ret = false;
			}
			return ret;
		}
		
		#endregion // Set
		
		#region Get
		#region GetByPK
		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sc_notifyEO GetByPK(string notifyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(notifyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<Sc_notifyEO> GetByPKAsync(string notifyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(notifyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		private void RepairGetByPKData(string notifyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`NotifyID` = @NotifyID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActionAt（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetActionAtByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ActionAt`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetActionAtByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ActionAt`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ShowAt（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetShowAtByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ShowAt`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetShowAtByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ShowAt`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserScope（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserScopeByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserScope`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetUserScopeByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserScope`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NotifyUsersCount（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetNotifyUsersCountByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`NotifyUsersCount`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetNotifyUsersCountByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`NotifyUsersCount`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NotifyedUsersCount（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetNotifyedUsersCountByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`NotifyedUsersCount`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetNotifyedUsersCountByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`NotifyedUsersCount`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Position（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPositionByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Position`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetPositionByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Position`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ShowTimes（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetShowTimesByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ShowTimes`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetShowTimesByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ShowTimes`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ShowInterval（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetShowIntervalByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ShowInterval`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetShowIntervalByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ShowInterval`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CloseInterval（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCloseIntervalByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CloseInterval`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetCloseIntervalByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CloseInterval`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderNumByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OrderNum`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetOrderNumByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OrderNum`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BeginDate（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetBeginDateByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`BeginDate`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<DateTime> GetBeginDateByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`BeginDate`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndDate（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetEndDateByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`EndDate`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<DateTime> GetEndDateByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`EndDate`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string notifyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`NotifyID` = @NotifyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByAppIDAsync(string appID, int top_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByAppIDAsync(string appID, string sort_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByActionAt
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByActionAt(int actionAt)
		{
			return GetByActionAt(actionAt, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByActionAtAsync(int actionAt)
		{
			return await GetByActionAtAsync(actionAt, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByActionAt(int actionAt, TransactionManager tm_)
		{
			return GetByActionAt(actionAt, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByActionAtAsync(int actionAt, TransactionManager tm_)
		{
			return await GetByActionAtAsync(actionAt, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByActionAt(int actionAt, int top_)
		{
			return GetByActionAt(actionAt, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByActionAtAsync(int actionAt, int top_)
		{
			return await GetByActionAtAsync(actionAt, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByActionAt(int actionAt, int top_, TransactionManager tm_)
		{
			return GetByActionAt(actionAt, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByActionAtAsync(int actionAt, int top_, TransactionManager tm_)
		{
			return await GetByActionAtAsync(actionAt, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByActionAt(int actionAt, string sort_)
		{
			return GetByActionAt(actionAt, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByActionAtAsync(int actionAt, string sort_)
		{
			return await GetByActionAtAsync(actionAt, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByActionAt(int actionAt, string sort_, TransactionManager tm_)
		{
			return GetByActionAt(actionAt, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByActionAtAsync(int actionAt, string sort_, TransactionManager tm_)
		{
			return await GetByActionAtAsync(actionAt, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActionAt（字段） 查询
		/// </summary>
		/// /// <param name = "actionAt">何时显示1-登录前2-注册后第一次登录3登录后</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByActionAt(int actionAt, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActionAt` = @ActionAt", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActionAt", actionAt, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByActionAtAsync(int actionAt, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ActionAt` = @ActionAt", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ActionAt", actionAt, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByActionAt
		#region GetByShowAt
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowAt(int showAt)
		{
			return GetByShowAt(showAt, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByShowAtAsync(int showAt)
		{
			return await GetByShowAtAsync(showAt, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowAt(int showAt, TransactionManager tm_)
		{
			return GetByShowAt(showAt, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByShowAtAsync(int showAt, TransactionManager tm_)
		{
			return await GetByShowAtAsync(showAt, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowAt(int showAt, int top_)
		{
			return GetByShowAt(showAt, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByShowAtAsync(int showAt, int top_)
		{
			return await GetByShowAtAsync(showAt, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowAt(int showAt, int top_, TransactionManager tm_)
		{
			return GetByShowAt(showAt, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByShowAtAsync(int showAt, int top_, TransactionManager tm_)
		{
			return await GetByShowAtAsync(showAt, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowAt(int showAt, string sort_)
		{
			return GetByShowAt(showAt, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByShowAtAsync(int showAt, string sort_)
		{
			return await GetByShowAtAsync(showAt, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowAt(int showAt, string sort_, TransactionManager tm_)
		{
			return GetByShowAt(showAt, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByShowAtAsync(int showAt, string sort_, TransactionManager tm_)
		{
			return await GetByShowAtAsync(showAt, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ShowAt（字段） 查询
		/// </summary>
		/// /// <param name = "showAt">显示页面FLAG值0-全部1-首页2-4-8</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowAt(int showAt, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowAt` = @ShowAt", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowAt", showAt, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByShowAtAsync(int showAt, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowAt` = @ShowAt", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowAt", showAt, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByShowAt
		#region GetByUserScope
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByUserScope(int userScope)
		{
			return GetByUserScope(userScope, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByUserScopeAsync(int userScope)
		{
			return await GetByUserScopeAsync(userScope, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByUserScope(int userScope, TransactionManager tm_)
		{
			return GetByUserScope(userScope, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByUserScopeAsync(int userScope, TransactionManager tm_)
		{
			return await GetByUserScopeAsync(userScope, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByUserScope(int userScope, int top_)
		{
			return GetByUserScope(userScope, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByUserScopeAsync(int userScope, int top_)
		{
			return await GetByUserScopeAsync(userScope, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByUserScope(int userScope, int top_, TransactionManager tm_)
		{
			return GetByUserScope(userScope, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByUserScopeAsync(int userScope, int top_, TransactionManager tm_)
		{
			return await GetByUserScopeAsync(userScope, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByUserScope(int userScope, string sort_)
		{
			return GetByUserScope(userScope, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByUserScopeAsync(int userScope, string sort_)
		{
			return await GetByUserScopeAsync(userScope, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByUserScope(int userScope, string sort_, TransactionManager tm_)
		{
			return GetByUserScope(userScope, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByUserScopeAsync(int userScope, string sort_, TransactionManager tm_)
		{
			return await GetByUserScopeAsync(userScope, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserScope（字段） 查询
		/// </summary>
		/// /// <param name = "userScope">用户范围0-全部用户1-指定具体用户</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByUserScope(int userScope, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserScope` = @UserScope", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserScope", userScope, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByUserScopeAsync(int userScope, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserScope` = @UserScope", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserScope", userScope, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByUserScope
		#region GetByNotifyUsersCount
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyUsersCount(int notifyUsersCount)
		{
			return GetByNotifyUsersCount(notifyUsersCount, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyUsersCountAsync(int notifyUsersCount)
		{
			return await GetByNotifyUsersCountAsync(notifyUsersCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyUsersCount(int notifyUsersCount, TransactionManager tm_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyUsersCountAsync(int notifyUsersCount, TransactionManager tm_)
		{
			return await GetByNotifyUsersCountAsync(notifyUsersCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyUsersCount(int notifyUsersCount, int top_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyUsersCountAsync(int notifyUsersCount, int top_)
		{
			return await GetByNotifyUsersCountAsync(notifyUsersCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyUsersCount(int notifyUsersCount, int top_, TransactionManager tm_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyUsersCountAsync(int notifyUsersCount, int top_, TransactionManager tm_)
		{
			return await GetByNotifyUsersCountAsync(notifyUsersCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyUsersCount(int notifyUsersCount, string sort_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyUsersCountAsync(int notifyUsersCount, string sort_)
		{
			return await GetByNotifyUsersCountAsync(notifyUsersCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyUsersCount(int notifyUsersCount, string sort_, TransactionManager tm_)
		{
			return GetByNotifyUsersCount(notifyUsersCount, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyUsersCountAsync(int notifyUsersCount, string sort_, TransactionManager tm_)
		{
			return await GetByNotifyUsersCountAsync(notifyUsersCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NotifyUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyUsersCount">需要通知的用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyUsersCount(int notifyUsersCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyUsersCount` = @NotifyUsersCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyUsersCount", notifyUsersCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyUsersCountAsync(int notifyUsersCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyUsersCount` = @NotifyUsersCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyUsersCount", notifyUsersCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByNotifyUsersCount
		#region GetByNotifyedUsersCount
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyedUsersCount(int notifyedUsersCount)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyedUsersCountAsync(int notifyedUsersCount)
		{
			return await GetByNotifyedUsersCountAsync(notifyedUsersCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyedUsersCount(int notifyedUsersCount, TransactionManager tm_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyedUsersCountAsync(int notifyedUsersCount, TransactionManager tm_)
		{
			return await GetByNotifyedUsersCountAsync(notifyedUsersCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyedUsersCount(int notifyedUsersCount, int top_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyedUsersCountAsync(int notifyedUsersCount, int top_)
		{
			return await GetByNotifyedUsersCountAsync(notifyedUsersCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyedUsersCount(int notifyedUsersCount, int top_, TransactionManager tm_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyedUsersCountAsync(int notifyedUsersCount, int top_, TransactionManager tm_)
		{
			return await GetByNotifyedUsersCountAsync(notifyedUsersCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyedUsersCount(int notifyedUsersCount, string sort_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyedUsersCountAsync(int notifyedUsersCount, string sort_)
		{
			return await GetByNotifyedUsersCountAsync(notifyedUsersCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyedUsersCount(int notifyedUsersCount, string sort_, TransactionManager tm_)
		{
			return GetByNotifyedUsersCount(notifyedUsersCount, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyedUsersCountAsync(int notifyedUsersCount, string sort_, TransactionManager tm_)
		{
			return await GetByNotifyedUsersCountAsync(notifyedUsersCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NotifyedUsersCount（字段） 查询
		/// </summary>
		/// /// <param name = "notifyedUsersCount">已通知用户人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByNotifyedUsersCount(int notifyedUsersCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyedUsersCount` = @NotifyedUsersCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyedUsersCount", notifyedUsersCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByNotifyedUsersCountAsync(int notifyedUsersCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyedUsersCount` = @NotifyedUsersCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyedUsersCount", notifyedUsersCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByNotifyedUsersCount
		#region GetByPosition
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByPosition(int position)
		{
			return GetByPosition(position, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByPositionAsync(int position)
		{
			return await GetByPositionAsync(position, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByPosition(int position, TransactionManager tm_)
		{
			return GetByPosition(position, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByPositionAsync(int position, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByPosition(int position, int top_)
		{
			return GetByPosition(position, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByPositionAsync(int position, int top_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByPosition(int position, int top_, TransactionManager tm_)
		{
			return GetByPosition(position, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByPositionAsync(int position, int top_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByPosition(int position, string sort_)
		{
			return GetByPosition(position, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByPositionAsync(int position, string sort_)
		{
			return await GetByPositionAsync(position, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByPosition(int position, string sort_, TransactionManager tm_)
		{
			return GetByPosition(position, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByPositionAsync(int position, string sort_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">显示位置1-顶部2-中部3-下部</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByPosition(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByPositionAsync(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByPosition
		#region GetByShowTimes
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowTimes(int showTimes)
		{
			return GetByShowTimes(showTimes, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByShowTimesAsync(int showTimes)
		{
			return await GetByShowTimesAsync(showTimes, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowTimes(int showTimes, TransactionManager tm_)
		{
			return GetByShowTimes(showTimes, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByShowTimesAsync(int showTimes, TransactionManager tm_)
		{
			return await GetByShowTimesAsync(showTimes, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowTimes(int showTimes, int top_)
		{
			return GetByShowTimes(showTimes, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByShowTimesAsync(int showTimes, int top_)
		{
			return await GetByShowTimesAsync(showTimes, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowTimes(int showTimes, int top_, TransactionManager tm_)
		{
			return GetByShowTimes(showTimes, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByShowTimesAsync(int showTimes, int top_, TransactionManager tm_)
		{
			return await GetByShowTimesAsync(showTimes, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowTimes(int showTimes, string sort_)
		{
			return GetByShowTimes(showTimes, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByShowTimesAsync(int showTimes, string sort_)
		{
			return await GetByShowTimesAsync(showTimes, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowTimes(int showTimes, string sort_, TransactionManager tm_)
		{
			return GetByShowTimes(showTimes, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByShowTimesAsync(int showTimes, string sort_, TransactionManager tm_)
		{
			return await GetByShowTimesAsync(showTimes, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ShowTimes（字段） 查询
		/// </summary>
		/// /// <param name = "showTimes">展示次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowTimes(int showTimes, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowTimes` = @ShowTimes", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowTimes", showTimes, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByShowTimesAsync(int showTimes, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowTimes` = @ShowTimes", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowTimes", showTimes, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByShowTimes
		#region GetByShowInterval
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowInterval(int showInterval)
		{
			return GetByShowInterval(showInterval, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByShowIntervalAsync(int showInterval)
		{
			return await GetByShowIntervalAsync(showInterval, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowInterval(int showInterval, TransactionManager tm_)
		{
			return GetByShowInterval(showInterval, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByShowIntervalAsync(int showInterval, TransactionManager tm_)
		{
			return await GetByShowIntervalAsync(showInterval, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowInterval(int showInterval, int top_)
		{
			return GetByShowInterval(showInterval, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByShowIntervalAsync(int showInterval, int top_)
		{
			return await GetByShowIntervalAsync(showInterval, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowInterval(int showInterval, int top_, TransactionManager tm_)
		{
			return GetByShowInterval(showInterval, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByShowIntervalAsync(int showInterval, int top_, TransactionManager tm_)
		{
			return await GetByShowIntervalAsync(showInterval, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowInterval(int showInterval, string sort_)
		{
			return GetByShowInterval(showInterval, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByShowIntervalAsync(int showInterval, string sort_)
		{
			return await GetByShowIntervalAsync(showInterval, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowInterval(int showInterval, string sort_, TransactionManager tm_)
		{
			return GetByShowInterval(showInterval, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByShowIntervalAsync(int showInterval, string sort_, TransactionManager tm_)
		{
			return await GetByShowIntervalAsync(showInterval, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ShowInterval（字段） 查询
		/// </summary>
		/// /// <param name = "showInterval">展示间隔（分钟）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByShowInterval(int showInterval, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowInterval` = @ShowInterval", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowInterval", showInterval, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByShowIntervalAsync(int showInterval, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowInterval` = @ShowInterval", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowInterval", showInterval, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByShowInterval
		#region GetByCloseInterval
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByCloseInterval(int closeInterval)
		{
			return GetByCloseInterval(closeInterval, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByCloseIntervalAsync(int closeInterval)
		{
			return await GetByCloseIntervalAsync(closeInterval, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByCloseInterval(int closeInterval, TransactionManager tm_)
		{
			return GetByCloseInterval(closeInterval, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByCloseIntervalAsync(int closeInterval, TransactionManager tm_)
		{
			return await GetByCloseIntervalAsync(closeInterval, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByCloseInterval(int closeInterval, int top_)
		{
			return GetByCloseInterval(closeInterval, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByCloseIntervalAsync(int closeInterval, int top_)
		{
			return await GetByCloseIntervalAsync(closeInterval, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByCloseInterval(int closeInterval, int top_, TransactionManager tm_)
		{
			return GetByCloseInterval(closeInterval, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByCloseIntervalAsync(int closeInterval, int top_, TransactionManager tm_)
		{
			return await GetByCloseIntervalAsync(closeInterval, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByCloseInterval(int closeInterval, string sort_)
		{
			return GetByCloseInterval(closeInterval, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByCloseIntervalAsync(int closeInterval, string sort_)
		{
			return await GetByCloseIntervalAsync(closeInterval, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByCloseInterval(int closeInterval, string sort_, TransactionManager tm_)
		{
			return GetByCloseInterval(closeInterval, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByCloseIntervalAsync(int closeInterval, string sort_, TransactionManager tm_)
		{
			return await GetByCloseIntervalAsync(closeInterval, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CloseInterval（字段） 查询
		/// </summary>
		/// /// <param name = "closeInterval">自动关闭间隔（秒）0-手动关闭</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByCloseInterval(int closeInterval, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CloseInterval` = @CloseInterval", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CloseInterval", closeInterval, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByCloseIntervalAsync(int closeInterval, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CloseInterval` = @CloseInterval", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CloseInterval", closeInterval, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByCloseInterval
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByOrderNumAsync(int orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByOrderNumAsync(int orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByOrderNumAsync(int orderNum, int top_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByOrderNumAsync(int orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByOrderNumAsync(int orderNum, string sort_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByOrderNumAsync(int orderNum, string sort_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByOrderNumAsync(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByBeginDate
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByBeginDate(DateTime beginDate)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByBeginDateAsync(DateTime beginDate)
		{
			return await GetByBeginDateAsync(beginDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByBeginDate(DateTime beginDate, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByBeginDateAsync(DateTime beginDate, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByBeginDate(DateTime beginDate, int top_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByBeginDateAsync(DateTime beginDate, int top_)
		{
			return await GetByBeginDateAsync(beginDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByBeginDate(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByBeginDateAsync(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByBeginDate(DateTime beginDate, string sort_)
		{
			return GetByBeginDate(beginDate, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByBeginDateAsync(DateTime beginDate, string sort_)
		{
			return await GetByBeginDateAsync(beginDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByBeginDate(DateTime beginDate, string sort_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByBeginDateAsync(DateTime beginDate, string sort_, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">起始日期（默认2016-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByBeginDate(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByBeginDateAsync(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByBeginDate
		#region GetByEndDate
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByEndDate(DateTime endDate)
		{
			return GetByEndDate(endDate, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByEndDateAsync(DateTime endDate)
		{
			return await GetByEndDateAsync(endDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByEndDate(DateTime endDate, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByEndDateAsync(DateTime endDate, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByEndDate(DateTime endDate, int top_)
		{
			return GetByEndDate(endDate, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByEndDateAsync(DateTime endDate, int top_)
		{
			return await GetByEndDateAsync(endDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByEndDate(DateTime endDate, int top_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByEndDateAsync(DateTime endDate, int top_, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByEndDate(DateTime endDate, string sort_)
		{
			return GetByEndDate(endDate, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByEndDateAsync(DateTime endDate, string sort_)
		{
			return await GetByEndDateAsync(endDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByEndDate(DateTime endDate, string sort_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByEndDateAsync(DateTime endDate, string sort_, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">截止日期（默认2099-01-01）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByEndDate(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByEndDateAsync(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByEndDate
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sc_notifyEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sc_notifyEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sc_notifyEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notifyEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		public async Task<List<Sc_notifyEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notifyEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
