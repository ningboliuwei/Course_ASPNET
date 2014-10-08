using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}
	protected void btnRegister_Click(object sender, EventArgs e)
	{
		string account;
		string nickname;
		string email;

		account = txtAccount.Text;
		nickname = txtNickname.Text;
		email = txtEmail.Text;

		Response.Write(string.Format("您已经成功注册<br>您的账号为：{0}<br>您的昵称为：{1}<br>您的电子邮件地址为：{2}<br>", 
			account, nickname, email));
	}
}
