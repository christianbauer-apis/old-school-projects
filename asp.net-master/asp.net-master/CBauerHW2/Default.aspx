<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 310px;
            height: 163px;
        }
        .auto-style3 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="welcomeLabel" runat="server" Text=""></asp:Label>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <img alt="asp" class="auto-style2" src="images/index.png" /></td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="OrderHyperLink" runat="server" NavigateUrl="~/Order.aspx">Order</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="AdminHyperLink" runat="server" NavigateUrl="~/Admin.aspx">Admin</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
