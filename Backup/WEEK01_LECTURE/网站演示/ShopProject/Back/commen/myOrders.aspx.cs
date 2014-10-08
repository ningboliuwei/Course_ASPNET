using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProject.Back.commen
{
    public partial class myOrders : System.Web.UI.Page
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
            string myid = Session["id"].ToString();
            
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select orid,username,shname,time,shoppay,posttype from UserInfo a,ShopThing b,Orders c where a.userid=c.userid and b.shopid=c.shopid and c.userid='"+myid+"'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            GridView1.DataSource = dataSet;
            GridView1.DataKeyNames = new string[] { "orid" };
            GridView1.DataBind();

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridView1.Rows[i].Cells[0].Text = (i + 1).ToString();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            show();
        }
    }
}
