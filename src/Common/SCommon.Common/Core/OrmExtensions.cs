using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using TinyFx.Data;
using TinyFx.Data.MySql;

namespace UGame.FuseService.Common.Core;

public static class OrmExtensions
{
    private static Type[] valueTypes = new Type[] {typeof(byte),typeof(sbyte),typeof(short),typeof(ushort),
        typeof(int),typeof(uint),typeof(long),typeof(ulong),typeof(float),typeof(double),typeof(decimal),
        typeof(bool),typeof(string),typeof(char),typeof(Guid),typeof(DateTime),typeof(DateTimeOffset),
        typeof(TimeSpan),typeof(TimeOnly),typeof(DateOnly),typeof(DBNull)};

    private static readonly ConcurrentDictionary<Type, object> valueDeserializerCache = new();
    private static readonly ConcurrentDictionary<int, object> queryReaderDeserializerCache = new();
    private static readonly ConcurrentDictionary<int, Action<IDbCommand, object>> rawSqlCommandInitializerCache = new();
    private static readonly ConcurrentDictionary<int, Func<IDbCommand, object, string>> createCommandInitializerCache = new();
    private static readonly ConcurrentDictionary<int, (string HeadSql, Action<IDbCommand, StringBuilder, object, int> CommandInitializer)> createBulkCommandInitializerCache = new();
    private static readonly ConcurrentDictionary<int, Func<IDbCommand, object, string>> updateCommandInitializerCache = new();
    private static readonly ConcurrentDictionary<int, Action<IDbCommand, StringBuilder, object, int>> updateBulkCommandInitializerCache = new();
    private static readonly ConcurrentDictionary<int, Func<IDbCommand, object, string>> deleteCommandInitializerCache = new();
    private static readonly ConcurrentDictionary<int, Action<IDbCommand, StringBuilder, object, int>> deleteBulkCommandInitializerCache = new();

    public static MySqlDatabase UseReadDb(this MySqlDatabase database)
    {
        database.UseReadConnectionString = true;
        return database;
    }
    public static async Task<TEntity> QueryFirstAsync<TEntity>(this MySqlDatabase database, string rawSql, object parameters = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(rawSql))
            throw new ArgumentNullException(nameof(rawSql));

