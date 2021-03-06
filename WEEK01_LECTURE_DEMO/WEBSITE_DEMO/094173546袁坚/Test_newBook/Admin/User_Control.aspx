﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User_Control.aspx.cs" Inherits="Admin_User_Control" %>

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
    <div style="height: 77px; width: 100%; margin-left: 227px; background-color: Gray">
    </div>
    <div style="margin-left: 228px; margin-top: 160px">
        <div id="content" style="margin-left: 150px">
            <div>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                    AutoGenerateColumns="False" Height="280px" Style="margin-left: 0px; margin-right: 41px;"
                    Width="720px" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting"
                    OnRowCommand="GridView1_RowCommand">
                    <PagerSettings Visible="False" />
                    <Columns>
                        <asp:BoundField HeaderText="id" DataField="userid" Visible="false"/>
                        <asp:BoundField HeaderText="姓名" DataField="Name" />
                        <asp:BoundField DataField="Sex" HeaderText="性别" />
                        <asp:CommandField HeaderText="删除" ShowDeleteButton="true"></asp:CommandField>
                        <asp:ButtonField DataTextField="Name" HeaderText="姓名" CommandName="show" Visible="false" />
                    </Columns>
                </asp:GridView>
                <a href="Admin_Addperson.aspx">用户添加</a>
            </div>
        </div>
    </div>
    	<script type='text/javascript' src='../scripts/enhance.js'></script>
    <script type='text/javascript' src='../scripts/excanvas.js'></script>
    <script type="text/javascript" src='../scripts/jquery.min.js'></script>
     <script type="text/javascript" src='../scripts/jquery-ui.min.js'></script>
	<script type='text/javascript' src='../scripts/jquery.wysiwyg.js'></script>
    <script type='text/javascript' src='../scripts/visualize.jQuery.js'></script>
    <script type="text/javascript" src='../scripts/functions.js'></script>
    </form>
</body>
</html>
