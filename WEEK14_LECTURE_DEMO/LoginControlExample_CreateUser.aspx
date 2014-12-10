<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginControlExample_CreateUser.aspx.cs" Inherits="LoginControlExample_CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
			<WizardSteps>
				<asp:CreateUserWizardStep runat="server" />
				<asp:CompleteWizardStep runat="server" />
			</WizardSteps>
		</asp:CreateUserWizard>
    
    </div>
    </form>
</body>
</html>
