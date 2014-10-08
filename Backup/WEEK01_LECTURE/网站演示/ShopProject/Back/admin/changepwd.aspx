<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changepwd.aspx.cs" Inherits="ShopProject.Back.admin.changepwd" %>

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
                margin: 0 0 10px 0;
	            height:55px;
	            padding-top: 3px;
	            overflow: hidden;
	            background: #336699 url("/images/shop/title.png") repeat-x;
                }

      .content-header h3 {
                padding:0px 0 20px 10px;
                text-align: center;
                color:white;
                }
      .content-content {
                padding: 20px;
                font-size: 13px;
                border-top: 1px solid #ccc;
                }
         .style1
         {
            width: 128px;
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
       
        #date
        {
            width: 153px;
        }
       
     </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center" style="margin: 0 0px 0 30px;height:100%;">
         <div class="content">

				<div class="content-header">
					<h3>修改密码</h3>

				</div> 
				<div class="content-content">
				     <table width="350px">
				        <tr>
				        <td class="style1">原有密码
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">请输入新密码
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">确认新密码
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
				        </td>
				        </tr>
				     
				         
				        
				        <tr>
				        <td colspan="2" align="center">
                            <asp:Button ID="Button1" CssClass="input" runat="server" Text="确认" onclick="Button1_Click" 
                                 />
				        </td>
				        </tr>
				     </table>
				
				</div>
		</div>
    </div>
    </form>
</body>
</html>
