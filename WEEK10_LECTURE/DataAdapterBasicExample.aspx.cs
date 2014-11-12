using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataAdapterBasicExample : System.Web.UI.Page
{
	private DataSet dataSet = new DataSet();
	private SqlDataAdapter dataAdapter;

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			GetData();
		}
	}

	public void GetData()
	{
		using (SqlConnection connection =
			new SqlConnection("server=.;database=schooldb;uid=ASPNET;pwd=ASPNET"))
		{
			string selectCommandText = "SELECT * FROM Student";
			//第一步
			dataAdapter = new SqlDataAdapter(selectCommandText, connection);
			dataAdapter.Fill(dataSet, "student");
			dgvStudent.DataSource = dataSet.Tables["student"];
			dgvStudent.DataBind();
			//第一步

			//第二步
			//dataAdapter = new SqlDataAdapter(selectCommandText, connection);
			//selectCommandText = "SELECT * FROM Course";
			//dataAdapter.SelectCommand.CommandText = selectCommandText;
			//dataAdapter.Fill(dataSet, "course");
			//dgvStudent.DataSource = dataSet.Tables["course"];
			//gdvStudent.DataBind();
			//第二步

			//第三步
			//dataAdapter = new SqlDataAdapter(selectCommandText, connection);
			//selectCommandText = "SELECT * FROM Course";
			//dataAdapter.SelectCommand.CommandText = selectCommandText;
			//dataAdapter.Fill(dataSet, "course");
			//dataAdapter.Fill(dataSet, "course");//比第二步多出来的部分
			//gdvStudent.DataSource = dataSet.Tables["course"];
			//gdvStudent.DataBind();
			//第三步
			
		}
	}
}