<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
		<asp:CreateUserWizard ID="CreateUserWizard1" runat="server" CancelDestinationPageUrl="~/Login.aspx" ContinueDestinationPageUrl="~/Login.aspx" FinishDestinationPageUrl="~/Login.aspx">
			<WizardSteps>
				<asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
				</asp:CreateUserWizardStep>
				<asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
				</asp:CompleteWizardStep>
			</WizardSteps>
		</asp:CreateUserWizard>
    <div>
    
    </div>
    </form>
</body>
</html>
