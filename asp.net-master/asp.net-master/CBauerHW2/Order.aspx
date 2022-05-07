<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 139px;
            text-align: right;
        }
        .auto-style3 {
            width: 139px;
            text-align: right;
            height: 30px;
        }
        .auto-style4 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Order Page&nbsp; </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Homepage</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Name:</td>
                <td class="auto-style4">
                    <asp:TextBox ID="nameTextBox" runat="server" OnTextChanged="nameTextBox_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nameTextBox" ErrorMessage="Enter Your name">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Phone Number:</td>
                <td>
                    <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="phoneTextBox" Display="Dynamic" ErrorMessage="the phone number as (999) 999-9999" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">Please submit the phone number as (999) 999-9999</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="phoneTextBox" ErrorMessage="enter your phone number"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">credit card number:</td>
                <td>
                    <asp:TextBox ID="creditCardTextBox" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="creditCardTextBox" Display="Dynamic" ErrorMessage="Invalid card number" ValidationExpression="\d{16}">Enter your sixteen digit card number</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="creditCardTextBox" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Item:</td>
                <td>
                    <asp:ListBox ID="itemListBox" runat="server" OnSelectedIndexChanged="itemListBox_SelectedIndexChanged">
                        <asp:ListItem>Pen</asp:ListItem>
                        <asp:ListItem>Mouse pad</asp:ListItem>
                        <asp:ListItem>Picture Frame</asp:ListItem>
                        <asp:ListItem>Mug</asp:ListItem>
                    </asp:ListBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="itemListBox" ErrorMessage="Select an item">Select an item</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Item Text:</td>
                <td>
                    <asp:TextBox ID="itemTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="itemTextBox" ErrorMessage="Enter a text">Enter text</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Quantity:</td>
                <td>
                    <asp:TextBox ID="quantityTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="quantityTextBox" ErrorMessage="Enter a valid number">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="quantityTextBox" ErrorMessage="Enter a valid number" MaximumValue="999999" MinimumValue="1">Enter a valid number</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Order Details:</td>
                <td>
                    <asp:Label ID="orderLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="addOrderButton" runat="server" Text="Add to Order" OnClick="addOrderButton_Click" />
                </td>
                <td>
                    <asp:Button ID="completeOrderButton" runat="server" OnClick="cmdStore_Click" Text="Complete Order" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
