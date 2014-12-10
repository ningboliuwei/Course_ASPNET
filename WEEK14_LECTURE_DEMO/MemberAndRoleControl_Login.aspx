<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberAndRoleControl_Login.aspx.cs" Inherits="MemberAndRoleControl_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <p>
            用户名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></p>
        <p>
            密 &nbsp;&nbsp; 码：<asp:TextBox ID="txtPwd" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_OnClick" Text="登录" />&nbsp;</p>
        <p>
    </div>
    </form>
</body>
</html>
