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


public partial class Users_UserInfo : System.Web.UI.Page
{

    private DataSet dataSet = new DataSet();
    private SqlDataAdapter dataAdapter = new SqlDataAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Bind();

        }
    }
    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);
    private void Bind()
    {
        string id = Session["Name"].ToString();
        try
        {

            string selectCommandText = @"SELECT  * FROM  usersinfo where name='" + id + "'";
                         


            DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);
            //SqlHelper.ExecuteReaderSqlCommand(selectCommandText, connection);
            //string aa = dataSet.Tables[0].ToString();
            // string aaa = dataSet.Tables[0].ToString();
            txtUserName.Text = dataSet.Tables[0].Rows[0]["Name"].ToString();
            txtUserPwd.Text = dataSet.Tables[0].Rows[0]["Pwd"].ToString(); ;//dataSet.Tables["Name"].ToString();
            string gender = dataSet.Tables[0].Rows[0]["Sex"].ToString();//dataSet.Tables["Gender"].ToString();
            if (gender == "男")
            {
                RadioButton1.Checked = true;
            }
            if (gender == "女")
            {
                RadioButton2.Checked = true;
            }
            txtDayOfBirth.Text = dataSet.Tables[0].Rows[0]["Birth"].ToString();
            txtAdress.Text = dataSet.Tables[0].Rows[0]["Address"].ToString();
            txtEmail.Text = dataSet.Tables[0].Rows[0]["Email"].ToString();
            txtMobile.Text = dataSet.Tables[0].Rows[0]["Mobile"].ToString();
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
            Response.End();
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {



        string Name = "";
        string Pwd = "";
        string Sex = "";
        string Birth = "";
        string Address = "";
        string Email = "";
        string Mobile = "";

        Name = txtUserName.Text;
        Pwd = txtUserPwd.Text;
        if (RadioButton1.Checked == true)
        {
            Sex = "男";
        }
        else
        {
            Sex = "女";
        }

        Birth = txtDayOfBirth.Text;
        Address = txtAdress.Text;
        Email = txtEmail.Text;
        Mobile = txtMobile.Text;
        string ad = Session["Name"].ToString();
        string selectCommandText = @"update usersInfo set Name ='" + Name + "',Pwd='" + Pwd + "'," +
                                   " Birth ='" + Birth + "',Address='" + Address + "', Email='" + Email + "',Mobile='" + Mobile + "',Sex='"+Sex+"' where name= '" + ad + "'";

        SqlCommand cmdd = new SqlCommand(selectCommandText, connection);
        connection.Open();
        if (cmdd.ExecuteScalar() == null)
        {
            Response.Write("<script>alert('亲，信息修改了哦!')</script>");
            Bind();
        }
        else
        {
         
        }
        connection.Close();
    }

}

