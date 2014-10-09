<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<%@ Register Src="menu_right.ascx" TagName="menu_right" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员后台</title>
    <link href="../styles/layout.css" rel="stylesheet" type="text/css" />
    <!-- Theme Start -->
    <link href="../themes/blue/styles.css" rel="stylesheet" type="text/css" />
    <link href="../styles/wysiwyg.css" rel="stylesheet" type="text/css" />
</head>
<body id="homepage" style="background-color: Silver">
    <form id="form1" runat="server">
    <div style="float: left">
        <uc1:menu_right ID="menu_right1" runat="server" />
    </div>
    <div style="height: 77px;width: 100%; margin-left: 227px; background-color: Gray">
    </div>
    <div style="margin-left: 228px; margin-top: 60px">
        <div id="content" 
            
            style="margin-left: 80px; height:800px; background-image: url('../images/建设.jpg'); margin-right: 184px;" >
  
        </div>
    </div>

    </form>
</body>
</html>
