<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageAdmin.aspx.cs" MasterPageFile="~/MasterPages/Master.Master" Inherits="TightlyCurly.Com.Admin.Web.PageAdmin" EnableEventValidation="false" ValidateRequest="false" %>

<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <script type="text/javascript">
        function showPagePreview() {
            var pageContentId;
            pageContentId = <%= GetPageContentId() %>;
            if (pageContentId && pageContent != 'undefined' && pageContent != 0) {
                window.open('PagePreview.aspx?pageContentId=' + pageContentId);
            }
            else {
                alert('Please save page content before previewing.');
            }
        }
    </script>
    <table>
        <tr>
            <td valign="top">
                Select a page:
                <br />
                <asp:ListBox ID="AllPagesList" runat="server" 
                    CssClass="textBox"
                    Width="300px" />
                <br />
                <asp:Button ID="EditPage" runat="server"
                    Text="Edit"
                    CssClass="button"
                    OnClick="EditPage_Clicked" 
                    OnClientClick="return confirm('Are you sure you want to edit this page?');" />
                &nbsp;
                <asp:Button ID="DeletePage" runat="server"
                    Text="Delete"
                    CssClass="button"
                    OnClick="DeletePage_Clicked" 
                    OnClientClick="return confirm('Are you sure you want to delete this page?');" />
            </td>
            <td valign="top">
                Page Content:
                <br />
                <asp:ListBox ID="PageContentList" runat="server" 
                    CssClass="textBox" 
                    Width="300px" />
                <br />
                <asp:Button ID="EditPageContent" runat="server"
                    Text="Edit"
                    CssClass="button"
                    OnClick="EditPageContent_Clicked"
                    OnClientClick="return confirm('Are you sure you want to edit this page content?');" />
                &nbsp;
                <asp:Button ID="DeletePageContent" runat="server"
                    Text="Delete"
                    CssClass="button"
                    OnClick="DeletePageContent_Clicked"
                    OnClientClick="return confirm('Are you sure you want to delete this page content?');" />
            </td>
        </tr>
        <tr>
            <td colspan="2" valign="top">
                <table>
                    <tr>
                        <td colspan="2">
                            <hr />
                            <span class="bodyEmphasis">
                                Selected Page:
                            </span>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:HiddenField ID="IdField" runat="server" />
                            <asp:HiddenField ID="PageEnteredDateField" runat="server" />
                            <asp:HiddenField ID="PageUpdatedDateField" runat="server" />
                            <asp:Label ID="PageNameLabel" runat="server" 
                                Text="Page Name:" 
                                AssociatedControlID="PageNameText" />
                        </td>
                        <td>
                            <asp:TextBox ID="PageNameText" runat="server" 
                                CssClass="textBox" 
                                Width="300px" 
                                ValidationGroup="PageValidationGroup" />
                            <asp:RequiredFieldValidator ID="PageNameValidator" runat="server"
                                CssClass="errorMessage"
                                ErrorMessage="Page Name is required."
                                ControlToValidate="PageNameText"
                                Display="Dynamic" 
                                ValidationGroup="PageValidationGroup" 
                                EnableClientScript="true" />
                            &nbsp;
                            <asp:Label ID="ViewStatusLabel" runat="server" 
                                Text="View Status"
                                AssociatedControlID="ViewStatusList" />
                            <asp:DropDownList ID="ViewStatusList" runat="server"
                                CssClass="textBox">
                                <asp:ListItem Selected="True" Value="1" Text="Normal" />
                                <asp:ListItem Value="2" Text="Under Construction" />
                                <asp:ListItem Value="3" Text="Not Found" />
                                <asp:ListItem Value="4" Text="Not Authorized" />
                            </asp:DropDownList>
                            <br />
                            <asp:Label ID="UriLabel" runat="server" 
                                Text="Uri:"
                                AssociatedControlID="UriText" />
                            &nbsp;&nbsp;
                            <asp:TextBox ID="UriText" runat="server"
                                CssClass="textBox"
                                Width="300px"
                                ValidationGroup="PageValidationGroup" />
                            <asp:RequiredFieldValidator ID="UriValidator" runat="server"
                                CssClass="errorMessage"
                                ErrorMessage="Uri is required."
                                ControlToValidate="UriText"
                                Display="Dynamic" 
                                ValidationGroup="PageValidationGroup" 
                                EnableClientScript="true" />
                            <br />
                            <asp:Button ID="NewPage" runat="server"
                                Text="New Page" 
                                CssClass="button"
                                OnClick="NewPage_Clicked"
                                OnClientClick="return confirm('Are you sure you want to create a new page?');" />
                            &nbsp;
                            <asp:Button ID="SavePage" runat="server"
                                Text="Save Page"
                                CssClass="button"
                                OnClick="SavePage_Clicked"
                                ValidationGroup="PageValidationGroup"
                                CausesValidation="true" />  
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <hr />  
                            <span class="bodyEmphasis">
                                Selected Page Content:
                            </span>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:HiddenField ID="PageContentIdField" runat="server" />
                            <asp:HiddenField ID="PageContentEnteredDateField" runat="server" />
                            <asp:HiddenField ID="PageContentUpdatedDateField" runat="server" />
                            <asp:Label ID="PageContentTitleLabel" runat="server" 
                                Text="Title:" 
                                AssociatedControlID="PageContentTitleText" />
                        </td>
                        <td valign="top">
                            <asp:TextBox ID="PageContentTitleText" runat="server"
                                CssClass="textBox" 
                                Width="300px"
                                ValidationGroup="PageContentValidationGroup" />
                            <asp:RequiredFieldValidator ID="PageContentTitleValidator"
                                runat="server" 
                                CssClass="errorMessage"
                                ErrorMessage="Title is required."
                                ControlToValidate="PageContentTitleText"
                                Display="Dynamic" 
                                EnableClientScript="true"
                                ValidationGroup="PageContentValidationGroup" />
                        </td>
                    </tr>
                    <tr>   
                        <td valign="top">
                            <asp:Label ID="PageContentMetaDescriptionLabel" runat="server" 
                                Text="Meta Description:" 
                                AssociatedControlID="PageContentMetaDescriptionText" />
                        </td>
                        <td valign="top">
                           <asp:TextBox ID="PageContentMetaDescriptionText" runat="server"
                                CssClass="textBox" 
                                Width="300px"
                                ValidationGroup="PageContentValidationGroup" />
                            <asp:RequiredFieldValidator ID="PageContentMetaDescriptionValidator"
                                runat="server" 
                                CssClass="errorMessage"
                                ErrorMessage="Meta description is required."
                                ControlToValidate="PageContentMetaDescriptionText"
                                Display="Dynamic" 
                                EnableClientScript="true"
                                ValidationGroup="PageContentValidationGroup" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:Label ID="PageContentMetaKeywordLabel" runat="server" 
                                Text="Meta Keywords:" 
                                AssociatedControlID="PageContentMetaKeywordsText" />
                        </td>
                        <td valign="top">
                           <asp:TextBox ID="PageContentMetaKeywordsText" runat="server"
                                CssClass="textBox" 
                                Width="300px"
                                ValidationGroup="PageContentValidationGroup" />
                            <asp:RequiredFieldValidator ID="PageContentMetaKeywordValidator"
                                runat="server" 
                                CssClass="errorMessage"
                                ErrorMessage="Meta keywords are required."
                                ControlToValidate="PageContentMetaKeywordsText"
                                Display="Dynamic" 
                                EnableClientScript="true"
                                ValidationGroup="PageContentValidationGroup" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:Label ID="PageContentDescriptionLabel" runat="server"
                                Text="Description:"
                                AssociatedControlID="PageContentDescriptionText" />
                        </td>
                        <td valign="top">
                            <asp:TextBox ID="PageContentDescriptionText" runat="server"
                                CssClass="textBox"
                                Width="300px"
                                ValidationGroup="PageContentValidationGroup" />
                            <asp:RequiredFieldValidator ID="PageContentDescriptionValidator" 
                                runat="server"
                                CssClass="errorMessage"
                                ErrorMessage="Description is required."
                                ControlToValidate="PageContentDescriptionText"
                                Display="Dynamic" 
                                EnableClientScript="true"
                                ValidationGroup="PageContentValidationGroup" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:CheckBox ID="PageContentIsActive" Text="Is Active?" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:Label ID="PageContentLabel" runat="server"
                                Text="Content:"
                                AssociatedControlID="PageContentText" />
                        </td>
                        <td valign="top">
                            <asp:TextBox ID="PageContentText" runat="server"
                                CssClass="textBox" 
                                Width="600px"
                                Height="500px"
                                TextMode="MultiLine" 
                                ValidationGroup="PageContentValidationGroup" />
                            <asp:RequiredFieldValidator ID="PageContentValidator"
                                runat="server"
                                CssClass="errorMessage"
                                ErrorMessage="Content is required."
                                ControlToValidate="PageContentText"
                                Display="Dynamic" 
                                EnableClientScript="true"
                                ValidationGroup="PageContentValidationGroup" />
                            <br />
                            <asp:Button ID="NewPageContent" runat="server"
                                CssClass="button"
                                Text="New Content"
                                OnClick="NewPageContent_Clicked"
                                OnClientClick="return confirm('Are you sure you want to add new content to this page?');" />
                            &nbsp;
                            <asp:Button ID="SavePageContent" runat="server"
                                CssClass="button"
                                Text="Save Content"
                                OnClick="SavePageContent_Clicked"
                                OnClientClick="return confirm('Are you sure you want to save this content to the page?')"
                                CausesValidation="true"
                                ValidationGroup="PageContentValidationGroup" />
                            &nbsp;
                            <asp:Button ID="PreviewPageContent" runat="server"
                                CssClass="button"
                                Text="Preview Content"
                                OnClientClick="showPagePreview();"
                                CausesValidation="false" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>