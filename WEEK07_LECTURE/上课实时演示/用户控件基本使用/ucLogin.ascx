<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="用户控件基本使用.ucLogin" %>


<table width="200px" bgcolor="pink" runat="server" id="table1">
    <tr>
        <td colspan="2" align="center">
            <asp:Label ID="lblTitle" runat="server" Text="登录"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            账号：</td>
        <td>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            密码</td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan="2" align="center">
            <br/><asp:Button ID="btnLogin" runat="server" Text="登录" 
                onclick="btnLogin_Click" /> <asp:Button ID="btnRest" runat="server" Text="重置" /></td>
       
    </tr>
</table>

<br/>



