<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AuthenticationExample_Login.aspx.cs" Inherits="AuthenticationExample_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <h3> 登录网站</h3>
       <hr />
        <p>
            <em>说明：测试用户名为“test”，密码为“1234”。</em></p>
            <hr />
        <p>
            用户名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></p>
        <p>
            密 &nbsp;&nbsp; 码：<asp:TextBox ID="txtPwd" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="登录" />&nbsp;</p>
        <p>
            <asp:Label ID="lblInfo" runat="server"></asp:Label>&nbsp;</p>
       
       
    
    </div>
    </form>
</body>
</html>
