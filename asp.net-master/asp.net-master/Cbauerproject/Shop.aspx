<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Shop.aspx.cs" Inherits="Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <table class="auto-style1">
         <tr>
             <td colspan="2">
                 <asp:Label ID="computerLabel" runat="server" Text="Computer"></asp:Label>
             </td>
             <td colspan="2">
                 <asp:Label ID="laptopLabel" runat="server" Text="Laptop"></asp:Label>
             </td>
             <td colspan="2">
                 <asp:Label ID="phoneLabel" runat="server" Text="Phone"></asp:Label>
             </td>
         </tr>
         <tr>
             <td colspan="2">
                 <asp:Image ID="Image2" src="images/computer.jpg" runat="server" />
             </td>
             <td colspan="2">
                 <asp:Image ID="Image3" src="images/laptop.jpg" runat="server" />
             </td>
             <td colspan="2">
                 <asp:Image ID="Image4" src="images/phone.jpg" runat="server" />
             </td>
         </tr>
         <tr>
             <td>
                 $600</td>
             <td>
                 <asp:CheckBox ID="computerCheckBox" runat="server" Text="purchase" />
             </td>
             <td>
                 $400</td>
             <td>
                 <asp:CheckBox ID="laptopCheckBox" runat="server" Text="purchase" />
             </td>
             <td>
                 $200</td>
             <td>
                 <asp:CheckBox ID="phoneCheckBox" runat="server" Text="purchase" />
             </td>
         </tr>
         <tr>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
             <td>
                 &nbsp;</td>
         </tr>
         <tr>
             <td colspan="2">&nbsp;</td>
             <td colspan="2">
                 <asp:Button ID="placeButton" runat="server" Text="Place order" OnClick="placeButton_Click" />
             </td>
             <td colspan="2">&nbsp;</td>
         </tr>
     </table>


     </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
</asp:Content>
