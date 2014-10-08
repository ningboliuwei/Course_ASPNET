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

namespace 用户控件基本使用
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ucLogin1.Width = "100px";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //ucLogin1.BackgroundColor = TextBox1.Text;
            (ucLogin1.FindControl("txtUsername") as TextBox).Text = TextBox1.Text;
        }
    }
}
