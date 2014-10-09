<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showOrders.aspx.cs" Inherits="ShopProject.Back.admin.showOrders" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<script type="text/javascript" src="../../js/box/facebox.js"></script>
<link rel="stylesheet" href="../../css/right.css" type="text/css" media="screen" />
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 148px;
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
					<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                            AllowPaging="True" onpageindexchanging="GridView1_PageIndexChanging" 
                            PageSize="5" Width="763px">
                        <Columns>
                            <asp:BoundField HeaderText="序号" />
                            <asp:BoundField DataField="username" HeaderText="用户名" />
                            <asp:BoundField DataField="shname" HeaderText="商品名" />
                            <asp:BoundField DataField="time" HeaderText="提交时间" />
                            <asp:BoundField DataField="shoppay" HeaderText="支付方式" />
                            <asp:BoundField DataField="posttype" HeaderText="配送方式" />
                            <asp:TemplateField HeaderText="详情信息">
                              <ItemTemplate>
                                  <a href="OrdersInfo.aspx?id=<%# Eval("orid") %>" >详细信息</a>
                              
                              </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                      
											
					</div> 
                    

				</div> 

			</div> 
			
    </div>
    </form>
</body>
</html>
