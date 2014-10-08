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

namespace WebApplication1
{
    public partial class ResponseExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            //string username = "jack";

            //Response.Write(username);

            //Response.Write(TextBox1.Text);

            //Response.Write("<font color=red>Hello world~!</font>");

            Response.Write("<script>alert('hello')</script>");
        }
    }
}
