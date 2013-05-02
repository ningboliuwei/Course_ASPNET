using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProject.Back.admin
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Calendar1.Visible = false;
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


        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Calendar1.Visible = false;
            TextBox7.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "123456";
            string sex = "";
            string birthday = "";
            string realname = "";
            string address = "";
            string email = "";
            string hoby = "";
            string role = "";
            string remark = "";
            string images = "";
            string qq = "";
            string idcards = "";
            string regtime = "";

            DateTime dt=new DateTime();
            regtime = dt.ToString();

            
            username = TextBox1.Text;
            if (RadioButton1.Checked==true)//没有选择时默认为女
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            birthday = TextBox7.Text;
            realname = TextBox2.Text;
            address = TextBox3.Text;
            email = TextBox4.Text;
            hoby = TextBox6.Text;
            if(DropDownList1.SelectedValue=="管理员")//排除了没有选择时也包括为普通会员
            {
                role = "1";
            }
            else
            {
                role = "0";
            }
            role = DropDownList1.SelectedIndex.ToString();
            remark = TextBox8.Text;
            images = "login.gif";//管理员添加用户，头像默认是系统自带的
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"insert into UserInfo values('" + username + "','" + password + "','" + sex + "'" +
                                    ",null,'" + realname + "','" + address + "',null,'" + birthday + "','" + hoby + "','"
                                    + remark + "','" + role + "','" + email + "','" + regtime + "'," +
                                 "'" + qq + "','" + idcards + "','" + images + "')";//缺少年龄和爱好

            SqlCommand cmd = new SqlCommand(CommandText, conn);
            conn.Open();
            try
            {
                int m=(int)cmd.ExecuteNonQuery();
                if(m>0)
                {
                    conn.Close();
                }
                    
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            Response.Redirect("/Back/admin/User_Guan.aspx");
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
