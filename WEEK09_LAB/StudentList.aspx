<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="基本ADONET对象的使用.StudentList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>学生列表</title>
    </head>
    <body bgcolor="lightblue">
        <form id="form1" runat="server">
            <div style="border: #ccc solid 1px; width: 800px; margin: auto;">
                <table width="100%" border="0" align="center" bgcolor="lightpink">
                    <tr>
                        <th>
                            学生列表：
                        </th>
                    </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="gridStudent" runat="server" Width="100%">
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <p>
                                <a href='StudentRegister.aspx'>学生注册</a></p>
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </body>
</html>