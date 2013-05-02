<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShopList.aspx.cs" Inherits="ShopProject.Back.admin.ShopList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    
<script type="text/javascript" src="../../js/box/facebox.js"></script>
<link rel="stylesheet" href="../../css/right.css" type="text/css" media="screen" />
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
					<h3>商品信息</h3>

					<div class="clear"></div>

				</div> 

				

				<div class="content-box-content">

					

					<div class="tab-content default-tab" align="center"> 
					
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                            CssClass="content-box1" Width="900px" 
                            >
                            <Columns>
                                 
                                <asp:TemplateField >
                                <HeaderTemplate>  
                                    <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="checkAll" AutoPostBack="true"/>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    
                                    <asp:CheckBox ID="CheckBox2" runat="server" CommandArgument='<%# Eval("shopid") %>'/>
                                </ItemTemplate> 
                                </asp:TemplateField>
                                <asp:BoundField DataField="shname" HeaderText="商品名字" />
                                <asp:BoundField DataField="publising" HeaderText="出版社" />
                                <asp:BoundField DataField="price" HeaderText="价格" />
                                <asp:BoundField DataField="firsttime" HeaderText="入库时间" />
                                <asp:BoundField DataField="sort" HeaderText="类别" />
                                <asp:BoundField DataField="shopnum" HeaderText="库量" />
                              
                                <asp:TemplateField HeaderText="编辑">
                                <ItemTemplate>
                                   <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/images/box/pencil.png" AlternateText="编辑" onclick="ImageButton1_Click" CommandArgument='<%# Eval("shopid") %>'/>
                                </ItemTemplate>
                                </asp:TemplateField>
                            
                                <asp:TemplateField HeaderText="删除">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="/images/box/cross.png" AlternateText="删除" onclick="ImageButton2_Click" CommandArgument='<%# Eval("shopid") %>'/>
                                </ItemTemplate>
                                </asp:TemplateField>
                                
                            
                            </Columns>
                        </asp:GridView>
                        <asp:Button ID="Button1" runat="server" Text="批量删除" CssClass="shanchu" 
                            onclick="Button1_Click" />
                        <div class="pagination" align="right">
                                 共<asp:Label ID="Label1" runat="server" Text=""></asp:Label>页&nbsp;&nbsp;当前第<asp:Label
                                     ID="Label2" runat="server" Text="1"></asp:Label>页
 
              &laquo; <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">首页</asp:LinkButton>&nbsp;&nbsp;&lt;
                      <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">前一页</asp:LinkButton>&nbsp;&nbsp;
                      <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">下一页</asp:LinkButton> &gt;&nbsp;&nbsp; 
                      <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">尾页</asp:LinkButton> &raquo;

						</div> 

										<div class="clear"></div>


						<!--
						<table style="width: 900px">
							
								<tr>
								   <th align="center"><input class="check-all" type="checkbox" /></th>

								   <th align="center">商品名字</th>

								   <th align="center">出版社</th>

								   <th align="center" class="style2">类别</th>
                                   <th align="center" class="style1">入库时间</th>
								   <th align="center">商品数量</th>

								   <th align="center"> 操作</th>

								</tr>
								 
								<tr>

									<td align="center"><input type="checkbox" /></td>

									<td align="center">Asp.Net 3.5中文版</td>

									<td align="center"><a href="#" title="title">电子工业出版社</a></td>

									<td align="center" class="style2">技术类</td>
									<td align="center" class="style1">1990-1-1</td>

									<td align="center">10</td>

									<td align="center">

										

										 <a href="#" title="编辑"><img src="../../images/box/pencil.png" alt="编辑" /></a>

										 <a href="#" title="删除"><img src="../../images/box/cross.png" alt="删除" /></a> 

										 <a href="#" title="Edit Meta"><img src="../../images/box/hammer_screwdriver.png" alt="Edit Meta" /></a>

									</td>

								</tr>
								
								
								<tr>
                                    <td align="center"><input type="checkbox" /></td>

									<td align="center">JSP实用教程</td>

									<td align="center"><a href="#" title="title">清华大学出版社</a></td>

									<td align="center" class="style2">技术类</td>
									<td align="center" class="style1">1990-1-1</td>

									<td align="center">9</td>

									<td align="center">

										

										 <a href="#" title="Edit"><img src="../../images/box/pencil.png" alt="Edit" /></a>

										 <a href="#" title="Delete"><img src="../../images/box/cross.png" alt="Delete" /></a> 

										 <a href="#" title="Edit Meta"><img src="../../images/box/hammer_screwdriver.png" alt="Edit Meta" /></a>

									</td>

								</tr>


                                 <tr>

									<td align="center"><input type="checkbox" /></td>

									<td align="center">数据库系统概论</td>

									<td align="center"><a href="#" title="title">高等教育出版社</a></td>

									<td align="center" class="style2">技术类</td>
									<td align="center" class="style1">1990-1-1</td>

									<td align="center">9</td>

									<td align="center">

										 <a href="#" title="Edit"><img src="../../images/box/pencil.png" alt="Edit" /></a>

										 <a href="#" title="Delete"><img src="../../images/box/cross.png" alt="Delete" /></a> 

										 <a href="#" title="Edit Meta"><img src="../../images/box/hammer_screwdriver.png" alt="Edit Meta" /></a>

									</td>

								</tr>


                                     <tr>

									<td align="center"><input type="checkbox" /></td>

									<td align="center">JavaScript完全解析</td>

									<td align="center"><a href="#" title="title">人民邮电出版社</a></td>

									<td align="center" class="style2">技术类</td>
									<td align="center" class="style1">1990-1-1</td>

									<td align="center">20</td>

									<td align="center">

									

										 <a href="#" title="Edit"><img src="../../images/box/pencil.png" alt="Edit" /></a>

										 <a href="#" title="Delete"><img src="../../images/box/cross.png" alt="Delete" /></a> 

										 <a href="#" title="Edit Meta"><img src="../../images/box/hammer_screwdriver.png" alt="Edit Meta" /></a>

									</td>

								</tr>


								<tr>

									<td colspan="7">

										<div class="pagination" align="right">

											<a href="#" title="First Page">&laquo; 首页</a><a href="#" title="Previous Page">&laquo; 前一页</a>

											<a href="#" class="number" title="1">1</a>

											<a href="#" class="number" title="2">2</a>

											<a href="#" class="number current" title="3">3</a>

											<a href="#" class="number" title="4">4</a>

											<a href="#" title="Next Page">下一页 &raquo;</a><a href="#" title="Last Page">尾页 &raquo;</a>

										</div> 

										<div class="clear"></div>

									</td>

								</tr>
                                         
						</table>
						-->
											
					</div> 

				</div> 

			</div> 
    </div>
    </form>
</body>
</html>
