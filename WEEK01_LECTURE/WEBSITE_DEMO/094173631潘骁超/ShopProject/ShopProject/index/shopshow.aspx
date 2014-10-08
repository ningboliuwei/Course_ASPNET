<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shopshow.aspx.cs" Inherits="ShopProject.index.shopshow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" type="text/css" href="../css/show.css" />
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
                    <li><a href="shopshow.aspx">
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
            <div id="showlist">
                 <div id="showlist-left">
                   <img src="../images/shop/left.jpg"/>
                 </div>
                 
                 
                 <div id="showlist-right">
                    
                     <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                          <table >
                              <tr ><td rowspan="4" width="120px"><img src="/Bookimages/<%#Eval("shoppicture")%>" width="100px"/></td></tr>
                              
                              <tr>
                              <td width="150px"><a href="shopInfo.aspx?id=<%#Eval("shopid")%>"><%#Eval("shname")%></a>
                              </td>
                              <td>
                                  <asp:TextBox ID="TextBox2" runat="server" Visible="false" Text='<%#Eval("shopid")%>'></asp:TextBox>
                                 <asp:ImageButton ID="ImageButton1" runat="server" CommandName="gouwuche" ImageUrl="../images/shop/guowu.jpg" Width="130px" Height="35px" OnClick="gouwu"/>
                                 
                                 
                              
                              </td>
                              </tr>
                              
                              <tr>
                              <td align="left" width="120px"><%#Eval("remark")%></td>
                              <td></td>
                              </tr>
                              
                              
                              <tr>
                              <td align="left" width="120px"><img src="../images/shop/fu.jpg"/><%#Eval("price")%></td>
                              <td> <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="../images/shop/1.jpg" Width="90px" Height="30px" OnClick="chakan"/></td>
                              </tr>
                              
                          </table>
                       </ItemTemplate>
                     </asp:DataList>
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
                 <div id="sort">
                    <div id="sort-top">按类别搜索</div>
                    <div id="sort-bottom">
                        
                        <div id="dong">&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="27px" 
                                Width="122px">
                        </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="搜索" Height="32px" Width="58px" 
                                onclick="Button2_Click" /></div>
                    
                        
                    </div>
                 
                 </div>
            
            
            </div>
            
            
       </div>
    </form>
</body>
</html>
