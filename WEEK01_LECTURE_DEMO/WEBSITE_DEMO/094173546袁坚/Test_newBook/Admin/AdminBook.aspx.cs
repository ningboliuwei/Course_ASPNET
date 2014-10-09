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
using System.Data.SqlClient;

public partial class Admin_AdminBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Bind();
        }
    }
    SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);
    private void Bind()
    {
        string name = "";

            name = Session["Name"].ToString();
       

        SqlDataAdapter adq = new SqlDataAdapter("SELECT DISTINCT * FROM BookInfo order by Attention desc", myConnection);
        DataSet dataset = new DataSet();


        try
        {
            myConnection.Open();
            adq.Fill(dataset);
            myConnection.Close();
            GridView1.DataSource = dataset;
            GridView1.DataKeyNames = new String[] { "BookID" };
            GridView1.DataBind();


            btnFirst.Enabled = true;
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnLast.Enabled = true;

            LblCurrentIndex.Text = "第 " + (GridView1.PageIndex + 1).ToString() + " 页";
            LblPageCount.Text = "共 " + GridView1.PageCount.ToString() + " 页";
            LblRecordCount.Text = "总共 " + dataset.Tables[0].Rows.Count.ToString() + " 条";
            if (GridView1.PageIndex == 0)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }
            else if (GridView1.PageIndex == GridView1.PageCount - 1)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            pageDropDownList.Items.Clear();
            for (int i = 1; i < GridView1.PageCount + 1; i++)
            {
                pageDropDownList.Items.Add(i.ToString());
            }
            pageDropDownList.SelectedValue = Convert.ToString(GridView1.PageIndex + 1);
            // 计算生成分页页码,分别为："首 页" "上一页" "下一页" "尾 页"
            btnFirst.CommandName = "1";
            btnPrev.CommandName = (GridView1.PageIndex == 0 ? "1" : GridView1.PageIndex.ToString());

            btnNext.CommandName = (GridView1.PageCount == 1 ? GridView1.PageCount.ToString() : (GridView1.PageIndex + 2).ToString());
            btnLast.CommandName = GridView1.PageCount.ToString();
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
            Response.End();
        }
    }
    protected void PagerButtonClick(object sender, EventArgs e)
    {
        GridView1.PageIndex = Convert.ToInt32(((LinkButton)sender).CommandName) - 1;
        Bind();
    }
    //跳转页
    protected void pageDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView1.PageIndex = Convert.ToInt32(pageDropDownList.SelectedValue) - 1;
        Bind();
    }
    /* protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
     {
         e.Row.Attributes["onmouseover"] = "ItemOver(this)";
         if (e.Row.RowType == DataControlRowType.DataRow)
         {
             e.Row.Cells[1].Attributes.Add("style", "vnd.ms-excel.numberformat:@;");
         }
     }*/

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

                    ((LinkButton)e.Row.Cells[4].Controls[0]).Attributes.Add("onclick", "javascript:return confirm('你确认要删除：\"" + e.Row.Cells[1].Text + "\"吗?')");

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

    //////////  删除
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        myConnection.Open();//打开连接
        int bookorderid = (int)GridView1.DataKeys[e.RowIndex].Value;
        string bookorderidd = bookorderid.ToString();

        string SQLString2 = "delete bookinfo where bookid='" + bookorderidd + "'";
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
            Response.Redirect(String.Format("AdminBookUpdate.aspx?an={0}&id={1}", GridView1.DataKeys[Convert.ToInt16(e.CommandArgument)].Value, GridView1.DataKeys[Convert.ToInt16(e.CommandArgument)].Value));
        }
        string cc = GridView1.DataKeys[Convert.ToInt16(e.CommandArgument)].Value.ToString();
        string comm = "SELECT DISTINCT * FROM BookInfo  WHERE  bookid='" + cc + "'order by bookid desc ";

        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(comm, myConnection);

        string dd = dataSet.Tables[0].Rows[0]["BookID"].ToString();
        string price = dataSet.Tables[0].Rows[0]["BookPrice"].ToString();
        if (e.CommandName == "show")
        {
            //Response.Redirect("../Book_Details.aspx?id=" + dd);
            Response.Redirect(String.Format("../Book_Detail.aspx?id={0}&price={1}", dd, price));
        }
    }
    protected void BtnSearch_Click(object sender, ImageClickEventArgs e)
    {

        BindDataList();

    }






    protected void BindDataList()
    {
        string aaaa = TextBox1.Text.ToString();
        string baobao = DropDownList1.SelectedItem.Text.ToString();
        string selectCommandText1;
        if (baobao == "男包")
        {
            string aa = "男包".ToString();

            selectCommandText1 = @"select bookinfo.*,booktype.* from bookInfo,Booktype
                where bookinfo.BookTypeID=booktype.BookTypeID and bookfm='" + aa + "' and bookname like '%" + aaaa + "%' ";
        }
        else if (baobao == "女包")
        {
            string bb = "女包".ToString();
            selectCommandText1 = @"select bookinfo.*,booktype.* from bookInfo,Booktype
                where bookinfo.BookTypeID=booktype.BookTypeID and bookfm='" + bb + "' and bookname like '%" + aaaa + "%' ";
        }
        else
        {
            selectCommandText1 = @"select bookinfo.*,booktype.* from bookInfo,Booktype 
                where bookinfo.BookTypeID=booktype.BookTypeID and bookname like '%" + aaaa + "%' ";
        }

        DataSet dataSet1 = SqlHelper.GetDataSetBySqlCommand(selectCommandText1, myConnection);

        GridView1.DataSource = dataSet1;
        GridView1.DataBind();
    }
}
