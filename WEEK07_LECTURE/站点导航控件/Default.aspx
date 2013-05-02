<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="站点导航控件._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>无标题页</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <p>
                    <asp:SiteMapPath ID="SiteMapPath1" runat="server">
                    </asp:SiteMapPath>
                </p>
                欢迎主界面
                <a href="Admin/AdminCenter.aspx">AdminCenter.aspx</a>
            </div>
        </form>
    </body>
</html>