using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataListExample : System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			BindDataList();
		}
	}

	protected void BindDataList()
	{
		string commandText =
			@"SELECT StudentID, Student.Name, Department.Name AS DepartmentName, Photo, Gender, Address, DayOfBirth 
					FROM Student INNER JOIN Department ON Student.DepartmentID = Department.DepartmentID";
		DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(commandText, SqlHelper.GetConnection());
		DataList1.DataSource = dataSet;
		DataList1.DataBind();
	}
	protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
	{

	}

	protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
	{
		if (e.CommandName == "s")
		{
			Response.Write("选择, StudentID=" + e.CommandArgument);
		}
		else if (e.CommandName == "e")
		{
			Response.Write("编辑");
		}
		else if (e.CommandName == "d")
		{
			Response.Write("删除");
		}
		else
		{
			
		}
	}
}