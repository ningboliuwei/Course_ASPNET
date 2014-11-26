<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowCart.aspx.cs" Inherits="ShowCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView runat="server" ID="gdvCart" ShowFooter="True">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
