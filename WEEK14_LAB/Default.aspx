<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
		<asp:LoginView ID="LoginView1" runat="server">
			<AnonymousTemplate>
				你好，游客！<br /> 若要使用网站的全部功能，请先<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">登录</asp:HyperLink>
				。
			</AnonymousTemplate>
			<LoggedInTemplate>
				你好，<asp:LoginName ID="LoginName1" runat="server" />
				<asp:LoginStatus ID="LoginStatus1" runat="server" />
			</LoggedInTemplate>
		</asp:LoginView>
   
    </div>
    </form>
</body>
</html>
