using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page 
{
	private string selectCommandText =
		@"SELECT StudentID, Name, Gender, DayOfBirth, Address, Department FROM Student";

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			ShowData();
		}
	}

	private void ShowData()
	{
		SqlConnection connection = SqlHelper.GetConnection();
		gridStudent.DataSource = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);

		gridStudent.DataBind();

		for (int i = 0; i < gridStudent.Rows.Count; i++)
		{
			gridStudent.Rows[i].Cells[0].Text = (i + 1).ToString();
		}
	}


	private void DeleteStudent(string sno)
	{
		SqlConnection connection = SqlHelper.GetConnection();
		var dataAdapter = new SqlDataAdapter(selectCommandText, connection);
		var builder = new SqlCommandBuilder(dataAdapter);
		dataAdapter.DeleteCommand = builder.GetDeleteCommand();
		DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);
		dataSet.Tables[0].Select("StudentID='" + sno + "'")[0].Delete();
		dataAdapter.Update(dataSet);
	}

	protected void btnDelete_Click(object sender, EventArgs e)
	{
		DeleteStudent(txtSno.Text.Trim());
		ShowData();
	}

	protected void btnAdd_Click(object sender, EventArgs e)
	{
		Response.Redirect("StudentRegister.aspx");
	}
}