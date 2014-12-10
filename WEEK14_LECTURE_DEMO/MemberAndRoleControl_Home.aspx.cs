using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MemberAndRoleControl_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		Response.Write("<p>你好，" + Context.User.Identity.Name + "</p>");
		Response.Write("<p>你是否已通过验证：" + Context.User.Identity.IsAuthenticated + "</p>");
		Response.Write("<p>你是否是 PowerUser 角色：" + Context.User.IsInRole("PowerUser") + "</p>");
		MembershipUser user = Membership.GetUser(Context.User.Identity.Name);

	    if (user != null)
	    {
		    Response.Write("<p>你上次登录时间为：" + user.LastLoginDate.ToString() +"</p>");
	    }
    }
}