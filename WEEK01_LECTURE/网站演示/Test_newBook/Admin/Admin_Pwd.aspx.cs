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

public partial class Admin_Admin_Pwd : System.Web.UI.Page
{

    private DataSet dataSet = new DataSet();
    private SqlDataAdapter dataAdapter = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            
        }
    }
    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);
    protected void Button1_Click(object sender, EventArgs e)
    {

        string id = Session["Name"].ToString();
        try
        {

            string selectCommandText = @"SELECT  * FROM
                           admininfo where adminID='" + id + "'";
            DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);
            string pwdd = dataSet.Tables[0].Rows[0]["pwd"].ToString();

            if(pwdd==TextBox2.Text.ToString())
            {

                string selectCommandText1 = @"update admininfo set pwd ='" + TextBox3.Text.ToString() + "'";  
                                                                                     
                SqlHelper.ExecuteNonQuerySqlCommand(selectCommandText1, connection);
                Response.Write("<script>alert('修改成功！')</script>");

            }
            else
            {
                Response.Write("<script>alert('密码错误，请重新填写！')</script>");
            }

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
}
