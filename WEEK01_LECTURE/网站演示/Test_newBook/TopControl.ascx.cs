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

public partial class TopControl : System.Web.UI.UserControl
{
    public string path = "~/Book_Order.aspx";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }
    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);
    private void bind()
    {
        if (Session["Name"] == null)
        {
            pnlmain.Visible = false;

        }
        else
        {

            LoginName.Text = Session["Name"].ToString() + ",你好，亲~欢迎来到宝宝网,祝你购物愉快~";
            Pnltop.Visible = false;

            string command1 = @"select name,pwd  from usersinfo where name='"+Session["Name"].ToString()+"'";
            SqlCommand cmd = new SqlCommand(command1, connection);
            connection.Open();
            if (cmd.ExecuteScalar() != null)
            {
                 HyperLink1.NavigateUrl = "Users/UserInfo.aspx";
            }
            else
            {
                HyperLink1.NavigateUrl = "Admin/Admin.aspx";
            }
        }
    }
}
