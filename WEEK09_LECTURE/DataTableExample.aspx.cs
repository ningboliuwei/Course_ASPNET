using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataTableExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		DataTable table = new DataTable();
		//第二步
		//table.Columns.Add("Sn", typeof(int));
		table.Columns.Add("Sno", typeof(string));
		table.Columns.Add("Sname", typeof(string));
		table.Columns.Add("Sage", typeof(int));

		//在DataTable中添加新的一行
		DataRow row = table.NewRow();
		row["Sno"] = "95001";
		row["Sname"] = "Tom";
		row["Sage"] = 16;
		table.Rows.Add(row);

		//在DataTable中再添加新的一行
		row = table.NewRow();
		row["Sno"] = "95002";
		row["Sname"] = "Jane";
		row["Sage"] = 18;
		table.Rows.Add(row);

		//table.Rows.RemoveAt(1);
		
		//第二步
		//for (int i = 0; i < table.Rows.Count; i++)
		//{
		//    table.Rows[i]["Sn"] = i + 1;
		//}

		GridView1.DataSource = table;
		GridView1.DataBind();

	}
}