        var connString = database.ConnectionString;
        using var connection = new MySqlConnection(connString);
        using var command = connection.CreateCommand();
        MySqlDataReader reader = null;
        TEntity result = default;
        try
        {
            command.CommandText = rawSql;
            command.CommandType = CommandType.Text;
            if (parameters != null)
            {
                var parametersType = parameters.GetType();
                var commandInitializer = BuildRawSqlParameters(rawSql, parametersType);
                commandInitializer.Invoke(command, parameters);
            }
            await connection.OpenAsync(cancellationToken);
            var behavior = CommandBehavior.SequentialAccess | CommandBehavior.SingleResult | CommandBehavior.SingleRow;
            reader = await command.ExecuteReaderAsync(behavior, cancellationToken);
            var targetType = typeof(TEntity);
            if (await reader.ReadAsync(cancellationToken))
            {
                if (targetType.IsEntityType(out _))
                    result = reader.To<TEntity>();
                else result = reader.ToValue<TEntity>();
            }
        }
        finally
        {
            if (reader != null)
                await reader.DisposeAsync();
            await command.DisposeAsync();
            await connection.DisposeAsync();
        }
        return result;
    }
    public static async Task<List<TEntity>> QueryAsync<TEntity>(this MySqlDatabase database, string rawSql, object parameters = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(rawSql))
            throw new ArgumentNullException(nameof(rawSql));

        var connString = database.ConnectionString;
        using var connection = new MySqlConnection(connString);
        using var command = connection.CreateCommand();
        MySqlDataReader reader = null;
        var result = new List<TEntity>();
        try
        {
            command.CommandText = rawSql;
            command.CommandType = CommandType.Text;
            if (parameters != null)
            {
                var parametersType = parameters.GetType();
                var commandInitializer = BuildRawSqlParameters(rawSql, parametersType);
                commandInitializer.Invoke(command, parameters);
            }
            await connection.OpenAsync(cancellationToken);
            var behavior = CommandBehavior.SequentialAccess;
            reader = await command.ExecuteReaderAsync(behavior, cancellationToken);
            var targetType = typeof(TEntity);
            if (targetType.IsEntityType(out _))
            {
                while (await reader.ReadAsync(cancellationToken))
                {
                    result.Add(reader.To<TEntity>());
                }
            }
            else
            {
                while (await reader.ReadAsync(cancellationToken))
                {
                    result.Add(reader.ToValue<TEntity>());
                }
            }
        }
        finally
        {
            if (reader != null)
                await reader.DisposeAsync();
            await command.DisposeAsync();
            await connection.DisposeAsync();
        }
        return result;
    }
    public static async Task<int> ExecuteAsync(this MySqlDatabase database, string rawSql, object parameters = null, TransactionManager tm = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(rawSql))
            throw new ArgumentNullException(nameof(rawSql));

        DbConnection connection = null;
        DbTransaction transaction = null;
        int result = 0;
        bool isNeedClose = true;
        if (tm != null)
        {
            transaction = tm.GetTransaction(database);
            connection = transaction?.Connection;
            isNeedClose = connection == null;
        }
        connection ??= new MySqlConnection(database.ConnectionString);
        using var command = connection.CreateCommand();
        try
        {
            command.CommandText = rawSql;
            command.CommandType = CommandType.Text;
            if (parameters != null)
            {
                var parametersType = parameters.GetType();
                var commandInitializer = BuildRawSqlParameters(rawSql, parametersType);
                commandInitializer.Invoke(command, parameters);
            }
            if (connection.State != ConnectionState.Open)
                await connection.OpenAsync(cancellationToken);
            result = await command.ExecuteNonQueryAsync(cancellationToken);
        }
        catch (Exception ex)
        {
            isNeedClose = true;
        }
        finally
        {
            await command.DisposeAsync();
            if (isNeedClose) await connection.DisposeAsync();
        }
        return result;
    }
    public static async Task<SqlReader> QueryMultipleAsync(this MySqlDatabase database, string rawSql, object parameters = null, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrEmpty(rawSql))
            throw new ArgumentNullException(nameof(rawSql));

        var connString = database.ConnectionString;
        var connection = new MySqlConnection(connString);
        var command = connection.CreateCommand();
        MySqlDataReader reader = null;
        try
        {
            command.CommandText = rawSql;
            command.CommandType = CommandType.Text;
            if (parameters != null)
            {
                var parametersType = parameters.GetType();
                var commandInitializer = BuildRawSqlParameters(rawSql, parametersType);
                commandInitializer.Invoke(command, parameters);
            }

            await connection.OpenAsync(cancellationToken);
            var behavior = CommandBehavior.SequentialAccess;
            reader = await command.ExecuteReaderAsync(behavior, cancellationToken);
        }
        catch (Exception ex)
        {
            if (reader != null)
                await reader.DisposeAsync();
            await command.DisposeAsync();
            await connection.DisposeAsync();
        }
        return new SqlReader(command, reader);
    }
    public static async Task<int> CreateAsync<TEntity>(this MySqlDatabase database, string tableName, object parameters, int bulkCount = 200, TransactionManager tm = null, CancellationToken cancellationToken = default)
    {
        if (parameters == null)
            throw new ArgumentNullException(nameof(parameters));

        DbConnection connection = null;
        DbTransaction transaction = null;
        bool isNeedClose = true;
        if (tm != null)
        {
            transaction = tm.GetTransaction(database);
            connection = transaction?.Connection;
            isNeedClose = false;
        }
        connection ??= new MySqlConnection(database.ConnectionString);
        using var command = connection.CreateCommand();
        int result = 0;
        try
        {
            command.CommandType = CommandType.Text;
            bool isBulk = parameters is IEnumerable && parameters is not string && parameters is not IDictionary<string, object>;
            Type parameterType = null;
            if (isBulk)
            {
                var entities = parameters as IEnumerable;
                foreach (var parameter in entities)
                {
                    parameterType = parameter.GetType();
                    break;
                }
                int index = 0;
                var commandInitializer = BuildCreateBulkSqlParameters(tableName, typeof(TEntity), parameterType, out var headSql);
                var sqlBuilder = new StringBuilder(headSql);
                foreach (var entity in entities)
                {
                    if (index > 0) sqlBuilder.Append(',');
                    commandInitializer.Invoke(command, sqlBuilder, entity, index);
                    if (index >= bulkCount)
                    {
                        command.CommandText = sqlBuilder.ToString();
                        if (connection.State != ConnectionState.Open)
                            await connection.OpenAsync(cancellationToken);
                        result += await command.ExecuteNonQueryAsync(cancellationToken);
                        command.Parameters.Clear();
                        sqlBuilder.Clear();
                        index = 0;
                        sqlBuilder.Append(headSql);
                        continue;
                    }
                    index++;
                }
                if (index > 0)
                {
                    command.CommandText = sqlBuilder.ToString();
                    if (connection.State != ConnectionState.Open)
                        await connection.OpenAsync(cancellationToken);
                    result += await command.ExecuteNonQueryAsync(cancellationToken);
                }
                sqlBuilder.Clear();
            }
            else
            {
                parameterType = parameters.GetType();
                var commandInitializer = BuildCreateSqlParameters(tableName, typeof(TEntity), parameterType);
                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync(cancellationToken);
                command.CommandText = commandInitializer.Invoke(command, parameters);
                result = await command.ExecuteNonQueryAsync(cancellationToken);
            }
        }
        catch (Exception ex)
        {
            isNeedClose = true;
        }
        finally
        {
            await command.DisposeAsync();
            if (isNeedClose) await connection.DisposeAsync();
        }
        return result;
    }
    public static async Task<int> UpdateAsync<TEntity>(this MySqlDatabase database, string tableName, object parameters, string[] whereFields, int bulkCount = 200, TransactionManager tm = null, CancellationToken cancellationToken = default)
    {
        if (parameters == null)
            throw new ArgumentNullException(nameof(parameters));

        DbConnection connection = null;
        DbTransaction transaction = null;
        bool isNeedClose = true;
        if (tm != null)
        {
            transaction = tm.GetTransaction(database);
            connection = transaction?.Connection;
            isNeedClose = false;
        }
        connection ??= new MySqlConnection(database.ConnectionString);
        using var command = connection.CreateCommand();
        int result = 0;
        try
        {
            command.CommandType = CommandType.Text;
            bool isBulk = parameters is IEnumerable && parameters is not string && parameters is not IDictionary<string, object>;
            Type parameterType = null;
            if (isBulk)
            {
                var entities = parameters as IEnumerable;
                foreach (var parameter in entities)
                {
                    parameterType = parameter.GetType();
                    break;
                }
                int index = 0;
                var commandInitializer = BuildUpdateBulkSqlParameters(tableName, typeof(TEntity), parameterType, whereFields);
                var sqlBuilder = new StringBuilder();
                foreach (var entity in entities)
                {
                    commandInitializer.Invoke(command, sqlBuilder, entity, index);
                    if (index >= bulkCount)
                    {
                        command.CommandText = sqlBuilder.ToString();
                        if (connection.State != ConnectionState.Open)
                            await connection.OpenAsync(cancellationToken);
                        result += await command.ExecuteNonQueryAsync(cancellationToken);
                        command.Parameters.Clear();
                        sqlBuilder.Clear();
                        index = 0;
                        continue;
                    }
                    index++;
                }
                if (index > 0)
                {
                    command.CommandText = sqlBuilder.ToString();
                    if (connection.State != ConnectionState.Open)
                        await connection.OpenAsync(cancellationToken);
                    result += await command.ExecuteNonQueryAsync(cancellationToken);
                }
                sqlBuilder.Clear();
            }
            else
            {
                parameterType = parameters.GetType();
                var commandInitializer = BuildUpdateSqlParameters(tableName, typeof(TEntity), parameterType, whereFields);
                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync(cancellationToken);
                command.CommandText = commandInitializer.Invoke(command, parameters);
                result = await command.ExecuteNonQueryAsync(cancellationToken);
            }
        }
        catch (Exception ex)
        {
            isNeedClose = true;
        }
        finally
        {
            await command.DisposeAsync();
            if (isNeedClose) await connection.DisposeAsync();
        }
        return result;
    }
    public static async Task<int> DeleteAsync<TEntity>(this MySqlDatabase database, string tableName, object parameters, string[] whereFields, int bulkCount = 200, TransactionManager tm = null, CancellationToken cancellationToken = default)
    {
        if (parameters == null)
            throw new ArgumentNullException(nameof(parameters));

        DbConnection connection = null;
        DbTransaction transaction = null;
        bool isNeedClose = true;
        if (tm != null)
        {
            transaction = tm.GetTransaction(database);
            connection = transaction?.Connection;
            isNeedClose = false;
        }
        connection ??= new MySqlConnection(database.ConnectionString);
        using var command = connection.CreateCommand();
        int result = 0;
        try
        {
            command.CommandType = CommandType.Text;
            bool isBulk = parameters is IEnumerable && parameters is not string && parameters is not IDictionary<string, object>;
            Type parameterType = null;
            if (isBulk)
            {
                var entities = parameters as IEnumerable;
                foreach (var parameter in entities)
                {
                    parameterType = parameter.GetType();
                    break;
                }
                int index = 0;
                var commandInitializer = BuildDeleteBulkSqlParameters(tableName, typeof(TEntity), parameterType, whereFields);
                var sqlBuilder = new StringBuilder();
                foreach (var entity in entities)
                {
                    commandInitializer.Invoke(command, sqlBuilder, entity, index);
                    if (index >= bulkCount)
                    {
                        command.CommandText = sqlBuilder.ToString();
                        if (connection.State != ConnectionState.Open)
                            await connection.OpenAsync(cancellationToken);
                        result += await command.ExecuteNonQueryAsync(cancellationToken);
                        command.Parameters.Clear();
                        sqlBuilder.Clear();
                        index = 0;
                        continue;
                    }
                    index++;
                }
                if (index > 0)
                {
                    command.CommandText = sqlBuilder.ToString();
                    if (connection.State != ConnectionState.Open)
                        await connection.OpenAsync(cancellationToken);
                    result += await command.ExecuteNonQueryAsync(cancellationToken);
                }
                sqlBuilder.Clear();
            }
            else
            {
                parameterType = parameters.GetType();
                var commandInitializer = BuildDeleteSqlParameters(tableName, typeof(TEntity), parameterType, whereFields);
                if (connection.State != ConnectionState.Open)
                    await connection.OpenAsync(cancellationToken);
                command.CommandText = commandInitializer.Invoke(command, parameters);
                result = await command.ExecuteNonQueryAsync(cancellationToken);
            }
        }
        catch (Exception ex)
        {
            isNeedClose = true;
        }
        finally
        {
            await command.DisposeAsync();
            if (isNeedClose) await connection.DisposeAsync();
        }
        return result;
    }

    public static TEntity To<TEntity>(this IDataReader reader)
    {
        var entityType = typeof(TEntity);
        var cacheKey = GetTypeReaderKey(entityType, reader);
        if (!queryReaderDeserializerCache.TryGetValue(cacheKey, out var deserializer))
        {
            deserializer = CreateReaderDeserializer(reader, entityType);
            queryReaderDeserializerCache.TryAdd(cacheKey, deserializer);
        }
        var typedDeserializer = deserializer as Func<IDataReader, TEntity>;
        return typedDeserializer.Invoke(reader);
    }
    public static TValue ToValue<TValue>(this IDataReader reader)
    {
        var targetType = typeof(TValue);
        if (!valueDeserializerCache.TryGetValue(targetType, out var deserializer))
        {
            var fieldType = reader.GetFieldType(0);
            deserializer = CreateReaderValueConverter(targetType, fieldType);
            valueDeserializerCache.TryAdd(targetType, deserializer);
        }
        var typedDeserializer = deserializer as Func<IDataReader, TValue>;
        return typedDeserializer.Invoke(reader);
    }
    private static object CreateReaderValueConverter(Type targetType, Type fieldType)
    {
        var blockParameters = new List<ParameterExpression>();
        var blockBodies = new List<Expression>();
        var readerExpr = Expression.Parameter(typeof(IDataReader), "reader");
        var indexExpr = Expression.Constant(0, typeof(int));

        var resultLabelExpr = Expression.Label(targetType);
        var readerValueExpr = GetReaderValue(readerExpr, indexExpr, targetType, fieldType, blockParameters, blockBodies);
        blockBodies.Add(Expression.Return(resultLabelExpr, readerValueExpr));
        blockBodies.Add(Expression.Label(resultLabelExpr, Expression.Default(targetType)));
        return Expression.Lambda(Expression.Block(blockParameters, blockBodies), readerExpr).Compile();
    }
    private static Action<IDbCommand, object> BuildRawSqlParameters(string rawSql, Type parameterType)
    {
        var cacheKey = HashCode.Combine(rawSql, parameterType);
        if (!rawSqlCommandInitializerCache.TryGetValue(cacheKey, out var commandInitializer))
        {
            var memberInfos = parameterType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();
            var commandExpr = Expression.Parameter(typeof(IDbCommand), "command");
            var parameterExpr = Expression.Parameter(typeof(object), "parameter");

            var typedParameterExpr = Expression.Variable(parameterType, "typedParameter");
            var blockParameters = new List<ParameterExpression>();
            var blockBodies = new List<Expression>();
            blockParameters.Add(typedParameterExpr);
            blockBodies.Add(Expression.Assign(typedParameterExpr, Expression.Convert(parameterExpr, parameterType)));
            var dbParametersExpr = Expression.Property(commandExpr, nameof(IDbCommand.Parameters));

            foreach (var memberInfo in memberInfos)
            {
                var parameterName = "@" + memberInfo.Name;
                if (!Regex.IsMatch(rawSql, parameterName + @"([^\p{L}\p{N}_]+|$)", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.CultureInvariant))
                    continue;
                var parameterNameExpr = Expression.Constant(parameterName);

                Expression fieldValueExpr = Expression.PropertyOrField(typedParameterExpr, memberInfo.Name);
                if (fieldValueExpr.Type != typeof(object))
                    fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));

                //var dbParameter = new MySqlParameter("@Name", objValue);
                var constructor = typeof(MySqlParameter).GetConstructor(new Type[] { typeof(string), typeof(object) });
                var dbParameterExpr = Expression.New(constructor, parameterNameExpr, fieldValueExpr);

                var methodInfo = typeof(IList).GetMethod(nameof(IDbCommand.Parameters.Add));
                var addParameterExpr = Expression.Call(dbParametersExpr, methodInfo, dbParameterExpr);
                blockBodies.Add(addParameterExpr);
            }
            commandInitializer = Expression.Lambda<Action<IDbCommand, object>>(Expression.Block(blockParameters, blockBodies), commandExpr, parameterExpr).Compile();
            rawSqlCommandInitializerCache.TryAdd(cacheKey, commandInitializer);
        }
        return commandInitializer;
    }
    private static Func<IDbCommand, object, string> BuildCreateSqlParameters(string tableName, Type entityType, Type parameterType)
    {
        var cacheKey = HashCode.Combine(entityType, parameterType);
        if (!createCommandInitializerCache.TryGetValue(cacheKey, out var commandInitializer))
        {
            var memberInfos = entityType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();
            var parameterMemberInfos = parameterType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();

            var commandExpr = Expression.Parameter(typeof(IDbCommand), "command");
            var insertObjExpr = Expression.Parameter(typeof(object), "insertObj");

            var blockParameters = new List<ParameterExpression>();
            var blockBodies = new List<Expression>();
            var typedParameterExpr = Expression.Variable(parameterType, "typedParameter");
            blockParameters.Add(typedParameterExpr);
            blockBodies.Add(Expression.Assign(typedParameterExpr, Expression.Convert(insertObjExpr, parameterType)));

            var addMethodInfo = typeof(IList).GetMethod(nameof(IList.Add));
            var dbParametersExpr = Expression.Property(commandExpr, nameof(IDbCommand.Parameters));

            int index = 0;
            var insertBuilder = new StringBuilder($"INSERT IGNORE INTO `{tableName}`(");
            var valuesBuilder = new StringBuilder(") VALUES(");
            foreach (var memberInfo in parameterMemberInfos)
            {
                if (!memberInfos.Exists(f => string.Equals(memberInfo.Name, f.Name, StringComparison.OrdinalIgnoreCase)))
                    continue;

                if (index > 0)
                {
                    insertBuilder.Append(',');
                    valuesBuilder.Append(',');
                }
                insertBuilder.Append($"`{memberInfo.Name}`");
                valuesBuilder.Append($"@{memberInfo.Name}");

                Expression fieldValueExpr = Expression.PropertyOrField(typedParameterExpr, memberInfo.Name);
                if (fieldValueExpr.Type != typeof(object))
                    fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));

                var dbNullExpr = Expression.Convert(Expression.Constant(DBNull.Value), typeof(object));
                var equalExpr = Expression.Equal(fieldValueExpr, Expression.Constant(null));
                fieldValueExpr = Expression.Condition(equalExpr, dbNullExpr, fieldValueExpr);

                //var dbParameter = new MySqlParameter("@Name", objValue);
                var constructor = typeof(MySqlParameter).GetConstructor(new Type[] { typeof(string), typeof(object) });
                var parameterNameExpr = Expression.Constant($"@{memberInfo.Name}");
                var dbParameterExpr = Expression.New(constructor, parameterNameExpr, fieldValueExpr);

                var addParameterExpr = Expression.Call(dbParametersExpr, addMethodInfo, dbParameterExpr);
                blockBodies.Add(addParameterExpr);
                index++;
            }
            var sql = insertBuilder.Append(valuesBuilder).Append(')').ToString();
            var returnExpr = Expression.Constant(sql);
            var resultLabelExpr = Expression.Label(typeof(string));
            blockBodies.Add(Expression.Return(resultLabelExpr, returnExpr));
            blockBodies.Add(Expression.Label(resultLabelExpr, Expression.Default(typeof(string))));

            commandInitializer = Expression.Lambda<Func<IDbCommand, object, string>>(
                 Expression.Block(blockParameters, blockBodies), commandExpr, insertObjExpr).Compile();
            createCommandInitializerCache.TryAdd(cacheKey, commandInitializer);
        }
        return commandInitializer;
    }
    private static Action<IDbCommand, StringBuilder, object, int> BuildCreateBulkSqlParameters(string tableName, Type entityType, Type parameterType, out string headSql)
    {
        var cacheKey = HashCode.Combine(entityType, parameterType);
        headSql = null;
        if (!createBulkCommandInitializerCache.TryGetValue(cacheKey, out var sqlCommandInitializer))
        {
            var memberInfos = entityType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();
            var parameterMemberInfos = parameterType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();

            int index = 0;
            var builder = new StringBuilder($"INSERT IGNORE INTO `{tableName}`(");
            foreach (var memberInfo in parameterMemberInfos)
            {
                if (!memberInfos.Exists(f => string.Equals(memberInfo.Name, f.Name, StringComparison.OrdinalIgnoreCase)))
                    continue;

                if (index > 0) builder.Append(',');
                builder.Append($"`{memberInfo.Name}`");
                index++;
            }
            sqlCommandInitializer.HeadSql = builder.Append(") VALUES").ToString();

            var commandExpr = Expression.Parameter(typeof(IDbCommand), "command");
            var builderExpr = Expression.Parameter(typeof(StringBuilder), "builder");
            var insertObjExpr = Expression.Parameter(typeof(object), "insertObj");
            var indexExpr = Expression.Parameter(typeof(int), "index");

            var blockParameters = new List<ParameterExpression>();
            var blockBodies = new List<Expression>();
            var typedParameterExpr = Expression.Variable(parameterType, "typedParameter");
            blockParameters.Add(typedParameterExpr);
            blockBodies.Add(Expression.Assign(typedParameterExpr, Expression.Convert(insertObjExpr, parameterType)));

            var appendMethodInfo1 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(char) });
            var appendMethodInfo2 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(string) });
            var concatMethodInfo = typeof(string).GetMethod(nameof(string.Concat), new Type[] { typeof(string), typeof(string) });
            var toStringMethodInfo = typeof(int).GetMethod(nameof(int.ToString), Type.EmptyTypes);
            var addMethodInfo = typeof(IList).GetMethod(nameof(IList.Add));
            var dbParametersExpr = Expression.Property(commandExpr, nameof(IDbCommand.Parameters));

            int columnIndex = 0;
            blockBodies.Add(Expression.Call(builderExpr, appendMethodInfo1, Expression.Constant('(')));
            foreach (var memberInfo in parameterMemberInfos)
            {
                if (!memberInfos.Exists(f => string.Equals(memberInfo.Name, f.Name, StringComparison.OrdinalIgnoreCase)))
                    continue;

                if (columnIndex > 0) blockBodies.Add(Expression.Call(builderExpr, appendMethodInfo1, Expression.Constant(',')));

                var parameterName = $"@{memberInfo.Name}";
                var toStringExpr = Expression.Call(indexExpr, toStringMethodInfo);
                Expression parameterNameExpr = Expression.Call(concatMethodInfo, Expression.Constant(parameterName), toStringExpr);
                blockBodies.Add(Expression.Call(builderExpr, appendMethodInfo2, parameterNameExpr));

                Expression fieldValueExpr = Expression.PropertyOrField(typedParameterExpr, memberInfo.Name);
                if (fieldValueExpr.Type.IsClass || fieldValueExpr.Type.IsNullableType(out _))
                {
                    var equalExpr = Expression.Equal(fieldValueExpr, Expression.Constant(null));
                    if (fieldValueExpr.Type != typeof(object))
                        fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));
                    var dbNullExpr = Expression.Convert(Expression.Constant(DBNull.Value), typeof(object));
                    fieldValueExpr = Expression.Condition(equalExpr, dbNullExpr, fieldValueExpr);
                }
                else if (fieldValueExpr.Type != typeof(object))
                    fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));

                //var dbParameter = new MySqlParameter("@Name", objValue);
                var constructor = typeof(MySqlParameter).GetConstructor(new Type[] { typeof(string), typeof(object) });
                var dbParameterExpr = Expression.New(constructor, parameterNameExpr, fieldValueExpr);

                var methodInfo = typeof(IList).GetMethod(nameof(IDbCommand.Parameters.Add));
                var addParameterExpr = Expression.Call(dbParametersExpr, methodInfo, dbParameterExpr);
                blockBodies.Add(addParameterExpr);
                columnIndex++;
            }
            blockBodies.Add(Expression.Call(builderExpr, appendMethodInfo1, Expression.Constant(')')));

            sqlCommandInitializer.CommandInitializer = Expression.Lambda<Action<IDbCommand, StringBuilder, object, int>>(
                Expression.Block(blockParameters, blockBodies), commandExpr, builderExpr, insertObjExpr, indexExpr).Compile();
            createBulkCommandInitializerCache.TryAdd(cacheKey, sqlCommandInitializer);
        }
        headSql = sqlCommandInitializer.HeadSql;
        return sqlCommandInitializer.CommandInitializer;
    }
    private static Func<IDbCommand, object, string> BuildUpdateSqlParameters(string tableName, Type entityType, Type parameterType, string[] whereFields)
    {
        var cacheKey = HashCode.Combine(entityType, parameterType);
        if (!updateCommandInitializerCache.TryGetValue(cacheKey, out var commandInitializer))
        {
            var memberInfos = entityType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();
            var parameterMemberInfos = parameterType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();

            int updateIndex = 0;
            int whereIndex = 0;
            var updateBuilder = new StringBuilder($"UPDATE `{tableName}`(");
            var whereBuilder = new StringBuilder($"WHERE ");
            var updateFields = new List<string>();
            foreach (var memberInfo in parameterMemberInfos)
            {
                if (!memberInfos.Exists(f => string.Equals(memberInfo.Name, f.Name, StringComparison.OrdinalIgnoreCase)))
                    continue;

                if (whereFields.Contains(memberInfo.Name))
                {
                    if (whereIndex > 0) updateBuilder.Append(',');
                    whereBuilder.Append($"`{memberInfo.Name}`=@k{memberInfo.Name}");
                    whereIndex++;
                }
                else
                {
                    if (updateIndex > 0) updateBuilder.Append(',');
                    updateBuilder.Append($"`{memberInfo.Name}`=@{memberInfo.Name}");
                    updateFields.Add(memberInfo.Name);
                    updateIndex++;
                }
            }
            updateFields.AddRange(whereFields);
            var sql = updateBuilder.Append(whereBuilder).ToString();

            var commandExpr = Expression.Parameter(typeof(IDbCommand), "command");
            var updateObjExpr = Expression.Parameter(typeof(object), "updateObj");

            var blockParameters = new List<ParameterExpression>();
            var blockBodies = new List<Expression>();
            var typedParameterExpr = Expression.Variable(parameterType, "typedParameter");
            blockParameters.Add(typedParameterExpr);
            blockBodies.Add(Expression.Assign(typedParameterExpr, Expression.Convert(updateObjExpr, parameterType)));

            var appendMethodInfo1 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(char) });
            var appendMethodInfo2 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(string) });
            var concatMethodInfo = typeof(string).GetMethod(nameof(string.Concat), new Type[] { typeof(string), typeof(string) });
            var toStringMethodInfo = typeof(int).GetMethod(nameof(int.ToString), Type.EmptyTypes);
            var addMethodInfo = typeof(IList).GetMethod(nameof(IList.Add));
            var dbParametersExpr = Expression.Property(commandExpr, nameof(IDbCommand.Parameters));
            MethodInfo methodInfo = null;

            foreach (var fieldName in updateFields)
            {
                string parameterName = null;
                if (whereFields.Contains(fieldName))
                    parameterName = $"@k{fieldName}";
                else parameterName = $"@{fieldName}";

                var parameterNameExpr = Expression.Constant(parameterName);
                Expression fieldValueExpr = Expression.PropertyOrField(typedParameterExpr, fieldName);
                if (fieldValueExpr.Type.IsClass || fieldValueExpr.Type.IsNullableType(out _))
                {
                    var equalExpr = Expression.Equal(fieldValueExpr, Expression.Constant(null));
                    if (fieldValueExpr.Type != typeof(object))
                        fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));
                    var dbNullExpr = Expression.Convert(Expression.Constant(DBNull.Value), typeof(object));
                    fieldValueExpr = Expression.Condition(equalExpr, dbNullExpr, fieldValueExpr);
                }
                else if (fieldValueExpr.Type != typeof(object))
                    fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));

                //var dbParameter = new MySqlParameter("@Name", objValue);
                var constructor = typeof(MySqlParameter).GetConstructor(new Type[] { typeof(string), typeof(object) });
                var dbParameterExpr = Expression.New(constructor, parameterNameExpr, fieldValueExpr);

                methodInfo = typeof(IList).GetMethod(nameof(IDbCommand.Parameters.Add));
                var addParameterExpr = Expression.Call(dbParametersExpr, methodInfo, dbParameterExpr);
                blockBodies.Add(addParameterExpr);
            }
            var returnExpr = Expression.Constant(sql);
            var resultLabelExpr = Expression.Label(typeof(string));
            blockBodies.Add(Expression.Return(resultLabelExpr, returnExpr));
            blockBodies.Add(Expression.Label(resultLabelExpr, Expression.Default(typeof(string))));

            commandInitializer = Expression.Lambda<Func<IDbCommand, object, string>>(
                Expression.Block(blockParameters, blockBodies), commandExpr, updateObjExpr).Compile();
            updateCommandInitializerCache.TryAdd(cacheKey, commandInitializer);
        }
        return commandInitializer;
    }
    private static Action<IDbCommand, StringBuilder, object, int> BuildUpdateBulkSqlParameters(string tableName, Type entityType, Type parameterType, string[] whereFields)
    {
        var cacheKey = HashCode.Combine(entityType, parameterType);
        if (!updateBulkCommandInitializerCache.TryGetValue(cacheKey, out var commandInitializer))
        {
            var memberInfos = entityType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();
            var parameterMemberInfos = parameterType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();

            int updateIndex = 0;
            int whereIndex = 0;
            var updateBuilder = new StringBuilder($"UPDATE `{tableName}` SET ");
            var whereBuilder = new StringBuilder($" WHERE ");
            var updateFields = new List<string>();
            foreach (var memberInfo in parameterMemberInfos)
            {
                if (!memberInfos.Exists(f => string.Equals(memberInfo.Name, f.Name, StringComparison.OrdinalIgnoreCase)))
                    continue;

                if (whereFields.Contains(memberInfo.Name))
                {
                    if (whereIndex > 0) updateBuilder.Append(',');
                    whereBuilder.Append($"`{memberInfo.Name}`=@k{memberInfo.Name}{{0}}");
                    whereIndex++;
                }
                else
                {
                    if (updateIndex > 0) updateBuilder.Append(',');
                    updateBuilder.Append($"`{memberInfo.Name}`=@{memberInfo.Name}{{0}}");
                    updateFields.Add(memberInfo.Name);
                    updateIndex++;
                }
            }
            if (updateIndex == 0) throw new Exception("没有更新的字段");
            updateFields.AddRange(whereFields);
            var sqlFormat = updateBuilder.Append(whereBuilder).Append(';').ToString();

            var commandExpr = Expression.Parameter(typeof(IDbCommand), "command");
            var builderExpr = Expression.Parameter(typeof(StringBuilder), "builder");
            var updateObjExpr = Expression.Parameter(typeof(object), "updateObj");
            var indexExpr = Expression.Parameter(typeof(int), "index");

            var blockParameters = new List<ParameterExpression>();
            var blockBodies = new List<Expression>();
            var typedParameterExpr = Expression.Variable(parameterType, "typedParameter");
            blockParameters.Add(typedParameterExpr);
            blockBodies.Add(Expression.Assign(typedParameterExpr, Expression.Convert(updateObjExpr, parameterType)));

            var appendMethodInfo1 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(char) });
            var appendMethodInfo2 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(string) });
            var concatMethodInfo = typeof(string).GetMethod(nameof(string.Concat), new Type[] { typeof(string), typeof(string) });
            var toStringMethodInfo = typeof(int).GetMethod(nameof(int.ToString), Type.EmptyTypes);
            var addMethodInfo = typeof(IList).GetMethod(nameof(IList.Add));
            var dbParametersExpr = Expression.Property(commandExpr, nameof(IDbCommand.Parameters));
            var toStringExpr = Expression.Call(indexExpr, toStringMethodInfo);
            MethodInfo methodInfo = null;

            foreach (var fieldName in updateFields)
            {
                string parameterName = null;
                if (whereFields.Contains(fieldName))
                    parameterName = $"@k{fieldName}";
                else parameterName = $"@{fieldName}";

                Expression parameterNameExpr = Expression.Call(concatMethodInfo, Expression.Constant(parameterName), toStringExpr);

                Expression fieldValueExpr = Expression.PropertyOrField(typedParameterExpr, fieldName);
                if (fieldValueExpr.Type.IsClass || fieldValueExpr.Type.IsNullableType(out _))
                {
                    var equalExpr = Expression.Equal(fieldValueExpr, Expression.Constant(null));
                    if (fieldValueExpr.Type != typeof(object))
                        fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));
                    var dbNullExpr = Expression.Convert(Expression.Constant(DBNull.Value), typeof(object));
                    fieldValueExpr = Expression.Condition(equalExpr, dbNullExpr, fieldValueExpr);
                }
                else if (fieldValueExpr.Type != typeof(object))
                    fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));

                //var dbParameter = new MySqlParameter("@Name", objValue);
                var constructor = typeof(MySqlParameter).GetConstructor(new Type[] { typeof(string), typeof(object) });
                var dbParameterExpr = Expression.New(constructor, parameterNameExpr, fieldValueExpr);

                methodInfo = typeof(IList).GetMethod(nameof(IDbCommand.Parameters.Add));
                var addParameterExpr = Expression.Call(dbParametersExpr, methodInfo, dbParameterExpr);
                blockBodies.Add(addParameterExpr);
            }
            methodInfo = typeof(StringBuilder).GetMethod(nameof(StringBuilder.AppendFormat), new Type[] { typeof(string), typeof(object) });
            blockBodies.Add(Expression.Call(builderExpr, methodInfo, Expression.Constant(sqlFormat), toStringExpr));

            commandInitializer = Expression.Lambda<Action<IDbCommand, StringBuilder, object, int>>(
                Expression.Block(blockParameters, blockBodies), commandExpr, builderExpr, updateObjExpr, indexExpr).Compile();
            updateBulkCommandInitializerCache.TryAdd(cacheKey, commandInitializer);
        }
        return commandInitializer;
    }
    private static Func<IDbCommand, object, string> BuildDeleteSqlParameters(string tableName, Type entityType, Type parameterType, string[] whereFields)
    {
        var cacheKey = HashCode.Combine(entityType, parameterType);
        if (!deleteCommandInitializerCache.TryGetValue(cacheKey, out var commandInitializer))
        {
            var memberInfos = entityType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();
            var parameterMemberInfos = parameterType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();

            int index = 0;
            var builder = new StringBuilder($"DELETE FROM `{tableName}` WHERE ");
            var fields = new List<string>();
            foreach (var memberInfo in parameterMemberInfos)
            {
                if (!memberInfos.Exists(f => string.Equals(memberInfo.Name, f.Name, StringComparison.OrdinalIgnoreCase)))
                    continue;

                if (index > 0) builder.Append(',');
                builder.Append($"`{memberInfo.Name}`=@{memberInfo.Name}");
                fields.Add(memberInfo.Name);
                index++;
            }
            var sql = builder.ToString();

            var commandExpr = Expression.Parameter(typeof(IDbCommand), "command");
            var whereObjExpr = Expression.Parameter(typeof(object), "whereObj");

            var blockParameters = new List<ParameterExpression>();
            var blockBodies = new List<Expression>();
            var typedParameterExpr = Expression.Variable(parameterType, "typedParameter");
            blockParameters.Add(typedParameterExpr);
            blockBodies.Add(Expression.Assign(typedParameterExpr, Expression.Convert(whereObjExpr, parameterType)));

            var appendMethodInfo1 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(char) });
            var appendMethodInfo2 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(string) });
            var concatMethodInfo = typeof(string).GetMethod(nameof(string.Concat), new Type[] { typeof(string), typeof(string) });
            var toStringMethodInfo = typeof(int).GetMethod(nameof(int.ToString), Type.EmptyTypes);
            var addMethodInfo = typeof(IList).GetMethod(nameof(IList.Add));
            var dbParametersExpr = Expression.Property(commandExpr, nameof(IDbCommand.Parameters));
            MethodInfo methodInfo = null;

            foreach (var fieldName in fields)
            {
                var parameterNameExpr = Expression.Constant($"@{fieldName}");
                Expression fieldValueExpr = Expression.PropertyOrField(typedParameterExpr, fieldName);
                if (fieldValueExpr.Type.IsClass || fieldValueExpr.Type.IsNullableType(out _))
                {
                    var equalExpr = Expression.Equal(fieldValueExpr, Expression.Constant(null));
                    if (fieldValueExpr.Type != typeof(object))
                        fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));
                    var dbNullExpr = Expression.Convert(Expression.Constant(DBNull.Value), typeof(object));
                    fieldValueExpr = Expression.Condition(equalExpr, dbNullExpr, fieldValueExpr);
                }
                else if (fieldValueExpr.Type != typeof(object))
                    fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));

                //var dbParameter = new MySqlParameter("@Name", objValue);
                var constructor = typeof(MySqlParameter).GetConstructor(new Type[] { typeof(string), typeof(object) });
                var dbParameterExpr = Expression.New(constructor, parameterNameExpr, fieldValueExpr);

                methodInfo = typeof(IList).GetMethod(nameof(IDbCommand.Parameters.Add));
                var addParameterExpr = Expression.Call(dbParametersExpr, methodInfo, dbParameterExpr);
                blockBodies.Add(addParameterExpr);
            }
            var returnExpr = Expression.Constant(sql);
            var resultLabelExpr = Expression.Label(typeof(string));
            blockBodies.Add(Expression.Return(resultLabelExpr, returnExpr));
            blockBodies.Add(Expression.Label(resultLabelExpr, Expression.Default(typeof(string))));

            commandInitializer = Expression.Lambda<Func<IDbCommand, object, string>>(
                Expression.Block(blockParameters, blockBodies), commandExpr, whereObjExpr).Compile();
            updateCommandInitializerCache.TryAdd(cacheKey, commandInitializer);
        }
        return commandInitializer;
    }
    private static Action<IDbCommand, StringBuilder, object, int> BuildDeleteBulkSqlParameters(string tableName, Type entityType, Type parameterType, string[] whereFields)
    {
        var cacheKey = HashCode.Combine(entityType, parameterType);
        if (!deleteBulkCommandInitializerCache.TryGetValue(cacheKey, out var commandInitializer))
        {
            var memberInfos = entityType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();
            var parameterMemberInfos = parameterType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
                .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();

            int index = 0;
            var builder = new StringBuilder($"DELETE FROM `{tableName}` WHERE ");
            var fields = new List<string>();
            foreach (var memberInfo in parameterMemberInfos)
            {
                if (!memberInfos.Exists(f => string.Equals(memberInfo.Name, f.Name, StringComparison.OrdinalIgnoreCase)))
                    continue;

                if (index > 0) builder.Append(" AND ");
                builder.Append($"`{memberInfo.Name}`=@{memberInfo.Name}{{0}}");
                fields.Add(memberInfo.Name);
                index++;
            }
            var sqlFormat = builder.Append(';').ToString();

            var commandExpr = Expression.Parameter(typeof(IDbCommand), "command");
            var builderExpr = Expression.Parameter(typeof(StringBuilder), "builder");
            var whereObjExpr = Expression.Parameter(typeof(object), "whereObj");
            var indexExpr = Expression.Parameter(typeof(int), "index");

            var blockParameters = new List<ParameterExpression>();
            var blockBodies = new List<Expression>();
            var typedParameterExpr = Expression.Variable(parameterType, "typedParameter");
            blockParameters.Add(typedParameterExpr);
            blockBodies.Add(Expression.Assign(typedParameterExpr, Expression.Convert(whereObjExpr, parameterType)));

            var appendMethodInfo1 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(char) });
            var appendMethodInfo2 = typeof(StringBuilder).GetMethod(nameof(StringBuilder.Append), new Type[] { typeof(string) });
            var concatMethodInfo = typeof(string).GetMethod(nameof(string.Concat), new Type[] { typeof(string), typeof(string) });
            var toStringMethodInfo = typeof(int).GetMethod(nameof(int.ToString), Type.EmptyTypes);
            var addMethodInfo = typeof(IList).GetMethod(nameof(IList.Add));
            var dbParametersExpr = Expression.Property(commandExpr, nameof(IDbCommand.Parameters));
            var toStringExpr = Expression.Call(indexExpr, toStringMethodInfo);
            MethodInfo methodInfo = null;

            foreach (var fieldName in fields)
            {
                string parameterName = $"@{fieldName}";
                var parameterNameExpr = Expression.Call(concatMethodInfo, Expression.Constant(parameterName), toStringExpr);
                Expression fieldValueExpr = Expression.PropertyOrField(typedParameterExpr, fieldName);
                if (fieldValueExpr.Type.IsClass || fieldValueExpr.Type.IsNullableType(out _))
                {
                    var equalExpr = Expression.Equal(fieldValueExpr, Expression.Constant(null));
                    if (fieldValueExpr.Type != typeof(object))
                        fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));
                    var dbNullExpr = Expression.Convert(Expression.Constant(DBNull.Value), typeof(object));
                    fieldValueExpr = Expression.Condition(equalExpr, dbNullExpr, fieldValueExpr);
                }
                else if (fieldValueExpr.Type != typeof(object))
                    fieldValueExpr = Expression.Convert(fieldValueExpr, typeof(object));

                //var dbParameter = new MySqlParameter("@Name", objValue);
                var constructor = typeof(MySqlParameter).GetConstructor(new Type[] { typeof(string), typeof(object) });
                var dbParameterExpr = Expression.New(constructor, parameterNameExpr, fieldValueExpr);

                methodInfo = typeof(IList).GetMethod(nameof(IDbCommand.Parameters.Add));
                var addParameterExpr = Expression.Call(dbParametersExpr, methodInfo, dbParameterExpr);
                blockBodies.Add(addParameterExpr);
            }
            methodInfo = typeof(StringBuilder).GetMethod(nameof(StringBuilder.AppendFormat), new Type[] { typeof(string), typeof(object) });
            blockBodies.Add(Expression.Call(builderExpr, methodInfo, Expression.Constant(sqlFormat), toStringExpr));

            commandInitializer = Expression.Lambda<Action<IDbCommand, StringBuilder, object, int>>(
                Expression.Block(blockParameters, blockBodies), commandExpr, builderExpr, whereObjExpr, indexExpr).Compile();
            deleteBulkCommandInitializerCache.TryAdd(cacheKey, commandInitializer);
        }
        return commandInitializer;
    }

    private static Delegate CreateReaderDeserializer(IDataReader reader, Type entityType)
    {
        var readerExpr = Expression.Parameter(typeof(IDataReader), "reader");
        var index = 0;
        var blockParameters = new List<ParameterExpression>();
        var blockBodies = new List<Expression>();
        var memberInfos = GetMembers(entityType);
        var bindings = new List<MemberBinding>();
        while (index < reader.FieldCount)
        {
            var memberName = reader.GetName(index);
            var fieldType = reader.GetFieldType(index);
            var memberInfo = memberInfos.Find(f => string.Equals(f.Name, memberName, StringComparison.OrdinalIgnoreCase));
            if (memberInfo == null)
            {
                index++;
                continue;
            }
            var readerValueExpr = GetReaderValue(readerExpr, Expression.Constant(index), memberInfo.GetMemberType(), fieldType, blockParameters, blockBodies);
            bindings.Add(Expression.Bind(memberInfo, readerValueExpr));
            index++;
        }
        var resultLabelExpr = Expression.Label(entityType);
        Expression returnExpr = null;
        var constructor = entityType.GetConstructor(Type.EmptyTypes);
        returnExpr = Expression.MemberInit(Expression.New(constructor), bindings);
        blockBodies.Add(Expression.Return(resultLabelExpr, returnExpr));
        blockBodies.Add(Expression.Label(resultLabelExpr, Expression.Default(entityType)));
        return Expression.Lambda(Expression.Block(blockParameters, blockBodies), readerExpr).Compile();
    }
    private static Expression GetReaderValue(ParameterExpression readerExpr, Expression indexExpr, Type targetType, Type fieldType, List<ParameterExpression> blockParameters, List<Expression> blockBodies)
    {
        bool isNullable = targetType.IsNullableType(out var underlyingType);
        var methodInfo = typeof(IDataRecord).GetMethod(nameof(IDataRecord.GetValue), new Type[] { typeof(int) });
        var objLocalExpr = AssignLocalParameter(typeof(object), Expression.Call(readerExpr, methodInfo, indexExpr), blockParameters, blockBodies);
        Expression typedValueExpr = null;

        if (underlyingType.IsAssignableFrom(fieldType))
            typedValueExpr = Expression.Convert(objLocalExpr, underlyingType);
        else if (underlyingType == typeof(char))
        {
            if (fieldType == typeof(string))
            {
                var strLocalExpr = AssignLocalParameter(typeof(string), Expression.Convert(objLocalExpr, typeof(string)), blockParameters, blockBodies);
                var lengthExpr = Expression.Property(strLocalExpr, nameof(string.Length));
                var compareExpr = Expression.GreaterThan(lengthExpr, Expression.Constant(0, typeof(int)));
                methodInfo = typeof(string).GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(p => p.GetIndexParameters().Length > 0 && p.GetIndexParameters()[0].ParameterType == typeof(int))
                    .Select(p => p.GetGetMethod()).First();
                var getCharExpr = Expression.Call(strLocalExpr, methodInfo, Expression.Constant(0, typeof(int)));
                typedValueExpr = Expression.IfThenElse(compareExpr, getCharExpr, Expression.Default(underlyingType));
            }
            else throw new NotSupportedException($"暂时不支持的类型,FieldType:{fieldType.FullName},TargetType:{targetType.FullName}");
        }
        else if (underlyingType == typeof(Guid))
        {
            if (fieldType != typeof(string) && fieldType != typeof(byte[]))
                throw new NotSupportedException($"暂时不支持的类型,FieldType:{fieldType.FullName},TargetType:{targetType.FullName}");
            typedValueExpr = Expression.New(typeof(Guid).GetConstructor(new Type[] { fieldType }), Expression.Convert(objLocalExpr, fieldType));
        }
        else if (underlyingType == typeof(DateTime))
        {
            if (fieldType == typeof(long) || fieldType == typeof(ulong))
                typedValueExpr = Expression.New(underlyingType.GetConstructor(new Type[] { fieldType }), Expression.Convert(objLocalExpr, fieldType));
            else if (fieldType == typeof(string))
            {
                methodInfo = underlyingType.GetMethod(nameof(DateTime.Parse), new Type[] { typeof(string) });
                typedValueExpr = Expression.Call(methodInfo, Expression.Convert(objLocalExpr, fieldType));
            }
            else if (fieldType == typeof(DateOnly))
            {
                methodInfo = underlyingType.GetMethod(nameof(DateOnly.ToDateTime), new Type[] { typeof(TimeOnly) });
                typedValueExpr = Expression.Call(Expression.Convert(objLocalExpr, fieldType), methodInfo, Expression.Constant(TimeOnly.MinValue));
            }
            else throw new NotSupportedException($"暂时不支持的类型,FieldType:{fieldType.FullName},TargetType:{targetType.FullName}");
        }
        else if (underlyingType == typeof(DateOnly))
        {
            if (fieldType == typeof(string))
            {
                methodInfo = underlyingType.GetMethod(nameof(DateOnly.Parse), new Type[] { typeof(string) });
                typedValueExpr = Expression.Call(methodInfo, Expression.Convert(objLocalExpr, fieldType));
            }
            else if (fieldType == typeof(DateTime))
            {
                methodInfo = underlyingType.GetMethod(nameof(DateOnly.FromDateTime), new Type[] { typeof(DateTime) });
                typedValueExpr = Expression.Call(methodInfo, Expression.Convert(objLocalExpr, fieldType));
            }
            else throw new NotSupportedException($"暂时不支持的类型,FieldType:{fieldType.FullName},TargetType:{targetType.FullName}");
        }
        else if (underlyingType == typeof(TimeSpan))
        {
            if (fieldType == typeof(long))
                typedValueExpr = Expression.New(underlyingType.GetConstructor(new Type[] { fieldType }), Expression.Convert(objLocalExpr, fieldType));
            else if (fieldType == typeof(string))
            {
                methodInfo = underlyingType.GetMethod(nameof(TimeSpan.Parse), new Type[] { typeof(string) });
                typedValueExpr = Expression.Call(methodInfo, Expression.Convert(objLocalExpr, fieldType));
            }
            else if (fieldType == typeof(TimeOnly))
            {
                methodInfo = underlyingType.GetMethod(nameof(TimeOnly.ToTimeSpan));
                typedValueExpr = Expression.Call(Expression.Convert(objLocalExpr, fieldType), methodInfo);
            }
            else throw new NotSupportedException($"暂时不支持的类型,FieldType:{fieldType.FullName},TargetType:{targetType.FullName}");
        }
        else if (underlyingType == typeof(TimeOnly))
        {
            if (fieldType == typeof(long))
                typedValueExpr = Expression.New(underlyingType.GetConstructor(new Type[] { fieldType }), Expression.Convert(objLocalExpr, fieldType));
            else if (fieldType == typeof(string))
            {
                methodInfo = underlyingType.GetMethod(nameof(TimeOnly.Parse), new Type[] { typeof(string) });
                typedValueExpr = Expression.Call(methodInfo, Expression.Convert(objLocalExpr, fieldType));
            }
            else if (fieldType == typeof(DateTime))
            {
                methodInfo = underlyingType.GetMethod(nameof(TimeOnly.FromDateTime));
                typedValueExpr = Expression.Call(methodInfo, Expression.Convert(objLocalExpr, fieldType));
            }
            else if (fieldType == typeof(TimeSpan))
            {
                methodInfo = underlyingType.GetMethod(nameof(TimeOnly.FromTimeSpan));
                typedValueExpr = Expression.Call(methodInfo, Expression.Convert(objLocalExpr, fieldType));
            }
            else throw new NotSupportedException($"暂时不支持的类型,FieldType:{fieldType.FullName},TargetType:{targetType.FullName}");
        }
        else if (targetType.FullName == "System.Data.Linq.Binary")
        {
            methodInfo = typeof(Activator).GetMethod(nameof(Activator.CreateInstance), new Type[] { typeof(Type), typeof(object[]) });
            typedValueExpr = Expression.Call(methodInfo, Expression.Constant(targetType), Expression.Constant(new object[] { objLocalExpr }));
            typedValueExpr = Expression.Convert(typedValueExpr, targetType);
        }
        else
        {
            if (underlyingType.IsEnum)
            {
                if (fieldType == typeof(string))
                {
                    typedValueExpr = Expression.Convert(objLocalExpr, typeof(string));
                    methodInfo = typeof(Enum).GetMethod(nameof(Enum.Parse), new Type[] { typeof(Type), typeof(string), typeof(bool) });
                    var toEnumExpr = Expression.Call(methodInfo, Expression.Constant(underlyingType), typedValueExpr, Expression.Constant(true));
                    typedValueExpr = Expression.Convert(toEnumExpr, underlyingType);
                }
                else if (fieldType == typeof(byte) || fieldType == typeof(sbyte) || fieldType == typeof(short)
                    || fieldType == typeof(ushort) || fieldType == typeof(int) || fieldType == typeof(uint)
                    || fieldType == typeof(long) || fieldType == typeof(ulong))
                {
                    typedValueExpr = Expression.Convert(objLocalExpr, fieldType);
                    methodInfo = typeof(Enum).GetMethod(nameof(Enum.ToObject), new Type[] { typeof(Type), fieldType });
                    var toEnumExpr = Expression.Call(methodInfo, Expression.Constant(underlyingType), typedValueExpr);
                    typedValueExpr = Expression.Convert(toEnumExpr, underlyingType);
                }
                else throw new Exception($"暂时不支持的类型,FieldType:{fieldType.FullName},TargetType:{targetType.FullName}");
            }
            else
            {
                var typeCode = Type.GetTypeCode(underlyingType);
                string toTypeMethod = null;
                switch (typeCode)
                {
                    case TypeCode.Boolean: toTypeMethod = nameof(Convert.ToBoolean); break;
                    case TypeCode.Char: toTypeMethod = nameof(Convert.ToChar); break;
                    case TypeCode.Byte: toTypeMethod = nameof(Convert.ToByte); break;
                    case TypeCode.SByte: toTypeMethod = nameof(Convert.ToSByte); break;
                    case TypeCode.Int16: toTypeMethod = nameof(Convert.ToInt16); break;
                    case TypeCode.UInt16: toTypeMethod = nameof(Convert.ToUInt16); break;
                    case TypeCode.Int32: toTypeMethod = nameof(Convert.ToInt32); break;
                    case TypeCode.UInt32: toTypeMethod = nameof(Convert.ToUInt32); break;
                    case TypeCode.Int64: toTypeMethod = nameof(Convert.ToInt64); break;
                    case TypeCode.UInt64: toTypeMethod = nameof(Convert.ToUInt64); break;
                    case TypeCode.Single: toTypeMethod = nameof(Convert.ToSingle); break;
                    case TypeCode.Double: toTypeMethod = nameof(Convert.ToDouble); break;
                    case TypeCode.Decimal: toTypeMethod = nameof(Convert.ToDecimal); break;
                    case TypeCode.DateTime: toTypeMethod = nameof(Convert.ToDateTime); break;
                    case TypeCode.String: toTypeMethod = nameof(Convert.ToString); break;
                }
                if (!string.IsNullOrEmpty(toTypeMethod))
                {
                    methodInfo = typeof(Convert).GetMethod(toTypeMethod, new Type[] { typeof(object), typeof(IFormatProvider) });
                    typedValueExpr = Expression.Call(methodInfo, objLocalExpr, Expression.Constant(CultureInfo.CurrentCulture));
                }
                else typedValueExpr = Expression.Convert(Expression.Convert(objLocalExpr, fieldType), underlyingType);
            }
        }
        if (underlyingType.IsValueType && isNullable)
            typedValueExpr = Expression.Convert(typedValueExpr, targetType);

        var isNullExpr = Expression.TypeIs(objLocalExpr, typeof(DBNull));
        return Expression.Condition(isNullExpr, Expression.Default(targetType), typedValueExpr);
    }
    public static bool IsNullableType(this Type type, out Type underlyingType)
    {
        if (type.IsValueType)
        {
            underlyingType = Nullable.GetUnderlyingType(type);
            if (underlyingType == null)
            {
                underlyingType = type;
                return false;
            }
            return true;
        }
        underlyingType = type;
        return false;
    }
    public static Type GetMemberType(this MemberInfo member)
    {
        switch (member.MemberType)
        {
            case MemberTypes.Property:
                var propertyInfo = member as PropertyInfo;
                return propertyInfo.PropertyType;
            case MemberTypes.Field:
                var fieldInfo = member as FieldInfo;
                return fieldInfo.FieldType;
        }
        throw new NotSupportedException("成员member，不是属性也不是字段");
    }
    public static bool IsEntityType(this Type type, out Type underlyingType)
    {
        underlyingType = type;
        if (valueTypes.Contains(type) || type.FullName == "System.Data.Linq.Binary")
            return false;
        underlyingType = Nullable.GetUnderlyingType(type) ?? type;
        if (valueTypes.Contains(underlyingType) || underlyingType.FullName == "System.Data.Linq.Binary" || underlyingType.IsEnum)
            return false;
        if (type.IsArray)
        {
            var elementType = type.GetElementType();
            return elementType!.IsEntityType(out underlyingType);
        }
        if (type.IsGenericType)
        {
            if (type.FullName.StartsWith("System.ValueTuple`") && type.GenericTypeArguments.Length == 1)
                return false;
            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                if (typeof(IDictionary).IsAssignableFrom(type))
                    return true;
                foreach (var elementType in type.GenericTypeArguments)
                {
                    if (elementType.IsEntityType(out underlyingType))
                        return true;
                }
                return false;
            }
        }
        return true;
    }
    private static int GetTypeReaderKey(Type entityType, IDataReader reader)
    {
        var hashCode = new HashCode();
        hashCode.Add(entityType);
        hashCode.Add(reader.FieldCount);
        for (int i = 0; i < reader.FieldCount; i++)
        {
            hashCode.Add(reader.GetName(i));
        }
        return hashCode.ToHashCode();
    }
    private static ParameterExpression AssignLocalParameter(Type type, Expression valueExpr, List<ParameterExpression> blockParameters, List<Expression> blockBodies)
    {
        var objLocalExpr = Expression.Variable(type, $"local{blockParameters.Count}");
        blockParameters.Add(objLocalExpr);
        blockBodies.Add(Expression.Assign(objLocalExpr, valueExpr));
        return objLocalExpr;
    }
    private static List<MemberInfo> GetMembers(Type entityType) => entityType.GetMembers(BindingFlags.Public | BindingFlags.Instance)
       .Where(f => f.MemberType == MemberTypes.Property | f.MemberType == MemberTypes.Field).ToList();
}
public class SqlReader : IDisposable, IAsyncDisposable
{
    private MySqlCommand command;
    private DbDataReader reader;
    public SqlReader(MySqlCommand command, DbDataReader reader)
    {
        this.command = command;
        this.reader = reader;
    }
    public async Task<TTarget> ReadFirstAsync<TTarget>(CancellationToken cancellationToken = default)
    {
        TTarget result = default;
        if (await reader.ReadAsync(cancellationToken))
        {
            var targetType = typeof(TTarget);
            if (targetType.IsEntityType(out _))
                result = reader.To<TTarget>();
            else result = reader.ToValue<TTarget>();
            await NextReaderAsync(cancellationToken);
        }
        return result;
    }
    public async Task<List<TTarget>> ReadAsync<TTarget>(CancellationToken cancellationToken = default)
    {
        var result = new List<TTarget>();
        var targetType = typeof(TTarget);
        if (targetType.IsEntityType(out _))
        {
            while (await reader.ReadAsync(cancellationToken))
            {
                result.Add(reader.To<TTarget>());
            }
        }
        else
        {
            while (await reader.ReadAsync(cancellationToken))
            {
                result.Add(reader.ToValue<TTarget>());
            }
        }
        await NextReaderAsync(cancellationToken);
        return result;
    }
    private async Task NextReaderAsync(CancellationToken cancellationToken)
    {
        if (!await reader.NextResultAsync(cancellationToken))
            await DisposeAsync();
    }

    public void Dispose()
    {
        reader?.Dispose();
        if (command != null)
        {
            var connection = command.Connection;
            command.Dispose();
            connection?.Dispose();
        }
        reader = null;
        command = null;
    }
    public async ValueTask DisposeAsync()
    {
        if (reader != null)
            await reader.DisposeAsync();
        if (command != null)
        {
            await command.DisposeAsync();
            var connection = command.Connection;
            if (connection != null)
                await connection.DisposeAsync();
        }
        reader = null;
        command = null;
    }
}
