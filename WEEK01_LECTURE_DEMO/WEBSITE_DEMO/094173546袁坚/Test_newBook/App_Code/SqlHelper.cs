using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
///SqlHelper 的摘要说明
/// </summary>
public class SqlHelper
{
    
        //public static SqlConnection GetConnection()
        //{
        //    try
        //    {
        //        string connectionString = "Data Source=.;database=Test_Book;uid=sa;pwd=123456";
        //        SqlConnection connection = new SqlConnection(connectionString);
        //        return connection;
        //    }
        //    catch (Exception exception)
        //    {

        //        throw new Exception(exception.Message);
        //    }
        //}
       public static DataSet GetDataSetBySqlCommand (string selectCommandText, SqlConnection connection)
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
       public static void ExecuteReaderSqlCommand(string commandText, SqlConnection connection)
       {
           try
           {
               if (connection.State != ConnectionState.Open)
               {
                   connection.Open();
               }

               SqlCommand command = new SqlCommand(commandText, connection);
               command.ExecuteReader();
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

