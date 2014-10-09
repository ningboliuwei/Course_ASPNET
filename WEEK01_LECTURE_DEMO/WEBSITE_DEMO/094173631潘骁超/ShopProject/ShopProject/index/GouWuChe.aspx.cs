using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopProject.index
{
    public partial class GouWuChe : System.Web.UI.Page
    {
        public static int num;
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if(Session["gouwuche"]==null)
                {
                    if (Session["datatable"] == null)
                    {
                        Panel1.Visible = true;
                        Label1.Visible = false;
                        Label2.Text = "0元";
                    }
                    else
                    {
                        Panel1.Visible = false;
                        Label1.Visible = true;
                        showtable();
                    }   
                }
                else
                {                  
                        Panel1.Visible = false;
                        Label1.Visible = true;
                        show();
                }
            }
        }

        public void show()
        {
            
            if(Session["datatable"] ==null)
            {
                newbind(); //新建
            }
            else
            {
                updata(); //更新
            }
        }
       
        public DataTable newtable()
        {
            DataTable dt=new DataTable();
            dt.Columns.Add(new DataColumn("shopid", typeof (string)));
            dt.Columns.Add(new DataColumn("shname", typeof(string)));
            dt.Columns.Add(new DataColumn("num", typeof(int)));
            dt.Columns.Add(new DataColumn("price", typeof(float)));
            return dt;

        }
        //新建
        public void newbind()
        {
            DataTable dataTable = newtable();
            DataRow dr;
            string id = Session["gouwuche"].ToString();
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing where shopid='" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            dr = dataTable.NewRow();

            dr[0] = dataSet.Tables[0].Rows[0]["shopid"].ToString();
            dr[1] = dataSet.Tables[0].Rows[0]["shname"].ToString();
            dr[2] = 1;
            dr[3] = dataSet.Tables[0].Rows[0]["price"].ToString();

            dataTable.Rows.Add(dr);

            GridView1.DataSource = dataTable;
            GridView1.DataKeyNames = new string[] { "shopid" };
            GridView1.DataBind();
            
            Money(dataTable);
            Session["datatable"] = dataTable;

        }
        //更新
        public void updata()
        {
            if(isTrue())
            {
                int a;
                DataRow dr;
                DataTable dataTable = newtable();
                dataTable = Session["datatable"] as DataTable;
                //操作数据
                a=Convert.ToInt16(dataTable.Rows[num]["num"]);
                a++;
                dataTable.Rows.RemoveAt(num);
                //再更新
                string id = Session["gouwuche"].ToString();
                SqlConnection conn = sqlHelper.Connection();
                string CommandText = @"select * from ShopThing where shopid='" + id + "'";
                DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

                dr = dataTable.NewRow();

                dr[0] = dataSet.Tables[0].Rows[0]["shopid"].ToString();
                dr[1] = dataSet.Tables[0].Rows[0]["shname"].ToString();
                dr[2] = a;
                dr[3] = dataSet.Tables[0].Rows[0]["price"].ToString();

                dataTable.Rows.Add(dr);

                GridView1.DataSource = dataTable;
                GridView1.DataKeyNames = new string[] { "shopid" };
                GridView1.DataBind();
                Money(dataTable);
                Session["datatable"] = dataTable;
            }
            else
            {
                DataTable dataTable = newtable();
                dataTable = Session["datatable"] as DataTable;
                DataRow dr;
                string id = Session["gouwuche"].ToString();
                SqlConnection conn = sqlHelper.Connection();
                string CommandText = @"select * from ShopThing where shopid='" + id + "'";
                DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

                dr = dataTable.NewRow();

                dr[0] = dataSet.Tables[0].Rows[0]["shopid"].ToString();
                dr[1] = dataSet.Tables[0].Rows[0]["shname"].ToString();
                dr[2] = 1;
                dr[3] = dataSet.Tables[0].Rows[0]["price"].ToString();

                dataTable.Rows.Add(dr);

                GridView1.DataSource = dataTable;
                GridView1.DataKeyNames=new string[]{"shopid"};
                GridView1.DataBind();
                Money(dataTable);
                Session["datatable"] = dataTable;
            }
                

        }

        //判断是否是相同的id
        public bool isTrue()
        {
            bool check = false;
            DataTable dataTable = Session["datatable"] as DataTable;
            string id = Session["gouwuche"].ToString();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if(id.Equals(dataTable.Rows[i]["shopid"]))
                {
                    check = true;
                    num = i;
                    break;
                }
            }

            return check;
        }

        //showtable
        public void showtable()
        {
            DataTable dataTable = newtable();
            dataTable = Session["datatable"] as DataTable;

            GridView1.DataSource = dataTable;
            GridView1.DataKeyNames = new string[] { "shopid" };
            GridView1.DataBind();
            Money(dataTable);
            Session["datatable"] = dataTable;
        }
        //删除
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            DataTable dataTable = Session["datatable"] as DataTable;
            dataTable.Rows.RemoveAt(e.RowIndex);

            GridView1.DataSource = dataTable;
            GridView1.DataKeyNames = new string[] { "shopid" };
            GridView1.DataBind();
            Money(dataTable);
            Session["datatable"] = dataTable;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if((Session["datatable"] as DataTable)==null)
            {
                Response.Write("<script>alert('请先购买，再结算！')</script>");
            }
            else
            {

                if(Session["username"]==null)
                {
                    Response.Write("<script>alert('请先登录！')</script>");
                }
                else
                {
                    Response.Redirect("addGouWu.aspx");     
                }
            }
        }


        public void Money(DataTable dataTable)
        {
            float sum = 0;
           
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                sum =sum+ float.Parse(dataTable.Rows[i]["num"].ToString())*float.Parse(dataTable.Rows[i]["price"].ToString());
            }
           

            Label2.Text = sum.ToString()+"元";
        }
        //减数量
        protected void jian(object sender, EventArgs e)
        {
            int a;
            DataRow dr;
            Button t = (Button)sender;
            GridViewRow drv = (GridViewRow)t.NamingContainer;
            int i = drv.RowIndex;
            string num = ((TextBox) GridView1.Rows[i].Cells[3].FindControl("TextBox1")).Text;
            DataTable dataTable = Session["datatable"] as DataTable;

            //操作数据
            a = Convert.ToInt16(dataTable.Rows[i]["num"]);
            a--;
            dataTable.Rows.RemoveAt(i);
            //再更新
            string id = Session["gouwuche"].ToString();
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing where shopid='" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            dr = dataTable.NewRow();

            dr[0] = dataSet.Tables[0].Rows[0]["shopid"].ToString();
            dr[1] = dataSet.Tables[0].Rows[0]["shname"].ToString();
            dr[2] = a;
            dr[3] = dataSet.Tables[0].Rows[0]["price"].ToString();

            dataTable.Rows.Add(dr);

            GridView1.DataSource = dataTable;
            GridView1.DataKeyNames = new string[] { "shopid" };
            GridView1.DataBind();
            Money(dataTable);
            Session["datatable"] = dataTable;

        }
        //加数量
        protected void add(object sender, EventArgs e)
        {
            int a;
            DataRow dr;

            Button t = (Button)sender;
            GridViewRow drv = (GridViewRow)t.NamingContainer;
            int i = drv.RowIndex;
            string num = ((TextBox)GridView1.Rows[i].FindControl("TextBox1")).Text;
            DataTable dataTable = Session["datatable"] as DataTable;

            //操作数据
            a = Convert.ToInt16(dataTable.Rows[i]["num"]);
            a++;
            dataTable.Rows.RemoveAt(i);
            //再更新
            string id = Session["gouwuche"].ToString();
            SqlConnection conn = sqlHelper.Connection();
            string CommandText = @"select * from ShopThing where shopid='" + id + "'";
            DataSet dataSet = sqlHelper.DataSetBySqlCommand(CommandText, conn);

            dr = dataTable.NewRow();

            dr[0] = dataSet.Tables[0].Rows[0]["shopid"].ToString();
            dr[1] = dataSet.Tables[0].Rows[0]["shname"].ToString();
            dr[2] = a;
            dr[3] = dataSet.Tables[0].Rows[0]["price"].ToString();

            dataTable.Rows.Add(dr);

            GridView1.DataSource = dataTable;
            GridView1.DataKeyNames = new string[] { "shopid" };
            GridView1.DataBind();
            Money(dataTable);
            Session["datatable"] = dataTable;
        }

    }
}
