<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SortingExample.aspx.cs" Inherits="SortingExample" %>

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
				AutoGenerateColumns="False" AllowSorting="True"
				OnSorting="gridStudent_Sorting">
				<Columns>
					<asp:BoundField HeaderText="序号" />
					<asp:BoundField DataField="StudentID" HeaderText="学号"
						SortExpression="StudentID" />
					<asp:HyperLinkField DataNavigateUrlFields="StudentID"
						DataNavigateUrlFormatString="StudentDetails.aspx?id={0}" DataTextField="Name"
						HeaderText="姓名" SortExpression="Name" />
					<asp:BoundField DataField="DepartmentName" HeaderText="系"
						SortExpression="DepartmentName" />
				</Columns>
			</asp:GridView>
		</div>
	</form>
</body>
</html>
