<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="StudentList.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
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
                            <asp:GridView ID="gridStudent" runat="server" Width="100%" 
                                          AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField  HeaderText="序号" />
                                    <asp:BoundField DataField="StudentID" HeaderText="学号" />
                                    <asp:BoundField DataField="Name" HeaderText="姓名" />
                                    <asp:BoundField DataField="Gender" HeaderText="性别" />
                                    <asp:BoundField DataField="DayOfBirth" DataFormatString="{0:yyyy-MM-dd}" 
                                                    HeaderText="出生日期" />
                                    <asp:BoundField DataField="Address" HeaderText="通讯地址" />
                                    <asp:BoundField DataField="Department" HeaderText="系" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                       
                        <td><asp:button ID="btnAdd" runat="server" Text="添加学生" onclick="btnAdd_Click" /></td>
                        
                      
                    </tr>
                    <tr>
                       
                        <td><asp:button ID="btnDelete" runat="server" Text="删除学生" 
                                        onclick="btnDelete_Click" />&nbsp;输入要删除的学生的学号：<asp:textbox ID="txtSno" runat="server"></asp:textbox></td>
                        
                      
                    </tr>
                </table>
            </div>
        </form>
</body>
</html>
