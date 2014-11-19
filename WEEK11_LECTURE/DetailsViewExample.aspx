<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetailsViewExample.aspx.cs" Inherits="DetailsViewExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False"
				Height="50px" Width="500px">
				<Fields>
					<asp:BoundField DataField="StudentID" HeaderText="学号" />
					<asp:BoundField DataField="Name" HeaderText="姓名" />
					<asp:BoundField DataField="Gender" HeaderText="性别" />
					<asp:BoundField DataField="DayOfBirth" HeaderText="生日" />
					<asp:BoundField DataField="Address" HeaderText="地址" />
					<asp:BoundField DataField="DepartmentID" HeaderText="系" />
					<asp:ImageField DataImageUrlField="Photo" DataImageUrlFormatString="images/{0}"
						HeaderText="照片">
					</asp:ImageField>
				</Fields>
			</asp:DetailsView>
		</div>
	</form>
</body>
</html>
