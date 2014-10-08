<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Book_Buy.aspx.cs" Inherits="Book_Buy" %>

<%@ Register TagPrefix="uc1" TagName="topcontrol" Src="~/TopControl.ascx" %>
<%@ Register TagPrefix="uc2" TagName="bottomcontrol" Src="~/BottomControl.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="templatemo_style.css" rel="stylesheet" type="text/css" />
    <!--  from www.cssmoban.com  -->
    <link rel="stylesheet" type="text/css" href="tabcontent.css" />

    <script type="text/javascript" src="tabcontent.js">
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
        <uc1:topcontrol ID="TopControl2" runat="server" />
    </div>
    <div id="templatemo_header_panel">
        <div id="templatemo_title_section">
            <h1>
                Yuan Jian<>ASP.NET
            </h1>
            <br />
            欢迎乐购O(∩_∩)O~~</div>
    </div>
    <!-- end of templatemo header panel -->
    <div id="templatemo_menu_panel">
        <div id="templatemo_menu_section">
            <ul>
                <li><a href="Index.aspx" class="current">包包首页</a></li>
                <li><a href="BookInfo_show.aspx">包包展示</a></li>
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
           <p > &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Text="生成所选订单" onclick="Button1_Click" /></p>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                DataKeyNames="num" AutoGenerateColumns="False" Height="280px" Style="margin-left: 0px;
                margin-right: 41px;" Width="720px" OnRowCommand="GridView1_RowCommand">
                <PagerSettings Visible="False" />
                <Columns>
                    <asp:TemplateField HeaderText="选择">
                        <HeaderTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged"
                                AutoPostBack="True" /></HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged"
                                AutoPostBack="True" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="num" HeaderText="序号" />
                    <asp:BoundField DataField="pid" HeaderText="包包id" Visible="false" />
                    <asp:ImageField DataImageUrlField="Photo" DataImageUrlFormatString="images/{0}" HeaderText="照片">
                        <ControlStyle Height="50px"></ControlStyle>
                    </asp:ImageField>
                    <asp:ButtonField DataTextField="BookName" HeaderText="包包信息" CommandName="show" />
                    <asp:BoundField DataField="count" HeaderText="购买数量" />
                    <asp:BoundField DataField="price" HeaderText="购买总价" />
                    <asp:BoundField DataField="username" HeaderText="购买用户" />
                    <asp:ButtonField HeaderText="生成订单" CommandName="order" Text="生成订单" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div style="height: 150px">
    </div>
    <div id="templatemo_bottom_panel">
        <div id="templatemo_bottom_section">
        </div>
    </div>
    <!-- end of templatemo bottom panel -->
    <div id="templatemo_footer_panel">
        <div id="templatemo_footer_section">
            <uc2:bottomcontrol ID="BottomControl2" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
