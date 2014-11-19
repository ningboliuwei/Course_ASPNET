<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HyperLinkAndImageColumnExample.aspx.cs" Inherits="HyperLinkAndImageColumnExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<asp:GridView ID="gridStudent" runat="server" Width="100%"
				AutoGenerateColumns="False" EnableModelValidation="True">
				<Columns>
					<asp:BoundField HeaderText="序号" />
					<asp:BoundField DataField="StudentID" HeaderText="学号" />
					<asp:HyperLinkField DataNavigateUrlFields="StudentID"
						DataNavigateUrlFormatString="DetailsViewExample.aspx?id={0}" DataTextField="Name"
						HeaderText="姓名" />
					<asp:BoundField DataField="Gender" HeaderText="性别" />
					<asp:BoundField DataField="DepartmentName" HeaderText="系" />
					<asp:ImageField HeaderText="照片" DataImageUrlField="Photo" DataImageUrlFormatString="images/{0}">
					</asp:ImageField>
				</Columns>
			</asp:GridView>
		</div>
	</form>
</body>
</html>
