/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-11-06 14: 39:08
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

namespace SComms.Notify.DAL.ing
{
	#region EO
	/// <summary>
	/// 用户邮件奖励表，描述发给指定用户的奖励邮件相关的数据
	/// 【表 sem_message_reward 的实体类】
	/// </summary>
	[DataContract]
	public class Sem_message_rewardEO : IRowMapper<Sem_message_rewardEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sem_message_rewardEO()
		{
			this.Status = 0;
			this.RecDate = DateTime.Now;
			this.UpdateTime = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalMessageID;
		/// <summary>
		/// 【数据库中的原始主键 MessageID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalMessageID
		{
			get { return _originalMessageID; }
			set { HasOriginal = true; _originalMessageID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "MessageID", MessageID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 消息ID
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string MessageID { get; set; }
		/// <summary>
		/// 接收人ID
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string ReceiverID { get; set; }
		/// <summary>
		/// 金额类型 1-Bonus 2-真金
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int AmountType { get; set; }
		/// <summary>
		/// 奖励金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long? RewardAmount { get; set; }
		/// <summary>
		/// 赠金提现所需要的流水倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int? FlowMultip { get; set; }
		/// <summary>
		/// 数据来源类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int? SourceType { get; set; }
		/// <summary>
		/// 数据来源表名
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 7)]
		public string SourceTable { get; set; }
		/// <summary>
		/// 数据ID
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 8)]
		public string SourceId { get; set; }
		/// <summary>
		/// 状态 0-未领取 1-已领取
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int? Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime? RecDate { get; set; }
		/// <summary>
		/// 更新时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 11)]
		public DateTime UpdateTime { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sem_message_rewardEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sem_message_rewardEO MapDataReader(IDataReader reader)
		{
		    Sem_message_rewardEO ret = new Sem_message_rewardEO();
			ret.MessageID = reader.ToString("MessageID");
			ret.OriginalMessageID = ret.MessageID;
			ret.ReceiverID = reader.ToString("ReceiverID");
			ret.AmountType = reader.ToInt32("AmountType");
			ret.RewardAmount = reader.ToInt64N("RewardAmount");
			ret.FlowMultip = reader.ToInt32N("FlowMultip");
			ret.SourceType = reader.ToInt32N("SourceType");
			ret.SourceTable = reader.ToString("SourceTable");
			ret.SourceId = reader.ToString("SourceId");
			ret.Status = reader.ToInt32N("Status");
			ret.RecDate = reader.ToDateTimeN("RecDate");
			ret.UpdateTime = reader.ToDateTime("UpdateTime");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户邮件奖励表，描述发给指定用户的奖励邮件相关的数据
	/// 【表 sem_message_reward 的操作类】
	/// </summary>
	public class Sem_message_rewardMO : MySqlTableMO<Sem_message_rewardEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sem_message_reward`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sem_message_rewardMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sem_message_rewardMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sem_message_rewardMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sem_message_rewardEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sem_message_rewardEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sem_message_rewardEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`MessageID`, `ReceiverID`, `AmountType`, `RewardAmount`, `FlowMultip`, `SourceType`, `SourceTable`, `SourceId`, `Status`, `RecDate`, `UpdateTime`) VALUE (@MessageID, @ReceiverID, @AmountType, @RewardAmount, @FlowMultip, @SourceType, @SourceTable, @SourceId, @Status, @RecDate, @UpdateTime);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ReceiverID", item.ReceiverID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AmountType", item.AmountType, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardAmount", item.RewardAmount.HasValue ? item.RewardAmount.Value : (object)DBNull.Value, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip.HasValue ? item.FlowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@SourceType", item.SourceType.HasValue ? item.SourceType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@SourceTable", item.SourceTable != null ? item.SourceTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceId", item.SourceId != null ? item.SourceId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status.HasValue ? item.Status.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UpdateTime", item.UpdateTime, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sem_message_rewardEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sem_message_rewardEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sem_message_rewardEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`MessageID`, `ReceiverID`, `AmountType`, `RewardAmount`, `FlowMultip`, `SourceType`, `SourceTable`, `SourceId`, `Status`, `RecDate`, `UpdateTime`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.MessageID}','{item.ReceiverID}',{item.AmountType},{item.RewardAmount?.ToString()??null},{item.FlowMultip?.ToString()??null},{item.SourceType?.ToString()??null},'{item.SourceTable}','{item.SourceId}',{item.Status?.ToString()??null},'{item.RecDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string messageID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(messageID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string messageID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sem_message_rewardEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.MessageID, tm_);
		}
		public async Task<int> RemoveAsync(Sem_message_rewardEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.MessageID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByReceiverID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReceiverID(string receiverID, TransactionManager tm_ = null)
		{
			RepairRemoveByReceiverIDData(receiverID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByReceiverIDAsync(string receiverID, TransactionManager tm_ = null)
		{
			RepairRemoveByReceiverIDData(receiverID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByReceiverIDData(string receiverID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ReceiverID` = @ReceiverID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiverID", receiverID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByReceiverID
		#region RemoveByAmountType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmountType(int amountType, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountTypeData(amountType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountTypeAsync(int amountType, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountTypeData(amountType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountTypeData(int amountType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AmountType` = @AmountType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountType", amountType, MySqlDbType.Int32));
		}
		#endregion // RemoveByAmountType
		#region RemoveByRewardAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardAmount(long? rewardAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardAmountData(rewardAmount.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardAmountAsync(long? rewardAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardAmountData(rewardAmount.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardAmountData(long? rewardAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (rewardAmount.HasValue ? "`RewardAmount` = @RewardAmount" : "`RewardAmount` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (rewardAmount.HasValue)
				paras_.Add(Database.CreateInParameter("@RewardAmount", rewardAmount.Value, MySqlDbType.Int64));
		}
		#endregion // RemoveByRewardAmount
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowMultip(int? flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowMultipAsync(int? flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowMultipData(int? flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (flowMultip.HasValue ? "`FlowMultip` = @FlowMultip" : "`FlowMultip` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (flowMultip.HasValue)
				paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlowMultip
		#region RemoveBySourceType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceType(int? sourceType, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeData(sourceType.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceTypeAsync(int? sourceType, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTypeData(sourceType.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceTypeData(int? sourceType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sourceType.HasValue ? "`SourceType` = @SourceType" : "`SourceType` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sourceType.HasValue)
				paras_.Add(Database.CreateInParameter("@SourceType", sourceType.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveBySourceType
		#region RemoveBySourceTable
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceTable(string sourceTable, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTableData(sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceTableAsync(string sourceTable, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceTableData(sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceTableData(string sourceTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sourceTable != null ? "`SourceTable` = @SourceTable" : "`SourceTable` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sourceTable != null)
				paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySourceTable
		#region RemoveBySourceId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "sourceId">数据ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySourceId(string sourceId, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceIdData(sourceId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySourceIdAsync(string sourceId, TransactionManager tm_ = null)
		{
			RepairRemoveBySourceIdData(sourceId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySourceIdData(string sourceId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (sourceId != null ? "`SourceId` = @SourceId" : "`SourceId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (sourceId != null)
				paras_.Add(Database.CreateInParameter("@SourceId", sourceId, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySourceId
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(int? status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(int? status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(int? status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (status.HasValue ? "`Status` = @Status" : "`Status` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (status.HasValue)
				paras_.Add(Database.CreateInParameter("@Status", status.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByStatus
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
		#region RemoveByUpdateTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUpdateTime(DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUpdateTimeAsync(DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByUpdateTimeData(updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUpdateTimeData(DateTime updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UpdateTime` = @UpdateTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveByUpdateTime
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
		public int Put(Sem_message_rewardEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sem_message_rewardEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sem_message_rewardEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID, `ReceiverID` = @ReceiverID, `AmountType` = @AmountType, `RewardAmount` = @RewardAmount, `FlowMultip` = @FlowMultip, `SourceType` = @SourceType, `SourceTable` = @SourceTable, `SourceId` = @SourceId, `Status` = @Status WHERE `MessageID` = @MessageID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ReceiverID", item.ReceiverID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AmountType", item.AmountType, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardAmount", item.RewardAmount.HasValue ? item.RewardAmount.Value : (object)DBNull.Value, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip.HasValue ? item.FlowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@SourceType", item.SourceType.HasValue ? item.SourceType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@SourceTable", item.SourceTable != null ? item.SourceTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SourceId", item.SourceId != null ? item.SourceId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status.HasValue ? item.Status.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID_Original", item.HasOriginal ? item.OriginalMessageID : item.MessageID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sem_message_rewardEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sem_message_rewardEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "messageID">消息ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string messageID, string set_, params object[] values_)
		{
			return Put(set_, "`MessageID` = @MessageID", ConcatValues(values_, messageID));
		}
		public async Task<int> PutByPKAsync(string messageID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`MessageID` = @MessageID", ConcatValues(values_, messageID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string messageID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`MessageID` = @MessageID", tm_, ConcatValues(values_, messageID));
		}
		public async Task<int> PutByPKAsync(string messageID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`MessageID` = @MessageID", tm_, ConcatValues(values_, messageID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string messageID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`MessageID` = @MessageID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string messageID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`MessageID` = @MessageID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutReceiverID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReceiverIDByPK(string messageID, string receiverID, TransactionManager tm_ = null)
		{
			RepairPutReceiverIDByPKData(messageID, receiverID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReceiverIDByPKAsync(string messageID, string receiverID, TransactionManager tm_ = null)
		{
			RepairPutReceiverIDByPKData(messageID, receiverID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReceiverIDByPKData(string messageID, string receiverID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReceiverID` = @ReceiverID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReceiverID", receiverID, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReceiverID(string receiverID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReceiverID` = @ReceiverID";
			var parameter_ = Database.CreateInParameter("@ReceiverID", receiverID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutReceiverIDAsync(string receiverID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReceiverID` = @ReceiverID";
			var parameter_ = Database.CreateInParameter("@ReceiverID", receiverID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReceiverID
		#region PutAmountType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountTypeByPK(string messageID, int amountType, TransactionManager tm_ = null)
		{
			RepairPutAmountTypeByPKData(messageID, amountType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountTypeByPKAsync(string messageID, int amountType, TransactionManager tm_ = null)
		{
			RepairPutAmountTypeByPKData(messageID, amountType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountTypeByPKData(string messageID, int amountType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AmountType` = @AmountType  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AmountType", amountType, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountType(int amountType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AmountType` = @AmountType";
			var parameter_ = Database.CreateInParameter("@AmountType", amountType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountTypeAsync(int amountType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AmountType` = @AmountType";
			var parameter_ = Database.CreateInParameter("@AmountType", amountType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmountType
		#region PutRewardAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardAmountByPK(string messageID, long? rewardAmount, TransactionManager tm_ = null)
		{
			RepairPutRewardAmountByPKData(messageID, rewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardAmountByPKAsync(string messageID, long? rewardAmount, TransactionManager tm_ = null)
		{
			RepairPutRewardAmountByPKData(messageID, rewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardAmountByPKData(string messageID, long? rewardAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardAmount` = @RewardAmount  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardAmount", rewardAmount.HasValue ? rewardAmount.Value : (object)DBNull.Value, MySqlDbType.Int64),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardAmount(long? rewardAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardAmount` = @RewardAmount";
			var parameter_ = Database.CreateInParameter("@RewardAmount", rewardAmount.HasValue ? rewardAmount.Value : (object)DBNull.Value, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardAmountAsync(long? rewardAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardAmount` = @RewardAmount";
			var parameter_ = Database.CreateInParameter("@RewardAmount", rewardAmount.HasValue ? rewardAmount.Value : (object)DBNull.Value, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardAmount
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string messageID, int? flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(messageID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string messageID, int? flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(messageID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string messageID, int? flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip.HasValue ? flowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultip(int? flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip.HasValue ? flowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowMultipAsync(int? flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip.HasValue ? flowMultip.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowMultip
		#region PutSourceType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTypeByPK(string messageID, int? sourceType, TransactionManager tm_ = null)
		{
			RepairPutSourceTypeByPKData(messageID, sourceType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceTypeByPKAsync(string messageID, int? sourceType, TransactionManager tm_ = null)
		{
			RepairPutSourceTypeByPKData(messageID, sourceType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceTypeByPKData(string messageID, int? sourceType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceType", sourceType.HasValue ? sourceType.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceType(int? sourceType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType";
			var parameter_ = Database.CreateInParameter("@SourceType", sourceType.HasValue ? sourceType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceTypeAsync(int? sourceType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceType` = @SourceType";
			var parameter_ = Database.CreateInParameter("@SourceType", sourceType.HasValue ? sourceType.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceType
		#region PutSourceTable
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTableByPK(string messageID, string sourceTable, TransactionManager tm_ = null)
		{
			RepairPutSourceTableByPKData(messageID, sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceTableByPKAsync(string messageID, string sourceTable, TransactionManager tm_ = null)
		{
			RepairPutSourceTableByPKData(messageID, sourceTable, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceTableByPKData(string messageID, string sourceTable, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceTable", sourceTable != null ? sourceTable : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceTable(string sourceTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable";
			var parameter_ = Database.CreateInParameter("@SourceTable", sourceTable != null ? sourceTable : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceTableAsync(string sourceTable, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceTable` = @SourceTable";
			var parameter_ = Database.CreateInParameter("@SourceTable", sourceTable != null ? sourceTable : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceTable
		#region PutSourceId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "sourceId">数据ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceIdByPK(string messageID, string sourceId, TransactionManager tm_ = null)
		{
			RepairPutSourceIdByPKData(messageID, sourceId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSourceIdByPKAsync(string messageID, string sourceId, TransactionManager tm_ = null)
		{
			RepairPutSourceIdByPKData(messageID, sourceId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSourceIdByPKData(string messageID, string sourceId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SourceId` = @SourceId  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SourceId", sourceId != null ? sourceId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "sourceId">数据ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSourceId(string sourceId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceId` = @SourceId";
			var parameter_ = Database.CreateInParameter("@SourceId", sourceId != null ? sourceId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSourceIdAsync(string sourceId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SourceId` = @SourceId";
			var parameter_ = Database.CreateInParameter("@SourceId", sourceId != null ? sourceId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSourceId
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string messageID, int? status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(messageID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string messageID, int? status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(messageID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string messageID, int? status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status.HasValue ? status.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(int? status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status.HasValue ? status.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(int? status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status.HasValue ? status.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string messageID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(messageID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string messageID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(messageID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string messageID, DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#region PutUpdateTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTimeByPK(string messageID, DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(messageID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUpdateTimeByPKAsync(string messageID, DateTime updateTime, TransactionManager tm_ = null)
		{
			RepairPutUpdateTimeByPKData(messageID, updateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUpdateTimeByPKData(string messageID, DateTime updateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUpdateTime(DateTime updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUpdateTimeAsync(DateTime updateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UpdateTime` = @UpdateTime";
			var parameter_ = Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUpdateTime
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sem_message_rewardEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MessageID) == null)
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
		public async Task<bool> SetAsync(Sem_message_rewardEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MessageID) == null)
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
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sem_message_rewardEO GetByPK(string messageID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(messageID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<Sem_message_rewardEO> GetByPKAsync(string messageID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(messageID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		private void RepairGetByPKData(string messageID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
		{
			sql_ = BuildSelectSQL("`MessageID` = @MessageID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ReceiverID（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetReceiverIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ReceiverID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetReceiverIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ReceiverID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AmountType（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetAmountTypeByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`AmountType`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int> GetAmountTypeByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`AmountType`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardAmount（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long? GetRewardAmountByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long?)GetScalar("`RewardAmount`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<long?> GetRewardAmountByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (long?)await GetScalarAsync("`RewardAmount`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetFlowMultipByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`FlowMultip`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int?> GetFlowMultipByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`FlowMultip`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceType（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetSourceTypeByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`SourceType`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int?> GetSourceTypeByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`SourceType`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceTable（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSourceTableByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SourceTable`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetSourceTableByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SourceTable`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SourceId（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSourceIdByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SourceId`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetSourceIdByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SourceId`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetStatusByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`Status`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int?> GetStatusByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`Status`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRecDateByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`RecDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<DateTime?> GetRecDateByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`RecDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UpdateTime（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetUpdateTimeByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`UpdateTime`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<DateTime> GetUpdateTimeByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`UpdateTime`", "`MessageID` = @MessageID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByReceiverID
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByReceiverID(string receiverID)
		{
			return GetByReceiverID(receiverID, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByReceiverIDAsync(string receiverID)
		{
			return await GetByReceiverIDAsync(receiverID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByReceiverID(string receiverID, TransactionManager tm_)
		{
			return GetByReceiverID(receiverID, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByReceiverIDAsync(string receiverID, TransactionManager tm_)
		{
			return await GetByReceiverIDAsync(receiverID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByReceiverID(string receiverID, int top_)
		{
			return GetByReceiverID(receiverID, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByReceiverIDAsync(string receiverID, int top_)
		{
			return await GetByReceiverIDAsync(receiverID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByReceiverID(string receiverID, int top_, TransactionManager tm_)
		{
			return GetByReceiverID(receiverID, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByReceiverIDAsync(string receiverID, int top_, TransactionManager tm_)
		{
			return await GetByReceiverIDAsync(receiverID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByReceiverID(string receiverID, string sort_)
		{
			return GetByReceiverID(receiverID, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByReceiverIDAsync(string receiverID, string sort_)
		{
			return await GetByReceiverIDAsync(receiverID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByReceiverID(string receiverID, string sort_, TransactionManager tm_)
		{
			return GetByReceiverID(receiverID, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByReceiverIDAsync(string receiverID, string sort_, TransactionManager tm_)
		{
			return await GetByReceiverIDAsync(receiverID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByReceiverID(string receiverID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiverID` = @ReceiverID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiverID", receiverID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetByReceiverIDAsync(string receiverID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiverID` = @ReceiverID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiverID", receiverID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetByReceiverID
		#region GetByAmountType
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByAmountType(int amountType)
		{
			return GetByAmountType(amountType, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByAmountTypeAsync(int amountType)
		{
			return await GetByAmountTypeAsync(amountType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByAmountType(int amountType, TransactionManager tm_)
		{
			return GetByAmountType(amountType, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByAmountTypeAsync(int amountType, TransactionManager tm_)
		{
			return await GetByAmountTypeAsync(amountType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByAmountType(int amountType, int top_)
		{
			return GetByAmountType(amountType, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByAmountTypeAsync(int amountType, int top_)
		{
			return await GetByAmountTypeAsync(amountType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByAmountType(int amountType, int top_, TransactionManager tm_)
		{
			return GetByAmountType(amountType, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByAmountTypeAsync(int amountType, int top_, TransactionManager tm_)
		{
			return await GetByAmountTypeAsync(amountType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByAmountType(int amountType, string sort_)
		{
			return GetByAmountType(amountType, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByAmountTypeAsync(int amountType, string sort_)
		{
			return await GetByAmountTypeAsync(amountType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByAmountType(int amountType, string sort_, TransactionManager tm_)
		{
			return GetByAmountType(amountType, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByAmountTypeAsync(int amountType, string sort_, TransactionManager tm_)
		{
			return await GetByAmountTypeAsync(amountType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AmountType（字段） 查询
		/// </summary>
		/// /// <param name = "amountType">金额类型 1-Bonus 2-真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByAmountType(int amountType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AmountType` = @AmountType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountType", amountType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetByAmountTypeAsync(int amountType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AmountType` = @AmountType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AmountType", amountType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetByAmountType
		#region GetByRewardAmount
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRewardAmount(long? rewardAmount)
		{
			return GetByRewardAmount(rewardAmount, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRewardAmountAsync(long? rewardAmount)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRewardAmount(long? rewardAmount, TransactionManager tm_)
		{
			return GetByRewardAmount(rewardAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRewardAmountAsync(long? rewardAmount, TransactionManager tm_)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRewardAmount(long? rewardAmount, int top_)
		{
			return GetByRewardAmount(rewardAmount, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRewardAmountAsync(long? rewardAmount, int top_)
		{
			return await GetByRewardAmountAsync(rewardAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRewardAmount(long? rewardAmount, int top_, TransactionManager tm_)
		{
			return GetByRewardAmount(rewardAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRewardAmountAsync(long? rewardAmount, int top_, TransactionManager tm_)
		{
			return await GetByRewardAmountAsync(rewardAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRewardAmount(long? rewardAmount, string sort_)
		{
			return GetByRewardAmount(rewardAmount, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRewardAmountAsync(long? rewardAmount, string sort_)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRewardAmount(long? rewardAmount, string sort_, TransactionManager tm_)
		{
			return GetByRewardAmount(rewardAmount, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRewardAmountAsync(long? rewardAmount, string sort_, TransactionManager tm_)
		{
			return await GetByRewardAmountAsync(rewardAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "rewardAmount">奖励金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRewardAmount(long? rewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardAmount.HasValue ? "`RewardAmount` = @RewardAmount" : "`RewardAmount` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardAmount.HasValue)
				paras_.Add(Database.CreateInParameter("@RewardAmount", rewardAmount.Value, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRewardAmountAsync(long? rewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(rewardAmount.HasValue ? "`RewardAmount` = @RewardAmount" : "`RewardAmount` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (rewardAmount.HasValue)
				paras_.Add(Database.CreateInParameter("@RewardAmount", rewardAmount.Value, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetByRewardAmount
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByFlowMultip(int? flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByFlowMultipAsync(int? flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByFlowMultip(int? flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByFlowMultipAsync(int? flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByFlowMultip(int? flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByFlowMultipAsync(int? flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByFlowMultip(int? flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByFlowMultipAsync(int? flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByFlowMultip(int? flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByFlowMultipAsync(int? flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByFlowMultip(int? flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByFlowMultipAsync(int? flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">赠金提现所需要的流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByFlowMultip(int? flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(flowMultip.HasValue ? "`FlowMultip` = @FlowMultip" : "`FlowMultip` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (flowMultip.HasValue)
				paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetByFlowMultipAsync(int? flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(flowMultip.HasValue ? "`FlowMultip` = @FlowMultip" : "`FlowMultip` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (flowMultip.HasValue)
				paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#region GetBySourceType
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceType(int? sourceType)
		{
			return GetBySourceType(sourceType, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTypeAsync(int? sourceType)
		{
			return await GetBySourceTypeAsync(sourceType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceType(int? sourceType, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceType(int? sourceType, int top_)
		{
			return GetBySourceType(sourceType, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, int top_)
		{
			return await GetBySourceTypeAsync(sourceType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceType(int? sourceType, int top_, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, int top_, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceType(int? sourceType, string sort_)
		{
			return GetBySourceType(sourceType, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, string sort_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceType(int? sourceType, string sort_, TransactionManager tm_)
		{
			return GetBySourceType(sourceType, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, string sort_, TransactionManager tm_)
		{
			return await GetBySourceTypeAsync(sourceType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceType（字段） 查询
		/// </summary>
		/// /// <param name = "sourceType">数据来源类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceType(int? sourceType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceType.HasValue ? "`SourceType` = @SourceType" : "`SourceType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceType.HasValue)
				paras_.Add(Database.CreateInParameter("@SourceType", sourceType.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTypeAsync(int? sourceType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceType.HasValue ? "`SourceType` = @SourceType" : "`SourceType` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceType.HasValue)
				paras_.Add(Database.CreateInParameter("@SourceType", sourceType.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetBySourceType
		#region GetBySourceTable
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceTable(string sourceTable)
		{
			return GetBySourceTable(sourceTable, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTableAsync(string sourceTable)
		{
			return await GetBySourceTableAsync(sourceTable, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceTable(string sourceTable, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTableAsync(string sourceTable, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceTable(string sourceTable, int top_)
		{
			return GetBySourceTable(sourceTable, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTableAsync(string sourceTable, int top_)
		{
			return await GetBySourceTableAsync(sourceTable, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceTable(string sourceTable, int top_, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTableAsync(string sourceTable, int top_, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceTable(string sourceTable, string sort_)
		{
			return GetBySourceTable(sourceTable, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTableAsync(string sourceTable, string sort_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceTable(string sourceTable, string sort_, TransactionManager tm_)
		{
			return GetBySourceTable(sourceTable, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTableAsync(string sourceTable, string sort_, TransactionManager tm_)
		{
			return await GetBySourceTableAsync(sourceTable, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceTable（字段） 查询
		/// </summary>
		/// /// <param name = "sourceTable">数据来源表名</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceTable(string sourceTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceTable != null ? "`SourceTable` = @SourceTable" : "`SourceTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceTable != null)
				paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceTableAsync(string sourceTable, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceTable != null ? "`SourceTable` = @SourceTable" : "`SourceTable` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceTable != null)
				paras_.Add(Database.CreateInParameter("@SourceTable", sourceTable, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetBySourceTable
		#region GetBySourceId
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">数据ID</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceId(string sourceId)
		{
			return GetBySourceId(sourceId, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceIdAsync(string sourceId)
		{
			return await GetBySourceIdAsync(sourceId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">数据ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceId(string sourceId, TransactionManager tm_)
		{
			return GetBySourceId(sourceId, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceIdAsync(string sourceId, TransactionManager tm_)
		{
			return await GetBySourceIdAsync(sourceId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">数据ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceId(string sourceId, int top_)
		{
			return GetBySourceId(sourceId, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceIdAsync(string sourceId, int top_)
		{
			return await GetBySourceIdAsync(sourceId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">数据ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceId(string sourceId, int top_, TransactionManager tm_)
		{
			return GetBySourceId(sourceId, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceIdAsync(string sourceId, int top_, TransactionManager tm_)
		{
			return await GetBySourceIdAsync(sourceId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">数据ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceId(string sourceId, string sort_)
		{
			return GetBySourceId(sourceId, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceIdAsync(string sourceId, string sort_)
		{
			return await GetBySourceIdAsync(sourceId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">数据ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceId(string sourceId, string sort_, TransactionManager tm_)
		{
			return GetBySourceId(sourceId, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceIdAsync(string sourceId, string sort_, TransactionManager tm_)
		{
			return await GetBySourceIdAsync(sourceId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SourceId（字段） 查询
		/// </summary>
		/// /// <param name = "sourceId">数据ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetBySourceId(string sourceId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceId != null ? "`SourceId` = @SourceId" : "`SourceId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceId != null)
				paras_.Add(Database.CreateInParameter("@SourceId", sourceId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetBySourceIdAsync(string sourceId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(sourceId != null ? "`SourceId` = @SourceId" : "`SourceId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (sourceId != null)
				paras_.Add(Database.CreateInParameter("@SourceId", sourceId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetBySourceId
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByStatus(int? status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByStatusAsync(int? status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByStatus(int? status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByStatusAsync(int? status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByStatus(int? status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByStatusAsync(int? status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByStatus(int? status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByStatusAsync(int? status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByStatus(int? status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByStatusAsync(int? status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByStatus(int? status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByStatusAsync(int? status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-未领取 1-已领取</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByStatus(int? status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(status.HasValue ? "`Status` = @Status" : "`Status` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (status.HasValue)
				paras_.Add(Database.CreateInParameter("@Status", status.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetByStatusAsync(int? status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(status.HasValue ? "`Status` = @Status" : "`Status` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (status.HasValue)
				paras_.Add(Database.CreateInParameter("@Status", status.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRecDate(DateTime? recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRecDateAsync(DateTime? recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRecDate(DateTime? recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRecDateAsync(DateTime? recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRecDate(DateTime? recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRecDateAsync(DateTime? recDate, int top_)
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
		public List<Sem_message_rewardEO> GetByRecDate(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRecDateAsync(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByRecDate(DateTime? recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRecDateAsync(DateTime? recDate, string sort_)
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
		public List<Sem_message_rewardEO> GetByRecDate(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRecDateAsync(DateTime? recDate, string sort_, TransactionManager tm_)
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
		public List<Sem_message_rewardEO> GetByRecDate(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetByRecDateAsync(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByUpdateTime
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByUpdateTime(DateTime updateTime)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByUpdateTimeAsync(DateTime updateTime)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByUpdateTime(DateTime updateTime, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByUpdateTimeAsync(DateTime updateTime, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByUpdateTime(DateTime updateTime, int top_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByUpdateTime(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByUpdateTime(DateTime updateTime, string sort_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, null);
		}
		public async Task<List<Sem_message_rewardEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByUpdateTime(DateTime updateTime, string sort_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, tm_);
		}
		public async Task<List<Sem_message_rewardEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_message_rewardEO> GetByUpdateTime(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		public async Task<List<Sem_message_rewardEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_message_rewardEO.MapDataReader);
		}
		#endregion // GetByUpdateTime
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
