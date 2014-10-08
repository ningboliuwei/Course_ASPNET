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

public partial class Admin_Admininfo : System.Web.UI.Page
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

            string selectCommandText = @"SELECT  * FROM
                           admininfo where adminID='" + id + "'";


            DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);
            //SqlHelper.ExecuteReaderSqlCommand(selectCommandText, connection);
            //string aa = dataSet.Tables[0].ToString();
            // string aaa = dataSet.Tables[0].ToString();
            TextBox1.Text = dataSet.Tables[0].Rows[0]["AdminID"].ToString();
            TextBox2.Text = dataSet.Tables[0].Rows[0]["Name"].ToString(); ;//dataSet.Tables["Name"].ToString();
          //  TextBox3.Text = dataSet.Tables[0].Rows[0]["Pwd"].ToString();
            string gender = dataSet.Tables[0].Rows[0]["Sex"].ToString();//dataSet.Tables["Gender"].ToString();
            if (gender == "男")
            {
                RadioButton1.Checked = true;
            }
            if (gender == "女")
            {
                RadioButton2.Checked = true;
            }
            TextBox5.Text = dataSet.Tables[0].Rows[0]["Birth"].ToString();
            TextBox6.Text = dataSet.Tables[0].Rows[0]["Address"].ToString();
            TextBox7.Text = dataSet.Tables[0].Rows[0]["Email"].ToString();
            TextBox8.Text = dataSet.Tables[0].Rows[0]["Mobile"].ToString();
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
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string AdminID = "";
        string Name = "";
        //string Pwd = "";
        string Sex = "";
        string Birth = "";
        string Address = "";
        string Email = "";
        string Mobile = "";

        AdminID = TextBox1.Text;
        Name = TextBox2.Text;
       // Pwd = TextBox3.Text;
        if (RadioButton1.Checked == true)
        {
            Sex = "男";
        }
        else
        {
            Sex = "女";
        }

        Birth = TextBox5.Text;
        Address = TextBox6.Text;
        Email = TextBox7.Text;
        Mobile = TextBox8.Text;
        string ad = Session["Name"].ToString();
        string selectCommandText = @"update admininfo set AdminID ='" + AdminID + "',Name='" + Name + "',Sex='" + Sex + "', Birth='" + Birth + "'," + "Address='" + Address + "',Mobile='" + Mobile + "',Email='" + Email + "'" + " where adminid= '" + ad + "'"; //" + " Pwd ='" + Pwd + "',                                             
        SqlHelper.ExecuteNonQuerySqlCommand(selectCommandText, connection);
        Response.Write("<script>alert('修改成功！')</script>");
        
        try
        {

            Bind();
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}
