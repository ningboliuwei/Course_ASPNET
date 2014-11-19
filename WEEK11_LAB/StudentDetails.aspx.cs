using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentDetails : System.Web.UI.Page
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
		string commandText =
			String.Format(
				@"SELECT StudentID, Student.Name, Department.Name AS DepartmentName, Photo, Gender, Address, DayOfBirth 
					FROM Student INNER JOIN Department ON Student.DepartmentID = Department.DepartmentID WHERE StudentID='{0}'",
				studentID);
		DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(commandText, SqlHelper.GetConnection());
		DetailsView1.DataSource = dataSet;
		DetailsView1.DataBind();
	}
}