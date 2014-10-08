using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
namespace ShopProject
{
    public class sqlHelper
    {
        public static SqlConnection Connection()
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["Shopdb"].ToString();
                SqlConnection conn = new SqlConnection(connection);    
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataSet DataSetBySqlCommand(String selectCommandText, SqlConnection connection)
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
    }
}
