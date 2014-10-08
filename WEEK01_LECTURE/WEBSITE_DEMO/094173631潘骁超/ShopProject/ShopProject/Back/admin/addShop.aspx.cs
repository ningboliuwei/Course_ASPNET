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
    public partial class addShop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                show();
                
                
                RadioButton1.Checked = true;
                RadioButton3.Checked = true;

            }
        }
        //绑定类别
        public void show()
        {
             SqlConnection conn = sqlHelper.Connection();
             string CommandText = @"select * from Sort";

             DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

             DropDownList2.DataSource = dataSet.Tables[0].DefaultView;
             DropDownList2.DataTextField = "sortname";
             DropDownList2.DataValueField = "sortid";
             DropDownList2.DataBind();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            //声明
            string shopname = "";
            string publishing = "";
            string price = "";
            int sort;
            string remark = "";
            string firsttime = "";
            int num ;
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

            if (type == "jpg" ||  type == "gif" ||   type == "bmp") //判断是否为图片类型
            {
                string path = HttpContext.Current.Request.MapPath("~/Bookimages/");//获取到我保存的路径中
                this.imagesupload.SaveAs(path + fileName);        //存储文件到磁盘
            }

            

            //赋值
            images = fileName;
            shopname = TextBox1.Text;
            publishing = DropDownList1.SelectedValue;
            price = TextBox2.Text;
            sort = DropDownList2.SelectedIndex;
            firsttime =d11.Text;
            num = Convert.ToInt16(TextBox3.Text);
            postpay = TextBox4.Text;
            fastpay = TextBox5.Text;
            state = DropDownList3.SelectedValue;
            if(RadioButton1.Checked==true)
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
            string CommandText = @"insert into ShopThing values('"+shopname+"','"+publishing+"','"+price+"','"+remark+"',"+sort+"," +
                                 "'" + firsttime + "'," + num + ",'" + postpay + "','" + fastpay + "','" + images + "','" + state + "','" + baoxiu + "','" + fapiao + "')";

            
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
