<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <p>姓名：<asp:TextBox runat="server" ID="txtName" /></p>
        <p>密码：<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/></p>
        <p>性别：<asp:RadioButton runat="server" ID="rdoMale" GroupName="sexGroup" Text="男" Checked="true"/><asp:RadioButton runat="server" ID="rdoFemale" GroupName="sexGroup" Text="女"/></p>
        <p>职业<asp:DropDownList ID="dplJob" runat="server">
            <asp:ListItem>教师</asp:ListItem>
            <asp:ListItem>学生</asp:ListItem>
            <asp:ListItem>工人</asp:ListItem>
            <asp:ListItem>农民</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>爱好：<asp:CheckBox ID="chkReading" runat="server" Text="阅读" /><asp:CheckBox ID="chkSing" runat="server" Text="唱歌" /><asp:CheckBox ID="chkDance" runat="server" Text="跳舞" /></p>
        <p>个人简介：<br/><asp:TextBox ID="txtResume" runat="server" TextMode="MultiLine" 
                Height="100px" Width="400px" /></p>
        <p><asp:Button runat="server" ID="btnOK" Text="注册" onclick="btnOK_Click" /></p>
    </div>
    </form>
</body>
</html>
