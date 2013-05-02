<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Pwd.aspx.cs" Inherits="Admin_Admin_Pwd" %>
<%@ Register TagPrefix="uc1" TagName="menu_right" Src="~/Admin/menu_right.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="../styles/layout.css" rel="stylesheet" type="text/css" />
    <link href="../styles/wysiwyg.css" rel="stylesheet" type="text/css" />
    <!-- Theme Start -->
    <link href="../themes/blue/styles.css" rel="stylesheet" type="text/css" />
</head>
<body id="homepage" style="background-color: Silver">
    <form id="form1" runat="server">
    <div style="float: left">
        <br />
        <uc1:menu_right ID="menu_right1" runat="server" />
        <br />
    </div>
    <div style="height: 77px; width:100%; margin-left: 227px; background-color: Gray">
    </div>
    <div style="margin-left: 228px; margin-top:60px">
        <div id="content" style="margin-left: 150px">

            编号&nbsp;&nbsp; ：&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="输入不能为空！"></asp:RequiredFieldValidator>
            <br />
            <br />
            原密码：&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="输入不能为空！"></asp:RequiredFieldValidator>

            <br />
            <br />
            新密码：&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="输入不能为空！"></asp:RequiredFieldValidator>

            <br />
            <br />
            确认密码： 
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="两次输入的密码不一致！"
                            ControlToCompare="TextBox3" ControlToValidate="TextBox4" Display="Dynamic"></asp:CompareValidator>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="确认修改" onclick="Button1_Click" />

        </div>
    </div>

    
    </form>
</body>
</html>