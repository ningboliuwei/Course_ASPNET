<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminBookAdd.aspx.cs" Inherits="Admin_AdminBookAdd" %>
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
<body id="homepage" style="background-color:Silver">
    <form id="form1" runat="server">
    <div style="float: left">
        
        <uc1:menu_right ID="menu_right1" runat="server" />
        
    </div>
    <div style="height: 77px; width:100%; margin-left: 227px; background-color: Gray">
        
    </div>
    <div style="margin-left: 228px; margin-top: 60px">
        <div id="content" style="margin-left: 150px; ">
            <div>
            
              
                包包名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                            ErrorMessage="输入不能为空！" Display="Dynamic" ValidationGroup="bb"></asp:RequiredFieldValidator>
                <br />
                包类别：<asp:DropDownList ID="DropDownList1" runat="server"  DataTextField="BookTypeName" 
                        DataValueField="BookTypeID">
                </asp:DropDownList>
                <br />
                包单价：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                            ErrorMessage="输入不能为空！" Display="Dynamic" ValidationGroup="bb"></asp:RequiredFieldValidator>
                <br />
                包信息：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                包运费：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                适人群：<asp:DropDownList ID="DropDownList2" runat="server" ValidationGroup="bb">
                    <asp:ListItem Selected="True">男包</asp:ListItem>
                    <asp:ListItem>女包</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                包照片：<asp:FileUpload ID="fileUpload" runat="server"  />
                <br />
                <asp:Button ID="Add" runat="server" Text="添加" Height="19px" onclick="Add_Click" 
                    Width="54px" ValidationGroup="bb"/>
            
              
            </div>
        </div>
    </div>

    
    </form>
</body>
</html>
