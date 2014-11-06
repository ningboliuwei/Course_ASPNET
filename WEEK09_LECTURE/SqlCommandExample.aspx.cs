using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SqlCommandExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}
	protected void btnExecute_Click(object sender, EventArgs e)
	{
		const string connectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET;";

		using (SqlConnection sqlConnection = new SqlConnection(connectionString))
		{
			try
			{
				//第一步
                //sqlConnection.Open();
                //SqlCommand sqlCommand = new SqlCommand();
                //sqlCommand.CommandText = "SELECT COUNT(*) FROM Student";
                //sqlCommand.Connection = sqlConnection;

                //string count = sqlCommand.ExecuteScalar().ToString();
                //Response.Write(string.Format("共有学生{0}名。", count));

                ////第二步，执行任意的 SQL 语句
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(txtCommand.Text, sqlConnection); //另一种写法
                sqlCommand.ExecuteNonQuery();
                Response.Write("命令执行成功");
            }
			catch (Exception ex)
			{
				Response.Write(ex.Message);
			}
		}
	}
}