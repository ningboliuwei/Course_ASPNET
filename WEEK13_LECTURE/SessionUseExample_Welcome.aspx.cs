using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SessionUseExample_Welcome : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		//第一步
		//从 Session 中取出用户名，并赋值给字符串 userName
		//string userName = Session["username"].ToString();
		//将用户在另一个页面中输入的用户名显示在当前页面的标签中
		//lblInfo.Text = "你好，" + userName;
		//第一步

		//第二步
		//string userName = Session["username"].ToString();
		//int id = Convert.ToInt32(Session["id"]);
		//lblInfo.Text = "你好，" + userName + "，你的 ID 为 " + id;
		//第二步

		//第三步
		if (Session["username"] == null)
		{
			lblInfo.Text = "你还未登录，<a href='SessionUseExample_Login.aspx'>点此返回登录页面</a>";
		}
		else
		{
			string userName = Session["username"].ToString();
			int id = Convert.ToInt32(Session["id"]);
			lblInfo.Text = "你好，" + userName + "，你的 GUID 为 " + id;
		}
		//第三步
	}
	protected void btnLogout_Click(object sender, EventArgs e)
	{
		Session["username"] = null;
		Session["id"] = null;
		Response.Redirect("SessionUseExample_Login.aspx");
	}
}