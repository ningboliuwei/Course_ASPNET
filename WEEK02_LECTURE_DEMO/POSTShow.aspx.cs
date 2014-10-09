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

public partial class POSTShow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string s1 = Request.Form["TextBox1"];
        string s2 = Request.Form["TextBox2"];

        Response.Write(s1 + "<br/>" + s2);

    }
}
