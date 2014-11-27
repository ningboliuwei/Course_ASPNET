<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataListExample.aspx.cs" Inherits="DataListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>
</head>
<body>
	<form id="form1" runat="server" style="border: 1px solid #cccccc ">
		<div>

			<asp:DataList ID="DataList1" runat="server" Width="700px"
				RepeatDirection="Horizontal" RepeatColumns="3" OnDeleteCommand="DataList1_DeleteCommand" OnItemCommand="DataList1_ItemCommand" OnEditCommand="DataList1_EditCommand">
				<ItemTemplate>
					<table style="width: 400px; margin: 20px; padding: 10px;">
						<tr>
							<td>学号：</td>
							<td>
								<asp:Label runat="server" ID="lblStudentID" Text='<%#Eval("StudentID")%>'></asp:Label></td>
							<td rowspan="3">
								<asp:Image runat="server" ID="imgStudent"
									ImageUrl='<%#"images/" + Eval("Photo")%>' /></td>
						</tr>
						<tr>
							<td>姓名：</td>
							<td>
								<asp:Label runat="server" ID="lblStudentName" Text='<%#Eval("Name")%>'></asp:Label></td>
						</tr>
						<tr>
							<td>系：</td>
							<td>
								<asp:Label runat="server" ID="lblDepartment" Text='<%#Eval("DepartmentName")%>'></asp:Label></td>
						</tr>
						<tr>
							<td colspan="3">
								<asp:Button ID="btnDelete" CommandName="delete" CommandArgument runat="server" Text="删除" />&nbsp;<asp:Button ID="btnEdit" CommandName="edit" CommandArgument runat="server" Text="编辑" />
							</td>
						</tr>
					</table>
				</ItemTemplate>
				<AlternatingItemTemplate>
					<table style="width: 400px; margin: 20px; padding: 10px; background-color: #ccc">
						<tr>
							<td>学号：</td>
							<td>
								<asp:Label runat="server" ID="lblStudentID" Text='<%#Eval("StudentID")%>'></asp:Label></td>
							<td rowspan="3">
								<asp:Image runat="server" ID="imgStudent"
									ImageUrl='<%#"images/" + Eval("Photo")%>' /></td>
						</tr>
						<tr>
							<td>姓名：</td>
							<td>
								<asp:Label runat="server" ID="lblStudentName" Text='<%#Eval("Name")%>'></asp:Label></td>
						</tr>
						<tr>
							<td>系：</td>
							<td>
								<asp:Label runat="server" ID="lblDepartment" Text='<%#Eval("DepartmentName")%>'></asp:Label></td>
						</tr>
						<tr>
							<td colspan="3">
								<asp:Button ID="btnDelete" CommandName="delete" CommandArgument='<%#Eval("StudentID")%>' runat="server" Text="删除" />&nbsp;
								<asp:Button ID="btnEdit" CommandName="edit" CommandArgument='<%#Eval("StudentID")%>' runat="server" Text="编辑" />
							</td>
						</tr>
					</table>
				</AlternatingItemTemplate>
				<EditItemTemplate>
					<table style="width: 400px; margin: 20px; padding: 10px;">
						<tr>
							<td>学号：</td>
							<td>
								<asp:TextBox runat="server" ID="txtStudentID" Text='<%#Eval("StudentID")%>' ></asp:TextBox>
							</td>
							<td rowspan="3">
								<asp:Image ID="imgStudent" runat="server" ImageUrl='<%#"images/" + Eval("Photo")%>' />
							</td>
						</tr>
						<tr>
							<td>姓名：</td>
							<td>
								<asp:TextBox runat="server" ID="TextBox1" Text='<%#Eval("Name")%>' ></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td>系：</td>
							<td>
								<asp:TextBox runat="server" ID="TextBox2" Text='<%#Eval("DepartmentName")%>' ></asp:TextBox>
							</td>
						</tr>
						<tr>
							<td colspan="3">
								<asp:Button ID="btnDelete" runat="server" CommandArgument='<%#Eval("StudentID")%>' CommandName="delete" Text="删除" />
								&nbsp;
								<asp:Button ID="btnEdit" runat="server" CommandArgument='<%#Eval("StudentID")%>' CommandName="edit" Text="编辑" />
							</td>
						</tr>
					</table>
				</EditItemTemplate>
			</asp:DataList>

		</div>
	</form>
</body>
</html>
