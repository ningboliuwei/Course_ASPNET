<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginControlExample_Login.aspx.cs" Inherits="LoginControlExample_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    	<asp:Login ID="Login1" runat="server" OnLoggedIn="Login1_LoggedIn" CreateUserText="注册" CreateUserUrl="~/LoginControlExample_CreateUser.aspx" DestinationPageUrl="~/LoginControlExample_Home.aspx">
		</asp:Login>
    <div>
    
    </div>
    </form>
</body>
</html>
