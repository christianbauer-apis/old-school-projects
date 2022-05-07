
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:createuserwizard runat="server" ContinueDestinationPageUrl="Login.aspx"> <WizardSteps> <asp:CreateUserWizardStep runat="server"/> <asp:CompleteWizardStep runat="server"/> </WizardSteps> </asp:createuserwizard>

    </div>
    </form>
</body>
</html>
