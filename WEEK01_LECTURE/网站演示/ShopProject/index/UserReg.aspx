<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserReg.aspx.cs" Inherits="ShopProject.index.UserReg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" type="text/css" href="../css/login.css" />
    <title></title>
    <style type="text/css">
     .content {
                border: 1px solid #ccc;
                margin: 0 0 20px 0;
                background: #fff;
                width: 400px;
                margin: 0px auto;
     }

     .content-header {
                 margin: 0 0 10px 0;
	            height:55px;
	            padding-top: 3px;
	            overflow: hidden;
	            background: #336699 url("/images/shop/title.png") repeat-x;
                }

      .content-header h2{
                 padding:10px 0 20px 10px;
                text-align: center;
                color:white;
                font-size: 23px;
      }
      .content-content {
                padding: 20px;
                font-size: 13px;
                border-top: 1px solid #ccc;
                }
         .style1
         {
            width: 67px;
            text-align: center;
        }
     table  tr td{
                background: #fff;
                font-size: 15px;
	            line-height: 2em;
	          
                
	            
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
	    padding: 4px 7px 4px 7px;
	    color: #FFFFFF;
       }
       
        .button1:hover
       {
       	background: #4e85bb url("/images/box/button_highlight_selected.png") repeat-x;
	    
	    border: 1px solid #316293;
	    
	    color: #FFFFFF;
       }
       
        #table
       {
       	  width:550px;
       	  margin:50px auto;
       	
       	  
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

                    <li><a href="">

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
            <div id="reg">
            <div id="table">
                <div class="content">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>

				  <div class="content-header">
					 <h2 >注册用户</h2>

				     </div> 
				   <div class="content-content">
				     <table>
				        <tr> 
				        <td colspan="2" align="center">
                            
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">账号
				        </td>
				        <td>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                 <ContentTemplate>
                                 
                                     <asp:TextBox ID="TextBox1" runat="server" Width="100px"></asp:TextBox>&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text=""></asp:Label><asp:Button 
                                      ID="Button3" CssClass="button1"
                                          runat="server" Text="检测用户" Height="28px" onclick="Button3_Click" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                            
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">登录密码
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>&nbsp;&nbsp;<span class="red">*</span>
				        </td>
				        </tr>
				        <tr>
				        <td class="style1">确认密码
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>&nbsp;&nbsp;<span class="red">*</span>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="密码不一致"></asp:CompareValidator>
				        </td>
				        </tr>
				        
				        <tr>
				        <td class="style1">Email
				        </td>
				        <td>
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>&nbsp;&nbsp;<span class="red">*</span>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ErrorMessage="Email不合法" ControlToValidate="TextBox4" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
				        </tr>
				        
				        
				       
				        <tr>
				        <td colspan="2" align="center">
                            <asp:Button ID="Button1" CssClass="input" runat="server" Text="注册" 
                                 Height="30px" onclick="Button1_Click" />
				        </td>
				        </tr>
				     </table>
				
				</div>
		     </div>
                
            </div>
            </div>
    
    </div>
    </form>
</body>
</html>
