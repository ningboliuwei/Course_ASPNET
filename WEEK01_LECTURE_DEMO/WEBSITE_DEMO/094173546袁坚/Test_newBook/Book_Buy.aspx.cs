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

public partial class Book_Buy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {

            //Response.Write("刷新一次");
            if (Session["Name"] == null)
            {

                Response.Redirect("./Users/Login.aspx");

            }
            Bind();

        }

    }
    SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);
    private void Bind()
    {
        DataTable dt;
        if (Session["shoppingcart"] != null)
        {
            dt = (DataTable)Session["shoppingcart"];

        }
        else
        {
            dt = new DataTable();
        }

        GridView1.DataSource = dt;
        GridView1.DataBind();
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            GridView1.Rows[i].Cells[1].Text = (i + 1).ToString();
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        bool bAll = ((CheckBox)(sender)).Checked;
        foreach (GridViewRow dr in GridView1.Rows)
        {
            ((CheckBox)dr.FindControl("CheckBox2")).Checked = bAll;
        }

    }

    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {

            CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox2");

            if (cbox.Checked == true)
            {
                cbox.Checked = true;
            }
            else
            {
                cbox.Checked = false;
            }
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        int num = 0;
        //int index = Convert.ToInt32(e.CommandArgument);
        //GridViewRow selectedRow = GridView1.Rows[index];
        //TableCell contactName = selectedRow.Cells[1];
        //string contact = contactName.Text;  

        DataTable dt1;
        if (Session["shoppingcart"] != null)
        {
            dt1 = (DataTable)Session["shoppingcart"];

        }
        else
        {
            dt1 = new DataTable();
        }


        if (e.CommandName == "show")
        {
            num = Convert.ToInt32(GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)].Value);
        }
		else
		{
			num = Convert.ToInt32(GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)].Value);
		}


        string bookidd = dt1.Rows[num][1].ToString();
        string photo = dt1.Rows[num][4].ToString();
        string name = dt1.Rows[num][5].ToString();
        string count = dt1.Rows[num][0].ToString();
        string price = dt1.Rows[num][2].ToString();

        if (e.CommandName == "order")
        {
            myConnection.Open();
            string SQLString =
                "INSERT INTO BookOrder (bookinfoid,userinfoname,bookcount,bookcountprice,datatime,photo) VALUES('" + bookidd +
                "','" + name + "','" + count + "','" + price.ToString() + "','" + System.DateTime.Now.ToString() + "','" + photo + "')";
            //
            SqlHelper.ExecuteNonQuerySqlCommand(SQLString, myConnection);


            int i = num;

            dt1.Rows.RemoveAt(i);
            try
            {
                Bind();
                Response.Write("<script>alert(' 亲,添加成功，前往查看！')</script>");


            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }


            myConnection.Close();
            Response.Write("Book_Order.aspx");


        }

        if (e.CommandName == "show")
        {
            Response.Redirect(String.Format("Book_Detail.aspx?id={0}&price={1}", bookidd, price));
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] aa = new string[50];

        DataTable dt1;

        if (Session["shoppingcart"] != null)
        {
            dt1 = (DataTable)Session["shoppingcart"];

        }
        else
        {
            dt1 = new DataTable();
        }
        int j = 0;

        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {
            CheckBox cbox = (CheckBox)GridView1.Rows[i].FindControl("CheckBox2");
            if (cbox.Checked == true)
            {

                int aaa = Convert.ToInt32(dt1.Rows[i][6].ToString());
                aa[j] = aaa.ToString();
                j++;
                // int aaa = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["num"].ToString())-1;
                // int aaa = Convert.ToInt32(GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)].Value) - 1; 

                if (aaa == 0)
                {    

                }
                else
                {
                    aaa = aaa - 1;

                }
                string bookidd1 = dt1.Rows[aaa][1].ToString();
                string photo1 = dt1.Rows[aaa][4].ToString();
                string name1 = dt1.Rows[aaa][5].ToString();
                string count1 = dt1.Rows[aaa][0].ToString();
                string price1 = dt1.Rows[aaa][2].ToString();
                string SQLString =
                     @"INSERT INTO BookOrder (bookinfoid,userinfoname,bookcount,bookcountprice,datatime,photo) VALUES('" + bookidd1 +
                      "','" + name1 + "','" + count1 + "','" + price1.ToString() + "','" + System.DateTime.Now.ToString() + "','" + photo1 + "')";
                //
                SqlHelper.ExecuteNonQuerySqlCommand(SQLString, myConnection);


            }
            else
            {
                Response.Write("<script>alert(' 亲,请选择订单！')</script>");
            }

        }
        for (j = 0; j <=49; j++)
        {
            if (aa[j] != null)
            {
                dt1.Rows.RemoveAt(0);
            }
        }
        Bind();
    }
}


