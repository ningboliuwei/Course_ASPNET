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
    public partial class addGouWu : System.Web.UI.Page
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
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = Session["datatable"] as DataTable;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DingDan(dataTable, i);
            }
        }

        //生成订单
        public void DingDan(DataTable dataTable, int i)
        {
            string userid = "";
            string shopid = "";
            string time = "";
            string num = "";
            string posttype = "";
            string shoppay = "";
            string postprice = "";
            string tele = "";
            string shouname = "";
            string shouaddress = "";
            string shoupost = "";
            string shopPrice = "";
            int state;
            float sumPrice;

            
            
            //赋值
            userid = Session["id"].ToString();
            shopid = dataTable.Rows[i]["shopid"].ToString();
            DateTime dt = DateTime.Now;
            time = dt.ToString();
            posttype = "平邮";//默认
            num = dataTable.Rows[i]["num"].ToString();//数量
            shoppay = "付款";

            postprice = "5";//运费
            tele = TextBox4.Text;
            shouname = TextBox1.Text;
            shouaddress = TextBox2.Text;
            shoupost = TextBox3.Text;
            shopPrice = dataTable.Rows[i]["price"].ToString(); //单价

            state = 0;//0表示正在处理
            sumPrice = float.Parse(num) * float.Parse(shopPrice) + float.Parse(postprice);
            //处理
            //jiannum(num);


            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"insert into Orders values('" + userid + "','" + shopid + "','" + time + "'," + Convert.ToInt16(num) + ",'" + posttype
                + "'," + float.Parse(postprice) + "," + sumPrice + ",'" + tele + "','" + shouname
                + "','" + shouaddress + "'," + "'" + shoupost + "'," + float.Parse(shopPrice) + "," + state + ",'" + shoppay + "')";
            string sql = @"";
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
            Session.Contents.Remove("datatable");
            Response.Redirect("gouwusuccess.aspx");

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
