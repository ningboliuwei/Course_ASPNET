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
		DisplayCart();
	}

	private void DisplayCart()
	{
		double totalPrice = 0;
		cart = Session["cart"] as List<CartItemInfo>;

		gdvCart.DataSource = cart;
		gdvCart.DataBind();

		//以下三种方式中选择其中一种即可

		//传统循环方式实现总价计算
		foreach (CartItemInfo c in cart)
		{
			totalPrice += Convert.ToDouble(c.Price) * c.Quantity;
		}

		//LINQ 实现表达式计算
		//totalPrice = (from c in cart select c.Price * c.Quantity).Sum();

		//Lambda表达式实现总价计算
		//totalPrice = cart.Sum(c => c.Price * c.Quantity);


		//在网格的页脚行显示总价
		gdvCart.FooterRow.Cells[gdvCart.FooterRow.Cells.Count - 2].Text = "总价：";
		gdvCart.FooterRow.Cells[gdvCart.FooterRow.Cells.Count - 1].Text = totalPrice.ToString();
	}


}