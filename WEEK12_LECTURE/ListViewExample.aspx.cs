using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ListView的使用;

public partial class ListViewExample : System.Web.UI.Page
{
	private List<CartItemInfo> cart;

	protected void Page_Load(object sender, EventArgs e)
	{
		//以下代码为什么不放到 if 语句块里面？
		if (Session["cart"] == null)
		{
			cart = new List<CartItemInfo>();
		}
		else
		{
			cart = Session["cart"] as List<CartItemInfo>;
		}

		if (!Page.IsPostBack)
		{
			BindListView();
		}
	}

	protected void BindListView()
	{
		string commandText =
			@"SELECT ItemID, Title, Price, Image FROM Items";
		DataSet dataSet = SqlHelper.GetDataSetBySqlCommand(commandText, SqlHelper.GetConnection());
		lvwItems.DataSource = dataSet;
		lvwItems.DataBind();
	}

	protected void lvwItems_ItemCommand(object sender, System.Web.UI.WebControls.ListViewCommandEventArgs e)
	{
		if (e.CommandName == "AddToCart")
		{

			string itemId = e.CommandArgument.ToString();
			string name = (e.Item.FindControl("lblTitle") as Label).Text;
			float price = Convert.ToSingle((e.Item.FindControl("lblPrice") as Label).Text);
			int quantity = Convert.ToInt32(txtCount.Text);
			CartItemInfo itemInfo = new CartItemInfo(itemId, name, price, quantity);


			cart.Add(itemInfo);
		}

		//能用 static 吗？
		Session["cart"] = cart;
	}

}