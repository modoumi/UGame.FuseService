/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-10-30 16: 44:45
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
	/// 推广用户基本信息
	/// 【表 sf_promoter_user 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sf_promoter_userEO : IRowMapper<Sf_promoter_userEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sf_promoter_userEO()
		{
			this.FromMode = 0;
			this.UserKind = 0;
			this.PLevel = 0;
			this.TotalComm = 0;
			this.CollectComm = 0;
			this.LastComm = 0;
			this.DirectNum = 0;
			this.OtherNum = 0;
			this.TotalPerf = 0;
			this.DirectPerf = 0;
			this.OtherPerf = 0;
			this.DepositNum = 0;
			this.DepositAmount = 0;
			this.CashNum = 0;
			this.CashAmount = 0;
			this.BetNum = 0;
			this.BetCashAmount = 0;
			this.WinCashAmount = 0;
			this.BetBonusAmount = 0;
			this.WinBonusAmount = 0;
			this.OtherDepositNum = 0;
			this.OtherDepositAmount = 0;
			this.OtherCashNum = 0;
			this.OtherCashAmount = 0;
			this.OtherBetNum = 0;
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
	        return new Dictionary<string, object>() { { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户编码
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 新用户来源方式
		///              0-获得运营商的新用户(s_operator)
		///              1-推广员获得的新用户（userid）
		///              2-推广渠道通过url获得的新用户（s_channel_url)
		///              3-推广渠道通过code获得的新用户（s_channel_code)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
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
		[DataMember(Order = 4)]
		public string FromId { get; set; }
		/// <summary>
		/// 用户类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int UserKind { get; set; }
		/// <summary>
		/// 推广链接
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 6)]
		public string PUrl { get; set; }
		/// <summary>
		/// 推广员级别
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int PLevel { get; set; }
		/// <summary>
		/// 累计佣金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long TotalComm { get; set; }
		/// <summary>
		/// 已取佣金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long CollectComm { get; set; }
		/// <summary>
		/// 上次领取的佣金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long LastComm { get; set; }
		/// <summary>
		/// 直属人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int DirectNum { get; set; }
		/// <summary>
		/// 其他人数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int OtherNum { get; set; }
		/// <summary>
		/// 总业绩（流水）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 13)]
		public long TotalPerf { get; set; }
		/// <summary>
		/// 直属业绩
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 14)]
		public long DirectPerf { get; set; }
		/// <summary>
		/// 其他业绩
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 15)]
		public long OtherPerf { get; set; }
		/// <summary>
		/// 充值人数（直属）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int DepositNum { get; set; }
		/// <summary>
		/// 充值（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 17)]
		public long DepositAmount { get; set; }
		/// <summary>
		/// 提现人数（直属）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 18)]
		public int CashNum { get; set; }
		/// <summary>
		/// 提现（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 19)]
		public long CashAmount { get; set; }
		/// <summary>
		/// 下注人数（直属）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 20)]
		public int BetNum { get; set; }
		/// <summary>
		/// 下注真金（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 21)]
		public long BetCashAmount { get; set; }
		/// <summary>
		/// 返奖真金（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 22)]
		public long WinCashAmount { get; set; }
		/// <summary>
		/// 下注bonus（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 23)]
		public long BetBonusAmount { get; set; }
		/// <summary>
		/// 返奖bonus（被邀请人）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 24)]
		public long WinBonusAmount { get; set; }
		/// <summary>
		/// 充值人数（其下级）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 25)]
		public int OtherDepositNum { get; set; }
		/// <summary>
		/// 充值（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 26)]
		public long OtherDepositAmount { get; set; }
		/// <summary>
		/// 提现人数（其下级）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 27)]
		public int OtherCashNum { get; set; }
		/// <summary>
		/// 提现（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 28)]
		public long OtherCashAmount { get; set; }
		/// <summary>
		/// 下注人数（其下级）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 29)]
		public int OtherBetNum { get; set; }
		/// <summary>
		/// 下注真金（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 30)]
		public long OtherBetCashAmount { get; set; }
		/// <summary>
		/// 返奖真金（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 31)]
		public long OtherWinCashAmount { get; set; }
		/// <summary>
		/// 下注bonus（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 32)]
		public long OtherBetBonusAmount { get; set; }
		/// <summary>
		/// 返奖bonus（其下级）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 33)]
		public long OtherWinBonusAmount { get; set; }
		/// <summary>
		/// 最后一次更新时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 34)]
		public DateTime LastUpdateTime { get; set; }
		/// <summary>
		/// 订单时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 35)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sf_promoter_userEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sf_promoter_userEO MapDataReader(IDataReader reader)
		{
		    Sf_promoter_userEO ret = new Sf_promoter_userEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.FromMode = reader.ToInt32("FromMode");
			ret.FromId = reader.ToString("FromId");
			ret.UserKind = reader.ToInt32("UserKind");
			ret.PUrl = reader.ToString("PUrl");
			ret.PLevel = reader.ToInt32("PLevel");
			ret.TotalComm = reader.ToInt64("TotalComm");
			ret.CollectComm = reader.ToInt64("CollectComm");
			ret.LastComm = reader.ToInt64("LastComm");
			ret.DirectNum = reader.ToInt32("DirectNum");
			ret.OtherNum = reader.ToInt32("OtherNum");
			ret.TotalPerf = reader.ToInt64("TotalPerf");
			ret.DirectPerf = reader.ToInt64("DirectPerf");
			ret.OtherPerf = reader.ToInt64("OtherPerf");
			ret.DepositNum = reader.ToInt32("DepositNum");
			ret.DepositAmount = reader.ToInt64("DepositAmount");
			ret.CashNum = reader.ToInt32("CashNum");
			ret.CashAmount = reader.ToInt64("CashAmount");
			ret.BetNum = reader.ToInt32("BetNum");
			ret.BetCashAmount = reader.ToInt64("BetCashAmount");
			ret.WinCashAmount = reader.ToInt64("WinCashAmount");
			ret.BetBonusAmount = reader.ToInt64("BetBonusAmount");
			ret.WinBonusAmount = reader.ToInt64("WinBonusAmount");
			ret.OtherDepositNum = reader.ToInt32("OtherDepositNum");
			ret.OtherDepositAmount = reader.ToInt64("OtherDepositAmount");
			ret.OtherCashNum = reader.ToInt32("OtherCashNum");
			ret.OtherCashAmount = reader.ToInt64("OtherCashAmount");
			ret.OtherBetNum = reader.ToInt32("OtherBetNum");
			ret.OtherBetCashAmount = reader.ToInt64("OtherBetCashAmount");
			ret.OtherWinCashAmount = reader.ToInt64("OtherWinCashAmount");
			ret.OtherBetBonusAmount = reader.ToInt64("OtherBetBonusAmount");
			ret.OtherWinBonusAmount = reader.ToInt64("OtherWinBonusAmount");
			ret.LastUpdateTime = reader.ToDateTime("LastUpdateTime");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 推广用户基本信息
	/// 【表 sf_promoter_user 的操作类】
	/// </summary>
	[Obsolete]
	public class Sf_promoter_userMO : MySqlTableMO<Sf_promoter_userEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sf_promoter_user`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sf_promoter_userMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sf_promoter_userMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sf_promoter_userMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sf_promoter_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sf_promoter_userEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sf_promoter_userEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `OperatorID`, `FromMode`, `FromId`, `UserKind`, `PUrl`, `PLevel`, `TotalComm`, `CollectComm`, `LastComm`, `DirectNum`, `OtherNum`, `TotalPerf`, `DirectPerf`, `OtherPerf`, `DepositNum`, `DepositAmount`, `CashNum`, `CashAmount`, `BetNum`, `BetCashAmount`, `WinCashAmount`, `BetBonusAmount`, `WinBonusAmount`, `OtherDepositNum`, `OtherDepositAmount`, `OtherCashNum`, `OtherCashAmount`, `OtherBetNum`, `OtherBetCashAmount`, `OtherWinCashAmount`, `OtherBetBonusAmount`, `OtherWinBonusAmount`, `LastUpdateTime`, `RecDate`) VALUE (@UserID, @OperatorID, @FromMode, @FromId, @UserKind, @PUrl, @PLevel, @TotalComm, @CollectComm, @LastComm, @DirectNum, @OtherNum, @TotalPerf, @DirectPerf, @OtherPerf, @DepositNum, @DepositAmount, @CashNum, @CashAmount, @BetNum, @BetCashAmount, @WinCashAmount, @BetBonusAmount, @WinBonusAmount, @OtherDepositNum, @OtherDepositAmount, @OtherCashNum, @OtherCashAmount, @OtherBetNum, @OtherBetCashAmount, @OtherWinCashAmount, @OtherBetBonusAmount, @OtherWinBonusAmount, @LastUpdateTime, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@PUrl", item.PUrl != null ? item.PUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", item.PLevel, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalComm", item.TotalComm, MySqlDbType.Int64),
				Database.CreateInParameter("@CollectComm", item.CollectComm, MySqlDbType.Int64),
				Database.CreateInParameter("@LastComm", item.LastComm, MySqlDbType.Int64),
				Database.CreateInParameter("@DirectNum", item.DirectNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OtherNum", item.OtherNum, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalPerf", item.TotalPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@DirectPerf", item.DirectPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherPerf", item.OtherPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@DepositNum", item.DepositNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DepositAmount", item.DepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashNum", item.CashNum, MySqlDbType.Int32),
				Database.CreateInParameter("@CashAmount", item.CashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetNum", item.BetNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BetCashAmount", item.BetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCashAmount", item.WinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonusAmount", item.BetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonusAmount", item.WinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherDepositNum", item.OtherDepositNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OtherDepositAmount", item.OtherDepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherCashNum", item.OtherCashNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OtherCashAmount", item.OtherCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherBetNum", item.OtherBetNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OtherBetCashAmount", item.OtherBetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherWinCashAmount", item.OtherWinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherBetBonusAmount", item.OtherBetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherWinBonusAmount", item.OtherWinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LastUpdateTime", item.LastUpdateTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sf_promoter_userEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sf_promoter_userEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sf_promoter_userEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `OperatorID`, `FromMode`, `FromId`, `UserKind`, `PUrl`, `PLevel`, `TotalComm`, `CollectComm`, `LastComm`, `DirectNum`, `OtherNum`, `TotalPerf`, `DirectPerf`, `OtherPerf`, `DepositNum`, `DepositAmount`, `CashNum`, `CashAmount`, `BetNum`, `BetCashAmount`, `WinCashAmount`, `BetBonusAmount`, `WinBonusAmount`, `OtherDepositNum`, `OtherDepositAmount`, `OtherCashNum`, `OtherCashAmount`, `OtherBetNum`, `OtherBetCashAmount`, `OtherWinCashAmount`, `OtherBetBonusAmount`, `OtherWinBonusAmount`, `LastUpdateTime`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}','{item.OperatorID}',{item.FromMode},'{item.FromId}',{item.UserKind},'{item.PUrl}',{item.PLevel},{item.TotalComm},{item.CollectComm},{item.LastComm},{item.DirectNum},{item.OtherNum},{item.TotalPerf},{item.DirectPerf},{item.OtherPerf},{item.DepositNum},{item.DepositAmount},{item.CashNum},{item.CashAmount},{item.BetNum},{item.BetCashAmount},{item.WinCashAmount},{item.BetBonusAmount},{item.WinBonusAmount},{item.OtherDepositNum},{item.OtherDepositAmount},{item.OtherCashNum},{item.OtherCashAmount},{item.OtherBetNum},{item.OtherBetCashAmount},{item.OtherWinCashAmount},{item.OtherBetBonusAmount},{item.OtherWinBonusAmount},'{item.LastUpdateTime.ToString("yyyy-MM-dd HH:mm:ss")}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sf_promoter_userEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Sf_promoter_userEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, tm_);
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
		#region RemoveByPUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "pUrl">推广链接</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPUrl(string pUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByPUrlData(pUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPUrlAsync(string pUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByPUrlData(pUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPUrlData(string pUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (pUrl != null ? "`PUrl` = @PUrl" : "`PUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (pUrl != null)
				paras_.Add(Database.CreateInParameter("@PUrl", pUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPUrl
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
		#region RemoveByTotalComm
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalComm(long totalComm, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCommData(totalComm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalCommAsync(long totalComm, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCommData(totalComm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalCommData(long totalComm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalComm` = @TotalComm";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalComm", totalComm, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalComm
		#region RemoveByCollectComm
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCollectComm(long collectComm, TransactionManager tm_ = null)
		{
			RepairRemoveByCollectCommData(collectComm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCollectCommAsync(long collectComm, TransactionManager tm_ = null)
		{
			RepairRemoveByCollectCommData(collectComm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCollectCommData(long collectComm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CollectComm` = @CollectComm";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CollectComm", collectComm, MySqlDbType.Int64));
		}
		#endregion // RemoveByCollectComm
		#region RemoveByLastComm
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastComm(long lastComm, TransactionManager tm_ = null)
		{
			RepairRemoveByLastCommData(lastComm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastCommAsync(long lastComm, TransactionManager tm_ = null)
		{
			RepairRemoveByLastCommData(lastComm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastCommData(long lastComm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LastComm` = @LastComm";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastComm", lastComm, MySqlDbType.Int64));
		}
		#endregion // RemoveByLastComm
		#region RemoveByDirectNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "directNum">直属人数</param>
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
		#region RemoveByOtherNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherNum">其他人数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherNum(int otherNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherNumData(otherNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherNumAsync(int otherNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherNumData(otherNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherNumData(int otherNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherNum` = @OtherNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherNum", otherNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByOtherNum
		#region RemoveByTotalPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalPerf(long totalPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPerfData(totalPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalPerfAsync(long totalPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPerfData(totalPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalPerfData(long totalPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalPerf` = @TotalPerf";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPerf", totalPerf, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalPerf
		#region RemoveByDirectPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDirectPerf(long directPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByDirectPerfData(directPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDirectPerfAsync(long directPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByDirectPerfData(directPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDirectPerfData(long directPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DirectPerf` = @DirectPerf";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DirectPerf", directPerf, MySqlDbType.Int64));
		}
		#endregion // RemoveByDirectPerf
		#region RemoveByOtherPerf
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherPerf(long otherPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherPerfData(otherPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherPerfAsync(long otherPerf, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherPerfData(otherPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherPerfData(long otherPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherPerf` = @OtherPerf";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherPerf", otherPerf, MySqlDbType.Int64));
		}
		#endregion // RemoveByOtherPerf
		#region RemoveByDepositNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDepositNum(int depositNum, TransactionManager tm_ = null)
		{
			RepairRemoveByDepositNumData(depositNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDepositNumAsync(int depositNum, TransactionManager tm_ = null)
		{
			RepairRemoveByDepositNumData(depositNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDepositNumData(int depositNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DepositNum` = @DepositNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DepositNum", depositNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByDepositNum
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
		#region RemoveByCashNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashNum(int cashNum, TransactionManager tm_ = null)
		{
			RepairRemoveByCashNumData(cashNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashNumAsync(int cashNum, TransactionManager tm_ = null)
		{
			RepairRemoveByCashNumData(cashNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashNumData(int cashNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashNum` = @CashNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashNum", cashNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByCashNum
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
		#region RemoveByBetNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetNum(int betNum, TransactionManager tm_ = null)
		{
			RepairRemoveByBetNumData(betNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetNumAsync(int betNum, TransactionManager tm_ = null)
		{
			RepairRemoveByBetNumData(betNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetNumData(int betNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetNum` = @BetNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetNum", betNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByBetNum
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
		#region RemoveByOtherDepositNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherDepositNum(int otherDepositNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherDepositNumData(otherDepositNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherDepositNumAsync(int otherDepositNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherDepositNumData(otherDepositNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherDepositNumData(int otherDepositNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherDepositNum` = @OtherDepositNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherDepositNum", otherDepositNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByOtherDepositNum
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
		#region RemoveByOtherCashNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherCashNum(int otherCashNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherCashNumData(otherCashNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherCashNumAsync(int otherCashNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherCashNumData(otherCashNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherCashNumData(int otherCashNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherCashNum` = @OtherCashNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherCashNum", otherCashNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByOtherCashNum
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
		#region RemoveByOtherBetNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOtherBetNum(int otherBetNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherBetNumData(otherBetNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOtherBetNumAsync(int otherBetNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOtherBetNumData(otherBetNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOtherBetNumData(int otherBetNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OtherBetNum` = @OtherBetNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetNum", otherBetNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByOtherBetNum
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
		#region RemoveByLastUpdateTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastUpdateTime(DateTime lastUpdateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByLastUpdateTimeData(lastUpdateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastUpdateTimeAsync(DateTime lastUpdateTime, TransactionManager tm_ = null)
		{
			RepairRemoveByLastUpdateTimeData(lastUpdateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastUpdateTimeData(DateTime lastUpdateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LastUpdateTime` = @LastUpdateTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastUpdateTime", lastUpdateTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLastUpdateTime
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
		public int Put(Sf_promoter_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sf_promoter_userEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sf_promoter_userEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `OperatorID` = @OperatorID, `FromMode` = @FromMode, `FromId` = @FromId, `UserKind` = @UserKind, `PUrl` = @PUrl, `PLevel` = @PLevel, `TotalComm` = @TotalComm, `CollectComm` = @CollectComm, `LastComm` = @LastComm, `DirectNum` = @DirectNum, `OtherNum` = @OtherNum, `TotalPerf` = @TotalPerf, `DirectPerf` = @DirectPerf, `OtherPerf` = @OtherPerf, `DepositNum` = @DepositNum, `DepositAmount` = @DepositAmount, `CashNum` = @CashNum, `CashAmount` = @CashAmount, `BetNum` = @BetNum, `BetCashAmount` = @BetCashAmount, `WinCashAmount` = @WinCashAmount, `BetBonusAmount` = @BetBonusAmount, `WinBonusAmount` = @WinBonusAmount, `OtherDepositNum` = @OtherDepositNum, `OtherDepositAmount` = @OtherDepositAmount, `OtherCashNum` = @OtherCashNum, `OtherCashAmount` = @OtherCashAmount, `OtherBetNum` = @OtherBetNum, `OtherBetCashAmount` = @OtherBetCashAmount, `OtherWinCashAmount` = @OtherWinCashAmount, `OtherBetBonusAmount` = @OtherBetBonusAmount, `OtherWinBonusAmount` = @OtherWinBonusAmount, `LastUpdateTime` = @LastUpdateTime WHERE `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@PUrl", item.PUrl != null ? item.PUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PLevel", item.PLevel, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalComm", item.TotalComm, MySqlDbType.Int64),
				Database.CreateInParameter("@CollectComm", item.CollectComm, MySqlDbType.Int64),
				Database.CreateInParameter("@LastComm", item.LastComm, MySqlDbType.Int64),
				Database.CreateInParameter("@DirectNum", item.DirectNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OtherNum", item.OtherNum, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalPerf", item.TotalPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@DirectPerf", item.DirectPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherPerf", item.OtherPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@DepositNum", item.DepositNum, MySqlDbType.Int32),
				Database.CreateInParameter("@DepositAmount", item.DepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@CashNum", item.CashNum, MySqlDbType.Int32),
				Database.CreateInParameter("@CashAmount", item.CashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetNum", item.BetNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BetCashAmount", item.BetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCashAmount", item.WinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetBonusAmount", item.BetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinBonusAmount", item.WinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherDepositNum", item.OtherDepositNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OtherDepositAmount", item.OtherDepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherCashNum", item.OtherCashNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OtherCashAmount", item.OtherCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherBetNum", item.OtherBetNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OtherBetCashAmount", item.OtherBetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherWinCashAmount", item.OtherWinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherBetBonusAmount", item.OtherBetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OtherWinBonusAmount", item.OtherWinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LastUpdateTime", item.LastUpdateTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sf_promoter_userEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sf_promoter_userEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string userID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(string userID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(userID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(string userID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(userID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(string userID, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(string userID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(userID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(string userID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(userID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(string userID, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(string userID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutPUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "pUrl">推广链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUrlByPK(string userID, string pUrl, TransactionManager tm_ = null)
		{
			RepairPutPUrlByPKData(userID, pUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPUrlByPKAsync(string userID, string pUrl, TransactionManager tm_ = null)
		{
			RepairPutPUrlByPKData(userID, pUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPUrlByPKData(string userID, string pUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PUrl` = @PUrl  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUrl", pUrl != null ? pUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "pUrl">推广链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUrl(string pUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUrl` = @PUrl";
			var parameter_ = Database.CreateInParameter("@PUrl", pUrl != null ? pUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPUrlAsync(string pUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUrl` = @PUrl";
			var parameter_ = Database.CreateInParameter("@PUrl", pUrl != null ? pUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPUrl
		#region PutPLevel
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPLevelByPK(string userID, int pLevel, TransactionManager tm_ = null)
		{
			RepairPutPLevelByPKData(userID, pLevel, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPLevelByPKAsync(string userID, int pLevel, TransactionManager tm_ = null)
		{
			RepairPutPLevelByPKData(userID, pLevel, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPLevelByPKData(string userID, int pLevel, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PLevel` = @PLevel  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
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
		#region PutTotalComm
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalCommByPK(string userID, long totalComm, TransactionManager tm_ = null)
		{
			RepairPutTotalCommByPKData(userID, totalComm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalCommByPKAsync(string userID, long totalComm, TransactionManager tm_ = null)
		{
			RepairPutTotalCommByPKData(userID, totalComm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalCommByPKData(string userID, long totalComm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalComm` = @TotalComm  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalComm", totalComm, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalComm(long totalComm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalComm` = @TotalComm";
			var parameter_ = Database.CreateInParameter("@TotalComm", totalComm, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalCommAsync(long totalComm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalComm` = @TotalComm";
			var parameter_ = Database.CreateInParameter("@TotalComm", totalComm, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalComm
		#region PutCollectComm
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCollectCommByPK(string userID, long collectComm, TransactionManager tm_ = null)
		{
			RepairPutCollectCommByPKData(userID, collectComm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCollectCommByPKAsync(string userID, long collectComm, TransactionManager tm_ = null)
		{
			RepairPutCollectCommByPKData(userID, collectComm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCollectCommByPKData(string userID, long collectComm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CollectComm` = @CollectComm  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CollectComm", collectComm, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCollectComm(long collectComm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CollectComm` = @CollectComm";
			var parameter_ = Database.CreateInParameter("@CollectComm", collectComm, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCollectCommAsync(long collectComm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CollectComm` = @CollectComm";
			var parameter_ = Database.CreateInParameter("@CollectComm", collectComm, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCollectComm
		#region PutLastComm
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastCommByPK(string userID, long lastComm, TransactionManager tm_ = null)
		{
			RepairPutLastCommByPKData(userID, lastComm, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastCommByPKAsync(string userID, long lastComm, TransactionManager tm_ = null)
		{
			RepairPutLastCommByPKData(userID, lastComm, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastCommByPKData(string userID, long lastComm, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastComm` = @LastComm  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastComm", lastComm, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastComm(long lastComm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastComm` = @LastComm";
			var parameter_ = Database.CreateInParameter("@LastComm", lastComm, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastCommAsync(long lastComm, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastComm` = @LastComm";
			var parameter_ = Database.CreateInParameter("@LastComm", lastComm, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastComm
		#region PutDirectNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "directNum">直属人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDirectNumByPK(string userID, int directNum, TransactionManager tm_ = null)
		{
			RepairPutDirectNumByPKData(userID, directNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDirectNumByPKAsync(string userID, int directNum, TransactionManager tm_ = null)
		{
			RepairPutDirectNumByPKData(userID, directNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDirectNumByPKData(string userID, int directNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DirectNum` = @DirectNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DirectNum", directNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "directNum">直属人数</param>
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
		#region PutOtherNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherNum">其他人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherNumByPK(string userID, int otherNum, TransactionManager tm_ = null)
		{
			RepairPutOtherNumByPKData(userID, otherNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherNumByPKAsync(string userID, int otherNum, TransactionManager tm_ = null)
		{
			RepairPutOtherNumByPKData(userID, otherNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherNumByPKData(string userID, int otherNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherNum` = @OtherNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherNum", otherNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherNum">其他人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherNum(int otherNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherNum` = @OtherNum";
			var parameter_ = Database.CreateInParameter("@OtherNum", otherNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherNumAsync(int otherNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherNum` = @OtherNum";
			var parameter_ = Database.CreateInParameter("@OtherNum", otherNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherNum
		#region PutTotalPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPerfByPK(string userID, long totalPerf, TransactionManager tm_ = null)
		{
			RepairPutTotalPerfByPKData(userID, totalPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalPerfByPKAsync(string userID, long totalPerf, TransactionManager tm_ = null)
		{
			RepairPutTotalPerfByPKData(userID, totalPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalPerfByPKData(string userID, long totalPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalPerf` = @TotalPerf  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalPerf", totalPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPerf(long totalPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPerf` = @TotalPerf";
			var parameter_ = Database.CreateInParameter("@TotalPerf", totalPerf, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalPerfAsync(long totalPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPerf` = @TotalPerf";
			var parameter_ = Database.CreateInParameter("@TotalPerf", totalPerf, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalPerf
		#region PutDirectPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDirectPerfByPK(string userID, long directPerf, TransactionManager tm_ = null)
		{
			RepairPutDirectPerfByPKData(userID, directPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDirectPerfByPKAsync(string userID, long directPerf, TransactionManager tm_ = null)
		{
			RepairPutDirectPerfByPKData(userID, directPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDirectPerfByPKData(string userID, long directPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DirectPerf` = @DirectPerf  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DirectPerf", directPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDirectPerf(long directPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DirectPerf` = @DirectPerf";
			var parameter_ = Database.CreateInParameter("@DirectPerf", directPerf, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDirectPerfAsync(long directPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DirectPerf` = @DirectPerf";
			var parameter_ = Database.CreateInParameter("@DirectPerf", directPerf, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDirectPerf
		#region PutOtherPerf
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherPerfByPK(string userID, long otherPerf, TransactionManager tm_ = null)
		{
			RepairPutOtherPerfByPKData(userID, otherPerf, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherPerfByPKAsync(string userID, long otherPerf, TransactionManager tm_ = null)
		{
			RepairPutOtherPerfByPKData(userID, otherPerf, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherPerfByPKData(string userID, long otherPerf, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherPerf` = @OtherPerf  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherPerf", otherPerf, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherPerf(long otherPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherPerf` = @OtherPerf";
			var parameter_ = Database.CreateInParameter("@OtherPerf", otherPerf, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherPerfAsync(long otherPerf, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherPerf` = @OtherPerf";
			var parameter_ = Database.CreateInParameter("@OtherPerf", otherPerf, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherPerf
		#region PutDepositNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDepositNumByPK(string userID, int depositNum, TransactionManager tm_ = null)
		{
			RepairPutDepositNumByPKData(userID, depositNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDepositNumByPKAsync(string userID, int depositNum, TransactionManager tm_ = null)
		{
			RepairPutDepositNumByPKData(userID, depositNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDepositNumByPKData(string userID, int depositNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DepositNum` = @DepositNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DepositNum", depositNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDepositNum(int depositNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DepositNum` = @DepositNum";
			var parameter_ = Database.CreateInParameter("@DepositNum", depositNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDepositNumAsync(int depositNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DepositNum` = @DepositNum";
			var parameter_ = Database.CreateInParameter("@DepositNum", depositNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDepositNum
		#region PutDepositAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDepositAmountByPK(string userID, long depositAmount, TransactionManager tm_ = null)
		{
			RepairPutDepositAmountByPKData(userID, depositAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDepositAmountByPKAsync(string userID, long depositAmount, TransactionManager tm_ = null)
		{
			RepairPutDepositAmountByPKData(userID, depositAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDepositAmountByPKData(string userID, long depositAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DepositAmount` = @DepositAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DepositAmount", depositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutCashNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashNumByPK(string userID, int cashNum, TransactionManager tm_ = null)
		{
			RepairPutCashNumByPKData(userID, cashNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashNumByPKAsync(string userID, int cashNum, TransactionManager tm_ = null)
		{
			RepairPutCashNumByPKData(userID, cashNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashNumByPKData(string userID, int cashNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashNum` = @CashNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashNum", cashNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashNum(int cashNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashNum` = @CashNum";
			var parameter_ = Database.CreateInParameter("@CashNum", cashNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashNumAsync(int cashNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashNum` = @CashNum";
			var parameter_ = Database.CreateInParameter("@CashNum", cashNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashNum
		#region PutCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAmountByPK(string userID, long cashAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAmountByPKData(userID, cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashAmountByPKAsync(string userID, long cashAmount, TransactionManager tm_ = null)
		{
			RepairPutCashAmountByPKData(userID, cashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashAmountByPKData(string userID, long cashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashAmount` = @CashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutBetNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetNumByPK(string userID, int betNum, TransactionManager tm_ = null)
		{
			RepairPutBetNumByPKData(userID, betNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetNumByPKAsync(string userID, int betNum, TransactionManager tm_ = null)
		{
			RepairPutBetNumByPKData(userID, betNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetNumByPKData(string userID, int betNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetNum` = @BetNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetNum", betNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetNum(int betNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetNum` = @BetNum";
			var parameter_ = Database.CreateInParameter("@BetNum", betNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetNumAsync(int betNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetNum` = @BetNum";
			var parameter_ = Database.CreateInParameter("@BetNum", betNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetNum
		#region PutBetCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCashAmountByPK(string userID, long betCashAmount, TransactionManager tm_ = null)
		{
			RepairPutBetCashAmountByPKData(userID, betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetCashAmountByPKAsync(string userID, long betCashAmount, TransactionManager tm_ = null)
		{
			RepairPutBetCashAmountByPKData(userID, betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetCashAmountByPKData(string userID, long betCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetCashAmount` = @BetCashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCashAmountByPK(string userID, long winCashAmount, TransactionManager tm_ = null)
		{
			RepairPutWinCashAmountByPKData(userID, winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinCashAmountByPKAsync(string userID, long winCashAmount, TransactionManager tm_ = null)
		{
			RepairPutWinCashAmountByPKData(userID, winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinCashAmountByPKData(string userID, long winCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinCashAmount` = @WinCashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBonusAmountByPK(string userID, long betBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBonusAmountByPKData(userID, betBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBonusAmountByPKAsync(string userID, long betBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBonusAmountByPKData(userID, betBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBonusAmountByPKData(string userID, long betBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBonusAmount` = @BetBonusAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBonusAmount", betBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinBonusAmountByPK(string userID, long winBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutWinBonusAmountByPKData(userID, winBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinBonusAmountByPKAsync(string userID, long winBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutWinBonusAmountByPKData(userID, winBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinBonusAmountByPKData(string userID, long winBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinBonusAmount` = @WinBonusAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinBonusAmount", winBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutOtherDepositNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherDepositNumByPK(string userID, int otherDepositNum, TransactionManager tm_ = null)
		{
			RepairPutOtherDepositNumByPKData(userID, otherDepositNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherDepositNumByPKAsync(string userID, int otherDepositNum, TransactionManager tm_ = null)
		{
			RepairPutOtherDepositNumByPKData(userID, otherDepositNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherDepositNumByPKData(string userID, int otherDepositNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherDepositNum` = @OtherDepositNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherDepositNum", otherDepositNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherDepositNum(int otherDepositNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherDepositNum` = @OtherDepositNum";
			var parameter_ = Database.CreateInParameter("@OtherDepositNum", otherDepositNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherDepositNumAsync(int otherDepositNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherDepositNum` = @OtherDepositNum";
			var parameter_ = Database.CreateInParameter("@OtherDepositNum", otherDepositNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherDepositNum
		#region PutOtherDepositAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherDepositAmountByPK(string userID, long otherDepositAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherDepositAmountByPKData(userID, otherDepositAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherDepositAmountByPKAsync(string userID, long otherDepositAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherDepositAmountByPKData(userID, otherDepositAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherDepositAmountByPKData(string userID, long otherDepositAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherDepositAmount` = @OtherDepositAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherDepositAmount", otherDepositAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutOtherCashNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherCashNumByPK(string userID, int otherCashNum, TransactionManager tm_ = null)
		{
			RepairPutOtherCashNumByPKData(userID, otherCashNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherCashNumByPKAsync(string userID, int otherCashNum, TransactionManager tm_ = null)
		{
			RepairPutOtherCashNumByPKData(userID, otherCashNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherCashNumByPKData(string userID, int otherCashNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherCashNum` = @OtherCashNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherCashNum", otherCashNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherCashNum(int otherCashNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherCashNum` = @OtherCashNum";
			var parameter_ = Database.CreateInParameter("@OtherCashNum", otherCashNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherCashNumAsync(int otherCashNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherCashNum` = @OtherCashNum";
			var parameter_ = Database.CreateInParameter("@OtherCashNum", otherCashNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherCashNum
		#region PutOtherCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherCashAmountByPK(string userID, long otherCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherCashAmountByPKData(userID, otherCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherCashAmountByPKAsync(string userID, long otherCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherCashAmountByPKData(userID, otherCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherCashAmountByPKData(string userID, long otherCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherCashAmount` = @OtherCashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherCashAmount", otherCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutOtherBetNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherBetNumByPK(string userID, int otherBetNum, TransactionManager tm_ = null)
		{
			RepairPutOtherBetNumByPKData(userID, otherBetNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherBetNumByPKAsync(string userID, int otherBetNum, TransactionManager tm_ = null)
		{
			RepairPutOtherBetNumByPKData(userID, otherBetNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherBetNumByPKData(string userID, int otherBetNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherBetNum` = @OtherBetNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherBetNum", otherBetNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherBetNum(int otherBetNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherBetNum` = @OtherBetNum";
			var parameter_ = Database.CreateInParameter("@OtherBetNum", otherBetNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOtherBetNumAsync(int otherBetNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OtherBetNum` = @OtherBetNum";
			var parameter_ = Database.CreateInParameter("@OtherBetNum", otherBetNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOtherBetNum
		#region PutOtherBetCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherBetCashAmountByPK(string userID, long otherBetCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherBetCashAmountByPKData(userID, otherBetCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherBetCashAmountByPKAsync(string userID, long otherBetCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherBetCashAmountByPKData(userID, otherBetCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherBetCashAmountByPKData(string userID, long otherBetCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherBetCashAmount` = @OtherBetCashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherBetCashAmount", otherBetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherWinCashAmountByPK(string userID, long otherWinCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherWinCashAmountByPKData(userID, otherWinCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherWinCashAmountByPKAsync(string userID, long otherWinCashAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherWinCashAmountByPKData(userID, otherWinCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherWinCashAmountByPKData(string userID, long otherWinCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherWinCashAmount` = @OtherWinCashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherWinCashAmount", otherWinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherBetBonusAmountByPK(string userID, long otherBetBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherBetBonusAmountByPKData(userID, otherBetBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherBetBonusAmountByPKAsync(string userID, long otherBetBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherBetBonusAmountByPKData(userID, otherBetBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherBetBonusAmountByPKData(string userID, long otherBetBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherBetBonusAmount` = @OtherBetBonusAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherBetBonusAmount", otherBetBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOtherWinBonusAmountByPK(string userID, long otherWinBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherWinBonusAmountByPKData(userID, otherWinBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOtherWinBonusAmountByPKAsync(string userID, long otherWinBonusAmount, TransactionManager tm_ = null)
		{
			RepairPutOtherWinBonusAmountByPKData(userID, otherWinBonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOtherWinBonusAmountByPKData(string userID, long otherWinBonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OtherWinBonusAmount` = @OtherWinBonusAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OtherWinBonusAmount", otherWinBonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutLastUpdateTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastUpdateTimeByPK(string userID, DateTime lastUpdateTime, TransactionManager tm_ = null)
		{
			RepairPutLastUpdateTimeByPKData(userID, lastUpdateTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastUpdateTimeByPKAsync(string userID, DateTime lastUpdateTime, TransactionManager tm_ = null)
		{
			RepairPutLastUpdateTimeByPKData(userID, lastUpdateTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastUpdateTimeByPKData(string userID, DateTime lastUpdateTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastUpdateTime` = @LastUpdateTime  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastUpdateTime", lastUpdateTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastUpdateTime(DateTime lastUpdateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastUpdateTime` = @LastUpdateTime";
			var parameter_ = Database.CreateInParameter("@LastUpdateTime", lastUpdateTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastUpdateTimeAsync(DateTime lastUpdateTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastUpdateTime` = @LastUpdateTime";
			var parameter_ = Database.CreateInParameter("@LastUpdateTime", lastUpdateTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastUpdateTime
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		public bool Set(Sf_promoter_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		public async Task<bool> SetAsync(Sf_promoter_userEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sf_promoter_userEO GetByPK(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<Sf_promoter_userEO> GetByPKAsync(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FromMode`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FromMode`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FromId`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FromId`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PUrl（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPUrlByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PUrl`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetPUrlByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PUrl`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PLevel（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPLevelByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PLevel`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetPLevelByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PLevel`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalComm（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalCommByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalComm`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalCommByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalComm`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CollectComm（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCollectCommByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`CollectComm`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetCollectCommByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`CollectComm`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastComm（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetLastCommByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`LastComm`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetLastCommByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`LastComm`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DirectNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetDirectNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`DirectNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetDirectNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`DirectNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOtherNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OtherNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetOtherNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OtherNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalPerf（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalPerfByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalPerf`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalPerfByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalPerf`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DirectPerf（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetDirectPerfByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`DirectPerf`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetDirectPerfByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`DirectPerf`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherPerf（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherPerfByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherPerf`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetOtherPerfByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherPerf`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DepositNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetDepositNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`DepositNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetDepositNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`DepositNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DepositAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetDepositAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`DepositAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetDepositAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`DepositAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCashNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CashNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetCashNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CashNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`CashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`CashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBetNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BetNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetBetNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BetNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetCashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBetCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinCashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetWinCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetBonusAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBonusAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetBonusAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBetBonusAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetBonusAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinBonusAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinBonusAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinBonusAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetWinBonusAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinBonusAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherDepositNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOtherDepositNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OtherDepositNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetOtherDepositNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OtherDepositNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherDepositAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherDepositAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherDepositAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetOtherDepositAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherDepositAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherCashNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOtherCashNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OtherCashNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetOtherCashNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OtherCashNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherCashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetOtherCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherBetNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOtherBetNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OtherBetNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetOtherBetNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OtherBetNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherBetCashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherBetCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherBetCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetOtherBetCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherBetCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherWinCashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherWinCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherWinCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetOtherWinCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherWinCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherBetBonusAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherBetBonusAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherBetBonusAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetOtherBetBonusAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherBetBonusAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OtherWinBonusAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetOtherWinBonusAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`OtherWinBonusAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetOtherWinBonusAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`OtherWinBonusAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastUpdateTime（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetLastUpdateTimeByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`LastUpdateTime`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetLastUpdateTimeByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`LastUpdateTime`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sf_promoter_userEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sf_promoter_userEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromModeAsync(int fromMode, int top_)
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
		public List<Sf_promoter_userEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromModeAsync(int fromMode, string sort_)
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
		public List<Sf_promoter_userEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromIdAsync(string fromId, int top_)
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
		public List<Sf_promoter_userEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromIdAsync(string fromId, string sort_)
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
		public List<Sf_promoter_userEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByUserKindAsync(int userKind, int top_)
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
		public List<Sf_promoter_userEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByUserKindAsync(int userKind, string sort_)
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
		public List<Sf_promoter_userEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByPUrl
		
		/// <summary>
		/// 按 PUrl（字段） 查询
		/// </summary>
		/// /// <param name = "pUrl">推广链接</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPUrl(string pUrl)
		{
			return GetByPUrl(pUrl, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPUrlAsync(string pUrl)
		{
			return await GetByPUrlAsync(pUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUrl（字段） 查询
		/// </summary>
		/// /// <param name = "pUrl">推广链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPUrl(string pUrl, TransactionManager tm_)
		{
			return GetByPUrl(pUrl, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPUrlAsync(string pUrl, TransactionManager tm_)
		{
			return await GetByPUrlAsync(pUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUrl（字段） 查询
		/// </summary>
		/// /// <param name = "pUrl">推广链接</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPUrl(string pUrl, int top_)
		{
			return GetByPUrl(pUrl, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPUrlAsync(string pUrl, int top_)
		{
			return await GetByPUrlAsync(pUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUrl（字段） 查询
		/// </summary>
		/// /// <param name = "pUrl">推广链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPUrl(string pUrl, int top_, TransactionManager tm_)
		{
			return GetByPUrl(pUrl, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPUrlAsync(string pUrl, int top_, TransactionManager tm_)
		{
			return await GetByPUrlAsync(pUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUrl（字段） 查询
		/// </summary>
		/// /// <param name = "pUrl">推广链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPUrl(string pUrl, string sort_)
		{
			return GetByPUrl(pUrl, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPUrlAsync(string pUrl, string sort_)
		{
			return await GetByPUrlAsync(pUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PUrl（字段） 查询
		/// </summary>
		/// /// <param name = "pUrl">推广链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPUrl(string pUrl, string sort_, TransactionManager tm_)
		{
			return GetByPUrl(pUrl, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPUrlAsync(string pUrl, string sort_, TransactionManager tm_)
		{
			return await GetByPUrlAsync(pUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PUrl（字段） 查询
		/// </summary>
		/// /// <param name = "pUrl">推广链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPUrl(string pUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(pUrl != null ? "`PUrl` = @PUrl" : "`PUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (pUrl != null)
				paras_.Add(Database.CreateInParameter("@PUrl", pUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPUrlAsync(string pUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(pUrl != null ? "`PUrl` = @PUrl" : "`PUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (pUrl != null)
				paras_.Add(Database.CreateInParameter("@PUrl", pUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByPUrl
		#region GetByPLevel
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPLevel(int pLevel)
		{
			return GetByPLevel(pLevel, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPLevelAsync(int pLevel)
		{
			return await GetByPLevelAsync(pLevel, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPLevel(int pLevel, TransactionManager tm_)
		{
			return GetByPLevel(pLevel, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPLevelAsync(int pLevel, TransactionManager tm_)
		{
			return await GetByPLevelAsync(pLevel, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPLevel(int pLevel, int top_)
		{
			return GetByPLevel(pLevel, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPLevelAsync(int pLevel, int top_)
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
		public List<Sf_promoter_userEO> GetByPLevel(int pLevel, int top_, TransactionManager tm_)
		{
			return GetByPLevel(pLevel, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPLevelAsync(int pLevel, int top_, TransactionManager tm_)
		{
			return await GetByPLevelAsync(pLevel, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PLevel（字段） 查询
		/// </summary>
		/// /// <param name = "pLevel">推广员级别</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByPLevel(int pLevel, string sort_)
		{
			return GetByPLevel(pLevel, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPLevelAsync(int pLevel, string sort_)
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
		public List<Sf_promoter_userEO> GetByPLevel(int pLevel, string sort_, TransactionManager tm_)
		{
			return GetByPLevel(pLevel, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPLevelAsync(int pLevel, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByPLevel(int pLevel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PLevel` = @PLevel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByPLevelAsync(int pLevel, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PLevel` = @PLevel", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PLevel", pLevel, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByPLevel
		#region GetByTotalComm
		
		/// <summary>
		/// 按 TotalComm（字段） 查询
		/// </summary>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalComm(long totalComm)
		{
			return GetByTotalComm(totalComm, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalCommAsync(long totalComm)
		{
			return await GetByTotalCommAsync(totalComm, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalComm（字段） 查询
		/// </summary>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalComm(long totalComm, TransactionManager tm_)
		{
			return GetByTotalComm(totalComm, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalCommAsync(long totalComm, TransactionManager tm_)
		{
			return await GetByTotalCommAsync(totalComm, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalComm（字段） 查询
		/// </summary>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalComm(long totalComm, int top_)
		{
			return GetByTotalComm(totalComm, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalCommAsync(long totalComm, int top_)
		{
			return await GetByTotalCommAsync(totalComm, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalComm（字段） 查询
		/// </summary>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalComm(long totalComm, int top_, TransactionManager tm_)
		{
			return GetByTotalComm(totalComm, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalCommAsync(long totalComm, int top_, TransactionManager tm_)
		{
			return await GetByTotalCommAsync(totalComm, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalComm（字段） 查询
		/// </summary>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalComm(long totalComm, string sort_)
		{
			return GetByTotalComm(totalComm, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalCommAsync(long totalComm, string sort_)
		{
			return await GetByTotalCommAsync(totalComm, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalComm（字段） 查询
		/// </summary>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalComm(long totalComm, string sort_, TransactionManager tm_)
		{
			return GetByTotalComm(totalComm, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalCommAsync(long totalComm, string sort_, TransactionManager tm_)
		{
			return await GetByTotalCommAsync(totalComm, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalComm（字段） 查询
		/// </summary>
		/// /// <param name = "totalComm">累计佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalComm(long totalComm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalComm` = @TotalComm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalComm", totalComm, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalCommAsync(long totalComm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalComm` = @TotalComm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalComm", totalComm, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByTotalComm
		#region GetByCollectComm
		
		/// <summary>
		/// 按 CollectComm（字段） 查询
		/// </summary>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCollectComm(long collectComm)
		{
			return GetByCollectComm(collectComm, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCollectCommAsync(long collectComm)
		{
			return await GetByCollectCommAsync(collectComm, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CollectComm（字段） 查询
		/// </summary>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCollectComm(long collectComm, TransactionManager tm_)
		{
			return GetByCollectComm(collectComm, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCollectCommAsync(long collectComm, TransactionManager tm_)
		{
			return await GetByCollectCommAsync(collectComm, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CollectComm（字段） 查询
		/// </summary>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCollectComm(long collectComm, int top_)
		{
			return GetByCollectComm(collectComm, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCollectCommAsync(long collectComm, int top_)
		{
			return await GetByCollectCommAsync(collectComm, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CollectComm（字段） 查询
		/// </summary>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCollectComm(long collectComm, int top_, TransactionManager tm_)
		{
			return GetByCollectComm(collectComm, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCollectCommAsync(long collectComm, int top_, TransactionManager tm_)
		{
			return await GetByCollectCommAsync(collectComm, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CollectComm（字段） 查询
		/// </summary>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCollectComm(long collectComm, string sort_)
		{
			return GetByCollectComm(collectComm, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCollectCommAsync(long collectComm, string sort_)
		{
			return await GetByCollectCommAsync(collectComm, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CollectComm（字段） 查询
		/// </summary>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCollectComm(long collectComm, string sort_, TransactionManager tm_)
		{
			return GetByCollectComm(collectComm, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCollectCommAsync(long collectComm, string sort_, TransactionManager tm_)
		{
			return await GetByCollectCommAsync(collectComm, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CollectComm（字段） 查询
		/// </summary>
		/// /// <param name = "collectComm">已取佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCollectComm(long collectComm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CollectComm` = @CollectComm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CollectComm", collectComm, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCollectCommAsync(long collectComm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CollectComm` = @CollectComm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CollectComm", collectComm, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByCollectComm
		#region GetByLastComm
		
		/// <summary>
		/// 按 LastComm（字段） 查询
		/// </summary>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastComm(long lastComm)
		{
			return GetByLastComm(lastComm, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastCommAsync(long lastComm)
		{
			return await GetByLastCommAsync(lastComm, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastComm（字段） 查询
		/// </summary>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastComm(long lastComm, TransactionManager tm_)
		{
			return GetByLastComm(lastComm, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastCommAsync(long lastComm, TransactionManager tm_)
		{
			return await GetByLastCommAsync(lastComm, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastComm（字段） 查询
		/// </summary>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastComm(long lastComm, int top_)
		{
			return GetByLastComm(lastComm, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastCommAsync(long lastComm, int top_)
		{
			return await GetByLastCommAsync(lastComm, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastComm（字段） 查询
		/// </summary>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastComm(long lastComm, int top_, TransactionManager tm_)
		{
			return GetByLastComm(lastComm, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastCommAsync(long lastComm, int top_, TransactionManager tm_)
		{
			return await GetByLastCommAsync(lastComm, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastComm（字段） 查询
		/// </summary>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastComm(long lastComm, string sort_)
		{
			return GetByLastComm(lastComm, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastCommAsync(long lastComm, string sort_)
		{
			return await GetByLastCommAsync(lastComm, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastComm（字段） 查询
		/// </summary>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastComm(long lastComm, string sort_, TransactionManager tm_)
		{
			return GetByLastComm(lastComm, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastCommAsync(long lastComm, string sort_, TransactionManager tm_)
		{
			return await GetByLastCommAsync(lastComm, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastComm（字段） 查询
		/// </summary>
		/// /// <param name = "lastComm">上次领取的佣金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastComm(long lastComm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastComm` = @LastComm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastComm", lastComm, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastCommAsync(long lastComm, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastComm` = @LastComm", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastComm", lastComm, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByLastComm
		#region GetByDirectNum
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectNum(int directNum)
		{
			return GetByDirectNum(directNum, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectNumAsync(int directNum)
		{
			return await GetByDirectNumAsync(directNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectNum(int directNum, TransactionManager tm_)
		{
			return GetByDirectNum(directNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectNumAsync(int directNum, TransactionManager tm_)
		{
			return await GetByDirectNumAsync(directNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectNum(int directNum, int top_)
		{
			return GetByDirectNum(directNum, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectNumAsync(int directNum, int top_)
		{
			return await GetByDirectNumAsync(directNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectNum(int directNum, int top_, TransactionManager tm_)
		{
			return GetByDirectNum(directNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectNumAsync(int directNum, int top_, TransactionManager tm_)
		{
			return await GetByDirectNumAsync(directNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectNum(int directNum, string sort_)
		{
			return GetByDirectNum(directNum, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectNumAsync(int directNum, string sort_)
		{
			return await GetByDirectNumAsync(directNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectNum(int directNum, string sort_, TransactionManager tm_)
		{
			return GetByDirectNum(directNum, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectNumAsync(int directNum, string sort_, TransactionManager tm_)
		{
			return await GetByDirectNumAsync(directNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DirectNum（字段） 查询
		/// </summary>
		/// /// <param name = "directNum">直属人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectNum(int directNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DirectNum` = @DirectNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DirectNum", directNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectNumAsync(int directNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DirectNum` = @DirectNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DirectNum", directNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByDirectNum
		#region GetByOtherNum
		
		/// <summary>
		/// 按 OtherNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherNum">其他人数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherNum(int otherNum)
		{
			return GetByOtherNum(otherNum, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherNumAsync(int otherNum)
		{
			return await GetByOtherNumAsync(otherNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherNum">其他人数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherNum(int otherNum, TransactionManager tm_)
		{
			return GetByOtherNum(otherNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherNumAsync(int otherNum, TransactionManager tm_)
		{
			return await GetByOtherNumAsync(otherNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherNum">其他人数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherNum(int otherNum, int top_)
		{
			return GetByOtherNum(otherNum, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherNumAsync(int otherNum, int top_)
		{
			return await GetByOtherNumAsync(otherNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherNum">其他人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherNum(int otherNum, int top_, TransactionManager tm_)
		{
			return GetByOtherNum(otherNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherNumAsync(int otherNum, int top_, TransactionManager tm_)
		{
			return await GetByOtherNumAsync(otherNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherNum">其他人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherNum(int otherNum, string sort_)
		{
			return GetByOtherNum(otherNum, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherNumAsync(int otherNum, string sort_)
		{
			return await GetByOtherNumAsync(otherNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherNum">其他人数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherNum(int otherNum, string sort_, TransactionManager tm_)
		{
			return GetByOtherNum(otherNum, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherNumAsync(int otherNum, string sort_, TransactionManager tm_)
		{
			return await GetByOtherNumAsync(otherNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherNum">其他人数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherNum(int otherNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherNum` = @OtherNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherNum", otherNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherNumAsync(int otherNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherNum` = @OtherNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherNum", otherNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherNum
		#region GetByTotalPerf
		
		/// <summary>
		/// 按 TotalPerf（字段） 查询
		/// </summary>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalPerf(long totalPerf)
		{
			return GetByTotalPerf(totalPerf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalPerfAsync(long totalPerf)
		{
			return await GetByTotalPerfAsync(totalPerf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPerf（字段） 查询
		/// </summary>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalPerf(long totalPerf, TransactionManager tm_)
		{
			return GetByTotalPerf(totalPerf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalPerfAsync(long totalPerf, TransactionManager tm_)
		{
			return await GetByTotalPerfAsync(totalPerf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPerf（字段） 查询
		/// </summary>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalPerf(long totalPerf, int top_)
		{
			return GetByTotalPerf(totalPerf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalPerfAsync(long totalPerf, int top_)
		{
			return await GetByTotalPerfAsync(totalPerf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPerf（字段） 查询
		/// </summary>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalPerf(long totalPerf, int top_, TransactionManager tm_)
		{
			return GetByTotalPerf(totalPerf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalPerfAsync(long totalPerf, int top_, TransactionManager tm_)
		{
			return await GetByTotalPerfAsync(totalPerf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPerf（字段） 查询
		/// </summary>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalPerf(long totalPerf, string sort_)
		{
			return GetByTotalPerf(totalPerf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalPerfAsync(long totalPerf, string sort_)
		{
			return await GetByTotalPerfAsync(totalPerf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalPerf（字段） 查询
		/// </summary>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalPerf(long totalPerf, string sort_, TransactionManager tm_)
		{
			return GetByTotalPerf(totalPerf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalPerfAsync(long totalPerf, string sort_, TransactionManager tm_)
		{
			return await GetByTotalPerfAsync(totalPerf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalPerf（字段） 查询
		/// </summary>
		/// /// <param name = "totalPerf">总业绩（流水）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByTotalPerf(long totalPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPerf` = @TotalPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPerf", totalPerf, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByTotalPerfAsync(long totalPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPerf` = @TotalPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPerf", totalPerf, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByTotalPerf
		#region GetByDirectPerf
		
		/// <summary>
		/// 按 DirectPerf（字段） 查询
		/// </summary>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectPerf(long directPerf)
		{
			return GetByDirectPerf(directPerf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectPerfAsync(long directPerf)
		{
			return await GetByDirectPerfAsync(directPerf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DirectPerf（字段） 查询
		/// </summary>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectPerf(long directPerf, TransactionManager tm_)
		{
			return GetByDirectPerf(directPerf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectPerfAsync(long directPerf, TransactionManager tm_)
		{
			return await GetByDirectPerfAsync(directPerf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DirectPerf（字段） 查询
		/// </summary>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectPerf(long directPerf, int top_)
		{
			return GetByDirectPerf(directPerf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectPerfAsync(long directPerf, int top_)
		{
			return await GetByDirectPerfAsync(directPerf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DirectPerf（字段） 查询
		/// </summary>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectPerf(long directPerf, int top_, TransactionManager tm_)
		{
			return GetByDirectPerf(directPerf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectPerfAsync(long directPerf, int top_, TransactionManager tm_)
		{
			return await GetByDirectPerfAsync(directPerf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DirectPerf（字段） 查询
		/// </summary>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectPerf(long directPerf, string sort_)
		{
			return GetByDirectPerf(directPerf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectPerfAsync(long directPerf, string sort_)
		{
			return await GetByDirectPerfAsync(directPerf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DirectPerf（字段） 查询
		/// </summary>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectPerf(long directPerf, string sort_, TransactionManager tm_)
		{
			return GetByDirectPerf(directPerf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectPerfAsync(long directPerf, string sort_, TransactionManager tm_)
		{
			return await GetByDirectPerfAsync(directPerf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DirectPerf（字段） 查询
		/// </summary>
		/// /// <param name = "directPerf">直属业绩</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDirectPerf(long directPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DirectPerf` = @DirectPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DirectPerf", directPerf, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDirectPerfAsync(long directPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DirectPerf` = @DirectPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DirectPerf", directPerf, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByDirectPerf
		#region GetByOtherPerf
		
		/// <summary>
		/// 按 OtherPerf（字段） 查询
		/// </summary>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherPerf(long otherPerf)
		{
			return GetByOtherPerf(otherPerf, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherPerfAsync(long otherPerf)
		{
			return await GetByOtherPerfAsync(otherPerf, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherPerf（字段） 查询
		/// </summary>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherPerf(long otherPerf, TransactionManager tm_)
		{
			return GetByOtherPerf(otherPerf, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherPerfAsync(long otherPerf, TransactionManager tm_)
		{
			return await GetByOtherPerfAsync(otherPerf, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherPerf（字段） 查询
		/// </summary>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherPerf(long otherPerf, int top_)
		{
			return GetByOtherPerf(otherPerf, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherPerfAsync(long otherPerf, int top_)
		{
			return await GetByOtherPerfAsync(otherPerf, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherPerf（字段） 查询
		/// </summary>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherPerf(long otherPerf, int top_, TransactionManager tm_)
		{
			return GetByOtherPerf(otherPerf, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherPerfAsync(long otherPerf, int top_, TransactionManager tm_)
		{
			return await GetByOtherPerfAsync(otherPerf, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherPerf（字段） 查询
		/// </summary>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherPerf(long otherPerf, string sort_)
		{
			return GetByOtherPerf(otherPerf, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherPerfAsync(long otherPerf, string sort_)
		{
			return await GetByOtherPerfAsync(otherPerf, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherPerf（字段） 查询
		/// </summary>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherPerf(long otherPerf, string sort_, TransactionManager tm_)
		{
			return GetByOtherPerf(otherPerf, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherPerfAsync(long otherPerf, string sort_, TransactionManager tm_)
		{
			return await GetByOtherPerfAsync(otherPerf, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherPerf（字段） 查询
		/// </summary>
		/// /// <param name = "otherPerf">其他业绩</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherPerf(long otherPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherPerf` = @OtherPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherPerf", otherPerf, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherPerfAsync(long otherPerf, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherPerf` = @OtherPerf", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherPerf", otherPerf, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherPerf
		#region GetByDepositNum
		
		/// <summary>
		/// 按 DepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositNum(int depositNum)
		{
			return GetByDepositNum(depositNum, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositNumAsync(int depositNum)
		{
			return await GetByDepositNumAsync(depositNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositNum(int depositNum, TransactionManager tm_)
		{
			return GetByDepositNum(depositNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositNumAsync(int depositNum, TransactionManager tm_)
		{
			return await GetByDepositNumAsync(depositNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositNum(int depositNum, int top_)
		{
			return GetByDepositNum(depositNum, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositNumAsync(int depositNum, int top_)
		{
			return await GetByDepositNumAsync(depositNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositNum(int depositNum, int top_, TransactionManager tm_)
		{
			return GetByDepositNum(depositNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositNumAsync(int depositNum, int top_, TransactionManager tm_)
		{
			return await GetByDepositNumAsync(depositNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositNum(int depositNum, string sort_)
		{
			return GetByDepositNum(depositNum, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositNumAsync(int depositNum, string sort_)
		{
			return await GetByDepositNumAsync(depositNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositNum(int depositNum, string sort_, TransactionManager tm_)
		{
			return GetByDepositNum(depositNum, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositNumAsync(int depositNum, string sort_, TransactionManager tm_)
		{
			return await GetByDepositNumAsync(depositNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "depositNum">充值人数（直属）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositNum(int depositNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DepositNum` = @DepositNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DepositNum", depositNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositNumAsync(int depositNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DepositNum` = @DepositNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DepositNum", depositNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByDepositNum
		#region GetByDepositAmount
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositAmount(long depositAmount)
		{
			return GetByDepositAmount(depositAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositAmountAsync(long depositAmount)
		{
			return await GetByDepositAmountAsync(depositAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositAmount(long depositAmount, TransactionManager tm_)
		{
			return GetByDepositAmount(depositAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositAmountAsync(long depositAmount, TransactionManager tm_)
		{
			return await GetByDepositAmountAsync(depositAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositAmount(long depositAmount, int top_)
		{
			return GetByDepositAmount(depositAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositAmountAsync(long depositAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByDepositAmount(long depositAmount, int top_, TransactionManager tm_)
		{
			return GetByDepositAmount(depositAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositAmountAsync(long depositAmount, int top_, TransactionManager tm_)
		{
			return await GetByDepositAmountAsync(depositAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "depositAmount">充值（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByDepositAmount(long depositAmount, string sort_)
		{
			return GetByDepositAmount(depositAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositAmountAsync(long depositAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByDepositAmount(long depositAmount, string sort_, TransactionManager tm_)
		{
			return GetByDepositAmount(depositAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositAmountAsync(long depositAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByDepositAmount(long depositAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DepositAmount` = @DepositAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DepositAmount", depositAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByDepositAmountAsync(long depositAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`DepositAmount` = @DepositAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@DepositAmount", depositAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByDepositAmount
		#region GetByCashNum
		
		/// <summary>
		/// 按 CashNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashNum(int cashNum)
		{
			return GetByCashNum(cashNum, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashNumAsync(int cashNum)
		{
			return await GetByCashNumAsync(cashNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashNum(int cashNum, TransactionManager tm_)
		{
			return GetByCashNum(cashNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashNumAsync(int cashNum, TransactionManager tm_)
		{
			return await GetByCashNumAsync(cashNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashNum(int cashNum, int top_)
		{
			return GetByCashNum(cashNum, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashNumAsync(int cashNum, int top_)
		{
			return await GetByCashNumAsync(cashNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashNum(int cashNum, int top_, TransactionManager tm_)
		{
			return GetByCashNum(cashNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashNumAsync(int cashNum, int top_, TransactionManager tm_)
		{
			return await GetByCashNumAsync(cashNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashNum(int cashNum, string sort_)
		{
			return GetByCashNum(cashNum, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashNumAsync(int cashNum, string sort_)
		{
			return await GetByCashNumAsync(cashNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashNum(int cashNum, string sort_, TransactionManager tm_)
		{
			return GetByCashNum(cashNum, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashNumAsync(int cashNum, string sort_, TransactionManager tm_)
		{
			return await GetByCashNumAsync(cashNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashNum（字段） 查询
		/// </summary>
		/// /// <param name = "cashNum">提现人数（直属）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashNum(int cashNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashNum` = @CashNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashNum", cashNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashNumAsync(int cashNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashNum` = @CashNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashNum", cashNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByCashNum
		#region GetByCashAmount
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashAmount(long cashAmount)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashAmountAsync(long cashAmount)
		{
			return await GetByCashAmountAsync(cashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashAmount(long cashAmount, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashAmountAsync(long cashAmount, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashAmount(long cashAmount, int top_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashAmountAsync(long cashAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByCashAmount(long cashAmount, int top_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashAmountAsync(long cashAmount, int top_, TransactionManager tm_)
		{
			return await GetByCashAmountAsync(cashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "cashAmount">提现（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByCashAmount(long cashAmount, string sort_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashAmountAsync(long cashAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByCashAmount(long cashAmount, string sort_, TransactionManager tm_)
		{
			return GetByCashAmount(cashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashAmountAsync(long cashAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByCashAmount(long cashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAmount` = @CashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByCashAmountAsync(long cashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAmount` = @CashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAmount", cashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByCashAmount
		#region GetByBetNum
		
		/// <summary>
		/// 按 BetNum（字段） 查询
		/// </summary>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetNum(int betNum)
		{
			return GetByBetNum(betNum, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetNumAsync(int betNum)
		{
			return await GetByBetNumAsync(betNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetNum（字段） 查询
		/// </summary>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetNum(int betNum, TransactionManager tm_)
		{
			return GetByBetNum(betNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetNumAsync(int betNum, TransactionManager tm_)
		{
			return await GetByBetNumAsync(betNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetNum（字段） 查询
		/// </summary>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetNum(int betNum, int top_)
		{
			return GetByBetNum(betNum, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetNumAsync(int betNum, int top_)
		{
			return await GetByBetNumAsync(betNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetNum（字段） 查询
		/// </summary>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetNum(int betNum, int top_, TransactionManager tm_)
		{
			return GetByBetNum(betNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetNumAsync(int betNum, int top_, TransactionManager tm_)
		{
			return await GetByBetNumAsync(betNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetNum（字段） 查询
		/// </summary>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetNum(int betNum, string sort_)
		{
			return GetByBetNum(betNum, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetNumAsync(int betNum, string sort_)
		{
			return await GetByBetNumAsync(betNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetNum（字段） 查询
		/// </summary>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetNum(int betNum, string sort_, TransactionManager tm_)
		{
			return GetByBetNum(betNum, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetNumAsync(int betNum, string sort_, TransactionManager tm_)
		{
			return await GetByBetNumAsync(betNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetNum（字段） 查询
		/// </summary>
		/// /// <param name = "betNum">下注人数（直属）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetNum(int betNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetNum` = @BetNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetNum", betNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetNumAsync(int betNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetNum` = @BetNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetNum", betNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByBetNum
		#region GetByBetCashAmount
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetCashAmount(long betCashAmount)
		{
			return GetByBetCashAmount(betCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetCashAmountAsync(long betCashAmount)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetCashAmount(long betCashAmount, TransactionManager tm_)
		{
			return GetByBetCashAmount(betCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetCashAmountAsync(long betCashAmount, TransactionManager tm_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetCashAmount(long betCashAmount, int top_)
		{
			return GetByBetCashAmount(betCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetCashAmountAsync(long betCashAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByBetCashAmount(long betCashAmount, int top_, TransactionManager tm_)
		{
			return GetByBetCashAmount(betCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetCashAmountAsync(long betCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">下注真金（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetCashAmount(long betCashAmount, string sort_)
		{
			return GetByBetCashAmount(betCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetCashAmountAsync(long betCashAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByBetCashAmount(long betCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetCashAmount(betCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetCashAmountAsync(long betCashAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByBetCashAmount(long betCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCashAmount` = @BetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetCashAmountAsync(long betCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCashAmount` = @BetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByBetCashAmount
		#region GetByWinCashAmount
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByWinCashAmount(long winCashAmount)
		{
			return GetByWinCashAmount(winCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinCashAmountAsync(long winCashAmount)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByWinCashAmount(long winCashAmount, TransactionManager tm_)
		{
			return GetByWinCashAmount(winCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinCashAmountAsync(long winCashAmount, TransactionManager tm_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByWinCashAmount(long winCashAmount, int top_)
		{
			return GetByWinCashAmount(winCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinCashAmountAsync(long winCashAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByWinCashAmount(long winCashAmount, int top_, TransactionManager tm_)
		{
			return GetByWinCashAmount(winCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinCashAmountAsync(long winCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">返奖真金（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByWinCashAmount(long winCashAmount, string sort_)
		{
			return GetByWinCashAmount(winCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinCashAmountAsync(long winCashAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByWinCashAmount(long winCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinCashAmount(winCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinCashAmountAsync(long winCashAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByWinCashAmount(long winCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCashAmount` = @WinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinCashAmountAsync(long winCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCashAmount` = @WinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByWinCashAmount
		#region GetByBetBonusAmount
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetBonusAmount(long betBonusAmount)
		{
			return GetByBetBonusAmount(betBonusAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetBonusAmountAsync(long betBonusAmount)
		{
			return await GetByBetBonusAmountAsync(betBonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetBonusAmount(long betBonusAmount, TransactionManager tm_)
		{
			return GetByBetBonusAmount(betBonusAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetBonusAmountAsync(long betBonusAmount, TransactionManager tm_)
		{
			return await GetByBetBonusAmountAsync(betBonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetBonusAmount(long betBonusAmount, int top_)
		{
			return GetByBetBonusAmount(betBonusAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetBonusAmountAsync(long betBonusAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByBetBonusAmount(long betBonusAmount, int top_, TransactionManager tm_)
		{
			return GetByBetBonusAmount(betBonusAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetBonusAmountAsync(long betBonusAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetBonusAmountAsync(betBonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBonusAmount">下注bonus（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByBetBonusAmount(long betBonusAmount, string sort_)
		{
			return GetByBetBonusAmount(betBonusAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetBonusAmountAsync(long betBonusAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByBetBonusAmount(long betBonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetBonusAmount(betBonusAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetBonusAmountAsync(long betBonusAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByBetBonusAmount(long betBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonusAmount` = @BetBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonusAmount", betBonusAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByBetBonusAmountAsync(long betBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBonusAmount` = @BetBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBonusAmount", betBonusAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByBetBonusAmount
		#region GetByWinBonusAmount
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByWinBonusAmount(long winBonusAmount)
		{
			return GetByWinBonusAmount(winBonusAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinBonusAmountAsync(long winBonusAmount)
		{
			return await GetByWinBonusAmountAsync(winBonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByWinBonusAmount(long winBonusAmount, TransactionManager tm_)
		{
			return GetByWinBonusAmount(winBonusAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinBonusAmountAsync(long winBonusAmount, TransactionManager tm_)
		{
			return await GetByWinBonusAmountAsync(winBonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByWinBonusAmount(long winBonusAmount, int top_)
		{
			return GetByWinBonusAmount(winBonusAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinBonusAmountAsync(long winBonusAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByWinBonusAmount(long winBonusAmount, int top_, TransactionManager tm_)
		{
			return GetByWinBonusAmount(winBonusAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinBonusAmountAsync(long winBonusAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinBonusAmountAsync(winBonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winBonusAmount">返奖bonus（被邀请人）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByWinBonusAmount(long winBonusAmount, string sort_)
		{
			return GetByWinBonusAmount(winBonusAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinBonusAmountAsync(long winBonusAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByWinBonusAmount(long winBonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinBonusAmount(winBonusAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinBonusAmountAsync(long winBonusAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByWinBonusAmount(long winBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonusAmount` = @WinBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonusAmount", winBonusAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByWinBonusAmountAsync(long winBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinBonusAmount` = @WinBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinBonusAmount", winBonusAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByWinBonusAmount
		#region GetByOtherDepositNum
		
		/// <summary>
		/// 按 OtherDepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositNum(int otherDepositNum)
		{
			return GetByOtherDepositNum(otherDepositNum, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositNumAsync(int otherDepositNum)
		{
			return await GetByOtherDepositNumAsync(otherDepositNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherDepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositNum(int otherDepositNum, TransactionManager tm_)
		{
			return GetByOtherDepositNum(otherDepositNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositNumAsync(int otherDepositNum, TransactionManager tm_)
		{
			return await GetByOtherDepositNumAsync(otherDepositNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherDepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositNum(int otherDepositNum, int top_)
		{
			return GetByOtherDepositNum(otherDepositNum, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositNumAsync(int otherDepositNum, int top_)
		{
			return await GetByOtherDepositNumAsync(otherDepositNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherDepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositNum(int otherDepositNum, int top_, TransactionManager tm_)
		{
			return GetByOtherDepositNum(otherDepositNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositNumAsync(int otherDepositNum, int top_, TransactionManager tm_)
		{
			return await GetByOtherDepositNumAsync(otherDepositNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherDepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositNum(int otherDepositNum, string sort_)
		{
			return GetByOtherDepositNum(otherDepositNum, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositNumAsync(int otherDepositNum, string sort_)
		{
			return await GetByOtherDepositNumAsync(otherDepositNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherDepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositNum(int otherDepositNum, string sort_, TransactionManager tm_)
		{
			return GetByOtherDepositNum(otherDepositNum, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositNumAsync(int otherDepositNum, string sort_, TransactionManager tm_)
		{
			return await GetByOtherDepositNumAsync(otherDepositNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherDepositNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositNum">充值人数（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositNum(int otherDepositNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherDepositNum` = @OtherDepositNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherDepositNum", otherDepositNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositNumAsync(int otherDepositNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherDepositNum` = @OtherDepositNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherDepositNum", otherDepositNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherDepositNum
		#region GetByOtherDepositAmount
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositAmount(long otherDepositAmount)
		{
			return GetByOtherDepositAmount(otherDepositAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositAmountAsync(long otherDepositAmount)
		{
			return await GetByOtherDepositAmountAsync(otherDepositAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositAmount(long otherDepositAmount, TransactionManager tm_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, TransactionManager tm_)
		{
			return await GetByOtherDepositAmountAsync(otherDepositAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositAmount(long otherDepositAmount, int top_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByOtherDepositAmount(long otherDepositAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherDepositAmountAsync(otherDepositAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherDepositAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherDepositAmount">充值（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherDepositAmount(long otherDepositAmount, string sort_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByOtherDepositAmount(long otherDepositAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherDepositAmount(otherDepositAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByOtherDepositAmount(long otherDepositAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherDepositAmount` = @OtherDepositAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherDepositAmount", otherDepositAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherDepositAmountAsync(long otherDepositAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherDepositAmount` = @OtherDepositAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherDepositAmount", otherDepositAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherDepositAmount
		#region GetByOtherCashNum
		
		/// <summary>
		/// 按 OtherCashNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashNum(int otherCashNum)
		{
			return GetByOtherCashNum(otherCashNum, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashNumAsync(int otherCashNum)
		{
			return await GetByOtherCashNumAsync(otherCashNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherCashNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashNum(int otherCashNum, TransactionManager tm_)
		{
			return GetByOtherCashNum(otherCashNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashNumAsync(int otherCashNum, TransactionManager tm_)
		{
			return await GetByOtherCashNumAsync(otherCashNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherCashNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashNum(int otherCashNum, int top_)
		{
			return GetByOtherCashNum(otherCashNum, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashNumAsync(int otherCashNum, int top_)
		{
			return await GetByOtherCashNumAsync(otherCashNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherCashNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashNum(int otherCashNum, int top_, TransactionManager tm_)
		{
			return GetByOtherCashNum(otherCashNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashNumAsync(int otherCashNum, int top_, TransactionManager tm_)
		{
			return await GetByOtherCashNumAsync(otherCashNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherCashNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashNum(int otherCashNum, string sort_)
		{
			return GetByOtherCashNum(otherCashNum, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashNumAsync(int otherCashNum, string sort_)
		{
			return await GetByOtherCashNumAsync(otherCashNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherCashNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashNum(int otherCashNum, string sort_, TransactionManager tm_)
		{
			return GetByOtherCashNum(otherCashNum, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashNumAsync(int otherCashNum, string sort_, TransactionManager tm_)
		{
			return await GetByOtherCashNumAsync(otherCashNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherCashNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashNum">提现人数（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashNum(int otherCashNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherCashNum` = @OtherCashNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherCashNum", otherCashNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashNumAsync(int otherCashNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherCashNum` = @OtherCashNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherCashNum", otherCashNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherCashNum
		#region GetByOtherCashAmount
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashAmount(long otherCashAmount)
		{
			return GetByOtherCashAmount(otherCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashAmountAsync(long otherCashAmount)
		{
			return await GetByOtherCashAmountAsync(otherCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashAmount(long otherCashAmount, TransactionManager tm_)
		{
			return GetByOtherCashAmount(otherCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashAmountAsync(long otherCashAmount, TransactionManager tm_)
		{
			return await GetByOtherCashAmountAsync(otherCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashAmount(long otherCashAmount, int top_)
		{
			return GetByOtherCashAmount(otherCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashAmountAsync(long otherCashAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByOtherCashAmount(long otherCashAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherCashAmount(otherCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashAmountAsync(long otherCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherCashAmountAsync(otherCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherCashAmount">提现（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherCashAmount(long otherCashAmount, string sort_)
		{
			return GetByOtherCashAmount(otherCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashAmountAsync(long otherCashAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByOtherCashAmount(long otherCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherCashAmount(otherCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashAmountAsync(long otherCashAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByOtherCashAmount(long otherCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherCashAmount` = @OtherCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherCashAmount", otherCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherCashAmountAsync(long otherCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherCashAmount` = @OtherCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherCashAmount", otherCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherCashAmount
		#region GetByOtherBetNum
		
		/// <summary>
		/// 按 OtherBetNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetNum(int otherBetNum)
		{
			return GetByOtherBetNum(otherBetNum, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetNumAsync(int otherBetNum)
		{
			return await GetByOtherBetNumAsync(otherBetNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherBetNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetNum(int otherBetNum, TransactionManager tm_)
		{
			return GetByOtherBetNum(otherBetNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetNumAsync(int otherBetNum, TransactionManager tm_)
		{
			return await GetByOtherBetNumAsync(otherBetNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetNum(int otherBetNum, int top_)
		{
			return GetByOtherBetNum(otherBetNum, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetNumAsync(int otherBetNum, int top_)
		{
			return await GetByOtherBetNumAsync(otherBetNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherBetNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetNum(int otherBetNum, int top_, TransactionManager tm_)
		{
			return GetByOtherBetNum(otherBetNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetNumAsync(int otherBetNum, int top_, TransactionManager tm_)
		{
			return await GetByOtherBetNumAsync(otherBetNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetNum(int otherBetNum, string sort_)
		{
			return GetByOtherBetNum(otherBetNum, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetNumAsync(int otherBetNum, string sort_)
		{
			return await GetByOtherBetNumAsync(otherBetNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OtherBetNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetNum(int otherBetNum, string sort_, TransactionManager tm_)
		{
			return GetByOtherBetNum(otherBetNum, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetNumAsync(int otherBetNum, string sort_, TransactionManager tm_)
		{
			return await GetByOtherBetNumAsync(otherBetNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetNum（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetNum">下注人数（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetNum(int otherBetNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetNum` = @OtherBetNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetNum", otherBetNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetNumAsync(int otherBetNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetNum` = @OtherBetNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetNum", otherBetNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherBetNum
		#region GetByOtherBetCashAmount
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetCashAmount(long otherBetCashAmount)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount)
		{
			return await GetByOtherBetCashAmountAsync(otherBetCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetCashAmount(long otherBetCashAmount, TransactionManager tm_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, TransactionManager tm_)
		{
			return await GetByOtherBetCashAmountAsync(otherBetCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetCashAmount(long otherBetCashAmount, int top_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByOtherBetCashAmount(long otherBetCashAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherBetCashAmountAsync(otherBetCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetCashAmount">下注真金（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetCashAmount(long otherBetCashAmount, string sort_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByOtherBetCashAmount(long otherBetCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherBetCashAmount(otherBetCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByOtherBetCashAmount(long otherBetCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetCashAmount` = @OtherBetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetCashAmount", otherBetCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetCashAmountAsync(long otherBetCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetCashAmount` = @OtherBetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetCashAmount", otherBetCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherBetCashAmount
		#region GetByOtherWinCashAmount
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherWinCashAmount(long otherWinCashAmount)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount)
		{
			return await GetByOtherWinCashAmountAsync(otherWinCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherWinCashAmount(long otherWinCashAmount, TransactionManager tm_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, TransactionManager tm_)
		{
			return await GetByOtherWinCashAmountAsync(otherWinCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherWinCashAmount(long otherWinCashAmount, int top_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByOtherWinCashAmount(long otherWinCashAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherWinCashAmountAsync(otherWinCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinCashAmount">返奖真金（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherWinCashAmount(long otherWinCashAmount, string sort_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByOtherWinCashAmount(long otherWinCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherWinCashAmount(otherWinCashAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByOtherWinCashAmount(long otherWinCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherWinCashAmount` = @OtherWinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinCashAmount", otherWinCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinCashAmountAsync(long otherWinCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherWinCashAmount` = @OtherWinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinCashAmount", otherWinCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherWinCashAmount
		#region GetByOtherBetBonusAmount
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetBonusAmount(long otherBetBonusAmount)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount)
		{
			return await GetByOtherBetBonusAmountAsync(otherBetBonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, TransactionManager tm_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, TransactionManager tm_)
		{
			return await GetByOtherBetBonusAmountAsync(otherBetBonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, int top_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherBetBonusAmountAsync(otherBetBonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherBetBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherBetBonusAmount">下注bonus（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, string sort_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherBetBonusAmount(otherBetBonusAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByOtherBetBonusAmount(long otherBetBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetBonusAmount` = @OtherBetBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetBonusAmount", otherBetBonusAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherBetBonusAmountAsync(long otherBetBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherBetBonusAmount` = @OtherBetBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherBetBonusAmount", otherBetBonusAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherBetBonusAmount
		#region GetByOtherWinBonusAmount
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherWinBonusAmount(long otherWinBonusAmount)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount)
		{
			return await GetByOtherWinBonusAmountAsync(otherWinBonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, TransactionManager tm_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, TransactionManager tm_)
		{
			return await GetByOtherWinBonusAmountAsync(otherWinBonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, int top_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, int top_)
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
		public List<Sf_promoter_userEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, int top_, TransactionManager tm_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, int top_, TransactionManager tm_)
		{
			return await GetByOtherWinBonusAmountAsync(otherWinBonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OtherWinBonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "otherWinBonusAmount">返奖bonus（其下级）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, string sort_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, string sort_)
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
		public List<Sf_promoter_userEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByOtherWinBonusAmount(otherWinBonusAmount, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByOtherWinBonusAmount(long otherWinBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherWinBonusAmount` = @OtherWinBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinBonusAmount", otherWinBonusAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByOtherWinBonusAmountAsync(long otherWinBonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OtherWinBonusAmount` = @OtherWinBonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OtherWinBonusAmount", otherWinBonusAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByOtherWinBonusAmount
		#region GetByLastUpdateTime
		
		/// <summary>
		/// 按 LastUpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastUpdateTime(DateTime lastUpdateTime)
		{
			return GetByLastUpdateTime(lastUpdateTime, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastUpdateTimeAsync(DateTime lastUpdateTime)
		{
			return await GetByLastUpdateTimeAsync(lastUpdateTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastUpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastUpdateTime(DateTime lastUpdateTime, TransactionManager tm_)
		{
			return GetByLastUpdateTime(lastUpdateTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastUpdateTimeAsync(DateTime lastUpdateTime, TransactionManager tm_)
		{
			return await GetByLastUpdateTimeAsync(lastUpdateTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastUpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastUpdateTime(DateTime lastUpdateTime, int top_)
		{
			return GetByLastUpdateTime(lastUpdateTime, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastUpdateTimeAsync(DateTime lastUpdateTime, int top_)
		{
			return await GetByLastUpdateTimeAsync(lastUpdateTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastUpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastUpdateTime(DateTime lastUpdateTime, int top_, TransactionManager tm_)
		{
			return GetByLastUpdateTime(lastUpdateTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastUpdateTimeAsync(DateTime lastUpdateTime, int top_, TransactionManager tm_)
		{
			return await GetByLastUpdateTimeAsync(lastUpdateTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastUpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastUpdateTime(DateTime lastUpdateTime, string sort_)
		{
			return GetByLastUpdateTime(lastUpdateTime, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastUpdateTimeAsync(DateTime lastUpdateTime, string sort_)
		{
			return await GetByLastUpdateTimeAsync(lastUpdateTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastUpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastUpdateTime(DateTime lastUpdateTime, string sort_, TransactionManager tm_)
		{
			return GetByLastUpdateTime(lastUpdateTime, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastUpdateTimeAsync(DateTime lastUpdateTime, string sort_, TransactionManager tm_)
		{
			return await GetByLastUpdateTimeAsync(lastUpdateTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastUpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "lastUpdateTime">最后一次更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByLastUpdateTime(DateTime lastUpdateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastUpdateTime` = @LastUpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastUpdateTime", lastUpdateTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByLastUpdateTimeAsync(DateTime lastUpdateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LastUpdateTime` = @LastUpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LastUpdateTime", lastUpdateTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByLastUpdateTime
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sf_promoter_userEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">订单时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sf_promoter_userEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sf_promoter_userEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sf_promoter_userEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sf_promoter_userEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sf_promoter_userEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		public async Task<List<Sf_promoter_userEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sf_promoter_userEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
