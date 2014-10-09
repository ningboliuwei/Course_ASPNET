<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminBook_type.aspx.cs" Inherits="AdminBook_type" %>
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
    <div style="height: 77px;width: 100%; margin-left: 227px; background-color: Gray">
    </div>
    <div style="margin-left:350px; margin-top: 60px">
        <div id="content" style="margin-left: 20px">
            <div>
                <a href="AdminType_add.aspx">添加类别</a>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                    AllowSorting="True" AutoGenerateColumns="False" Height="280px" 
                    onrowcommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" 
                    OnRowDeleting="GridView1_RowDeleting" 
                    Style="margin-left: 0px; margin-right: 41px;" Width="720px">
                    <PagerSettings Visible="False" />
                    <Columns>
                        <asp:BoundField DataField="BookTypeID" HeaderText="商品类别Id"  />
                         <asp:BoundField DataField="BookTypeName" HeaderText="类别信息"  />
 
                        <asp:CommandField HeaderText="删除" ShowDeleteButton="true" />
                        <asp:ButtonField CommandName="Modify" HeaderText="修改" Text="修改" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>    

    
    </form>
</body>
</html>
