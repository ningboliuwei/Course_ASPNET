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
    public partial class BuyShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if(!Page.IsPostBack)
                {
                    show();
                }
            }
        }
        public void show()
        {
            string id = Request.QueryString["id"];
            string post = Request.QueryString["post"];
            
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing where shopid='" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            Label1.Text = dataSet.Tables[0].Rows[0]["shname"].ToString();
            Label2.Text = dataSet.Tables[0].Rows[0]["price"].ToString();
            Label3.Text = post;

            Image1.ImageUrl = "/Bookimages/" + dataSet.Tables[0].Rows[0]["shoppicture"].ToString();



        }
        //生成订单 
        protected void Button1_Click(object sender, EventArgs e)
        {
            string userid = "";
            string shopid = "";
            string time = "";
            string num="" ;
            string posttype = "";
            string shoppay = "";
            string postprice = "";
            string tele = "";
            string shouname = "";
            string shouaddress = "";
            string shoupost = "";
            string shopPrice = "";
            int state ;
            float sumPrice;

            //赋值
            userid = Session["id"].ToString();
            shopid = Request.QueryString["id"];
            DateTime dt =DateTime.Now;
            time = dt.ToString();
            posttype = Request.QueryString["post"];
            num = DropDownList1.SelectedValue;//数量
            shoppay = DropDownList2.SelectedValue;

            postprice = Request.QueryString["money"];//运费
            tele = TextBox4.Text;
            shouname = TextBox1.Text;
            shouaddress = TextBox2.Text;
            shoupost = TextBox3.Text;
            shopPrice = getprice();//单价

            state = 0;//0表示正在处理

            
            //处理
            jiannum(num);
            sumPrice = float.Parse(num) * float.Parse(shopPrice) + float.Parse(postprice);
            //插入
            SqlConnection conn = sqlHelper.Connection();

            string CommandText = @"insert into Orders values('" + userid + "','" + shopid + "','" + time + "'," + Convert.ToInt16(num) + ",'" + posttype
                + "'," + float.Parse(postprice) + "," + sumPrice + ",'" + tele + "','" + shouname
                + "','" + shouaddress + "'," + "'" + shoupost + "'," + float.Parse(shopPrice) + "," + state + ",'" + shoppay + "')";
           // string CommandText = @"insert into Orders(userid,shopid,time) values('" + userid + "','" + shopid + "','" + time + "')";
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

            Response.Redirect("addsuccess.aspx");
        }

        public  String getprice()
        {
            string id = Request.QueryString["id"];
          

            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing where shopid='" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            return Label2.Text = dataSet.Tables[0].Rows[0]["price"].ToString();
        }
        //减去数量
        public void jiannum(string num)
        {
            string id = Request.QueryString["id"];
            int n;

            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing where shopid='" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            n = Convert.ToInt16(dataSet.Tables[0].Rows[0]["shopnum"]) - Convert.ToInt16(num);

            string com = @"update ShopThing set shopnum=" + n + "where shopid='" + id + "'";

            SqlCommand cmd = new SqlCommand(com, conn);
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
