<%@ Application Language="C#" %>
<%@ Import Namespace="System.IO" %>

<script RunAt="server">
	//当本 Web 应用程序启动时
	protected void Application_Start(object sender, EventArgs e)
	{
		//在线人数设为0
		Application["online"] = 0;
		
		//第二步
		Application["total"] = LoadTotalFromFile("r:\\total.txt");
		//第二步
		//不能用Server.MapPath，因Session结束后，Server对象也被结束，无法保存Server.MapPath的值，可先把Server中的内容保存到Application中，再取
	}

	protected void Session_Start(object sender, EventArgs e)
	{
		Application.Lock();
		Application["online"] = Convert.ToInt32(Application["online"]) + 1;
		Application["total"] = Convert.ToInt32(Application["online"]) + 1;
		Application.UnLock();
	}

	protected void Application_BeginRequest(object sender, EventArgs e)
	{
	}

	protected void Application_AuthenticateRequest(object sender, EventArgs e)
	{
	}

	protected void Application_Error(object sender, EventArgs e)
	{
	}

	protected void Session_End(object sender, EventArgs e)
	{
		Application.Lock();
		Application["online"] = Convert.ToInt32(Application["online"]) - 1;
		Application.UnLock();
	}

	protected void Application_End(object sender, EventArgs e)
	{
		SaveTotalToFile("c:\\total.txt", Convert.ToInt32(Application["total"]));
	}

	private void SaveTotalToFile(string filePath, int total)
	{
		StreamWriter writer = new StreamWriter(filePath);
		writer.WriteLine(total);
		writer.Close();
	}

	private int LoadTotalFromFile(string filePath)
	{
		StreamReader reader = new StreamReader(filePath);
		int total = Convert.ToInt32(reader.ReadLine());
		reader.Close();

		return total;
	}

</script>
