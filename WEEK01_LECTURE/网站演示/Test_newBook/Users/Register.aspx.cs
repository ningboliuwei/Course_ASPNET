using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Users_aa : System.Web.UI.Page
{
    private DataSet dataSet = new DataSet();
    private SqlDataAdapter dataAdapter = new SqlDataAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }
    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (calDayOfBirth.Visible == true)
        {
            Button1.Text = "↓";
            calDayOfBirth.Visible = false;
        }
        else
        {
            Button1.Text = "↑";
            calDayOfBirth.Visible = true;
        }

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtDayOfBirth.Text = calDayOfBirth.SelectedDate.ToString("yyyy-MM-dd");
        calDayOfBirth.Visible = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string UserName = "";
        UserName = txtUserName.Text.ToString();

        string password = txtUserPwd.Text;
        string sex = "";
        string birthdaytime = txtDayOfBirth.Text;
        string address = txtAdress.Text;
        string email = txtEmail.Text;
        string mobile = txtMobile.Text;
        if (RadioButton1.Checked == true)
        {
            sex = "男";
        }
        else
        {
            sex = "女";
        }


        string command1 = @"SELECT  * FROM usersinfo where name='" + UserName + "'";

        SqlCommand cmd = new SqlCommand(command1, connection);
        connection.Open();
        if (cmd.ExecuteScalar() != null)
        {
            Response.Write("<script>alert('用户名已经存在,请重新注册！')</script>");
        }
        else
        {

            try
            {
                string SQLString =
                    @"INSERT INTO usersinfo (Name,Pwd,Sex,Birth,Address,Email,Mobile) VALUES('" +
                    UserName + "','" + password + "','" + sex + "','" + birthdaytime + "','" + address + "','" +
                    email + "','" + mobile + "')";

                //
                //string SQLString1 = "INSERT INTO Question () VALUES()";QueNum,
                //string SQLString2 = "INSERT INTO Question () VALUES()";'" + QueTextBox4.Text.ToString() + "',
                // string SQLString3 = "INSERT INTO Question () VALUES()";,StuName " + QueTextBox1.Text.ToString() + "'
                //string SQLString = "SELECT QueNum FROM Quesition ";,'
                SqlCommand cmdd = new SqlCommand(SQLString, connection);

                if (cmdd.ExecuteScalar() == null)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Redirect("提交未成功");
                }

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message); //本来应该显示错误原因的。但是没有！！
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}

