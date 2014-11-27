using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataListExample : System.Web.UI.Page
{
	private List<CartItemInfo> cart;

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			BindDataList();
		}
	}

	protected void BindDataList()
	{
		string commandText =
			@"SELECT ItemID, Title, Price, Image FROM Items"; DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(commandText, SqlHelper.GetConnection());
		DataList1.DataSource = dataSet;
		DataList1.DataBind();
	}
	protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
	{

	}

	protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
	{
		if (e.CommandName == "s")
		{
			//Response.Write("选择, StudentID=" + e.CommandArgument);
		}
		else if (e.CommandName == "e")
		{
			Response.Write("编辑");
		}
		else if (e.CommandName == "d")
		{
			Response.Write("删除");
		}
		else if (e.CommandName == "AddToCart")
		{
			string itemId = e.CommandArgument.ToString();
			string name = (e.Item.FindControl("lblName") as Label).Text;
			float price = Convert.ToSingle((e.Item.FindControl("lblPrice") as Label).Text);
			int quantity = Convert.ToInt32(txtQuantity.Text);
			CartItemInfo itemInfo = new CartItemInfo(itemId, name, price, quantity);


			cart.Add(itemInfo);

			Response.Write("将 " +e.CommandArgument+ "号商品加入购物车");
		}
	}
}