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
	protected void gridStudent_RowEditing(object sender, GridViewEditEventArgs e)
	{
		gridStudent.EditIndex = e.NewEditIndex;
		ShowData();
	}
	protected void gridStudent_RowUpdating(object sender, GridViewUpdateEventArgs e)
	{
		SqlConnection connection = SqlHelper.GetConnection();
		var dataAdapter = new SqlDataAdapter(selectCommandText, connection);
		var builder = new SqlCommandBuilder(dataAdapter);
		dataAdapter.DeleteCommand = builder.GetDeleteCommand();
		DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);
	
		

		string studentID = (gridStudent.Rows[e.RowIndex].Cells[1].Controls[0] as TextBox).Text;
		string name = (gridStudent.Rows[e.RowIndex].Cells[2].Controls[0] as TextBox).Text;
		string gender = (gridStudent.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text;
		string dayOfBirth = (gridStudent.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox).Text;
		string address = (gridStudent.Rows[e.RowIndex].Cells[5].Controls[0] as TextBox).Text;
		string department = (gridStudent.Rows[e.RowIndex].Cells[6].Controls[0] as TextBox).Text;

		//获取 DataSet 中与点击了 “编辑” 按钮的这行对应的数据行
		DataRow row = dataSet.Tables[0].Rows[e.RowIndex];
		//修改其中各字段的值
		row["StudentID"] = studentID;
		row["Name"] = name;
		row["Gender"] = gender;
		row["DayOfBirth"] = dayOfBirth;
		row["Address"] = address;
		row["Department"] = department;

		//提交到数据库中
		dataAdapter.Update(dataSet);
		gridStudent.EditIndex = -1;
		ShowData();
	}
	protected void gridStudent_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
	{
		gridStudent.EditIndex = -1;
		ShowData();
	}
}