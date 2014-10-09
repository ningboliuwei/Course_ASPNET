<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="changeShopInfo.aspx.cs" Inherits="ShopProject.Back.admin.changeShopInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
   <script src="../../js/shop/time/WdatePicker.js" type="text/javascript"></script>
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
					<h3>修改商品</h3>

				</div> 
				<div class="content-content">
				     <table width="350px">
				        <tr>
				        <td class="style1">商品名称
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
				        </td>
				        </tr>
				     
				         <tr>
				        <td class="style1">出版社
				        </td>
				        <td>
                            <asp:DropDownList ID="DropDownList2" runat="server">
                                <asp:ListItem>---请选择---</asp:ListItem>
                                <asp:ListItem>清华大学出版社</asp:ListItem>
                                <asp:ListItem>电子工业出版社</asp:ListItem>
                                <asp:ListItem>人民邮电出版社</asp:ListItem>
                                <asp:ListItem>机械工业出版社</asp:ListItem>
                                <asp:ListItem>东南大学出版社 </asp:ListItem>
                                <asp:ListItem>高等教育出版社</asp:ListItem>
                                <asp:ListItem>其他</asp:ListItem>
                            </asp:DropDownList>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">价格
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><span>元 </span>
				        </td>
				        </tr>
		
				        <tr>
				        <td class="style1">类别
				        </td>
				        <td>
                            <asp:DropDownList ID="DropDownList3" runat="server">
                            </asp:DropDownList>
				        </tr>
				        
				        
				        <tr>
				        <td class="style1">入库时间
				        </td>
				        <td>
                            <asp:TextBox ID="d11"  runat="server" onClick="WdatePicker()"></asp:TextBox>&nbsp;&nbsp;<img src="../../images/shop/calendar.png"/>

				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">数量
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
				        </td>
				        </tr>
				        
				        
				        
				        <tr>
				        <td class="style1">邮寄费用
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">快递费用
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">商品状态
				        </td>
				        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>有货</asp:ListItem>
                                <asp:ListItem>缺货</asp:ListItem>
                            </asp:DropDownList>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">保修
				        </td>
				        <td>
                            <asp:RadioButton ID="RadioButton1" runat="server" Text="是" GroupName="baoxiu" /><asp:RadioButton ID="RadioButton2"
                                runat="server" Text="否" GroupName="baoxiu" />
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">发票
				        </td>
				        <td>
                            <asp:RadioButton ID="RadioButton3" runat="server" Text="是" GroupName="fapiao" /><asp:RadioButton ID="RadioButton4"
                                runat="server" Text="否" GroupName="fapiao" />
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">详细信息
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" Height="82px"></asp:TextBox>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">图片
				        </td>
				        <td>
                            <asp:Image ID="Image1" runat="server" Width="60px"/>
                            修改图片<asp:FileUpload ID="imagesupload" runat="server"  />
				        </td>
				        </tr>
				        
				        <tr>
				        <td colspan="2" align="center">
                            <asp:Button ID="Button1" CssClass="input" runat="server" Text="修改商品" 
                                onclick="Button1_Click" />&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" 
                                CssClass="input" runat="server" Text="返回" onclick="Button2_Click" />
				        </td>
				        </tr>
				     </table>
				
				</div>
		</div>
    </div>
    </form>
</body>
</html>
