<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataListExample.aspx.cs" Inherits="DataListExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="border:#cccccc 1px">
        <div>

            <asp:DataList ID="DataList1" runat="server" Width="700px"
                RepeatDirection="Horizontal" RepeatColumns="3">
                <ItemTemplate>
                    <table style="width: 400px; margin: 20px; padding: 10px;">
                        <tr>
                            <td>学号：</td>
                            <td>
                                <asp:Label runat="server" ID="lblStudentID" Text='<%#Eval("StudentID")%>'></asp:Label></td>
                            <td rowspan="3">
                                <asp:Image runat="server" ID="imgStudent" 
                                    ImageUrl='<%#"images/" + Eval("Photo")%>' /></td>
                        </tr>
                        <tr>
                            <td>姓名：</td>
                            <td>
                                <asp:Label runat="server" ID="lblStudentName" Text='<%#Eval("Name")%>'></asp:Label></td>
                        </tr>
                        <tr>
                            <td>系：</td>
                            <td>
                                <asp:Label runat="server" ID="lblDepartment" Text='<%#Eval("DepartmentName")%>'></asp:Label></td>
                    </table>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <table style="width: 400px; margin: 20px; padding: 10px; background-color: #ccc">
                        <tr>
                            <td>学号：</td>
                            <td>
                                <asp:Label runat="server" ID="lblStudentID" Text='<%#Eval("StudentID")%>'></asp:Label></td>
                            <td rowspan="3">
                                <asp:Image runat="server" ID="imgStudent"
                                    ImageUrl='<%#"images/" + Eval("Photo")%>' /></td>
                        </tr>
                        <tr>
                            <td>姓名：</td>
                            <td>
                                <asp:Label runat="server" ID="lblStudentName" Text='<%#Eval("Name")%>'></asp:Label></td>
                        </tr>
                        <tr>
                            <td>系：</td>
                            <td>
                                <asp:Label runat="server" ID="lblDepartment" Text='<%#Eval("DepartmentName")%>'></asp:Label></td>
                    </table>
                </AlternatingItemTemplate>
            </asp:DataList>

        </div>
    </form>
</body>
</html>
