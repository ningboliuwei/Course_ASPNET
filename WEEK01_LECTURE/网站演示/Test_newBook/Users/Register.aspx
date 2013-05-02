<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Users_aa" %>

<%@ Register TagPrefix="uc1" TagName="TopControl" Src="~/TopControl.ascx" %>
<%@ Register TagPrefix="uc2" TagName="BottomControl" Src="~/BottomControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>无标题页</title>
    <link href="../templatemo_style.css" rel="stylesheet" type="text/css" />
    <!--  from www.cssmoban.com  -->
    <link rel="stylesheet" type="text/css" href="../tabcontent.css" />

    <script type="text/javascript" src="../tabcontent.js">
/***********************************************
* Tab Content script v2.2- © Dynamic Drive DHTML code library (www.dynamicdrive.com)
* This notice MUST stay intact for legal use
* Visit Dynamic Drive at http://www.dynamicdrive.com/ for full source code
***********************************************/
    </script>

    <style type="text/css">
        *
        {
            margin: 0px;
            padding: 0px;
            border: 0px;
        }
        body, td, th
        {
            margin: 0;
            padding: 0;
            font-family: Arial, Helvetica, sans-serif;
            line-height: 1.5em;
            text-align: center;
            font-family: 宋体;
            font-size: 12px;
            color: #ff7f50;
            background: url(   'images/背景.jpg' );
        }
    </style>
</head>
<body style="background: url(  'images/背景.jpg' );">
    <form id="form1" runat="server">
    <div>
        <uc1:TopControl ID="TopControl2" runat="server" />
    </div>
    <div id="templatemo_header_panel">
        <div id="templatemo_title_section">
            <h1>
                Yuan Jian<>ASP.NET
            </h1>
            <br />
            <br />
            欢迎乐购O(∩_∩)O~~</div>
    </div>
    <!-- end of templatemo header panel -->
    <div id="templatemo_menu_panel">
        <div id="templatemo_menu_section">
            <ul>
                <li><a href="../Index.aspx" class="current">包包首页</a></li>
                <li><a href="../BookInfo_show.aspx">包包展示</a></li>
                <li><a href="#">包包历史</a></li>
                <li><a href="#">品牌展示</a></li>
                <li><a href="#">hi，女包</a></li>
                <li><a href="#">hi，男包</a></li>
                <li><a href="#">小资天下</a></li>
                <li><a href="#">你来我往</a></li>
            </ul>
        </div>
    </div>
    <!-- end of menu -->
    <div id="templatemo_content_container">
        <div id="templatemo_content">
            <!-- end of content left -->
            <!-- end of content -->
           用户姓名：<asp:TextBox ID="txtUserName" runat="server" Width="113px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="输入不能为空！" ValidationGroup="aa"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                密码：&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtUserPwd" runat="server" Width="112px"></asp:TextBox>
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUserPwd" Display="Dynamic" ErrorMessage="输入不能为空！" ValidationGroup="aa"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                确定密码：&nbsp; 
                    <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="112px"></asp:TextBox>
                    &nbsp;<asp:CompareValidator ID="CompareValidator2" runat="server" 
                        ControlToCompare="txtUserPwd" ControlToValidate="TextBox2" Display="Dynamic" 
                        ErrorMessage="两次输入的密码不一致！" ValidationGroup="aa"></asp:CompareValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br/>
                性别：
                <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" Text="男" GroupName="sexGroup" />
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sexGroup" Text="女" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                联系email：<asp:TextBox ID="txtEmail" runat="server" Width="118px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="电子邮件格式错误" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="aa"></asp:RegularExpressionValidator>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                出生年月：
                <asp:TextBox ID="txtDayOfBirth" runat="server" Width="122px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="↓" OnClick="Button1_Click" Width="21px"  ValidationGroup="aa"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Calendar ID="calDayOfBirth" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"
                    Visible="true" Style="margin-right: 44px" Width="198px"></asp:Calendar>
                    <br/>
                所在地址 ：<asp:TextBox ID="txtAdress" runat="server" Width="135px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                
                常用电话 ：<asp:TextBox ID="txtMobile" runat="server" Width="110px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Button ID="Button2" runat="server" Text="注册" OnClick="Button2_Click" Height="22px"
                    Style="margin-left: 0px; margin-top: 0px;" Width="63px" ValidationGroup="aa"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </div>
    <div id="templatemo_bottom_panel">
        <div id="templatemo_bottom_section">
        </div>
    </div>
    <!-- end of templatemo bottom panel -->
    <div id="templatemo_footer_panel">
        <div id="templatemo_footer_section">
            <uc2:BottomControl ID="BottomControl2" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
