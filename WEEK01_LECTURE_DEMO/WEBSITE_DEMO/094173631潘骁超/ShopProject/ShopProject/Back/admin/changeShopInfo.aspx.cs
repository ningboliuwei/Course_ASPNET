using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace ShopProject.Back.admin
{
    public partial class changeShopInfo : System.Web.UI.Page
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
           //绑定类别
            SqlConnection conn = sqlHelper.Connection();
            string CommandText1 = @"select * from Sort";

            DataSet dataSet1 = sqlHelper.DataSetBySqlCommand(CommandText1, conn);

            DropDownList3.DataSource = dataSet1.Tables[0].DefaultView;
            DropDownList3.DataTextField = "sortname";
            DropDownList3.DataValueField = "sortid";
            DropDownList3.DataBind();
             
            string id = Request.QueryString["id"];
           
            string CommandText = @"select * from ShopThing,Sort where ShopThing.sort=Sort.sortid and shopid='" + id + "'";

            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            TextBox1.Text = dataSet.Tables[0].Rows[0]["shname"].ToString();
            TextBox2.Text = dataSet.Tables[0].Rows[0]["price"].ToString();

            d11.Text = dataSet.Tables[0].Rows[0]["firsttime"].ToString();

            TextBox3.Text = dataSet.Tables[0].Rows[0]["shopnum"].ToString();
            TextBox4.Text = dataSet.Tables[0].Rows[0]["shoppost"].ToString();
            TextBox5.Text = dataSet.Tables[0].Rows[0]["shopfax"].ToString();

            if(dataSet.Tables[0].Rows[0]["shoprepair"].ToString()=="是")
            {
                RadioButton1.Checked = true;
            }
            else
            {
                RadioButton2.Checked = true;
            }

            if(dataSet.Tables[0].Rows[0]["shopinvoice"].ToString()=="是")
            {
                RadioButton3.Checked = true;
            }
            else
            {
                RadioButton4.Checked = true;
            }

            TextBox6.Text = dataSet.Tables[0].Rows[0]["remark"].ToString();
            
            DropDownList3.SelectedValue = dataSet.Tables[0].Rows[0]["sortname"].ToString();
            Image1.ImageUrl = "/Bookimages/" + dataSet.Tables[0].Rows[0]["shoppicture"].ToString().Trim(); ;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopList.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            //声明
            string shopname = "";
            string publishing = "";
            string price = "";
            int sort ;
            string remark = "";
            string firsttime = "";
            int num;
            string postpay = "";
            string fastpay = "";
            string state = "";
            string baoxiu = "";
            string fapiao = "";
            string images = "";
           
            
            //操作图片
            string FulfileName = this.imagesupload.PostedFile.FileName;               //文件路径名
            string fileName = FulfileName.Substring(FulfileName.LastIndexOf("\\") + 1);  //图片名称
            string type = FulfileName.Substring(FulfileName.LastIndexOf(".") + 1).ToLower();       //图片格式

            if (type == "jpg" || type == "gif" || type == "bmp") //判断是否为图片类型
            {
                string path = HttpContext.Current.Request.MapPath("~/Bookimages/");//获取到我保存的路径中
                imagesupload.SaveAs(path + fileName);        //存储文件到磁盘
            }



            //赋值
            images = fileName;
            shopname = TextBox1.Text;
            publishing = DropDownList2.SelectedValue;
            price = TextBox2.Text;
            sort = DropDownList3.SelectedIndex;
            firsttime = d11.Text;
            num = Convert.ToInt16(TextBox3.Text);
            postpay = TextBox4.Text;
            fastpay = TextBox5.Text;
            state = DropDownList1.SelectedValue;
            if (RadioButton1.Checked == true)
            {
                baoxiu = RadioButton1.Text;
            }
            else
            {
                baoxiu = RadioButton2.Text;
            }
            if (RadioButton3.Checked == true)
            {
                fapiao = RadioButton3.Text;
            }
            else
            {
                fapiao = RadioButton4.Text;
            }
            remark = TextBox6.Text;
            //images=FileUpload1  图片

            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"update ShopThing set sort="+sort+",publising='"+publishing+"',state='"+state+"', shname='" + shopname + "',price='" + price + "',remark='" + remark + "',firsttime='" + firsttime + "'," +
                                 "shopnum=" + num + ",shoppost='" + postpay + "',shopfax='" + fastpay + "',shoprepair='" + baoxiu + "',shopinvoice='" + fapiao + "',shoppicture='"+images+"' where shopid='"+id+"'";


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
            Response.Redirect("/Back/admin/ShopList.aspx");
        }
    }
}
