<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="用户控件_用户登录._Default" %>

<%@ Register Src="ucLogin.ascx" TagName="ucLogin" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>无标题页</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
            </div>
            <uc1:ucLogin ID="ucLogin1" runat="server" Width="300" Title="hello" BackgroundColor="pink" />
            <uc1:ucLogin ID="ucLogin2" runat="server" />
            <asp:Button runat="server" ID="btnLogin" Text="登录" OnClick="btnLogin_Click" />
    
        </form>
    </body>
</html>