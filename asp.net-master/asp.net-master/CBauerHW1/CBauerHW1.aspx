<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CBauerHW1.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label3" runat="server" Text="Event name:"></asp:Label>&nbsp;
        <asp:TextBox ID="EventBox" runat="server" OnTextChanged="EventBox_TextChanged"></asp:TextBox>
    &nbsp;
        <asp:Label ID="Label1" runat="server" Text="Menu:"></asp:Label>
    &nbsp;
        <asp:ListBox ID="MenuBox" runat="server" OnSelectedIndexChanged="MenuBox_SelectedIndexChanged">
            <asp:ListItem>Prime Rib</asp:ListItem>
            <asp:ListItem>Chicken</asp:ListItem>
            <asp:ListItem>Pasta</asp:ListItem>
        </asp:ListBox>
        &nbsp;
        <asp:Label ID="Label2" runat="server" Text="Number of guests:"></asp:Label>
        &nbsp;
        <asp:TextBox ID="guestBox" runat="server" EnableViewState="False"></asp:TextBox>
        <p>
            <asp:Button ID="CalcButton" runat="server" OnClick="CalcButton_Click" Text="Calculate" />&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Event:"></asp:Label>
            &nbsp;<asp:Label ID="EventLabel" runat="server" Width="99px"></asp:Label>
&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Charge:"></asp:Label>
&nbsp;<asp:Label ID="ChargeLabel" runat="server"></asp:Label>
        </p>
</body>
</html>
    </form>

