<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SessionUseExample_Welcome.aspx.cs" Inherits="SessionUseExample_Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<asp:Label runat="server" ID="lblInfo"></asp:Label><br/>
		<asp:Button runat="server" ID="btnLogout" Text="注销" OnClick="btnLogout_Click" />
	</div>
	</form>
</body>
</html>
