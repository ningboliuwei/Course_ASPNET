using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddStudent : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			BindDepartmentDropDownList();
		}
	}


	protected void btnRegister_Click(object sender, EventArgs e)
	{
		AddStudentRecord();
	}

	protected void BindDepartmentDropDownList()
	{
		try
		{
			SqlConnection connection = SqlHelper.GetConnection();
			DataTable dataTable = SqlHelper.GetDataSetBySqlCommand("SELECT * FROM Department", connection).Tables[0];
			dropDepartment.DataTextField = "Name";
			dropDepartment.DataValueField = "DepartmentID";
			dropDepartment.DataSource = dataTable;
			dropDepartment.DataBind();
		}
		catch (Exception ex)
		{
			lblInfo.Text = ex.Message;
		}
	}

	private void AddStudentRecord()
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
			string fileName = UploadPhoto(); //先上传照片

			SqlConnection connection = SqlHelper.GetConnection();

			string insertCommandText =
				string.Format(
					@"INSERT INTO Student(StudentID, Name, Gender, DayOfBirth, Address, DepartmentID, Photo)
                                                            VALUES('{0}','{1}','{2}','{3}','{4}',{5},'{6}')",
					studentID,
					studentName,
					studentGender,
					dayOfBirth,
					address,
					department,
					fileName);
			SqlHelper.ExecuteNonQuerySqlCommand(insertCommandText, connection);

			lblInfo.Text = "添加成功，<a href='StudentList.aspx'>点击此处</a>查看所有学生记录";
		}
		catch (Exception ex)
		{
			lblInfo.Text = ex.Message;
		}
	}

	private string UploadPhoto()
	{
		int lastIndexOfSlash = fupldPhoto.PostedFile.FileName.LastIndexOf("\\"); //得到选中要上传的文件的最后一个"\"字符的位置
		string fileName = fupldPhoto.PostedFile.FileName.Substring(lastIndexOfSlash + 1); //得到选中要上传的文件的文件名


		int lastIndexOfDot = fileName.LastIndexOf("."); //得到选中要上传的文件的最后一个"."字符的位置
		string fileExtName = fileName.Substring(lastIndexOfDot + 1).ToUpper(); //得到要上传的文件的后缀名，并变所有字符为大写
		string newFileName = DateTime.Now.ToString("yyyyMMddhhmmss") + DateTime.Now.Millisecond + "." + fileExtName;
		string result = "";

		if (fileExtName != "JPG" && fileExtName != "JPEG" && fileExtName != "PNG" && fileExtName != "GIF"
		    && fileExtName != "BMP") //若后缀名不是这些格式
		{
			Response.Write("上传的文件格式不对，请重试。只接受JPG/JPEG/PNG/GIF/BMP类型的文件"); //则报错
		}
		else if (fupldPhoto.PostedFile.ContentLength > 0) //若选中要上传的文件大小>0
		{
			try
			{
				string uploadDir = Server.MapPath("images\\"); //得到在服务器磁盘上images所在的路径
				string uploadFilePath = uploadDir + newFileName; //得到在服务器磁盘上上传文件要保存的路径

				fupldPhoto.PostedFile.SaveAs(uploadFilePath); //利用SaveAs()方法，保存文件到服务器上指定路径
				result = newFileName;
			}
			catch (Exception ex) //若出现异常
			{
				Response.Write("文件上传失败。错误信息：" + ex.Message); //则报错
				throw new Exception(ex.Message);
			}
		}
		return result;
	}

	protected void btnAddStudent_Click(object sender, EventArgs e)
	{
		AddStudentRecord();
	}

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

}