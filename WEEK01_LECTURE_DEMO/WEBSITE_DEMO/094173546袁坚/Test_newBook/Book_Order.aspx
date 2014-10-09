<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Book_Order.aspx.cs" Inherits="Book_Order" %>

<%@ Register TagPrefix="uc2" TagName="bottomcontrol" Src="~/BottomControl.ascx" %>
<%@ Register TagPrefix="uc1" TagName="topcontrol" Src="~/TopControl.ascx" %>
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
            欢迎乐购
        </div>
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
            <br />
            <div>
                <div style="margin-right: 400px; height: 58px; width: 597px;">
                    亲爱的用户，您的地址：<asp:Label ID="Label1" runat="server" Text=""></asp:Label><font size="15px"><asp:Button
                        ID="Button1" runat="server" Text="结算全部订单" Height="26px" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="结算所选订单" Width="89px" 
                        Height="25px" onclick="Button2_Click" />
                    <asp:Label
                            ID="Label2" runat="server" Visible="false" Text=""></asp:Label></font>
                </div>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                    AutoGenerateColumns="False" Height="280px" OnRowCommand="GridView1_RowCommand"
                    OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting"
                    Style="margin-left: 0px; margin-right: 41px;" Width="720px">
                    <PagerSettings Visible="False" />
                    <Columns>
                            <asp:TemplateField HeaderText="选择">
                                 <HeaderTemplate><asp:CheckBox ID="CheckBox1" runat="server" 
                                         oncheckedchanged="CheckBox1_CheckedChanged" AutoPostBack="True" /></HeaderTemplate>
                                
                            
                            <ItemTemplate>
                                <asp:CheckBox ID="CheckBox2" runat="server" oncheckedchanged="CheckBox2_CheckedChanged" AutoPostBack="True"/>
                            </ItemTemplate>
                                
                            </asp:TemplateField>

                            <asp:BoundField DataField="BookOrderID" HeaderText="订单编号" Visible="false" />
                            <asp:ButtonField CommandName="show" DataTextField="BookName" HeaderText="包包信息" />
                            <asp:BoundField DataField="BookPrice" HeaderText="包包单价" />
                            <asp:BoundField DataField="BookCount" HeaderText="包包数量" />
                            <asp:BoundField DataField="BookCountPrice" HeaderText="购买总价" />
                            <asp:BoundField DataField="UserInfoName" HeaderText="购买用户" />
                            <asp:BoundField DataField="Datatime" HeaderText="订单时间" />
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="true" />
                            <%-- <asp:ButtonField HeaderText="修改" CommandName="buy"  Text="结算" />--%>
                    </Columns>
                </asp:GridView>
                <div style="margin-right: 400px">
                    <asp:LinkButton ID="btnFirst" runat="server" CommandArgument="first" OnClick="PagerButtonClick">首 页</asp:LinkButton>
                    <asp:LinkButton ID="btnPrev" runat="server" CommandArgument="prev" OnClick="PagerButtonClick">上一页</asp:LinkButton>
                    <asp:LinkButton ID="btnNext" runat="server" CommandArgument="next" OnClick="PagerButtonClick">下一页</asp:LinkButton>
                    <asp:LinkButton ID="btnLast" runat="server" CommandArgument="last" OnClick="PagerButtonClick">尾 页</asp:LinkButton>
                    <asp:Label ID="LblCurrentIndex" runat="server"></asp:Label>
                    <asp:Label ID="LblPageCount" runat="server"></asp:Label>
                    <asp:Label ID="LblRecordCount" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp; 跳转到:
                    <asp:DropDownList ID="pageDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="pageDropDownList_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
                <br />
            </div>
        </div>
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
