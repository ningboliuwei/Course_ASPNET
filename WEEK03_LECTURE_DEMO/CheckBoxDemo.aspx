<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBoxDemo.aspx.cs" Inherits="" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="lblInfo" runat="server"></asp:Label>

        </div>
        <asp:CheckBox ID="chxFootball" runat="server" AutoPostBack="True"
            Text="足球" />
        <asp:CheckBox ID="chxBasketball" runat="server" AutoPostBack="True"
            Text="篮球" />
        <br />
        <asp:Button ID="btnDisplay" runat="server" OnClick="Button1_Click" Text="显示" />
    </form>
</body>
</html>
