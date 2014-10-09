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
    public partial class deleteShopInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string id = Request.QueryString["id"];

                SqlConnection conn = sqlHelper.Connection();
                string CommandText = @"delete from ShopThing where shopid='" + id + "'";

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
}
