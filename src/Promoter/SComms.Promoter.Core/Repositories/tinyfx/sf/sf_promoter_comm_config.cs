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
	/// 推广返佣比例配置
	/// 【表 sf_promoter_comm_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sf_promoter_comm_configEO : IRowMapper<Sf_promoter_comm_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sf_promoter_comm_configEO()
		{
			this.PromoterType = 2;
			this.CommLevel = 0;
			this.MinAmountPerf = 0;
			this.MinCashPerf = 0;
			this.Comm = 0d;
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
		
		private int _originalPromoterType;
		/// <summary>
		/// 【数据库中的原始主键 PromoterType 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalPromoterType
		{
			get { return _originalPromoterType; }
			set { HasOriginal = true; _originalPromoterType = value; }
		}
		
		private int _originalCommLevel;
		/// <summary>
		/// 【数据库中的原始主键 CommLevel 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalCommLevel
		{
			get { return _originalCommLevel; }
			set { HasOriginal = true; _originalCommLevel = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID },  { "PromoterType", PromoterType },  { "CommLevel", CommLevel }, };
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
		/// 推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int PromoterType { get; set; }
		/// <summary>
		/// 返佣级别
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int CommLevel { get; set; }
		/// <summary>
		/// 最低业绩数量（含Bonus）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long MinAmountPerf { get; set; }
		/// <summary>
		/// 最低业绩数量（仅真金）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long MinCashPerf { get; set; }
		/// <summary>
		/// 返还佣金（每一万有效投注流水返奖值）
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 6)]
		public double Comm { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sf_promoter_comm_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sf_promoter_comm_configEO MapDataReader(IDataReader reader)
		{
		    Sf_promoter_comm_configEO ret = new Sf_promoter_comm_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.PromoterType = reader.ToInt32("PromoterType");
			ret.OriginalPromoterType = ret.PromoterType;
			ret.CommLevel = reader.ToInt32("CommLevel");
			ret.OriginalCommLevel = ret.CommLevel;
			ret.MinAmountPerf = reader.ToInt64("MinAmountPerf");
			ret.MinCashPerf = reader.ToInt64("MinCashPerf");
			ret.Comm = reader.ToDouble("Comm");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 推广返佣比例配置
	/// 【表 sf_promoter_comm_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Sf_promoter_comm_configMO : MySqlTableMO<Sf_promoter_comm_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sf_promoter_comm_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sf_promoter_comm_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sf_promoter_comm_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sf_promoter_comm_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sf_promoter_comm_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sf_promoter_comm_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sf_promoter_comm_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `PromoterType`, `CommLevel`, `MinAmountPerf`, `MinCashPerf`, `Comm`) VALUE (@OperatorID, @PromoterType, @CommLevel, @MinAmountPerf, @MinCashPerf, @Comm);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", item.PromoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", item.CommLevel, MySqlDbType.Int32),
				Database.CreateInParameter("@MinAmountPerf", item.MinAmountPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@MinCashPerf", item.MinCashPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@Comm", item.Comm, MySqlDbType.Double),
			};
		}
		public int AddByBatch(IEnumerable<Sf_promoter_comm_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sf_promoter_comm_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sf_promoter_comm_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `PromoterType`, `CommLevel`, `MinAmountPerf`, `MinCashPerf`, `Comm`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}',{item.PromoterType},{item.CommLevel},{item.MinAmountPerf},{item.MinCashPerf},{item.Comm}),");
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
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, promoterType, commLevel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, promoterType, commLevel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, int promoterType, int commLevel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sf_promoter_comm_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.PromoterType, item.CommLevel, tm_);
		}
		public async Task<int> RemoveAsync(Sf_promoter_comm_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, item.PromoterType, item.CommLevel, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
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
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByPromoterType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPromoterType(int promoterType, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoterTypeData(promoterType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPromoterTypeAsync(int promoterType, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoterTypeData(promoterType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPromoterTypeData(int promoterType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
		}
		#endregion // RemoveByPromoterType
		#region RemoveByCommLevel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCommLevel(int commLevel, TransactionManager tm_ = null)
		{
			RepairRemoveByCommLevelData(commLevel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCommLevelAsync(int commLevel, TransactionManager tm_ = null)
		{
			RepairRemoveByCommLevelData(commLevel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCommLevelData(int commLevel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CommLevel` = @CommLevel";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32));
		}
		#endregion // RemoveByCommLevel
		#region RemoveByMinAmountPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMinAmountPerf(long minAmountPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByMinAmountPerfData(minAmountPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMinAmountPerfAsync(long minAmountPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByMinAmountPerfData(minAmountPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMinAmountPerfData(long minAmountPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MinAmountPerf` = @MinAmountPerf";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinAmountPerf", minAmountPerf, MySqlDbType.Int64));
		}
		#endregion // RemoveByMinAmountPerf
		#region RemoveByMinCashPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMinCashPerf(long minCashPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByMinCashPerfData(minCashPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMinCashPerfAsync(long minCashPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByMinCashPerfData(minCashPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMinCashPerfData(long minCashPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MinCashPerf` = @MinCashPerf";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinCashPerf", minCashPerf, MySqlDbType.Int64));
		}
		#endregion // RemoveByMinCashPerf
		#region RemoveByComm
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByComm(double comm, TransactionManager tm_ = null)
		{
			RepairRemoveByCommData(comm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCommAsync(double comm, TransactionManager tm_ = null)
		{
			RepairRemoveByCommData(comm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCommData(double comm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Comm` = @Comm";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Comm", comm, MySqlDbType.Double));
		}
		#endregion // RemoveByComm
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
		public int Put(Sf_promoter_comm_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sf_promoter_comm_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sf_promoter_comm_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `PromoterType` = @PromoterType, `CommLevel` = @CommLevel, `MinAmountPerf` = @MinAmountPerf, `MinCashPerf` = @MinCashPerf, `Comm` = @Comm WHERE `OperatorID` = @OperatorID_Original AND `PromoterType` = @PromoterType_Original AND `CommLevel` = @CommLevel_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", item.PromoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", item.CommLevel, MySqlDbType.Int32),
				Database.CreateInParameter("@MinAmountPerf", item.MinAmountPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@MinCashPerf", item.MinCashPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@Comm", item.Comm, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType_Original", item.HasOriginal ? item.OriginalPromoterType : item.PromoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel_Original", item.HasOriginal ? item.OriginalCommLevel : item.CommLevel, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sf_promoter_comm_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sf_promoter_comm_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, int promoterType, int commLevel, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", ConcatValues(values_, operatorID, promoterType, commLevel));
		}
		public async Task<int> PutByPKAsync(string operatorID, int promoterType, int commLevel, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", ConcatValues(values_, operatorID, promoterType, commLevel));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, int promoterType, int commLevel, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", tm_, ConcatValues(values_, operatorID, promoterType, commLevel));
		}
		public async Task<int> PutByPKAsync(string operatorID, int promoterType, int commLevel, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", tm_, ConcatValues(values_, operatorID, promoterType, commLevel));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, int promoterType, int commLevel, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
	        };
			return Put(set_, "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, int promoterType, int commLevel, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutPromoterType
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPromoterType(int promoterType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoterType` = @PromoterType";
			var parameter_ = Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPromoterTypeAsync(int promoterType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoterType` = @PromoterType";
			var parameter_ = Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPromoterType
		#region PutCommLevel
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCommLevel(int commLevel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CommLevel` = @CommLevel";
			var parameter_ = Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCommLevelAsync(int commLevel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CommLevel` = @CommLevel";
			var parameter_ = Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCommLevel
		#region PutMinAmountPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinAmountPerfByPK(string operatorID, int promoterType, int commLevel, long minAmountPerf, TransactionManager tm_ = null)
		{
			RepairPutMinAmountPerfByPKData(operatorID, promoterType, commLevel, minAmountPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMinAmountPerfByPKAsync(string operatorID, int promoterType, int commLevel, long minAmountPerf, TransactionManager tm_ = null)
		{
			RepairPutMinAmountPerfByPKData(operatorID, promoterType, commLevel, minAmountPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMinAmountPerfByPKData(string operatorID, int promoterType, int commLevel, long minAmountPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MinAmountPerf` = @MinAmountPerf  WHERE `OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinAmountPerf", minAmountPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinAmountPerf(long minAmountPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinAmountPerf` = @MinAmountPerf";
			var parameter_ = Database.CreateInParameter("@MinAmountPerf", minAmountPerf, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMinAmountPerfAsync(long minAmountPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinAmountPerf` = @MinAmountPerf";
			var parameter_ = Database.CreateInParameter("@MinAmountPerf", minAmountPerf, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMinAmountPerf
		#region PutMinCashPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinCashPerfByPK(string operatorID, int promoterType, int commLevel, long minCashPerf, TransactionManager tm_ = null)
		{
			RepairPutMinCashPerfByPKData(operatorID, promoterType, commLevel, minCashPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMinCashPerfByPKAsync(string operatorID, int promoterType, int commLevel, long minCashPerf, TransactionManager tm_ = null)
		{
			RepairPutMinCashPerfByPKData(operatorID, promoterType, commLevel, minCashPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMinCashPerfByPKData(string operatorID, int promoterType, int commLevel, long minCashPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MinCashPerf` = @MinCashPerf  WHERE `OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinCashPerf", minCashPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinCashPerf(long minCashPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinCashPerf` = @MinCashPerf";
			var parameter_ = Database.CreateInParameter("@MinCashPerf", minCashPerf, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMinCashPerfAsync(long minCashPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinCashPerf` = @MinCashPerf";
			var parameter_ = Database.CreateInParameter("@MinCashPerf", minCashPerf, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMinCashPerf
		#region PutComm
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCommByPK(string operatorID, int promoterType, int commLevel, double comm, TransactionManager tm_ = null)
		{
			RepairPutCommByPKData(operatorID, promoterType, commLevel, comm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCommByPKAsync(string operatorID, int promoterType, int commLevel, double comm, TransactionManager tm_ = null)
		{
			RepairPutCommByPKData(operatorID, promoterType, commLevel, comm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCommByPKData(string operatorID, int promoterType, int commLevel, double comm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Comm` = @Comm  WHERE `OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Comm", comm, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutComm(double comm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Comm` = @Comm";
			var parameter_ = Database.CreateInParameter("@Comm", comm, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCommAsync(double comm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Comm` = @Comm";
			var parameter_ = Database.CreateInParameter("@Comm", comm, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutComm
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sf_promoter_comm_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.PromoterType, item.CommLevel) == null)
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
		public async Task<bool> SetAsync(Sf_promoter_comm_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.PromoterType, item.CommLevel) == null)
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
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sf_promoter_comm_configEO GetByPK(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, promoterType, commLevel, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		public async Task<Sf_promoter_comm_configEO> GetByPKAsync(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, promoterType, commLevel, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, int promoterType, int commLevel, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PromoterType（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPromoterTypeByPK(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (int)GetScalar("`PromoterType`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		public async Task<int> GetPromoterTypeByPKAsync(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`PromoterType`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CommLevel（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCommLevelByPK(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (int)GetScalar("`CommLevel`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		public async Task<int> GetCommLevelByPKAsync(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`CommLevel`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MinAmountPerf（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMinAmountPerfByPK(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (long)GetScalar("`MinAmountPerf`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		public async Task<long> GetMinAmountPerfByPKAsync(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`MinAmountPerf`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MinCashPerf（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMinCashPerfByPK(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (long)GetScalar("`MinCashPerf`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		public async Task<long> GetMinCashPerfByPKAsync(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`MinCashPerf`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Comm（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetCommByPK(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (double)GetScalar("`Comm`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		public async Task<double> GetCommByPKAsync(string operatorID, int promoterType, int commLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`Comm`", "`OperatorID` = @OperatorID AND `PromoterType` = @PromoterType AND `CommLevel` = @CommLevel", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByPromoterType
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByPromoterType(int promoterType)
		{
			return GetByPromoterType(promoterType, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByPromoterTypeAsync(int promoterType)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByPromoterType(int promoterType, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByPromoterTypeAsync(int promoterType, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByPromoterType(int promoterType, int top_)
		{
			return GetByPromoterType(promoterType, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByPromoterTypeAsync(int promoterType, int top_)
		{
			return await GetByPromoterTypeAsync(promoterType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByPromoterType(int promoterType, int top_, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByPromoterTypeAsync(int promoterType, int top_, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByPromoterType(int promoterType, string sort_)
		{
			return GetByPromoterType(promoterType, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByPromoterTypeAsync(int promoterType, string sort_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByPromoterType(int promoterType, string sort_, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByPromoterTypeAsync(int promoterType, string sort_, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByPromoterType(int promoterType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoterType` = @PromoterType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByPromoterTypeAsync(int promoterType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoterType` = @PromoterType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		#endregion // GetByPromoterType
		#region GetByCommLevel
		
		/// <summary>
		/// 按 CommLevel（字段） 查询
		/// </summary>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByCommLevel(int commLevel)
		{
			return GetByCommLevel(commLevel, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommLevelAsync(int commLevel)
		{
			return await GetByCommLevelAsync(commLevel, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CommLevel（字段） 查询
		/// </summary>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByCommLevel(int commLevel, TransactionManager tm_)
		{
			return GetByCommLevel(commLevel, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommLevelAsync(int commLevel, TransactionManager tm_)
		{
			return await GetByCommLevelAsync(commLevel, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CommLevel（字段） 查询
		/// </summary>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByCommLevel(int commLevel, int top_)
		{
			return GetByCommLevel(commLevel, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommLevelAsync(int commLevel, int top_)
		{
			return await GetByCommLevelAsync(commLevel, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CommLevel（字段） 查询
		/// </summary>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByCommLevel(int commLevel, int top_, TransactionManager tm_)
		{
			return GetByCommLevel(commLevel, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommLevelAsync(int commLevel, int top_, TransactionManager tm_)
		{
			return await GetByCommLevelAsync(commLevel, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CommLevel（字段） 查询
		/// </summary>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByCommLevel(int commLevel, string sort_)
		{
			return GetByCommLevel(commLevel, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommLevelAsync(int commLevel, string sort_)
		{
			return await GetByCommLevelAsync(commLevel, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CommLevel（字段） 查询
		/// </summary>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByCommLevel(int commLevel, string sort_, TransactionManager tm_)
		{
			return GetByCommLevel(commLevel, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommLevelAsync(int commLevel, string sort_, TransactionManager tm_)
		{
			return await GetByCommLevelAsync(commLevel, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CommLevel（字段） 查询
		/// </summary>
		/// /// <param name = "commLevel">返佣级别</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByCommLevel(int commLevel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CommLevel` = @CommLevel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommLevelAsync(int commLevel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CommLevel` = @CommLevel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CommLevel", commLevel, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		#endregion // GetByCommLevel
		#region GetByMinAmountPerf
		
		/// <summary>
		/// 按 MinAmountPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinAmountPerf(long minAmountPerf)
		{
			return GetByMinAmountPerf(minAmountPerf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinAmountPerfAsync(long minAmountPerf)
		{
			return await GetByMinAmountPerfAsync(minAmountPerf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinAmountPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinAmountPerf(long minAmountPerf, TransactionManager tm_)
		{
			return GetByMinAmountPerf(minAmountPerf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinAmountPerfAsync(long minAmountPerf, TransactionManager tm_)
		{
			return await GetByMinAmountPerfAsync(minAmountPerf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinAmountPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinAmountPerf(long minAmountPerf, int top_)
		{
			return GetByMinAmountPerf(minAmountPerf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinAmountPerfAsync(long minAmountPerf, int top_)
		{
			return await GetByMinAmountPerfAsync(minAmountPerf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinAmountPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinAmountPerf(long minAmountPerf, int top_, TransactionManager tm_)
		{
			return GetByMinAmountPerf(minAmountPerf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinAmountPerfAsync(long minAmountPerf, int top_, TransactionManager tm_)
		{
			return await GetByMinAmountPerfAsync(minAmountPerf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinAmountPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinAmountPerf(long minAmountPerf, string sort_)
		{
			return GetByMinAmountPerf(minAmountPerf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinAmountPerfAsync(long minAmountPerf, string sort_)
		{
			return await GetByMinAmountPerfAsync(minAmountPerf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MinAmountPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinAmountPerf(long minAmountPerf, string sort_, TransactionManager tm_)
		{
			return GetByMinAmountPerf(minAmountPerf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinAmountPerfAsync(long minAmountPerf, string sort_, TransactionManager tm_)
		{
			return await GetByMinAmountPerfAsync(minAmountPerf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MinAmountPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minAmountPerf">最低业绩数量（含Bonus）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinAmountPerf(long minAmountPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinAmountPerf` = @MinAmountPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinAmountPerf", minAmountPerf, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinAmountPerfAsync(long minAmountPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinAmountPerf` = @MinAmountPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinAmountPerf", minAmountPerf, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		#endregion // GetByMinAmountPerf
		#region GetByMinCashPerf
		
		/// <summary>
		/// 按 MinCashPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinCashPerf(long minCashPerf)
		{
			return GetByMinCashPerf(minCashPerf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinCashPerfAsync(long minCashPerf)
		{
			return await GetByMinCashPerfAsync(minCashPerf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinCashPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinCashPerf(long minCashPerf, TransactionManager tm_)
		{
			return GetByMinCashPerf(minCashPerf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinCashPerfAsync(long minCashPerf, TransactionManager tm_)
		{
			return await GetByMinCashPerfAsync(minCashPerf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinCashPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinCashPerf(long minCashPerf, int top_)
		{
			return GetByMinCashPerf(minCashPerf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinCashPerfAsync(long minCashPerf, int top_)
		{
			return await GetByMinCashPerfAsync(minCashPerf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinCashPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinCashPerf(long minCashPerf, int top_, TransactionManager tm_)
		{
			return GetByMinCashPerf(minCashPerf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinCashPerfAsync(long minCashPerf, int top_, TransactionManager tm_)
		{
			return await GetByMinCashPerfAsync(minCashPerf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinCashPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinCashPerf(long minCashPerf, string sort_)
		{
			return GetByMinCashPerf(minCashPerf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinCashPerfAsync(long minCashPerf, string sort_)
		{
			return await GetByMinCashPerfAsync(minCashPerf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MinCashPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinCashPerf(long minCashPerf, string sort_, TransactionManager tm_)
		{
			return GetByMinCashPerf(minCashPerf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinCashPerfAsync(long minCashPerf, string sort_, TransactionManager tm_)
		{
			return await GetByMinCashPerfAsync(minCashPerf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MinCashPerf（字段） 查询
		/// </summary>
		/// /// <param name = "minCashPerf">最低业绩数量（仅真金）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByMinCashPerf(long minCashPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinCashPerf` = @MinCashPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinCashPerf", minCashPerf, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByMinCashPerfAsync(long minCashPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinCashPerf` = @MinCashPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinCashPerf", minCashPerf, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		#endregion // GetByMinCashPerf
		#region GetByComm
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByComm(double comm)
		{
			return GetByComm(comm, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommAsync(double comm)
		{
			return await GetByCommAsync(comm, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByComm(double comm, TransactionManager tm_)
		{
			return GetByComm(comm, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommAsync(double comm, TransactionManager tm_)
		{
			return await GetByCommAsync(comm, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByComm(double comm, int top_)
		{
			return GetByComm(comm, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommAsync(double comm, int top_)
		{
			return await GetByCommAsync(comm, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByComm(double comm, int top_, TransactionManager tm_)
		{
			return GetByComm(comm, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommAsync(double comm, int top_, TransactionManager tm_)
		{
			return await GetByCommAsync(comm, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByComm(double comm, string sort_)
		{
			return GetByComm(comm, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommAsync(double comm, string sort_)
		{
			return await GetByCommAsync(comm, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByComm(double comm, string sort_, TransactionManager tm_)
		{
			return GetByComm(comm, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommAsync(double comm, string sort_, TransactionManager tm_)
		{
			return await GetByCommAsync(comm, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">返还佣金（每一万有效投注流水返奖值）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_comm_configEO> GetByComm(double comm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Comm` = @Comm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Comm", comm, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_comm_configEO>> GetByCommAsync(double comm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Comm` = @Comm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Comm", comm, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_comm_configEO.MapDataReader);
		}
		#endregion // GetByComm
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
