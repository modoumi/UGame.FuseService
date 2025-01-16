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
	/// 每天推广员邀请的用户的统计信息
	/// 【表 sf_promoter_iuser_day 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sf_promoter_iuser_dayEO : IRowMapper<Sf_promoter_iuser_dayEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sf_promoter_iuser_dayEO()
		{
			this.FromMode = 0;
			this.UserKind = 0;
			this.PromoteTime = DateTime.Now;
			this.DirectNum = 0;
			this.Perf = 0;
			this.ContributionComm = 0;
			this.Income = 0;
			this.DepositAmount = 0;
			this.CashAmount = 0;
			this.BetCashAmount = 0;
			this.WinCashAmount = 0;
			this.BetBonusAmount = 0;
			this.WinBonusAmount = 0;
			this.OtherDepositAmount = 0;
			this.OtherCashAmount = 0;
			this.OtherBetCashAmount = 0;
			this.OtherWinCashAmount = 0;
			this.OtherBetBonusAmount = 0;
			this.OtherWinBonusAmount = 0;
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
		
		private string _originalIUserID;
		/// <summary>
		/// 【数据库中的原始主键 IUserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalIUserID
		{
			get { return _originalIUserID; }
			set { HasOriginal = true; _originalIUserID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DayID", DayID },  { "UserID", UserID },  { "IUserID", IUserID }, };
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
		/// 被邀请用户编码
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 3)]
		public string IUserID { get; set; }
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
		/// 推广时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 8)]
		public DateTime PromoteTime { get; set; }
		/// <summary>
		/// 直属人数（仅当天贡献的）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int DirectNum { get; set; }
		/// <summary>
		/// 业绩（被邀请人+其下级bet总和）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long Perf { get; set; }
		/// <summary>
		/// 贡献的佣金（被邀请人+其下级的总和）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long ContributionComm { get; set; }
		/// <summary>
		/// 总输赢（被邀请人的bet-win）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 12)]
		public long Income { get; set; }
		/// <summary>
		/// 充值（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 13)]
		public long DepositAmount { get; set; }
		/// <summary>
		/// 提现（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 14)]
		public long CashAmount { get; set; }
		/// <summary>
		/// 下注真金（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 15)]
		public long BetCashAmount { get; set; }
		/// <summary>
		/// 返奖真金（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 16)]
		public long WinCashAmount { get; set; }
		/// <summary>
		/// 下注bonus（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 17)]
		public long BetBonusAmount { get; set; }
		/// <summary>
		/// 返奖bonus（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 18)]
		public long WinBonusAmount { get; set; }
		/// <summary>
		/// 充值（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 19)]
		public long OtherDepositAmount { get; set; }
		/// <summary>
		/// 提现（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 20)]
		public long OtherCashAmount { get; set; }
		/// <summary>
		/// 下注真金（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 21)]
		public long OtherBetCashAmount { get; set; }
		/// <summary>
		/// 返奖真金（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 22)]
		public long OtherWinCashAmount { get; set; }
		/// <summary>
		/// 下注bonus（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 23)]
		public long OtherBetBonusAmount { get; set; }
		/// <summary>
		/// 返奖bonus（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 24)]
		public long OtherWinBonusAmount { get; set; }
		/// <summary>
		/// 订单时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 25)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sf_promoter_iuser_dayEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sf_promoter_iuser_dayEO MapDataReader(IDataReader reader)
		{
		    Sf_promoter_iuser_dayEO ret = new Sf_promoter_iuser_dayEO();
			ret.DayID = reader.ToDateTime("DayID");
			ret.OriginalDayID = ret.DayID;
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.IUserID = reader.ToString("IUserID");
			ret.OriginalIUserID = ret.IUserID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.FromMode = reader.ToInt32("FromMode");
			ret.FromId = reader.ToString("FromId");
			ret.UserKind = reader.ToInt32("UserKind");
			ret.PromoteTime = reader.ToDateTime("PromoteTime");
			ret.DirectNum = reader.ToInt32("DirectNum");
			ret.Perf = reader.ToInt64("Perf");
			ret.ContributionComm = reader.ToInt64("ContributionComm");
			ret.Income = reader.ToInt64("Income");
			ret.DepositAmount = reader.ToInt64("DepositAmount");
			ret.CashAmount = reader.ToInt64("CashAmount");
			ret.BetCashAmount = reader.ToInt64("BetCashAmount");
			ret.WinCashAmount = reader.ToInt64("WinCashAmount");
			ret.BetBonusAmount = reader.ToInt64("BetBonusAmount");
			ret.WinBonusAmount = reader.ToInt64("WinBonusAmount");
			ret.OtherDepositAmount = reader.ToInt64("OtherDepositAmount");
			ret.OtherCashAmount = reader.ToInt64("OtherCashAmount");
			ret.OtherBetCashAmount = reader.ToInt64("OtherBetCashAmount");
			ret.OtherWinCashAmount = reader.ToInt64("OtherWinCashAmount");
			ret.OtherBetBonusAmount = reader.ToInt64("OtherBetBonusAmount");
			ret.OtherWinBonusAmount = reader.ToInt64("OtherWinBonusAmount");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 每天推广员邀请的用户的统计信息
	/// 【表 sf_promoter_iuser_day 的操作类】
	/// </summary>
	[Obsolete]
	public class Sf_promoter_iuser_dayMO : MySqlTableMO<Sf_promoter_iuser_dayEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sf_promoter_iuser_day`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sf_promoter_iuser_dayMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sf_promoter_iuser_dayMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sf_promoter_iuser_dayMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sf_promoter_iuser_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sf_promoter_iuser_dayEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sf_promoter_iuser_dayEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DayID`, `UserID`, `IUserID`, `OperatorID`, `FromMode`, `FromId`, `UserKind`, `PromoteTime`, `DirectNum`, `Perf`, `ContributionComm`, `Income`, `DepositAmount`, `CashAmount`, `BetCashAmount`, `WinCashAmount`, `BetBonusAmount`, `WinBonusAmount`, `OtherDepositAmount`, `OtherCashAmount`, `OtherBetCashAmount`, `OtherWinCashAmount`, `OtherBetBonusAmount`, `OtherWinBonusAmount`, `RecDate`) VALUE (@DayID, @UserID, @IUserID, @OperatorID, @FromMode, @FromId, @UserKind, @PromoteTime, @DirectNum, @Perf, @ContributionComm, @Income, @DepositAmount, @CashAmount, @BetCashAmount, @WinCashAmount, @BetBonusAmount, @WinBonusAmount, @OtherDepositAmount, @OtherCashAmount, @OtherBetCashAmount, @OtherWinCashAmount, @OtherBetBonusAmount, @OtherWinBonusAmount, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", item.IUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@PromoteTime", item.PromoteTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@DirectNum", item.DirectNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Perf", item.Perf, MySqlDbType.Int64),
				Database.CreateInParameter("@ContributionComm", item.ContributionComm, MySqlDbType.Int64),
				Database.CreateInParameter("@Income", item.Income, MySqlDbType.Int64),
				Database.CreateInParameter("@DepositAmount", item.DepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashAmount", item.CashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetCashAmount", item.BetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCashAmount", item.WinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonusAmount", item.BetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonusAmount", item.WinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherDepositAmount", item.OtherDepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherCashAmount", item.OtherCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherBetCashAmount", item.OtherBetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherWinCashAmount", item.OtherWinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherBetBonusAmount", item.OtherBetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherWinBonusAmount", item.OtherWinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sf_promoter_iuser_dayEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sf_promoter_iuser_dayEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sf_promoter_iuser_dayEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DayID`, `UserID`, `IUserID`, `OperatorID`, `FromMode`, `FromId`, `UserKind`, `PromoteTime`, `DirectNum`, `Perf`, `ContributionComm`, `Income`, `DepositAmount`, `CashAmount`, `BetCashAmount`, `WinCashAmount`, `BetBonusAmount`, `WinBonusAmount`, `OtherDepositAmount`, `OtherCashAmount`, `OtherBetCashAmount`, `OtherWinCashAmount`, `OtherBetBonusAmount`, `OtherWinBonusAmount`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DayID.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UserID}','{item.IUserID}','{item.OperatorID}',{item.FromMode},'{item.FromId}',{item.UserKind},'{item.PromoteTime.ToString("yyyy-MM-dd HH:mm:ss")}',{item.DirectNum},{item.Perf},{item.ContributionComm},{item.Income},{item.DepositAmount},{item.CashAmount},{item.BetCashAmount},{item.WinCashAmount},{item.BetBonusAmount},{item.WinBonusAmount},{item.OtherDepositAmount},{item.OtherCashAmount},{item.OtherBetCashAmount},{item.OtherWinCashAmount},{item.OtherBetBonusAmount},{item.OtherWinBonusAmount},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, userID, iUserID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(dayID, userID, iUserID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(DateTime dayID, string userID, string iUserID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sf_promoter_iuser_dayEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DayID, item.UserID, item.IUserID, tm_);
		}
		public async Task<int> RemoveAsync(Sf_promoter_iuser_dayEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DayID, item.UserID, item.IUserID, tm_);
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
		#region RemoveByIUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIUserID(string iUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByIUserIDData(iUserID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIUserIDAsync(string iUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByIUserIDData(iUserID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIUserIDData(string iUserID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByIUserID
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
		#region RemoveByPromoteTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPromoteTime(DateTime promoteTime, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoteTimeData(promoteTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPromoteTimeAsync(DateTime promoteTime, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoteTimeData(promoteTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPromoteTimeData(DateTime promoteTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PromoteTime` = @PromoteTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveByPromoteTime
		#region RemoveByDirectNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDirectNum(int directNum, TransactionManager tm_ = null)
		{
			RepairRemoveByDirectNumData(directNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDirectNumAsync(int directNum, TransactionManager tm_ = null)
		{
			RepairRemoveByDirectNumData(directNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDirectNumData(int directNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DirectNum` = @DirectNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DirectNum", directNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByDirectNum
		#region RemoveByPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
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
		#region RemoveByContributionComm
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByContributionComm(long contributionComm, TransactionManager tm_ = null)
		{
			RepairRemoveByContributionCommData(contributionComm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByContributionCommAsync(long contributionComm, TransactionManager tm_ = null)
		{
			RepairRemoveByContributionCommData(contributionComm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByContributionCommData(long contributionComm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ContributionComm` = @ContributionComm";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ContributionComm", contributionComm, MySqlDbType.Int64));
		}
		#endregion // RemoveByContributionComm
		#region RemoveByIncome
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIncome(long income, TransactionManager tm_ = null)
		{
			RepairRemoveByIncomeData(income, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIncomeAsync(long income, TransactionManager tm_ = null)
		{
			RepairRemoveByIncomeData(income, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIncomeData(long income, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Income` = @Income";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Income", income, MySqlDbType.Int64));
		}
		#endregion // RemoveByIncome
		#region RemoveByDepositAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDepositAmount(long depositAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByDepositAmountData(depositAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDepositAmountAsync(long depositAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByDepositAmountData(depositAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDepositAmountData(long depositAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DepositAmount` = @DepositAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DepositAmount", depositAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByDepositAmount
		#region RemoveByCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashAmount(long cashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAmountData(cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashAmountAsync(long cashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAmountData(cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashAmountData(long cashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashAmount` = @CashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByCashAmount
		#region RemoveByBetCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetCashAmount(long betCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetCashAmountData(betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetCashAmountAsync(long betCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetCashAmountData(betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetCashAmountData(long betCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetCashAmount` = @BetCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetCashAmount
		#region RemoveByWinCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinCashAmount(long winCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinCashAmountData(winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinCashAmountAsync(long winCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinCashAmountData(winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinCashAmountData(long winCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinCashAmount` = @WinCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinCashAmount
		#region RemoveByBetBonusAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetBonusAmount(long betBonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusAmountData(betBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetBonusAmountAsync(long betBonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBonusAmountData(betBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetBonusAmountData(long betBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetBonusAmount` = @BetBonusAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonusAmount", betBonusAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetBonusAmount
		#region RemoveByWinBonusAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinBonusAmount(long winBonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusAmountData(winBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinBonusAmountAsync(long winBonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinBonusAmountData(winBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinBonusAmountData(long winBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinBonusAmount` = @WinBonusAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonusAmount", winBonusAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinBonusAmount
		#region RemoveByOtherDepositAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherDepositAmount(long otherDepositAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherDepositAmountData(otherDepositAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherDepositAmountAsync(long otherDepositAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherDepositAmountData(otherDepositAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherDepositAmountData(long otherDepositAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherDepositAmount` = @OtherDepositAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherDepositAmount", otherDepositAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByOtherDepositAmount
		#region RemoveByOtherCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherCashAmount(long otherCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherCashAmountData(otherCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherCashAmountAsync(long otherCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherCashAmountData(otherCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherCashAmountData(long otherCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherCashAmount` = @OtherCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherCashAmount", otherCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByOtherCashAmount
		#region RemoveByOtherBetCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherBetCashAmount(long otherBetCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherBetCashAmountData(otherBetCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherBetCashAmountAsync(long otherBetCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherBetCashAmountData(otherBetCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherBetCashAmountData(long otherBetCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherBetCashAmount` = @OtherBetCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetCashAmount", otherBetCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByOtherBetCashAmount
		#region RemoveByOtherWinCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherWinCashAmount(long otherWinCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherWinCashAmountData(otherWinCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherWinCashAmountAsync(long otherWinCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherWinCashAmountData(otherWinCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherWinCashAmountData(long otherWinCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherWinCashAmount` = @OtherWinCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinCashAmount", otherWinCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByOtherWinCashAmount
		#region RemoveByOtherBetBonusAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherBetBonusAmount(long otherBetBonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherBetBonusAmountData(otherBetBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherBetBonusAmountAsync(long otherBetBonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherBetBonusAmountData(otherBetBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherBetBonusAmountData(long otherBetBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherBetBonusAmount` = @OtherBetBonusAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetBonusAmount", otherBetBonusAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByOtherBetBonusAmount
		#region RemoveByOtherWinBonusAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherWinBonusAmount(long otherWinBonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherWinBonusAmountData(otherWinBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherWinBonusAmountAsync(long otherWinBonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherWinBonusAmountData(otherWinBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherWinBonusAmountData(long otherWinBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherWinBonusAmount` = @OtherWinBonusAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinBonusAmount", otherWinBonusAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByOtherWinBonusAmount
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
		public int Put(Sf_promoter_iuser_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sf_promoter_iuser_dayEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sf_promoter_iuser_dayEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DayID` = @DayID, `UserID` = @UserID, `IUserID` = @IUserID, `OperatorID` = @OperatorID, `FromMode` = @FromMode, `FromId` = @FromId, `UserKind` = @UserKind, `DirectNum` = @DirectNum, `Perf` = @Perf, `ContributionComm` = @ContributionComm, `Income` = @Income, `DepositAmount` = @DepositAmount, `CashAmount` = @CashAmount, `BetCashAmount` = @BetCashAmount, `WinCashAmount` = @WinCashAmount, `BetBonusAmount` = @BetBonusAmount, `WinBonusAmount` = @WinBonusAmount, `OtherDepositAmount` = @OtherDepositAmount, `OtherCashAmount` = @OtherCashAmount, `OtherBetCashAmount` = @OtherBetCashAmount, `OtherWinCashAmount` = @OtherWinCashAmount, `OtherBetBonusAmount` = @OtherBetBonusAmount, `OtherWinBonusAmount` = @OtherWinBonusAmount WHERE `DayID` = @DayID_Original AND `UserID` = @UserID_Original AND `IUserID` = @IUserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", item.IUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@DirectNum", item.DirectNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Perf", item.Perf, MySqlDbType.Int64),
				Database.CreateInParameter("@ContributionComm", item.ContributionComm, MySqlDbType.Int64),
				Database.CreateInParameter("@Income", item.Income, MySqlDbType.Int64),
				Database.CreateInParameter("@DepositAmount", item.DepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashAmount", item.CashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetCashAmount", item.BetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCashAmount", item.WinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonusAmount", item.BetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonusAmount", item.WinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherDepositAmount", item.OtherDepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherCashAmount", item.OtherCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherBetCashAmount", item.OtherBetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherWinCashAmount", item.OtherWinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherBetBonusAmount", item.OtherBetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherWinBonusAmount", item.OtherWinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID_Original", item.HasOriginal ? item.OriginalDayID : item.DayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID_Original", item.HasOriginal ? item.OriginalIUserID : item.IUserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sf_promoter_iuser_dayEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sf_promoter_iuser_dayEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, string iUserID, string set_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", ConcatValues(values_, dayID, userID, iUserID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, string iUserID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", ConcatValues(values_, dayID, userID, iUserID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, string iUserID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", tm_, ConcatValues(values_, dayID, userID, iUserID));
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, string iUserID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", tm_, ConcatValues(values_, dayID, userID, iUserID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(DateTime dayID, string userID, string iUserID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(DateTime dayID, string userID, string iUserID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutIUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIUserID(string iUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IUserID` = @IUserID";
			var parameter_ = Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIUserIDAsync(string iUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IUserID` = @IUserID";
			var parameter_ = Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIUserID
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(DateTime dayID, string userID, string iUserID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, userID, iUserID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(DateTime dayID, string userID, string iUserID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(dayID, userID, iUserID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(DateTime dayID, string userID, string iUserID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
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
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(DateTime dayID, string userID, string iUserID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(dayID, userID, iUserID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(DateTime dayID, string userID, string iUserID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(dayID, userID, iUserID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(DateTime dayID, string userID, string iUserID, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
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
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(DateTime dayID, string userID, string iUserID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(dayID, userID, iUserID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(DateTime dayID, string userID, string iUserID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(dayID, userID, iUserID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(DateTime dayID, string userID, string iUserID, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
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
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(DateTime dayID, string userID, string iUserID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(dayID, userID, iUserID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(DateTime dayID, string userID, string iUserID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(dayID, userID, iUserID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(DateTime dayID, string userID, string iUserID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
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
		#region PutPromoteTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPromoteTimeByPK(DateTime dayID, string userID, string iUserID, DateTime promoteTime, TransactionManager tm_ = null)
		{
			RepairPutPromoteTimeByPKData(dayID, userID, iUserID, promoteTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPromoteTimeByPKAsync(DateTime dayID, string userID, string iUserID, DateTime promoteTime, TransactionManager tm_ = null)
		{
			RepairPutPromoteTimeByPKData(dayID, userID, iUserID, promoteTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPromoteTimeByPKData(DateTime dayID, string userID, string iUserID, DateTime promoteTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PromoteTime` = @PromoteTime  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPromoteTime(DateTime promoteTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoteTime` = @PromoteTime";
			var parameter_ = Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPromoteTimeAsync(DateTime promoteTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoteTime` = @PromoteTime";
			var parameter_ = Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPromoteTime
		#region PutDirectNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDirectNumByPK(DateTime dayID, string userID, string iUserID, int directNum, TransactionManager tm_ = null)
		{
			RepairPutDirectNumByPKData(dayID, userID, iUserID, directNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDirectNumByPKAsync(DateTime dayID, string userID, string iUserID, int directNum, TransactionManager tm_ = null)
		{
			RepairPutDirectNumByPKData(dayID, userID, iUserID, directNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDirectNumByPKData(DateTime dayID, string userID, string iUserID, int directNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DirectNum` = @DirectNum  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DirectNum", directNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDirectNum(int directNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DirectNum` = @DirectNum";
			var parameter_ = Database.CreateInParameter("@DirectNum", directNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDirectNumAsync(int directNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DirectNum` = @DirectNum";
			var parameter_ = Database.CreateInParameter("@DirectNum", directNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDirectNum
		#region PutPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPerfByPK(DateTime dayID, string userID, string iUserID, long perf, TransactionManager tm_ = null)
		{
			RepairPutPerfByPKData(dayID, userID, iUserID, perf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPerfByPKAsync(DateTime dayID, string userID, string iUserID, long perf, TransactionManager tm_ = null)
		{
			RepairPutPerfByPKData(dayID, userID, iUserID, perf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPerfByPKData(DateTime dayID, string userID, string iUserID, long perf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Perf` = @Perf  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Perf", perf, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
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
		#region PutContributionComm
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContributionCommByPK(DateTime dayID, string userID, string iUserID, long contributionComm, TransactionManager tm_ = null)
		{
			RepairPutContributionCommByPKData(dayID, userID, iUserID, contributionComm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutContributionCommByPKAsync(DateTime dayID, string userID, string iUserID, long contributionComm, TransactionManager tm_ = null)
		{
			RepairPutContributionCommByPKData(dayID, userID, iUserID, contributionComm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutContributionCommByPKData(DateTime dayID, string userID, string iUserID, long contributionComm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ContributionComm` = @ContributionComm  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ContributionComm", contributionComm, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContributionComm(long contributionComm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ContributionComm` = @ContributionComm";
			var parameter_ = Database.CreateInParameter("@ContributionComm", contributionComm, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutContributionCommAsync(long contributionComm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ContributionComm` = @ContributionComm";
			var parameter_ = Database.CreateInParameter("@ContributionComm", contributionComm, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutContributionComm
		#region PutIncome
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIncomeByPK(DateTime dayID, string userID, string iUserID, long income, TransactionManager tm_ = null)
		{
			RepairPutIncomeByPKData(dayID, userID, iUserID, income, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIncomeByPKAsync(DateTime dayID, string userID, string iUserID, long income, TransactionManager tm_ = null)
		{
			RepairPutIncomeByPKData(dayID, userID, iUserID, income, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIncomeByPKData(DateTime dayID, string userID, string iUserID, long income, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Income` = @Income  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Income", income, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIncome(long income, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Income` = @Income";
			var parameter_ = Database.CreateInParameter("@Income", income, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIncomeAsync(long income, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Income` = @Income";
			var parameter_ = Database.CreateInParameter("@Income", income, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIncome
		#region PutDepositAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDepositAmountByPK(DateTime dayID, string userID, string iUserID, long depositAmount, TransactionManager tm_ = null)
		{
			RepairPutDepositAmountByPKData(dayID, userID, iUserID, depositAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDepositAmountByPKAsync(DateTime dayID, string userID, string iUserID, long depositAmount, TransactionManager tm_ = null)
		{
			RepairPutDepositAmountByPKData(dayID, userID, iUserID, depositAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDepositAmountByPKData(DateTime dayID, string userID, string iUserID, long depositAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DepositAmount` = @DepositAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DepositAmount", depositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDepositAmount(long depositAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DepositAmount` = @DepositAmount";
			var parameter_ = Database.CreateInParameter("@DepositAmount", depositAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDepositAmountAsync(long depositAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DepositAmount` = @DepositAmount";
			var parameter_ = Database.CreateInParameter("@DepositAmount", depositAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDepositAmount
		#region PutCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAmountByPK(DateTime dayID, string userID, string iUserID, long cashAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAmountByPKData(dayID, userID, iUserID, cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, long cashAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAmountByPKData(dayID, userID, iUserID, cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashAmountByPKData(DateTime dayID, string userID, string iUserID, long cashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAmount(long cashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount";
			var parameter_ = Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashAmountAsync(long cashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount";
			var parameter_ = Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashAmount
		#region PutBetCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCashAmountByPK(DateTime dayID, string userID, string iUserID, long betCashAmount, TransactionManager tm_ = null)
		{
			RepairPutBetCashAmountByPKData(dayID, userID, iUserID, betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, long betCashAmount, TransactionManager tm_ = null)
		{
			RepairPutBetCashAmountByPKData(dayID, userID, iUserID, betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetCashAmountByPKData(DateTime dayID, string userID, string iUserID, long betCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetCashAmount` = @BetCashAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCashAmount(long betCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetCashAmount` = @BetCashAmount";
			var parameter_ = Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetCashAmountAsync(long betCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetCashAmount` = @BetCashAmount";
			var parameter_ = Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetCashAmount
		#region PutWinCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCashAmountByPK(DateTime dayID, string userID, string iUserID, long winCashAmount, TransactionManager tm_ = null)
		{
			RepairPutWinCashAmountByPKData(dayID, userID, iUserID, winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, long winCashAmount, TransactionManager tm_ = null)
		{
			RepairPutWinCashAmountByPKData(dayID, userID, iUserID, winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinCashAmountByPKData(DateTime dayID, string userID, string iUserID, long winCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinCashAmount` = @WinCashAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCashAmount(long winCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinCashAmount` = @WinCashAmount";
			var parameter_ = Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinCashAmountAsync(long winCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinCashAmount` = @WinCashAmount";
			var parameter_ = Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinCashAmount
		#region PutBetBonusAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonusAmountByPK(DateTime dayID, string userID, string iUserID, long betBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBonusAmountByPKData(dayID, userID, iUserID, betBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBonusAmountByPKAsync(DateTime dayID, string userID, string iUserID, long betBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBonusAmountByPKData(dayID, userID, iUserID, betBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBonusAmountByPKData(DateTime dayID, string userID, string iUserID, long betBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBonusAmount` = @BetBonusAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBonusAmount", betBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonusAmount(long betBonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonusAmount` = @BetBonusAmount";
			var parameter_ = Database.CreateInParameter("@BetBonusAmount", betBonusAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetBonusAmountAsync(long betBonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBonusAmount` = @BetBonusAmount";
			var parameter_ = Database.CreateInParameter("@BetBonusAmount", betBonusAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetBonusAmount
		#region PutWinBonusAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonusAmountByPK(DateTime dayID, string userID, string iUserID, long winBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutWinBonusAmountByPKData(dayID, userID, iUserID, winBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinBonusAmountByPKAsync(DateTime dayID, string userID, string iUserID, long winBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutWinBonusAmountByPKData(dayID, userID, iUserID, winBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinBonusAmountByPKData(DateTime dayID, string userID, string iUserID, long winBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinBonusAmount` = @WinBonusAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinBonusAmount", winBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonusAmount(long winBonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonusAmount` = @WinBonusAmount";
			var parameter_ = Database.CreateInParameter("@WinBonusAmount", winBonusAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinBonusAmountAsync(long winBonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinBonusAmount` = @WinBonusAmount";
			var parameter_ = Database.CreateInParameter("@WinBonusAmount", winBonusAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinBonusAmount
		#region PutOtherDepositAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherDepositAmountByPK(DateTime dayID, string userID, string iUserID, long otherDepositAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherDepositAmountByPKData(dayID, userID, iUserID, otherDepositAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherDepositAmountByPKAsync(DateTime dayID, string userID, string iUserID, long otherDepositAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherDepositAmountByPKData(dayID, userID, iUserID, otherDepositAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherDepositAmountByPKData(DateTime dayID, string userID, string iUserID, long otherDepositAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherDepositAmount` = @OtherDepositAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherDepositAmount", otherDepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherDepositAmount(long otherDepositAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherDepositAmount` = @OtherDepositAmount";
			var parameter_ = Database.CreateInParameter("@OtherDepositAmount", otherDepositAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherDepositAmountAsync(long otherDepositAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherDepositAmount` = @OtherDepositAmount";
			var parameter_ = Database.CreateInParameter("@OtherDepositAmount", otherDepositAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherDepositAmount
		#region PutOtherCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherCashAmountByPK(DateTime dayID, string userID, string iUserID, long otherCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherCashAmountByPKData(dayID, userID, iUserID, otherCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, long otherCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherCashAmountByPKData(dayID, userID, iUserID, otherCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherCashAmountByPKData(DateTime dayID, string userID, string iUserID, long otherCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherCashAmount` = @OtherCashAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherCashAmount", otherCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherCashAmount(long otherCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherCashAmount` = @OtherCashAmount";
			var parameter_ = Database.CreateInParameter("@OtherCashAmount", otherCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherCashAmountAsync(long otherCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherCashAmount` = @OtherCashAmount";
			var parameter_ = Database.CreateInParameter("@OtherCashAmount", otherCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherCashAmount
		#region PutOtherBetCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherBetCashAmountByPK(DateTime dayID, string userID, string iUserID, long otherBetCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherBetCashAmountByPKData(dayID, userID, iUserID, otherBetCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherBetCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, long otherBetCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherBetCashAmountByPKData(dayID, userID, iUserID, otherBetCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherBetCashAmountByPKData(DateTime dayID, string userID, string iUserID, long otherBetCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherBetCashAmount` = @OtherBetCashAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherBetCashAmount", otherBetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherBetCashAmount(long otherBetCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherBetCashAmount` = @OtherBetCashAmount";
			var parameter_ = Database.CreateInParameter("@OtherBetCashAmount", otherBetCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherBetCashAmountAsync(long otherBetCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherBetCashAmount` = @OtherBetCashAmount";
			var parameter_ = Database.CreateInParameter("@OtherBetCashAmount", otherBetCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherBetCashAmount
		#region PutOtherWinCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherWinCashAmountByPK(DateTime dayID, string userID, string iUserID, long otherWinCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherWinCashAmountByPKData(dayID, userID, iUserID, otherWinCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherWinCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, long otherWinCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherWinCashAmountByPKData(dayID, userID, iUserID, otherWinCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherWinCashAmountByPKData(DateTime dayID, string userID, string iUserID, long otherWinCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherWinCashAmount` = @OtherWinCashAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherWinCashAmount", otherWinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherWinCashAmount(long otherWinCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherWinCashAmount` = @OtherWinCashAmount";
			var parameter_ = Database.CreateInParameter("@OtherWinCashAmount", otherWinCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherWinCashAmountAsync(long otherWinCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherWinCashAmount` = @OtherWinCashAmount";
			var parameter_ = Database.CreateInParameter("@OtherWinCashAmount", otherWinCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherWinCashAmount
		#region PutOtherBetBonusAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherBetBonusAmountByPK(DateTime dayID, string userID, string iUserID, long otherBetBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherBetBonusAmountByPKData(dayID, userID, iUserID, otherBetBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherBetBonusAmountByPKAsync(DateTime dayID, string userID, string iUserID, long otherBetBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherBetBonusAmountByPKData(dayID, userID, iUserID, otherBetBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherBetBonusAmountByPKData(DateTime dayID, string userID, string iUserID, long otherBetBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherBetBonusAmount` = @OtherBetBonusAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherBetBonusAmount", otherBetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherBetBonusAmount(long otherBetBonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherBetBonusAmount` = @OtherBetBonusAmount";
			var parameter_ = Database.CreateInParameter("@OtherBetBonusAmount", otherBetBonusAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherBetBonusAmountAsync(long otherBetBonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherBetBonusAmount` = @OtherBetBonusAmount";
			var parameter_ = Database.CreateInParameter("@OtherBetBonusAmount", otherBetBonusAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherBetBonusAmount
		#region PutOtherWinBonusAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherWinBonusAmountByPK(DateTime dayID, string userID, string iUserID, long otherWinBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherWinBonusAmountByPKData(dayID, userID, iUserID, otherWinBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherWinBonusAmountByPKAsync(DateTime dayID, string userID, string iUserID, long otherWinBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherWinBonusAmountByPKData(dayID, userID, iUserID, otherWinBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherWinBonusAmountByPKData(DateTime dayID, string userID, string iUserID, long otherWinBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherWinBonusAmount` = @OtherWinBonusAmount  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherWinBonusAmount", otherWinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherWinBonusAmount(long otherWinBonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherWinBonusAmount` = @OtherWinBonusAmount";
			var parameter_ = Database.CreateInParameter("@OtherWinBonusAmount", otherWinBonusAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherWinBonusAmountAsync(long otherWinBonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherWinBonusAmount` = @OtherWinBonusAmount";
			var parameter_ = Database.CreateInParameter("@OtherWinBonusAmount", otherWinBonusAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherWinBonusAmount
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(DateTime dayID, string userID, string iUserID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, userID, iUserID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(DateTime dayID, string userID, string iUserID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(dayID, userID, iUserID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(DateTime dayID, string userID, string iUserID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
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
		public bool Set(Sf_promoter_iuser_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.UserID, item.IUserID) == null)
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
		public async Task<bool> SetAsync(Sf_promoter_iuser_dayEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DayID, item.UserID, item.IUserID) == null)
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
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sf_promoter_iuser_dayEO GetByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, userID, iUserID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<Sf_promoter_iuser_dayEO> GetByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(dayID, userID, iUserID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		private void RepairGetByPKData(DateTime dayID, string userID, string iUserID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 DayID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetDayIDByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`DayID`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<DateTime> GetDayIDByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`DayID`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IUserID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetIUserIDByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`IUserID`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetIUserIDByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`IUserID`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FromMode`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FromMode`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FromId`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FromId`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PromoteTime（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetPromoteTimeByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`PromoteTime`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<DateTime> GetPromoteTimeByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`PromoteTime`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DirectNum（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetDirectNumByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`DirectNum`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<int> GetDirectNumByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`DirectNum`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Perf（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetPerfByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Perf`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetPerfByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Perf`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ContributionComm（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetContributionCommByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`ContributionComm`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetContributionCommByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`ContributionComm`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Income（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetIncomeByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Income`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetIncomeByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Income`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DepositAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetDepositAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`DepositAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetDepositAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`DepositAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCashAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`CashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`CashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetCashAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetCashAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetBetCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinCashAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinCashAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetWinCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetBonusAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBonusAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetBonusAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetBetBonusAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetBonusAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinBonusAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinBonusAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinBonusAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetWinBonusAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinBonusAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherDepositAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherDepositAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherDepositAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetOtherDepositAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherDepositAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherCashAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherCashAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetOtherCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherBetCashAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherBetCashAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherBetCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetOtherBetCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherBetCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherWinCashAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherWinCashAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherWinCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetOtherWinCashAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherWinCashAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherBetBonusAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherBetBonusAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherBetBonusAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetOtherBetBonusAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherBetBonusAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherWinBonusAmount（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherWinBonusAmountByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherWinBonusAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<long> GetOtherWinBonusAmountByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherWinBonusAmount`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(DateTime dayID, string userID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DayID` = @DayID AND `UserID` = @UserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByDayID
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDayID(DateTime dayID)
		{
			return GetByDayID(dayID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDayIDAsync(DateTime dayID)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDayID(DateTime dayID, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDayIDAsync(DateTime dayID, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDayID(DateTime dayID, int top_)
		{
			return GetByDayID(dayID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDayIDAsync(DateTime dayID, int top_)
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
		public List<Sf_promoter_iuser_dayEO> GetByDayID(DateTime dayID, int top_, TransactionManager tm_)
		{
			return GetByDayID(dayID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, TransactionManager tm_)
		{
			return await GetByDayIDAsync(dayID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DayID（字段） 查询
		/// </summary>
		/// /// <param name = "dayID">统计日</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDayID(DateTime dayID, string sort_)
		{
			return GetByDayID(dayID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_)
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
		public List<Sf_promoter_iuser_dayEO> GetByDayID(DateTime dayID, string sort_, TransactionManager tm_)
		{
			return GetByDayID(dayID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDayIDAsync(DateTime dayID, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_iuser_dayEO> GetByDayID(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDayIDAsync(DateTime dayID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DayID` = @DayID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DayID", dayID, MySqlDbType.Date));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByDayID
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Sf_promoter_iuser_dayEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Sf_promoter_iuser_dayEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_iuser_dayEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByIUserID
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIUserID(string iUserID)
		{
			return GetByIUserID(iUserID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIUserIDAsync(string iUserID)
		{
			return await GetByIUserIDAsync(iUserID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIUserID(string iUserID, TransactionManager tm_)
		{
			return GetByIUserID(iUserID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIUserIDAsync(string iUserID, TransactionManager tm_)
		{
			return await GetByIUserIDAsync(iUserID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIUserID(string iUserID, int top_)
		{
			return GetByIUserID(iUserID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIUserIDAsync(string iUserID, int top_)
		{
			return await GetByIUserIDAsync(iUserID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIUserID(string iUserID, int top_, TransactionManager tm_)
		{
			return GetByIUserID(iUserID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIUserIDAsync(string iUserID, int top_, TransactionManager tm_)
		{
			return await GetByIUserIDAsync(iUserID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIUserID(string iUserID, string sort_)
		{
			return GetByIUserID(iUserID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIUserIDAsync(string iUserID, string sort_)
		{
			return await GetByIUserIDAsync(iUserID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIUserID(string iUserID, string sort_, TransactionManager tm_)
		{
			return GetByIUserID(iUserID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIUserIDAsync(string iUserID, string sort_, TransactionManager tm_)
		{
			return await GetByIUserIDAsync(iUserID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIUserID(string iUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IUserID` = @IUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIUserIDAsync(string iUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IUserID` = @IUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByIUserID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sf_promoter_iuser_dayEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sf_promoter_iuser_dayEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_iuser_dayEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromModeAsync(int fromMode, int top_)
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
		public List<Sf_promoter_iuser_dayEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromModeAsync(int fromMode, string sort_)
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
		public List<Sf_promoter_iuser_dayEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_iuser_dayEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromIdAsync(string fromId, int top_)
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
		public List<Sf_promoter_iuser_dayEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromIdAsync(string fromId, string sort_)
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
		public List<Sf_promoter_iuser_dayEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_iuser_dayEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserKindAsync(int userKind, int top_)
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
		public List<Sf_promoter_iuser_dayEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserKindAsync(int userKind, string sort_)
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
		public List<Sf_promoter_iuser_dayEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_iuser_dayEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByPromoteTime
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPromoteTime(DateTime promoteTime)
		{
			return GetByPromoteTime(promoteTime, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPromoteTimeAsync(DateTime promoteTime)
		{
			return await GetByPromoteTimeAsync(promoteTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPromoteTime(DateTime promoteTime, TransactionManager tm_)
		{
			return GetByPromoteTime(promoteTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPromoteTimeAsync(DateTime promoteTime, TransactionManager tm_)
		{
			return await GetByPromoteTimeAsync(promoteTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPromoteTime(DateTime promoteTime, int top_)
		{
			return GetByPromoteTime(promoteTime, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPromoteTimeAsync(DateTime promoteTime, int top_)
		{
			return await GetByPromoteTimeAsync(promoteTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPromoteTime(DateTime promoteTime, int top_, TransactionManager tm_)
		{
			return GetByPromoteTime(promoteTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPromoteTimeAsync(DateTime promoteTime, int top_, TransactionManager tm_)
		{
			return await GetByPromoteTimeAsync(promoteTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPromoteTime(DateTime promoteTime, string sort_)
		{
			return GetByPromoteTime(promoteTime, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPromoteTimeAsync(DateTime promoteTime, string sort_)
		{
			return await GetByPromoteTimeAsync(promoteTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPromoteTime(DateTime promoteTime, string sort_, TransactionManager tm_)
		{
			return GetByPromoteTime(promoteTime, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPromoteTimeAsync(DateTime promoteTime, string sort_, TransactionManager tm_)
		{
			return await GetByPromoteTimeAsync(promoteTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPromoteTime(DateTime promoteTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoteTime` = @PromoteTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPromoteTimeAsync(DateTime promoteTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoteTime` = @PromoteTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByPromoteTime
		#region GetByDirectNum
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDirectNum(int directNum)
		{
			return GetByDirectNum(directNum, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDirectNumAsync(int directNum)
		{
			return await GetByDirectNumAsync(directNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDirectNum(int directNum, TransactionManager tm_)
		{
			return GetByDirectNum(directNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDirectNumAsync(int directNum, TransactionManager tm_)
		{
			return await GetByDirectNumAsync(directNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDirectNum(int directNum, int top_)
		{
			return GetByDirectNum(directNum, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDirectNumAsync(int directNum, int top_)
		{
			return await GetByDirectNumAsync(directNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDirectNum(int directNum, int top_, TransactionManager tm_)
		{
			return GetByDirectNum(directNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDirectNumAsync(int directNum, int top_, TransactionManager tm_)
		{
			return await GetByDirectNumAsync(directNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDirectNum(int directNum, string sort_)
		{
			return GetByDirectNum(directNum, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDirectNumAsync(int directNum, string sort_)
		{
			return await GetByDirectNumAsync(directNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDirectNum(int directNum, string sort_, TransactionManager tm_)
		{
			return GetByDirectNum(directNum, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDirectNumAsync(int directNum, string sort_, TransactionManager tm_)
		{
			return await GetByDirectNumAsync(directNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数（仅当天贡献的）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDirectNum(int directNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DirectNum` = @DirectNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DirectNum", directNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDirectNumAsync(int directNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DirectNum` = @DirectNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DirectNum", directNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByDirectNum
		#region GetByPerf
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPerf(long perf)
		{
			return GetByPerf(perf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPerfAsync(long perf)
		{
			return await GetByPerfAsync(perf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPerf(long perf, TransactionManager tm_)
		{
			return GetByPerf(perf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPerfAsync(long perf, TransactionManager tm_)
		{
			return await GetByPerfAsync(perf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPerf(long perf, int top_)
		{
			return GetByPerf(perf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPerfAsync(long perf, int top_)
		{
			return await GetByPerfAsync(perf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPerf(long perf, int top_, TransactionManager tm_)
		{
			return GetByPerf(perf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPerfAsync(long perf, int top_, TransactionManager tm_)
		{
			return await GetByPerfAsync(perf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPerf(long perf, string sort_)
		{
			return GetByPerf(perf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPerfAsync(long perf, string sort_)
		{
			return await GetByPerfAsync(perf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPerf(long perf, string sort_, TransactionManager tm_)
		{
			return GetByPerf(perf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPerfAsync(long perf, string sort_, TransactionManager tm_)
		{
			return await GetByPerfAsync(perf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Perf（字段） 查询
		/// </summary>
		/// /// <param name = "perf">业绩（被邀请人+其下级bet总和）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByPerf(long perf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Perf` = @Perf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Perf", perf, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByPerfAsync(long perf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Perf` = @Perf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Perf", perf, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByPerf
		#region GetByContributionComm
		
		/// <summary>
		/// 按 ContributionComm（字段） 查询
		/// </summary>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByContributionComm(long contributionComm)
		{
			return GetByContributionComm(contributionComm, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByContributionCommAsync(long contributionComm)
		{
			return await GetByContributionCommAsync(contributionComm, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ContributionComm（字段） 查询
		/// </summary>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByContributionComm(long contributionComm, TransactionManager tm_)
		{
			return GetByContributionComm(contributionComm, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByContributionCommAsync(long contributionComm, TransactionManager tm_)
		{
			return await GetByContributionCommAsync(contributionComm, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ContributionComm（字段） 查询
		/// </summary>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByContributionComm(long contributionComm, int top_)
		{
			return GetByContributionComm(contributionComm, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByContributionCommAsync(long contributionComm, int top_)
		{
			return await GetByContributionCommAsync(contributionComm, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ContributionComm（字段） 查询
		/// </summary>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByContributionComm(long contributionComm, int top_, TransactionManager tm_)
		{
			return GetByContributionComm(contributionComm, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByContributionCommAsync(long contributionComm, int top_, TransactionManager tm_)
		{
			return await GetByContributionCommAsync(contributionComm, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ContributionComm（字段） 查询
		/// </summary>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByContributionComm(long contributionComm, string sort_)
		{
			return GetByContributionComm(contributionComm, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByContributionCommAsync(long contributionComm, string sort_)
		{
			return await GetByContributionCommAsync(contributionComm, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ContributionComm（字段） 查询
		/// </summary>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByContributionComm(long contributionComm, string sort_, TransactionManager tm_)
		{
			return GetByContributionComm(contributionComm, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByContributionCommAsync(long contributionComm, string sort_, TransactionManager tm_)
		{
			return await GetByContributionCommAsync(contributionComm, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ContributionComm（字段） 查询
		/// </summary>
		/// /// <param name = "contributionComm">贡献的佣金（被邀请人+其下级的总和）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByContributionComm(long contributionComm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ContributionComm` = @ContributionComm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ContributionComm", contributionComm, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByContributionCommAsync(long contributionComm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ContributionComm` = @ContributionComm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ContributionComm", contributionComm, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByContributionComm
		#region GetByIncome
		
		/// <summary>
		/// 按 Income（字段） 查询
		/// </summary>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIncome(long income)
		{
			return GetByIncome(income, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIncomeAsync(long income)
		{
			return await GetByIncomeAsync(income, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Income（字段） 查询
		/// </summary>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIncome(long income, TransactionManager tm_)
		{
			return GetByIncome(income, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIncomeAsync(long income, TransactionManager tm_)
		{
			return await GetByIncomeAsync(income, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Income（字段） 查询
		/// </summary>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIncome(long income, int top_)
		{
			return GetByIncome(income, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIncomeAsync(long income, int top_)
		{
			return await GetByIncomeAsync(income, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Income（字段） 查询
		/// </summary>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIncome(long income, int top_, TransactionManager tm_)
		{
			return GetByIncome(income, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIncomeAsync(long income, int top_, TransactionManager tm_)
		{
			return await GetByIncomeAsync(income, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Income（字段） 查询
		/// </summary>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIncome(long income, string sort_)
		{
			return GetByIncome(income, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIncomeAsync(long income, string sort_)
		{
			return await GetByIncomeAsync(income, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Income（字段） 查询
		/// </summary>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIncome(long income, string sort_, TransactionManager tm_)
		{
			return GetByIncome(income, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIncomeAsync(long income, string sort_, TransactionManager tm_)
		{
			return await GetByIncomeAsync(income, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Income（字段） 查询
		/// </summary>
		/// /// <param name = "income">总输赢（被邀请人的bet-win）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByIncome(long income, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Income` = @Income", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Income", income, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByIncomeAsync(long income, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Income` = @Income", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Income", income, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByIncome
		#region GetByDepositAmount
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDepositAmount(long depositAmount)
		{
			return GetByDepositAmount(depositAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDepositAmountAsync(long depositAmount)
		{
			return await GetByDepositAmountAsync(depositAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDepositAmount(long depositAmount, TransactionManager tm_)
		{
			return GetByDepositAmount(depositAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDepositAmountAsync(long depositAmount, TransactionManager tm_)
		{
			return await GetByDepositAmountAsync(depositAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDepositAmount(long depositAmount, int top_)
		{
			return GetByDepositAmount(depositAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDepositAmountAsync(long depositAmount, int top_)
		{
			return await GetByDepositAmountAsync(depositAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDepositAmount(long depositAmount, int top_, TransactionManager tm_)
		{
			return GetByDepositAmount(depositAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDepositAmountAsync(long depositAmount, int top_, TransactionManager tm_)
		{
			return await GetByDepositAmountAsync(depositAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDepositAmount(long depositAmount, string sort_)
		{
			return GetByDepositAmount(depositAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDepositAmountAsync(long depositAmount, string sort_)
		{
			return await GetByDepositAmountAsync(depositAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDepositAmount(long depositAmount, string sort_, TransactionManager tm_)
		{
			return GetByDepositAmount(depositAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDepositAmountAsync(long depositAmount, string sort_, TransactionManager tm_)
		{
			return await GetByDepositAmountAsync(depositAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByDepositAmount(long depositAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DepositAmount` = @DepositAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DepositAmount", depositAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByDepositAmountAsync(long depositAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DepositAmount` = @DepositAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DepositAmount", depositAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByDepositAmount
		#region GetByCashAmount
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByCashAmount(long cashAmount)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByCashAmountAsync(long cashAmount)
		{
			return await GetByCashAmountAsync(cashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByCashAmount(long cashAmount, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByCashAmountAsync(long cashAmount, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByCashAmount(long cashAmount, int top_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByCashAmountAsync(long cashAmount, int top_)
		{
			return await GetByCashAmountAsync(cashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByCashAmount(long cashAmount, int top_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByCashAmountAsync(long cashAmount, int top_, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByCashAmount(long cashAmount, string sort_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByCashAmountAsync(long cashAmount, string sort_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByCashAmount(long cashAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByCashAmountAsync(long cashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByCashAmount(long cashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAmount` = @CashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByCashAmountAsync(long cashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAmount` = @CashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByCashAmount
		#region GetByBetCashAmount
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetCashAmount(long betCashAmount)
		{
			return GetByBetCashAmount(betCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetCashAmountAsync(long betCashAmount)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetCashAmount(long betCashAmount, TransactionManager tm_)
		{
			return GetByBetCashAmount(betCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetCashAmountAsync(long betCashAmount, TransactionManager tm_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetCashAmount(long betCashAmount, int top_)
		{
			return GetByBetCashAmount(betCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetCashAmountAsync(long betCashAmount, int top_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetCashAmount(long betCashAmount, int top_, TransactionManager tm_)
		{
			return GetByBetCashAmount(betCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetCashAmountAsync(long betCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetCashAmount(long betCashAmount, string sort_)
		{
			return GetByBetCashAmount(betCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetCashAmountAsync(long betCashAmount, string sort_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetCashAmount(long betCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetCashAmount(betCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetCashAmountAsync(long betCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetCashAmount(long betCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCashAmount` = @BetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetCashAmountAsync(long betCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCashAmount` = @BetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByBetCashAmount
		#region GetByWinCashAmount
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinCashAmount(long winCashAmount)
		{
			return GetByWinCashAmount(winCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinCashAmountAsync(long winCashAmount)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinCashAmount(long winCashAmount, TransactionManager tm_)
		{
			return GetByWinCashAmount(winCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinCashAmountAsync(long winCashAmount, TransactionManager tm_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinCashAmount(long winCashAmount, int top_)
		{
			return GetByWinCashAmount(winCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinCashAmountAsync(long winCashAmount, int top_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinCashAmount(long winCashAmount, int top_, TransactionManager tm_)
		{
			return GetByWinCashAmount(winCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinCashAmountAsync(long winCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinCashAmount(long winCashAmount, string sort_)
		{
			return GetByWinCashAmount(winCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinCashAmountAsync(long winCashAmount, string sort_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinCashAmount(long winCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinCashAmount(winCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinCashAmountAsync(long winCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinCashAmount(long winCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCashAmount` = @WinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinCashAmountAsync(long winCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCashAmount` = @WinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByWinCashAmount
		#region GetByBetBonusAmount
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetBonusAmount(long betBonusAmount)
		{
			return GetByBetBonusAmount(betBonusAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetBonusAmountAsync(long betBonusAmount)
		{
			return await GetByBetBonusAmountAsync(betBonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetBonusAmount(long betBonusAmount, TransactionManager tm_)
		{
			return GetByBetBonusAmount(betBonusAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetBonusAmountAsync(long betBonusAmount, TransactionManager tm_)
		{
			return await GetByBetBonusAmountAsync(betBonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetBonusAmount(long betBonusAmount, int top_)
		{
			return GetByBetBonusAmount(betBonusAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetBonusAmountAsync(long betBonusAmount, int top_)
		{
			return await GetByBetBonusAmountAsync(betBonusAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetBonusAmount(long betBonusAmount, int top_, TransactionManager tm_)
		{
			return GetByBetBonusAmount(betBonusAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetBonusAmountAsync(long betBonusAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetBonusAmountAsync(betBonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetBonusAmount(long betBonusAmount, string sort_)
		{
			return GetByBetBonusAmount(betBonusAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetBonusAmountAsync(long betBonusAmount, string sort_)
		{
			return await GetByBetBonusAmountAsync(betBonusAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetBonusAmount(long betBonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetBonusAmount(betBonusAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetBonusAmountAsync(long betBonusAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetBonusAmountAsync(betBonusAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByBetBonusAmount(long betBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonusAmount` = @BetBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonusAmount", betBonusAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByBetBonusAmountAsync(long betBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonusAmount` = @BetBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonusAmount", betBonusAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByBetBonusAmount
		#region GetByWinBonusAmount
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinBonusAmount(long winBonusAmount)
		{
			return GetByWinBonusAmount(winBonusAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinBonusAmountAsync(long winBonusAmount)
		{
			return await GetByWinBonusAmountAsync(winBonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinBonusAmount(long winBonusAmount, TransactionManager tm_)
		{
			return GetByWinBonusAmount(winBonusAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinBonusAmountAsync(long winBonusAmount, TransactionManager tm_)
		{
			return await GetByWinBonusAmountAsync(winBonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinBonusAmount(long winBonusAmount, int top_)
		{
			return GetByWinBonusAmount(winBonusAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinBonusAmountAsync(long winBonusAmount, int top_)
		{
			return await GetByWinBonusAmountAsync(winBonusAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinBonusAmount(long winBonusAmount, int top_, TransactionManager tm_)
		{
			return GetByWinBonusAmount(winBonusAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinBonusAmountAsync(long winBonusAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinBonusAmountAsync(winBonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinBonusAmount(long winBonusAmount, string sort_)
		{
			return GetByWinBonusAmount(winBonusAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinBonusAmountAsync(long winBonusAmount, string sort_)
		{
			return await GetByWinBonusAmountAsync(winBonusAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinBonusAmount(long winBonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinBonusAmount(winBonusAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinBonusAmountAsync(long winBonusAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinBonusAmountAsync(winBonusAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByWinBonusAmount(long winBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonusAmount` = @WinBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonusAmount", winBonusAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByWinBonusAmountAsync(long winBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonusAmount` = @WinBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonusAmount", winBonusAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByWinBonusAmount
		#region GetByOtherDepositAmount
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherDepositAmount(long otherDepositAmount)
		{
			return GetByOtherDepositAmount(otherDepositAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherDepositAmountAsync(long otherDepositAmount)
		{
			return await GetByOtherDepositAmountAsync(otherDepositAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherDepositAmount(long otherDepositAmount, TransactionManager tm_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, TransactionManager tm_)
		{
			return await GetByOtherDepositAmountAsync(otherDepositAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherDepositAmount(long otherDepositAmount, int top_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, int top_)
		{
			return await GetByOtherDepositAmountAsync(otherDepositAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherDepositAmount(long otherDepositAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherDepositAmountAsync(otherDepositAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherDepositAmount(long otherDepositAmount, string sort_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, string sort_)
		{
			return await GetByOtherDepositAmountAsync(otherDepositAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherDepositAmount(long otherDepositAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, string sort_, TransactionManager tm_)
		{
			return await GetByOtherDepositAmountAsync(otherDepositAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherDepositAmount(long otherDepositAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherDepositAmount` = @OtherDepositAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherDepositAmount", otherDepositAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherDepositAmount` = @OtherDepositAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherDepositAmount", otherDepositAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByOtherDepositAmount
		#region GetByOtherCashAmount
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherCashAmount(long otherCashAmount)
		{
			return GetByOtherCashAmount(otherCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherCashAmountAsync(long otherCashAmount)
		{
			return await GetByOtherCashAmountAsync(otherCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherCashAmount(long otherCashAmount, TransactionManager tm_)
		{
			return GetByOtherCashAmount(otherCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherCashAmountAsync(long otherCashAmount, TransactionManager tm_)
		{
			return await GetByOtherCashAmountAsync(otherCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherCashAmount(long otherCashAmount, int top_)
		{
			return GetByOtherCashAmount(otherCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherCashAmountAsync(long otherCashAmount, int top_)
		{
			return await GetByOtherCashAmountAsync(otherCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherCashAmount(long otherCashAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherCashAmount(otherCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherCashAmountAsync(long otherCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherCashAmountAsync(otherCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherCashAmount(long otherCashAmount, string sort_)
		{
			return GetByOtherCashAmount(otherCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherCashAmountAsync(long otherCashAmount, string sort_)
		{
			return await GetByOtherCashAmountAsync(otherCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherCashAmount(long otherCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherCashAmount(otherCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherCashAmountAsync(long otherCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByOtherCashAmountAsync(otherCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherCashAmount(long otherCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherCashAmount` = @OtherCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherCashAmount", otherCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherCashAmountAsync(long otherCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherCashAmount` = @OtherCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherCashAmount", otherCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByOtherCashAmount
		#region GetByOtherBetCashAmount
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetCashAmount(long otherBetCashAmount)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount)
		{
			return await GetByOtherBetCashAmountAsync(otherBetCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetCashAmount(long otherBetCashAmount, TransactionManager tm_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, TransactionManager tm_)
		{
			return await GetByOtherBetCashAmountAsync(otherBetCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetCashAmount(long otherBetCashAmount, int top_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, int top_)
		{
			return await GetByOtherBetCashAmountAsync(otherBetCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetCashAmount(long otherBetCashAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherBetCashAmountAsync(otherBetCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetCashAmount(long otherBetCashAmount, string sort_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, string sort_)
		{
			return await GetByOtherBetCashAmountAsync(otherBetCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetCashAmount(long otherBetCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByOtherBetCashAmountAsync(otherBetCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetCashAmount(long otherBetCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetCashAmount` = @OtherBetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetCashAmount", otherBetCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetCashAmount` = @OtherBetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetCashAmount", otherBetCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByOtherBetCashAmount
		#region GetByOtherWinCashAmount
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinCashAmount(long otherWinCashAmount)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount)
		{
			return await GetByOtherWinCashAmountAsync(otherWinCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinCashAmount(long otherWinCashAmount, TransactionManager tm_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, TransactionManager tm_)
		{
			return await GetByOtherWinCashAmountAsync(otherWinCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinCashAmount(long otherWinCashAmount, int top_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, int top_)
		{
			return await GetByOtherWinCashAmountAsync(otherWinCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinCashAmount(long otherWinCashAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherWinCashAmountAsync(otherWinCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinCashAmount(long otherWinCashAmount, string sort_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, string sort_)
		{
			return await GetByOtherWinCashAmountAsync(otherWinCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinCashAmount(long otherWinCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByOtherWinCashAmountAsync(otherWinCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinCashAmount(long otherWinCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherWinCashAmount` = @OtherWinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinCashAmount", otherWinCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherWinCashAmount` = @OtherWinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinCashAmount", otherWinCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByOtherWinCashAmount
		#region GetByOtherBetBonusAmount
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetBonusAmount(long otherBetBonusAmount)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount)
		{
			return await GetByOtherBetBonusAmountAsync(otherBetBonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, TransactionManager tm_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, TransactionManager tm_)
		{
			return await GetByOtherBetBonusAmountAsync(otherBetBonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, int top_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, int top_)
		{
			return await GetByOtherBetBonusAmountAsync(otherBetBonusAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherBetBonusAmountAsync(otherBetBonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, string sort_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, string sort_)
		{
			return await GetByOtherBetBonusAmountAsync(otherBetBonusAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, string sort_, TransactionManager tm_)
		{
			return await GetByOtherBetBonusAmountAsync(otherBetBonusAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetBonusAmount` = @OtherBetBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetBonusAmount", otherBetBonusAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetBonusAmount` = @OtherBetBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetBonusAmount", otherBetBonusAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByOtherBetBonusAmount
		#region GetByOtherWinBonusAmount
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinBonusAmount(long otherWinBonusAmount)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount)
		{
			return await GetByOtherWinBonusAmountAsync(otherWinBonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, TransactionManager tm_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, TransactionManager tm_)
		{
			return await GetByOtherWinBonusAmountAsync(otherWinBonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, int top_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, int top_)
		{
			return await GetByOtherWinBonusAmountAsync(otherWinBonusAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherWinBonusAmountAsync(otherWinBonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, string sort_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, string sort_)
		{
			return await GetByOtherWinBonusAmountAsync(otherWinBonusAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, string sort_, TransactionManager tm_)
		{
			return await GetByOtherWinBonusAmountAsync(otherWinBonusAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherWinBonusAmount` = @OtherWinBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinBonusAmount", otherWinBonusAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherWinBonusAmount` = @OtherWinBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinBonusAmount", otherWinBonusAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByOtherWinBonusAmount
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sf_promoter_iuser_dayEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_iuser_dayEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sf_promoter_iuser_dayEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_iuser_dayEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_iuser_dayEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_iuser_dayEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
