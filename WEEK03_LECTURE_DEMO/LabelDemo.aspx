<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LabelDemo.aspx.cs" Inherits="LabelDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label runat="server" BorderColor="#CCCCCC" BorderStyle="Dashed" BorderWidth="2"  Text="Hello"></asp:Label>
     <asp:Label ID="Label1" runat="server" ForeColor="yellow" BackColor="lightblue" Text="Hello"></asp:Label>
     <asp:Label runat="server" Text="微软" Font-Size="50pt" Font-Names="宋体" 
            Font-Overline="True" ondatabinding="Unnamed2_DataBinding"></asp:Label>
    <asp:TextBox runat="server" ID="TextBox1" ontextchanged="TextBox1_TextChanged" MaxLength="3"></asp:TextBox>
        <asp:Button ID="btnDelete" runat="server" Text="Button" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <asp:CheckBoxList  ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
        <asp:CheckBox ID="CheckBox1" runat="server" />
    <asp:Button runat="server"/>
    <asp:LinkButton runat="server"></asp:LinkButton>
    <asp:ImageButton runat="server" ImageUrl=""/>
       
<asp:radiobutton ID="Radiobutton1" runat="server" 
            oncheckedchanged="Radiobutton1_CheckedChanged"></asp:radiobutton>
          
            <asp:DropDownList runat="server" ID="DropDownList1" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="a" Value="1"></asp:ListItem>
                 <asp:ListItem Text="b" Value="2"></asp:ListItem>
                  <asp:ListItem Text="c" Value="3"></asp:ListItem>
            
            </asp:DropDownList>
    </div>
    </form>
</body>
</html>
