<%@ Page Language="C#" MasterPageFile ="~/MasterPage.master" AutoEventWireup="false" CodeFile="Home.aspx.cs" Inherits="_Default" %>


 
<asp:Content ID="Content1" ContentPlaceHolderID="LeftContent" runat="Server">

    <p>
        <b>
            Welcome to HR Solutions

        </b>

        <table style="width: 100%">
            <tr>
                <td><asp:AdRotator ID="AdRotator1" runat="server"
                      AdvertisementFile="~/adBanner.xml"  />
                </td>
            </tr>
        </table>

    </p>
    
      </asp:Content> 
            <asp:Content ID="Content2" ContentPlaceHolderID="RightContent" Runat="Server">
                    
               </asp:Content>
           
        
    
   