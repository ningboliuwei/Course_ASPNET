<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DisplayExample.aspx.cs" Inherits="Temp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator
        ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" Display="Dynamic" ErrorMessage="请输入年龄"></asp:RequiredFieldValidator><asp:RangeValidator
            ID="RangeValidator1" runat="server"  ControlToValidate="TextBox1" MinimumValue="0" MaximumValue="120" Type="Integer" ErrorMessage="年龄的范围必须在0~120之间"></asp:RangeValidator>
   <br/> <asp:Button ID="Button1" runat="server" Text="确定" 
        onclick="Button1_Click" />
        <asp:Button runat="server" ID="btnReset" Text="重置" CausesValidation="False"/>
        
    </form>
    
</body>
</html>
