<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListViewExample.aspx.cs" Inherits="ListViewExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>无标题页</title>
        <style>
        	.price
        	{
        		color: #ff0000;
        		font-size: 14px;
        		font-weight: bold;
        	}

            .itemImage {
                width: 100%;
            }
            
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
            <asp:ListView runat="server" ID="lvwItems" GroupItemCount="3" GroupPlaceholderID="groupPlaceholder" OnItemCommand="lvwItems_ItemCommand">
                <LayoutTemplate>
                    <table style="width: 700px; text-align: center; font-size: 12px;">
                        <asp:PlaceHolder runat="server" ID="groupPlaceholder" />
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <td>
                        <p>
                            <asp:Image runat="server" ID="imgItem" ImageUrl='<%#"images/" + Eval("Image")%>' CssClass="itemImage"/></p>
                        <p>
                            <asp:Label ID="lblTitle" runat="server" Text='<%#Eval("Title")%>' /></p>
                        <p>
                            <asp:Label  ID="lblPrice" CssClass="price" runat="server" Text='<%#"$" + Eval("Price")%>'/></p>
                        <p>
                            <asp:Button runat="server" ID="btnBuy" CommandName="AddToCart" CommandArgument='<%#Eval("ItemID")%>' Text="添加到购物车" />&nbsp;<asp:Button runat="server"
                                                                                                 ID="btnFollow" Text="关注" />&nbsp;<asp:Button runat="server" ID="btnCompare" Text="对比" /></p>
                    </td>
                </ItemTemplate>
                <GroupTemplate>
                    <tr>
                        <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
                    </tr>
                </GroupTemplate>
            </asp:ListView>
            <a href="ShowCart.aspx">显示购物车</a>
            <asp:TextBox runat="server" ID="txtCount"></asp:TextBox>
            
        </form>
    </body>
</html>