<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageUploadDemo.aspx.cs" Inherits="WEEK05_LECTURE_DEMO_ImageUploadDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="上传" />
        <br />
        <asp:Image ID="Image1" runat="server" Width="600px" />
    
    </div>
    </form>
</body>
</html>
