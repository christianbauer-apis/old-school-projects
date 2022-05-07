<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 402px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Welcome to ASP Design</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/CRLogin.aspx">CR Employee Login</asp:HyperLink>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/MarketLogin.aspx">Marketing Employee login</asp:HyperLink>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
               
                   

                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
               
                   

                <td class="auto-style2">CR Login user: bauer&nbsp;&nbsp; password: bauer1*</td>
            </tr>
            <tr>
               
                   

                <td class="auto-style2">marketing login user: christian&nbsp;&nbsp; password: christian*</td>
            </tr>
        </table>
    </form>
</body>
</html>
