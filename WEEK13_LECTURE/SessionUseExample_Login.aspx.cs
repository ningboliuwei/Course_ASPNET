using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SessionUseExample_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void btnLogin_Click(object sender, EventArgs e)
	{
		//将 “用户名” 文本框中的文本放入 Session 中
		//Session["username"] = txtUserName.Text;
		//Response.Redirect("SessionUseExample_Welcome.aspx");
		//跳转到另一个页面

		//第二步
		//Session 中可以存放不止一个数据
		Session["username"] = txtUserName.Text;
		//生成一个随机整数作为 id
		Session["id"] = new Random().Next(1, 1000);
		Response.Redirect("SessionUseExample_Welcome.aspx");
		//第二步
		
	}
}