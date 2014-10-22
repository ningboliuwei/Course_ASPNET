<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HeaderControl.ascx.cs" Inherits="HeaderControl" %>
<div style="border: solid 1px #B5C7DE">
    <div style="text-align: center;">
        <table style="width: 100%;">
            <tr>
                <td style="width: 265px;">
                    <img alt="" src="images/logo.jpg" style="height: 77px; width: 265px;" />
                </td>
                <td style="width: 478px;">
                    <img alt="" src="images/banner.jpg" style="height: 84px; width: 478px;" />
                </td>
                <td style="text-align: center;">
                    设为首页<br />
                    加入收藏<br />
                    网站地图
                </td>
            </tr>
        </table>
    </div>
    <div style="background-color: #B5C7DE; padding: 5px 0px 5px 10px">
	
        <asp:Menu ID="mnuMain" runat="server" BackColor="#B5C7DE" 
                  DataSourceID="xdsMenu" DynamicHorizontalOffset="2" Font-Names="Verdana" 
                  Font-Size="14px" ForeColor="#284E98" Orientation="Horizontal" 
                  StaticSubMenuIndent="10px">
            <StaticSelectedStyle BackColor="#507CD1" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
            <DynamicMenuStyle BackColor="#B5C7DE" />
            <DynamicSelectedStyle BackColor="#507CD1" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DataBindings>
                <asp:MenuItemBinding DataMember="MenuItem" Depth="0" NavigateUrlField="Url" 
                                     TextField="Text" />
                <asp:MenuItemBinding DataMember="MenuItem" Depth="1" NavigateUrlField="Url" 
                                     TextField="Text" />
            </DataBindings>
            <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
        </asp:Menu>
        <asp:XmlDataSource ID="xdsMenu" runat="server" DataFile="~/MenuItems.xml" 
                           XPath="/MenuItems/MenuItem"></asp:XmlDataSource>
	
    </div>
    <div>
        <table style="width: 100%">
            <tr>
                <td>
				
                    <asp:SiteMapPath ID="SiteMapPath1" runat="server">
                    </asp:SiteMapPath>
				
                </td>
                <td style="text-align: center; width: 250px;">
					
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="搜索" />
					
                </td>
            </tr>
        </table>
    </div>
</div>