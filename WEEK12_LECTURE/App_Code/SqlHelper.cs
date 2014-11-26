using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// SqlHelper 的摘要说明
/// </summary>
public class SqlHelper
{
	public SqlHelper()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

	public static SqlConnection GetConnection()
	{
		try
		{
			string connectionString = "data source=.;database=school;uid=ASPNET;pwd=ASPNET";
			var connection = new SqlConnection(connectionString);
			return connection;
		}
		catch (Exception exception)
		{
			throw new Exception(exception.Message);
		}
	}

	public static DataSet GetDataSetBySqlCommand(string selectCommandText, SqlConnection connection)
	{
		try
		{
			var dataAdapter = new SqlDataAdapter(selectCommandText, connection);
			var dataSet = new DataSet();
			dataAdapter.Fill(dataSet);

			return dataSet;
		}
		catch (Exception exception)
		{
			throw new Exception(exception.Message);
		}
	}

	public static void ExecuteNonQuerySqlCommand(string commandText, SqlConnection connection)
	{
		try
		{
			if (connection.State != ConnectionState.Open)
			{
				connection.Open();
			}

			var command = new SqlCommand(commandText, connection);
			command.ExecuteNonQuery();
		}
		catch (Exception exception)
		{
			throw new Exception(exception.Message);
		}
		finally
		{
			connection.Close();
		}
	}
}