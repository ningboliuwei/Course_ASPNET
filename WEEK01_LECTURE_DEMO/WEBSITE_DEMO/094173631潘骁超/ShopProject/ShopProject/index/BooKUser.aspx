<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BooKUser.aspx.cs" Inherits="ShopProject.index.BooKUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
 <link rel="stylesheet" type="text/css" href="../css/login1.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="site">
            <div id="top"></div>
            <div id="menu">
              <div class="menul">
                <div class="menur">
                  <ul>
                    <li><a href="../BookLogin.aspx">
                      <h3>网站首页</h3>
                      </a></li>
                    <li><a href="">
                      <h3>最新上架</h3>
                      </a></li>
                    <li><a href="">
                      <h3>热销排行</h3>
                      </a></li>
                    <li><a href="">
                      <h3>特价图书</h3>
                      </a></li>
                    <li><a href="">
                      <h3>进口图书</h3>
                      </a></li>
		            <li><a href="">
                      <h3>在线订购</h3>
                      </a></li>
		             <li><a href="">
                      <h3>服务中心</h3>
                      </a></li>
                    <li class="last"><a href="">
                      <h3>联系我们</h3>
                      </a></li>		  
                  </ul>
                </div>
              </div>
            </div> 
            <div id="sou">
              <div id="sou-con">
                 <div id="sou-input">
                   <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="450px"></asp:TextBox>
                </div>
                <div id="sou-button">
                    <asp:Button ID="Button1" runat="server" Text="搜索" Height="25px" Width="71px" CssClass="button" /></div>  
              </div>
                
            </div>
            <div id="main-content">
                <div id="main-content-left"></div>
                <div id="main-content-right">
                    <div id="user">
                        <div id="images">
                           <img src="../images/shop/login.gif" width="90px"/>
                        </div> 
                        <div id="xinxi">
                             <p style="color: black; height:20px; font-size:14px;">您好</p>
                             
                        </div>  
                        
                        <div id="bot"> 
                            
                            <div id="bot-bot"><a href="#" style="color: black; height:20px; font-size:14px;">进入个人中心</a></div>
                        </div>
                    </div>                    
                
                </div>
            </div> 
            
            <div id="main-list">
               <div id="main-list-top">
               <h2>新书快递</h2>
               </div>
               <div id="main-list-main"></div>
            
            </div>
        </div>
        
    </form>
</body>
</html>
