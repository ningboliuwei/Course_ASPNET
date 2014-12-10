using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MemberAndRoleControl_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

	protected void btnLogin_OnClick(object sender, EventArgs e)
	{
		if (Membership.ValidateUser(txtUserName.Text.Trim(), txtPwd.Text.Trim()))
		{
			FormsAuthentication.SetAuthCookie(txtUserName.Text.Trim(), false);
			Response.Redirect("MemberAndRoleControl_Home.aspx");
		}
		else
		{
			Response.Write("登录失败");
		}
	}
}