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

public partial class Admin_AdminType_Update : System.Web.UI.Page
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
        string id = Request.QueryString["an"].ToString();
        try
        {

            string selectCommandText = @"SELECT  * FROM
                           BookType where BookTypeID='" + id + "'";


            DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);
            //SqlHelper.ExecuteReaderSqlCommand(selectCommandText, connection);
            //string aa = dataSet.Tables[0].ToString();
            // string aaa = dataSet.Tables[0].ToString();
            TextBox1.Text = dataSet.Tables[0].Rows[0]["BookTypeID"].ToString();
            TextBox2.Text = dataSet.Tables[0].Rows[0]["BookTypeName"].ToString(); ;//dataSet.Tables["Name"].ToString();


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
    protected void Button1_Click(object sender, EventArgs e)
    {
        string BookTypeID = TextBox1.Text.ToString();
        string BookTypeName = TextBox2.Text;

        try
        {

            string idd = Request.QueryString["an"].ToString();
            string selectCommandText = @"update BookType set BookTypeID ='" + BookTypeID + "',BookTypeName='" + BookTypeName +"' where booktypeid = '" + idd + "'";
                                    

            SqlCommand cmdd = new SqlCommand(selectCommandText, connection);
            connection.Open();
            if (cmdd.ExecuteScalar() == null)
            {
                Response.Redirect("AdminBook_Type.aspx");
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
