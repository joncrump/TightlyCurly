<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Master.Master" CodeBehind="Landing.aspx.cs" Inherits="TightlyCurly.Com.Admin.Web.Landing" %>

<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <table>
        <tr>
            <td class="landingPadding">
                <a href="IngredientsAdmin.aspx" style="text-decoration:none;text-align:center">
                    <div>
                    <img src="images/content/ingredientsAdmin.jpg" alt="Go to Ingredients Admin page." />
                    <br />
                    <span style="text-align:center">
                        <asp:Literal ID="IngredientsAdmin" runat="server" 
                            Text="<% $Resources:TightlyCurly.Com.Admin.Web,ingredientsAdminTitle %>" />
                    </span>
                    </div>
                </a>
            </td>
            <td class="landingPadding">
                <a href="AnswerBankAdmin.aspx" style="text-decoration:none;text-align:center">
                    <div>
                    <img src="images/content/chickInBasket.jpg" />
                    <br />
                    <span style="text-align:center">
                        <asp:Literal ID="AskTeriAdmin" runat="server"
                            Text="<% $Resources:TightlyCurly.Com.Admin.Web,answerBankAdminTitle %>" />
                    </span>
                    </div>
                </a>
            </td>
            <td class="landingPadding">
                <a href="SettingsAdmin.aspx" style="text-decoration:none;text-align:center">
                    <div>
                    <img src="images/content/stainlessSteelKitchen.jpg" />
                    <br />
                    <span style="text-align:center">
                        <asp:Literal ID="SettingsAdmin" runat="server" 
                            Text="<% $Resources:TightlyCurly.Com.Admin.Web,SettingsAdminTitle %>" />
                    </span>
                    </div>
                </a>
            </td>
            <td class="landingPadding">
                <a href="PageAdmin.aspx" style="text-decoration:none;text-align:center">
                    <div>
                        <div style="margin-top:26px;">
                        </div>
                        <img src="images/content/spottedDog.jpg" />
                        <br />
                        <span style="text-align:center;">
                            <asp:Literal ID="PageAdmin" runat="server" 
                                Text="<% $Resources:TightlyCurly.Com.Admin.Web,pageAdminTitle %>" />
                        </span>
                    </div>
                </a>
            </td>
            <td class="landingPadding">

            </td>
            <td class="landingPadding">

            </td>
        </tr>
    </table>
</asp:Content>
