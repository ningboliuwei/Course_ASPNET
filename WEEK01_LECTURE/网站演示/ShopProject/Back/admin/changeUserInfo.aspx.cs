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
    public partial class changeUserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Calendar1.Visible = false;
                show();
            }
        }

        public void show()
        {
            string id=Request.QueryString["id"];
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from UserInfo where userid='"+id+"'";

            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            Label1.Text = dataSet.Tables[0].Rows[0]["username"].ToString();
            if (dataSet.Tables[0].Rows[0]["sex"].ToString()=="男")
            {
                RadioButton1.Checked = true;
            }
            else if (dataSet.Tables[0].Rows[0]["sex"].ToString() == "女")
            {
                RadioButton2.Checked = true;
            }

            TextBox7.Text = dataSet.Tables[0].Rows[0]["birthday"].ToString();
            TextBox2.Text = dataSet.Tables[0].Rows[0]["realname"].ToString();
            TextBox3.Text = dataSet.Tables[0].Rows[0]["address"].ToString();
            TextBox4.Text = dataSet.Tables[0].Rows[0]["email"].ToString();
            TextBox6.Text = dataSet.Tables[0].Rows[0]["hobby"].ToString();

            if(dataSet.Tables[0].Rows[0]["role"].ToString()=="1")
            {
                Label2.Text = "管理员";
            }
            else
            {
                Label2.Text = "普通会员";
            }

            TextBox8.Text = dataSet.Tables[0].Rows[0]["remark"].ToString();

            qq.Text = dataSet.Tables[0].Rows[0]["qq"].ToString();
            idcards.Text = dataSet.Tables[0].Rows[0]["IDcard"].ToString();
            Image1.ImageUrl = "/images/Userimages/" + dataSet.Tables[0].Rows[0]["userpicture"].ToString();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Guan.aspx");
        }
        //显示日期
        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox7.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            Calendar1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string id=Request.QueryString["id"];
            string sex = "";
            string birthday = "";
            string realname = "";
            string address = "";
            string email = "";
            string hoby = "";
            
            string remark = "";
            string images = "";
            string qqq = "";
            string idcard = "";

            qqq = qq.Text.Trim();
            idcard = idcards.Text.Trim();

            string FulfileName = this.imagesupload.PostedFile.FileName;               //文件路径名
            string fileName = FulfileName.Substring(FulfileName.LastIndexOf("\\") + 1);  //图片名称
            string type = FulfileName.Substring(FulfileName.LastIndexOf(".") + 1).ToLower();       //图片格式

            if (type == "jpg" || type == "gif" || type == "bmp") //判断是否为图片类型
            {
                string path = HttpContext.Current.Request.MapPath("~/images/Userimages/");//获取到我保存的路径中
                imagesupload.SaveAs(path + fileName);        //存储文件到磁盘
            }


            images = fileName; 
            
            if (RadioButton1.Checked == true)//没有选择时默认为女
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            birthday = TextBox7.Text.Trim();
            realname = TextBox2.Text.Trim();
            address = TextBox3.Text.Trim();
            email = TextBox4.Text.Trim();
            hoby = TextBox6.Text.Trim();

            remark = TextBox8.Text.Trim();

            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"update UserInfo set sex='" + sex + "',realname='" + realname + "',address='" + address + "',birthday='" + birthday + "',hobby='" + hoby + "',remark='"
                                    + remark + "',email='" + email + "',qq='"+qqq+"',IDcard='"+idcard+"',userpicture='"+images+"' where userid='"+id+"'";

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
            Response.Redirect("/Back/admin/User_Guan.aspx");
        }
    }
}
