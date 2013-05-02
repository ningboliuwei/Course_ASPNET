<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="用户控件_用户登录.ucLogin" %>
<div>
    <table width="300px" border="0" bgcolor="lightblue" runat="server" id="tableLogin">
        <tr>
            <th colspan="2">
                <asp:Label runat="server" ID="lblTitle"></asp:Label>
            </th>
        </tr>
        <tr>
            <td>
                用户名：
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                密码：
            </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button runat="server" ID="btnOK" Text="登录" onclick="btnOK_Click" />
                &nbsp;&nbsp;<asp:Button runat="server" ID="btnReset" Text="重置" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label runat="server" ID="lblInfo"></asp:Label>
            </td>
        </tr>
    </table>
</div>