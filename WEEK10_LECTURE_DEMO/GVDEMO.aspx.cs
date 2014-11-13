#region

using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

#endregion

public partial class GVDEMO : Page
{
	private static DataSet dataSet;
	private string connectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET";

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			BindGridView();
		}
	}


	private void BindGridView()
	{
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Student", connection);

			if (dataSet == null)
			{
				dataSet = new DataSet();
			}

			dataSet.Clear();
			dataAdapter.Fill(dataSet, "Student");
			GridView1.DataSource = dataSet;
			GridView1.DataBind();
		}
	}


	protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
	{
		dataSet.Tables[0].Rows[e.RowIndex].Delete();
		dataAdapter da = new dataAdapter();
		da.Delte
	}

	protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
	{
		GridView1.EditIndex = e.NewEditIndex;
		BindGridView();
	}

	protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
	{
		GridView1.EditIndex = -1;
		BindGridView();
	}
}