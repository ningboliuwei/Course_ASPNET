using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{

    private const string cookieName = "UserAccount";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            LoadCookie();
        }
    }

    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        bool isValid = IsValidUser(txtUserName.Text.Trim(), txtPassword.Text);

        if (isValid == false)
        {
            Response.Write("<script>alert('亲，用户名或密码错误!')</script>");
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

            Response.Redirect("../Index.aspx");
        }

       

    }

    private bool IsValidUser(string username, string password)
    {
        bool isValid;
        string commandText = string.Format("SELECT pwd,name,address FROM usersinfo WHERE name = '{0}'", username);

        using (connection)
        {
            DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(commandText, connection);

            
            if (dataSet.Tables[0].Rows.Count == 0) //没根据用户名找到相应记录
            {
                isValid = false;
            }
            else
            {

                   Session["Address"] = dataSet.Tables[0].Rows[0]["Address"].ToString();
                    Session["Name"] = dataSet.Tables[0].Rows[0]["name"];
                    string correctPassword = dataSet.Tables[0].Rows[0]["pwd"].ToString();
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
            HttpCookie cookie = new HttpCookie("UserAccount");
            cookie["username"] = txtUserName.Text;
            cookie["password"] = txtPassword.Text;
            //cookie["password"] = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "MD5");
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
            //txtPassword.Attributes["value"] = aCookie.Values["pwd"];
            txtUserName.Text = Request.Cookies[cookieName]["username"];
            //txtPassword.Text = Request.Cookies[cookieName]["password"];
            txtPassword.Attributes["value"] = Request.Cookies[cookieName]["password"];

        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Index.aspx");
    }
}
