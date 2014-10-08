<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminType_add.aspx.cs" Inherits="Admin_AdminType_add" %>
<%@ Register TagPrefix="uc1" TagName="menu_right" Src="~/Admin/menu_right.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
<link href="../styles/layout.css" rel="stylesheet" type="text/css" />
    <!-- Theme Start -->
        <link href="../themes/blue/styles.css" rel="stylesheet" type="text/css" />
    <link href="../styles/wysiwyg.css" rel="stylesheet" type="text/css" />
    <link href="../themes/blue/styles.css" rel="stylesheet" type="text/css" />
</head>
<body id="homepage" style="background-color:Silver">
    <form id="form1" runat="server">
    <div style="float: left">
        
        <uc1:menu_right ID="menu_right1" runat="server" />
        
    </div>
    <div style="height: 77px; width:100%; margin-left: 227px; background-color: Gray">
        
    </div>
    <div style="margin-left: 228px; margin-top: 60px">
        <div id="content" style="margin-left: 150px">
            <div>
            
                类别id&nbsp;&nbsp;&nbsp; ：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                类别信息：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click" />
            
              
            </div>
        </div>
    </div>

    
    </form>
</body>
</html>
