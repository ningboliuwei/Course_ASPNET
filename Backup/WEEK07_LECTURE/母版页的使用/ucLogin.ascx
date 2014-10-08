<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLogin.ascx.cs" Inherits="母版页的使用.ucLogin" %>
<asp:Login ID="Login1" runat="server" VisibleWhenLoggedIn="False">
</asp:Login>
<asp:LoginName ID="LoginName1" runat="server" />
<asp:LoginView ID="LoginView1" runat="server">
    <LoggedInTemplate>
        <span lang="zh-cn">logged</span>
    </LoggedInTemplate>
    <AnonymousTemplate>
        <span lang="zh-cn">no</span>
    </AnonymousTemplate>
    
</asp:LoginView>
<asp:LoginStatus ID="LoginStatus1" runat="server" />
<table width="100%" bgcolor="lightpink" runat="server" ID="tableLogin">
    
    
    
    <!--<tr>
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
    </tr>-->
</table>