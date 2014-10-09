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
    public partial class left : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                show();
                if (Session["username"] == null)
                {
                    Label1.Text = "潘骁超";
                }
                else
                {
                    Label1.Text = Session["username"].ToString();
                }   
            }
        }
        public void show()
        {
            string id = Session["id"].ToString();
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from UserInfo where userid='" + id + "'";

            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            Image1.ImageUrl = "/images/Userimages/" + dataSet.Tables[0].Rows[0]["userpicture"].ToString();
            if (dataSet.Tables[0].Rows[0]["role"].ToString().Trim() == "1")
            {
                Label2.Text = "管理员";
            }
            else
            {
                Label2.Text = "普通会员";
            }



        }
    }
}