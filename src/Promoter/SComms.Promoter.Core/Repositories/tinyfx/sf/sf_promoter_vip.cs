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
	/// 推广员vip等级设置
	/// 【表 sf_promoter_vip 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sf_promoter_vipEO : IRowMapper<Sf_promoter_vipEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sf_promoter_vipEO()
		{
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
		
		private int _originalPLevel;
		/// <summary>
		/// 【数据库中的原始主键 PLevel 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalPLevel
		{
			get { return _originalPLevel; }
			set { HasOriginal = true; _originalPLevel = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID },  { "PLevel", PLevel }, };
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
		/// 推广员级别
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int PLevel { get; set; }
		/// <summary>
		/// 需要业绩数
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long NeedPerf { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sf_promoter_vipEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sf_promoter_vipEO MapDataReader(IDataReader reader)
		{
		    Sf_promoter_vipEO ret = new Sf_promoter_vipEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.PLevel = reader.ToInt32("PLevel");
			ret.OriginalPLevel = ret.PLevel;
			ret.NeedPerf = reader.ToInt64("NeedPerf");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 推广员vip等级设置
	/// 【表 sf_promoter_vip 的操作类】
	/// </summary>
	[Obsolete]
	public class Sf_promoter_vipMO : MySqlTableMO<Sf_promoter_vipEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sf_promoter_vip`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sf_promoter_vipMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sf_promoter_vipMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sf_promoter_vipMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sf_promoter_vipEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sf_promoter_vipEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sf_promoter_vipEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `PLevel`, `NeedPerf`) VALUE (@OperatorID, @PLevel, @NeedPerf);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", item.PLevel, MySqlDbType.Int32),
				Database.CreateInParameter("@NeedPerf", item.NeedPerf, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<Sf_promoter_vipEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sf_promoter_vipEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sf_promoter_vipEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `PLevel`, `NeedPerf`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}',{item.PLevel},{item.NeedPerf}),");
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
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, int pLevel, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, pLevel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, int pLevel, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, pLevel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, int pLevel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID AND `PLevel` = @PLevel";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sf_promoter_vipEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.PLevel, tm_);
		}
		public async Task<int> RemoveAsync(Sf_promoter_vipEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, item.PLevel, tm_);
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
		#region RemoveByPLevel
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPLevel(int pLevel, TransactionManager tm_ = null)
		{
			RepairRemoveByPLevelData(pLevel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPLevelAsync(int pLevel, TransactionManager tm_ = null)
		{
			RepairRemoveByPLevelData(pLevel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPLevelData(int pLevel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PLevel` = @PLevel";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32));
		}
		#endregion // RemoveByPLevel
		#region RemoveByNeedPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNeedPerf(long needPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByNeedPerfData(needPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNeedPerfAsync(long needPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByNeedPerfData(needPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNeedPerfData(long needPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NeedPerf` = @NeedPerf";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NeedPerf", needPerf, MySqlDbType.Int64));
		}
		#endregion // RemoveByNeedPerf
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
		public int Put(Sf_promoter_vipEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sf_promoter_vipEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sf_promoter_vipEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `PLevel` = @PLevel, `NeedPerf` = @NeedPerf WHERE `OperatorID` = @OperatorID_Original AND `PLevel` = @PLevel_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", item.PLevel, MySqlDbType.Int32),
				Database.CreateInParameter("@NeedPerf", item.NeedPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel_Original", item.HasOriginal ? item.OriginalPLevel : item.PLevel, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sf_promoter_vipEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sf_promoter_vipEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, int pLevel, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", ConcatValues(values_, operatorID, pLevel));
		}
		public async Task<int> PutByPKAsync(string operatorID, int pLevel, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", ConcatValues(values_, operatorID, pLevel));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, int pLevel, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", tm_, ConcatValues(values_, operatorID, pLevel));
		}
		public async Task<int> PutByPKAsync(string operatorID, int pLevel, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", tm_, ConcatValues(values_, operatorID, pLevel));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, int pLevel, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
	        };
			return Put(set_, "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, int pLevel, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutPLevel
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPLevel(int pLevel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PLevel` = @PLevel";
			var parameter_ = Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPLevelAsync(int pLevel, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PLevel` = @PLevel";
			var parameter_ = Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPLevel
		#region PutNeedPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "pLevel">推广员级别</param>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNeedPerfByPK(string operatorID, int pLevel, long needPerf, TransactionManager tm_ = null)
		{
			RepairPutNeedPerfByPKData(operatorID, pLevel, needPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNeedPerfByPKAsync(string operatorID, int pLevel, long needPerf, TransactionManager tm_ = null)
		{
			RepairPutNeedPerfByPKData(operatorID, pLevel, needPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNeedPerfByPKData(string operatorID, int pLevel, long needPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NeedPerf` = @NeedPerf  WHERE `OperatorID` = @OperatorID AND `PLevel` = @PLevel";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NeedPerf", needPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNeedPerf(long needPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NeedPerf` = @NeedPerf";
			var parameter_ = Database.CreateInParameter("@NeedPerf", needPerf, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNeedPerfAsync(long needPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NeedPerf` = @NeedPerf";
			var parameter_ = Database.CreateInParameter("@NeedPerf", needPerf, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNeedPerf
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sf_promoter_vipEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.PLevel) == null)
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
		public async Task<bool> SetAsync(Sf_promoter_vipEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.PLevel) == null)
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
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sf_promoter_vipEO GetByPK(string operatorID, int pLevel, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, pLevel, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sf_promoter_vipEO.MapDataReader);
		}
		public async Task<Sf_promoter_vipEO> GetByPKAsync(string operatorID, int pLevel, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, pLevel, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sf_promoter_vipEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, int pLevel, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID AND `PLevel` = @PLevel", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string operatorID, int pLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string operatorID, int pLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PLevel（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPLevelByPK(string operatorID, int pLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
			};
			return (int)GetScalar("`PLevel`", "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", paras_, tm_);
		}
		public async Task<int> GetPLevelByPKAsync(string operatorID, int pLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`PLevel`", "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NeedPerf（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetNeedPerfByPK(string operatorID, int pLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
			};
			return (long)GetScalar("`NeedPerf`", "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", paras_, tm_);
		}
		public async Task<long> GetNeedPerfByPKAsync(string operatorID, int pLevel, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`NeedPerf`", "`OperatorID` = @OperatorID AND `PLevel` = @PLevel", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sf_promoter_vipEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sf_promoter_vipEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_vipEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_vipEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_vipEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByPLevel
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByPLevel(int pLevel)
		{
			return GetByPLevel(pLevel, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByPLevelAsync(int pLevel)
		{
			return await GetByPLevelAsync(pLevel, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByPLevel(int pLevel, TransactionManager tm_)
		{
			return GetByPLevel(pLevel, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByPLevelAsync(int pLevel, TransactionManager tm_)
		{
			return await GetByPLevelAsync(pLevel, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByPLevel(int pLevel, int top_)
		{
			return GetByPLevel(pLevel, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByPLevelAsync(int pLevel, int top_)
		{
			return await GetByPLevelAsync(pLevel, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByPLevel(int pLevel, int top_, TransactionManager tm_)
		{
			return GetByPLevel(pLevel, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByPLevelAsync(int pLevel, int top_, TransactionManager tm_)
		{
			return await GetByPLevelAsync(pLevel, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByPLevel(int pLevel, string sort_)
		{
			return GetByPLevel(pLevel, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByPLevelAsync(int pLevel, string sort_)
		{
			return await GetByPLevelAsync(pLevel, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByPLevel(int pLevel, string sort_, TransactionManager tm_)
		{
			return GetByPLevel(pLevel, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByPLevelAsync(int pLevel, string sort_, TransactionManager tm_)
		{
			return await GetByPLevelAsync(pLevel, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByPLevel(int pLevel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PLevel` = @PLevel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_vipEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByPLevelAsync(int pLevel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PLevel` = @PLevel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_vipEO.MapDataReader);
		}
		#endregion // GetByPLevel
		#region GetByNeedPerf
		
		/// <summary>
		/// 按 NeedPerf（字段） 查询
		/// </summary>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByNeedPerf(long needPerf)
		{
			return GetByNeedPerf(needPerf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByNeedPerfAsync(long needPerf)
		{
			return await GetByNeedPerfAsync(needPerf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NeedPerf（字段） 查询
		/// </summary>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByNeedPerf(long needPerf, TransactionManager tm_)
		{
			return GetByNeedPerf(needPerf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByNeedPerfAsync(long needPerf, TransactionManager tm_)
		{
			return await GetByNeedPerfAsync(needPerf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NeedPerf（字段） 查询
		/// </summary>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByNeedPerf(long needPerf, int top_)
		{
			return GetByNeedPerf(needPerf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByNeedPerfAsync(long needPerf, int top_)
		{
			return await GetByNeedPerfAsync(needPerf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NeedPerf（字段） 查询
		/// </summary>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByNeedPerf(long needPerf, int top_, TransactionManager tm_)
		{
			return GetByNeedPerf(needPerf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByNeedPerfAsync(long needPerf, int top_, TransactionManager tm_)
		{
			return await GetByNeedPerfAsync(needPerf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NeedPerf（字段） 查询
		/// </summary>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByNeedPerf(long needPerf, string sort_)
		{
			return GetByNeedPerf(needPerf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByNeedPerfAsync(long needPerf, string sort_)
		{
			return await GetByNeedPerfAsync(needPerf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NeedPerf（字段） 查询
		/// </summary>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByNeedPerf(long needPerf, string sort_, TransactionManager tm_)
		{
			return GetByNeedPerf(needPerf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByNeedPerfAsync(long needPerf, string sort_, TransactionManager tm_)
		{
			return await GetByNeedPerfAsync(needPerf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NeedPerf（字段） 查询
		/// </summary>
		/// /// <param name = "needPerf">需要业绩数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_vipEO> GetByNeedPerf(long needPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NeedPerf` = @NeedPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NeedPerf", needPerf, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_vipEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_vipEO>> GetByNeedPerfAsync(long needPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NeedPerf` = @NeedPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NeedPerf", needPerf, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_vipEO.MapDataReader);
		}
		#endregion // GetByNeedPerf
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
