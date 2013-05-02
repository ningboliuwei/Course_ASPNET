<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ShopProject.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
       <div id="contan">
        <div id="top">
           <a href="#"><img src="images/top/logo4.jpg" alt="品书网" title="品书网" height="100px"/></a> 
        </div>
        
        <div id="main">

            <div id="main1">
                <div id="login_me">
                     <div id="login_top">
                       <a id="con" href="/index/UserReg.aspx">立即注册</a>还不是品书用户吗？
                     </div>
                    <div id="username">
                      <label>用户名</label>
                      <span class="login_input">
                          <asp:TextBox ID="Usernametext" runat="server" Width="232px" Height="24px"></asp:TextBox></span><asp:Label
                              ID="Label1" runat="server" Text=""></asp:Label>
                    </div>
                    <div id="password">
                      <label>密码</label>
                      <span class="login_input">
                          <asp:TextBox ID="Passwordtext" runat="server" Width="232px" 
                            TextMode="Password" Height="24px"></asp:TextBox></span>
                    </div>
                    <div id="check">
                    
                        <asp:CheckBox ID="CheckBox1" runat="server" CssClass="checkbox" Text="记住我" /> &nbsp;&nbsp;&nbsp;<asp:DropDownList
                            ID="DropDownList1" runat="server">
                            <asp:ListItem>保存5天</asp:ListItem>
                            <asp:ListItem>保存10天</asp:ListItem>
                            <asp:ListItem>保存1个月</asp:ListItem>
                            <asp:ListItem>保存一年</asp:ListItem>
                        </asp:DropDownList>
                    
                    </div>
                    <div id="denglu" align="center">
                    
                        <asp:Button ID="Button1" runat="server" Text="登录" onclick="Button1_Click1" CssClass="button1"/>
                    
                    </div>
                
                
                
                </div>
            
            </div>
        
        </div>
        
      <div id="bottom"></div>
    
    </div>   


</asp:Content>
