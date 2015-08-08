<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Master.Master" CodeBehind="IngredientsAdmin.aspx.cs" Inherits="TightlyCurly.Com.Admin.Web.IngredientsAdmin" ValidateRequest="false" %>
<%@ Register Src="~/UserControls/ListModifierControl.ascx" TagName="ListModifier" TagPrefix="Alligoshee" %>
<%@ Register Assembly="CapitalizationExtender" Namespace="CapitalizationExtender" TagPrefix="Lmts" %>  

<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <asp:ValidationSummary ID="ValidationSummary" runat="server" 
        ValidationGroup="ingredients" 
        DisplayMode="BulletList" />
    <table>
        <tr>
            <td width="215px" valign="top">
                <span class="bodyTextEmphasis">
                    Existing Ingredients
                </span>
                <br />
                <br />
                <asp:ListBox ID="IngredientNames" runat="server" 
                    Height="647px" 
                    Width="500px" 
                    CssClass="textBox" />
                <br />
                <hr />
                <asp:Button ID="EditIngredient" runat="server"
                    CssClass="button"
                    OnClick="EditIngredient_Clicked"
                    Text="Edit" />
                <asp:Button ID="RemoveIngredient" runat="server" 
                    CssClass="button" 
                    OnClick="RemoveIngredient_Clicked" 
                    Text="Remove" 
                    OnClientClick="return confirm('Are you sure you want to delete the ingredient?');"/>
            </td>
            <td valign="top">
                <table>
                    <tr>
                        <td valign="top">
                            <table>
                                <tr>
                                    <td>
                                        <asp:HiddenField ID="Id" runat="server" />
                                        <asp:HiddenField ID="EnteredDate" runat="server" />
                                        <asp:HiddenField ID="UpdatedDate" runat="server" />
                                        <asp:Label ID="TitleText" 
                                            runat="server" 
                                            AssociatedControlID="Title" 
                                            Text="Title: " />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Title" 
                                            runat="server" 
                                            MaxLength="255" 
                                            Width="300px"
                                            CssClass="textBox" />
                                        <span class="errorMessage">*</span>
                                        <asp:RequiredFieldValidator ID="TitleValidator" 
                                            runat="server" 
                                            ControlToValidate="Title"
                                            Display="Dynamic" 
                                            ErrorMessage="Title is required" 
                                            EnableClientScript="true" 
                                            ValidationGroup="ingredients" 
                                            CssClass="errorMessage" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="AliasText" 
                                            runat="server" 
                                            AssociatedControlID="Alias"
                                            Text="Alias: " />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Alias" 
                                            runat="server" 
                                            MaxLength="255" 
                                            Width="300px"
                                            CssClass="textBox" />                              
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="DescriptionText"
                                            runat="server"
                                            AssociatedControlID="Description"
                                            Text="Description: " />
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Description"
                                            runat="server"
                                            MaxLength="4000" 
                                            TextMode="MultiLine" 
                                            Width="300px"
                                            Height="75px"
                                            CssClass="textBox" />
                                        <span class="errorMessage">*</span>
                                        <asp:RequiredFieldValidator ID="DescriptionValidator"
                                            runat="server"
                                            ControlToValidate="Description"
                                            Display="Dynamic"
                                            ErrorMessage="Description is required"
                                            EnableClientScript="true"
                                            ValidationGroup="ingredients"
                                            CssClass="errorMessage" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="IngredientRatingText" 
                                            runat="server" Text="Ingredient Rating: " />
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="IngredientRating"
                                            runat="server"
                                            Width="100px">
                                            <asp:ListItem Value="0" Text="Okay" />
                                            <asp:ListItem Value="1" Text="Avoid" />
                                            <asp:ListItem Value="2" Text="Caution" />
                                            <asp:ListItem Value="3" Text="Good" />
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <hr />
                                            <Alligoshee:ListModifier ID="References" 
                                                runat="server" 
                                                Title="References" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <hr />
                                        <Alligoshee:ListModifier ID="Links" 
                                            runat="server" 
                                            Title="Links" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <hr />
                                        <Alligoshee:ListModifier ID="SeeAlso" 
                                            runat="server" 
                                            Title="See Also" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <hr />
                                        Ingredient URL:&nbsp;&nbsp;
                                        <asp:Label ID="IngredientUri" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <hr />
                                        <asp:Button ID="Save" runat="server"
                                            Text="Save Ingredient" 
                                            OnClick="Save_Clicked" 
                                            CssClass="button" 
                                            ValidationGroup="ingredients" />
                                        <asp:Button ID="NewIngredient" runat="server"
                                            Text="Add New Ingredient" 
                                            OnClick="NewIngredient_Clicked" 
                                            CssClass="button" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
