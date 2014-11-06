using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SqlConnectionExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}


	protected void btnConnect_Click(object sender, EventArgs e)
	{
		//第一步
        //const string connectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET;";
        //Response.Write("建立SqlConnection对象<br/>");
        //SqlConnection sqlConnection = new SqlConnection();
        //Response.Write("根据连接字符串创建连接<br/>");
        //sqlConnection.ConnectionString = connectionString;
        //Response.Write("打开数据库连接<br/>");
        //sqlConnection.Open();
        //Response.Write("连接状态为：" + sqlConnection.State + "<br>");
        //Response.Write("连接字符串为：" + sqlConnection.ConnectionString + "<br>");
        //Response.Write("关闭数据库连接");
        //sqlConnection.Close();
        //Response.Write("关闭后的连接状态为：" + sqlConnection.State + "<br>");


		//第二步 关闭数据库，看看以上程序运行结果

		//第三步
        //const string connectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET;";
        //SqlConnection connection = null;
        //try
        //{
        //    connection = new SqlConnection(connectionString);
        //    //以下两行代码与前面的这行代码等效
        //    //SqlConnection connection = new SqlConnection();
        //    //connection.ConnectionString = connectionString;

        //    connection.Open();
        //    Response.Write("数据库连接打开成功<br/>");
        //    connection.Close();
        //    Response.Write("数据库连接关闭成功<br/>");

        //}
        //catch (Exception ex)
        //{
        //    Response.Write(ex.Message);

        //}
        //finally
        //{
        //    if (connection != null)
        //    {
        //        connection.Close();
        //    }
        //}


		//第四步
		//另一种写法
        ////using (SqlConnection connection = new SqlConnection(connectionString))
        ////{

        ////    try
        ////    {
        ////        connection.Open();
        ////        Response.Write("数据库连接打开成功<br/>");
        ////        connection.Close();
        ////        Response.Write("数据库连接关闭成功<br/>");
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Response.Write(ex.Message);
        ////    }
        ////}
	}
}