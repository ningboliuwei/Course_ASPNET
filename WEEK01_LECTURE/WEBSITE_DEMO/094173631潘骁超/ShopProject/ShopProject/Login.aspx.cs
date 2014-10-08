using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Cookies["user"] != null)
                {
                    CheckBox1.Checked = true;
                    Usernametext.Text = Request.Cookies["user"]["username"];
                    Passwordtext.Text = Request.Cookies["user"]["password"];
                }
            }

        }

      
        public void Cookike()
        {
            HttpCookie myCookie = new HttpCookie("user");
            myCookie["username"] = Usernametext.Text;
            myCookie["password"] = Passwordtext.Text;

            if (DropDownList1.SelectedIndex == 0)
            {
                myCookie.Expires = DateTime.Now.AddDays(5);
            }
            if (DropDownList1.SelectedIndex == 1)
            {
                myCookie.Expires = DateTime.Now.AddDays(10);
            }
            if (DropDownList1.SelectedIndex == 2)
            {
                myCookie.Expires = DateTime.Now.AddMonths(1);
            }
            if (DropDownList1.SelectedIndex == 3)
            {
                myCookie.Expires = DateTime.Now.AddMonths(12);
            }

            Response.Cookies.Add(myCookie);
        }

        public void session()
        {

            Session["username"] = Usernametext.Text;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //得到用户名和密码
            string username = "";
            string password = "";

            username = Usernametext.Text;
            password = Passwordtext.Text;

            if (username == "")
            {
                Response.Write("<script>alert('请输入用户名'); </script>");
            }
            if (password == "")
            {
                Response.Write("<script>alert('请输入密码'); </script>");
            }

            else
            {

                //连接数据库

                SqlConnection conn = sqlHelper.Connection();
                string CommandText = @"select userid,username,password,role from UserInfo where username = '" + username + "'";
                DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    password = dataSet.Tables[0].Rows[0]["password"].ToString();

                    if (password == Passwordtext.Text)
                    {
                        if (CheckBox1.Checked == true)
                        {
                            Cookike();
                        }

                        if (dataSet.Tables[0].Rows[0]["role"].ToString().Trim() == "1")
                        {
                            session();
                            Session["id"] = dataSet.Tables[0].Rows[0]["userid"].ToString();
                            Session.Timeout = 30;
                            Response.Redirect("Back/admin/main.aspx");
                        }
                        else
                        {
                            session();
                            Session["id"] = dataSet.Tables[0].Rows[0]["userid"].ToString();
                            Session.Timeout = 30;
                            Response.Redirect("/BookLogin.aspx");
                        }

                    }
                    else
                    {
                        Label1.Text = "用户名或者密码不正确！";
                    }
                }
            }

        }

        

    }
}
