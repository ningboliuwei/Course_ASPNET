<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationGroupExample.aspx.cs"
    Inherits="ValidationGroupExample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="200px" border="1">
            <tr>
                <td>用户名
                </td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <td>
                </td>
            </tr>
            <tr>
                <td>密码
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
                <td>
                </td>
            </tr>
        </table>
        
         <table width="200px" border="1">
            <tr>
                <td>用户名
                </td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <td>
                </td>
            </tr>
            <tr>
                <td>密码
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Button" />
                </td>
                <td>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
