<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Master.Master" CodeBehind="AnswerBankAdmin.aspx.cs" Inherits="TightlyCurly.Com.Admin.Web.AnswerBankAdmin" EnableEventValidation="false" ValidateRequest="false"%>
<%@ Register Src="~/UserControls/ListExchangerControl.ascx" TagName="ListExchanger" TagPrefix="Alligoshee" %>

<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <table>
        <tr>
            <td colspan="2">
                <asp:HiddenField ID="SelectedIndexField" runat="server" />
                All Questions:
                <br />
                <asp:ListBox ID="QuestionsList" runat="server" Width="700px" />
                <br />
                <asp:Button ID="EditQuestion" runat="server" CssClass="button" Text="Edit" OnClick="EditQuestion_Click" />
                <asp:Button ID="DeleteQuestion" 
                    runat="server" 
                    CssClass="button" 
                    Text="Delete" 
                    OnClick="DeleteQuestion_Click" 
                    OnClientClick="return confirm('Are you sure you want to delete this question?');"/>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height:15px">
            </td>
        </tr>
        <tr>
            <td style="width:40%">
                <asp:HiddenField ID="SelectedMasterCategoryField" runat="server" />
                <asp:HiddenField ID="QuestionIdField" runat="server" />
                <asp:HiddenField ID="QuestionCategoryField" runat="server" />
                Question: <asp:TextBox ID="QuestionText" runat="server" Width="400px" CssClass="textBox" />
                <br />
                Answer: <asp:TextBox ID="AnswerText" runat="server" TextMode="MultiLine" Width="400px" CssClass="textBox" Height="400px" />
                <br />
            </td>
            <td valign="top">
                <table>
                    <tr>
                        <td colspan="2" class="bodyTextEmphasis" style="text-align:center">
                            Master Categories
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            New Master Category: <asp:TextBox ID="NewMasterCategory" runat="server" CssClass="textBox" Width="190px" />
                            &nbsp;
                            <asp:Button ID="AddMasterCategory" runat="server" Text="Add Master Category" CssClass="button" OnClick="AddMasterCategory_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <Alligoshee:ListExchanger ID="MasterCategoriesListExchanger" runat="server" 
                                ButtonCssClass="button" 
                                ListWidth="150px" 
                                LeftText="Available"
                                RightText="Assigned"  
                                DataTextField="Category" 
                                DataValueField="QuestionCategoryId" />
                            <asp:Button ID="DeleteMasterCategory" 
                                runat="server" 
                                CssClass="button" 
                                Text="Delete Master Category" 
                                OnClick="DeleteMasterCategory_Click" 
                                OnClientClick="return confirm('Are you sure you want to delete this master category?');" />
                        </td>
                        <td>
                            <asp:Button ID="ViewSubcategories" runat="server" CssClass="button" Text="View Subcategories" OnClick="ViewSubcategories_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <hr />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="bodyTextEmphasis" style="text-align:center">
                            Subcategories
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            New Subcategory: <asp:TextBox ID="NewSubcategory" runat="server" CssClass="textBox" Width="200px" />
                            &nbsp;
                            <asp:Button ID="AddSubcategory" runat="server" Text="Add Subcategory" CssClass="button" OnClick="AddSubcategory_Click" />
                        </td>
                    </tr>
                </table>
                <table>
                    <tr>
                        <td>
                            <Alligoshee:ListExchanger ID="SubCategoriesListExchanger" runat="server"
                                ButtonCssClass="button" ListWidth="150px"
                                LeftText="Available"
                                RightText="Assigned"
                                DataTextField="Category"
                                DataValueField="QuestionCategoryId" />
                            <asp:Button ID="DeleteSubcategory" runat="server" CssClass="button" Text="Delete Subcategory" OnClientClick="return confirm('Are you sure you want to delete this subcategory?');" OnClick="DeleteSubcategory_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <hr />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            All Subcategories Assigned to Question:
                            <br />
                            <table>
                                <tr>
                                    <td>
                                        <asp:ListBox ID="AllSubcategoriesList" runat="server" Width="200px" />
                                    </td>
                                    <td>
                                        <asp:Button ID="DeleteSubcategoryFromQuestion" runat="server" CssClass="button" Text="Remove Subcategory From Question" OnClick="DeleteSubcategoryFromQuestion_Click" OnClientClick="return confirm('Are you sure you want to delete this subcategory?');"/>
                                    </td>
                                </tr>    
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                Selected URI: <asp:Label ID="SelectedUriText" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="SaveQuestion" runat="server" CssClass="button" Text="Save" OnClick="SaveQuestion_Click" OnClientClick="return confirm('Are you sure you want to save this question?');" />
                &nbsp;
                <asp:Button ID="NewQuestion" runat="server" CssClass="button" Text="New" OnClick="NewQuestion_Click" OnClientClick="return confirm('Are you sure you want to create a new question?');" />
            </td>
        </tr>
    </table>
</asp:Content> 