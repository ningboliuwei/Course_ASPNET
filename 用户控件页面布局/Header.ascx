<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="用户控件页面布局.Header" %>
<img src="Header.png"/><asp:Menu ID="Menu1" runat="server" BackColor="#B5C7DE" 
    DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" 
    ForeColor="#284E98" Orientation="Horizontal" StaticSubMenuIndent="10px" 
    Width="74px">
    <StaticSelectedStyle BackColor="#507CD1" />
    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <DynamicHoverStyle BackColor="#284E98" ForeColor="White" />
    <DynamicMenuStyle BackColor="#B5C7DE" />
    <DynamicSelectedStyle BackColor="#507CD1" />
    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
    <StaticHoverStyle BackColor="#284E98" ForeColor="White" />
    <Items>
        <asp:MenuItem Text="下属学院" Value="下属学院">
            <asp:MenuItem Text="科技学院" Value="科技学院"></asp:MenuItem>
            <asp:MenuItem Text="信息学院" Value="信息学院"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem Text="重要文件" Value="重要文件">
            <asp:MenuItem Text="科研文件" Value="科研文件"></asp:MenuItem>
            <asp:MenuItem Text="教研文件" Value="教研文件"></asp:MenuItem>
        </asp:MenuItem>
        <asp:MenuItem Text="生活服务" Value="生活服务">
            <asp:MenuItem Text="校车路线" Value="校车路线"></asp:MenuItem>
            <asp:MenuItem Text="食堂菜谱" Value="食堂菜谱"></asp:MenuItem>
        </asp:MenuItem>
    </Items>
</asp:Menu>
