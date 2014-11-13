using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridViewDataAdapterCRUDExample : System.Web.UI.Page
{
	//不在数据表中设置主键，看看会怎么样
	private SqlConnection connection = new SqlConnection();
	private SqlDataAdapter dataAdapter = new SqlDataAdapter();
	private DataSet dataSet = new DataSet();
	private string connectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET"; 

	protected void Page_Load(object sender, EventArgs e)
	{
		InitializeDataAdapter();
		ShowData();
	}

	public void InitializeDataAdapter()
	{
		connection.ConnectionString = connectionString ;

		SqlCommand selectCommand = new SqlCommand("SELECT * FROM Student", connection);
		dataAdapter.SelectCommand = selectCommand;

		SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
		dataAdapter.DeleteCommand = builder.GetDeleteCommand();
		dataAdapter.UpdateCommand = builder.GetUpdateCommand();
		dataAdapter.InsertCommand = builder.GetInsertCommand();
	}

	public void ShowData()
	{
		dataAdapter.Fill(dataSet);
		gridview1.DataSource = dataSet;
		gridview1.DataBind();
	}

	public void DeleteData()
	{
		dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count - 1].Delete();
		dataAdapter.Update(dataSet);
	}

	public void InsertData()
	{
			DataRow row = dataSet.Tables[0].NewRow();
			row["Sno"] = "95012";
			row["Sname"] = "郑芳芳";
			row["Sage"] = "20";
			row["Ssex"] = "女";
			row["Sdept"] = "SE";
			dataSet.Tables[0].Rows.InsertAt(row, dataSet.Tables[0].Rows.Count);
			dataAdapter.Update(dataSet);
	}

	public void UpdateData()
	{
		dataSet.Tables[0].Rows[dataSet.Tables[0].Rows.Count - 1]["Sdept"] = "MA";
		dataAdapter.Update(dataSet);
	}

	protected void btnDelete_Click(object sender, EventArgs e)
	{
		DeleteData();
		gridview1.DataBind();
	}

	protected void btnInsert_Click(object sender, EventArgs e)
	{
		InsertData();
		gridview1.DataBind();
	}

	protected void btnUpdate_Click(object sender, EventArgs e)
	{
		UpdateData();
		gridview1.DataBind();
	}
}