<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CookieUseExample_Login.aspx.cs" Inherits="CookieUseExample_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
             用户名：<asp:TextBox runat="server" ID="txtUserName"></asp:TextBox></p>
                <p>密码：<asp:TextBox runat="server" ID="txtPassword"></asp:TextBox></p>
                <p><asp:CheckBox runat="server" ID="chkRememberPassword" Text="记住密码"/> &nbsp;
                    <asp:DropDownList ID="dplSaveTime" runat="server">
                        <asp:ListItem>保存一天</asp:ListItem>
                        <asp:ListItem>保存一月</asp:ListItem>
                        <asp:ListItem>保存一年</asp:ListItem>
                    </asp:DropDownList>
                
                </p>
                <p><asp:Button runat="server" ID="btnLogin" Text="登录" onclick="btnLogin_Click" />
                </p>
    
            </div>
    </form>
</body>
</html>
