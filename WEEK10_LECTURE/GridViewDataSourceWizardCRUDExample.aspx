<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewDataSourceWizardCRUDExample.aspx.cs" Inherits="GridViewDataSourceWizardCRUDExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
            <asp:GridView ID="gridview1" runat="server"></asp:GridView>
            <asp:Button ID="btnInsert" runat="server" Text="插入" OnClick="btnInsert_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="修改" OnClick="btnUpdate_Click" />
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:schooldbConnectionString %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>
    </form>
</body>
</html>
