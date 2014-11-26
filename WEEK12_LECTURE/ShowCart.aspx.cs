using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ListView的使用;

public partial class ShowCart : System.Web.UI.Page
{
	private List<CartItemInfo> cart;

	protected void Page_Load(object sender, EventArgs e)
	{

		cart = Session["cart"] as List<CartItemInfo>;


	}

	private void DisplayCart()
	{
		string outputStr = "";

		double totalPrice = 0;

		foreach (CartItemInfo s in cart)
		{
			outputStr += s.ItemId + "," + s.Name + "," + s.Price + "," + s.Quantity + "<br/>";
			totalPrice += Convert.ToDouble(s.Price) * s.Quantity;
		}

		Response.Write(totalPrice);
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		this.DisplayCart();
	}
}