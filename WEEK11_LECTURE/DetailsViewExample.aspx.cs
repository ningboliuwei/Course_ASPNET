using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DetailsViewExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		string studentID = Request.QueryString["id"];

		if (!Page.IsPostBack)
		{
			ShowData(studentID);
		}
	}

	private void ShowData(string studentID)
	{
		string commandText = String.Format("SELECT * FROM Student WHERE StudentID='{0}'", studentID);
		DetailsView1.DataSource = SqlHelper.GetDataSetBySqlCommand(commandText, SqlHelper.GetConnection()); ;
		DetailsView1.DataBind();
	}
}