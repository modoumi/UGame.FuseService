/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-11-06 14: 16:56
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
	/// 用户邮件表，描述发给指定用户的邮件，通常是不批量的，或是私信
	/// 【表 sem_user_message 的实体类】
	/// </summary>
	[DataContract]
	public class Sem_user_messageEO : IRowMapper<Sem_user_messageEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Sem_user_messageEO()
		{
			this.Status = 1;
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
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string AppID { get; set; }
		/// <summary>
		/// 发送人ID
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string SenderID { get; set; }
		/// <summary>
		/// 接收人ID
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string ReceiverID { get; set; }
		/// <summary>
		/// 模板ID（null表示Data为最终信息）
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string TemplateID { get; set; }
		/// <summary>
		/// 显示分类
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int? DisplayTag { get; set; }
		/// <summary>
		/// 标题，不是模板邮件此栏位有值
		/// 【字段 varchar(200)】
		/// </summary>
		[DataMember(Order = 7)]
		public string Title { get; set; }
		/// <summary>
		/// 内容（模板数据JSON或者最终内容字符串)
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 8)]
		public string Content { get; set; }
		/// <summary>
		/// 生效日期
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 9)]
		public DateTime BeginDate { get; set; }
		/// <summary>
		/// 失效日期
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime EndDate { get; set; }
		/// <summary>
		/// 状态 0-无读1-已读
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 12)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 更新时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 13)]
		public DateTime UpdateTime { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Sem_user_messageEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Sem_user_messageEO MapDataReader(IDataReader reader)
		{
		    Sem_user_messageEO ret = new Sem_user_messageEO();
			ret.MessageID = reader.ToString("MessageID");
			ret.OriginalMessageID = ret.MessageID;
			ret.AppID = reader.ToString("AppID");
			ret.SenderID = reader.ToString("SenderID");
			ret.ReceiverID = reader.ToString("ReceiverID");
			ret.TemplateID = reader.ToString("TemplateID");
			ret.DisplayTag = reader.ToInt32N("DisplayTag");
			ret.Title = reader.ToString("Title");
			ret.Content = reader.ToString("Content");
			ret.BeginDate = reader.ToDateTime("BeginDate");
			ret.EndDate = reader.ToDateTime("EndDate");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.UpdateTime = reader.ToDateTime("UpdateTime");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户邮件表，描述发给指定用户的邮件，通常是不批量的，或是私信
	/// 【表 sem_user_message 的操作类】
	/// </summary>
	public class Sem_user_messageMO : MySqlTableMO<Sem_user_messageEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`sem_user_message`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Sem_user_messageMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Sem_user_messageMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Sem_user_messageMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Sem_user_messageEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Sem_user_messageEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Sem_user_messageEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`MessageID`, `AppID`, `SenderID`, `ReceiverID`, `TemplateID`, `DisplayTag`, `Title`, `Content`, `BeginDate`, `EndDate`, `Status`, `RecDate`, `UpdateTime`) VALUE (@MessageID, @AppID, @SenderID, @ReceiverID, @TemplateID, @DisplayTag, @Title, @Content, @BeginDate, @EndDate, @Status, @RecDate, @UpdateTime);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SenderID", item.SenderID != null ? item.SenderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ReceiverID", item.ReceiverID, MySqlDbType.VarChar),
				Database.CreateInParameter("@TemplateID", item.TemplateID != null ? item.TemplateID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DisplayTag", item.DisplayTag.HasValue ? item.DisplayTag.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UpdateTime", item.UpdateTime, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Sem_user_messageEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Sem_user_messageEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Sem_user_messageEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`MessageID`, `AppID`, `SenderID`, `ReceiverID`, `TemplateID`, `DisplayTag`, `Title`, `Content`, `BeginDate`, `EndDate`, `Status`, `RecDate`, `UpdateTime`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.MessageID}','{item.AppID}','{item.SenderID}','{item.ReceiverID}','{item.TemplateID}',{item.DisplayTag?.ToString()??null},'{item.Title}','{item.Content}','{item.BeginDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.EndDate.ToString("yyyy-MM-dd HH:mm:ss")}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		public int Remove(Sem_user_messageEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.MessageID, tm_);
		}
		public async Task<int> RemoveAsync(Sem_user_messageEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.MessageID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
		#region RemoveBySenderID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "senderID">发送人ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySenderID(string senderID, TransactionManager tm_ = null)
		{
			RepairRemoveBySenderIDData(senderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySenderIDAsync(string senderID, TransactionManager tm_ = null)
		{
			RepairRemoveBySenderIDData(senderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySenderIDData(string senderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (senderID != null ? "`SenderID` = @SenderID" : "`SenderID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (senderID != null)
				paras_.Add(Database.CreateInParameter("@SenderID", senderID, MySqlDbType.VarChar));
		}
		#endregion // RemoveBySenderID
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
		#region RemoveByTemplateID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTemplateID(string templateID, TransactionManager tm_ = null)
		{
			RepairRemoveByTemplateIDData(templateID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTemplateIDAsync(string templateID, TransactionManager tm_ = null)
		{
			RepairRemoveByTemplateIDData(templateID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTemplateIDData(string templateID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (templateID != null ? "`TemplateID` = @TemplateID" : "`TemplateID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (templateID != null)
				paras_.Add(Database.CreateInParameter("@TemplateID", templateID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTemplateID
		#region RemoveByDisplayTag
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "displayTag">显示分类</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDisplayTag(int? displayTag, TransactionManager tm_ = null)
		{
			RepairRemoveByDisplayTagData(displayTag.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDisplayTagAsync(int? displayTag, TransactionManager tm_ = null)
		{
			RepairRemoveByDisplayTagData(displayTag.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDisplayTagData(int? displayTag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (displayTag.HasValue ? "`DisplayTag` = @DisplayTag" : "`DisplayTag` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (displayTag.HasValue)
				paras_.Add(Database.CreateInParameter("@DisplayTag", displayTag.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByDisplayTag
		#region RemoveByTitle
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
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
		#region RemoveByContent
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
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
		#region RemoveByBeginDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "beginDate">生效日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBeginDate(DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByBeginDateData(beginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBeginDateData(DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BeginDate` = @BeginDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByBeginDate
		#region RemoveByEndDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "endDate">失效日期</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEndDate(DateTime endDate, TransactionManager tm_ = null)
		{
			RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
		{
			RepairRemoveByEndDateData(endDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEndDateData(DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EndDate` = @EndDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByEndDate
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态 0-无读1-已读</param>
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
		public int Put(Sem_user_messageEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Sem_user_messageEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Sem_user_messageEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MessageID` = @MessageID, `AppID` = @AppID, `SenderID` = @SenderID, `ReceiverID` = @ReceiverID, `TemplateID` = @TemplateID, `DisplayTag` = @DisplayTag, `Title` = @Title, `Content` = @Content, `BeginDate` = @BeginDate, `EndDate` = @EndDate, `Status` = @Status WHERE `MessageID` = @MessageID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", item.MessageID, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@SenderID", item.SenderID != null ? item.SenderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ReceiverID", item.ReceiverID, MySqlDbType.VarChar),
				Database.CreateInParameter("@TemplateID", item.TemplateID != null ? item.TemplateID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DisplayTag", item.DisplayTag.HasValue ? item.DisplayTag.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Content", item.Content != null ? item.Content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@BeginDate", item.BeginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@EndDate", item.EndDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID_Original", item.HasOriginal ? item.OriginalMessageID : item.MessageID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Sem_user_messageEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Sem_user_messageEO> items, TransactionManager tm_ = null)
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
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string messageID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(messageID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string messageID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(messageID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string messageID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
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
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutSenderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "senderID">发送人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSenderIDByPK(string messageID, string senderID, TransactionManager tm_ = null)
		{
			RepairPutSenderIDByPKData(messageID, senderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSenderIDByPKAsync(string messageID, string senderID, TransactionManager tm_ = null)
		{
			RepairPutSenderIDByPKData(messageID, senderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSenderIDByPKData(string messageID, string senderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SenderID` = @SenderID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SenderID", senderID != null ? senderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "senderID">发送人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSenderID(string senderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SenderID` = @SenderID";
			var parameter_ = Database.CreateInParameter("@SenderID", senderID != null ? senderID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSenderIDAsync(string senderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SenderID` = @SenderID";
			var parameter_ = Database.CreateInParameter("@SenderID", senderID != null ? senderID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSenderID
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
		#region PutTemplateID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplateIDByPK(string messageID, string templateID, TransactionManager tm_ = null)
		{
			RepairPutTemplateIDByPKData(messageID, templateID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTemplateIDByPKAsync(string messageID, string templateID, TransactionManager tm_ = null)
		{
			RepairPutTemplateIDByPKData(messageID, templateID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTemplateIDByPKData(string messageID, string templateID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TemplateID` = @TemplateID  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TemplateID", templateID != null ? templateID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTemplateID(string templateID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TemplateID` = @TemplateID";
			var parameter_ = Database.CreateInParameter("@TemplateID", templateID != null ? templateID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTemplateIDAsync(string templateID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TemplateID` = @TemplateID";
			var parameter_ = Database.CreateInParameter("@TemplateID", templateID != null ? templateID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTemplateID
		#region PutDisplayTag
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "displayTag">显示分类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDisplayTagByPK(string messageID, int? displayTag, TransactionManager tm_ = null)
		{
			RepairPutDisplayTagByPKData(messageID, displayTag, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutDisplayTagByPKAsync(string messageID, int? displayTag, TransactionManager tm_ = null)
		{
			RepairPutDisplayTagByPKData(messageID, displayTag, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutDisplayTagByPKData(string messageID, int? displayTag, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DisplayTag` = @DisplayTag  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DisplayTag", displayTag.HasValue ? displayTag.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "displayTag">显示分类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDisplayTag(int? displayTag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DisplayTag` = @DisplayTag";
			var parameter_ = Database.CreateInParameter("@DisplayTag", displayTag.HasValue ? displayTag.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDisplayTagAsync(int? displayTag, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `DisplayTag` = @DisplayTag";
			var parameter_ = Database.CreateInParameter("@DisplayTag", displayTag.HasValue ? displayTag.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDisplayTag
		#region PutTitle
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(string messageID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(messageID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(string messageID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(messageID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(string messageID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
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
		#region PutContent
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutContentByPK(string messageID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(messageID, content, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutContentByPKAsync(string messageID, string content, TransactionManager tm_ = null)
		{
			RepairPutContentByPKData(messageID, content, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutContentByPKData(string messageID, string content, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Content` = @Content  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Content", content != null ? content : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
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
		#region PutBeginDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "beginDate">生效日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBeginDateByPK(string messageID, DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairPutBeginDateByPKData(messageID, beginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBeginDateByPKAsync(string messageID, DateTime beginDate, TransactionManager tm_ = null)
		{
			RepairPutBeginDateByPKData(messageID, beginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBeginDateByPKData(string messageID, DateTime beginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "beginDate">生效日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBeginDate(DateTime beginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBeginDateAsync(DateTime beginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BeginDate` = @BeginDate";
			var parameter_ = Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBeginDate
		#region PutEndDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "endDate">失效日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndDateByPK(string messageID, DateTime endDate, TransactionManager tm_ = null)
		{
			RepairPutEndDateByPKData(messageID, endDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndDateByPKAsync(string messageID, DateTime endDate, TransactionManager tm_ = null)
		{
			RepairPutEndDateByPKData(messageID, endDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndDateByPKData(string messageID, DateTime endDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "endDate">失效日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndDate(DateTime endDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEndDateAsync(DateTime endDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndDate` = @EndDate";
			var parameter_ = Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEndDate
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "status">状态 0-无读1-已读</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string messageID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(messageID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string messageID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(messageID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string messageID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态 0-无读1-已读</param>
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
		/// /// <param name = "messageID">消息ID</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string messageID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(messageID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string messageID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(messageID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string messageID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `MessageID` = @MessageID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
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
		public bool Set(Sem_user_messageEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Sem_user_messageEO item, TransactionManager tm = null)
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
		public Sem_user_messageEO GetByPK(string messageID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(messageID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<Sem_user_messageEO> GetByPKAsync(string messageID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(messageID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
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
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SenderID（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetSenderIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`SenderID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetSenderIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`SenderID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
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
		/// 按主键查询 TemplateID（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTemplateIDByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`TemplateID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetTemplateIDByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`TemplateID`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 DisplayTag（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetDisplayTagByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`DisplayTag`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int?> GetDisplayTagByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`DisplayTag`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Title`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Title`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Content（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetContentByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Content`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<string> GetContentByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Content`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BeginDate（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetBeginDateByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`BeginDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<DateTime> GetBeginDateByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`BeginDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndDate（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetEndDateByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`EndDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<DateTime> GetEndDateByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`EndDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`MessageID` = @MessageID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "messageID">消息ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`MessageID` = @MessageID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string messageID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MessageID", messageID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`MessageID` = @MessageID", paras_, tm_);
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
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<Sem_user_messageEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<Sem_user_messageEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<Sem_user_messageEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetBySenderID
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发送人ID</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetBySenderID(string senderID)
		{
			return GetBySenderID(senderID, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetBySenderIDAsync(string senderID)
		{
			return await GetBySenderIDAsync(senderID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发送人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetBySenderID(string senderID, TransactionManager tm_)
		{
			return GetBySenderID(senderID, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetBySenderIDAsync(string senderID, TransactionManager tm_)
		{
			return await GetBySenderIDAsync(senderID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发送人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetBySenderID(string senderID, int top_)
		{
			return GetBySenderID(senderID, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetBySenderIDAsync(string senderID, int top_)
		{
			return await GetBySenderIDAsync(senderID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发送人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetBySenderID(string senderID, int top_, TransactionManager tm_)
		{
			return GetBySenderID(senderID, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetBySenderIDAsync(string senderID, int top_, TransactionManager tm_)
		{
			return await GetBySenderIDAsync(senderID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发送人ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetBySenderID(string senderID, string sort_)
		{
			return GetBySenderID(senderID, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetBySenderIDAsync(string senderID, string sort_)
		{
			return await GetBySenderIDAsync(senderID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发送人ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetBySenderID(string senderID, string sort_, TransactionManager tm_)
		{
			return GetBySenderID(senderID, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetBySenderIDAsync(string senderID, string sort_, TransactionManager tm_)
		{
			return await GetBySenderIDAsync(senderID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SenderID（字段） 查询
		/// </summary>
		/// /// <param name = "senderID">发送人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetBySenderID(string senderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(senderID != null ? "`SenderID` = @SenderID" : "`SenderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (senderID != null)
				paras_.Add(Database.CreateInParameter("@SenderID", senderID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetBySenderIDAsync(string senderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(senderID != null ? "`SenderID` = @SenderID" : "`SenderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (senderID != null)
				paras_.Add(Database.CreateInParameter("@SenderID", senderID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetBySenderID
		#region GetByReceiverID
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByReceiverID(string receiverID)
		{
			return GetByReceiverID(receiverID, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByReceiverIDAsync(string receiverID)
		{
			return await GetByReceiverIDAsync(receiverID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByReceiverID(string receiverID, TransactionManager tm_)
		{
			return GetByReceiverID(receiverID, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByReceiverIDAsync(string receiverID, TransactionManager tm_)
		{
			return await GetByReceiverIDAsync(receiverID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByReceiverID(string receiverID, int top_)
		{
			return GetByReceiverID(receiverID, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByReceiverIDAsync(string receiverID, int top_)
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
		public List<Sem_user_messageEO> GetByReceiverID(string receiverID, int top_, TransactionManager tm_)
		{
			return GetByReceiverID(receiverID, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByReceiverIDAsync(string receiverID, int top_, TransactionManager tm_)
		{
			return await GetByReceiverIDAsync(receiverID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReceiverID（字段） 查询
		/// </summary>
		/// /// <param name = "receiverID">接收人ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByReceiverID(string receiverID, string sort_)
		{
			return GetByReceiverID(receiverID, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByReceiverIDAsync(string receiverID, string sort_)
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
		public List<Sem_user_messageEO> GetByReceiverID(string receiverID, string sort_, TransactionManager tm_)
		{
			return GetByReceiverID(receiverID, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByReceiverIDAsync(string receiverID, string sort_, TransactionManager tm_)
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
		public List<Sem_user_messageEO> GetByReceiverID(string receiverID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiverID` = @ReceiverID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiverID", receiverID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByReceiverIDAsync(string receiverID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReceiverID` = @ReceiverID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReceiverID", receiverID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByReceiverID
		#region GetByTemplateID
		
		/// <summary>
		/// 按 TemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTemplateID(string templateID)
		{
			return GetByTemplateID(templateID, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByTemplateIDAsync(string templateID)
		{
			return await GetByTemplateIDAsync(templateID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTemplateID(string templateID, TransactionManager tm_)
		{
			return GetByTemplateID(templateID, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByTemplateIDAsync(string templateID, TransactionManager tm_)
		{
			return await GetByTemplateIDAsync(templateID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTemplateID(string templateID, int top_)
		{
			return GetByTemplateID(templateID, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByTemplateIDAsync(string templateID, int top_)
		{
			return await GetByTemplateIDAsync(templateID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTemplateID(string templateID, int top_, TransactionManager tm_)
		{
			return GetByTemplateID(templateID, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByTemplateIDAsync(string templateID, int top_, TransactionManager tm_)
		{
			return await GetByTemplateIDAsync(templateID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTemplateID(string templateID, string sort_)
		{
			return GetByTemplateID(templateID, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByTemplateIDAsync(string templateID, string sort_)
		{
			return await GetByTemplateIDAsync(templateID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTemplateID(string templateID, string sort_, TransactionManager tm_)
		{
			return GetByTemplateID(templateID, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByTemplateIDAsync(string templateID, string sort_, TransactionManager tm_)
		{
			return await GetByTemplateIDAsync(templateID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TemplateID（字段） 查询
		/// </summary>
		/// /// <param name = "templateID">模板ID（null表示Data为最终信息）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTemplateID(string templateID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(templateID != null ? "`TemplateID` = @TemplateID" : "`TemplateID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (templateID != null)
				paras_.Add(Database.CreateInParameter("@TemplateID", templateID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByTemplateIDAsync(string templateID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(templateID != null ? "`TemplateID` = @TemplateID" : "`TemplateID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (templateID != null)
				paras_.Add(Database.CreateInParameter("@TemplateID", templateID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByTemplateID
		#region GetByDisplayTag
		
		/// <summary>
		/// 按 DisplayTag（字段） 查询
		/// </summary>
		/// /// <param name = "displayTag">显示分类</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByDisplayTag(int? displayTag)
		{
			return GetByDisplayTag(displayTag, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByDisplayTagAsync(int? displayTag)
		{
			return await GetByDisplayTagAsync(displayTag, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DisplayTag（字段） 查询
		/// </summary>
		/// /// <param name = "displayTag">显示分类</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByDisplayTag(int? displayTag, TransactionManager tm_)
		{
			return GetByDisplayTag(displayTag, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByDisplayTagAsync(int? displayTag, TransactionManager tm_)
		{
			return await GetByDisplayTagAsync(displayTag, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DisplayTag（字段） 查询
		/// </summary>
		/// /// <param name = "displayTag">显示分类</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByDisplayTag(int? displayTag, int top_)
		{
			return GetByDisplayTag(displayTag, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByDisplayTagAsync(int? displayTag, int top_)
		{
			return await GetByDisplayTagAsync(displayTag, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 DisplayTag（字段） 查询
		/// </summary>
		/// /// <param name = "displayTag">显示分类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByDisplayTag(int? displayTag, int top_, TransactionManager tm_)
		{
			return GetByDisplayTag(displayTag, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByDisplayTagAsync(int? displayTag, int top_, TransactionManager tm_)
		{
			return await GetByDisplayTagAsync(displayTag, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 DisplayTag（字段） 查询
		/// </summary>
		/// /// <param name = "displayTag">显示分类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByDisplayTag(int? displayTag, string sort_)
		{
			return GetByDisplayTag(displayTag, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByDisplayTagAsync(int? displayTag, string sort_)
		{
			return await GetByDisplayTagAsync(displayTag, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 DisplayTag（字段） 查询
		/// </summary>
		/// /// <param name = "displayTag">显示分类</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByDisplayTag(int? displayTag, string sort_, TransactionManager tm_)
		{
			return GetByDisplayTag(displayTag, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByDisplayTagAsync(int? displayTag, string sort_, TransactionManager tm_)
		{
			return await GetByDisplayTagAsync(displayTag, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 DisplayTag（字段） 查询
		/// </summary>
		/// /// <param name = "displayTag">显示分类</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByDisplayTag(int? displayTag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(displayTag.HasValue ? "`DisplayTag` = @DisplayTag" : "`DisplayTag` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (displayTag.HasValue)
				paras_.Add(Database.CreateInParameter("@DisplayTag", displayTag.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByDisplayTagAsync(int? displayTag, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(displayTag.HasValue ? "`DisplayTag` = @DisplayTag" : "`DisplayTag` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (displayTag.HasValue)
				paras_.Add(Database.CreateInParameter("@DisplayTag", displayTag.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByDisplayTag
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByTitleAsync(string title, int top_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByTitleAsync(string title, string sort_)
		{
			return await GetByTitleAsync(title, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">标题，不是模板邮件此栏位有值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByContent
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByContent(string content)
		{
			return GetByContent(content, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByContentAsync(string content)
		{
			return await GetByContentAsync(content, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByContent(string content, TransactionManager tm_)
		{
			return GetByContent(content, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByContentAsync(string content, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByContent(string content, int top_)
		{
			return GetByContent(content, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByContentAsync(string content, int top_)
		{
			return await GetByContentAsync(content, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByContent(string content, int top_, TransactionManager tm_)
		{
			return GetByContent(content, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByContentAsync(string content, int top_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByContent(string content, string sort_)
		{
			return GetByContent(content, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByContentAsync(string content, string sort_)
		{
			return await GetByContentAsync(content, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByContent(string content, string sort_, TransactionManager tm_)
		{
			return GetByContent(content, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByContentAsync(string content, string sort_, TransactionManager tm_)
		{
			return await GetByContentAsync(content, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Content（字段） 查询
		/// </summary>
		/// /// <param name = "content">内容（模板数据JSON或者最终内容字符串)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByContent(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByContentAsync(string content, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(content != null ? "`Content` = @Content" : "`Content` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (content != null)
				paras_.Add(Database.CreateInParameter("@Content", content, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByContent
		#region GetByBeginDate
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">生效日期</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByBeginDate(DateTime beginDate)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByBeginDateAsync(DateTime beginDate)
		{
			return await GetByBeginDateAsync(beginDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">生效日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByBeginDate(DateTime beginDate, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByBeginDateAsync(DateTime beginDate, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">生效日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByBeginDate(DateTime beginDate, int top_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByBeginDateAsync(DateTime beginDate, int top_)
		{
			return await GetByBeginDateAsync(beginDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">生效日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByBeginDate(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByBeginDateAsync(DateTime beginDate, int top_, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">生效日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByBeginDate(DateTime beginDate, string sort_)
		{
			return GetByBeginDate(beginDate, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByBeginDateAsync(DateTime beginDate, string sort_)
		{
			return await GetByBeginDateAsync(beginDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">生效日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByBeginDate(DateTime beginDate, string sort_, TransactionManager tm_)
		{
			return GetByBeginDate(beginDate, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByBeginDateAsync(DateTime beginDate, string sort_, TransactionManager tm_)
		{
			return await GetByBeginDateAsync(beginDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BeginDate（字段） 查询
		/// </summary>
		/// /// <param name = "beginDate">生效日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByBeginDate(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByBeginDateAsync(DateTime beginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BeginDate` = @BeginDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BeginDate", beginDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByBeginDate
		#region GetByEndDate
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">失效日期</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByEndDate(DateTime endDate)
		{
			return GetByEndDate(endDate, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByEndDateAsync(DateTime endDate)
		{
			return await GetByEndDateAsync(endDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">失效日期</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByEndDate(DateTime endDate, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByEndDateAsync(DateTime endDate, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">失效日期</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByEndDate(DateTime endDate, int top_)
		{
			return GetByEndDate(endDate, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByEndDateAsync(DateTime endDate, int top_)
		{
			return await GetByEndDateAsync(endDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">失效日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByEndDate(DateTime endDate, int top_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByEndDateAsync(DateTime endDate, int top_, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">失效日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByEndDate(DateTime endDate, string sort_)
		{
			return GetByEndDate(endDate, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByEndDateAsync(DateTime endDate, string sort_)
		{
			return await GetByEndDateAsync(endDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">失效日期</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByEndDate(DateTime endDate, string sort_, TransactionManager tm_)
		{
			return GetByEndDate(endDate, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByEndDateAsync(DateTime endDate, string sort_, TransactionManager tm_)
		{
			return await GetByEndDateAsync(endDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndDate（字段） 查询
		/// </summary>
		/// /// <param name = "endDate">失效日期</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByEndDate(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByEndDateAsync(DateTime endDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndDate` = @EndDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndDate", endDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByEndDate
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-无读1-已读</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-无读1-已读</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-无读1-已读</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-无读1-已读</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-无读1-已读</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-无读1-已读</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态 0-无读1-已读</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Sem_user_messageEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Sem_user_messageEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Sem_user_messageEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByUpdateTime
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByUpdateTime(DateTime updateTime)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByUpdateTimeAsync(DateTime updateTime)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByUpdateTime(DateTime updateTime, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByUpdateTime(DateTime updateTime, int top_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_)
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
		public List<Sem_user_messageEO> GetByUpdateTime(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, top_, string.Empty, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, TransactionManager tm_)
		{
			return await GetByUpdateTimeAsync(updateTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UpdateTime（字段） 查询
		/// </summary>
		/// /// <param name = "updateTime">更新时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Sem_user_messageEO> GetByUpdateTime(DateTime updateTime, string sort_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, null);
		}
		public async Task<List<Sem_user_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_)
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
		public List<Sem_user_messageEO> GetByUpdateTime(DateTime updateTime, string sort_, TransactionManager tm_)
		{
			return GetByUpdateTime(updateTime, 0, sort_, tm_);
		}
		public async Task<List<Sem_user_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, string sort_, TransactionManager tm_)
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
		public List<Sem_user_messageEO> GetByUpdateTime(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		public async Task<List<Sem_user_messageEO>> GetByUpdateTimeAsync(DateTime updateTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UpdateTime` = @UpdateTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UpdateTime", updateTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Sem_user_messageEO.MapDataReader);
		}
		#endregion // GetByUpdateTime
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
