<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButtonListDemo.aspx.cs" Inherits="WEEK03_LECTURE_DEMO.RadioButtonListDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        for (int i = 0; i < RadioButtonList1.Items.Count; i++)
        {
            if (RadioButtonList1.Items[i].Selected == true)
            {
                Label1.Text = RadioButtonList1.Items[i].Text;
            }
        }
    }

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head runat="server">
        <title>无标题页</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
    
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                     onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:RadioButtonList>
    
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
            </div>
        </form>
    </body>
</html>