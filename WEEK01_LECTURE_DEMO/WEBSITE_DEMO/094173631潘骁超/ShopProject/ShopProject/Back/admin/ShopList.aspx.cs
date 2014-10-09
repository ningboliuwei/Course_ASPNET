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
    public partial class ShopList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                show();
            }
        }

        public void show()
        {
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            int curpage = Convert.ToInt32(this.Label2.Text);
            PagedDataSource ps = new PagedDataSource();
            DataSet ds = dataSet; //这里是数据源

            ps.DataSource = ds.Tables[0].DefaultView;
            ps.AllowPaging = true; //是否可以分页
            ps.PageSize = 5; //显示的数量，也就是每页要显示多少条记录
            ps.CurrentPageIndex = curpage - 1; //取得当前页的页码

            this.LinkButton1.Enabled = true;
            this.LinkButton2.Enabled = true;
            this.LinkButton3.Enabled = true;
            this.LinkButton4.Enabled = true;

            if (curpage == 1)
            {
                this.LinkButton1.Enabled = false;//不显示首页按钮
                this.LinkButton2.Enabled = false;//不显示上一页按钮
            }
            if (curpage == ps.PageCount)
            {
                this.LinkButton3.Enabled = false;//不显示下一页
                this.LinkButton4.Enabled = false;//不显示尾页
            }
            Label1.Text = Convert.ToString(ps.PageCount);
            
   
            GridView1.DataSource = ps;
            GridView1.DataKeyNames=new string[]{"shopid"};
            GridView1.DataBind();

        }
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

        //编辑
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            string id = button.CommandArgument;
            Response.Redirect("changeShopInfo.aspx?id=" + id);
        }
        //删除
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            string id = button.CommandArgument;
            Response.Redirect("deleteShopInfo.aspx?id=" + id);
        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string boxid = "";
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox checkbook = (CheckBox)GridView1.Rows[i].FindControl("CheckBox2"); 
                if(checkbook.Checked==true)
                {
                    boxid += "'" + GridView1.DataKeys[i].Value + "',";
                }
            }

            SqlConnection conn = sqlHelper.Connection();

            string CommandText = "delete from ShopThing where shopid in(" + boxid.TrimEnd(',') + ")";
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
            Response.Redirect("ShopList.aspx");
        }

        //首页
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            this.Label2.Text = "1";
            show();
        }
        //前一页
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            this.Label2.Text = Convert.ToString(Convert.ToInt32(this.Label2.Text) - 1);
            show();
        }
        //下一页
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            this.Label2.Text = Convert.ToString(Convert.ToInt32(this.Label2.Text) + 1);
            show();
        }
        //尾页
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            this.Label2.Text = this.Label1.Text; //Label2.Text为总页数
            show();
        }
       
    }
}
