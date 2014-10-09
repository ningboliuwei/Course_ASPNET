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

public partial class RequestExample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //string s = Request.QueryString["id"];
        //Response.Write(s);

        Response.Write(Request.Path);
        Response.Write(Request.UserHostAddress);
        Response.Write(Request.Browser["Browser"]);
        Response.Write(Request.Browser["Version"]);

    }
}
