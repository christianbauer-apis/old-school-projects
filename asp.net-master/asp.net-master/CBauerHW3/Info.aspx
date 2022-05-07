<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Info.aspx.cs" Inherits="Info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="Server">

    <table style="width: 100%; height: 780px;">
        <tr>
            <td>
                <asp:Image ID="Image2" runat="server"  ImageUrl="~/Images/stress.jpg" />
            </td>
            <td>This session helps you manage stressful situations.<br />
                Fee is $200 per person.</td>
        </tr>
        <tr>
            <td>
                <asp:Image ID="Image3" runat="server"   ImageUrl="~/Images/time.jpg" Width="301px"/>
            </td>
            <td>This session helps you manage your time.<br />
                Fee is $150 per person.</td>
        </tr>
        <tr>
            <td>
                <asp:Image ID="Image4" runat="server"  ImageUrl="~/Images/supervision.jpg" Width="302px"/>
            </td>
            <td>This session teaches you how to supervise your employees<br />
                Fee is $400 per person.</td>
        </tr>
        <tr>
            <td>
                <asp:Image ID="Image5" runat="server"  ImageUrl="~/Images/negotiation.jpg" Height="281px" Width="303px" />
            </td>
            <td>This session teaches you how to better negotiate deals.<br />
                Fee is $500 per person.</td>
        </tr>
    </table>

</asp:Content> 

 <asp:Content ID="Content2" ContentPlaceHolderID="RightContent" Runat="Server">
                    
                </asp:Content>
