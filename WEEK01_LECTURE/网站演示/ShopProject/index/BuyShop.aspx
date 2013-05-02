<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BuyShop.aspx.cs" Inherits="ShopProject.index.BuyShop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" type="text/css" href="../css/buyshop.css" />
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 174px;
            font-weight: bold;
             border-right:1px solid gray;
             border-bottom:1px solid gray;
        }
        .style2
        {
            height: 62px;
             font-weight: bold;
             font-size:20px;
             border-bottom:1px solid gray;
        }
        .style3
        {
            width: 174px;
            font-weight: bold;
            border-right: 1px solid gray;
            border-bottom: 1px solid gray;
            height: 70px;
        }
        .style4
        {
            height: 70px;
            width: 178px;
        }
        .style5
        {
            width: 174px;
            font-weight: bold;
            border-right: 1px solid gray;
            border-bottom: 1px solid gray;
            height: 64px;
        }
        .style6
        {
            height: 64px;
            width: 178px;
        }
        .style7
        {
            width: 174px;
            font-weight: bold;
            border-right: 1px solid gray;
            border-bottom: 1px solid gray;
            height: 61px;
        }
        .style8
        {
            height: 61px;
            width: 178px;
        }
        .style9
        {
            width: 174px;
            font-weight: bold;
            border-right: 1px solid gray;
            border-top: 1px solid gray;
            border-bottom: 1px solid gray;
            height: 54px;
        }
        .button1:hover
        {
        	cursor:pointer;
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
            
            
            <div id="main">
                <div id="main-left"><img src="../images/shop/left.jpg"/></div>
                <div id="main-center">
                    <table width="100%" style="margin: 0px 0 0 0; border:1px solid gray;">
                    <tr>
                    <td colspan="3" class="style2" >商品信息
                    </td>
                    </tr>
                    
 
                    <tr>
                    <td class="style7">商品名字
                    </td>
                    <td class="style8">
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                    <td rowspan="3">
                        <asp:Image ID="Image1" runat="server" Width="183px" Height="189px"/>
                    </td>
                    </tr>
                    
                    <tr>
                    <td class="style5">商品价格
                    </td>
                    <td class="style6">
                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </td>
                    
                    </tr>
                    
                    
                    <tr>
                    <td class="style3">配送方式
                    </td>
                    <td class="style4">
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                    </td>
                    
                    </tr>
                                     
                    </table>
  
                    
                    <table width="100%" style="margin: 50px 0 0 0; border:1px solid gray;">
                    <tr>
                    <td colspan="2" class="style2" >生成订单
                    </td>
                    </tr>
                    
 
                    <tr>
                    <td class="style1">收货人姓名
                    </td>
                    <td>
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                    
                    <tr>
                    <td class="style1">收获地址
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                    
                    
                    <tr>
                    <td class="style1">邮政编码
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                    
                    
                    <tr>
                    <td class="style1">手机号码
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    </tr>
                    
                    <tr>
                    <td class="style1">付费方式
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem>---请选择---</asp:ListItem>
                            <asp:ListItem>网银支付</asp:ListItem>
                            <asp:ListItem>第三方支付</asp:ListItem>
                            <asp:ListItem>汇款支付</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    </tr>
                    
                    <tr>
                    <td class="style1">购买数量
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>---请选择---</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    </tr>
                    
                    
                    <tr>
                    <td class="style9" colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" CssClass="button1" Text="购买" 
                            Height="26px" Width="66px" onclick="Button1_Click" />
                    </td>
                    </tr>
                    
                    </table>
                
                
                
                </div>
                <div id="main-right"></div>
            </div>
    
    </div>
    </form>
</body>
</html>
