<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginUserControlExample.aspx.cs" Inherits="LoginUserControlExample" %>

<%@ Register src="ucLogin.ascx" tagname="ucLogin" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
    
            </div>
            <uc1:ucLogin ID="ucLogin1" runat="server" />
            <!--<uc1:ucLogin ID="ucLogin2" runat="server" />-->
       
        </form>
    </body>
</html>