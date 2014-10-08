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
    public partial class OrdersInfo : System.Web.UI.Page
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

            string id = Request.QueryString["id"];
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select c.*,username,shname from UserInfo a,ShopThing b,Orders c where a.userid=c.userid and b.shopid=c.shopid and orid='"+id+"'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            GridView1.DataSource = dataSet;
            GridView1.DataKeyNames = new string[] { "orid" };
            GridView1.DataBind();

        }
    }
}
