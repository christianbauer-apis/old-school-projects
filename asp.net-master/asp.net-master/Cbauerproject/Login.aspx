
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:login runat="server" DestinationPageUrl="OrderDetails.aspx"></asp:login>

        <br />
        username: abc123&nbsp;&nbsp; password: abc123*<br />

        <br />
        not registered? login in
        <asp:HyperLink ID="HyperLink1" NavigateUrl="Register.aspx" runat="server">here</asp:HyperLink>

    </div>
    </form>
</body>
</html>
