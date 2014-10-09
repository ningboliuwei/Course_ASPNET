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
    public partial class OneUserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                show();
            }
        }

        public void show()
        {
            
           // string id = Request.QueryString["id"];
            string name = Session["username"].ToString();
            int id = getID(name);
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from UserInfo where userid=" + id + "";

            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            TextBox1.Text = dataSet.Tables[0].Rows[0]["username"].ToString();
            if (dataSet.Tables[0].Rows[0]["sex"].ToString() == "男")
            {
                RadioButton1.Checked = true;
            }
            else
            {
                RadioButton2.Checked = true;
            }

            TextBox7.Text = dataSet.Tables[0].Rows[0]["birthday"].ToString();
            TextBox2.Text = dataSet.Tables[0].Rows[0]["realname"].ToString();
            TextBox3.Text = dataSet.Tables[0].Rows[0]["address"].ToString();
            TextBox4.Text = dataSet.Tables[0].Rows[0]["email"].ToString();
            TextBox6.Text = dataSet.Tables[0].Rows[0]["hobby"].ToString();

            if (dataSet.Tables[0].Rows[0]["role"].ToString() == "1")
            {
                Label1.Text = "管理员";
            }
            else
            {
                Label1.Text = "普通会员";
            }

            TextBox8.Text = dataSet.Tables[0].Rows[0]["remark"].ToString();

        }

        public int getID(string name)
        {
            int id;
            string username = name;
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from UserInfo where username='" + username + "'";

            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            id = Convert.ToInt16(dataSet.Tables[0].Rows[0]["userid"]);
            return id;

        }
    }
}
