<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GouWuChe.aspx.cs" Inherits="ShopProject.index.GouWuChe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" type="text/css" href="../css/gouwu.css" />
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
            
            
            <div id="main">
               <div id="main-top" align="center">     
               
               <font style="font-size: 30px; color:Blue; font-weight:bold ">购物车!<asp:Label ID="Label1"
                   runat="server" Text="<a href=shopshow.aspx>继续购物</a>"></asp:Label></font>
               
               </div>
               <div id="main-content" align="center">
                   <asp:Panel ID="Panel1" runat="server" Height="93px">
                          <font style="font-size: 30px; ">无购物清单!<a href="shopshow.aspx">继续购物</a></font>
                         
                   </asp:Panel>
                   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                       Width="725px" onrowdeleting="GridView1_RowDeleting" >
                       <Columns>
                           <asp:TemplateField>
                           <HeaderTemplate>
                               <asp:CheckBox ID="CheckBox1" runat="server" />
                           </HeaderTemplate>
                           <ItemTemplate>
                               <asp:CheckBox ID="CheckBox2" runat="server" />
                           </ItemTemplate>
                           
                           </asp:TemplateField>
                           <asp:BoundField DataField="shopid" HeaderText="商品ID" />
                           <asp:BoundField DataField="shname" HeaderText="商品名字" />
                            <asp:TemplateField HeaderText="数量">
                           
                           <ItemTemplate>
                               <asp:Button ID="Button1" runat="server" Text="-" OnClick="jian"/> 
                               <asp:TextBox ID="TextBox1" runat="server" Text='<%#Eval("num")%>' Width="25px" ReadOnly="true"></asp:TextBox>
                               <asp:Button ID="Button2" runat="server" Text="+" OnClick="add"/>
                           </ItemTemplate>
                           
                           </asp:TemplateField>
                           
                           <asp:BoundField DataField="price" HeaderText="商品单价(元)" />
             
                           <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                       
                       
                       
                       </Columns>
                      
                   </asp:GridView>

               </div>
               <div id="mon" >
                   总价：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
               </div>
               
               <div id="main-bottom" align="center">
               
                   <asp:ImageButton ID="ImageButton1"   runat="server" 
                       ImageUrl="../images/shop/proceed.gif" onclick="ImageButton1_Click"/>
               
               </div>
            
            
            
            </div>
         
    
      </div>
    </form>
</body>
</html>
