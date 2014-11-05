<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SqlCommandExample.aspx.cs" Inherits="SqlCommandExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCommand" runat="server" Width="400px" Height="300px" TextMode="MultiLine"></asp:TextBox>&nbsp;
                <asp:Button ID="btnExecute" runat="server" Text="执行" OnClick="btnExecute_Click" />
        </div>
    </form>
</body>
</html>
