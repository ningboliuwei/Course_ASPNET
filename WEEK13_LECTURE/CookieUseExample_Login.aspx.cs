using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CookieUseExample_Login : System.Web.UI.Page
{
	private const string cookieName = "UserAccount";

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			LoadCookie();
		}

		//this.btnLogin_Click(null, null);
	}


	protected void btnLogin_Click(object sender, EventArgs e)
	{
		bool isValid = IsValidUser(txtUserName.Text.Trim(), txtPassword.Text);

		if (isValid == false)
		{
			Response.Write("用户名或密码错误");
		}
		else
		{
			if (chkRememberPassword.Checked)
			{
				CreateCookie(dplSaveTime.Text);
			}
			else
			{
				Response.Cookies[cookieName].Expires = DateTime.Now;
			}

			Response.Redirect("CookieUseExample_Home.aspx");
		}
	}

	private bool IsValidUser(string username, string password)
	{
		bool isValid;
		string commandText = string.Format("SELECT Password FROM Users WHERE Username = '{0}'", username);

		using (SqlConnection connection = SqlHelper.GetConnection())
		{
			DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(commandText, connection);

			if (dataSet.Tables[0].Rows.Count == 0) //没根据用户名找到相应记录
			{
				isValid = false;
			}
			else
			{
				string correctPassword = dataSet.Tables[0].Rows[0]["Password"].ToString();

				if (correctPassword == password)
				{
					isValid = true;
				}
				else
				{
					isValid = false;
				}
			}
		}

		return isValid;
	}

	private void CreateCookie(string period)
	{
		if (Request.Cookies[cookieName] == null)
		{
			HttpCookie cookie = new HttpCookie(cookieName);
			cookie["username"] = txtUserName.Text;
			//cookie["password"] = txtPassword.Text;
			cookie["password"] = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "MD5");
			//如果要对保存的密码加密，使用注释的语句


			switch (period)
			{
				case "保存一天":
					cookie.Expires = DateTime.Now.AddDays(1);
					break;
				case "保存一月":
					cookie.Expires = DateTime.Now.AddMonths(1);
					break;
				case "保存一年":
					cookie.Expires = DateTime.Now.AddYears(1);
					break;
				default:
					break;
			}

			Response.Cookies.Add(cookie);
		}
	}

	private void LoadCookie()
	{
		if (Request.Cookies[cookieName] == null)
		{
			chkRememberPassword.Checked = false;
		}
		else
		{
			chkRememberPassword.Checked = true;
			txtUserName.Text = Request.Cookies[cookieName]["username"];
			txtPassword.Text = Request.Cookies[cookieName]["password"];
		}
	}
}