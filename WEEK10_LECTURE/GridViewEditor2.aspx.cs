using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridViewEditor2 : System.Web.UI.Page
{
	//为了在不同的事件中都用到 DataSet 与 DataAdapter 对象，需要将这些对象声明为当前页面类的成员变量，放在所有方法的外面。
	//为了防止页面刷新后对象被销毁，造成数据丢失，需要将着几个对象声明为静态类型（static）
	private static DataSet dataSet = new DataSet();
	private static string connectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET";
	private static SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Student", connectionString);

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			InitializeDataAdapter();
			BindGridView();
		}
	}

	/// <summary>
	/// 利用 CommandBuilder，根据 DataAdapter 对象的 SelectCommand 属性，自动生成其余的三个 SqlCommand 对象
	/// </summary>
	private void InitializeDataAdapter()
	{
		SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
		dataAdapter.DeleteCommand = builder.GetDeleteCommand();
		dataAdapter.UpdateCommand = builder.GetUpdateCommand();
		dataAdapter.InsertCommand = builder.GetInsertCommand();
	}

	/// <summary>
	/// 刷新数据
	/// </summary>
	private void BindGridView()
	{
		//每次填充新的数据前，都把原有的数据清空
		dataSet.Clear();
		//利用 DataAdapter，将通过 SelectCommand 得到的数据，填充到 DataSet 中
		dataAdapter.Fill(dataSet);
		GridView1.DataSource = dataSet;
		GridView1.DataBind();
	}


	protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
	{
		//删除 DataSet 中点击了“删除”按钮那一行的数据
		dataSet.Tables[0].Rows[e.RowIndex].Delete();
		//将 DataSet 中数据的修改提交到数据库中
		dataAdapter.Update(dataSet);
		//刷新数据
		BindGridView();
	}

	protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
	{
		GridView1.EditIndex = e.NewEditIndex;
		BindGridView();
	}

	protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
	{
		//点击 “取消” 之后，取消编辑状态。
		GridView1.EditIndex = -1;
		BindGridView();
	}

	protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
	{
		//获取编辑状态下当前行中每一列的值
		//当 GridView 中的某一行处于编辑状态时，可以看成是某个单元格中放置了一个 TextBox 控件
		//所以需要得到这个 TextBox 控件，并获取其中的文本
		string sno = (GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text;
		string sname = (GridView1.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox).Text;
		string ssex = (GridView1.Rows[e.RowIndex].Cells[5].Controls[0] as TextBox).Text;
		string sage = (GridView1.Rows[e.RowIndex].Cells[6].Controls[0] as TextBox).Text;
		string sdept = (GridView1.Rows[e.RowIndex].Cells[7].Controls[0] as TextBox).Text;

		//获取 DataSet 中与点击了 “编辑” 按钮的这行对应的数据行
		DataRow row = dataSet.Tables[0].Rows[e.RowIndex];
		//修改其中各字段的值
		row["Sno"] = sno;
		row["Sname"] = sname;
		row["Ssex"] = ssex;
		row["Sage"] = sage;
		row["Sdept"] = sdept;

		//提交到数据库中
		dataAdapter.Update(dataSet);
		GridView1.EditIndex = -1;
		BindGridView();
	}
}