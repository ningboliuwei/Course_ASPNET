<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewBasickExample.aspx.cs" Inherits="GridViewBasickExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
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
					<asp:BoundField DataField="Name" HeaderText="姓名" />	
					<asp:BoundField DataField="Gender" HeaderText="性别" />
					<asp:BoundField DataField="DepartmentName" HeaderText="系" />
				</Columns>
			</asp:GridView>
		</div>
    	<br />
		<asp:GridView ID="GridView1" runat="server">
		</asp:GridView>
    </form>
</body>
</html>
