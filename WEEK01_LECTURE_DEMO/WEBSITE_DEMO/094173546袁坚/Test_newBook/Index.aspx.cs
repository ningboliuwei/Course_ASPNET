using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDataList();
            Show();
        }
    }
    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);
    protected void ImgLogin_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("./Users/Login.aspx");
    }
    protected void ImgRegister_Click(object sender, ImageClickEventArgs e)
    {

        Response.Redirect("./Users/Register.aspx");
    }
    protected void BtnSearch_Click(object sender, ImageClickEventArgs e)
    {

        BindDataList();

    }

    public void Show()
    {
        string selectCommandText = @"SELECT * from booktype";

        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText, connection);

        DropDownList2.DataSource = dataSet.Tables[0].DefaultView;
        DropDownList2.DataValueField = dataSet.Tables[0].Columns[0].ColumnName;
        DropDownList2.DataTextField = dataSet.Tables[0].Columns[1].ColumnName; ;
        DropDownList2.DataBind();
    }

    protected void BindDataList()
    {
        string aaaa = TextBox1.Text.ToString();
        string baobao = DropDownList1.SelectedItem.Text.ToString();
        string selectCommandText1;
        string department = DropDownList2.SelectedValue;
        if (baobao == "男包")
        {
            string aa = "男包".ToString();

            selectCommandText1 = @"select bookinfo.*,booktype.* from bookInfo,Booktype
                where bookinfo.BookTypeID=booktype.BookTypeID and bookfm='" + aa + "' and bookinformation like '%" + aaaa + "%' and booktype.BookTypeID='" + department + "' ";
        }
        else if (baobao == "女包")
        {
            string bb = "女包".ToString();
            selectCommandText1 = @"select bookinfo.*,booktype.* from bookInfo,Booktype
                where bookinfo.BookTypeID=booktype.BookTypeID and bookfm='" + bb + "' and bookinformation like '%" + aaaa + "%' and booktype.BookTypeID='" + department + "' ";
        }
        else
        {
            selectCommandText1 = @"select bookinfo.*,booktype.* from bookInfo,Booktype 
                where bookinfo.BookTypeID=booktype.BookTypeID and bookinformation like '%" + aaaa + "%' ";
        }

        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText1, connection);

        DataList1.DataSource = dataSet;
        this.DataList1.DataKeyField = "bookid";
        DataList1.DataBind();
    }
}
