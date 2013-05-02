<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminBook_order.aspx.cs"
    Inherits="Admin_AdminBook_order" %>

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
    <div style="height: 77px;width:100%; margin-left: 227px; background-color: Gray">
    </div>
    <div style="margin-left: 228px; margin-top: 60px">
        <div id="content" style="margin-left: 150px">
            <div>
                <p>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Selected="True">全部</asp:ListItem>
                        <asp:ListItem>女包</asp:ListItem>
                        <asp:ListItem>男包</asp:ListItem>
                    </asp:DropDownList>
                    <asp:ImageButton ID="BtnSearch" runat="server" ImageUrl="~/images/搜索.jpg" 
                        OnClick="BtnSearch_Click" />
                </p>
                <div>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                        AutoGenerateColumns="False" Height="280px" Style="margin-left: 0px; margin-right: 41px;"
                        Width="720px" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting"
                        OnRowCommand="GridView1_RowCommand">
                        <PagerSettings Visible="False" />
                        <Columns>
                            <asp:BoundField HeaderText="订单编号" DataField="BookOrderID" Visible="false" />
                            <asp:ButtonField DataTextField="BookName" HeaderText="包包信息" CommandName="show" />
                            <asp:BoundField DataField="BookPrice" HeaderText="包包单价" />
                            <asp:BoundField DataField="BookCount" HeaderText="包包数量" />
                            <asp:BoundField DataField="BookCountPrice" HeaderText="包包总价" />
                            <asp:BoundField DataField="UserInfoName" HeaderText="购买用户" />
                            <asp:BoundField DataField="Datatime" HeaderText="订单时间" />
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="true" ></asp:CommandField>
                        </Columns>
                    </asp:GridView>
                    <asp:LinkButton ID="btnFirst" CommandArgument="first" OnClick="PagerButtonClick"
                        runat="server">首 页</asp:LinkButton>
                    <asp:LinkButton ID="btnPrev" CommandArgument="prev" OnClick="PagerButtonClick" runat="server">上一页</asp:LinkButton>
                    <asp:LinkButton ID="btnNext" CommandArgument="next" OnClick="PagerButtonClick" runat="server">下一页</asp:LinkButton>
                    <asp:LinkButton ID="btnLast" CommandArgument="last" OnClick="PagerButtonClick" runat="server">尾 页</asp:LinkButton>
                    <asp:Label ID="LblCurrentIndex" runat="server"></asp:Label>
                    <asp:Label ID="LblPageCount" runat="server"></asp:Label>
                    <asp:Label ID="LblRecordCount" runat="server"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp; 跳转到:
                    <asp:DropDownList ID="pageDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="pageDropDownList_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                </div>
            </div>
        </div>    	

    
    </form>
</body>
</html>
