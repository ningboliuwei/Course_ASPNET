#region

using System;
using System.Web.UI;

#endregion

public partial class ucLogin : UserControl
{
	/// <summary>
	///     可以获得或设置背景色
	/// </summary>
	public string BackgroundColor
	{
		get { return tableLogin.BgColor; }
		set { tableLogin.BgColor = BackgroundColor; }
	}

	/// <summary>
	///     可以获得或设置用户控件中表格的宽度
	/// </summary>
	public string Width
	{
		get { return tableLogin.Width; }
		set { tableLogin.Width = Width; }
	}

	/// <summary>
	///     可以获得或设置用户控件中表格的标题
	/// </summary>
	public string Title
	{
		get { return lblTitle.Text; }
		set { lblTitle.Text = Title; }
	}

	protected void Page_Load(object sender, EventArgs e)
	{
	}

	/// <summary>
	///     验证用户名与密码是否正确
	/// </summary>
	/// <returns></returns>
	public bool ValidateUser()
	{
		if (txtUserName.Text == "admin" && txtPassword.Text == "123456")
		{
			return true;
		}

		return false;
	}
	/// <summary>
	/// 点击“登录按钮”
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void btnOK_Click(object sender, EventArgs e)
	{
		if (ValidateUser())
		{
			lblInfo.Text = "您已登录成功";
		}
		else
		{
			lblInfo.Text = "您的用户名或者密码不正确";
		}
	}
}