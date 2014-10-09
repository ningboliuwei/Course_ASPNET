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

public partial class AdminBook_type : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Bind();
    }
    SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);
    private void Bind()
    {
        SqlDataAdapter adq = new SqlDataAdapter("SELECT DISTINCT * FROM booktype order by booktypeid ", myConnection);
        DataSet dataset = new DataSet();
        myConnection.Open();
        adq.Fill(dataset);
        myConnection.Close();
        GridView1.DataSource = dataset;
        GridView1.DataKeyNames = new String[] { "BookTypeID" };
        GridView1.DataBind();
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {


        try
        {
            /*if (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate) || e.Row.RowState == DataControlRowState.Edit)
            {
                for (int i = 1; i < GridView1.Columns.Count - 1; i++)
                {

                    TextBox txt = (TextBox)e.Row.Cells[i].Controls[0];
                    txt.Width = Unit.Pixel(60);
                }
            }*/
            e.Row.Attributes["onmouseover"] = "ItemOver(this)";//跳转页

            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {

                    ((LinkButton)e.Row.Cells[2].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：\"" + e.Row.Cells[1].Text + "\"吗?')");

                }

                //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色
                e.Row.Attributes.Add("onmouseover", "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#C9D3E2',this.style.fontWeight='';");
                //当鼠标离开的时候 将背景颜色还原的以前的颜色 
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
                e.Row.Attributes["style"] = "Cursor:pointer";

                e.Row.Cells[1].Attributes.Add("style", "vnd.ms-excel.numberformat:@;");//跳转页
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);//显示错误原因。
        }

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        myConnection.Open();//打开连接
        string  bookorderid = GridView1.DataKeys[e.RowIndex].Value.ToString();

        string SQLString2 = "delete BookType where Booktypeid='" + bookorderid + "'";
        SqlCommand sqlcom = new SqlCommand(SQLString2, myConnection);
        try
        {

            sqlcom.ExecuteNonQuery();
            Response.Write("<script>alert('亲，商品删除了哦!')</script>");
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        sqlcom.Connection.Close();
        Bind();



    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Modify")
        {
            //Response.Redirect("AdminBookUpdate.aspx?an=" + GridView1.DataKeys[Convert.ToInt16(e.CommandArgument)].Value);
            Response.Redirect("AdminType_Update.aspx?an=" + GridView1.DataKeys[Convert.ToInt16(e.CommandArgument)].Value);
        }
    }

}
