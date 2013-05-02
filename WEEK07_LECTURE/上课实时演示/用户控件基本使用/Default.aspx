<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="用户控件基本使用._Default" %>

<%@ Register src="ucLogin.ascx" tagname="ucLogin" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:ucLogin ID="ucLogin1" runat="server" /><br/>
        <uc1:ucLogin ID="ucLogin2" runat="server" /><br/>
        <uc1:ucLogin ID="ucLogin3" runat="server" />
    
    </div>
    </form>
</body>
</html>
