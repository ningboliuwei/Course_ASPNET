<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserInfo.aspx.cs" Inherits="Users_UserInfo" %>

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
            background: url(    'images/背景.jpg' );
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
            欢迎乐购
        </div>
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
            用户姓名：<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            密码&nbsp;&nbsp;&nbsp;&nbsp;：<asp:TextBox ID="txtUserPwd" runat="server"></asp:TextBox>
            <br />
            性别：
            <div>
                <asp:RadioButton ID="RadioButton1" runat="server" Checked="True" Text="男" GroupName="sexGroup" />
                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sexGroup" Text="女" /></div>
            出生年月：
            <asp:TextBox ID="txtDayOfBirth" runat="server"></asp:TextBox>
            <br />
            所在地址 ：<asp:TextBox ID="txtAdress" runat="server"></asp:TextBox>
            <br />
            联系email：<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            常用电话 ：<asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="修改" Height="19px" OnClick="Button2_Click"
                Width="51px" />
            <br />
            <div style="height: 200px"></div>
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
