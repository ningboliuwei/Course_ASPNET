using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataReaderExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		const string connectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET;";

		using (SqlConnection sqlConnection = new SqlConnection(connectionString))
		{
			try
			{
				sqlConnection.Open();
				SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Student", sqlConnection); //也可以分步骤做

				//以下这行代码可以吗？
				//SqlDataReader dataReader = new SqlDataReader();
				SqlDataReader dataReader = sqlCommand.ExecuteReader();
				while (dataReader.Read())
				{
					//写法一
					Response.Write(dataReader["Sno"] + ", " + dataReader["Sname"] + "<br/>");
					//写法二
					//Response.Write(string.Format("{0}, {1}, {2}, {3}, {4}<br/>", dataReader["Sno"], dataReader["Sname"], dataReader["Ssex"], dataReader["Sage"], dataReader["Sdept"]));
					//写法三
					//for (int i = 0; i < dataReader.FieldCount; i++)
					//{
					//	Response.Write(dataReader[i] + " ");
					//}
					Response.Write("<br/>");
				}
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}
	}
}