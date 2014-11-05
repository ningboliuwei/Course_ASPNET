<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SqlConnectionExample.aspx.cs" Inherits="SqlConnectionExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="btnConnect" Text="连接数据库" OnClick="btnConnect_Click"/>
        </div>
    </form>
</body>
</html>
