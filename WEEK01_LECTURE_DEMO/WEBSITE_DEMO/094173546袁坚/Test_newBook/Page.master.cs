using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.SqlClient;
public partial class Page : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSearch_Click(object sender, ImageClickEventArgs e)
    {
        Session["asd"]= DropDownList1.SelectedItem.Text.ToString();
        Response.Redirect("index.aspx");
        string aaaa = TextBox1.Text;
    }
    protected void ImgLogin_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("./Users/Login.aspx");
    }
    protected void ImgRegister_Click(object sender, ImageClickEventArgs e)
    {

        Response.Redirect("./Users/Register.aspx");
    }
    
}
