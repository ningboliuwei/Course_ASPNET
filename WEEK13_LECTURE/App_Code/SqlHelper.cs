using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
			string connectionString = ConfigurationManager.ConnectionStrings["connStr"].ToString();
			//ConfigurationManager.AppSettings

			SqlConnection connection = new SqlConnection(connectionString);
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
			SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommandText, connection);
			DataSet dataSet = new DataSet();
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

			SqlCommand command = new SqlCommand(commandText, connection);
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