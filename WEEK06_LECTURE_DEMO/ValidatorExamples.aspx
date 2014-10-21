<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidatorExamples.aspx.cs"
    Inherits="ValidatorExamples" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        账号：<asp:TextBox runat="server" ID="txtAccount" MaxLength="12"></asp:TextBox><asp:RequiredFieldValidator
            ID="rfvAccount" ControlToValidate="txtAccount" runat="server" ErrorMessage="请输入账号"></asp:RequiredFieldValidator><br />
        <br />
        密码：<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br />
        确认密码：<asp:TextBox ID="txtPasswordConfirm" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="cvPassword" runat="server" ControlToCompare="txtPassword"
            ControlToValidate="txtPasswordConfirm" ErrorMessage="密码与确认密码不一致" Type="Integer"></asp:CompareValidator><br />
        <br />
        年龄：<asp:TextBox ID="txtAge" runat="server"></asp:TextBox><asp:RangeValidator ID="rvAge"
            runat="server" ControlToValidate="txtAge" ErrorMessage="年龄必须在0-100岁之间" MaximumValue="100"
            MinimumValue="0" Type="Integer"></asp:RangeValidator><br />
        <br />
        性别：<asp:DropDownList runat="server" ID="dplGender">
            <asp:ListItem>请选择性别</asp:ListItem>
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator
            ID="rfvGender" ControlToValidate="dplGender" runat="server" ErrorMessage="请选择“男”或“女”" InitialValue="请选择性别" /><br />
        <br />
        电子邮件：<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><asp:RequiredFieldValidator
            ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic"
            ErrorMessage="请输入电子邮件"></asp:RequiredFieldValidator><asp:RegularExpressionValidator
                ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="email地址不合法"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />
        <br />
        固定电话：<asp:TextBox ID="txtTel" runat="server"></asp:TextBox><asp:RegularExpressionValidator
            ID="revTel" runat="server" ControlToValidate="txtTel" ErrorMessage="电话号码格式不合法"
            ValidationExpression="(\(\d{3,4}\)|\d{3,4}-)?\d{7,8}$"></asp:RegularExpressionValidator><br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            ShowMessageBox="True" />
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="注册" />
    </div>
    </form>
</body>
</html>
