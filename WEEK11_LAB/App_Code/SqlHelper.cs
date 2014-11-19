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

	private static readonly string connectionString = "server=10.22.149.105;database=school;uid=ASPNET;pwd=ASPNET;";
	public SqlHelper()
	{
	}


	public static SqlConnection GetConnection()
	{
		try
		{

			SqlConnection connection = new SqlConnection(connectionString);
			return connection;
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
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
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
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
		catch (Exception ex)
		{
			throw new Exception(ex.Message);
		}
		finally
		{
			if (connection != null)
			{
				connection.Close();
			}
		}
	}
}
