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

public partial class Book_Order : System.Web.UI.Page
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

    private SqlConnection myConnection =
        new SqlConnection(ConfigurationManager.ConnectionStrings["nd_data"].ConnectionString);

    private void Bind()
    {
        string name = "";
        if (Session["Name"] != null)
        {

            name = Session["Name"].ToString();
            Label1.Text = Session["Address"].ToString();
        }
        else
        {
            name = Session["Admin"].ToString();
        }


        SqlDataAdapter adq =
            new SqlDataAdapter(
                "SELECT DISTINCT BookOrder.*,BookPrice,BookName,BookInfoID FROM BookOrder,BookInfo  WHERE bookid=bookinfoid and userinfoname='" +
                name + "'order by Datatime ", myConnection);
        DataSet dataset = new DataSet();


        try
        {
            myConnection.Open();
            adq.Fill(dataset);
            myConnection.Close();
            GridView1.DataSource = dataset;
            GridView1.DataKeyNames = new String[] {"BookOrderID"};
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

            btnNext.CommandName = (GridView1.PageCount == 1
                                       ? GridView1.PageCount.ToString()
                                       : (GridView1.PageIndex + 2).ToString());
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
        GridView1.PageIndex = Convert.ToInt32(((LinkButton) sender).CommandName) - 1;
        Bind();
    }

    //跳转页
    protected void pageDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView1.PageIndex = Convert.ToInt32(pageDropDownList.SelectedValue) - 1;
        Bind();
    }


    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {


        try
        {

            e.Row.Attributes["onmouseover"] = "ItemOver(this)"; //跳转页

            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {

                    ((LinkButton) e.Row.Cells[8].Controls[0]).Attributes.Add("onclick",
                                                                             "javascript:return confirm('你确认要删除此订单吗?')");

                }

                //当鼠标放上去的时候 先保存当前行的背景颜色 并给附一颜色
                e.Row.Attributes.Add("onmouseover",
                                     "currentcolor=this.style.backgroundColor;this.style.backgroundColor='#C9D3E2',this.style.fontWeight='';");
                //当鼠标离开的时候 将背景颜色还原的以前的颜色 
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=currentcolor,this.style.fontWeight='';");
                e.Row.Attributes["style"] = "Cursor:pointer";

                e.Row.Cells[1].Attributes.Add("style", "vnd.ms-excel.numberformat:@;"); //跳转页
            }
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message); //显示错误原因。
        }

    }

    //////////  删除
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        myConnection.Open(); //打开连接
        int bookorderid = (int) GridView1.DataKeys[e.RowIndex].Value;
        string bookorderidd = bookorderid.ToString();

        string SQLString2 = "delete bookorder where bookorderid='" + bookorderidd + "'";
        SqlCommand sqlcom = new SqlCommand(SQLString2, myConnection);
        try
        {

            sqlcom.ExecuteNonQuery();
            Response.Write("<script>alert('亲，订单被删除了哦!')</script>");
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

        string cc = GridView1.DataKeys[Convert.ToInt16(e.CommandArgument)].Value.ToString();
        string comm =
            "SELECT DISTINCT BookOrder.*,BookPrice,BookName,BookInfoID FROM BookOrder,BookInfo  WHERE  bookorderid='" +
            cc + "'order by Datatime desc ";

        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(comm, myConnection);
        string dd = dataSet.Tables[0].Rows[0]["BookInfoID"].ToString();
        string price = dataSet.Tables[0].Rows[0]["BookPrice"].ToString();

        if (e.CommandName == "show")
        {
            Response.Redirect(String.Format("Book_Detail.aspx?id={0}&price={1}", dd, price));
        }
        //if (e.CommandName == "buy")
        //{
        //    Response.Write("<script>alert(' 亲,结算成功，等着收货吧！')</script>");
        //}

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label2.Visible = true;
        myConnection.Open();
        string SQLString =
            @"SELECT DISTINCT BookOrder.*,BookPrice,BookName,BookInfoID FROM BookOrder,BookInfo  WHERE bookid=bookinfoid and userinfoname='" +
            Session["Name"].ToString() + "'order by Datatime ";
        //
        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(SQLString, myConnection);

        int countpriceall = 0;

        for (int a = 0; a < dataSet.Tables[0].Rows.Count; a++)
        {
            countpriceall += Convert.ToInt32(dataSet.Tables[0].Rows[a]["BookCountPrice"].ToString());
        }
        Label2.Text = " ￥" + countpriceall.ToString();
        Label1.Text = Session["Address"].ToString();



    }



    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        bool bAll = ((CheckBox) (sender)).Checked;
        foreach (GridViewRow dr in GridView1.Rows)
        {
            ((CheckBox) dr.FindControl("CheckBox2")).Checked = bAll;
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


    protected void Button2_Click(object sender, EventArgs e)
    {
        
        Label2.Visible = true;
        myConnection.Open();
        string SQLString =
            @"SELECT DISTINCT BookOrder.*,BookPrice,BookName,BookInfoID FROM BookOrder,BookInfo  WHERE bookid=bookinfoid and userinfoname='" +
            Session["Name"].ToString() + "'order by Datatime ";
        //
        DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(SQLString, myConnection);


        int countpriceall = 0;
        for (int i = 0; i <= GridView1.Rows.Count - 1; i++)
        {
            CheckBox cbox = (CheckBox) GridView1.Rows[i].FindControl("CheckBox2"); 
      
            if (cbox.Checked == true)
            {

              countpriceall += Convert.ToInt32(dataSet.Tables[0].Rows[i]["BookCountPrice"].ToString());


            }
        }   
        Label2.Text = " ￥" + countpriceall.ToString();
        Label1.Text = Session["Address"].ToString();
    }


}
