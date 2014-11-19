using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TemplateColumnExample : System.Web.UI.Page
{
	private static DataSet dataSet;
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

	protected void gridStudent_SelectedIndexChanged(object sender, EventArgs e)
	{
		DropDownList drop = gridStudent.Rows[gridStudent.SelectedIndex].Cells[3].FindControl("drpGender") as DropDownList;
		Response.Write(drop.Text);
		gridStudent.Rows[gridStudent.SelectedIndex].BackColor = Color.LightCoral;
	}
}