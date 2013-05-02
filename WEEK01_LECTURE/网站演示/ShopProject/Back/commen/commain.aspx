<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="commain.aspx.cs" Inherits="ShopProject.Back.commen.commain" %>
<%@ Register TagPrefix="uc5" TagName="left" Src="~/Back/用户控件/commen.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" href="../../css/left.css" type="text/css" media="screen" />
<script type="text/javascript" src="/js/left/jquery-1.3.2.min.js"></script><script type="text/javascript" src="/js/left/simpla.jquery.configuration.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <div style="width: 230px;float:left;height:100%">
           <uc5:left runat="server" ID="left_UserGuan"/>
        </div>
 
         <div style="margin: 0 30px 0 260px;height:100%;">
             <iframe height="100%" width="100%" scrolling="auto" frameborder="0" name="right">
         </iframe> 
    </div>
    </div>
    </form>
</body>
</html>
