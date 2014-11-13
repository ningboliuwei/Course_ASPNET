using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GridViewEditor : System.Web.UI.Page
{
	private string connectionString = "server=.;database=schooldb;uid=ASPNET;pwd=ASPNET";
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			BindGridView();
		}
	}

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		GridView1.Rows[GridView1.SelectedIndex].BackColor = Color.LightPink;
		//遍历 GridView 中所有行，若当前行被选中在，则修改背景色，否则设为默认的透明背景色。
		foreach (GridViewRow row in GridView1.Rows)
		{
			if (row == GridView1.SelectedRow)
			{
				row.BackColor = Color.LightPink;
			}
			else
			{
				row.BackColor = Color.Transparent;
			}
		}
	}

	private void BindGridView()
	{
		using (
			SqlConnection connection =
				new SqlConnection(connectionString))
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Student", connection);
			DataSet dataSet = new DataSet();
			dataAdapter.Fill(dataSet, "Student");
			GridView1.DataSource = dataSet;
			GridView1.DataBind();
		}

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

	protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
	{
		string id = GridView1.Rows[e.RowIndex].Cells[3].Text;

		using (
			SqlConnection connection =
				new SqlConnection(connectionString))
		{
			string commanText = string.Format("DELETE FROM Student WHERE Sno = '{0}'", id);
			var command = new SqlCommand(commanText, connection);
			if (connection.State != ConnectionState.Open)
			{
				connection.Open();
			}
			command.ExecuteNonQuery();
			BindGridView();
		}
		//-------------------------------使用SQL语句删除----------------------
	}

	protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
	{
		string sno = (GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox).Text;
		string sname = (GridView1.Rows[e.RowIndex].Cells[4].Controls[0] as TextBox).Text;
		string ssex = (GridView1.Rows[e.RowIndex].Cells[5].Controls[0] as TextBox).Text;
		string sage = (GridView1.Rows[e.RowIndex].Cells[6].Controls[0] as TextBox).Text;
		string sdept = (GridView1.Rows[e.RowIndex].Cells[7].Controls[0] as TextBox).Text;
		using (
			SqlConnection connection =
				new SqlConnection(connectionString))
		{
			string commanText =
				string.Format("UPDATE Student SET Sname = '{0}', Ssex = '{1}', Sage = '{2}', Sdept = '{3}' WHERE Sno = '{4}'", sname,
					ssex, sage, sdept, sno);
			var command = new SqlCommand(commanText, connection);
			if (connection.State != ConnectionState.Open)
			{
				connection.Open();
			}
			command.ExecuteNonQuery();
			GridView1.EditIndex = -1;
			BindGridView();

		}
	}
}