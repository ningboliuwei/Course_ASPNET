using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListView的使用
{
	public class CartItemInfo
	{
		public string ItemId { get; set; }

		public string Name { get; set; }

		public float Price { get; set; }

		public int Quantity { get; set; }

		public CartItemInfo(string itemId, string name, float price, int quantity)
		{
			ItemId = itemId;
			Name = name;
			Price = price;
			Quantity = quantity;
		}


	}
}