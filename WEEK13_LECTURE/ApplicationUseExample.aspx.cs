using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ApplicationUseExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		Response.Write("当前在线人数：" + Application["online"] + "<br/>您是总共第" + Application["total"] + "名访客");
	}
}