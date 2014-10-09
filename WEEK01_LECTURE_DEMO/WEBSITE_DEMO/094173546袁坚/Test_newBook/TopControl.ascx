<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TopControl.ascx.cs" Inherits="TopControl" %>
<div id="divtop" height:20px" >
    <div id="divtop_left" style=" float: left;margin-left:50px" >
        <asp:Panel ID="Pnltop" runat="server" HorizontalAlign="Left">
            &nbsp;亲,欢迎您来商城！<a href="<% =HttpContext.Current.Request.ApplicationPath %>/Users/Login.aspx">请登录 </a><a href="<% =HttpContext.Current.Request.ApplicationPath %>/Users/Register.aspx">免费注册 </a>
             <a href="<% =HttpContext.Current.Request.ApplicationPath %>/Admin/AdminLogin.aspx">管理员登录</a>
        </asp:Panel>
    </div>
    <div id="divtop_right" style="float: left">
    <asp:Panel ID="pnlmain" runat="server" HorizontalAlign="Left">
        <asp:Label ID="LoginName" runat="server" Text=""></asp:Label><a href="<% =HttpContext.Current.Request.ApplicationPath %>/Book_Buy.aspx">购物车</a>
        <a href="<% =HttpContext.Current.Request.ApplicationPath %>/Book_Order.aspx">我的订单</a>
         <a href="<% =HttpContext.Current.Request.ApplicationPath %>/Admin/AdminLogin.aspx">管理员登录</a>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="" >个人中心</asp:HyperLink>
    </asp:Panel>
    
    </div>
</div>


