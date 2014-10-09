<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Addperson.aspx.cs"
    Inherits="Admin_Admin_Addperson" %>

<%@ Register TagPrefix="uc1" TagName="menu_right" Src="~/Admin/menu_right.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head runat="server">
    <title>无标题页</title>
    <link href="../styles/layout.css" rel="stylesheet" type="text/css" />
    <!-- Theme Start -->
    <link href="../themes/blue/styles.css" rel="stylesheet" type="text/css" />
    <link href="../styles/wysiwyg.css" rel="stylesheet" type="text/css" />
    <script src="tabs_optimized.js" type="text/javascript"></script>

    <link href="design.css" rel="stylesheet" type="text/css" />
</head>
<body id="homepage" style="background-color: Silver">
    <form id="form1" runat="server">
    <div style="float: left">
        <uc1:menu_right ID="menu_right1" runat="server" />
    </div>
    <div style="height: 77px; width: 100%; margin-left: 227px; background-color: Gray">
    </div>
    <div style="margin-left: 228px; margin-top: 60px">
        <div id="content" style="margin-left: 150px">
            <div>
                <h1>
                    添加不同用户</h1>
                <ol id="toc">
                    <li><a href="#Introduction"><span>添加管理员</span></a></li>
                    <li><a href="#Step_1"><span>添加用户</span></a></li>
                </ol>
                <div class="content" id="Introduction">
                    <p>
                        管理员编号：
                        <asp:TextBox ID="txtNum" runat="server"></asp:TextBox>
                        *<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNum"
                            ErrorMessage="输入不能为空！" Display="Dynamic" ValidationGroup="bb"></asp:RequiredFieldValidator>
                        <br />
                        管理员姓名：
                        <asp:TextBox ID="txtUserName1" runat="server"></asp:TextBox>
                        *<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserName1"
                            ErrorMessage="输入不能为空！" Display="Dynamic" ValidationGroup="bb"></asp:RequiredFieldValidator>
                        <br />
                        密码&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ：
                        <asp:TextBox ID="txtUserPwd2" runat="server"></asp:TextBox>
                        *<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtUserPwd2"
                            ErrorMessage="输入不能为空！" Display="Dynamic" ValidationGroup="bb"></asp:RequiredFieldValidator>
                        <br />
                        确定密码&nbsp;&nbsp; ：
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="两次输入的密码不一致！"
                            ControlToCompare="txtUserPwd2" ControlToValidate="TextBox1" Display="Dynamic" ValidationGroup="bb"></asp:CompareValidator>
                        <br />
                        性别：
                        <div>
                            <asp:RadioButton ID="RadioButton3" runat="server" Checked="True" Text="男" GroupName="sexGroup1" />
                            <asp:RadioButton ID="RadioButton4" runat="server" GroupName="sexGroup1" Text="女" />
                        </div>
                        <br />
                        出生年月：&nbsp;
                        <asp:TextBox ID="txtDayOfBirth1" runat="server"></asp:TextBox>
                        <asp:Button ID="Button3" runat="server" Text="↓" Width="21px" OnClick="Button3_Click" ValidationGroup="bb" />
                        <asp:Calendar ID="calDayOfBirth1" runat="server" Visible="true" Style="margin-right: 44px"
                            Width="198px" OnSelectionChanged="calDayOfBirth1_SelectionChanged"></asp:Calendar>
                        <br/>
                        <p>
                            所在地址：&nbsp;
                            <asp:TextBox ID="txtAdress1" runat="server"></asp:TextBox>
                            <br />
                            联系email：
                            <asp:TextBox ID="txtEmail1" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="txtEmail1" Display="Dynamic" ErrorMessage="电子邮件格式错误" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="bb"></asp:RegularExpressionValidator>
                            <br />
                            常用电话：&nbsp;
                            <asp:TextBox ID="txtMobile1" runat="server"></asp:TextBox>
                            <br />
                        </p>
                        <asp:Button ID="Button4" runat="server" Text="注册" Height="22px" Style="margin-left: 0px;
                            margin-top: 0px;" Width="63px" OnClick="Button4_Click" ValidationGroup="bb" />
                </div>
                <div class="content" id="Step_1">
                    用户姓名：&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                    *<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="输入不能为空！" ValidationGroup="aa"></asp:RequiredFieldValidator>
                    <br />
                    密码&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ：&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtUserPwd" runat="server"></asp:TextBox>
                    *<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtUserPwd" Display="Dynamic" ErrorMessage="输入不能为空！" ValidationGroup="aa"></asp:RequiredFieldValidator>
                    <br />
                    确定密码：&nbsp; 
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    *<asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToCompare="txtUserPwd" ControlToValidate="TextBox2" Display="Dynamic" 
                        ErrorMessage="两次输入的密码不一致！" ValidationGroup="aa"></asp:CompareValidator>
                    <br />
                    性别：
                    <div>
                        <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" Text="男" GroupName="sexGroup" />
                        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sexGroup" Text="女" /></div>
                    <br />
                    出生年月：
                    <asp:TextBox ID="txtDayOfBirth" runat="server" ></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Text="↓" OnClick="Button1_Click" Width="21px" ValidationGroup="aa" />
                    <asp:Calendar ID="calDayOfBirth" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"
                        Visible="True" Style="margin-right: 44px" Width="198px"></asp:Calendar>
                    <br />
                    所在地址 ：<asp:TextBox ID="txtAdress" runat="server"></asp:TextBox>
                    <br />
                    联系email：<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="电子邮件格式错误" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="aa" ></asp:RegularExpressionValidator>
                    <br />
                    常用电话 ：<asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="注册" OnClick="Button2_Click" Height="22px"
                        Style="margin-left: 0px; margin-top: 0px;" Width="63px" ValidationGroup="aa"/>
                </div>
            </div>
        </div>
    </div>

    
    </form>
</body>
</html>
