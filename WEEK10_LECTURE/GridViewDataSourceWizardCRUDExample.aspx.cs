using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridViewDataSourceWizardCRUDExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}

	
	public void ShowData()
	{
		//gridview1.DataSource = dataSource;
		gridview1.DataBind();
	}

	

	protected void btnDelete_Click(object sender, EventArgs e)
	{
		gridview1.DataBind();
	}

	protected void btnInsert_Click(object sender, EventArgs e)
	{
		SqlDataSource1.Insert();
		gridview1.DataBind();
	}

	protected void btnUpdate_Click(object sender, EventArgs e)
	{
		SqlDataSource1.Update();
		gridview1.DataBind();
	}
}