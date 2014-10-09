using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class AdminLogin : System.Web.UI.Page
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
    protected void btnAdminLgn_Click(object sender, EventArgs e)
    {

        bool isValid = IsValidUser(txtAdminID.Text.Trim(), tetPwd.Text);

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

            Response.Redirect("Admin.aspx");
        }
    }

    private bool IsValidUser(string username, string password)
    {
        bool isValid;
        string commandText = string.Format("SELECT AdminID,pwd,address FROM adminInfo WHERE adminid = '{0}'", username);

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
                    Session["Name"] = dataSet.Tables[0].Rows[0]["AdminID"];
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
            cookie["username"] = txtAdminID.Text;
            cookie["password"] = tetPwd.Text;
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
            txtAdminID.Text = Request.Cookies[cookieName]["username"];
           // tetPwd.Text = Request.Cookies[cookieName]["password"];
            tetPwd.Attributes["value"] = Request.Cookies[cookieName]["password"];

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Index.aspx");
    }
}
