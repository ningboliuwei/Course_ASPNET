<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownListDemo.aspx.cs" Inherits="WEEK05_LECTURE_DEMO_DropDownListDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label><br/>
        <!--直接在页面代码中添加选项 以下代码应放入<asp:DropDownList></asp:DropDownList>标签之间-->
            <!--<asp:ListItem Value="95001">ASP.NET程序设计</asp:ListItem>
            <asp:ListItem Value="95002">数据库原理</asp:ListItem>
            <asp:ListItem Value="95003">C语言程序设计</asp:ListItem>
            <asp:ListItem Value="95004">数据结构</asp:ListItem>
            <asp:ListItem Value="95005">操作系统</asp:ListItem>-->
        <asp:DropDownList ID="DropDownList1" runat="server">
            
        </asp:DropDownList>
        <br />
        <asp:Button ID="btnDisplay" runat="server" Text="显示" 
            onclick="btnDisplay_Click" />
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="清空" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="添加" />
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="删除" />
    
    </div>
    </form>
</body>
</html>