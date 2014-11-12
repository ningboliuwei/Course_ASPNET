<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewDataSourceWizardCRUDExample.aspx.cs" Inherits="GridViewDataSourceWizardCRUDExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridview1" runat="server" AutoGenerateColumns="False" DataKeyNames="Sno" DataSourceID="SqlDataSource1" EnableModelValidation="True">
                <Columns>
                    <asp:BoundField DataField="Sno" HeaderText="Sno" ReadOnly="True" SortExpression="Sno" />
                    <asp:BoundField DataField="Sname" HeaderText="Sname" SortExpression="Sname" />
                    <asp:BoundField DataField="Ssex" HeaderText="Ssex" SortExpression="Ssex" />
                    <asp:BoundField DataField="Sage" HeaderText="Sage" SortExpression="Sage" />
                    <asp:BoundField DataField="Sdept" HeaderText="Sdept" SortExpression="Sdept" />
                </Columns>
            </asp:GridView>
            <asp:Button ID="btnInsert" runat="server" Text="插入" OnClick="btnInsert_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="修改" OnClick="btnUpdate_Click" />
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:schooldbConnectionString %>" SelectCommand="SELECT * FROM [Student]" DeleteCommand="DELETE FROM [Student] WHERE [Sno] = @Sno" InsertCommand="INSERT INTO [Student] ([Sno], [Sname], [Ssex], [Sage], [Sdept]) VALUES (@Sno, @Sname, @Ssex, @Sage, @Sdept)" UpdateCommand="UPDATE [Student] SET [Sname] = @Sname, [Ssex] = @Ssex, [Sage] = @Sage, [Sdept] = @Sdept WHERE [Sno] = @Sno">
            <DeleteParameters>
                <asp:Parameter Name="Sno" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="txtSno" Name="Sno" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="txtSname" Name="Sname" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="txtSsex" Name="Ssex" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="txtSage" Name="Sage" PropertyName="Text" Type="Int32" />
                <asp:ControlParameter ControlID="txtSdept" Name="Sdept" PropertyName="Text" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter ControlID="txtSname" Name="Sname" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="txtSsex" Name="Ssex" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="txtSage" Name="Sage" PropertyName="Text" Type="Int32" />
                <asp:ControlParameter ControlID="txtSdept" Name="Sdept" PropertyName="Text" Type="String" />
                <asp:ControlParameter ControlID="txtSno" Name="Sno" PropertyName="Text" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <table width="300" border="1">
            <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="txtSno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="txtSname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="txtSsex" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="txtSage" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="txtSdept" runat="server"></asp:TextBox></td>
            </tr>
        </table>
    </form>
</body>
</html>
