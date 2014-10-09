<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageUploadExercise.aspx.cs"
    Inherits="WEEK05_LAB_DEMO_ImageUploadExercise" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="imgImage" runat="server" Width="400px" BorderWidth="1" />&nbsp;
        <asp:ListBox ID="lstbxImage" runat="server" Width="400px" Height="300px" AutoPostBack="True"
            OnSelectedIndexChanged="lstbxImage_SelectedIndexChanged"></asp:ListBox>
        <br />
        <asp:FileUpload ID="fileUpload" runat="server" />&nbsp;
        <asp:Button ID="btnUpload" runat="server" Text="上传" OnClick="btnUpload_Click" />&nbsp;
        <asp:Button ID="btnRefresh" runat="server" Text="刷新" OnClick="btnRefresh_Click" />
    </div>
    </form>
</body>
</html>
