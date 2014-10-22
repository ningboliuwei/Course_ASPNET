#region

using System;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

public partial class UCLoginExample : Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
		
		} 
	}

	protected void btnLogin_Click(object sender, EventArgs e)
	{
		//在页面中得到用户空间中的文本框的值
		//Response.Write((ucLogin1.FindControl("txtUserName") as TextBox).Text);
		//调用用户控件提供的方法
		//Response.Write(ucLogin1.ValidateUser());


	}
	protected void btnChangeStyle_Click(object sender, EventArgs e)
	{
		ucLogin1.BackgroundColor = "lightpink";
		ucLogin1.Width = "100px";
		ucLogin1.Title = "【登录】";
	}
}