<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Common.aspx.cs" Inherits="Common" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" 
            ToolTip="按钮" />
        <span lang="zh-cn">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </span>
      
        <span lang="zh-cn">&nbsp;<asp:TextBox ID="TextBox1" runat="server" 
            Height="39px" ontextchanged="TextBox1_TextChanged" TextMode="Password"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
        <asp:Button ID="Button3" runat="server" Text="Button" />
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="button.png" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="50pt" Text="Label"></asp:Label>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="足球" AutoPostBack="True" 
            oncheckedchanged="CheckBox1_CheckedChanged" />
        <br />
        <asp:CheckBox ID="CheckBox2" runat="server" Text="篮球"/>
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="游泳"/>
        <br />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
<asp:DropDownList ID="DropDownList1" runat="server">
    <ASP:ListItem Text="李勇" Value="95001"></ASP:ListItem>
    <ASP:ListItem Text="刘晨" Value="95002"></ASP:ListItem>
    <ASP:ListItem Text="王敏" Value="95003"></ASP:ListItem>
    <ASP:ListItem Text="张立" Value="95004"></ASP:ListItem>
</asp:DropDownList>
        <br />
        </span>
    
    </div>
    </form>
</body>
</html>
