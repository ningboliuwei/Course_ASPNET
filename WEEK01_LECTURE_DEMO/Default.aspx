<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	账号：<asp:TextBox ID="txtAccount" runat="server"></asp:TextBox>
		<br />
		昵称：<asp:TextBox ID="txtNickname" runat="server"></asp:TextBox>
		<br />
		电子邮件地址：<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
		<br />
		<asp:Button ID="btnRegister" runat="server" onclick="btnRegister_Click" 
			Text="注册" />
    
    </div>
    </form>
</body>
</html>
