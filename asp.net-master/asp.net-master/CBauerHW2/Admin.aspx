<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 168px;
            text-align: right;
        }
        .auto-style3
        {
            width: 168px;
            text-align: right;
            height: 25px;
        }
        .auto-style4
        {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Admin Page<table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Homepage</asp:HyperLink>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Revenues:</td>
                <td class="auto-style4">
                    <asp:Label ID="revenueLabel" runat="server" Text="$0.00"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Sales</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">pens:</td>
                <td>
                    <asp:Label ID="penLabel" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">mouse pads:</td>
                <td>
                    <asp:Label ID="mouseLabel" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">picture frame:</td>
                <td>
                    <asp:Label ID="pictureLabel" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">mugs:</td>
                <td>
                    <asp:Label ID="mugLabel" runat="server" Text="0"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Customer Details:</td>
                <td>
                    <asp:ListBox ID="detailsListBox" runat="server"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
