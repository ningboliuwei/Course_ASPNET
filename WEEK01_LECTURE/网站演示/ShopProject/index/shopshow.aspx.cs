using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProject.index
{
    public partial class shopshow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["content"] != null)
            {
                chuan();
            }
            else
            {
                if (!Page.IsPostBack)
                {

                    show();
                }
            }

            
        }

        public void show()
        {
            SqlConnection conn = sqlHelper.Connection();
            
            //绑定类别
            string CommandText1 = @"select * from Sort";

            DataSet dataSet1 = sqlHelper.DataSetBySqlCommand(CommandText1, conn);

            DropDownList1.DataSource = dataSet1.Tables[0].DefaultView;
            DropDownList1.DataTextField = "sortname";
            DropDownList1.DataValueField = "sortid";
            DropDownList1.DataBind();
 
            //显示数据
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
            this.Label1.Text = Convert.ToString(ps.PageCount);

            DataList1.DataSource = ps;
            DataList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string sort = "";
            sort = DropDownList1.SelectedValue;

            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select shopid,shname,remark,shoppicture,price from Sort,ShopThing where Sort.sortid=ShopThing.sort and sort="+sort+"";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            DataList1.DataSource = dataSet;
            DataList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string soucont = "";
            soucont = TextBox1.Text;

            SqlConnection conn = sqlHelper.Connection();

            string CommandText = @"select shopid,shname,remark,shoppicture,price from ShopThing where shname like '%"+soucont+"%'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            DataList1.DataSource = dataSet;
            DataList1.DataBind();

        }

        protected void gouwu(object sender, EventArgs e)
        {

            DataListItem item = (DataListItem)(((Control)sender).NamingContainer);
            int i = item.ItemIndex;
            string shopid = ((TextBox)DataList1.Items[i].FindControl("TextBox2")).Text.ToString();
            Session["gouwuche"] = shopid;
            Response.Redirect("GouWuChe.aspx");
        }





        public void chuan()
        {
            
                string soucont = "";
                soucont = Request.QueryString["content"];

                SqlConnection conn = sqlHelper.Connection();

                string CommandText = @"select shopid,shname,remark,shoppicture,price from ShopThing where shname like '%" + soucont + "%'";
                DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

                DataList1.DataSource = dataSet;
                DataList1.DataBind();

               
                //绑定类别
                string CommandText1 = @"select * from Sort";

                DataSet dataSet1 = sqlHelper.DataSetBySqlCommand(CommandText1, conn);

                DropDownList1.DataSource = dataSet1.Tables[0].DefaultView;
                DropDownList1.DataTextField = "sortname";
                DropDownList1.DataValueField = "sortid";
                DropDownList1.DataBind();
           
        }

        public void chakan(object sender, EventArgs e)
        {
            DataListItem item = (DataListItem)(((Control)sender).NamingContainer);
            int i = item.ItemIndex;
            string shopid = ((TextBox)DataList1.Items[i].FindControl("TextBox2")).Text.ToString();
            Session["gouwuche"] = null;
            Response.Redirect("GouWuChe.aspx");

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
