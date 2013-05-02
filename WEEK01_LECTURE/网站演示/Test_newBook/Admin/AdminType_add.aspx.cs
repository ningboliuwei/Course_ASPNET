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

public partial class Admin_AdminType_add : System.Web.UI.Page
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

        string BookTypeID = TextBox1.Text.ToString();
        string BookTypeName = TextBox2.Text;



        connection.Open();
        string selectCommandText = @"SELECT  * FROM
                           BookType where BookTypeID='" + BookTypeID + "'";


        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);

        if(dataSet.Tables[0].Rows.Count!=0)
        {
            Response.Write("<script>alert('id已经存在，换一个，亲~!')</script>");
        }
        try
        {
            string SQLString = @"INSERT INTO BookType (BookTypeID,BookTypeName) VALUES('" + BookTypeID + "','" +BookTypeName + "')";
               
                

            //

            SqlCommand cmdd = new SqlCommand(SQLString, connection);

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
            Console.Write(ex.Message);
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
