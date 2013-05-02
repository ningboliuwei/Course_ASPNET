using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProject.index
{
    public partial class UserReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ScriptManager1.SetFocus("TextBox1");
            }
        }

        private bool CheckUser()
        {
            int count = 0;
            SqlConnection conn = sqlHelper.Connection();
            string username = TextBox1.Text;
            string strsql = "select count(userid) from UserInfo where username='" + username + "'";
            SqlCommand cmd = new SqlCommand(strsql, conn);
            conn.Open();
            count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = "";
            string pwd = "";
            string email = "";
            string regtime = "";
            string role = "";

            


            username = TextBox1.Text;
            pwd = TextBox2.Text;
            email = TextBox4.Text;

            if(username==""||pwd==""||email=="")
            {
                Response.Write("<script>alert('不能为空！'); </script>");
            }
            else
            {
                DateTime dt = DateTime.Now;
                regtime = dt.ToString();
                role = "0";

                SqlConnection conn = sqlHelper.Connection();
                string CommandText = @"insert into UserInfo(username,password,email,regTime,role) values('" + username + "','" +
                                     pwd + "','" + email + "','" + regtime + "','" + role + "')";
                SqlCommand cmd = new SqlCommand(CommandText, conn);
                conn.Open();
                try
                {
                    int m = (int)cmd.ExecuteNonQuery();
                    if (m > 0)
                    {
                        conn.Close();
                    }


                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }

                Response.Redirect("/Login.aspx");
            }
           

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (!CheckUser())
            {
                Label1.Text = "用户名已经存在";
                ScriptManager.RegisterStartupScript(this.UpdatePanel1, UpdatePanel1.GetType(), "",
                         "document.getElementById('TextBox1').select();", true);
            }
            else
            {
                Label1.Text = "";
            }
        }
    }
}
