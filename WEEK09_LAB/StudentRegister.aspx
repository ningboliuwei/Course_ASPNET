<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegister.aspx.cs"
         Inherits="基本ADONET对象的使用._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>学生注册</title>
    </head>
    <body bgcolor="lightblue">
        <form id="form1" runat="server">
            <div style="border: #ccc solid 1px; width: 500px; margin: auto;">
                <table width="100%" border="0" align="center" bgcolor="lightpink">
                    <tr>
                        <th colspan="2" align="center">
                            学生注册
                        </th>
                    </tr>
                    <tr>
                        <td width="150px">
                            学号：
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtStudentID" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            姓名：
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtStudentName" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            出生日期：
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="txtDayOfBirth" Width="200px"></asp:TextBox>&nbsp;
                            <asp:Button ID="btnShowCalender" runat="server" Text="↓" OnClick="btnShowCalender_Click" />
                            <asp:Calendar ID="calDayOfBirth" Width="300px" runat="server" Visible="False" OnSelectionChanged="calDayOfBirth_SelectionChanged">
                            </asp:Calendar>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            性别：
                        </td>
                        <td>
                            <asp:RadioButton ID="radMale" Text="男" runat="server" Checked="true" GroupName="Gender" />
                            <asp:RadioButton ID="radFemale" Text="女" runat="server" GroupName="Gender" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            专业：
                        </td>
                        <td>
                            <asp:DropDownList ID="dropDepartment" runat="server" Width="300px">
                                <asp:ListItem runat="server">计算机科学与技术</asp:ListItem>
                                <asp:ListItem runat="server">软件工程</asp:ListItem>
                                <asp:ListItem runat="server">电子信息工程</asp:ListItem>
                                <asp:ListItem runat="server">电子信息科学与技术</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            通讯地址：
                        </td>
                        <td>
                            <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Height="100px" Width="300px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblInfo" runat="server" Width="100%"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:Button runat="server" ID="btnRegister" Text="注册" OnClick="btnRegister_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </body>
</html>