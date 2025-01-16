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
	/// 每天推广员下游戏类别统计
	/// 【表 sf_promoter_ptype_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sf_promoter_ptype_dayEO : IRowMapper<Sf_promoter_ptype_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sf_promoter_ptype_dayEO()
		{
			this.PromoterType = 2;
			this.FromMode = 0;
			this.UserKind = 0;
			this.Perf = 0;
			this.Contributors = 0;
			this.Comm = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private DateTime _originalDayID;
		/// <summary>
		/// 【数据库中的原始主键 DayID 值的副本，用于主键值更新】
		/// </summary>
		public DateTime OriginalDayID
		{
			get { return _originalDayID; }
			set { HasOriginal = true; _originalDayID = value; }
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
		
		private int _originalPromoterType;
		/// <summary>
		/// 【数据库中的原始主键 PromoterType 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalPromoterType
		{
			get { return _originalPromoterType; }
			set { HasOriginal = true; _originalPromoterType = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayID", DayID },  { "UserID", UserID },  { "PromoterType", PromoterType }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 统计日
		/// 【主键 date】
		/// </summary>
		[DataMember(Order = 1)]
		public DateTime DayID { get; set; }
		/// <summary>
		/// 用户编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int PromoterType { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 新用户来源方式
		///              0-获得运营商的新用户(s_operator)
		///              1-推广员获得的新用户（userid）
		///              2-推广渠道通过url获得的新用户（s_channel_url)
		///              3-推广渠道通过code获得的新用户（s_channel_code)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int FromMode { get; set; }
		/// <summary>
		/// 对应的编码（根据FromMode变化）
		///              FromMode=
		///              0-运营商的新用户(s_operator)==> OperatorID
		///              1-推广员获得的新用户（userid） ==> 邀请人的UserID
		///              2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
		///              3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 6)]
		public string FromId { get; set; }
		/// <summary>
		/// 用户类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int UserKind { get; set; }
		/// <summary>
		/// 业绩
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long Perf { get; set; }
		/// <summary>
		/// 贡献者人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int Contributors { get; set; }
		/// <summary>
		/// 佣金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long Comm { get; set; }
		/// <summary>
		/// 订单时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 11)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sf_promoter_ptype_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sf_promoter_ptype_dayEO MapDataReader(IDataReader reader)
		{
		    Sf_promoter_ptype_dayEO ret = new Sf_promoter_ptype_dayEO();
			ret.DayID = reader.ToDateTime("DayID");
			ret.OriginalDayID = ret.DayID;
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.PromoterType = reader.ToInt32("PromoterType");
			ret.OriginalPromoterType = ret.PromoterType;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.FromMode = reader.ToInt32("FromMode");
			ret.FromId = reader.ToString("FromId");
			ret.UserKind = reader.ToInt32("UserKind");
			ret.Perf = reader.ToInt64("Perf");
			ret.Contributors = reader.ToInt32("Contributors");
			ret.Comm = reader.ToInt64("Comm");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 每天推广员下游戏类别统计
	/// 【表 sf_promoter_ptype_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sf_promoter_ptype_dayMO : MySqlTableMO<Sf_promoter_ptype_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sf_promoter_ptype_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sf_promoter_ptype_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sf_promoter_ptype_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sf_promoter_ptype_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sf_promoter_ptype_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sf_promoter_ptype_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sf_promoter_ptype_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayID`, `UserID`, `PromoterType`, `OperatorID`, `FromMode`, `FromId`, `UserKind`, `Perf`, `Contributors`, `Comm`, `RecDate`) VALUE (@DayID, @UserID, @PromoterType, @OperatorID, @FromMode, @FromId, @UserKind, @Perf, @Contributors, @Comm, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", item.PromoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@Perf", item.Perf, MySqlDbType.Int64),
				Database.CreateInParameter("@Contributors", item.Contributors, MySqlDbType.Int32),
				Database.CreateInParameter("@Comm", item.Comm, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sf_promoter_ptype_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sf_promoter_ptype_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sf_promoter_ptype_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayID`, `UserID`, `PromoterType`, `OperatorID`, `FromMode`, `FromId`, `UserKind`, `Perf`, `Contributors`, `Comm`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UserID}',{item.PromoterType},'{item.OperatorID}',{item.FromMode},'{item.FromId}',{item.UserKind},{item.Perf},{item.Contributors},{item.Comm},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, userID, promoterType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, userID, promoterType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayID, string userID, int promoterType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sf_promoter_ptype_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayID, item.UserID, item.PromoterType, tm_);
		}
		public async Task<int> RemoveAsync(Sf_promoter_ptype_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayID, item.UserID, item.PromoterType, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByDayID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			RepairRemoveByDayIDData(dayID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDayIDData(DateTime dayID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
		}
		#endregion // RemoveByDayID
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByFromMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFromMode(int fromMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFromModeData(fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFromModeAsync(int fromMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFromModeData(fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFromModeData(int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FromMode` = @FromMode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
		}
		#endregion // RemoveByFromMode
		#region RemoveByFromId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFromId(string fromId, TransactionManager tm_ = null)
		{
			RepairRemoveByFromIdData(fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFromIdAsync(string fromId, TransactionManager tm_ = null)
		{
			RepairRemoveByFromIdData(fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFromIdData(string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFromId
		#region RemoveByUserKind
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserKind(int userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserKindAsync(int userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserKindData(int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserKind` = @UserKind";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserKind
		#region RemoveByPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "perf">业绩</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPerf(long perf, TransactionManager tm_ = null)
		{
			RepairRemoveByPerfData(perf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPerfAsync(long perf, TransactionManager tm_ = null)
		{
			RepairRemoveByPerfData(perf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPerfData(long perf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Perf` = @Perf";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Perf", perf, MySqlDbType.Int64));
		}
		#endregion // RemoveByPerf
		#region RemoveByContributors
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByContributors(int contributors, TransactionManager tm_ = null)
		{
			RepairRemoveByContributorsData(contributors, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByContributorsAsync(int contributors, TransactionManager tm_ = null)
		{
			RepairRemoveByContributorsData(contributors, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByContributorsData(int contributors, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Contributors` = @Contributors";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Contributors", contributors, MySqlDbType.Int32));
		}
		#endregion // RemoveByContributors
		#region RemoveByComm
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "comm">佣金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByComm(long comm, TransactionManager tm_ = null)
		{
			RepairRemoveByCommData(comm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCommAsync(long comm, TransactionManager tm_ = null)
		{
			RepairRemoveByCommData(comm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCommData(long comm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Comm` = @Comm";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Comm", comm, MySqlDbType.Int64));
		}
		#endregion // RemoveByComm
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
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
		public int Put(Sf_promoter_ptype_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sf_promoter_ptype_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sf_promoter_ptype_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID, `UserID` = @UserID, `PromoterType` = @PromoterType, `OperatorID` = @OperatorID, `FromMode` = @FromMode, `FromId` = @FromId, `UserKind` = @UserKind, `Perf` = @Perf, `Contributors` = @Contributors, `Comm` = @Comm WHERE `DayID` = @DayID_Original AND `UserID` = @UserID_Original AND `PromoterType` = @PromoterType_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", item.PromoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@Perf", item.Perf, MySqlDbType.Int64),
				Database.CreateInParameter("@Contributors", item.Contributors, MySqlDbType.Int32),
				Database.CreateInParameter("@Comm", item.Comm, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID_Original", item.HasOriginal ? item.OriginalDayID : item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType_Original", item.HasOriginal ? item.OriginalPromoterType : item.PromoterType, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sf_promoter_ptype_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sf_promoter_ptype_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, int promoterType, string set_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", ConcatValues(values_, dayID, userID, promoterType));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, int promoterType, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", ConcatValues(values_, dayID, userID, promoterType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, int promoterType, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", tm_, ConcatValues(values_, dayID, userID, promoterType));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, int promoterType, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", tm_, ConcatValues(values_, dayID, userID, promoterType));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, int promoterType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
	        };
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, int promoterType, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutDayID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDayID(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDayIDAsync(DateTime dayID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DayID` = @DayID";
			var parameter_ = Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDayID
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
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(DateTime dayID, string userID, int promoterType, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, userID, promoterType, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(DateTime dayID, string userID, int promoterType, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, userID, promoterType, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(DateTime dayID, string userID, int promoterType, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
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
		#region PutFromMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(DateTime dayID, string userID, int promoterType, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(dayID, userID, promoterType, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(DateTime dayID, string userID, int promoterType, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(dayID, userID, promoterType, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(DateTime dayID, string userID, int promoterType, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromMode(int fromMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode";
			var parameter_ = Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFromModeAsync(int fromMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode";
			var parameter_ = Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFromMode
		#region PutFromId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(DateTime dayID, string userID, int promoterType, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(dayID, userID, promoterType, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(DateTime dayID, string userID, int promoterType, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(dayID, userID, promoterType, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(DateTime dayID, string userID, int promoterType, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromId(string fromId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromId` = @FromId";
			var parameter_ = Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFromIdAsync(string fromId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromId` = @FromId";
			var parameter_ = Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFromId
		#region PutUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(DateTime dayID, string userID, int promoterType, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(dayID, userID, promoterType, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(DateTime dayID, string userID, int promoterType, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(dayID, userID, promoterType, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(DateTime dayID, string userID, int promoterType, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKind(int userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserKindAsync(int userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserKind
		#region PutPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "perf">业绩</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPerfByPK(DateTime dayID, string userID, int promoterType, long perf, TransactionManager tm_ = null)
		{
			RepairPutPerfByPKData(dayID, userID, promoterType, perf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPerfByPKAsync(DateTime dayID, string userID, int promoterType, long perf, TransactionManager tm_ = null)
		{
			RepairPutPerfByPKData(dayID, userID, promoterType, perf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPerfByPKData(DateTime dayID, string userID, int promoterType, long perf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Perf` = @Perf  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Perf", perf, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "perf">业绩</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPerf(long perf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Perf` = @Perf";
			var parameter_ = Database.CreateInParameter("@Perf", perf, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPerfAsync(long perf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Perf` = @Perf";
			var parameter_ = Database.CreateInParameter("@Perf", perf, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPerf
		#region PutContributors
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContributorsByPK(DateTime dayID, string userID, int promoterType, int contributors, TransactionManager tm_ = null)
		{
			RepairPutContributorsByPKData(dayID, userID, promoterType, contributors, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutContributorsByPKAsync(DateTime dayID, string userID, int promoterType, int contributors, TransactionManager tm_ = null)
		{
			RepairPutContributorsByPKData(dayID, userID, promoterType, contributors, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutContributorsByPKData(DateTime dayID, string userID, int promoterType, int contributors, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Contributors` = @Contributors  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Contributors", contributors, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContributors(int contributors, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Contributors` = @Contributors";
			var parameter_ = Database.CreateInParameter("@Contributors", contributors, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutContributorsAsync(int contributors, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Contributors` = @Contributors";
			var parameter_ = Database.CreateInParameter("@Contributors", contributors, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutContributors
		#region PutComm
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "comm">佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCommByPK(DateTime dayID, string userID, int promoterType, long comm, TransactionManager tm_ = null)
		{
			RepairPutCommByPKData(dayID, userID, promoterType, comm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCommByPKAsync(DateTime dayID, string userID, int promoterType, long comm, TransactionManager tm_ = null)
		{
			RepairPutCommByPKData(dayID, userID, promoterType, comm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCommByPKData(DateTime dayID, string userID, int promoterType, long comm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Comm` = @Comm  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Comm", comm, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "comm">佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutComm(long comm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Comm` = @Comm";
			var parameter_ = Database.CreateInParameter("@Comm", comm, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCommAsync(long comm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Comm` = @Comm";
			var parameter_ = Database.CreateInParameter("@Comm", comm, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutComm
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime dayID, string userID, int promoterType, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, userID, promoterType, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime dayID, string userID, int promoterType, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, userID, promoterType, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime dayID, string userID, int promoterType, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
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
		public bool Set(Sf_promoter_ptype_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.UserID, item.PromoterType) == null)
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
		public async Task<bool> SetAsync(Sf_promoter_ptype_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.UserID, item.PromoterType) == null)
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
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sf_promoter_ptype_dayEO GetByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, userID, promoterType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<Sf_promoter_ptype_dayEO> GetByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, userID, promoterType, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayID, string userID, int promoterType, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (DateTime)GetScalar("`DayID`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`UserID`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`UserID`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PromoterType（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPromoterTypeByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`PromoterType`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<int> GetPromoterTypeByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`PromoterType`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`FromMode`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`FromMode`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (string)GetScalar("`FromId`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`FromId`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`UserKind`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`UserKind`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Perf（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPerfByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (long)GetScalar("`Perf`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<long> GetPerfByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`Perf`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Contributors（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetContributorsByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Contributors`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<int> GetContributorsByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Contributors`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Comm（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCommByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (long)GetScalar("`Comm`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<long> GetCommByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`Comm`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (DateTime)GetScalar("`RecDate`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime dayID, string userID, int promoterType, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DayID` = @DayID AND `UserID` = @UserID AND `PromoterType` = @PromoterType", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByDayIDAsync(DateTime dayID, int top_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Sf_promoter_ptype_dayEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Sf_promoter_ptype_dayEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_ptype_dayEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByPromoterType
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPromoterType(int promoterType)
		{
			return GetByPromoterType(promoterType, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPromoterTypeAsync(int promoterType)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPromoterType(int promoterType, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPromoterTypeAsync(int promoterType, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPromoterType(int promoterType, int top_)
		{
			return GetByPromoterType(promoterType, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPromoterTypeAsync(int promoterType, int top_)
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
		public List<Sf_promoter_ptype_dayEO> GetByPromoterType(int promoterType, int top_, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPromoterTypeAsync(int promoterType, int top_, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPromoterType(int promoterType, string sort_)
		{
			return GetByPromoterType(promoterType, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPromoterTypeAsync(int promoterType, string sort_)
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
		public List<Sf_promoter_ptype_dayEO> GetByPromoterType(int promoterType, string sort_, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPromoterTypeAsync(int promoterType, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_ptype_dayEO> GetByPromoterType(int promoterType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoterType` = @PromoterType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPromoterTypeAsync(int promoterType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoterType` = @PromoterType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByPromoterType
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sf_promoter_ptype_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sf_promoter_ptype_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_ptype_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromModeAsync(int fromMode, int top_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromModeAsync(int fromMode, string sort_)
		{
			return await GetByFromModeAsync(fromMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromIdAsync(string fromId, int top_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromIdAsync(string fromId, string sort_)
		{
			return await GetByFromIdAsync(fromId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserKindAsync(int userKind, int top_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserKindAsync(int userKind, string sort_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByPerf
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPerf(long perf)
		{
			return GetByPerf(perf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPerfAsync(long perf)
		{
			return await GetByPerfAsync(perf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPerf(long perf, TransactionManager tm_)
		{
			return GetByPerf(perf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPerfAsync(long perf, TransactionManager tm_)
		{
			return await GetByPerfAsync(perf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPerf(long perf, int top_)
		{
			return GetByPerf(perf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPerfAsync(long perf, int top_)
		{
			return await GetByPerfAsync(perf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPerf(long perf, int top_, TransactionManager tm_)
		{
			return GetByPerf(perf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPerfAsync(long perf, int top_, TransactionManager tm_)
		{
			return await GetByPerfAsync(perf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPerf(long perf, string sort_)
		{
			return GetByPerf(perf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPerfAsync(long perf, string sort_)
		{
			return await GetByPerfAsync(perf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPerf(long perf, string sort_, TransactionManager tm_)
		{
			return GetByPerf(perf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPerfAsync(long perf, string sort_, TransactionManager tm_)
		{
			return await GetByPerfAsync(perf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByPerf(long perf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Perf` = @Perf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Perf", perf, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByPerfAsync(long perf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Perf` = @Perf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Perf", perf, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByPerf
		#region GetByContributors
		
		/// <summary>
		/// 按 Contributors（字段） 查询
		/// </summary>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByContributors(int contributors)
		{
			return GetByContributors(contributors, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByContributorsAsync(int contributors)
		{
			return await GetByContributorsAsync(contributors, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Contributors（字段） 查询
		/// </summary>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByContributors(int contributors, TransactionManager tm_)
		{
			return GetByContributors(contributors, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByContributorsAsync(int contributors, TransactionManager tm_)
		{
			return await GetByContributorsAsync(contributors, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Contributors（字段） 查询
		/// </summary>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByContributors(int contributors, int top_)
		{
			return GetByContributors(contributors, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByContributorsAsync(int contributors, int top_)
		{
			return await GetByContributorsAsync(contributors, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Contributors（字段） 查询
		/// </summary>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByContributors(int contributors, int top_, TransactionManager tm_)
		{
			return GetByContributors(contributors, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByContributorsAsync(int contributors, int top_, TransactionManager tm_)
		{
			return await GetByContributorsAsync(contributors, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Contributors（字段） 查询
		/// </summary>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByContributors(int contributors, string sort_)
		{
			return GetByContributors(contributors, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByContributorsAsync(int contributors, string sort_)
		{
			return await GetByContributorsAsync(contributors, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Contributors（字段） 查询
		/// </summary>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByContributors(int contributors, string sort_, TransactionManager tm_)
		{
			return GetByContributors(contributors, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByContributorsAsync(int contributors, string sort_, TransactionManager tm_)
		{
			return await GetByContributorsAsync(contributors, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Contributors（字段） 查询
		/// </summary>
		/// /// <param name = "contributors">贡献者人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByContributors(int contributors, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Contributors` = @Contributors", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Contributors", contributors, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByContributorsAsync(int contributors, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Contributors` = @Contributors", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Contributors", contributors, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByContributors
		#region GetByComm
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">佣金</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByComm(long comm)
		{
			return GetByComm(comm, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByCommAsync(long comm)
		{
			return await GetByCommAsync(comm, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByComm(long comm, TransactionManager tm_)
		{
			return GetByComm(comm, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByCommAsync(long comm, TransactionManager tm_)
		{
			return await GetByCommAsync(comm, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByComm(long comm, int top_)
		{
			return GetByComm(comm, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByCommAsync(long comm, int top_)
		{
			return await GetByCommAsync(comm, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByComm(long comm, int top_, TransactionManager tm_)
		{
			return GetByComm(comm, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByCommAsync(long comm, int top_, TransactionManager tm_)
		{
			return await GetByCommAsync(comm, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">佣金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByComm(long comm, string sort_)
		{
			return GetByComm(comm, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByCommAsync(long comm, string sort_)
		{
			return await GetByCommAsync(comm, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">佣金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByComm(long comm, string sort_, TransactionManager tm_)
		{
			return GetByComm(comm, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByCommAsync(long comm, string sort_, TransactionManager tm_)
		{
			return await GetByCommAsync(comm, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Comm（字段） 查询
		/// </summary>
		/// /// <param name = "comm">佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByComm(long comm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Comm` = @Comm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Comm", comm, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByCommAsync(long comm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Comm` = @Comm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Comm", comm, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByComm
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_ptype_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_ptype_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_ptype_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
