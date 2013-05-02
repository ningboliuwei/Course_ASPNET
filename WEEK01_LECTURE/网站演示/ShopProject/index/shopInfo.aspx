<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shopInfo.aspx.cs" Inherits="ShopProject.index.shopInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" type="text/css" href="../css/showinfo.css" />
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 118px;
        }
        .style2
        {
            width: 125px;
            font-weight:bold;
        }
        .style3
        {
            width: 191px;
        }
        .style4
        {
            width: 143px;
             font-weight:bold;
        }
    </style>
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
            <div class="nar">
               <div id="font"> <span><a href="../BookLogin.aspx">首页</a>&gt;<a href="shopshow.aspx">最新上架</a>&gt;<asp:Label ID="Label9" runat="server" Text=""></asp:Label></span></div>
               <div id="lo">
                   <asp:Label ID="Label12" runat="server" Text=""></asp:Label></div>
            </div>
            
            <div id="info">
               <div id="info-left">
                   <asp:Image ID="Image1" runat="server" Width="275px" Height="314px"/>
                  
               </div>
               <div id="info-center">
                  <table width="100%" style="margin-top: 40px;">
                     <tr>
                     <td class="style1" ><b><font style="font-size: 20px;">书名</font></b>
                     </td>
                     <td>
                         <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                     </td>
                     </tr>
                     
                     
                     <tr>
                     <td class="style1">价格
                     </td>
                     <td>
                         <img src="../images/shop/fu.jpg"/><asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                     </td>
                     </tr>
                     
                     <tr>
                     <td class="style1">配送方式
                     </td>
                     <td>
                         <asp:RadioButton ID="RadioButton1" runat="server" GroupName="di" Text="平邮" />(<asp:Label
                             ID="Label3" runat="server" Text=""></asp:Label>)
                         <asp:RadioButton ID="RadioButton2" runat="server" GroupName="di" Text="快递" />(<asp:Label
                             ID="Label4" runat="server" Text=""></asp:Label>)
                     </td>
                     </tr>
                     
                     
                     <tr>
                     <td>剩余数量
                     </td>
                     <td>
                         <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                     </td>
                     </tr>
                     
                     <tr>
                     <td>货物状态
                     </td>
                     <td>
                         <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                     </td>
                     </tr>
                     
                     <tr>
                     <td>发票
                     </td>
                     <td>
                         <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                     </td>
                    </tr>
                    
                    <tr>
                     <td>保修
                     </td>
                     <td>
                         <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                     </td>
                    </tr>
                    
                    <tr>
                    <td colspan="2"> 
                        <asp:ImageButton ID="ImageButton1" runat="server" 
                            ImageUrl="../images/shop/add.gif" onclick="ImageButton1_Click"/></td>
                    </tr>
                  
                  </table>
               
               </div>
               
               <div id="info-right">
                  <img src="../images/shop/gutiao.jpg" width="180px" height="320px"/>
               </div>
            
            </div>
            
            
            <div id="jiben">
                <div class="nar"><font style=" color:#c60;  font-size: 20px;margin:5px 0 0 10px;"><b>基本信息</b></font></div>
                <div id="nar-bot">
                    <table width="70%" style="margin: 30px auto;">
                    <tr>
                    <td class="style2">出版社
                    </td>
                    <td class="style3">
                        <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                    </td>
                    <td class="style4">书名
                    </td>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                    </td>
                    </tr>
                    
                    
                    
                    <tr>
                    <td class="style2">语种
                    </td> 
                    <td class="style3">
                        
                        简体中文</td>
                    
                    <td class="style4">开本
                    </td>
                    <td>16
                    </td>
                    </tr>
                    
                    
                    
                    
                    <tr>
                    <td class="style2">条形码
                    </td>
                    <td class="style3">9787509404775
                    </td>
                    
                    <td class="style4">商品尺寸
                    </td>
                    <td>28.6 x 20.4 x 1.8 cm
                    </td>
                    </tr>
                    
                    
                   
                    
                    <tr>
                    <td class="style2">ASIN
                    </td>
                    <td class="style3">B004TETLOO
                    </td>
                    <td class="style4">商品重量
                    </td>
                    <td>569g
                    </td>
                    </tr>
                    
                   
                    
                    </table>
                
                
                
                </div>
            
            
            </div>
    
    </div>
    </form>
</body>
</html>
