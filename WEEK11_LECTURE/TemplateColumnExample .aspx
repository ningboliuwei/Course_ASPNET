<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TemplateColumnExample .aspx.cs" Inherits="TemplateColumnExample" %>

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
				AutoGenerateColumns="False" EnableModelValidation="True" OnSelectedIndexChanged="gridStudent_SelectedIndexChanged">
				<Columns>
					<asp:BoundField HeaderText="序号" />
					<asp:BoundField DataField="StudentID" HeaderText="学号" />
					<asp:BoundField DataField="Name" HeaderText="姓名" />
					    <asp:TemplateField HeaderText="性别" >
									 <ItemTemplate>
										 <asp:DropDownList ID="drpGender" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Gender") %>'>
											 <asp:ListItem>男</asp:ListItem>
											 <asp:ListItem>女</asp:ListItem>
										 </asp:DropDownList>
									 </ItemTemplate>
								 </asp:TemplateField>
					<asp:BoundField DataField="DepartmentName" HeaderText="系" />
					<asp:CommandField ButtonType="Button" ShowSelectButton="True" />
				</Columns>
			</asp:GridView>
		</div>
	</form>
</body>
</html>
