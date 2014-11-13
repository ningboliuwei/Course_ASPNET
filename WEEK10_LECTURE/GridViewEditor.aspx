<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewEditor.aspx.cs" Inherits="GridViewEditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" 
                              onselectedindexchanged="GridView1_SelectedIndexChanged" 
                              onrowcancelingedit="GridView1_RowCancelingEdit" 
                              onrowdeleting="GridView1_RowDeleting" 
                              onrowupdating="GridView1_RowUpdating" 
                    onrowediting="GridView1_RowEditing" >
                    <Columns>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
                <asp:label runat="server" ID="lblInfo"></asp:label>
    </form>
</body>
</html>
