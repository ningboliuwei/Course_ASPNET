<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileUploadDemo.aspx.cs" Inherits="WEEK05_LECTURE_DEMO_FileUploadDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:FileUpload runat="server" ID="fileUpload1"/><asp:Button runat="server" 
            ID="Button1" Text="上传" onclick="Button1_Click"/>
    </div>
    </form>
</body>
</html>
