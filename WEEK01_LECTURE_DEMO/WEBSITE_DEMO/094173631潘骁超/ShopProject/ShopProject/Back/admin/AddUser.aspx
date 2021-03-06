﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="ShopProject.Back.admin.AddUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    
     <style type="text/css">
     .content {
                border: 1px solid #ccc;
                margin: 0 0 20px 0;
                background: #fff;
                width: 400px;
                }

     .content-header {
                background: #e5e5e5 url('/images/box/bg-content-box.gif') top left repeat-x;
                /*margin-top: 1px;*/
                height: 40px;
                }

      .content-header h3 {
                padding: 1px 0 20px 10px;
                text-align: center;
                }
      .content-content {
                padding: 20px;
                font-size: 13px;
                border-top: 1px solid #ccc;
                }
         .style1
         {
             width: 76px;
             text-align: center;
         }
     table  tr td{
                background: #fff;
                font-size: 15px;
	            line-height: 1.5em;
	            font-family:fantasy;
                
	            
                }
     .input
     {
     	        font-family: Verdana, Arial, sans-serif;
                margin:5px 0 0 0;
                background: #459300 url('/images/box/bg-button-green.gif') top left repeat-x !important;
                border: 1px solid #459300 !important;
                padding: 5px 8px 5px 8px !important;
                color: #fff !important;
                font-size: 11px !important;
                font-weight:bold;
                cursor: pointer;
        }
        .input1
        {
        	font-family: Verdana, Arial, sans-serif;
        	
            padding: 5px 8px 5px 8px !important;
            cursor:pointer;
            font-size: 11px !important;
        }
        .red
        {
        	color:red;
        }
       .button1
       {
       	background: #4e85bb url("/images/box/button_highlight.png") repeat-x;
	    border: 1px solid #316293;
	    
	    color: #FFFFFF;
       }
       
        .button1:hover
       {
       	background: #4e85bb url("/images/box/button_highlight_selected.png") repeat-x;
	    
	    border: 1px solid #316293;
	    
	    color: #FFFFFF;
       }
       
     </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin: 0 0px 0 30px;height:100%;">
        <div class="content">

				<div class="content-header">
					<h3>添加用户</h3>

				</div> 
				<div class="content-content">
				<asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
				     <table width="350px">
				        <tr>
				        <td class="style1">账号
				        </td>
				        <td>
				        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                 <ContentTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox>&nbsp;&nbsp;<asp:Label
                                ID="Label1" runat="server" Text=""></asp:Label>
                                     <asp:Button 
                                ID="Button3" CssClass="button1"
                                runat="server" Text="检测用户" onclick="Button3_Click" />
                                
                            </ContentTemplate>
                          </asp:UpdatePanel>
				        </td>
				        </tr>
				     
				         <tr>
				        <td class="style1">性别
				        </td>
				        <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="sex" Text="男" /><asp:RadioButton ID="RadioButton2"
                                runat="server" GroupName="sex" Text="女" />
				        </td>
	
				        </tr>
				        
				        <tr>
				        <td class="style1">出生日期
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox7" runat="server" Width="75px"></asp:TextBox>
                            <asp:Button ID="Button2" runat="server" CssClass="input1" Text="显示日期" 
                                onclick="Button2_Click" />&nbsp;&nbsp;<span class="red">*</span><asp:Calendar ID="Calendar1" runat="server" 
                                Height="50px" onselectionchanged="Calendar1_SelectionChanged"></asp:Calendar>
				        </td>
				        </tr>
		
				        <tr>
				        <td class="style1">真实姓名
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>&nbsp;&nbsp;<span class="red">*</span>
				        </td>
				        </tr>
				        
				        
				        <tr>
				        <td class="style1">地址
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">Email
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>&nbsp;&nbsp;<span class="red">*</span>
				        </td>
				        </tr>
				        
				        
				        
				        <tr>
				        <td class="style1">爱好
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">角色
				        </td>
				        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>---请选择---</asp:ListItem>
                                <asp:ListItem>管理员</asp:ListItem>
                                <asp:ListItem>普通会员</asp:ListItem>
                            </asp:DropDownList>&nbsp;&nbsp;<span class="red">*</span>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">个人简介
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox8" runat="server" Height="100px" TextMode="MultiLine" 
                                Width="150px"></asp:TextBox>
				        </td>
				        </tr>
				        
				     
				        
				        <tr>
				        <td colspan="2" align="center">
                            <asp:Button ID="Button1" CssClass="input" runat="server" Text="添加用户" 
                                onclick="Button1_Click" />
				        </td>
				        </tr>
				     </table>
				
				</div>
		</div>
    </div>
    </form>
</body>
</html>
