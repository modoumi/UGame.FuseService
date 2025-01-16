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
	/// 通知用户日志
	/// 【表 sc_notify_user_log 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_notify_user_logEO : IRowMapper<Sc_notify_user_logEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_notify_user_logEO()
		{
			this.ShowCount = 0;
			this.LastShowDate = DateTime.Now;
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
		
		private string _originalUserID;
		/// <summary>
		/// 【数据库中的原始主键 UserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalUserID
		{
			get { return _originalUserID; }
			set { HasOriginal = true; _originalUserID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "NotifyID", NotifyID },  { "UserID", UserID }, };
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
		/// 用户编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 显示次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int ShowCount { get; set; }
		/// <summary>
		/// 最后一次展示时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 4)]
		public DateTime LastShowDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sc_notify_user_logEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_notify_user_logEO MapDataReader(IDataReader reader)
		{
		    Sc_notify_user_logEO ret = new Sc_notify_user_logEO();
			ret.NotifyID = reader.ToString("NotifyID");
			ret.OriginalNotifyID = ret.NotifyID;
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.ShowCount = reader.ToInt32("ShowCount");
			ret.LastShowDate = reader.ToDateTime("LastShowDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 通知用户日志
	/// 【表 sc_notify_user_log 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_notify_user_logMO : MySqlTableMO<Sc_notify_user_logEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_notify_user_log`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_notify_user_logMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_notify_user_logMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_notify_user_logMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_notify_user_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_notify_user_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_notify_user_logEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`NotifyID`, `UserID`, `ShowCount`, `LastShowDate`) VALUE (@NotifyID, @UserID, @ShowCount, @LastShowDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ShowCount", item.ShowCount, MySqlDbType.Int32),
				Database.CreateInParameter("@LastShowDate", item.LastShowDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sc_notify_user_logEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_notify_user_logEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_notify_user_logEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`NotifyID`, `UserID`, `ShowCount`, `LastShowDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.NotifyID}','{item.UserID}',{item.ShowCount},'{item.LastShowDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string notifyID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(notifyID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string notifyID, string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(notifyID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string notifyID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NotifyID` = @NotifyID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sc_notify_user_logEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.NotifyID, item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_notify_user_logEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.NotifyID, item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByNotifyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNotifyID(string notifyID, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyIDData(notifyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNotifyIDAsync(string notifyID, TransactionManager tm_ = null)
		{
			RepairRemoveByNotifyIDData(notifyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNotifyIDData(string notifyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NotifyID` = @NotifyID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByNotifyID
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserID(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByShowCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "showCount">显示次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByShowCount(int showCount, TransactionManager tm_ = null)
		{
			RepairRemoveByShowCountData(showCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByShowCountAsync(int showCount, TransactionManager tm_ = null)
		{
			RepairRemoveByShowCountData(showCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByShowCountData(int showCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ShowCount` = @ShowCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowCount", showCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByShowCount
		#region RemoveByLastShowDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastShowDate(DateTime lastShowDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastShowDateData(lastShowDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastShowDateAsync(DateTime lastShowDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastShowDateData(lastShowDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastShowDateData(DateTime lastShowDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LastShowDate` = @LastShowDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastShowDate", lastShowDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLastShowDate
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
		public int Put(Sc_notify_user_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_notify_user_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_notify_user_logEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NotifyID` = @NotifyID, `UserID` = @UserID, `ShowCount` = @ShowCount WHERE `NotifyID` = @NotifyID_Original AND `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ShowCount", item.ShowCount, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID_Original", item.HasOriginal ? item.OriginalNotifyID : item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_notify_user_logEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_notify_user_logEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string notifyID, string userID, string set_, params object[] values_)
		{
			return Put(set_, "`NotifyID` = @NotifyID AND `UserID` = @UserID", ConcatValues(values_, notifyID, userID));
		}
		public async Task<int> PutByPKAsync(string notifyID, string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`NotifyID` = @NotifyID AND `UserID` = @UserID", ConcatValues(values_, notifyID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string notifyID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`NotifyID` = @NotifyID AND `UserID` = @UserID", tm_, ConcatValues(values_, notifyID, userID));
		}
		public async Task<int> PutByPKAsync(string notifyID, string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`NotifyID` = @NotifyID AND `UserID` = @UserID", tm_, ConcatValues(values_, notifyID, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string notifyID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`NotifyID` = @NotifyID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string notifyID, string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`NotifyID` = @NotifyID AND `UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutNotifyID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNotifyID(string notifyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyID` = @NotifyID";
			var parameter_ = Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNotifyIDAsync(string notifyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NotifyID` = @NotifyID";
			var parameter_ = Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNotifyID
		#region PutUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutShowCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "showCount">显示次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutShowCountByPK(string notifyID, string userID, int showCount, TransactionManager tm_ = null)
		{
			RepairPutShowCountByPKData(notifyID, userID, showCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutShowCountByPKAsync(string notifyID, string userID, int showCount, TransactionManager tm_ = null)
		{
			RepairPutShowCountByPKData(notifyID, userID, showCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutShowCountByPKData(string notifyID, string userID, int showCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ShowCount` = @ShowCount  WHERE `NotifyID` = @NotifyID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ShowCount", showCount, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "showCount">显示次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutShowCount(int showCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ShowCount` = @ShowCount";
			var parameter_ = Database.CreateInParameter("@ShowCount", showCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutShowCountAsync(int showCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ShowCount` = @ShowCount";
			var parameter_ = Database.CreateInParameter("@ShowCount", showCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutShowCount
		#region PutLastShowDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastShowDateByPK(string notifyID, string userID, DateTime lastShowDate, TransactionManager tm_ = null)
		{
			RepairPutLastShowDateByPKData(notifyID, userID, lastShowDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastShowDateByPKAsync(string notifyID, string userID, DateTime lastShowDate, TransactionManager tm_ = null)
		{
			RepairPutLastShowDateByPKData(notifyID, userID, lastShowDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastShowDateByPKData(string notifyID, string userID, DateTime lastShowDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastShowDate` = @LastShowDate  WHERE `NotifyID` = @NotifyID AND `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastShowDate", lastShowDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastShowDate(DateTime lastShowDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastShowDate` = @LastShowDate";
			var parameter_ = Database.CreateInParameter("@LastShowDate", lastShowDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastShowDateAsync(DateTime lastShowDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastShowDate` = @LastShowDate";
			var parameter_ = Database.CreateInParameter("@LastShowDate", lastShowDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastShowDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sc_notify_user_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.NotifyID, item.UserID) == null)
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
		public async Task<bool> SetAsync(Sc_notify_user_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.NotifyID, item.UserID) == null)
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sc_notify_user_logEO GetByPK(string notifyID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(notifyID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		public async Task<Sc_notify_user_logEO> GetByPKAsync(string notifyID, string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(notifyID, userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		private void RepairGetByPKData(string notifyID, string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`NotifyID` = @NotifyID AND `UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 NotifyID（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNotifyIDByPK(string notifyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`NotifyID`", "`NotifyID` = @NotifyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetNotifyIDByPKAsync(string notifyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`NotifyID`", "`NotifyID` = @NotifyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string notifyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`NotifyID` = @NotifyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string notifyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`NotifyID` = @NotifyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ShowCount（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetShowCountByPK(string notifyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ShowCount`", "`NotifyID` = @NotifyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetShowCountByPKAsync(string notifyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ShowCount`", "`NotifyID` = @NotifyID AND `UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastShowDate（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetLastShowDateByPK(string notifyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`LastShowDate`", "`NotifyID` = @NotifyID AND `UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetLastShowDateByPKAsync(string notifyID, string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`LastShowDate`", "`NotifyID` = @NotifyID AND `UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByNotifyID
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByNotifyID(string notifyID)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByNotifyIDAsync(string notifyID)
		{
			return await GetByNotifyIDAsync(notifyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByNotifyID(string notifyID, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByNotifyIDAsync(string notifyID, TransactionManager tm_)
		{
			return await GetByNotifyIDAsync(notifyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByNotifyID(string notifyID, int top_)
		{
			return GetByNotifyID(notifyID, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByNotifyIDAsync(string notifyID, int top_)
		{
			return await GetByNotifyIDAsync(notifyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByNotifyID(string notifyID, int top_, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByNotifyIDAsync(string notifyID, int top_, TransactionManager tm_)
		{
			return await GetByNotifyIDAsync(notifyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByNotifyID(string notifyID, string sort_)
		{
			return GetByNotifyID(notifyID, 0, sort_, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByNotifyIDAsync(string notifyID, string sort_)
		{
			return await GetByNotifyIDAsync(notifyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByNotifyID(string notifyID, string sort_, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByNotifyIDAsync(string notifyID, string sort_, TransactionManager tm_)
		{
			return await GetByNotifyIDAsync(notifyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByNotifyID(string notifyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyID` = @NotifyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByNotifyIDAsync(string notifyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyID` = @NotifyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		#endregion // GetByNotifyID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByShowCount
		
		/// <summary>
		/// 按 ShowCount（字段） 查询
		/// </summary>
		/// /// <param name = "showCount">显示次数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByShowCount(int showCount)
		{
			return GetByShowCount(showCount, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByShowCountAsync(int showCount)
		{
			return await GetByShowCountAsync(showCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowCount（字段） 查询
		/// </summary>
		/// /// <param name = "showCount">显示次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByShowCount(int showCount, TransactionManager tm_)
		{
			return GetByShowCount(showCount, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByShowCountAsync(int showCount, TransactionManager tm_)
		{
			return await GetByShowCountAsync(showCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowCount（字段） 查询
		/// </summary>
		/// /// <param name = "showCount">显示次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByShowCount(int showCount, int top_)
		{
			return GetByShowCount(showCount, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByShowCountAsync(int showCount, int top_)
		{
			return await GetByShowCountAsync(showCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ShowCount（字段） 查询
		/// </summary>
		/// /// <param name = "showCount">显示次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByShowCount(int showCount, int top_, TransactionManager tm_)
		{
			return GetByShowCount(showCount, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByShowCountAsync(int showCount, int top_, TransactionManager tm_)
		{
			return await GetByShowCountAsync(showCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ShowCount（字段） 查询
		/// </summary>
		/// /// <param name = "showCount">显示次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByShowCount(int showCount, string sort_)
		{
			return GetByShowCount(showCount, 0, sort_, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByShowCountAsync(int showCount, string sort_)
		{
			return await GetByShowCountAsync(showCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ShowCount（字段） 查询
		/// </summary>
		/// /// <param name = "showCount">显示次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByShowCount(int showCount, string sort_, TransactionManager tm_)
		{
			return GetByShowCount(showCount, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByShowCountAsync(int showCount, string sort_, TransactionManager tm_)
		{
			return await GetByShowCountAsync(showCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ShowCount（字段） 查询
		/// </summary>
		/// /// <param name = "showCount">显示次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByShowCount(int showCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowCount` = @ShowCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowCount", showCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByShowCountAsync(int showCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ShowCount` = @ShowCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ShowCount", showCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		#endregion // GetByShowCount
		#region GetByLastShowDate
		
		/// <summary>
		/// 按 LastShowDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByLastShowDate(DateTime lastShowDate)
		{
			return GetByLastShowDate(lastShowDate, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByLastShowDateAsync(DateTime lastShowDate)
		{
			return await GetByLastShowDateAsync(lastShowDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastShowDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByLastShowDate(DateTime lastShowDate, TransactionManager tm_)
		{
			return GetByLastShowDate(lastShowDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByLastShowDateAsync(DateTime lastShowDate, TransactionManager tm_)
		{
			return await GetByLastShowDateAsync(lastShowDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastShowDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByLastShowDate(DateTime lastShowDate, int top_)
		{
			return GetByLastShowDate(lastShowDate, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByLastShowDateAsync(DateTime lastShowDate, int top_)
		{
			return await GetByLastShowDateAsync(lastShowDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastShowDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByLastShowDate(DateTime lastShowDate, int top_, TransactionManager tm_)
		{
			return GetByLastShowDate(lastShowDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByLastShowDateAsync(DateTime lastShowDate, int top_, TransactionManager tm_)
		{
			return await GetByLastShowDateAsync(lastShowDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastShowDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByLastShowDate(DateTime lastShowDate, string sort_)
		{
			return GetByLastShowDate(lastShowDate, 0, sort_, null);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByLastShowDateAsync(DateTime lastShowDate, string sort_)
		{
			return await GetByLastShowDateAsync(lastShowDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastShowDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByLastShowDate(DateTime lastShowDate, string sort_, TransactionManager tm_)
		{
			return GetByLastShowDate(lastShowDate, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByLastShowDateAsync(DateTime lastShowDate, string sort_, TransactionManager tm_)
		{
			return await GetByLastShowDateAsync(lastShowDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastShowDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastShowDate">最后一次展示时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_user_logEO> GetByLastShowDate(DateTime lastShowDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastShowDate` = @LastShowDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastShowDate", lastShowDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		public async Task<List<Sc_notify_user_logEO>> GetByLastShowDateAsync(DateTime lastShowDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastShowDate` = @LastShowDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastShowDate", lastShowDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_user_logEO.MapDataReader);
		}
		#endregion // GetByLastShowDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
