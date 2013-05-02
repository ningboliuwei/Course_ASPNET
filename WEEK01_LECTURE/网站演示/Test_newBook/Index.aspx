<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="_Default" %>

<%@ Register TagPrefix="uc1" TagName="TopControl" Src="~/TopControl.ascx" %>
<%@ Register Src="BottomControl.ascx" TagName="BottomControl" TagPrefix="uc2" %>
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
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:TopControl ID="TopControl1" runat="server" />
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
            <div id="templatemo_content_left">
                <div class="templatemo_post_wrapper">
                    <div class="post_title">
                        包包展示</div>
                    <div class="post_info">
                        <a href="#"></a>
                    </div>
                    <asp:DataList ID="DataList1" runat="server" DataKeyField="BookID" RepeatColumns="3"
                        RepeatDirection="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                        BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <ItemTemplate>
                            <table width="200px">
                                <tr>
                                    <td align="center" colspan="2">
                                        <asp:Image ID="imgBook" runat="server" Height="140px" ImageUrl='<%#"Admin/upload/" + Eval("BookPhoto")%>'
                                            Width="140px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        &nbsp;&nbsp;&nbsp; <a href='Book_Detail.aspx?id=<%# DataBinder.Eval(Container.DataItem,"BookID") %>&amp;price=<%#DataBinder.Eval(Container.DataItem,"BookPrice")%>'>
                                            <%#DataBinder.Eval(Container.DataItem, "BookInformation")%>
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span style="color: #ff7f50">&nbsp;&nbsp;&nbsp;￥</span><asp:Label ID="lbPrice" runat="server"
                                            Text='<%#Eval("BookPrice")%>' />
                                    </td>
                                    <td style="font-size: 10px">
                                        运费：<asp:Label ID="lbFare" runat="server" Text='<%#Eval("BookFare")%>' />
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                    <div class="post_comment">
                        &nbsp;</div>
                </div>
                <!-- End of a post-->
                <!-- End of a post-->
            </div>
            <!-- end of content left -->
            <div id="templatemo_content_right">
                <div class="temp">
                    <div class="templatemo_right_section" style="float: left">
                        <asp:TextBox ID="TextBox1" runat="server" Width="92px"></asp:TextBox>
                        <asp:DropDownList ID="DropDownList2" runat="server" DataTextField="BookTypeName"
                            DataValueField="BookTypeID" Width="90px">
                        </asp:DropDownList>
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="57px">
                            <asp:ListItem Selected="True">全部</asp:ListItem>
                            <asp:ListItem>女包</asp:ListItem>
                            <asp:ListItem>男包</asp:ListItem>
                        </asp:DropDownList>
                        <asp:ImageButton ID="BtnSearch" runat="server" ImageUrl="~/images/搜索.jpg" OnClick="BtnSearch_Click" />
                    </div>
                    <div class="templatemo_right_section">
                        <asp:ImageButton ID="ImgRegister" runat="server" ImageUrl="images/免费注册.jpg" OnClick="ImgRegister_Click" />
                        <asp:ImageButton ID="ImgLogin" runat="server" ImageUrl="images/登录.jpg" Height="32px"
                            Width="91px" OnClick="ImgLogin_Click" />
                    </div>
                    <div class="templatemo_right_section">
                        <h2>
                            Popular Posts</h2>
                        <ul>
                            <li><a href="#">ASP.NET 作业</a></li>
                            <li><a href="#">老师是刘慰</a></li>
                            <li><a href="#">我是袁坚</a></li>
                            <li><a href="#">这是我的网站前台</a></li>
                            <li><a href="#">也就是我的首页</a></li>
                        </ul>
                    </div>
                    <div class="templatemo_right_section">
                        <h2>
                            Archives</h2>
                        <ul>
                            <li><a href="#">ASP.NET 作业</a></li>
                            <li><a href="#">老师是刘慰</a></li>
                            <li><a href="#">我是袁坚</a></li>
                            <li><a href="#">这是我的网站前台</a></li>
                            <li><a href="#">也就是我的首页</a></li>
                        </ul>
                    </div>
                    <div class="templatemo_right_section">
                        <h2>
                            Recent Comments</h2>
                        <ul>
                            <li><a href="#">ASP.NET 作业</a></li>
                            <li><a href="#">老师是刘慰</a></li>
                            <li><a href="#">我是袁坚</a></li>
                            <li><a href="#">这是我的网站前台</a></li>
                            <li><a href="#">也就是我的首页</a></li>
                        </ul>
                    </div>
                </div>
                <!-- end of right content -->
            </div>
            <!-- end of content -->
        </div>
    </div>
    <div id="templatemo_bottom_panel">
        <div id="templatemo_bottom_section">
        </div>
    </div>
    <!-- end of templatemo bottom panel -->
    <div id="templatemo_footer_panel">
        <div id="templatemo_footer_section">
            <uc2:BottomControl ID="BottomControl1" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
