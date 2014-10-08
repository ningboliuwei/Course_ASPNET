using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{

    private string empID;
    private DataSet dataSet = new DataSet();
    private SqlDataAdapter dataAdapter = new SqlDataAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            BindDataList();
        }
    }

    private SqlConnection connection =
        new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);

    protected void BindDataList()
    {
        string bookid = Request.QueryString["id"];

        string selectCommandText1 =
            @"select bookinfo.*,booktype.* from bookInfo,Booktype where bookinfo.BookTypeID=booktype.BookTypeID and bookid='" +
            bookid + "' ";
        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText1, connection);

        DataList1.DataSource = dataSet;
        this.DataList1.DataKeyField = "bookid";
        DataList1.DataBind();
    }

    protected void ImgBuy_Click(object sender, ImageClickEventArgs e)
    {



        string bookidd = Request.QueryString["id"];
        if (Session["Name"] == null)
        {
            Response.Write("<script>alert(' 亲,请先登录哦！')</script>");
        }
        else
        {
            DataListItem item = (DataListItem) (((Control) sender).NamingContainer);
            int i = item.ItemIndex;
            string count = ((TextBox) DataList1.Items[i].FindControl("tetbuy")).Text.ToString();
            string name = "";
            if (Session["Name"] != null)
            {
                name = Session["Name"].ToString();
            }
            if (count == "")
            {
                Response.Write("<script>alert(' 亲,请输入购买数量！')</script>");
            }

            else
            {
                int price = 0;
                for (int m = 0; m < Convert.ToInt32(count); m++)
                {
                    price = price + Convert.ToInt32(Request.QueryString["price"].ToString());
                }



                string selectCommandText1 =
                    @"select bookinfo.*,booktype.* from bookInfo,Booktype where bookinfo.BookTypeID=booktype.BookTypeID and bookid='" +
                    bookidd + "' ";


                DataSet dataSet1 = SqlHelper.GetDataSetBySqlCommand(selectCommandText1, connection);
                string bookname = dataSet1.Tables[0].Rows[0]["BookInformation"].ToString();
                Session["aa"] = "0";
                string photo = dataSet1.Tables[0].Rows[0]["BookPhoto"].ToString();
                DataTable cart = new DataTable(); //新建虚拟表 

                if (Session["shoppingcart"] == null)
                {
                    cart.Columns.Add("count", typeof (string)); //编辑表的列的属性
                    cart.Columns.Add("pid", typeof (string));
                    cart.Columns.Add("price", typeof (string));
                    cart.Columns.Add("bookname", typeof (string));
                    cart.Columns.Add("photo", typeof (string));
                    cart.Columns.Add("username", typeof (string));
                    cart.Columns.Add("num", typeof (string));
                    Session["shoppingcart"] = cart;
                }
                cart = (DataTable) Session["shoppingcart"];
                string num;
                if (cart.Rows.Count==0)
                {
                   num = cart.Rows.Count.ToString();
                }
                else
                {
                   num = (Convert.ToInt32(cart.Rows.Count.ToString())).ToString();
                }
                DataRow rr = cart.NewRow();

                rr["count"] = count;
                rr["pid"] = bookidd;
                rr["price"] = price;
                rr["bookname"] = bookname;
                rr["photo"] = photo;
                rr["username"] = name;

                rr["num"] = num;
                cart.Rows.Add(rr); //增加一条记录
                Session["shoppingcart"] = cart;




                Response.Redirect("Book_Buy.aspx?an=" + empID);
            }
        }
    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        empID = this.DataList1.DataKeys[e.Item.ItemIndex].ToString();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {


        string bookidd = Request.QueryString["id"];
        if (Session["Name"] == null)
        {
            Response.Write("<script>alert(' 亲,请先登录哦！')</script>");
        }
        else
        {
            DataListItem item1 = (DataListItem) (((Control) sender).NamingContainer);
            int i = item1.ItemIndex;
            string count1 = ((TextBox) DataList1.Items[i].FindControl("tetbuy")).Text.ToString();
            string name1 = "";
            if (Session["Name"] != null)
            {
                name1 = Session["Name"].ToString();
            }
            if (count1== "")
            {
                Response.Write("<script>alert(' 亲,请输入购买数量！')</script>");
            }
            else
            {


                int price1 = 0;

                for (int m = 0; m < Convert.ToInt32(count1); m++)
                {
                    price1 = price1 + Convert.ToInt32(Request.QueryString["price"].ToString());
                }


                string selectCommandText1 =
                    @"select bookinfo.*,booktype.* from bookInfo,Booktype where bookinfo.BookTypeID=booktype.BookTypeID and bookid='" +
                    bookidd + "' ";


                DataSet dataSet1 = SqlHelper.GetDataSetBySqlCommand(selectCommandText1, connection);
                string bookname = dataSet1.Tables[0].Rows[0]["BookInformation"].ToString();
                string photo1 = dataSet1.Tables[0].Rows[0]["BookPhoto"].ToString();

                connection.Open();
                string SQLString =
                    "INSERT INTO BookOrder (bookinfoid,userinfoname,bookcount,bookcountprice,datatime,photo) VALUES('" +
                    bookidd +
                    "','" + name1 + "','" + count1 + "','" + price1.ToString() + "','" + System.DateTime.Now.ToString() +
                    "','" +
                    photo1 + "')";
                //
                SqlHelper.ExecuteNonQuerySqlCommand(SQLString, connection);
                try
                {
                    Response.Write("<script>alert(' 亲,添加成功，前往查看！');window.location='Book_Order.aspx'</script>");

                  //  Response.Redirect("Book_Order.aspx");
                }
                catch (Exception ex)
                {

                    Response.Write(ex.Message);
                }
                connection.Close();

            }
        }
    }
}
