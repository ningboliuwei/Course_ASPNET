using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProject.Back.admin
{
    public partial class changepwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = Session["id"].ToString();
            string pwd = "";
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select username,password,role from UserInfo where userid = '" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);
            pwd = TextBox1.Text;
            if(pwd==dataSet.Tables[0].Rows[0]["password"].ToString())
            {
                updata(id);
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                Response.Write("修改成功！");
            }
            else
            {

                Response.Write("原有密码错误！");
                
            }

        }

        public void updata(string id)
        {
            SqlConnection conn = sqlHelper.Connection();
            string newpwd = "";
            newpwd = TextBox2.Text;
            string CommandText = @"update UserInfo set password='"+newpwd+"' where userid ='"+id+"'";

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

        }
    }
}
