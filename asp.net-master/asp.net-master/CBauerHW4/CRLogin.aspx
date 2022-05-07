<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CRLogin.aspx.cs" Inherits="CRLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/CR/Orders.aspx">
        </asp:Login>
    
    </div>
    </form>
</body>
</html>
