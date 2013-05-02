<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
        <link href="../Admin/skin.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        #table212
        {
            width: 71%;
            margin-left: 0px;
        }
        .top_hui_text
        {
        }
        .login_txt
        {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 12px;
            line-height: 25px;
            color: #333333;
        }
        .style2
        {
            width: 65px;
        }
        span
        {
            font-size:10px;
        }
        
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <table width="100%" height="166" border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td height="42" class="top">
                <table width="100%" height="42" border="0" cellpadding="0" cellspacing="0" class="login_top_bg">
                    <tr>
                        <td width="1%" height="21">
                            &nbsp;
                        </td>
                        <td height="42">
                            &nbsp;
                        </td>
                        <td width="17%">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="top">
                <table width="100%" height="532" border="0" cellpadding="0" cellspacing="0" class="login_bg">
                    <tr>
                        <td width="49%" align="right">
                            <table width="91%" height="532" border="0" cellpadding="0" cellspacing="0" class="login_bg2">
                                <tr>
                                    <td height="138" class="top">
                                        <table width="89%" height="427" border="0" cellpadding="0" cellspacing="0">
                                            <tr>
                                                <td height="149" align="center">
                                                    <h1>
                                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                        包包网</h1>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="80" align="right" class="top">
                                                    <img src="../images/111.jpg" height="230px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="198" align="right" class="top">
                                                    &nbsp;</td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                        <td width="1%">
                            &nbsp;
                        </td>
                        <td width="50%" class="bottom">
                            <table width="100%" height="59" border="0" align="center" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td width="4%">
                                        &nbsp;
                                    </td>
                                    <td width="96%" height="38">
                                        <span class="login_txt_bt">包包网前台登录</span>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td height="210px">
                                        <table >
                                            <tr>
                                                <td height="164" colspan="2" align="middle">
                                                    <table  height="143" >
                                                        <tr>
                                                            <td height="38" style="width: 40%"  >
                                                                <span>用户：</span>
                                                            </td>
                                                            <td height="38" colspan="2" style="width:60%" >
                                                                <asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="38" style="width: 40%">
                                                                <span>密 码：</span>
                                                            </td>
                                                            <td height="38" colspan="2" style="width:60%" >
                                                                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
                                                                <img src="../images/luck.gif" width="19" height="18">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="35" class="style2">
                                                      
                                                            </td>
                                                            <td height="35" colspan="2" class="top_hui_text">
            <asp:CheckBox runat="server" ID="chkRememberPassword" Text="记住密码" />
            <asp:DropDownList ID="dplSaveTime" runat="server">
                <asp:ListItem>保存一天</asp:ListItem>
                <asp:ListItem>保存一月</asp:ListItem>
                <asp:ListItem>保存一年</asp:ListItem>
            </asp:DropDownList>
                                                       
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td height="35" class="style2">
                                                        
                                                            </td>
                                                            <td width="20%" height="35">
            <asp:Button runat="server" ID="btnLogin" Text="登录" OnClick="btnLogin_Click" Height="19px" />
            <asp:Button ID="btnRegister" runat="server" Text="注册" OnClick="btnRegister_Click" Height="18px" /><asp:Button ID="Button1" runat="server" Height="18px" Text="首页" 
                                                                    onclick="Button1_Click" />
                                                            </td>
                                                            <td width="67%" class="top_hui_text">
                                                              
                                                                
                                                              
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <br>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td width="433" height="164" align="right">
                                           
                                                </td>
                                                <td width="57" align="right">
                                               
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td height="20">
                <table width="100%" >
                    <tr>
                        <td align="center">
                            &nbsp;
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
