using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataSourceBasicExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			GetData();
		}
	}

	private void GetData()
	{
		//第一步
		SqlDataSource dataSource = new SqlDataSource();
		dataSource.ConnectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET";
		dataSource.SelectCommand = "SELECT * FROM Student";
		dgvStudent.DataSource = dataSource;
		dgvStudent.DataBind();
		//第一步
	}

}