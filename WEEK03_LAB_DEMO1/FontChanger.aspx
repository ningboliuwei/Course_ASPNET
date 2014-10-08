<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FontChanger.aspx.cs" Inherits="FontChanger" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
        <title>动态修改字体显示效果</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <table width="100%">
                    <tr>
                        <td style="text-align: right">
                            字体大小：</td>
                        <td>
   
<asp:DropDownList ID="drpFontSize" runat="server" AutoPostBack="True" onselectedindexchanged="drpFontSize_SelectedIndexChanged" >
    <asp:ListItem Text="超小字体" Value="10"></asp:ListItem>
    <asp:ListItem Text="小字体" Value="10"></asp:ListItem>
    <asp:ListItem Text="中字体" Value="10"></asp:ListItem>
    <asp:ListItem Text="大字体" Value="10"></asp:ListItem>
    <asp:ListItem Text="超大字体" Value="10"></asp:ListItem>
</asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            文字粗斜体：</td>
                        <td>
                            <asp:CheckBox ID="chkBold" runat="server" Text="粗体" AutoPostBack="True" oncheckedchanged="chkBold_CheckedChanged" 
                                />
                            <asp:CheckBox ID="chkItalic" runat="server" Text = "斜体" AutoPostBack="True" oncheckedchanged="chkItalic_CheckedChanged" 
                                />
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">字体名称：
                        </td>
                        <td>
                            <asp:RadioButton ID="rdoSong" runat="server" GroupName="GroupFont" Text ="宋体" 
                                             AutoPostBack="True" 
                                             oncheckedchanged="rdoSong_CheckedChanged" />
                            <asp:RadioButton ID="rdoHei" runat="server" GroupName="GroupFont" Text="黑体" 
                                             AutoPostBack="True" 
                                             oncheckedchanged="rdoHei_CheckedChanged"  />
                            <asp:RadioButton ID="rdoLishu" runat="server" GroupName="GroupFont" Text="隶书" 
                                             AutoPostBack="True" 
                                             oncheckedchanged="rdoLishu_CheckedChanged" />
                    
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">文字颜色：
                        </td>
                        <td>
                            <asp:RadioButton ID="rdoColorRed" runat="server" GroupName="GroupColor" Text ="红色" 
                                             AutoPostBack="True" 
                                             oncheckedchanged="rdoColorRed_CheckedChanged" />
                            <asp:RadioButton ID="rdoColorYellow" runat="server" GroupName="GroupColor" Text="黄色" 
                                             AutoPostBack="True" 
                                             oncheckedchanged="rdoColorYellow_CheckedChanged"  />
                            <asp:RadioButton ID="rdoColorBlue" runat="server" GroupName="GroupColor" Text="蓝色" 
                                             AutoPostBack="True" 
                                             oncheckedchanged="rdoColorBlue_CheckedChanged" />
              
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">文字其他属性：
                        </td>
                        <td>
                            <asp:CheckBoxList ID="chkFontStyle" runat="server" 
                                              RepeatDirection="Horizontal" AutoPostBack="True" onselectedindexchanged="chkFontStyle_SelectedIndexChanged" 
                                >
                                <asp:ListItem>下划线</asp:ListItem>
                                <asp:ListItem>删除线</asp:ListItem>
                                <asp:ListItem>上划线</asp:ListItem>
                            </asp:CheckBoxList>
                        </td>
          
                    </tr>
                    <tr><td style="text-align: right">自定义测试文本：</td><td>
                                                                       <asp:TextBox ID="txtTestText" runat="server"></asp:TextBox>
                                                                       <span lang="zh-cn">&nbsp;&nbsp;&nbsp; </span>
                                                                       <asp:Button ID="btnChangeTestText" runat="server" Text="修改测试文本" 
                                                                                   onclick="btnChangeTestText_Click" />
                                                                   </td></tr>
                    <tr>
            
                        <td>
                            <span lang="zh-cn">&nbsp;</span></td>
                        <td>
                            <asp:Label ID="lblTestText" runat="server" Text="测试文本" Font-Size="10"></asp:Label>
              
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </body>
</html>