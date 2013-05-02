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
    public partial class BookLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["username"]==null)
                {
                    Panel1.Visible = true;
                    Panel2.Visible = false;
                }
                else
                {
                    Panel1.Visible = false;
                    Panel2.Visible = true;
                    Label3.Text = Session["username"].ToString();
                }
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
            ps.PageSize = 10; //显示的数量，也就是每页要显示多少条记录
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
            this.Label1.Text = Convert.ToString(ps.PageCount);

            DataList1.DataSource = ps;
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string content = "";
            content = TextBox1.Text;
            Response.Redirect("index/shopshow.aspx?content="+content);
        }

        protected void chakan(object sender, ImageClickEventArgs e)
        {
           
            Session["gouwuche"] = null;
            Response.Redirect("/index/GouWuChe.aspx");

     
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

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("BookLogin.aspx");
        }

    }
}
