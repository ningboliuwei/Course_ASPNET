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
    public partial class showSort : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                show();
            }
        }

        public  void show()
        {
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from Sort";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            GridView1.DataSource = dataSet;
            GridView1.DataKeyNames = new string[] { "sortid" };
            GridView1.DataBind();

            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridView1.Rows[i].Cells[0].Text = (i + 1).ToString();
            }
        }
       //修改

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            show();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            show();
        }
        //更新
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Values[0].ToString();
            string sortname = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1")).Text;

            string SqlStr = "update Sort set sortname='"+sortname+"' where sortid='"+id+"'";
            SqlConnection conn = sqlHelper.Connection();//新连接
            SqlCommand comm = new SqlCommand(SqlStr, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            comm.Clone();
            conn.Close();
            GridView1.EditIndex = -1;
            show();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Values[0].ToString();
            string SqlStr = "delete from Sort where sortid='" + id + "'";
            SqlConnection conn = sqlHelper.Connection();//新连接
            SqlCommand comm = new SqlCommand(SqlStr, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            comm.Clone();
            conn.Close();
            GridView1.EditIndex = -1;
            show();


        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            show();
        }

        


    }
}
