using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AuthenticationExample_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		Response.Write("<p>当前用户名称：" + Context.User.Identity.Name);
		Response.Write("<p>当前用户授权方式：" + Context.User.Identity.AuthenticationType);
		Response.Write("<p>当前用户是否已被验证：" + Context.User.Identity.IsAuthenticated.ToString());
    }
	protected void btnLogout_Click(object sender, EventArgs e)
	{
		FormsAuthentication.SignOut();
	}
}