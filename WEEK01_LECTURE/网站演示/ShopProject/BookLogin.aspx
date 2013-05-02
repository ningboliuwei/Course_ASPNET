<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookLogin.aspx.cs" Inherits="ShopProject.BookLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" type="text/css" href="css/login1.css" />
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

                    <li><a href="BookLogin.aspx">

                      <h3>网站首页</h3>

                      </a></li>

                    <li><a href="/index/shopshow.aspx">

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
                    
                    <asp:Button ID="Button1" runat="server" Text="搜索" Height="25px" Width="71px" 
                        CssClass="button" onclick="Button1_Click" /></div> 
                        
             
                    
              </div>
                
            </div>
            <div id="main-content">
                <div id="main-content-left">
                  <object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" codebase="http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=9,0,28,0" width="770px" height="190px" title="time">
                    <param name="movie" value="flash/time.swf" />
                    <param name="quality" value="high" />
                    <param name="wmode" value="opaque" />
                    <embed src="flash/time.swf" quality="high" wmode="opaque" pluginspage="http://www.adobe.com/shockwave/download/download.cgi?P1_Prod_Version=ShockwaveFlash" type="application/x-shockwave-flash" width="776px" height="200px"></embed>
                  </object>
              </div>
                <div id="main-content-right">
                    <asp:Panel ID="Panel2" runat="server" BackColor="White" Height="194px">
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <font style="font-size: 18px;color:Black; font-weight:bold">&nbsp;&nbsp;&nbsp;欢迎你,</font> 
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        
                        <br />
                         <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<a href="Back/commen/commain.aspx">个人中心</a>]&nbsp;[<asp:LinkButton
                            ID="LinkButton5" runat="server" onclick="LinkButton5_Click">退出</asp:LinkButton>]
                    </asp:Panel>
                
                
                <asp:Panel ID="Panel1" runat="server" Height="195px">
                 <div id="log">
                        <a href="/index/UserReg.aspx"><img src="images/shop/zhuce.jpg"/></a>
                        <a href="Login.aspx"><img src="images/shop/login.jpg"/></a>
                    </div>
                    <div id="logimg">
     
                        
     
                     <img src="images/shop/img.jpg" width="200px"/>
                    </div>
                
                        </asp:Panel>
                   
                    
                
                </div>
            </div> 
            
            <div id="main-list">
               <div id="main-list-top">
               <h2>新书快递</h2>
                <div id="gouwu"><asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/shop/1.jpg"  OnClick="chakan"/></div>
               </div>
               <div id="main-list-main">
               
                   <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" 
                       RepeatDirection="Horizontal">
                   <ItemTemplate>
                        <table >
                          <tr><td><img src="/Bookimages/<%#Eval("shoppicture")%>" width="100px" height="130px"/></td></tr>
                          <tr><td><a href="/index/shopInfo.aspx?id=<%#Eval("shopid")%>"><%#Eval("shname")%></td></tr>
                          <tr><td><%#Eval("remark")%></td></tr>
                          <tr><td><img src="images/shop/fu.jpg"/><%#Eval("price")%></td></tr>
                        </table>
                    </ItemTemplate>
                   </asp:DataList>

               </div>
               <div id="fengye">
                  <div class="pagination" align="right">
                                 共<asp:Label ID="Label1" runat="server" Text=""></asp:Label>页&nbsp;&nbsp;当前第<asp:Label
                                     ID="Label2" runat="server" Text="1"></asp:Label>页
 
              &laquo; <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">首页</asp:LinkButton>&nbsp;&nbsp;&lt;
                      <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">前一页</asp:LinkButton>&nbsp;&nbsp;
                      <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">下一页</asp:LinkButton> &gt;&nbsp;&nbsp; 
                      <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">尾页</asp:LinkButton> &raquo;

				</div> 
               </div>
            
            </div>
            
        </div>
        <div id="bottom1">
        @2011-2012 copyright 潘骁超
        </div>
        
        
    </form>
</body>
</html>
