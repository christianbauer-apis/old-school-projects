<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Registrations.aspx.cs" Inherits="Registrations" StylesheetTheme="registration" %>


<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="Server">

    <table style="width: 123%; height: 155px">
        <tr>
            <td style="width: 86px">Name:</td>
            <td style="width: 163px">
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 200px">Number of people:</td>
            <td style="width: 163px">
                <asp:TextBox ID="numberTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="numberTextBox" ErrorMessage="Enter a value between 1 to 10" MinimumValue="1" MaximumValue="10"
                    Type="Integer" ></asp:RangeValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 86px; height: 27px;" rowspan="4">Session:</td>
            <td style="width: 163px; height: 27px;" rowspan="4">
                <asp:RadioButtonList ID="sessionButtonList" runat="server" OnSelectedIndexChanged="sessionButtonList_SelectedIndexChanged">
                    <asp:ListItem>Handling Stress</asp:ListItem>
                    <asp:ListItem>Time Management</asp:ListItem>
                    <asp:ListItem>Supervision Skills</asp:ListItem>
                    <asp:ListItem>Negotiation</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td style="height: 27px">
                <asp:Label ID="Label1" runat="server" Text="$200"></asp:Label>
                 
            </td>

            <td style="height: 27px" rowspan="4"></td>
        </tr>
        <tr>
            <td style="height: 27px"><asp:Label ID="Label2" runat="server" Text="$150"></asp:Label>
                &nbsp;</td>

        </tr>
        <tr>
            <td style="height: 27px"><asp:Label ID="Label3" runat="server" Text="$400"></asp:Label>
                &nbsp;</td>

        </tr>
        <tr>
            <td style="height: 27px"> <asp:Label ID="Label4" runat="server" Text="$500"></asp:Label>
                &nbsp;</td>

        </tr>
        <tr>
            <td style="width: 86px">
                <asp:Button ID="registerbutton" runat="server" Text="Complete Registration" OnClick="registerButton_Click" SkinID ="Button" />
            </td>
            <td style="width: 163px">Order information:</td>
            <td>
                <asp:Label ID="orderLabel" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 86px">
                <asp:Button ID="clearButton" runat="server" Text="Clear" SkinID ="Button" OnClick="clearButton_Click" Width="192px"/>
            </td>
            <td style="width: 163px">Charges:</td>
            <td>
                <asp:Label ID="chargeLabel" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
      </asp:Content> 
            <asp:Content ID="Content2" ContentPlaceHolderID="RightContent" Runat="Server" >
                    
                <asp:Calendar ID="MyCalendar" runat="server"  OnDayRender="MyCalendar_DayRender" SkinID="Calendar"></asp:Calendar>
                    
                </asp:Content>
