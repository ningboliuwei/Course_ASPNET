<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="用户控件_上课演示.ucLogin" %>
<table width="300px" bgcolor="lightpink" runat="server" ID="tableLogin">
    <tr>
        <td colspan="2">
            <asp:Label ID="lblTitle" runat="server" Text="用户登录"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            用户名：
        </td>
        <td>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            密码：
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="btnLogin" runat="server" Text="登录" onclick="btnLogin_Click" />
            <asp:Button ID="btnReset" runat="server" Text="重置" />
        </td>
    </tr>
</table>