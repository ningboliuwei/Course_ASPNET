using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProject.Back
{
    public partial class User_Guan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                DataShow();
            }
        }
        //绑定数据
        public void DataShow()
        {
            //string username = Session["usename"].ToString();
            
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from UserInfo where role !=1";//找出不是管理员的
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            GridView1.DataSource = dataSet;
            GridView1.DataKeyNames = new string[] { "userid" };
            GridView1.DataBind();
            
        }
        //编辑
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            string id = button.CommandArgument;
            Response.Redirect("changeUserInfo.aspx?id="+id);
        }
        //删除
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            string id = button.CommandArgument;
            Response.Redirect("deleteUserInfo.aspx?id=" + id);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="edit")
            {
                var dataKey = GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)];
                if (dataKey != null)
                {
                    string id = dataKey.Value.ToString();
                }
                // Response.Redirect("changeUserInfo.aspx?id="+id);
            }
            if(e.CommandName=="delete")
            {
                string id = GridView1.DataKeys[Convert.ToInt32(e.CommandArgument.ToString())].Value.ToString();
               // Response.Redirect("deleteUserInfo.aspx?id=" + id);
            }
        }
        //全选
        protected void checkAll(object sender, EventArgs e)
        {
            //bool check = ((CheckBox)GridView1.FindControl("CheckBox1")).Checked;
            CheckBox check = (CheckBox)sender;

            if (check.Checked)
            {
                CheckBox checkbox2;
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    checkbox2 = (CheckBox)GridView1.Rows[i].FindControl("CheckBox2");
                    if (checkbox2.Checked != check.Checked)
                    {
                        checkbox2.Checked = check.Checked;
                    }
                    else
                    {
                        checkbox2.Checked = !check.Checked;
                    }

                }
            }
            else
            {
                CheckBox checkbox2;
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    checkbox2 = (CheckBox)GridView1.Rows[i].FindControl("CheckBox2");
                    if (checkbox2.Checked != check.Checked)
                    {
                        checkbox2.Checked = check.Checked;
                    }
                    else
                    {
                        checkbox2.Checked = !check.Checked;
                    }

                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string boxid = "";
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox checkbook = (CheckBox)GridView1.Rows[i].FindControl("CheckBox2");
                if (checkbook.Checked == true)
                {
                    boxid += "'" + GridView1.DataKeys[i].Value + "',";
                }
            }

            SqlConnection conn = sqlHelper.Connection();

            string CommandText = "delete from UserInfo where userid in(" + boxid.TrimEnd(',') + ")";
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
            Response.Redirect("User_Guan.aspx");
        }
    }
}
