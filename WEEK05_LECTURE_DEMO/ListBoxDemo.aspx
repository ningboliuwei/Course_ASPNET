<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListBoxDemo.aspx.cs" Inherits="ListBoxDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:ListBox ID="ListBox1" runat="server" Height="128px" SelectionMode="Multiple">
            <asp:ListItem Value="95001">ASP.NET程序设计</asp:ListItem>
            <asp:ListItem Value="95002">数据库原理</asp:ListItem>
            <asp:ListItem Value="95003">C语言程序设计</asp:ListItem>
            <asp:ListItem Value="95004">数据结构</asp:ListItem>
            <asp:ListItem Value="95005">操作系统</asp:ListItem>
        </asp:ListBox>
    </div>
    </form>
</body>
</html>
