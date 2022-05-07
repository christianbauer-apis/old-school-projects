<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CRUDorder.aspx.cs" Inherits="CRUDorder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 447px;
        }
        .auto-style3 {
            width: 263px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Enter your Order ID:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="orderIDTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    sign out link</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:FormView ID="FormView1" runat="server" DataKeyNames="OrderId" DataSourceID="SqlDataSource1">
                        <EditItemTemplate>
                            OrderId:
                            <asp:Label ID="OrderIdLabel1" runat="server" Text='<%# Eval("OrderId") %>' />
                            <br />
                            Computer:
                            <asp:TextBox ID="ComputerTextBox" runat="server" Text='<%# Bind("Computer") %>' />
                            <br />
                            Laptop:
                            <asp:TextBox ID="LaptopTextBox" runat="server" Text='<%# Bind("Laptop") %>' />
                            <br />
                            Phone:
                            <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                            <br />
                            TotalCharge:
                            <asp:TextBox ID="TotalChargeTextBox" runat="server" Text='<%# Bind("TotalCharge") %>' />
                            <br />
                            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            Computer:
                            <asp:TextBox ID="ComputerTextBox" runat="server" Text='<%# Bind("Computer") %>' />
                            <br />
                            Laptop:
                            <asp:TextBox ID="LaptopTextBox" runat="server" Text='<%# Bind("Laptop") %>' />
                            <br />
                            Phone:
                            <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                            <br />
                            TotalCharge:
                            <asp:TextBox ID="TotalChargeTextBox" runat="server" Text='<%# Bind("TotalCharge") %>' />
                            <br />
                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </InsertItemTemplate>
                        <ItemTemplate>
                            OrderId:
                            <asp:Label ID="OrderIdLabel" runat="server" Text='<%# Eval("OrderId") %>' />
                            <br />
                            Computer:
                            <asp:Label ID="ComputerLabel" runat="server" Text='<%# Bind("Computer") %>' />
                            <br />
                            Laptop:
                            <asp:Label ID="LaptopLabel" runat="server" Text='<%# Bind("Laptop") %>' />
                            <br />
                            Phone:
                            <asp:Label ID="PhoneLabel" runat="server" Text='<%# Bind("Phone") %>' />
                            <br />
                            TotalCharge:
                            <asp:Label ID="TotalChargeLabel" runat="server" Text='<%# Bind("TotalCharge") %>' />
                            <br />
                            <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                            &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                            &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
                        </ItemTemplate>
                    </asp:FormView>
                </td>
                <td class="auto-style3">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:project %>" SelectCommand="SELECT * FROM [Order] WHERE ([OrderId] = @OrderId)" DeleteCommand="DELETE FROM [Order] WHERE [OrderId] = @OrderId" InsertCommand="INSERT INTO [Order] ([Computer], [Laptop], [Phone], [TotalCharge]) VALUES (@Computer, @Laptop, @Phone, @TotalCharge)" UpdateCommand="UPDATE [Order] SET [Computer] = @Computer, [Laptop] = @Laptop, [Phone] = @Phone, [TotalCharge] = @TotalCharge WHERE [OrderId] = @OrderId">
                        <DeleteParameters>
                            <asp:Parameter Name="OrderId" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="Computer" Type="String" />
                            <asp:Parameter Name="Laptop" Type="String" />
                            <asp:Parameter Name="Phone" Type="String" />
                            <asp:Parameter Name="TotalCharge" Type="Decimal" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:ControlParameter ControlID="orderIDTextBox" Name="OrderId" PropertyName="Text" Type="Int32" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="Computer" Type="String" />
                            <asp:Parameter Name="Laptop" Type="String" />
                            <asp:Parameter Name="Phone" Type="String" />
                            <asp:Parameter Name="TotalCharge" Type="Decimal" />
                            <asp:Parameter Name="OrderId" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="submitButton" runat="server" Text="Submit" />
                </td>
                <td class="auto-style3">&nbsp;
                                        <asp:Button ID="signButton" runat="server" OnClick="signButton_Click" Text="sign out" style="height: 26px" />

                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
