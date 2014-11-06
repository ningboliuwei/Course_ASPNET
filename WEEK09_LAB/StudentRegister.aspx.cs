using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace 基本ADONET对象的使用
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=127.0.0.1;database=school;uid=sa;pwd=liuxiaozeng";


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

            string commandText =
                string.Format(
                    @"INSERT INTO Student(StudentID, Name, Gender, DayOfBirth, Address, Department)
                                    VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                    studentID, studentName, studentGender, dayOfBirth, address, department);

            try
            {
                var connection = new SqlConnection(connectionString);
                var command = new SqlCommand(commandText, connection);

                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command.ExecuteNonQuery();

                connection.Close();

                lblInfo.Text = "注册成功，<a href='StudentList.aspx'>点击此处</a>查看所有学生记录";
            }
            catch (Exception exception)
            {
                lblInfo.Text = exception.Message;
                throw;
            }
        }
    }
}