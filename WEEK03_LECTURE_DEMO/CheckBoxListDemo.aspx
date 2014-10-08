<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxListDemo.aspx.cs" Inherits="WEEK03_LECTURE_DEMO.CheckBoxListDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="54px" DataSourceID="" 
            RepeatColumns="3">
            <asp:ListItem>唱歌</asp:ListItem>
            <asp:ListItem>跳舞</asp:ListItem>
            <asp:ListItem>游泳</asp:ListItem>
            <asp:ListItem>打球</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    <asp:CheckBoxList ID="CheckBoxList2" runat="server" AutoPostBack="True" 
        onselectedindexchanged="CheckBoxList2_SelectedIndexChanged">
    </asp:CheckBoxList>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
