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
		//以下代码为什么不放到 if (!Page.IsPostBack) 语句块里面？
		//若 Session 中已经保存了购物车数据
		if (Session["cart"] != null)
		{
			//那么将 Session 中的购物车数据取出并转换为 List<CartItemInfo> 类型
			cart = Session["cart"] as List<CartItemInfo>;
		}
		else
		{
			//否则创建一个新的实例
			cart = new List<CartItemInfo>();
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
		//通过 CommandName 判断用户在 DataList 中点击的是否是“添加到购物车”按钮，若是
		if (e.CommandName == "AddToCart")
		{
			//获取用户点击的那一项的 ItemID（通过事先通过数据绑定实现的 CommandArgument 属性）
			string itemId = e.CommandArgument.ToString();
			//通过 e.Item.FindControl() 方法，获取用户点击的那一项中的指定名称的控件，并得到控件中的属性值
			string name = (e.Item.FindControl("lblTitle") as Label).Text;
			float price = Convert.ToSingle((e.Item.FindControl("lblPrice") as Label).Text);
			//获取用户在“购买数量”文本框中输入的值
			int quantity = Convert.ToInt32(txtCount.Text);
			//通过调用构造函数，创建一个 CartItemInfo 类型的对象，用于保存购物车中的一条记录
			CartItemInfo itemInfo = new CartItemInfo(itemId, name, price, quantity);
			//将 CartItemInfo 类型的对象作为一个元素，添加到 List<CartItemInfo> 类型的对象中去
			cart.Add(itemInfo);
			//将 List<CartItemInfo> 类型的对象放入 Session 中（以便在另外一个页面得到购物车中的数据）
			Session["cart"] = cart;
		}
	}

}