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
    public partial class shopInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                show();
                RadioButton1.Checked = true;
                if(Session["username"]==null)
                {
                    Label12.Text = "请先<a href=/Login.aspx>登录</a>,<a href=UserReg.aspx>注册</a>";
                }
                else
                {
                    Label12.Text = "你好！";
                }

            }
        }
        public void show()
        {
            
            
            string id = Request.QueryString["id"];
            
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing where shopid='" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);


            Image1.ImageUrl = "/Bookimages/" + dataSet.Tables[0].Rows[0]["shoppicture"].ToString();

            Label1.Text = dataSet.Tables[0].Rows[0]["shname"].ToString();
            Label9.Text = dataSet.Tables[0].Rows[0]["shname"].ToString();
            Label2.Text = dataSet.Tables[0].Rows[0]["price"].ToString();

            Label3.Text = dataSet.Tables[0].Rows[0]["shoppost"].ToString()+"元";
            Label4.Text = dataSet.Tables[0].Rows[0]["shopfax"].ToString()+"元";

            Label5.Text = dataSet.Tables[0].Rows[0]["shopnum"].ToString();

            if (Convert.ToInt16(dataSet.Tables[0].Rows[0]["shopnum"])==0)
            {
                Label6.Text = "无货";
            }
            else
            {
                Label6.Text = dataSet.Tables[0].Rows[0]["shopstate"].ToString();
            }

            Label7.Text = dataSet.Tables[0].Rows[0]["shoprepair"].ToString();
            Label8.Text = dataSet.Tables[0].Rows[0]["shopinvoice"].ToString();


            //基本信息
            Label10.Text = dataSet.Tables[0].Rows[0]["publising"].ToString();
            Label11.Text = dataSet.Tables[0].Rows[0]["shname"].ToString();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string id = Request.QueryString["id"];
            string post = "";
            string money = "";
            if(Session["username"]==null)
            {
                Response.Write("<script> alert('请先登录！'); </script>");
            }
            else
            {
                if (RadioButton1.Checked==true)
                {
                    post = "平邮";
                    money = getmoney();
                }
                else
                {
                    post = "快递";
                    money = getmoney1();
                }
                Response.Redirect("BuyShop.aspx?id="+id+"&post="+post+"&money="+money);
            }
        }

        public  String getmoney()
        {
            string id = Request.QueryString["id"];
            string mone = "";
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing where shopid='" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            mone = dataSet.Tables[0].Rows[0]["shoppost"].ToString();
            return mone;
        }

        public String getmoney1()
        {
            string id = Request.QueryString["id"];
            string mone = "";
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing where shopid='" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            mone = dataSet.Tables[0].Rows[0]["shopfax"].ToString();
            return mone;
        }
    }
    
}
