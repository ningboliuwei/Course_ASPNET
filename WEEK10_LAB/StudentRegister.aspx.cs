using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentRegister : System.Web.UI.Page
{
	string selectCommandText =
		@"SELECT StudentID, Name, Gender, DayOfBirth, Address, Department FROM Student";

	protected void btnShowCalender_Click(object sender, EventArgs e)
	{
		calDayOfBirth.Visible = !calDayOfBirth.Visible;
		if (calDayOfBirth.Visible)
		{
			btnShowCalender.Text = "↑";
		}
		else
		{
			btnShowCalender.Text = "↓";
		}
	}

	protected void calDayOfBirth_SelectionChanged(object sender, EventArgs e)
	{
		txtDayOfBirth.Text = calDayOfBirth.SelectedDate.ToString("yyyy-MM-dd");
		//yyyy表示用4位数字代表年份，MM表示用2位数字代表月份，dd表示用2位数字代表日
		calDayOfBirth.Visible = false;
	}

	protected void btnRegister_Click(object sender, EventArgs e)
	{
		AddStudent();
	}


	private void AddStudent()
	{
	

		string studentID = txtStudentID.Text;
		string studentName = txtStudentName.Text;
		string studentGender = "";

		if (radMale.Checked)
		{
			studentGender = "男";
		}
		else
		{
			studentGender = "女";
		}

		string dayOfBirth = txtDayOfBirth.Text;
		string department = dropDepartment.SelectedValue;
		string address = txtAddress.Text;


		try
		{
			SqlConnection connection = SqlHelper.GetConnection();
			SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommandText, connection);
			SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
			dataAdapter.InsertCommand = builder.GetInsertCommand();
			DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);

			DataRow row = dataSet.Tables[0].NewRow();
			row["StudentID"] = studentID;
			row["Name"] = studentName;
			row["Gender"] = studentGender;
			row["DayOfBirth"] = dayOfBirth;
			row["Address"] = address;
			row["Department"] = department;
			dataSet.Tables[0].Rows.Add(row);
			dataAdapter.Update(dataSet);

			lblInfo.Text = "注册成功，<a href='StudentList.aspx'>点击此处</a>查看所有学生记录";
		}
		catch (Exception exception)
		{
			lblInfo.Text = exception.Message;
			throw new Exception(exception.Message);
		}
	}
}


