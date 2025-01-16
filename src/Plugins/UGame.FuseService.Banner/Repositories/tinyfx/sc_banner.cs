/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-10-24 18: 05:00
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

namespace UGame.FuseService.Banner.Repositories.tinyfx
{
	#region EO
	/// <summary>
	/// 广告位定义
	/// 【表 sc_banner 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_bannerEO : IRowMapper<Sc_bannerEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_bannerEO()
		{
			this.BannerType = 0;
			this.Code = 0;
			this.Position = 0;
			this.LinkType = 0;
			this.OrderNum = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalBannerID;
		/// <summary>
		/// 【数据库中的原始主键 BannerID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalBannerID
		{
			get { return _originalBannerID; }
			set { HasOriginal = true; _originalBannerID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "BannerID", BannerID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// Banner编码GUID
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string BannerID { get; set; }
		/// <summary>
		/// banner类型1-未登录2-登录3-...
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int BannerType { get; set; }
		/// <summary>
		/// 10000X活动；50000XVIP
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Code { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string AppID { get; set; }
		/// <summary>
		/// 运营商编码（null意味着全部）
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 使用位置
		///              0-未知
		///              1-首页推荐
		///              2-首页顶部
		///              3-汉堡栏
		///              4-个人中心
		///              5-充值页
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Position { get; set; }
		/// <summary>
		/// 语言代码（null意味着全部）
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 7)]
		public string LangID { get; set; }
		/// <summary>
		/// 标题
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 8)]
		public string Title { get; set; }
		/// <summary>
		/// 提示信息
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 9)]
		public string Tip { get; set; }
		/// <summary>
		/// 内容
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 10)]
		public string Content { get; set; }
		/// <summary>
		/// 图片地址
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 11)]
		public string ImageUrl { get; set; }
		/// <summary>
		/// 链接类型1-相对地址2-绝对地址3-游戏地址
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int LinkType { get; set; }
		/// <summary>
		/// 链接地址
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 13)]
		public string LinkUrl { get; set; }
		/// <summary>
		/// 可能存在的链接参数格式(json)
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 14)]
		public string LinkParams { get; set; }
		/// <summary>
		/// 排序（从小到大）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 15)]
		public int OrderNum { get; set; }
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
		public Sc_bannerEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_bannerEO MapDataReader(IDataReader reader)
		{
		    Sc_bannerEO ret = new Sc_bannerEO();
			ret.BannerID = reader.ToString("BannerID");
			ret.OriginalBannerID = ret.BannerID;
			ret.BannerType = reader.ToInt32("BannerType");
			ret.Code = reader.ToInt32("Code");
			ret.AppID = reader.ToString("AppID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.Position = reader.ToInt32("Position");
			ret.LangID = reader.ToString("LangID");
			ret.Title = reader.ToString("Title");
			ret.Tip = reader.ToString("Tip");
			ret.Content = reader.ToString("Content");
			ret.ImageUrl = reader.ToString("ImageUrl");
			ret.LinkType = reader.ToInt32("LinkType");
			ret.LinkUrl = reader.ToString("LinkUrl");
			ret.LinkParams = reader.ToString("LinkParams");
			ret.OrderNum = reader.ToInt32("OrderNum");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 广告位定义
	/// 【表 sc_banner 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_bannerMO : MySqlTableMO<Sc_bannerEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_banner`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_bannerMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_bannerMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_bannerMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_bannerEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_bannerEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_bannerEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BannerID`, `BannerType`, `Code`, `AppID`, `OperatorID`, `Position`, `LangID`, `Title`, `Tip`, `Content`, `ImageUrl`, `LinkType`, `LinkUrl`, `LinkParams`, `OrderNum`, `Status`, `RecDate`) VALUE (@BannerID, @BannerType, @Code, @AppID, @OperatorID, @Position, @LangID, @Title, @Tip, @Content, @ImageUrl, @LinkType, @LinkUrl, @LinkParams, @OrderNum, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", item.BannerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerType", item.BannerType, MySqlDbType.Int32),
				Database.CreateInParameter("@Code", item.Code, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Tip", item.Tip != null ? item.Tip : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ImageUrl", item.ImageUrl != null ? item.ImageUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LinkType", item.LinkType, MySqlDbType.Int32),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LinkParams", item.LinkParams != null ? item.LinkParams : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sc_bannerEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_bannerEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_bannerEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BannerID`, `BannerType`, `Code`, `AppID`, `OperatorID`, `Position`, `LangID`, `Title`, `Tip`, `Content`, `ImageUrl`, `LinkType`, `LinkUrl`, `LinkParams`, `OrderNum`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.BannerID}',{item.BannerType},{item.Code},'{item.AppID}','{item.OperatorID}',{item.Position},'{item.LangID}','{item.Title}','{item.Tip}','{item.Content}','{item.ImageUrl}',{item.LinkType},'{item.LinkUrl}','{item.LinkParams}',{item.OrderNum},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string bannerID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(bannerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(bannerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string bannerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sc_bannerEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BannerID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_bannerEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BannerID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByBannerType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBannerType(int bannerType, TransactionManager tm_ = null)
		{
			RepairRemoveByBannerTypeData(bannerType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBannerTypeAsync(int bannerType, TransactionManager tm_ = null)
		{
			RepairRemoveByBannerTypeData(bannerType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBannerTypeData(int bannerType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BannerType` = @BannerType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BannerType", bannerType, MySqlDbType.Int32));
		}
		#endregion // RemoveByBannerType
		#region RemoveByCode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCode(int code, TransactionManager tm_ = null)
		{
			RepairRemoveByCodeData(code, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCodeAsync(int code, TransactionManager tm_ = null)
		{
			RepairRemoveByCodeData(code, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCodeData(int code, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Code` = @Code";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Code", code, MySqlDbType.Int32));
		}
		#endregion // RemoveByCode
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
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>();
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
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByPosition
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "position">使用位置</param>
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
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLangID(string langID, TransactionManager tm_ = null)
		{
			RepairRemoveByLangIDData(langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLangIDAsync(string langID, TransactionManager tm_ = null)
		{
			RepairRemoveByLangIDData(langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLangIDData(string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLangID
		#region RemoveByTitle
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTitle(string title, TransactionManager tm_ = null)
		{
			RepairRemoveByTitleData(title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTitleAsync(string title, TransactionManager tm_ = null)
		{
			RepairRemoveByTitleData(title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTitleData(string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (title != null ? "`Title` = @Title" : "`Title` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTitle
		#region RemoveByTip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "tip">提示信息</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTip(string tip, TransactionManager tm_ = null)
		{
			RepairRemoveByTipData(tip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTipAsync(string tip, TransactionManager tm_ = null)
		{
			RepairRemoveByTipData(tip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTipData(string tip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (tip != null ? "`Tip` = @Tip" : "`Tip` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (tip != null)
				paras_.Add(Database.CreateInParameter("@Tip", tip, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTip
		#region RemoveByContent
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByContent(string content, TransactionManager tm_ = null)
		{
			RepairRemoveByContentData(content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByContentAsync(string content, TransactionManager tm_ = null)
		{
			RepairRemoveByContentData(content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByContentData(string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (content != null ? "`Content` = @Content" : "`Content` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.VarChar));
		}
		#endregion // RemoveByContent
		#region RemoveByImageUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImageUrl(string imageUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByImageUrlData(imageUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImageUrlAsync(string imageUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByImageUrlData(imageUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImageUrlData(string imageUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (imageUrl != null ? "`ImageUrl` = @ImageUrl" : "`ImageUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (imageUrl != null)
				paras_.Add(Database.CreateInParameter("@ImageUrl", imageUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImageUrl
		#region RemoveByLinkType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLinkType(int linkType, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkTypeData(linkType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLinkTypeAsync(int linkType, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkTypeData(linkType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLinkTypeData(int linkType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LinkType` = @LinkType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LinkType", linkType, MySqlDbType.Int32));
		}
		#endregion // RemoveByLinkType
		#region RemoveByLinkUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLinkUrl(string linkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkUrlData(linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLinkUrlAsync(string linkUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkUrlData(linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLinkUrlData(string linkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLinkUrl
		#region RemoveByLinkParams
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLinkParams(string linkParams, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkParamsData(linkParams, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLinkParamsAsync(string linkParams, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkParamsData(linkParams, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLinkParamsData(string linkParams, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (linkParams != null ? "`LinkParams` = @LinkParams" : "`LinkParams` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (linkParams != null)
				paras_.Add(Database.CreateInParameter("@LinkParams", linkParams, MySqlDbType.Text));
		}
		#endregion // RemoveByLinkParams
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
		public int Put(Sc_bannerEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_bannerEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_bannerEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BannerID` = @BannerID, `BannerType` = @BannerType, `Code` = @Code, `AppID` = @AppID, `OperatorID` = @OperatorID, `Position` = @Position, `LangID` = @LangID, `Title` = @Title, `Tip` = @Tip, `Content` = @Content, `ImageUrl` = @ImageUrl, `LinkType` = @LinkType, `LinkUrl` = @LinkUrl, `LinkParams` = @LinkParams, `OrderNum` = @OrderNum, `Status` = @Status WHERE `BannerID` = @BannerID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", item.BannerID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerType", item.BannerType, MySqlDbType.Int32),
				Database.CreateInParameter("@Code", item.Code, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Tip", item.Tip != null ? item.Tip : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ImageUrl", item.ImageUrl != null ? item.ImageUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LinkType", item.LinkType, MySqlDbType.Int32),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LinkParams", item.LinkParams != null ? item.LinkParams : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OrderNum", item.OrderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID_Original", item.HasOriginal ? item.OriginalBannerID : item.BannerID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_bannerEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_bannerEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string bannerID, string set_, params object[] values_)
		{
			return Put(set_, "`BannerID` = @BannerID", ConcatValues(values_, bannerID));
		}
		public async Task<int> PutByPKAsync(string bannerID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`BannerID` = @BannerID", ConcatValues(values_, bannerID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string bannerID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`BannerID` = @BannerID", tm_, ConcatValues(values_, bannerID));
		}
		public async Task<int> PutByPKAsync(string bannerID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`BannerID` = @BannerID", tm_, ConcatValues(values_, bannerID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string bannerID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`BannerID` = @BannerID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string bannerID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`BannerID` = @BannerID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutBannerType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBannerTypeByPK(string bannerID, int bannerType, TransactionManager tm_ = null)
		{
			RepairPutBannerTypeByPKData(bannerID, bannerType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBannerTypeByPKAsync(string bannerID, int bannerType, TransactionManager tm_ = null)
		{
			RepairPutBannerTypeByPKData(bannerID, bannerType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBannerTypeByPKData(string bannerID, int bannerType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BannerType` = @BannerType  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerType", bannerType, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBannerType(int bannerType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BannerType` = @BannerType";
			var parameter_ = Database.CreateInParameter("@BannerType", bannerType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBannerTypeAsync(int bannerType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BannerType` = @BannerType";
			var parameter_ = Database.CreateInParameter("@BannerType", bannerType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBannerType
		#region PutCode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCodeByPK(string bannerID, int code, TransactionManager tm_ = null)
		{
			RepairPutCodeByPKData(bannerID, code, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCodeByPKAsync(string bannerID, int code, TransactionManager tm_ = null)
		{
			RepairPutCodeByPKData(bannerID, code, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCodeByPKData(string bannerID, int code, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Code` = @Code  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Code", code, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCode(int code, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Code` = @Code";
			var parameter_ = Database.CreateInParameter("@Code", code, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCodeAsync(int code, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Code` = @Code";
			var parameter_ = Database.CreateInParameter("@Code", code, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCode
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string bannerID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(bannerID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string bannerID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(bannerID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string bannerID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
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
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string bannerID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(bannerID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string bannerID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(bannerID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string bannerID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
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
		#region PutPosition
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "position">使用位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPositionByPK(string bannerID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(bannerID, position, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPositionByPKAsync(string bannerID, int position, TransactionManager tm_ = null)
		{
			RepairPutPositionByPKData(bannerID, position, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPositionByPKData(string bannerID, int position, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Position` = @Position  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "position">使用位置</param>
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
		#region PutLangID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangIDByPK(string bannerID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(bannerID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangIDByPKAsync(string bannerID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(bannerID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangIDByPKData(string bannerID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID` = @LangID  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangID(string langID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID` = @LangID";
			var parameter_ = Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLangIDAsync(string langID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID` = @LangID";
			var parameter_ = Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLangID
		#region PutTitle
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(string bannerID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(bannerID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(string bannerID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(bannerID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(string bannerID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitle(string title, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Title` = @Title";
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTitleAsync(string title, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Title` = @Title";
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTitle
		#region PutTip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "tip">提示信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTipByPK(string bannerID, string tip, TransactionManager tm_ = null)
		{
			RepairPutTipByPKData(bannerID, tip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTipByPKAsync(string bannerID, string tip, TransactionManager tm_ = null)
		{
			RepairPutTipByPKData(bannerID, tip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTipByPKData(string bannerID, string tip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Tip` = @Tip  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Tip", tip != null ? tip : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "tip">提示信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTip(string tip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Tip` = @Tip";
			var parameter_ = Database.CreateInParameter("@Tip", tip != null ? tip : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTipAsync(string tip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Tip` = @Tip";
			var parameter_ = Database.CreateInParameter("@Tip", tip != null ? tip : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTip
		#region PutContent
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContentByPK(string bannerID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(bannerID, content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutContentByPKAsync(string bannerID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(bannerID, content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutContentByPKData(string bannerID, string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Content` = @Content  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContent(string content, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Content` = @Content";
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutContentAsync(string content, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Content` = @Content";
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutContent
		#region PutImageUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImageUrlByPK(string bannerID, string imageUrl, TransactionManager tm_ = null)
		{
			RepairPutImageUrlByPKData(bannerID, imageUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImageUrlByPKAsync(string bannerID, string imageUrl, TransactionManager tm_ = null)
		{
			RepairPutImageUrlByPKData(bannerID, imageUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImageUrlByPKData(string bannerID, string imageUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ImageUrl` = @ImageUrl  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ImageUrl", imageUrl != null ? imageUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImageUrl(string imageUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ImageUrl` = @ImageUrl";
			var parameter_ = Database.CreateInParameter("@ImageUrl", imageUrl != null ? imageUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImageUrlAsync(string imageUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ImageUrl` = @ImageUrl";
			var parameter_ = Database.CreateInParameter("@ImageUrl", imageUrl != null ? imageUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImageUrl
		#region PutLinkType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkTypeByPK(string bannerID, int linkType, TransactionManager tm_ = null)
		{
			RepairPutLinkTypeByPKData(bannerID, linkType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkTypeByPKAsync(string bannerID, int linkType, TransactionManager tm_ = null)
		{
			RepairPutLinkTypeByPKData(bannerID, linkType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkTypeByPKData(string bannerID, int linkType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LinkType` = @LinkType  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LinkType", linkType, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkType(int linkType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkType` = @LinkType";
			var parameter_ = Database.CreateInParameter("@LinkType", linkType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLinkTypeAsync(int linkType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkType` = @LinkType";
			var parameter_ = Database.CreateInParameter("@LinkType", linkType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLinkType
		#region PutLinkUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkUrlByPK(string bannerID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(bannerID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkUrlByPKAsync(string bannerID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(bannerID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkUrlByPKData(string bannerID, string linkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkUrl(string linkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl";
			var parameter_ = Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLinkUrlAsync(string linkUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl";
			var parameter_ = Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLinkUrl
		#region PutLinkParams
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkParamsByPK(string bannerID, string linkParams, TransactionManager tm_ = null)
		{
			RepairPutLinkParamsByPKData(bannerID, linkParams, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkParamsByPKAsync(string bannerID, string linkParams, TransactionManager tm_ = null)
		{
			RepairPutLinkParamsByPKData(bannerID, linkParams, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkParamsByPKData(string bannerID, string linkParams, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LinkParams` = @LinkParams  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LinkParams", linkParams != null ? linkParams : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkParams(string linkParams, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkParams` = @LinkParams";
			var parameter_ = Database.CreateInParameter("@LinkParams", linkParams != null ? linkParams : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLinkParamsAsync(string linkParams, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkParams` = @LinkParams";
			var parameter_ = Database.CreateInParameter("@LinkParams", linkParams != null ? linkParams : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLinkParams
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(string bannerID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(bannerID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(string bannerID, int orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(bannerID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(string bannerID, int orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
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
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string bannerID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(bannerID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string bannerID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(bannerID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string bannerID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
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
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string bannerID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(bannerID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string bannerID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(bannerID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string bannerID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `BannerID` = @BannerID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
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
		public bool Set(Sc_bannerEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BannerID) == null)
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
		public async Task<bool> SetAsync(Sc_bannerEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BannerID) == null)
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
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sc_bannerEO GetByPK(string bannerID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(bannerID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<Sc_bannerEO> GetByPKAsync(string bannerID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(bannerID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		private void RepairGetByPKData(string bannerID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`BannerID` = @BannerID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 BannerType（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBannerTypeByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BannerType`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<int> GetBannerTypeByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BannerType`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Code（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCodeByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Code`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<int> GetCodeByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Code`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Position（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPositionByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Position`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<int> GetPositionByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Position`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Title`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Title`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Tip（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTipByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Tip`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetTipByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Tip`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Content（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetContentByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Content`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetContentByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Content`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ImageUrl（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImageUrlByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ImageUrl`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetImageUrlByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ImageUrl`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LinkType（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLinkTypeByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LinkType`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<int> GetLinkTypeByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LinkType`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LinkUrl（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLinkUrlByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LinkUrl`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetLinkUrlByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LinkUrl`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LinkParams（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLinkParamsByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LinkParams`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<string> GetLinkParamsByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LinkParams`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderNumByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OrderNum`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<int> GetOrderNumByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OrderNum`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`BannerID` = @BannerID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "bannerID">Banner编码GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`BannerID` = @BannerID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string bannerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BannerID", bannerID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`BannerID` = @BannerID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByBannerType
		
		/// <summary>
		/// 按 BannerType（字段） 查询
		/// </summary>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByBannerType(int bannerType)
		{
			return GetByBannerType(bannerType, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByBannerTypeAsync(int bannerType)
		{
			return await GetByBannerTypeAsync(bannerType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BannerType（字段） 查询
		/// </summary>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByBannerType(int bannerType, TransactionManager tm_)
		{
			return GetByBannerType(bannerType, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByBannerTypeAsync(int bannerType, TransactionManager tm_)
		{
			return await GetByBannerTypeAsync(bannerType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BannerType（字段） 查询
		/// </summary>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByBannerType(int bannerType, int top_)
		{
			return GetByBannerType(bannerType, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByBannerTypeAsync(int bannerType, int top_)
		{
			return await GetByBannerTypeAsync(bannerType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BannerType（字段） 查询
		/// </summary>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByBannerType(int bannerType, int top_, TransactionManager tm_)
		{
			return GetByBannerType(bannerType, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByBannerTypeAsync(int bannerType, int top_, TransactionManager tm_)
		{
			return await GetByBannerTypeAsync(bannerType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BannerType（字段） 查询
		/// </summary>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByBannerType(int bannerType, string sort_)
		{
			return GetByBannerType(bannerType, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByBannerTypeAsync(int bannerType, string sort_)
		{
			return await GetByBannerTypeAsync(bannerType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BannerType（字段） 查询
		/// </summary>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByBannerType(int bannerType, string sort_, TransactionManager tm_)
		{
			return GetByBannerType(bannerType, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByBannerTypeAsync(int bannerType, string sort_, TransactionManager tm_)
		{
			return await GetByBannerTypeAsync(bannerType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BannerType（字段） 查询
		/// </summary>
		/// /// <param name = "bannerType">banner类型1-未登录2-登录3-...</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByBannerType(int bannerType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BannerType` = @BannerType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BannerType", bannerType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByBannerTypeAsync(int bannerType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BannerType` = @BannerType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BannerType", bannerType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByBannerType
		#region GetByCode
		
		/// <summary>
		/// 按 Code（字段） 查询
		/// </summary>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByCode(int code)
		{
			return GetByCode(code, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByCodeAsync(int code)
		{
			return await GetByCodeAsync(code, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Code（字段） 查询
		/// </summary>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByCode(int code, TransactionManager tm_)
		{
			return GetByCode(code, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByCodeAsync(int code, TransactionManager tm_)
		{
			return await GetByCodeAsync(code, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Code（字段） 查询
		/// </summary>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByCode(int code, int top_)
		{
			return GetByCode(code, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByCodeAsync(int code, int top_)
		{
			return await GetByCodeAsync(code, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Code（字段） 查询
		/// </summary>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByCode(int code, int top_, TransactionManager tm_)
		{
			return GetByCode(code, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByCodeAsync(int code, int top_, TransactionManager tm_)
		{
			return await GetByCodeAsync(code, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Code（字段） 查询
		/// </summary>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByCode(int code, string sort_)
		{
			return GetByCode(code, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByCodeAsync(int code, string sort_)
		{
			return await GetByCodeAsync(code, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Code（字段） 查询
		/// </summary>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByCode(int code, string sort_, TransactionManager tm_)
		{
			return GetByCode(code, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByCodeAsync(int code, string sort_, TransactionManager tm_)
		{
			return await GetByCodeAsync(code, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Code（字段） 查询
		/// </summary>
		/// /// <param name = "code">10000X活动；50000XVIP</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByCode(int code, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Code` = @Code", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Code", code, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByCodeAsync(int code, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Code` = @Code", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Code", code, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByCode
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Sc_bannerEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Sc_bannerEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Sc_bannerEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Sc_bannerEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（null意味着全部）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Sc_bannerEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Sc_bannerEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByPosition
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByPosition(int position)
		{
			return GetByPosition(position, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByPositionAsync(int position)
		{
			return await GetByPositionAsync(position, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByPosition(int position, TransactionManager tm_)
		{
			return GetByPosition(position, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByPositionAsync(int position, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByPosition(int position, int top_)
		{
			return GetByPosition(position, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByPositionAsync(int position, int top_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByPosition(int position, int top_, TransactionManager tm_)
		{
			return GetByPosition(position, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByPositionAsync(int position, int top_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByPosition(int position, string sort_)
		{
			return GetByPosition(position, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByPositionAsync(int position, string sort_)
		{
			return await GetByPositionAsync(position, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByPosition(int position, string sort_, TransactionManager tm_)
		{
			return GetByPosition(position, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByPositionAsync(int position, string sort_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">使用位置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByPosition(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByPositionAsync(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByPosition
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码（null意味着全部）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByTitleAsync(string title, int top_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByTitleAsync(string title, string sort_)
		{
			return await GetByTitleAsync(title, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByTip
		
		/// <summary>
		/// 按 Tip（字段） 查询
		/// </summary>
		/// /// <param name = "tip">提示信息</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTip(string tip)
		{
			return GetByTip(tip, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByTipAsync(string tip)
		{
			return await GetByTipAsync(tip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Tip（字段） 查询
		/// </summary>
		/// /// <param name = "tip">提示信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTip(string tip, TransactionManager tm_)
		{
			return GetByTip(tip, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByTipAsync(string tip, TransactionManager tm_)
		{
			return await GetByTipAsync(tip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Tip（字段） 查询
		/// </summary>
		/// /// <param name = "tip">提示信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTip(string tip, int top_)
		{
			return GetByTip(tip, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByTipAsync(string tip, int top_)
		{
			return await GetByTipAsync(tip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Tip（字段） 查询
		/// </summary>
		/// /// <param name = "tip">提示信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTip(string tip, int top_, TransactionManager tm_)
		{
			return GetByTip(tip, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByTipAsync(string tip, int top_, TransactionManager tm_)
		{
			return await GetByTipAsync(tip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Tip（字段） 查询
		/// </summary>
		/// /// <param name = "tip">提示信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTip(string tip, string sort_)
		{
			return GetByTip(tip, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByTipAsync(string tip, string sort_)
		{
			return await GetByTipAsync(tip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Tip（字段） 查询
		/// </summary>
		/// /// <param name = "tip">提示信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTip(string tip, string sort_, TransactionManager tm_)
		{
			return GetByTip(tip, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByTipAsync(string tip, string sort_, TransactionManager tm_)
		{
			return await GetByTipAsync(tip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Tip（字段） 查询
		/// </summary>
		/// /// <param name = "tip">提示信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByTip(string tip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(tip != null ? "`Tip` = @Tip" : "`Tip` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (tip != null)
				paras_.Add(Database.CreateInParameter("@Tip", tip, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByTipAsync(string tip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(tip != null ? "`Tip` = @Tip" : "`Tip` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (tip != null)
				paras_.Add(Database.CreateInParameter("@Tip", tip, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByTip
		#region GetByContent
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByContent(string content)
		{
			return GetByContent(content, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByContentAsync(string content)
		{
			return await GetByContentAsync(content, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByContent(string content, TransactionManager tm_)
		{
			return GetByContent(content, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByContentAsync(string content, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByContent(string content, int top_)
		{
			return GetByContent(content, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByContentAsync(string content, int top_)
		{
			return await GetByContentAsync(content, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByContent(string content, int top_, TransactionManager tm_)
		{
			return GetByContent(content, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByContentAsync(string content, int top_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByContent(string content, string sort_)
		{
			return GetByContent(content, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByContentAsync(string content, string sort_)
		{
			return await GetByContentAsync(content, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByContent(string content, string sort_, TransactionManager tm_)
		{
			return GetByContent(content, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByContentAsync(string content, string sort_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByContent(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByContentAsync(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByContent
		#region GetByImageUrl
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByImageUrl(string imageUrl)
		{
			return GetByImageUrl(imageUrl, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByImageUrlAsync(string imageUrl)
		{
			return await GetByImageUrlAsync(imageUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByImageUrl(string imageUrl, TransactionManager tm_)
		{
			return GetByImageUrl(imageUrl, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByImageUrlAsync(string imageUrl, TransactionManager tm_)
		{
			return await GetByImageUrlAsync(imageUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByImageUrl(string imageUrl, int top_)
		{
			return GetByImageUrl(imageUrl, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByImageUrlAsync(string imageUrl, int top_)
		{
			return await GetByImageUrlAsync(imageUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByImageUrl(string imageUrl, int top_, TransactionManager tm_)
		{
			return GetByImageUrl(imageUrl, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByImageUrlAsync(string imageUrl, int top_, TransactionManager tm_)
		{
			return await GetByImageUrlAsync(imageUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByImageUrl(string imageUrl, string sort_)
		{
			return GetByImageUrl(imageUrl, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByImageUrlAsync(string imageUrl, string sort_)
		{
			return await GetByImageUrlAsync(imageUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByImageUrl(string imageUrl, string sort_, TransactionManager tm_)
		{
			return GetByImageUrl(imageUrl, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByImageUrlAsync(string imageUrl, string sort_, TransactionManager tm_)
		{
			return await GetByImageUrlAsync(imageUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByImageUrl(string imageUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(imageUrl != null ? "`ImageUrl` = @ImageUrl" : "`ImageUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (imageUrl != null)
				paras_.Add(Database.CreateInParameter("@ImageUrl", imageUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByImageUrlAsync(string imageUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(imageUrl != null ? "`ImageUrl` = @ImageUrl" : "`ImageUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (imageUrl != null)
				paras_.Add(Database.CreateInParameter("@ImageUrl", imageUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByImageUrl
		#region GetByLinkType
		
		/// <summary>
		/// 按 LinkType（字段） 查询
		/// </summary>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkType(int linkType)
		{
			return GetByLinkType(linkType, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkTypeAsync(int linkType)
		{
			return await GetByLinkTypeAsync(linkType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkType（字段） 查询
		/// </summary>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkType(int linkType, TransactionManager tm_)
		{
			return GetByLinkType(linkType, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkTypeAsync(int linkType, TransactionManager tm_)
		{
			return await GetByLinkTypeAsync(linkType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkType（字段） 查询
		/// </summary>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkType(int linkType, int top_)
		{
			return GetByLinkType(linkType, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkTypeAsync(int linkType, int top_)
		{
			return await GetByLinkTypeAsync(linkType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkType（字段） 查询
		/// </summary>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkType(int linkType, int top_, TransactionManager tm_)
		{
			return GetByLinkType(linkType, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkTypeAsync(int linkType, int top_, TransactionManager tm_)
		{
			return await GetByLinkTypeAsync(linkType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkType（字段） 查询
		/// </summary>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkType(int linkType, string sort_)
		{
			return GetByLinkType(linkType, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkTypeAsync(int linkType, string sort_)
		{
			return await GetByLinkTypeAsync(linkType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkType（字段） 查询
		/// </summary>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkType(int linkType, string sort_, TransactionManager tm_)
		{
			return GetByLinkType(linkType, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkTypeAsync(int linkType, string sort_, TransactionManager tm_)
		{
			return await GetByLinkTypeAsync(linkType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkType（字段） 查询
		/// </summary>
		/// /// <param name = "linkType">链接类型1-相对地址2-绝对地址3-游戏地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkType(int linkType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LinkType` = @LinkType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LinkType", linkType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkTypeAsync(int linkType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LinkType` = @LinkType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LinkType", linkType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByLinkType
		#region GetByLinkUrl
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkUrl(string linkUrl)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkUrlAsync(string linkUrl)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkUrl(string linkUrl, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkUrlAsync(string linkUrl, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkUrl(string linkUrl, int top_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkUrlAsync(string linkUrl, int top_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkUrl(string linkUrl, int top_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkUrlAsync(string linkUrl, int top_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkUrl(string linkUrl, string sort_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkUrlAsync(string linkUrl, string sort_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkUrl(string linkUrl, string sort_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkUrlAsync(string linkUrl, string sort_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkUrl(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkUrlAsync(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByLinkUrl
		#region GetByLinkParams
		
		/// <summary>
		/// 按 LinkParams（字段） 查询
		/// </summary>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkParams(string linkParams)
		{
			return GetByLinkParams(linkParams, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkParamsAsync(string linkParams)
		{
			return await GetByLinkParamsAsync(linkParams, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkParams（字段） 查询
		/// </summary>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkParams(string linkParams, TransactionManager tm_)
		{
			return GetByLinkParams(linkParams, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkParamsAsync(string linkParams, TransactionManager tm_)
		{
			return await GetByLinkParamsAsync(linkParams, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkParams（字段） 查询
		/// </summary>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkParams(string linkParams, int top_)
		{
			return GetByLinkParams(linkParams, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkParamsAsync(string linkParams, int top_)
		{
			return await GetByLinkParamsAsync(linkParams, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkParams（字段） 查询
		/// </summary>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkParams(string linkParams, int top_, TransactionManager tm_)
		{
			return GetByLinkParams(linkParams, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkParamsAsync(string linkParams, int top_, TransactionManager tm_)
		{
			return await GetByLinkParamsAsync(linkParams, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkParams（字段） 查询
		/// </summary>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkParams(string linkParams, string sort_)
		{
			return GetByLinkParams(linkParams, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkParamsAsync(string linkParams, string sort_)
		{
			return await GetByLinkParamsAsync(linkParams, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkParams（字段） 查询
		/// </summary>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkParams(string linkParams, string sort_, TransactionManager tm_)
		{
			return GetByLinkParams(linkParams, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkParamsAsync(string linkParams, string sort_, TransactionManager tm_)
		{
			return await GetByLinkParamsAsync(linkParams, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkParams（字段） 查询
		/// </summary>
		/// /// <param name = "linkParams">可能存在的链接参数格式(json)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByLinkParams(string linkParams, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkParams != null ? "`LinkParams` = @LinkParams" : "`LinkParams` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkParams != null)
				paras_.Add(Database.CreateInParameter("@LinkParams", linkParams, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByLinkParamsAsync(string linkParams, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkParams != null ? "`LinkParams` = @LinkParams" : "`LinkParams` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkParams != null)
				paras_.Add(Database.CreateInParameter("@LinkParams", linkParams, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByLinkParams
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByOrderNum(int orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByOrderNumAsync(int orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByOrderNum(int orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByOrderNumAsync(int orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByOrderNum(int orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByOrderNumAsync(int orderNum, int top_)
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
		public List<Sc_bannerEO> GetByOrderNum(int orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByOrderNumAsync(int orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序（从小到大）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByOrderNum(int orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByOrderNumAsync(int orderNum, string sort_)
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
		public List<Sc_bannerEO> GetByOrderNum(int orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByOrderNumAsync(int orderNum, string sort_, TransactionManager tm_)
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
		public List<Sc_bannerEO> GetByOrderNum(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByOrderNumAsync(int orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderNum` = @OrderNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderNum", orderNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByStatusAsync(int status, int top_)
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
		public List<Sc_bannerEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByStatusAsync(int status, string sort_)
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
		public List<Sc_bannerEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<Sc_bannerEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sc_bannerEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sc_bannerEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_bannerEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sc_bannerEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sc_bannerEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sc_bannerEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sc_bannerEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		public async Task<List<Sc_bannerEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_bannerEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
