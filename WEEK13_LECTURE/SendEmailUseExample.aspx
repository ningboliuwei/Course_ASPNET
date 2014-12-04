<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SendEmailUseExample.aspx.cs" Inherits="SendEmailUseExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<p>收件人：<asp:TextBox runat="server" ID="txtTo"></asp:TextBox></p>
			<p>邮件标题：<asp:TextBox runat="server" ID="txtSubject"></asp:TextBox></p>
			<p>邮件正文：<asp:TextBox runat="server" ID="txtBody" TextMode="MultiLine"  Width="200px" Height="100px"></asp:TextBox></p>
			<p>发件人：<asp:TextBox runat="server" ID="txtFrom"></asp:TextBox></p>
			<p>附件地址：<asp:TextBox runat="server" ID="txtAttachment"></asp:TextBox></p>
			<p>SMTP服务器地址：<asp:TextBox runat="server" ID="txtSMTP"></asp:TextBox></p>
			<p>密码：<asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox></p>
			<asp:Button runat="server" ID="btnSendEmail" Text="发送" OnClick="btnSendEmail_Click" />
		</div>
	</form>
</body>
</html>
