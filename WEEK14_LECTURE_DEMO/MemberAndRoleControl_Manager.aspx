<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberAndRoleControl_Manager.aspx.cs" Inherits="MemberAndRoleControl_Manager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<p>
				用户名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
				&nbsp;密码：<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>&nbsp;电子邮件：<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnCreateUser" runat="server" Text="创建用户" OnClick="btnCreateUser_Click" />
			</p>

			<p>用户名：<asp:TextBox ID="txtUserNameToDelete" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnDeleteUser" runat="server" Text="删除指定用户" OnClick="btnDeleteUser_OnClick" /></p>
			<p>角色名：<asp:TextBox ID="txtRoleName" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnCreateRole" runat="server" Text="创建角色" OnClick="btnCreateRole_OnClick" /></p>
			<p>角色名：<asp:TextBox ID="txtRoleNameToDelete" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnDeleteRole" runat="server" Text="删除指定角色" OnClick="btnDeleteRole_OnClick" /></p>
			<p>用户名：<asp:TextBox ID="txtAddUserToRoleUserName" runat="server"></asp:TextBox>&nbsp;角色名：<asp:TextBox ID="txtAddUserToRoleRoleName" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnAddUserToRole" runat="server" Text="将用户加入角色" OnClick="btnAddUserToRole_OnClick" /></p>
			<p>角色名：<asp:TextBox ID="txtRoleNameForUserDisplay" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnDisplayUsersInRole" runat="server" Text="显示角色中所有用户" OnClick="btnDisplayUsersInRole_OnClick" /></p>
			<p>用户名：<asp:TextBox ID="txtRemoveUserFromRoleUserName" runat="server"></asp:TextBox>&nbsp;角色名：<asp:TextBox ID="txtRemoveUserFromRoleRoleName" runat="server"></asp:TextBox>&nbsp;<asp:Button ID="btnRemoveUserFromRole" runat="server" Text="将用户从角色中移除" OnClick="btnRemoveUserFromRole_OnClick"/></p>

		</div>
	</form>
</body>
</html>
