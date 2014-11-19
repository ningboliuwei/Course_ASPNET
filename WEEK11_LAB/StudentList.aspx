<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentList.aspx.cs" Inherits="StudentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div style="width: 700px; margin: auto; border: solid 2px">
                <div style="text-align: center"><div>学生信息列表</div>
                    <div><asp:GridView ID="gridStudent" runat="server" Width="100%"  
                                       AutoGenerateColumns="False" AllowPaging="True" 
                                       onpageindexchanging="gridStudent_PageIndexChanging"  >
                             <Columns>
                                 <asp:BoundField HeaderText="序号" />
                                 <asp:BoundField DataField="StudentID" HeaderText="学号" />
                                 <asp:HyperLinkField HeaderText="姓名" DataTextField="Name" 
                                                     DataNavigateUrlFields="StudentID" 
                                                     DataNavigateUrlFormatString="StudentDetails.aspx?id={0}"/>
                                 <asp:BoundField DataField="ClassName" HeaderText="系"  />
                                 <asp:ImageField HeaderText="照片" DataImageUrlField="Photo" 
                                                 DataImageUrlFormatString="images/{0}">
                                     <ControlStyle Height="50px" />
                                 </asp:ImageField>
                             </Columns>
                         </asp:GridView></div><div><a href="AddStudent.aspx">添加学生</a></div></div>
            </div>
        </form>
    </body>
</html>