using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AuthenticationExample_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

	protected void btnLogin_Click(object sender, EventArgs e)
	{
		if ((txtUserName.Text == "test") && (txtPwd.Text == "1234"))
		{
			//将用户登录凭据保存到Cookie中，注意，用户名进行了转换
			FormsAuthentication.SetAuthCookie("SystemManager", false);
			//显示网站主页
			Response.Redirect("AuthenticationExample_Home.aspx");
		}
		else
		{
			lblInfo.Text = "错误的用户名或密码！";
		}
	}
}