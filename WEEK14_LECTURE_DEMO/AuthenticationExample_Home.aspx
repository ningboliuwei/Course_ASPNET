﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AuthenticationExample_Home.aspx.cs" Inherits="AuthenticationExample_Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:Button runat="server"  ID="btnLogout" Text="注销" OnClick="btnLogout_Click"/>
    </div>
    </form>
</body>
</html>
