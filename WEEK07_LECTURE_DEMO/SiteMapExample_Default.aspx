<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SiteMapExample_Default.aspx.cs" Inherits="SiteMapExample" %>

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
                    <asp:SiteMapPath ID="SiteMapPath1" runat="server">
                    </asp:SiteMapPath>
                </p>
                欢迎主界面
                <a href="Admin/SiteMapExample_AdminCenter.aspx">AdminCenter.aspx</a>
            </div>
        </form>
    </body>
</html>