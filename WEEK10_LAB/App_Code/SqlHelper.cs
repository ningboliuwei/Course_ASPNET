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
			string connectionString = "server=.;database=School;uid=ASPNET;pwd=ASPNET;";
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
}
