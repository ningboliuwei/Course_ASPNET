using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentList : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			BindGridView();
		}
	}

	public void BindGridView()
	{
		SqlConnection connection = SqlHelper.GetConnection();
		DataSet dataSet =
			SqlHelper.GetDataSetBySqlCommand(
				@"SELECT StudentID, Student.Name, Class.Name AS ClassName, Photo 
					FROM Student INNER JOIN Class ON Student.ClassID = Class.ClassID", connection);

		gridStudent.DataSource = dataSet;
		Cache["DataSource"] = dataSet;
		gridStudent.DataBind();

		for (int i = 0; i < gridStudent.Rows.Count; i++)
		{
			gridStudent.Rows[i].Cells[0].Text = (i + 1).ToString();
		}
	}

	protected void gridStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		gridStudent.PageIndex = e.NewPageIndex;
		BindGridView();
	}
}