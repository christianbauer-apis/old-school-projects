<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MarketLogin.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/marketing/Marketing.aspx">
        </asp:Login>
    
    </div>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Register.aspx">register</asp:HyperLink>
    </form>
</body>
</html>
