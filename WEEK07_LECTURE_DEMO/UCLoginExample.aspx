<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UCLoginExample.aspx.cs" Inherits="UCLoginExample" %>

<%@ Register src="ucLogin.ascx" tagname="ucLogin" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <uc1:ucLogin ID="ucLogin1" runat="server" />
                <asp:Button runat="server" ID="btnLogin" Text="登录" OnClick="btnLogin_Click" />
                <asp:Button ID="btnChangeStyle" runat="server" OnClick="btnChangeStyle_Click" Text="改变风格" />
    
            </div>
        </form>
    </body>
</html>