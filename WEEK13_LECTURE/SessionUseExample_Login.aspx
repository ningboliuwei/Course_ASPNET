<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SessionUseExample_Login.aspx.cs" Inherits="SessionUseExample_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			请输入用户名：<asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>&nbsp;<asp:Button runat="server" ID="btnLogin" Text="登录" OnClick="btnLogin_Click" />
		</div>
	</form>
</body>
</html>
