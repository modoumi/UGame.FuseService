/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-10-24 18: 04:55
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
	/// 通知明细
	/// 【表 sc_notify_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Sc_notify_detailEO : IRowMapper<Sc_notify_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sc_notify_detailEO()
		{
			this.LinkKind = 0;
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
		
		private string _originalLangID;
		/// <summary>
		/// 【数据库中的原始主键 LangID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalLangID
		{
			get { return _originalLangID; }
			set { HasOriginal = true; _originalLangID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "NotifyID", NotifyID },  { "LangID", LangID }, };
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
		/// 语言代码
		/// 【主键 varchar(20)】
		/// </summary>
		[DataMember(Order = 2)]
		public string LangID { get; set; }
		/// <summary>
		/// 标题
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Title { get; set; }
		/// <summary>
		/// 图片地址
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 4)]
		public string ImageUrl { get; set; }
		/// <summary>
		/// 内容
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 5)]
		public string Content { get; set; }
		/// <summary>
		/// 链接类型1-email 2-url
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int LinkKind { get; set; }
		/// <summary>
		/// 链接
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string LinkUrl { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 8)]
		public string Txt1 { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 9)]
		public string Txt2 { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 10)]
		public string Txt3 { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 11)]
		public string Txt4 { get; set; }
		/// <summary>
		/// 文本1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 12)]
		public string Txt5 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 13)]
		public string Img1 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 14)]
		public string Img2 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 15)]
		public string Img3 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 16)]
		public string Img4 { get; set; }
		/// <summary>
		/// 图片1
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 17)]
		public string Img5 { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sc_notify_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sc_notify_detailEO MapDataReader(IDataReader reader)
		{
		    Sc_notify_detailEO ret = new Sc_notify_detailEO();
			ret.NotifyID = reader.ToString("NotifyID");
			ret.OriginalNotifyID = ret.NotifyID;
			ret.LangID = reader.ToString("LangID");
			ret.OriginalLangID = ret.LangID;
			ret.Title = reader.ToString("Title");
			ret.ImageUrl = reader.ToString("ImageUrl");
			ret.Content = reader.ToString("Content");
			ret.LinkKind = reader.ToInt32("LinkKind");
			ret.LinkUrl = reader.ToString("LinkUrl");
			ret.Txt1 = reader.ToString("Txt1");
			ret.Txt2 = reader.ToString("Txt2");
			ret.Txt3 = reader.ToString("Txt3");
			ret.Txt4 = reader.ToString("Txt4");
			ret.Txt5 = reader.ToString("Txt5");
			ret.Img1 = reader.ToString("Img1");
			ret.Img2 = reader.ToString("Img2");
			ret.Img3 = reader.ToString("Img3");
			ret.Img4 = reader.ToString("Img4");
			ret.Img5 = reader.ToString("Img5");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 通知明细
	/// 【表 sc_notify_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Sc_notify_detailMO : MySqlTableMO<Sc_notify_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sc_notify_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sc_notify_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sc_notify_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sc_notify_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sc_notify_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sc_notify_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sc_notify_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`NotifyID`, `LangID`, `Title`, `ImageUrl`, `Content`, `LinkKind`, `LinkUrl`, `Txt1`, `Txt2`, `Txt3`, `Txt4`, `Txt5`, `Img1`, `Img2`, `Img3`, `Img4`, `Img5`) VALUE (@NotifyID, @LangID, @Title, @ImageUrl, @Content, @LinkKind, @LinkUrl, @Txt1, @Txt2, @Txt3, @Txt4, @Txt5, @Img1, @Img2, @Img3, @Img4, @Img5);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ImageUrl", item.ImageUrl != null ? item.ImageUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@LinkKind", item.LinkKind, MySqlDbType.Int32),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt1", item.Txt1 != null ? item.Txt1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt2", item.Txt2 != null ? item.Txt2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt3", item.Txt3 != null ? item.Txt3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt4", item.Txt4 != null ? item.Txt4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt5", item.Txt5 != null ? item.Txt5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img1", item.Img1 != null ? item.Img1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img2", item.Img2 != null ? item.Img2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img3", item.Img3 != null ? item.Img3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img4", item.Img4 != null ? item.Img4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img5", item.Img5 != null ? item.Img5 : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Sc_notify_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sc_notify_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sc_notify_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`NotifyID`, `LangID`, `Title`, `ImageUrl`, `Content`, `LinkKind`, `LinkUrl`, `Txt1`, `Txt2`, `Txt3`, `Txt4`, `Txt5`, `Img1`, `Img2`, `Img3`, `Img4`, `Img5`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.NotifyID}','{item.LangID}','{item.Title}','{item.ImageUrl}','{item.Content}',{item.LinkKind},'{item.LinkUrl}','{item.Txt1}','{item.Txt2}','{item.Txt3}','{item.Txt4}','{item.Txt5}','{item.Img1}','{item.Img2}','{item.Img3}','{item.Img4}','{item.Img5}'),");
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
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(notifyID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(notifyID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string notifyID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Sc_notify_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.NotifyID, item.LangID, tm_);
		}
		public async Task<int> RemoveAsync(Sc_notify_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.NotifyID, item.LangID, tm_);
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
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
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
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
		}
		#endregion // RemoveByContent
		#region RemoveByLinkKind
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLinkKind(int linkKind, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkKindData(linkKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLinkKindAsync(int linkKind, TransactionManager tm_ = null)
		{
			RepairRemoveByLinkKindData(linkKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLinkKindData(int linkKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LinkKind` = @LinkKind";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LinkKind", linkKind, MySqlDbType.Int32));
		}
		#endregion // RemoveByLinkKind
		#region RemoveByLinkUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
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
		#region RemoveByTxt1
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTxt1(string txt1, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt1Data(txt1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTxt1Async(string txt1, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt1Data(txt1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTxt1Data(string txt1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (txt1 != null ? "`Txt1` = @Txt1" : "`Txt1` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (txt1 != null)
				paras_.Add(Database.CreateInParameter("@Txt1", txt1, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTxt1
		#region RemoveByTxt2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTxt2(string txt2, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt2Data(txt2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTxt2Async(string txt2, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt2Data(txt2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTxt2Data(string txt2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (txt2 != null ? "`Txt2` = @Txt2" : "`Txt2` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (txt2 != null)
				paras_.Add(Database.CreateInParameter("@Txt2", txt2, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTxt2
		#region RemoveByTxt3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTxt3(string txt3, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt3Data(txt3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTxt3Async(string txt3, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt3Data(txt3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTxt3Data(string txt3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (txt3 != null ? "`Txt3` = @Txt3" : "`Txt3` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (txt3 != null)
				paras_.Add(Database.CreateInParameter("@Txt3", txt3, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTxt3
		#region RemoveByTxt4
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTxt4(string txt4, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt4Data(txt4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTxt4Async(string txt4, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt4Data(txt4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTxt4Data(string txt4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (txt4 != null ? "`Txt4` = @Txt4" : "`Txt4` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (txt4 != null)
				paras_.Add(Database.CreateInParameter("@Txt4", txt4, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTxt4
		#region RemoveByTxt5
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTxt5(string txt5, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt5Data(txt5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTxt5Async(string txt5, TransactionManager tm_ = null)
		{
			RepairRemoveByTxt5Data(txt5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTxt5Data(string txt5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (txt5 != null ? "`Txt5` = @Txt5" : "`Txt5` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (txt5 != null)
				paras_.Add(Database.CreateInParameter("@Txt5", txt5, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTxt5
		#region RemoveByImg1
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg1(string img1, TransactionManager tm_ = null)
		{
			RepairRemoveByImg1Data(img1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg1Async(string img1, TransactionManager tm_ = null)
		{
			RepairRemoveByImg1Data(img1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg1Data(string img1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img1 != null ? "`Img1` = @Img1" : "`Img1` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img1 != null)
				paras_.Add(Database.CreateInParameter("@Img1", img1, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg1
		#region RemoveByImg2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg2(string img2, TransactionManager tm_ = null)
		{
			RepairRemoveByImg2Data(img2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg2Async(string img2, TransactionManager tm_ = null)
		{
			RepairRemoveByImg2Data(img2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg2Data(string img2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img2 != null ? "`Img2` = @Img2" : "`Img2` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img2 != null)
				paras_.Add(Database.CreateInParameter("@Img2", img2, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg2
		#region RemoveByImg3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg3(string img3, TransactionManager tm_ = null)
		{
			RepairRemoveByImg3Data(img3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg3Async(string img3, TransactionManager tm_ = null)
		{
			RepairRemoveByImg3Data(img3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg3Data(string img3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img3 != null ? "`Img3` = @Img3" : "`Img3` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img3 != null)
				paras_.Add(Database.CreateInParameter("@Img3", img3, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg3
		#region RemoveByImg4
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg4(string img4, TransactionManager tm_ = null)
		{
			RepairRemoveByImg4Data(img4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg4Async(string img4, TransactionManager tm_ = null)
		{
			RepairRemoveByImg4Data(img4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg4Data(string img4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img4 != null ? "`Img4` = @Img4" : "`Img4` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img4 != null)
				paras_.Add(Database.CreateInParameter("@Img4", img4, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg4
		#region RemoveByImg5
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByImg5(string img5, TransactionManager tm_ = null)
		{
			RepairRemoveByImg5Data(img5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByImg5Async(string img5, TransactionManager tm_ = null)
		{
			RepairRemoveByImg5Data(img5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByImg5Data(string img5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (img5 != null ? "`Img5` = @Img5" : "`Img5` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (img5 != null)
				paras_.Add(Database.CreateInParameter("@Img5", img5, MySqlDbType.VarChar));
		}
		#endregion // RemoveByImg5
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
		public int Put(Sc_notify_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sc_notify_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sc_notify_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NotifyID` = @NotifyID, `LangID` = @LangID, `Title` = @Title, `ImageUrl` = @ImageUrl, `Content` = @Content, `LinkKind` = @LinkKind, `LinkUrl` = @LinkUrl, `Txt1` = @Txt1, `Txt2` = @Txt2, `Txt3` = @Txt3, `Txt4` = @Txt4, `Txt5` = @Txt5, `Img1` = @Img1, `Img2` = @Img2, `Img3` = @Img3, `Img4` = @Img4, `Img5` = @Img5 WHERE `NotifyID` = @NotifyID_Original AND `LangID` = @LangID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ImageUrl", item.ImageUrl != null ? item.ImageUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@LinkKind", item.LinkKind, MySqlDbType.Int32),
				Database.CreateInParameter("@LinkUrl", item.LinkUrl != null ? item.LinkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt1", item.Txt1 != null ? item.Txt1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt2", item.Txt2 != null ? item.Txt2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt3", item.Txt3 != null ? item.Txt3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt4", item.Txt4 != null ? item.Txt4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Txt5", item.Txt5 != null ? item.Txt5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img1", item.Img1 != null ? item.Img1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img2", item.Img2 != null ? item.Img2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img3", item.Img3 != null ? item.Img3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img4", item.Img4 != null ? item.Img4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Img5", item.Img5 != null ? item.Img5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID_Original", item.HasOriginal ? item.OriginalNotifyID : item.NotifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID_Original", item.HasOriginal ? item.OriginalLangID : item.LangID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sc_notify_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sc_notify_detailEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string notifyID, string langID, string set_, params object[] values_)
		{
			return Put(set_, "`NotifyID` = @NotifyID AND `LangID` = @LangID", ConcatValues(values_, notifyID, langID));
		}
		public async Task<int> PutByPKAsync(string notifyID, string langID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`NotifyID` = @NotifyID AND `LangID` = @LangID", ConcatValues(values_, notifyID, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string notifyID, string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`NotifyID` = @NotifyID AND `LangID` = @LangID", tm_, ConcatValues(values_, notifyID, langID));
		}
		public async Task<int> PutByPKAsync(string notifyID, string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`NotifyID` = @NotifyID AND `LangID` = @LangID", tm_, ConcatValues(values_, notifyID, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string notifyID, string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`NotifyID` = @NotifyID AND `LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string notifyID, string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`NotifyID` = @NotifyID AND `LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutLangID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
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
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(string notifyID, string langID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(notifyID, langID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(string notifyID, string langID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(notifyID, langID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(string notifyID, string langID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
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
		#region PutImageUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImageUrlByPK(string notifyID, string langID, string imageUrl, TransactionManager tm_ = null)
		{
			RepairPutImageUrlByPKData(notifyID, langID, imageUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImageUrlByPKAsync(string notifyID, string langID, string imageUrl, TransactionManager tm_ = null)
		{
			RepairPutImageUrlByPKData(notifyID, langID, imageUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImageUrlByPKData(string notifyID, string langID, string imageUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ImageUrl` = @ImageUrl  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ImageUrl", imageUrl != null ? imageUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
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
		#region PutContent
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContentByPK(string notifyID, string langID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(notifyID, langID, content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutContentByPKAsync(string notifyID, string langID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(notifyID, langID, content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutContentByPKData(string notifyID, string langID, string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Content` = @Content  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
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
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutContentAsync(string content, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Content` = @Content";
			var parameter_ = Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutContent
		#region PutLinkKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkKindByPK(string notifyID, string langID, int linkKind, TransactionManager tm_ = null)
		{
			RepairPutLinkKindByPKData(notifyID, langID, linkKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkKindByPKAsync(string notifyID, string langID, int linkKind, TransactionManager tm_ = null)
		{
			RepairPutLinkKindByPKData(notifyID, langID, linkKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkKindByPKData(string notifyID, string langID, int linkKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LinkKind` = @LinkKind  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LinkKind", linkKind, MySqlDbType.Int32),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkKind(int linkKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkKind` = @LinkKind";
			var parameter_ = Database.CreateInParameter("@LinkKind", linkKind, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLinkKindAsync(int linkKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LinkKind` = @LinkKind";
			var parameter_ = Database.CreateInParameter("@LinkKind", linkKind, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLinkKind
		#region PutLinkUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLinkUrlByPK(string notifyID, string langID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(notifyID, langID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLinkUrlByPKAsync(string notifyID, string langID, string linkUrl, TransactionManager tm_ = null)
		{
			RepairPutLinkUrlByPKData(notifyID, langID, linkUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLinkUrlByPKData(string notifyID, string langID, string linkUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LinkUrl` = @LinkUrl  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LinkUrl", linkUrl != null ? linkUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
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
		#region PutTxt1
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "txt1">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt1ByPK(string notifyID, string langID, string txt1, TransactionManager tm_ = null)
		{
			RepairPutTxt1ByPKData(notifyID, langID, txt1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTxt1ByPKAsync(string notifyID, string langID, string txt1, TransactionManager tm_ = null)
		{
			RepairPutTxt1ByPKData(notifyID, langID, txt1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTxt1ByPKData(string notifyID, string langID, string txt1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Txt1` = @Txt1  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Txt1", txt1 != null ? txt1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt1(string txt1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt1` = @Txt1";
			var parameter_ = Database.CreateInParameter("@Txt1", txt1 != null ? txt1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTxt1Async(string txt1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt1` = @Txt1";
			var parameter_ = Database.CreateInParameter("@Txt1", txt1 != null ? txt1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTxt1
		#region PutTxt2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "txt2">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt2ByPK(string notifyID, string langID, string txt2, TransactionManager tm_ = null)
		{
			RepairPutTxt2ByPKData(notifyID, langID, txt2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTxt2ByPKAsync(string notifyID, string langID, string txt2, TransactionManager tm_ = null)
		{
			RepairPutTxt2ByPKData(notifyID, langID, txt2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTxt2ByPKData(string notifyID, string langID, string txt2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Txt2` = @Txt2  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Txt2", txt2 != null ? txt2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt2(string txt2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt2` = @Txt2";
			var parameter_ = Database.CreateInParameter("@Txt2", txt2 != null ? txt2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTxt2Async(string txt2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt2` = @Txt2";
			var parameter_ = Database.CreateInParameter("@Txt2", txt2 != null ? txt2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTxt2
		#region PutTxt3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "txt3">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt3ByPK(string notifyID, string langID, string txt3, TransactionManager tm_ = null)
		{
			RepairPutTxt3ByPKData(notifyID, langID, txt3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTxt3ByPKAsync(string notifyID, string langID, string txt3, TransactionManager tm_ = null)
		{
			RepairPutTxt3ByPKData(notifyID, langID, txt3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTxt3ByPKData(string notifyID, string langID, string txt3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Txt3` = @Txt3  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Txt3", txt3 != null ? txt3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt3(string txt3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt3` = @Txt3";
			var parameter_ = Database.CreateInParameter("@Txt3", txt3 != null ? txt3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTxt3Async(string txt3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt3` = @Txt3";
			var parameter_ = Database.CreateInParameter("@Txt3", txt3 != null ? txt3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTxt3
		#region PutTxt4
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "txt4">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt4ByPK(string notifyID, string langID, string txt4, TransactionManager tm_ = null)
		{
			RepairPutTxt4ByPKData(notifyID, langID, txt4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTxt4ByPKAsync(string notifyID, string langID, string txt4, TransactionManager tm_ = null)
		{
			RepairPutTxt4ByPKData(notifyID, langID, txt4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTxt4ByPKData(string notifyID, string langID, string txt4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Txt4` = @Txt4  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Txt4", txt4 != null ? txt4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt4(string txt4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt4` = @Txt4";
			var parameter_ = Database.CreateInParameter("@Txt4", txt4 != null ? txt4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTxt4Async(string txt4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt4` = @Txt4";
			var parameter_ = Database.CreateInParameter("@Txt4", txt4 != null ? txt4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTxt4
		#region PutTxt5
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "txt5">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt5ByPK(string notifyID, string langID, string txt5, TransactionManager tm_ = null)
		{
			RepairPutTxt5ByPKData(notifyID, langID, txt5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTxt5ByPKAsync(string notifyID, string langID, string txt5, TransactionManager tm_ = null)
		{
			RepairPutTxt5ByPKData(notifyID, langID, txt5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTxt5ByPKData(string notifyID, string langID, string txt5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Txt5` = @Txt5  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Txt5", txt5 != null ? txt5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTxt5(string txt5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt5` = @Txt5";
			var parameter_ = Database.CreateInParameter("@Txt5", txt5 != null ? txt5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTxt5Async(string txt5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Txt5` = @Txt5";
			var parameter_ = Database.CreateInParameter("@Txt5", txt5 != null ? txt5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTxt5
		#region PutImg1
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg1ByPK(string notifyID, string langID, string img1, TransactionManager tm_ = null)
		{
			RepairPutImg1ByPKData(notifyID, langID, img1, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg1ByPKAsync(string notifyID, string langID, string img1, TransactionManager tm_ = null)
		{
			RepairPutImg1ByPKData(notifyID, langID, img1, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg1ByPKData(string notifyID, string langID, string img1, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img1` = @Img1  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img1", img1 != null ? img1 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg1(string img1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img1` = @Img1";
			var parameter_ = Database.CreateInParameter("@Img1", img1 != null ? img1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg1Async(string img1, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img1` = @Img1";
			var parameter_ = Database.CreateInParameter("@Img1", img1 != null ? img1 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg1
		#region PutImg2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg2ByPK(string notifyID, string langID, string img2, TransactionManager tm_ = null)
		{
			RepairPutImg2ByPKData(notifyID, langID, img2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg2ByPKAsync(string notifyID, string langID, string img2, TransactionManager tm_ = null)
		{
			RepairPutImg2ByPKData(notifyID, langID, img2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg2ByPKData(string notifyID, string langID, string img2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img2` = @Img2  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img2", img2 != null ? img2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg2(string img2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img2` = @Img2";
			var parameter_ = Database.CreateInParameter("@Img2", img2 != null ? img2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg2Async(string img2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img2` = @Img2";
			var parameter_ = Database.CreateInParameter("@Img2", img2 != null ? img2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg2
		#region PutImg3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg3ByPK(string notifyID, string langID, string img3, TransactionManager tm_ = null)
		{
			RepairPutImg3ByPKData(notifyID, langID, img3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg3ByPKAsync(string notifyID, string langID, string img3, TransactionManager tm_ = null)
		{
			RepairPutImg3ByPKData(notifyID, langID, img3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg3ByPKData(string notifyID, string langID, string img3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img3` = @Img3  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img3", img3 != null ? img3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg3(string img3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img3` = @Img3";
			var parameter_ = Database.CreateInParameter("@Img3", img3 != null ? img3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg3Async(string img3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img3` = @Img3";
			var parameter_ = Database.CreateInParameter("@Img3", img3 != null ? img3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg3
		#region PutImg4
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg4ByPK(string notifyID, string langID, string img4, TransactionManager tm_ = null)
		{
			RepairPutImg4ByPKData(notifyID, langID, img4, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg4ByPKAsync(string notifyID, string langID, string img4, TransactionManager tm_ = null)
		{
			RepairPutImg4ByPKData(notifyID, langID, img4, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg4ByPKData(string notifyID, string langID, string img4, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img4` = @Img4  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img4", img4 != null ? img4 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg4(string img4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img4` = @Img4";
			var parameter_ = Database.CreateInParameter("@Img4", img4 != null ? img4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg4Async(string img4, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img4` = @Img4";
			var parameter_ = Database.CreateInParameter("@Img4", img4 != null ? img4 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg4
		#region PutImg5
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg5ByPK(string notifyID, string langID, string img5, TransactionManager tm_ = null)
		{
			RepairPutImg5ByPKData(notifyID, langID, img5, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutImg5ByPKAsync(string notifyID, string langID, string img5, TransactionManager tm_ = null)
		{
			RepairPutImg5ByPKData(notifyID, langID, img5, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutImg5ByPKData(string notifyID, string langID, string img5, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Img5` = @Img5  WHERE `NotifyID` = @NotifyID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Img5", img5 != null ? img5 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutImg5(string img5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img5` = @Img5";
			var parameter_ = Database.CreateInParameter("@Img5", img5 != null ? img5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutImg5Async(string img5, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Img5` = @Img5";
			var parameter_ = Database.CreateInParameter("@Img5", img5 != null ? img5 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutImg5
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Sc_notify_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.NotifyID, item.LangID) == null)
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
		public async Task<bool> SetAsync(Sc_notify_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.NotifyID, item.LangID) == null)
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
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Sc_notify_detailEO GetByPK(string notifyID, string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(notifyID, langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<Sc_notify_detailEO> GetByPKAsync(string notifyID, string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(notifyID, langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		private void RepairGetByPKData(string notifyID, string langID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`NotifyID` = @NotifyID AND `LangID` = @LangID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 NotifyID（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNotifyIDByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`NotifyID`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetNotifyIDByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`NotifyID`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Title`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Title`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ImageUrl（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImageUrlByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ImageUrl`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetImageUrlByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ImageUrl`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Content（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetContentByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Content`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetContentByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Content`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LinkKind（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLinkKindByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LinkKind`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<int> GetLinkKindByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LinkKind`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LinkUrl（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLinkUrlByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LinkUrl`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetLinkUrlByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LinkUrl`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Txt1（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTxt1ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Txt1`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetTxt1ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Txt1`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Txt2（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTxt2ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Txt2`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetTxt2ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Txt2`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Txt3（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTxt3ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Txt3`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetTxt3ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Txt3`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Txt4（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTxt4ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Txt4`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetTxt4ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Txt4`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Txt5（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTxt5ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Txt5`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetTxt5ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Txt5`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img1（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg1ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img1`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetImg1ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img1`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img2（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg2ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img2`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetImg2ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img2`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img3（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg3ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img3`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetImg3ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img3`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img4（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg4ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img4`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetImg4ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img4`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Img5（字段）
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetImg5ByPK(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Img5`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetImg5ByPKAsync(string notifyID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Img5`", "`NotifyID` = @NotifyID AND `LangID` = @LangID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByNotifyID
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByNotifyID(string notifyID)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByNotifyIDAsync(string notifyID)
		{
			return await GetByNotifyIDAsync(notifyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByNotifyID(string notifyID, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByNotifyIDAsync(string notifyID, TransactionManager tm_)
		{
			return await GetByNotifyIDAsync(notifyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByNotifyID(string notifyID, int top_)
		{
			return GetByNotifyID(notifyID, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByNotifyIDAsync(string notifyID, int top_)
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
		public List<Sc_notify_detailEO> GetByNotifyID(string notifyID, int top_, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByNotifyIDAsync(string notifyID, int top_, TransactionManager tm_)
		{
			return await GetByNotifyIDAsync(notifyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NotifyID（字段） 查询
		/// </summary>
		/// /// <param name = "notifyID">主键GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByNotifyID(string notifyID, string sort_)
		{
			return GetByNotifyID(notifyID, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByNotifyIDAsync(string notifyID, string sort_)
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
		public List<Sc_notify_detailEO> GetByNotifyID(string notifyID, string sort_, TransactionManager tm_)
		{
			return GetByNotifyID(notifyID, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByNotifyIDAsync(string notifyID, string sort_, TransactionManager tm_)
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
		public List<Sc_notify_detailEO> GetByNotifyID(string notifyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyID` = @NotifyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByNotifyIDAsync(string notifyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`NotifyID` = @NotifyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@NotifyID", notifyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByNotifyID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言代码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTitleAsync(string title, int top_)
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
		public List<Sc_notify_detailEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTitleAsync(string title, string sort_)
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
		public List<Sc_notify_detailEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
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
		public List<Sc_notify_detailEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByImageUrl
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImageUrl(string imageUrl)
		{
			return GetByImageUrl(imageUrl, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImageUrlAsync(string imageUrl)
		{
			return await GetByImageUrlAsync(imageUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImageUrl(string imageUrl, TransactionManager tm_)
		{
			return GetByImageUrl(imageUrl, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImageUrlAsync(string imageUrl, TransactionManager tm_)
		{
			return await GetByImageUrlAsync(imageUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImageUrl(string imageUrl, int top_)
		{
			return GetByImageUrl(imageUrl, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImageUrlAsync(string imageUrl, int top_)
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
		public List<Sc_notify_detailEO> GetByImageUrl(string imageUrl, int top_, TransactionManager tm_)
		{
			return GetByImageUrl(imageUrl, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImageUrlAsync(string imageUrl, int top_, TransactionManager tm_)
		{
			return await GetByImageUrlAsync(imageUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ImageUrl（字段） 查询
		/// </summary>
		/// /// <param name = "imageUrl">图片地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImageUrl(string imageUrl, string sort_)
		{
			return GetByImageUrl(imageUrl, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImageUrlAsync(string imageUrl, string sort_)
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
		public List<Sc_notify_detailEO> GetByImageUrl(string imageUrl, string sort_, TransactionManager tm_)
		{
			return GetByImageUrl(imageUrl, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImageUrlAsync(string imageUrl, string sort_, TransactionManager tm_)
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
		public List<Sc_notify_detailEO> GetByImageUrl(string imageUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(imageUrl != null ? "`ImageUrl` = @ImageUrl" : "`ImageUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (imageUrl != null)
				paras_.Add(Database.CreateInParameter("@ImageUrl", imageUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImageUrlAsync(string imageUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(imageUrl != null ? "`ImageUrl` = @ImageUrl" : "`ImageUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (imageUrl != null)
				paras_.Add(Database.CreateInParameter("@ImageUrl", imageUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImageUrl
		#region GetByContent
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByContent(string content)
		{
			return GetByContent(content, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByContentAsync(string content)
		{
			return await GetByContentAsync(content, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByContent(string content, TransactionManager tm_)
		{
			return GetByContent(content, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByContentAsync(string content, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByContent(string content, int top_)
		{
			return GetByContent(content, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByContentAsync(string content, int top_)
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
		public List<Sc_notify_detailEO> GetByContent(string content, int top_, TransactionManager tm_)
		{
			return GetByContent(content, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByContentAsync(string content, int top_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByContent(string content, string sort_)
		{
			return GetByContent(content, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByContentAsync(string content, string sort_)
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
		public List<Sc_notify_detailEO> GetByContent(string content, string sort_, TransactionManager tm_)
		{
			return GetByContent(content, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByContentAsync(string content, string sort_, TransactionManager tm_)
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
		public List<Sc_notify_detailEO> GetByContent(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByContentAsync(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByContent
		#region GetByLinkKind
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkKind(int linkKind)
		{
			return GetByLinkKind(linkKind, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkKindAsync(int linkKind)
		{
			return await GetByLinkKindAsync(linkKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkKind(int linkKind, TransactionManager tm_)
		{
			return GetByLinkKind(linkKind, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkKindAsync(int linkKind, TransactionManager tm_)
		{
			return await GetByLinkKindAsync(linkKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkKind(int linkKind, int top_)
		{
			return GetByLinkKind(linkKind, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkKindAsync(int linkKind, int top_)
		{
			return await GetByLinkKindAsync(linkKind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkKind(int linkKind, int top_, TransactionManager tm_)
		{
			return GetByLinkKind(linkKind, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkKindAsync(int linkKind, int top_, TransactionManager tm_)
		{
			return await GetByLinkKindAsync(linkKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkKind(int linkKind, string sort_)
		{
			return GetByLinkKind(linkKind, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkKindAsync(int linkKind, string sort_)
		{
			return await GetByLinkKindAsync(linkKind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkKind(int linkKind, string sort_, TransactionManager tm_)
		{
			return GetByLinkKind(linkKind, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkKindAsync(int linkKind, string sort_, TransactionManager tm_)
		{
			return await GetByLinkKindAsync(linkKind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkKind（字段） 查询
		/// </summary>
		/// /// <param name = "linkKind">链接类型1-email 2-url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkKind(int linkKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LinkKind` = @LinkKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LinkKind", linkKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkKindAsync(int linkKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LinkKind` = @LinkKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LinkKind", linkKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByLinkKind
		#region GetByLinkUrl
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkUrl(string linkUrl)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkUrlAsync(string linkUrl)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkUrl(string linkUrl, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkUrlAsync(string linkUrl, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkUrl(string linkUrl, int top_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkUrlAsync(string linkUrl, int top_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkUrl(string linkUrl, int top_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkUrlAsync(string linkUrl, int top_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkUrl(string linkUrl, string sort_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkUrlAsync(string linkUrl, string sort_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkUrl(string linkUrl, string sort_, TransactionManager tm_)
		{
			return GetByLinkUrl(linkUrl, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkUrlAsync(string linkUrl, string sort_, TransactionManager tm_)
		{
			return await GetByLinkUrlAsync(linkUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LinkUrl（字段） 查询
		/// </summary>
		/// /// <param name = "linkUrl">链接</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByLinkUrl(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByLinkUrlAsync(string linkUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(linkUrl != null ? "`LinkUrl` = @LinkUrl" : "`LinkUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (linkUrl != null)
				paras_.Add(Database.CreateInParameter("@LinkUrl", linkUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByLinkUrl
		#region GetByTxt1
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt1(string txt1)
		{
			return GetByTxt1(txt1, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt1Async(string txt1)
		{
			return await GetByTxt1Async(txt1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt1(string txt1, TransactionManager tm_)
		{
			return GetByTxt1(txt1, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt1Async(string txt1, TransactionManager tm_)
		{
			return await GetByTxt1Async(txt1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt1(string txt1, int top_)
		{
			return GetByTxt1(txt1, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt1Async(string txt1, int top_)
		{
			return await GetByTxt1Async(txt1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt1(string txt1, int top_, TransactionManager tm_)
		{
			return GetByTxt1(txt1, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt1Async(string txt1, int top_, TransactionManager tm_)
		{
			return await GetByTxt1Async(txt1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt1(string txt1, string sort_)
		{
			return GetByTxt1(txt1, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt1Async(string txt1, string sort_)
		{
			return await GetByTxt1Async(txt1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt1(string txt1, string sort_, TransactionManager tm_)
		{
			return GetByTxt1(txt1, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt1Async(string txt1, string sort_, TransactionManager tm_)
		{
			return await GetByTxt1Async(txt1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt1（字段） 查询
		/// </summary>
		/// /// <param name = "txt1">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt1(string txt1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt1 != null ? "`Txt1` = @Txt1" : "`Txt1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt1 != null)
				paras_.Add(Database.CreateInParameter("@Txt1", txt1, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt1Async(string txt1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt1 != null ? "`Txt1` = @Txt1" : "`Txt1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt1 != null)
				paras_.Add(Database.CreateInParameter("@Txt1", txt1, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt1
		#region GetByTxt2
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt2(string txt2)
		{
			return GetByTxt2(txt2, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt2Async(string txt2)
		{
			return await GetByTxt2Async(txt2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt2(string txt2, TransactionManager tm_)
		{
			return GetByTxt2(txt2, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt2Async(string txt2, TransactionManager tm_)
		{
			return await GetByTxt2Async(txt2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt2(string txt2, int top_)
		{
			return GetByTxt2(txt2, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt2Async(string txt2, int top_)
		{
			return await GetByTxt2Async(txt2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt2(string txt2, int top_, TransactionManager tm_)
		{
			return GetByTxt2(txt2, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt2Async(string txt2, int top_, TransactionManager tm_)
		{
			return await GetByTxt2Async(txt2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt2(string txt2, string sort_)
		{
			return GetByTxt2(txt2, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt2Async(string txt2, string sort_)
		{
			return await GetByTxt2Async(txt2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt2(string txt2, string sort_, TransactionManager tm_)
		{
			return GetByTxt2(txt2, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt2Async(string txt2, string sort_, TransactionManager tm_)
		{
			return await GetByTxt2Async(txt2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt2（字段） 查询
		/// </summary>
		/// /// <param name = "txt2">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt2(string txt2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt2 != null ? "`Txt2` = @Txt2" : "`Txt2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt2 != null)
				paras_.Add(Database.CreateInParameter("@Txt2", txt2, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt2Async(string txt2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt2 != null ? "`Txt2` = @Txt2" : "`Txt2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt2 != null)
				paras_.Add(Database.CreateInParameter("@Txt2", txt2, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt2
		#region GetByTxt3
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt3(string txt3)
		{
			return GetByTxt3(txt3, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt3Async(string txt3)
		{
			return await GetByTxt3Async(txt3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt3(string txt3, TransactionManager tm_)
		{
			return GetByTxt3(txt3, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt3Async(string txt3, TransactionManager tm_)
		{
			return await GetByTxt3Async(txt3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt3(string txt3, int top_)
		{
			return GetByTxt3(txt3, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt3Async(string txt3, int top_)
		{
			return await GetByTxt3Async(txt3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt3(string txt3, int top_, TransactionManager tm_)
		{
			return GetByTxt3(txt3, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt3Async(string txt3, int top_, TransactionManager tm_)
		{
			return await GetByTxt3Async(txt3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt3(string txt3, string sort_)
		{
			return GetByTxt3(txt3, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt3Async(string txt3, string sort_)
		{
			return await GetByTxt3Async(txt3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt3(string txt3, string sort_, TransactionManager tm_)
		{
			return GetByTxt3(txt3, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt3Async(string txt3, string sort_, TransactionManager tm_)
		{
			return await GetByTxt3Async(txt3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt3（字段） 查询
		/// </summary>
		/// /// <param name = "txt3">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt3(string txt3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt3 != null ? "`Txt3` = @Txt3" : "`Txt3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt3 != null)
				paras_.Add(Database.CreateInParameter("@Txt3", txt3, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt3Async(string txt3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt3 != null ? "`Txt3` = @Txt3" : "`Txt3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt3 != null)
				paras_.Add(Database.CreateInParameter("@Txt3", txt3, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt3
		#region GetByTxt4
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt4(string txt4)
		{
			return GetByTxt4(txt4, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt4Async(string txt4)
		{
			return await GetByTxt4Async(txt4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt4(string txt4, TransactionManager tm_)
		{
			return GetByTxt4(txt4, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt4Async(string txt4, TransactionManager tm_)
		{
			return await GetByTxt4Async(txt4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt4(string txt4, int top_)
		{
			return GetByTxt4(txt4, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt4Async(string txt4, int top_)
		{
			return await GetByTxt4Async(txt4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt4(string txt4, int top_, TransactionManager tm_)
		{
			return GetByTxt4(txt4, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt4Async(string txt4, int top_, TransactionManager tm_)
		{
			return await GetByTxt4Async(txt4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt4(string txt4, string sort_)
		{
			return GetByTxt4(txt4, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt4Async(string txt4, string sort_)
		{
			return await GetByTxt4Async(txt4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt4(string txt4, string sort_, TransactionManager tm_)
		{
			return GetByTxt4(txt4, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt4Async(string txt4, string sort_, TransactionManager tm_)
		{
			return await GetByTxt4Async(txt4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt4（字段） 查询
		/// </summary>
		/// /// <param name = "txt4">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt4(string txt4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt4 != null ? "`Txt4` = @Txt4" : "`Txt4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt4 != null)
				paras_.Add(Database.CreateInParameter("@Txt4", txt4, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt4Async(string txt4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt4 != null ? "`Txt4` = @Txt4" : "`Txt4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt4 != null)
				paras_.Add(Database.CreateInParameter("@Txt4", txt4, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt4
		#region GetByTxt5
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt5(string txt5)
		{
			return GetByTxt5(txt5, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt5Async(string txt5)
		{
			return await GetByTxt5Async(txt5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt5(string txt5, TransactionManager tm_)
		{
			return GetByTxt5(txt5, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt5Async(string txt5, TransactionManager tm_)
		{
			return await GetByTxt5Async(txt5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt5(string txt5, int top_)
		{
			return GetByTxt5(txt5, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt5Async(string txt5, int top_)
		{
			return await GetByTxt5Async(txt5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt5(string txt5, int top_, TransactionManager tm_)
		{
			return GetByTxt5(txt5, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt5Async(string txt5, int top_, TransactionManager tm_)
		{
			return await GetByTxt5Async(txt5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt5(string txt5, string sort_)
		{
			return GetByTxt5(txt5, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt5Async(string txt5, string sort_)
		{
			return await GetByTxt5Async(txt5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt5(string txt5, string sort_, TransactionManager tm_)
		{
			return GetByTxt5(txt5, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt5Async(string txt5, string sort_, TransactionManager tm_)
		{
			return await GetByTxt5Async(txt5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Txt5（字段） 查询
		/// </summary>
		/// /// <param name = "txt5">文本1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByTxt5(string txt5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt5 != null ? "`Txt5` = @Txt5" : "`Txt5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt5 != null)
				paras_.Add(Database.CreateInParameter("@Txt5", txt5, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByTxt5Async(string txt5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(txt5 != null ? "`Txt5` = @Txt5" : "`Txt5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (txt5 != null)
				paras_.Add(Database.CreateInParameter("@Txt5", txt5, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByTxt5
		#region GetByImg1
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg1(string img1)
		{
			return GetByImg1(img1, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg1Async(string img1)
		{
			return await GetByImg1Async(img1, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg1(string img1, TransactionManager tm_)
		{
			return GetByImg1(img1, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg1Async(string img1, TransactionManager tm_)
		{
			return await GetByImg1Async(img1, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg1(string img1, int top_)
		{
			return GetByImg1(img1, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg1Async(string img1, int top_)
		{
			return await GetByImg1Async(img1, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg1(string img1, int top_, TransactionManager tm_)
		{
			return GetByImg1(img1, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg1Async(string img1, int top_, TransactionManager tm_)
		{
			return await GetByImg1Async(img1, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg1(string img1, string sort_)
		{
			return GetByImg1(img1, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg1Async(string img1, string sort_)
		{
			return await GetByImg1Async(img1, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg1(string img1, string sort_, TransactionManager tm_)
		{
			return GetByImg1(img1, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg1Async(string img1, string sort_, TransactionManager tm_)
		{
			return await GetByImg1Async(img1, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img1（字段） 查询
		/// </summary>
		/// /// <param name = "img1">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg1(string img1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img1 != null ? "`Img1` = @Img1" : "`Img1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img1 != null)
				paras_.Add(Database.CreateInParameter("@Img1", img1, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg1Async(string img1, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img1 != null ? "`Img1` = @Img1" : "`Img1` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img1 != null)
				paras_.Add(Database.CreateInParameter("@Img1", img1, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg1
		#region GetByImg2
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg2(string img2)
		{
			return GetByImg2(img2, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg2Async(string img2)
		{
			return await GetByImg2Async(img2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg2(string img2, TransactionManager tm_)
		{
			return GetByImg2(img2, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg2Async(string img2, TransactionManager tm_)
		{
			return await GetByImg2Async(img2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg2(string img2, int top_)
		{
			return GetByImg2(img2, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg2Async(string img2, int top_)
		{
			return await GetByImg2Async(img2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg2(string img2, int top_, TransactionManager tm_)
		{
			return GetByImg2(img2, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg2Async(string img2, int top_, TransactionManager tm_)
		{
			return await GetByImg2Async(img2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg2(string img2, string sort_)
		{
			return GetByImg2(img2, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg2Async(string img2, string sort_)
		{
			return await GetByImg2Async(img2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg2(string img2, string sort_, TransactionManager tm_)
		{
			return GetByImg2(img2, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg2Async(string img2, string sort_, TransactionManager tm_)
		{
			return await GetByImg2Async(img2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img2（字段） 查询
		/// </summary>
		/// /// <param name = "img2">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg2(string img2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img2 != null ? "`Img2` = @Img2" : "`Img2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img2 != null)
				paras_.Add(Database.CreateInParameter("@Img2", img2, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg2Async(string img2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img2 != null ? "`Img2` = @Img2" : "`Img2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img2 != null)
				paras_.Add(Database.CreateInParameter("@Img2", img2, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg2
		#region GetByImg3
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg3(string img3)
		{
			return GetByImg3(img3, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg3Async(string img3)
		{
			return await GetByImg3Async(img3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg3(string img3, TransactionManager tm_)
		{
			return GetByImg3(img3, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg3Async(string img3, TransactionManager tm_)
		{
			return await GetByImg3Async(img3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg3(string img3, int top_)
		{
			return GetByImg3(img3, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg3Async(string img3, int top_)
		{
			return await GetByImg3Async(img3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg3(string img3, int top_, TransactionManager tm_)
		{
			return GetByImg3(img3, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg3Async(string img3, int top_, TransactionManager tm_)
		{
			return await GetByImg3Async(img3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg3(string img3, string sort_)
		{
			return GetByImg3(img3, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg3Async(string img3, string sort_)
		{
			return await GetByImg3Async(img3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg3(string img3, string sort_, TransactionManager tm_)
		{
			return GetByImg3(img3, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg3Async(string img3, string sort_, TransactionManager tm_)
		{
			return await GetByImg3Async(img3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img3（字段） 查询
		/// </summary>
		/// /// <param name = "img3">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg3(string img3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img3 != null ? "`Img3` = @Img3" : "`Img3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img3 != null)
				paras_.Add(Database.CreateInParameter("@Img3", img3, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg3Async(string img3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img3 != null ? "`Img3` = @Img3" : "`Img3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img3 != null)
				paras_.Add(Database.CreateInParameter("@Img3", img3, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg3
		#region GetByImg4
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg4(string img4)
		{
			return GetByImg4(img4, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg4Async(string img4)
		{
			return await GetByImg4Async(img4, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg4(string img4, TransactionManager tm_)
		{
			return GetByImg4(img4, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg4Async(string img4, TransactionManager tm_)
		{
			return await GetByImg4Async(img4, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg4(string img4, int top_)
		{
			return GetByImg4(img4, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg4Async(string img4, int top_)
		{
			return await GetByImg4Async(img4, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg4(string img4, int top_, TransactionManager tm_)
		{
			return GetByImg4(img4, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg4Async(string img4, int top_, TransactionManager tm_)
		{
			return await GetByImg4Async(img4, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg4(string img4, string sort_)
		{
			return GetByImg4(img4, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg4Async(string img4, string sort_)
		{
			return await GetByImg4Async(img4, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg4(string img4, string sort_, TransactionManager tm_)
		{
			return GetByImg4(img4, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg4Async(string img4, string sort_, TransactionManager tm_)
		{
			return await GetByImg4Async(img4, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img4（字段） 查询
		/// </summary>
		/// /// <param name = "img4">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg4(string img4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img4 != null ? "`Img4` = @Img4" : "`Img4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img4 != null)
				paras_.Add(Database.CreateInParameter("@Img4", img4, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg4Async(string img4, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img4 != null ? "`Img4` = @Img4" : "`Img4` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img4 != null)
				paras_.Add(Database.CreateInParameter("@Img4", img4, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg4
		#region GetByImg5
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg5(string img5)
		{
			return GetByImg5(img5, 0, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg5Async(string img5)
		{
			return await GetByImg5Async(img5, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg5(string img5, TransactionManager tm_)
		{
			return GetByImg5(img5, 0, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg5Async(string img5, TransactionManager tm_)
		{
			return await GetByImg5Async(img5, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg5(string img5, int top_)
		{
			return GetByImg5(img5, top_, string.Empty, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg5Async(string img5, int top_)
		{
			return await GetByImg5Async(img5, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg5(string img5, int top_, TransactionManager tm_)
		{
			return GetByImg5(img5, top_, string.Empty, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg5Async(string img5, int top_, TransactionManager tm_)
		{
			return await GetByImg5Async(img5, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg5(string img5, string sort_)
		{
			return GetByImg5(img5, 0, sort_, null);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg5Async(string img5, string sort_)
		{
			return await GetByImg5Async(img5, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg5(string img5, string sort_, TransactionManager tm_)
		{
			return GetByImg5(img5, 0, sort_, tm_);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg5Async(string img5, string sort_, TransactionManager tm_)
		{
			return await GetByImg5Async(img5, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Img5（字段） 查询
		/// </summary>
		/// /// <param name = "img5">图片1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sc_notify_detailEO> GetByImg5(string img5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img5 != null ? "`Img5` = @Img5" : "`Img5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img5 != null)
				paras_.Add(Database.CreateInParameter("@Img5", img5, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		public async Task<List<Sc_notify_detailEO>> GetByImg5Async(string img5, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(img5 != null ? "`Img5` = @Img5" : "`Img5` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (img5 != null)
				paras_.Add(Database.CreateInParameter("@Img5", img5, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sc_notify_detailEO.MapDataReader);
		}
		#endregion // GetByImg5
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
