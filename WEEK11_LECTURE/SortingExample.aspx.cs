using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SortingExample : System.Web.UI.Page
{
	private static DataView dataView;
	protected void Page_Load(object sender, EventArgs e)
	{
		//需要排序的写法
		if (!Page.IsPostBack)
		{
			ViewState["SortDirection"] = "ASC";
			BindGridView("StudentID", "ASC");
		}
	}


	public void BindGridView(string sortExpression, string sortDirection)
	{
		SqlConnection connection = SqlHelper.GetConnection();
		DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(@"SELECT StudentID, Student.Name, Gender, Department.Name AS DepartmentName, Photo 
																	FROM Student INNER JOIN Department 
																	ON Student.DepartmentID = Department.DepartmentID ", connection);
		DataView dataView = dataSet.Tables[0].DefaultView;

		dataView.Sort = sortExpression + " " + sortDirection;
		gridStudent.DataSource = dataView;
		gridStudent.DataBind();

		for (int i = 0; i < gridStudent.Rows.Count; i++)
		{
			gridStudent.Rows[i].Cells[0].Text = (i + 1).ToString();
		}
	}

	protected void gridStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		gridStudent.PageIndex = e.NewPageIndex;
		BindGridView(gridStudent.SortExpression, ViewState["SortDirection"].ToString());
	}

	protected void gridStudent_Sorting(object sender, GridViewSortEventArgs e)
	{
		string sortDirection = ViewState["SortDirection"].ToString();

		if (sortDirection == "ASC")
		{
			ViewState["SortDirection"] = "DESC";
		}
		else if (sortDirection == "DESC")
		{
			ViewState["SortDirection"] = "ASC";
		}

		BindGridView(e.SortExpression, ViewState["SortDirection"].ToString());
	}
}