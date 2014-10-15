<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomValidatorExample.aspx.cs" Inherits="CustomValidatorExample" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" ID="txtEvenNumber"></asp:TextBox><br/>
        <asp:CustomValidator ID="cvEvenNumber" ControlToValidate="txtEvenNumber" 
            runat="server" ErrorMessage="这不是一个偶数" 
            onservervalidate="cvEvenNumber_ServerValidate"></asp:CustomValidator><br/>
        <asp:Button ID="btnSubmit" runat="server" Text="确定" />
        <asp:RangeValidator ID="rvGrade" runat="server" ControlToValidate="txtGrade" MaximumValue="100" MinimumValue="0" Type="Integer"/>
        <asp:CompareValidator ID="cvPassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPasswordAgain" Text="密码与确认密码不一致！"/>
        <asp:RegularExpressionValidator ID="revMail" runat="server" ControlToValidate="txtMail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Text="必须为合法的E-mail地址"/>
    </div>
    </form>
</body>
</html>
