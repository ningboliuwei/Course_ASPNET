<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDownListExercise.aspx.cs"
    Inherits="WEEK05_LAB_DEMO_DropDownListExercise" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            要添加的项目的Text属性值
            <asp:TextBox ID="txtItemText" runat="server" Width="208px" Height="24px" MaxLength="20"></asp:TextBox></p>
        <p>
            要添加的项目的Value属性值
            <asp:TextBox ID="txtItemValue" runat="server" Width="208px" Height="24px" MaxLength="5"></asp:TextBox></p>
        <p>
            <asp:DropDownList ID="dplItems" runat="server" Width="208px" AutoPostBack="True"
                OnSelectedIndexChanged="dplItems_SelectedIndexChanged">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblInfo" runat="server" ForeColor="#C00000"></asp:Label></p>
        <p>
            <asp:Button ID="btnAdd" runat="server" Text="添加" Width="80px" Height="24px" OnClick="btnAdd_Click">
            </asp:Button>
            <asp:Button ID="btnDelete" runat="server" Text="删除当前项" Width="80px" Height="24px"
                OnClick="btnDelete_Click"></asp:Button>
            <asp:Button ID="btnClear" runat="server" Text="清除所有项" Width="80px" Height="24px"
                OnClick="btnClear_Click"></asp:Button>
        </p>
    </div>
    </form>
</body>
</html>
