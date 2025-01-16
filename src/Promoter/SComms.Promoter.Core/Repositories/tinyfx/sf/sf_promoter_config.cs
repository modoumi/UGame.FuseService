/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-10-30 16: 44:44
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

namespace SComms.Promoter.Core.Repositories
{
	#region EO
	/// <summary>
	/// 推广基础配置
	/// 【表 sf_promoter_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sf_promoter_configEO : IRowMapper<Sf_promoter_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sf_promoter_configEO()
		{
			this.HasBonusPerf = false;
			this.CommMinDeposit = 0;
			this.CommMinPerf = 0;
			this.IsCollectBonus = true;
			this.FlowMultip = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalOperatorID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorID
		{
			get { return _originalOperatorID; }
			set { HasOriginal = true; _originalOperatorID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 业绩返佣时是否包含bonus
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 2)]
		public bool HasBonusPerf { get; set; }
		/// <summary>
		/// 返佣时最低存款要求
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long CommMinDeposit { get; set; }
		/// <summary>
		/// 返佣时最低业绩要求
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long CommMinPerf { get; set; }
		/// <summary>
		/// 领取时是否是bonus
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 5)]
		public bool IsCollectBonus { get; set; }
		/// <summary>
		/// 流水倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int FlowMultip { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sf_promoter_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sf_promoter_configEO MapDataReader(IDataReader reader)
		{
		    Sf_promoter_configEO ret = new Sf_promoter_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.HasBonusPerf = reader.ToBoolean("HasBonusPerf");
			ret.CommMinDeposit = reader.ToInt64("CommMinDeposit");
			ret.CommMinPerf = reader.ToInt64("CommMinPerf");
			ret.IsCollectBonus = reader.ToBoolean("IsCollectBonus");
			ret.FlowMultip = reader.ToInt32("FlowMultip");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 推广基础配置
	/// 【表 sf_promoter_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sf_promoter_configMO : MySqlTableMO<Sf_promoter_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sf_promoter_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sf_promoter_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sf_promoter_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sf_promoter_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sf_promoter_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sf_promoter_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sf_promoter_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `HasBonusPerf`, `CommMinDeposit`, `CommMinPerf`, `IsCollectBonus`, `FlowMultip`) VALUE (@OperatorID, @HasBonusPerf, @CommMinDeposit, @CommMinPerf, @IsCollectBonus, @FlowMultip);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@HasBonusPerf", item.HasBonusPerf, MySqlDbType.Byte),
				Database.CreateInParameter("@CommMinDeposit", item.CommMinDeposit, MySqlDbType.Int64),
				Database.CreateInParameter("@CommMinPerf", item.CommMinPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@IsCollectBonus", item.IsCollectBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Sf_promoter_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sf_promoter_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sf_promoter_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `HasBonusPerf`, `CommMinDeposit`, `CommMinPerf`, `IsCollectBonus`, `FlowMultip`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}',{item.HasBonusPerf},{item.CommMinDeposit},{item.CommMinPerf},{item.IsCollectBonus},{item.FlowMultip}),");
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sf_promoter_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, tm_);
		}
		public async Task<int> RemoveAsync(Sf_promoter_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByHasBonusPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHasBonusPerf(bool hasBonusPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByHasBonusPerfData(hasBonusPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHasBonusPerfAsync(bool hasBonusPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByHasBonusPerfData(hasBonusPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHasBonusPerfData(bool hasBonusPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HasBonusPerf` = @HasBonusPerf";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBonusPerf", hasBonusPerf, MySqlDbType.Byte));
		}
		#endregion // RemoveByHasBonusPerf
		#region RemoveByCommMinDeposit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCommMinDeposit(long commMinDeposit, TransactionManager tm_ = null)
		{
			RepairRemoveByCommMinDepositData(commMinDeposit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCommMinDepositAsync(long commMinDeposit, TransactionManager tm_ = null)
		{
			RepairRemoveByCommMinDepositData(commMinDeposit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCommMinDepositData(long commMinDeposit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CommMinDeposit` = @CommMinDeposit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CommMinDeposit", commMinDeposit, MySqlDbType.Int64));
		}
		#endregion // RemoveByCommMinDeposit
		#region RemoveByCommMinPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCommMinPerf(long commMinPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByCommMinPerfData(commMinPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCommMinPerfAsync(long commMinPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByCommMinPerfData(commMinPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCommMinPerfData(long commMinPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CommMinPerf` = @CommMinPerf";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CommMinPerf", commMinPerf, MySqlDbType.Int64));
		}
		#endregion // RemoveByCommMinPerf
		#region RemoveByIsCollectBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsCollectBonus(bool isCollectBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByIsCollectBonusData(isCollectBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsCollectBonusAsync(bool isCollectBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByIsCollectBonusData(isCollectBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsCollectBonusData(bool isCollectBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsCollectBonus` = @IsCollectBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsCollectBonus", isCollectBonus, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsCollectBonus
		#region RemoveByFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowMultip(int flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowMultipAsync(int flowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowMultipData(flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowMultipData(int flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowMultip` = @FlowMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlowMultip
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
		public int Put(Sf_promoter_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sf_promoter_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sf_promoter_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `HasBonusPerf` = @HasBonusPerf, `CommMinDeposit` = @CommMinDeposit, `CommMinPerf` = @CommMinPerf, `IsCollectBonus` = @IsCollectBonus, `FlowMultip` = @FlowMultip WHERE `OperatorID` = @OperatorID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@HasBonusPerf", item.HasBonusPerf, MySqlDbType.Byte),
				Database.CreateInParameter("@CommMinDeposit", item.CommMinDeposit, MySqlDbType.Int64),
				Database.CreateInParameter("@CommMinPerf", item.CommMinPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@IsCollectBonus", item.IsCollectBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@FlowMultip", item.FlowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sf_promoter_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sf_promoter_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID", ConcatValues(values_, operatorID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID", ConcatValues(values_, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID", tm_, ConcatValues(values_, operatorID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID", tm_, ConcatValues(values_, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutHasBonusPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasBonusPerfByPK(string operatorID, bool hasBonusPerf, TransactionManager tm_ = null)
		{
			RepairPutHasBonusPerfByPKData(operatorID, hasBonusPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasBonusPerfByPKAsync(string operatorID, bool hasBonusPerf, TransactionManager tm_ = null)
		{
			RepairPutHasBonusPerfByPKData(operatorID, hasBonusPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasBonusPerfByPKData(string operatorID, bool hasBonusPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasBonusPerf` = @HasBonusPerf  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasBonusPerf", hasBonusPerf, MySqlDbType.Byte),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasBonusPerf(bool hasBonusPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasBonusPerf` = @HasBonusPerf";
			var parameter_ = Database.CreateInParameter("@HasBonusPerf", hasBonusPerf, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHasBonusPerfAsync(bool hasBonusPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasBonusPerf` = @HasBonusPerf";
			var parameter_ = Database.CreateInParameter("@HasBonusPerf", hasBonusPerf, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHasBonusPerf
		#region PutCommMinDeposit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCommMinDepositByPK(string operatorID, long commMinDeposit, TransactionManager tm_ = null)
		{
			RepairPutCommMinDepositByPKData(operatorID, commMinDeposit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCommMinDepositByPKAsync(string operatorID, long commMinDeposit, TransactionManager tm_ = null)
		{
			RepairPutCommMinDepositByPKData(operatorID, commMinDeposit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCommMinDepositByPKData(string operatorID, long commMinDeposit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CommMinDeposit` = @CommMinDeposit  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CommMinDeposit", commMinDeposit, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCommMinDeposit(long commMinDeposit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CommMinDeposit` = @CommMinDeposit";
			var parameter_ = Database.CreateInParameter("@CommMinDeposit", commMinDeposit, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCommMinDepositAsync(long commMinDeposit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CommMinDeposit` = @CommMinDeposit";
			var parameter_ = Database.CreateInParameter("@CommMinDeposit", commMinDeposit, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCommMinDeposit
		#region PutCommMinPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCommMinPerfByPK(string operatorID, long commMinPerf, TransactionManager tm_ = null)
		{
			RepairPutCommMinPerfByPKData(operatorID, commMinPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCommMinPerfByPKAsync(string operatorID, long commMinPerf, TransactionManager tm_ = null)
		{
			RepairPutCommMinPerfByPKData(operatorID, commMinPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCommMinPerfByPKData(string operatorID, long commMinPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CommMinPerf` = @CommMinPerf  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CommMinPerf", commMinPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCommMinPerf(long commMinPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CommMinPerf` = @CommMinPerf";
			var parameter_ = Database.CreateInParameter("@CommMinPerf", commMinPerf, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCommMinPerfAsync(long commMinPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CommMinPerf` = @CommMinPerf";
			var parameter_ = Database.CreateInParameter("@CommMinPerf", commMinPerf, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCommMinPerf
		#region PutIsCollectBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsCollectBonusByPK(string operatorID, bool isCollectBonus, TransactionManager tm_ = null)
		{
			RepairPutIsCollectBonusByPKData(operatorID, isCollectBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsCollectBonusByPKAsync(string operatorID, bool isCollectBonus, TransactionManager tm_ = null)
		{
			RepairPutIsCollectBonusByPKData(operatorID, isCollectBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsCollectBonusByPKData(string operatorID, bool isCollectBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsCollectBonus` = @IsCollectBonus  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsCollectBonus", isCollectBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsCollectBonus(bool isCollectBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsCollectBonus` = @IsCollectBonus";
			var parameter_ = Database.CreateInParameter("@IsCollectBonus", isCollectBonus, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsCollectBonusAsync(bool isCollectBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsCollectBonus` = @IsCollectBonus";
			var parameter_ = Database.CreateInParameter("@IsCollectBonus", isCollectBonus, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsCollectBonus
		#region PutFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultipByPK(string operatorID, int flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(operatorID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowMultipByPKAsync(string operatorID, int flowMultip, TransactionManager tm_ = null)
		{
			RepairPutFlowMultipByPKData(operatorID, flowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowMultipByPKData(string operatorID, int flowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMultip(int flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowMultipAsync(int flowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMultip` = @FlowMultip";
			var parameter_ = Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowMultip
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sf_promoter_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID) == null)
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
		public async Task<bool> SetAsync(Sf_promoter_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID) == null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sf_promoter_configEO GetByPK(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		public async Task<Sf_promoter_configEO> GetByPKAsync(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 HasBonusPerf（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasBonusPerfByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasBonusPerf`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<bool> GetHasBonusPerfByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasBonusPerf`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CommMinDeposit（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCommMinDepositByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`CommMinDeposit`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<long> GetCommMinDepositByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`CommMinDeposit`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CommMinPerf（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCommMinPerfByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`CommMinPerf`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<long> GetCommMinPerfByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`CommMinPerf`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsCollectBonus（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsCollectBonusByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsCollectBonus`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<bool> GetIsCollectBonusByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsCollectBonus`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMultip（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFlowMultipByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FlowMultip`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetFlowMultipByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FlowMultip`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByHasBonusPerf
		
		/// <summary>
		/// 按 HasBonusPerf（字段） 查询
		/// </summary>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByHasBonusPerf(bool hasBonusPerf)
		{
			return GetByHasBonusPerf(hasBonusPerf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByHasBonusPerfAsync(bool hasBonusPerf)
		{
			return await GetByHasBonusPerfAsync(hasBonusPerf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasBonusPerf（字段） 查询
		/// </summary>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByHasBonusPerf(bool hasBonusPerf, TransactionManager tm_)
		{
			return GetByHasBonusPerf(hasBonusPerf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByHasBonusPerfAsync(bool hasBonusPerf, TransactionManager tm_)
		{
			return await GetByHasBonusPerfAsync(hasBonusPerf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasBonusPerf（字段） 查询
		/// </summary>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByHasBonusPerf(bool hasBonusPerf, int top_)
		{
			return GetByHasBonusPerf(hasBonusPerf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByHasBonusPerfAsync(bool hasBonusPerf, int top_)
		{
			return await GetByHasBonusPerfAsync(hasBonusPerf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasBonusPerf（字段） 查询
		/// </summary>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByHasBonusPerf(bool hasBonusPerf, int top_, TransactionManager tm_)
		{
			return GetByHasBonusPerf(hasBonusPerf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByHasBonusPerfAsync(bool hasBonusPerf, int top_, TransactionManager tm_)
		{
			return await GetByHasBonusPerfAsync(hasBonusPerf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasBonusPerf（字段） 查询
		/// </summary>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByHasBonusPerf(bool hasBonusPerf, string sort_)
		{
			return GetByHasBonusPerf(hasBonusPerf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByHasBonusPerfAsync(bool hasBonusPerf, string sort_)
		{
			return await GetByHasBonusPerfAsync(hasBonusPerf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasBonusPerf（字段） 查询
		/// </summary>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByHasBonusPerf(bool hasBonusPerf, string sort_, TransactionManager tm_)
		{
			return GetByHasBonusPerf(hasBonusPerf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByHasBonusPerfAsync(bool hasBonusPerf, string sort_, TransactionManager tm_)
		{
			return await GetByHasBonusPerfAsync(hasBonusPerf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasBonusPerf（字段） 查询
		/// </summary>
		/// /// <param name = "hasBonusPerf">业绩返佣时是否包含bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByHasBonusPerf(bool hasBonusPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasBonusPerf` = @HasBonusPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBonusPerf", hasBonusPerf, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_configEO>> GetByHasBonusPerfAsync(bool hasBonusPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasBonusPerf` = @HasBonusPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasBonusPerf", hasBonusPerf, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		#endregion // GetByHasBonusPerf
		#region GetByCommMinDeposit
		
		/// <summary>
		/// 按 CommMinDeposit（字段） 查询
		/// </summary>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinDeposit(long commMinDeposit)
		{
			return GetByCommMinDeposit(commMinDeposit, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinDepositAsync(long commMinDeposit)
		{
			return await GetByCommMinDepositAsync(commMinDeposit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CommMinDeposit（字段） 查询
		/// </summary>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinDeposit(long commMinDeposit, TransactionManager tm_)
		{
			return GetByCommMinDeposit(commMinDeposit, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinDepositAsync(long commMinDeposit, TransactionManager tm_)
		{
			return await GetByCommMinDepositAsync(commMinDeposit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CommMinDeposit（字段） 查询
		/// </summary>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinDeposit(long commMinDeposit, int top_)
		{
			return GetByCommMinDeposit(commMinDeposit, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinDepositAsync(long commMinDeposit, int top_)
		{
			return await GetByCommMinDepositAsync(commMinDeposit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CommMinDeposit（字段） 查询
		/// </summary>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinDeposit(long commMinDeposit, int top_, TransactionManager tm_)
		{
			return GetByCommMinDeposit(commMinDeposit, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinDepositAsync(long commMinDeposit, int top_, TransactionManager tm_)
		{
			return await GetByCommMinDepositAsync(commMinDeposit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CommMinDeposit（字段） 查询
		/// </summary>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinDeposit(long commMinDeposit, string sort_)
		{
			return GetByCommMinDeposit(commMinDeposit, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinDepositAsync(long commMinDeposit, string sort_)
		{
			return await GetByCommMinDepositAsync(commMinDeposit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CommMinDeposit（字段） 查询
		/// </summary>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinDeposit(long commMinDeposit, string sort_, TransactionManager tm_)
		{
			return GetByCommMinDeposit(commMinDeposit, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinDepositAsync(long commMinDeposit, string sort_, TransactionManager tm_)
		{
			return await GetByCommMinDepositAsync(commMinDeposit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CommMinDeposit（字段） 查询
		/// </summary>
		/// /// <param name = "commMinDeposit">返佣时最低存款要求</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinDeposit(long commMinDeposit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CommMinDeposit` = @CommMinDeposit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CommMinDeposit", commMinDeposit, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinDepositAsync(long commMinDeposit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CommMinDeposit` = @CommMinDeposit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CommMinDeposit", commMinDeposit, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		#endregion // GetByCommMinDeposit
		#region GetByCommMinPerf
		
		/// <summary>
		/// 按 CommMinPerf（字段） 查询
		/// </summary>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinPerf(long commMinPerf)
		{
			return GetByCommMinPerf(commMinPerf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinPerfAsync(long commMinPerf)
		{
			return await GetByCommMinPerfAsync(commMinPerf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CommMinPerf（字段） 查询
		/// </summary>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinPerf(long commMinPerf, TransactionManager tm_)
		{
			return GetByCommMinPerf(commMinPerf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinPerfAsync(long commMinPerf, TransactionManager tm_)
		{
			return await GetByCommMinPerfAsync(commMinPerf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CommMinPerf（字段） 查询
		/// </summary>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinPerf(long commMinPerf, int top_)
		{
			return GetByCommMinPerf(commMinPerf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinPerfAsync(long commMinPerf, int top_)
		{
			return await GetByCommMinPerfAsync(commMinPerf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CommMinPerf（字段） 查询
		/// </summary>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinPerf(long commMinPerf, int top_, TransactionManager tm_)
		{
			return GetByCommMinPerf(commMinPerf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinPerfAsync(long commMinPerf, int top_, TransactionManager tm_)
		{
			return await GetByCommMinPerfAsync(commMinPerf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CommMinPerf（字段） 查询
		/// </summary>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinPerf(long commMinPerf, string sort_)
		{
			return GetByCommMinPerf(commMinPerf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinPerfAsync(long commMinPerf, string sort_)
		{
			return await GetByCommMinPerfAsync(commMinPerf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CommMinPerf（字段） 查询
		/// </summary>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinPerf(long commMinPerf, string sort_, TransactionManager tm_)
		{
			return GetByCommMinPerf(commMinPerf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinPerfAsync(long commMinPerf, string sort_, TransactionManager tm_)
		{
			return await GetByCommMinPerfAsync(commMinPerf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CommMinPerf（字段） 查询
		/// </summary>
		/// /// <param name = "commMinPerf">返佣时最低业绩要求</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByCommMinPerf(long commMinPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CommMinPerf` = @CommMinPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CommMinPerf", commMinPerf, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_configEO>> GetByCommMinPerfAsync(long commMinPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CommMinPerf` = @CommMinPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CommMinPerf", commMinPerf, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		#endregion // GetByCommMinPerf
		#region GetByIsCollectBonus
		
		/// <summary>
		/// 按 IsCollectBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByIsCollectBonus(bool isCollectBonus)
		{
			return GetByIsCollectBonus(isCollectBonus, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByIsCollectBonusAsync(bool isCollectBonus)
		{
			return await GetByIsCollectBonusAsync(isCollectBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsCollectBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByIsCollectBonus(bool isCollectBonus, TransactionManager tm_)
		{
			return GetByIsCollectBonus(isCollectBonus, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByIsCollectBonusAsync(bool isCollectBonus, TransactionManager tm_)
		{
			return await GetByIsCollectBonusAsync(isCollectBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsCollectBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByIsCollectBonus(bool isCollectBonus, int top_)
		{
			return GetByIsCollectBonus(isCollectBonus, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByIsCollectBonusAsync(bool isCollectBonus, int top_)
		{
			return await GetByIsCollectBonusAsync(isCollectBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsCollectBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByIsCollectBonus(bool isCollectBonus, int top_, TransactionManager tm_)
		{
			return GetByIsCollectBonus(isCollectBonus, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByIsCollectBonusAsync(bool isCollectBonus, int top_, TransactionManager tm_)
		{
			return await GetByIsCollectBonusAsync(isCollectBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsCollectBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByIsCollectBonus(bool isCollectBonus, string sort_)
		{
			return GetByIsCollectBonus(isCollectBonus, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByIsCollectBonusAsync(bool isCollectBonus, string sort_)
		{
			return await GetByIsCollectBonusAsync(isCollectBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsCollectBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByIsCollectBonus(bool isCollectBonus, string sort_, TransactionManager tm_)
		{
			return GetByIsCollectBonus(isCollectBonus, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByIsCollectBonusAsync(bool isCollectBonus, string sort_, TransactionManager tm_)
		{
			return await GetByIsCollectBonusAsync(isCollectBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsCollectBonus（字段） 查询
		/// </summary>
		/// /// <param name = "isCollectBonus">领取时是否是bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByIsCollectBonus(bool isCollectBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsCollectBonus` = @IsCollectBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsCollectBonus", isCollectBonus, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_configEO>> GetByIsCollectBonusAsync(bool isCollectBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsCollectBonus` = @IsCollectBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsCollectBonus", isCollectBonus, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		#endregion // GetByIsCollectBonus
		#region GetByFlowMultip
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByFlowMultip(int flowMultip)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByFlowMultipAsync(int flowMultip)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByFlowMultip(int flowMultip, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByFlowMultipAsync(int flowMultip, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByFlowMultip(int flowMultip, int top_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByFlowMultipAsync(int flowMultip, int top_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByFlowMultip(int flowMultip, int top_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByFlowMultipAsync(int flowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByFlowMultip(int flowMultip, string sort_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_configEO>> GetByFlowMultipAsync(int flowMultip, string sort_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByFlowMultip(int flowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFlowMultip(flowMultip, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_configEO>> GetByFlowMultipAsync(int flowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFlowMultipAsync(flowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "flowMultip">流水倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_configEO> GetByFlowMultip(int flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_configEO>> GetByFlowMultipAsync(int flowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMultip` = @FlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMultip", flowMultip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_configEO.MapDataReader);
		}
		#endregion // GetByFlowMultip
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
