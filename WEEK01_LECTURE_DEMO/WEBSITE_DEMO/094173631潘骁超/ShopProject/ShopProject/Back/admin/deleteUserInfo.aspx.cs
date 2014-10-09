using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProject.Back.admin
{
    public partial class deleteUserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string id = Request.QueryString["id"];

                SqlConnection conn = sqlHelper.Connection();
                string CommandText = @"delete from UserInfo where userid='"+id+"'";

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
                Response.Redirect("/Back/admin/User_Guan.aspx");
            }
        }
    }
}
