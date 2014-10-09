<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrdersInfo.aspx.cs" Inherits="ShopProject.Back.admin.OrdersInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <script type="text/javascript" src="../../js/box/facebox.js"></script>
<link rel="stylesheet" href="../../css/right.css" type="text/css" media="screen" />
    <title></title>
    <style type="text/css">
        .style1
        {
           font-weight:bold;
        }
        .style2
        {
            width: 127px;
        }
         .shanchu
        {
        	color: white !important;
            text-shadow: 0 1px 1px rgba(0, 0, 0, 0.25);
            border: 1px solid #749217 !important;
            background-color: #6AB620 !important;

            padding: 5px 10px;
          
            text-decoration: none;
            font-weight: bold;
            font-size: 11px;
       
            -moz-border-radius: 4px;
            -webkit-border-radius: 4px;
          
           
            position: relative;
            cursor: pointer;
            border: 1px solid #CCC !important;
            margin-left:30px;
            float: left;
        }
        table
        {
        width: 900px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin: 0 0px 0 30px;height:100%;">
    <div class="content-box">

				<div class="content-box-header">
					<h3>订单查看</h3>

					<div class="clear"></div>

				</div> 
				<div class="content-box-content">

					

					<div class="tab-content default-tab" align="center"> 
					
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:TemplateField>
                                  <ItemTemplate>
                                      <table width="900px">
                                      <tr>
                                          <td class="style1">用户名
                                          </td>
                                          
                                          <td><%# Eval("username") %>
                                          </td>
                                          
                                          <td class="style1">商品名
                                          </td>
                                          
                                          <td><%# Eval("shname") %>
                                          </td>
                                          
                                          <td class="style1">提交时间
                                          </td>
                                          
                                          <td><%# Eval("time") %>
                                          </td>
                                          
                                          <td class="style1">购买数量
                                          </td>
                                          
                                          <td><%# Eval("num") %>
                                          </td>
                                      
                                      
                                      </tr>
                                      
                                      
                                      <tr>
                                          <td class="style1">配送方式
                                          </td>
                                          
                                          <td><%# Eval("posttype") %>
                                          </td>
                                          
                                          <td class="style1">配送费用
                                          </td>
                                          
                                          <td><%# Eval("postprice") %>
                                          </td>
                                          
                                          <td class="style1">总价
                                          </td>
                                          
                                          <td><%# Eval("sumPrice") %>
                                          </td>
                                          
                                          <td class="style1">收货人
                                          </td>
                                          
                                          <td><%# Eval("conName") %>
                                          </td>
                                      
                                      
                                      </tr>
                                      
                                      
                                      <tr>
                                          <td class="style1">Tel
                                          </td>
                                          
                                          <td><%# Eval("tele") %>
                                          </td>
                                          
                                          <td class="style1">地址
                                          </td>
                                          
                                          <td><%# Eval("conadderess") %>
                                          </td>
                                          
                                          <td class="style1">邮编
                                          </td>
                                          
                                          <td><%# Eval("conpost") %>
                                          </td>
                                          
                                          <td class="style1">订单状态
                                          </td>
                                          
                                          <td>
                                              <%# Eval("state") %>
                                          </td>
                                      
                                      
                                      </tr>
                                      
                                      
                                      <tr>
                                         
                                          
                                          <td class="style1">支付方式
                                          </td>
                                          
                                          <td><%# Eval("shoppay") %>
                                          </td>
                                      </tr>
                                      </table>                            
                                  </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>

                        </asp:GridView>	
					</div> 
					<a href="showOrders.aspx" style="font-size: 20px; font-weight:bold">返回</a>
                    

				</div> 

			</div> 
			
    </div>
    </form>
</body>
</html>
