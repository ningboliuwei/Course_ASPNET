using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridViewDataSourceCRUDExample : System.Web.UI.Page
{//不在数据表中设置主键，看看会怎么样
	private SqlDataSource dataSource = new SqlDataSource();
	private string connectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET";

	protected void Page_Load(object sender, EventArgs e)
	{
		InitializeDataSource();
		ShowData();
	}

	public void InitializeDataSource()
	{
		dataSource.ConnectionString = connectionString;
		dataSource.SelectCommand = "SELECT * FROM Student";
		dataSource.InsertCommand = "INSERT INTO Student VALUES(@Sno, @Sname, @Ssex, @Sage, @Sdept)";
		dataSource.UpdateCommand = "UPDATE Student SET Sname=@Sname, Ssex=@Ssex, Sage=@Sage, Sdept=@Sdept WHERE Sno=@Sno";
		dataSource.DeleteCommand = "DELETE FROM Student WHERE Sno=@Sno";

		dataSource.InsertParameters.Add(new Parameter("Sno", TypeCode.String, ""));
		dataSource.InsertParameters.Add(new Parameter("Sname", TypeCode.String, ""));
		dataSource.InsertParameters.Add(new Parameter("Ssex", TypeCode.String, ""));
		dataSource.InsertParameters.Add(new Parameter("Sage", TypeCode.Int32, "0"));
		dataSource.InsertParameters.Add(new Parameter("Sdept", TypeCode.String, ""));

		dataSource.UpdateParameters.Add(new Parameter("Sno", TypeCode.String, ""));
		dataSource.UpdateParameters.Add(new Parameter("Sname", TypeCode.String, ""));
		dataSource.UpdateParameters.Add(new Parameter("Ssex", TypeCode.String, ""));
		dataSource.UpdateParameters.Add(new Parameter("Sage", TypeCode.Int32, "0"));
		dataSource.UpdateParameters.Add(new Parameter("Sdept", TypeCode.String, ""));

		dataSource.DeleteParameters.Add(new Parameter("Sno", TypeCode.String, ""));
	}

	public void ShowData()
	{
		gridview1.DataSource = dataSource;
		gridview1.DataBind();
	}

	public void DeleteData()
	{
		dataSource.DeleteParameters["Sno"].DefaultValue = "95012";
		dataSource.Delete();
	}

	public void InsertData()
	{
		dataSource.InsertParameters["Sno"].DefaultValue = "95012";
		dataSource.InsertParameters["Sname"].DefaultValue = "郑芳芳";
		dataSource.InsertParameters["Sage"].DefaultValue = "20";
		dataSource.InsertParameters["Ssex"].DefaultValue = "女";
		dataSource.InsertParameters["Sdept"].DefaultValue = "SE";
		dataSource.Insert();

	}

	public void UpdateData()
	{
		//注意这里有什么问题没有
		dataSource.UpdateParameters["Sdept"].DefaultValue = "MA";
		dataSource.UpdateParameters["Sno"].DefaultValue = "95012";
		dataSource.Update();
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