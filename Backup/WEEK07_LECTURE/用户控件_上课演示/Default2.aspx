<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="用户控件_上课演示.Default2" %>

<%@ Register src="Header.ascx" tagname="Header" tagprefix="uc1" %>
<%@ Register src="SideBar.ascx" tagname="SideBar" tagprefix="uc2" %>

<%@ Register src="Footer.ascx" tagname="Footer" tagprefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>无标题页</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <table width="780px" border="3">
                    <tr>
                        <td colspan="2">
                            <uc1:Header ID="Header1" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <uc2:SideBar ID="SideBar1" runat="server" />
                        </td>
                        <td > <a href="Default3.aspx">default3.aspx</a></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <uc3:Footer ID="Footer1" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </body>
</html>