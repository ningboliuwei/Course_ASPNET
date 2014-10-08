<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admininfo.aspx.cs" Inherits="Admin_Admininfo" %>
<%@ Register TagPrefix="uc1" TagName="menu_right" Src="~/Admin/menu_right.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="../styles/layout.css" rel="stylesheet" type="text/css" />
    <link href="../styles/wysiwyg.css" rel="stylesheet" type="text/css" />
    <!-- Theme Start -->
    <link href="../themes/blue/styles.css" rel="stylesheet" type="text/css" />
</head>
<body id="homepage" style="background-color: Silver">
    <form id="form1" runat="server">
    <div style="float: left">
        <uc1:menu_right ID="menu_right1" runat="server" />
    </div>
    <div style="height: 77px; width:100%; margin-left: 227px; background-color: Gray">
    </div>
    <div style="margin-left: 228px; margin-top:60px">
        <div id="content" style="margin-left: 150px">
            <div>

            
                编号&nbsp; ：&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                            ErrorMessage="输入不能为空！" Display="Dynamic"></asp:RequiredFieldValidator>
                        <br />
                名字：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                            ErrorMessage="输入不能为空！" Display="Dynamic"></asp:RequiredFieldValidator>
                        <br />
               <%-- 密码：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />--%>
                性别：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" GroupName="sexGroup" Text="男" />
                    
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sexGroup" 
                    Text="女" />
                <br />
                生日：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
                地址：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
                Email：&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="TextBox7" Display="Dynamic" ErrorMessage="电子邮件格式错误" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <br />
                联系电话：<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnUpdate" runat="server" Text="修改" Height="23px" 
                    onclick="btnUpdate_Click" Width="58px" />
            </div>
        </div>
    </div>

    
    </form>
</body>
</html>