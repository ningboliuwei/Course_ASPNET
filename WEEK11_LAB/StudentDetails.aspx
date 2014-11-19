<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentDetails.aspx.cs" Inherits="StudentDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            学生详细信息
            <div style="margin: auto;">
    
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                                 width="700px">
                    <Fields>
                        <asp:BoundField HeaderText="学号" DataField="StudentID" />
                        <asp:BoundField HeaderText="姓名" DataField="Name"/>
                        <asp:BoundField HeaderText="性别" DataField="Gender"/>
                        <asp:BoundField HeaderText="出生日期" DataField="DayOfBirth" DataFormatString="{0:yyyy-MM-dd}"/>
                        <asp:BoundField HeaderText="地址" DataField="Address"/>
                        <asp:BoundField HeaderText="系" DataField="DepartmentName"/>
                        <asp:ImageField HeaderText="照片" DataImageUrlField="Photo" 
                                        DataImageUrlFormatString="images\{0}">
                        </asp:ImageField>
                    </Fields>
                </asp:DetailsView>
    
            </div>
        </form>
</body>
</html>
