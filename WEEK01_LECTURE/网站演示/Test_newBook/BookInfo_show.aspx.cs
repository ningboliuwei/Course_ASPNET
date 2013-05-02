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
        }
    }

    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);

    protected void BindDataList()
    {
        string selectCommandText1 = @"select bookinfo.*,booktype.* from bookInfo,Booktype where bookinfo.BookTypeID=booktype.BookTypeID";
        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(selectCommandText1, connection);

        DataList1.DataSource = dataSet;
        this.DataList1.DataKeyField = "bookid";
        DataList1.DataBind();
    }
}
