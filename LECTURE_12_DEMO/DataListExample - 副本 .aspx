<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataListExample - 副本 .aspx.cs" Inherits="DataListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>

			<asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal" OnItemCommand="DataList1_ItemCommand" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
				<ItemTemplate>
					
					<table border="1px" width="200px">
						<tr>
							<td>商品编号</td>
							<td>
								<asp:Label ID="lblID" runat="server" Text='<%# Eval("ItemID") %>'></asp:Label></td>
							<td rowspan="3"><asp:Image  Width="50px" ID="imgPhoto" runat="server" ImageUrl='<%# "images/" + Eval("Image") %>' /></td>
						</tr>
						<tr>
							<td>名称</td>
							<td>
								<asp:Label ID="lblName" runat="server" Text='<%# Eval("Title") %>'></asp:Label></td>
							</td>
						
						</tr>
						<tr>
							<td>价格</td>
							<td>
								<asp:Label ID="lblPrice" runat="server" Text='<%# Eval("Price") %>'></asp:Label></td>
							</td>
							
						</tr>
						<tr><td colspan="3">
							<asp:Button ID="Button1" runat="server" Text="选择" CommandName="s" CommandArgument='<%# Eval("ItemID") %>'/>
							<asp:Button ID="Button2" runat="server" Text="编辑" CommandName="e" />
							<asp:Button ID="Button3" runat="server" Text="删除" CommandName="d" />
							<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="AddToCart.png"  CommandName="AddToCart" CommandArgument='<%# Eval("ItemID") %>'/>
							</td>
						</tr>
					</table>
				</ItemTemplate>
			</asp:DataList>
			<asp:TextBox runat="server" ID="txtQuantity"></asp:TextBox>

		</div>
	</form>
</body>
</html>
