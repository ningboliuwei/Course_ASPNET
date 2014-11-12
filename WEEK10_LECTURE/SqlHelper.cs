using System;
using System.Data;
using System.Data.SqlClient;

namespace GridView的使用
{
    public class SqlHelper
    {
        public static SqlConnection GetConnection()
        {
            try
            {
                string connectionString = "data source=10.22.149.99;database=school;uid=Student;pwd=123456";
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
}