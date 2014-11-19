using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PagingExample : System.Web.UI.Page
{
	private static DataSet dataSet;
	protected void Page_Load(object sender, EventArgs e)
	{
		//不需要排序的写法
		if (!Page.IsPostBack)
		{
			BindGridView();
		}
	}

	public void BindGridView()
	{
		SqlConnection connection = SqlHelper.GetConnection();
		gridStudent.DataSource = SqlHelper.GetDataSetBySqlCommand(@"SELECT StudentID, Student.Name, Gender, Department.Name AS DepartmentName, Photo 
																	FROM Student INNER JOIN Department 
																	ON Student.DepartmentID = Department.DepartmentID ", connection);
		gridStudent.DataBind();

		//为GridView第一列中的单元格写入行号
		for (int i = 0; i < gridStudent.Rows.Count; i++)
		{
			gridStudent.Rows[i].Cells[0].Text = (i + 1).ToString();
		}
	}

	protected void gridStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
	{
		gridStudent.PageIndex = e.NewPageIndex;
		//一定要在设置新页码后重新绑定数据，否则无法实现分页显示功能
		BindGridView();
	}
	
}