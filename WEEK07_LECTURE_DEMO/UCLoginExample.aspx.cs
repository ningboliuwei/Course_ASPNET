#region

using System;
using System.Web.UI;

#endregion

public partial class UCLoginExample : Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			//ucLogin1.BackgroundColor = "blue";
			//ucLogin1.Width = 100;
			//ucLogin1.Title = "login1";

			//ucLogin2.BackgroundColor = "red";
			//ucLogin2.Width = 300;
			//ucLogin2.Title = "Login2";
		}
	}

	protected void btnLogin_Click(object sender, EventArgs e)
	{
		//Response.Write((ucLogin1.FindControl("txtUserName") as TextBox).Text);
		//Response.Write(ucLogin1.ValidateUser());
	}
}