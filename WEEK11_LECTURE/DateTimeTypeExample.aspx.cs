using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DateTimeTypeExample : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		DateTime now = DateTime.Now;

		Response.Write("今天的日期是："+ now.Date + "<br/>");
		//如果只显示日期
		Response.Write("今天的日期是：" + now.Date.ToString("yyyy-MM-dd") + "<br/>");
		Response.Write("现在的时间是：" + now.TimeOfDay + "<br/>");
		Response.Write("现在的时间是：" + now.ToString("HH:mm:ss") + "<br/>");
		Response.Write("今天是" + now.DayOfWeek + "<br/>");
		Response.Write("今天是今年的第" + now.DayOfYear + "天" + "<br/>");

		//90天以后是
		DateTime dueDate = now.AddDays(90);
		
		//90天前是
		DateTime dueDate2 = now.AddDays(-90);
		
		//计算时间间隔
		TimeSpan ts = dueDate.Subtract(now);

		Response.Write(ts);
	}
}