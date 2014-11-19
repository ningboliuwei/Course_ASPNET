<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PagingExample.aspx.cs" Inherits="PagingExample" %>

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
				AutoGenerateColumns="False" AllowPaging="True" OnPageIndexChanging="gridStudent_PageIndexChanging">
				<Columns>
					<asp:BoundField HeaderText="序号" />
					<asp:BoundField DataField="StudentID" HeaderText="学号" />
					<asp:BoundField DataField="Name" HeaderText="姓名" />
					<asp:BoundField DataField="Gender" HeaderText="性别" />
					<asp:BoundField DataField="DepartmentName" HeaderText="系"
						SortExpression="Department" />
				</Columns>
			</asp:GridView>
		</div>
	</form>
</body>
</html>
