<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Guan.aspx.cs" Inherits="ShopProject.Back.User_Guan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" href="../../css/right.css" type="text/css" media="screen" />
<script type="text/javascript" src="../../js/box/facebox.js"></script>
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
					<h3>用户信息</h3>

					<div class="clear"></div>

				</div> 

				

				<div class="content-box-content">

					

					<div class="tab-content default-tab" >
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                            CssClass="content-box" Width="900px" onrowcommand="GridView1_RowCommand">
                            <Columns>
                                
                                <asp:TemplateField HeaderText="全选">
                                <HeaderTemplate>
                                  <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="checkAll" AutoPostBack="true"/>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CheckBox2" runat="server" 
                                         />
                                </ItemTemplate> 
                                </asp:TemplateField>
                                
                                <asp:BoundField DataField="username" HeaderText="账号" />
                                <asp:BoundField DataField="sex" HeaderText="性别" />
                                <asp:BoundField DataField="age" HeaderText="年龄" />
                                <asp:BoundField DataField="address" HeaderText="地址" />
                                <asp:BoundField DataField="email" HeaderText="Email" />
                                <asp:BoundField DataField="birthday" HeaderText="生日" />
                                <asp:TemplateField HeaderText="编辑">
                                <ItemTemplate>
                                   <asp:ImageButton ID="ImageButton1" CommandName="edit" runat="server" ImageUrl="/images/box/pencil.png" AlternateText="编辑" onclick="ImageButton1_Click" CommandArgument='<%# Eval("userid") %>'/>
                                    
                                </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="删除">
                                <ItemTemplate>
                                    <asp:ImageButton ID="ImageButton2" runat="server" CommandName="delete" ImageUrl="/images/box/cross.png" AlternateText="删除" onclick="ImageButton2_Click"  CommandArgument='<%# Eval("userid") %>'/>
                                </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                          
                        </asp:GridView>
                        <asp:Button ID="Button1" runat="server" Text="批量删除" CssClass="shanchu" 
                            onclick="Button1_Click" />
                        <div class="pagination" align="right">
                            

		<a href="#" title="First Page">&laquo; 首页</a><a href="#" title="Previous Page">&laquo; 前一页</a>

		<a href="#" class="number" title="1">1</a>

		<a href="#" class="number" title="2">2</a>

		<a href="#" class="number current" title="3">3</a>

		<a href="#" class="number" title="4">4</a>

		<a href="#" title="Next Page">下一页 &raquo;</a><a href="#" title="Last Page">尾页 &raquo;</a>

	</div> <!-- End .pagination -->

	<div class="clear"></div> 
                        	
                        					
					</div> 
					

			</div> 
	</div>
	
    </div>
    </form>
</body>
</html>
