<%@ Page Language="C#" MasterPageFile="~/MasterPages/Master.master" Culture="auto:en-US" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TightlyCurly.Com.Web.Contact" ValidateRequest="false" %>

<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <asp:Panel ID="ContactPanel" runat="server">
        <asp:Panel ID="MessageContainer" runat="server" Visible="false">
            <asp:Literal ID="MessageContainerText" runat="server" /> 
        </asp:Panel>
        <asp:Panel ID="ContactContainer" runat="server">
            <table>
                <tr>
                    <td colspan="2">
                         <p>
                            Please fill out this form if you would like to ask a question, leave a comment, or sign up for news about the site or the book.<span style="color:Purple;">*</span>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td style="width:75px;">
                    </td>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <asp:Label ID="FirstNameLabel" runat="server" AssociatedControlID="FirstNameText" 
                                        Text="<%$ Resources:TightlyCurly.Com.Web,firstNameText %>"
                                        ToolTip="<%$ Resources:TightlyCurly.Com.Web,firstNameToolTip %>" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="FirstNameText" runat="server" MaxLength="50" 
                                        ToolTip="<%$ Resources:TightlyCurly.Com.Web,firstNameToolTip %>"  
                                        Width="300px"
                                        CssClass="textBox"
                                        ValidationGroup="CommentsValidation" />
                                    <asp:RequiredFieldValidator ID="FirstNameValidator" runat="server"
                                        Display="Dynamic"
                                        ControlToValidate="FirstNameText" 
                                        EnableClientScript="true"
                                        ErrorMessage="<%$ Resources:TightlyCurly.Com.Web,firstNameValidationMessage %>" 
                                        ValidationGroup="CommentsValidation" />
                               </td>
                            </tr> 
                            <tr>
                                <td>
                                    <asp:Label ID="LastNameLabel" runat="server" AssociatedControlID="LastNameText" 
                                        Text="<%$ Resources:TightlyCurly.Com.Web,lastNameText %>"
                                        ToolTip="<%$ Resources:TightlyCurly.Com.Web,lastNameToolTip %>" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="LastNameText" runat="server" MaxLength="50" 
                                        ToolTip="<%$ Resources:TightlyCurly.Com.Web,firstNameToolTip %>"  
                                        Width="300px" 
                                        CssClass="textBox"
                                        ValidationGroup="CommentsValidation" />
                                    <asp:RequiredFieldValidator ID="LastNameValidator" runat="server"
                                        Display="Dynamic"
                                        ControlToValidate="LastNameText" 
                                        EnableClientScript="true"
                                        ErrorMessage="<%$ Resources:TightlyCurly.Com.Web,lastNameValidationMessage %>" 
                                        ValidationGroup="CommentsValidation" />
                               </td>
                            </tr> 
                            
                            <tr>
                               <td>
                                    <asp:Label ID="EmailAddressLabel" runat="server" AssociatedControlID="EmailAddressText" 
                                        Text="<%$ Resources:TightlyCurly.Com.Web,emailText %>"
                                        ToolTip="<%$ Resources:TightlyCurly.Com.Web,emailToolTip %>" />
                               </td>
                            </tr>
                            <tr>
                               <td>
                                    <asp:TextBox ID="EmailAddressText" runat="server" MaxLength="50" 
                                        ToolTip="<%$ Resources:TightlyCurly.Com.Web,emailToolTip %>" 
                                        Width="300px" 
                                        CssClass="textBox"
                                        ValidationGroup="CommentsValidation" />
                                    <asp:RequiredFieldValidator ID="EmailAddressValidator" runat="server"
                                        Display="Dynamic"
                                        ControlToValidate="EmailAddressText" 
                                        EnableClientScript="true"
                                        ErrorMessage="<%$ Resources:TightlyCurly.Com.Web,emailValidationMessage %>" 
                                        ValidationGroup="CommentsValidation" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="CommentsLabel" runat="server" AssociatedControlID="CommentsText" 
                                        Text="<%$ Resources:TightlyCurly.Com.Web,commentsText %>"
                                        ToolTip="<%$ Resources:TightlyCurly.Com.Web,commentsToolTip %>" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="CommentsText" runat="server" MaxLength="50" TextMode="MultiLine"
                                        ToolTip="<%$ Resources:TightlyCurly.Com.Web,commentsToolTip %>" 
                                        Width="300px"
                                        Height="200px" 
                                        CssClass="textBox"
                                        ValidationGroup="CommentsValidation" />
                                    <asp:RequiredFieldValidator ID="CommentsValidator" runat="server" 
                                        Display="Dynamic" 
                                        ControlToValidate="CommentsText"
                                        ErrorMessage="<%$ Resources:TightlyCurly.Com.Web,commentsValidationMessage %>" 
                                        ValidationGroup="CommentsValidation" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="AddComment" runat="server" 
                                        OnClick="AddComments_Click" 
                                        CssClass="button"
                                        Text="<%$ Resources:TightlyCurly.Com.Web,submitCommentsText %>" 
                                        ToolTip="<%$ Resources:TightlyCurly.Com.Web,submitCommentsToolTip %>" 
                                        style="text-align:center;" 
                                        ValidationGroup="CommentsValidation" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:CheckBox ID="SignUpBookUpdates" runat="server"
                                        Checked="true"
                                        Text="<%$ Resources:TightlyCurly.Com.Web,signUpForBookUpdates %>" />
                                </td>
                            </tr>
                        </table>
                    </td>                
                </tr>                
            </table>
            <p>
                Because of the number of great questions and comments I get, sometimes it might take me a few days <span style="color:Purple;">(well, while I catch up, it may take a few weeks)</span> to write back, but I do my best to answer every email sent to me.
                <br />
                <br />
                <i>
                <span style="color:Purple;">*</span>You should immediately get a simple confirmation email from me. If you don't get one, then it means I didn't get your message (probably because there was a typo when your email address was entered).
                </i>
                <br />
                <br />
            </p>
            
            <p>
                
                <span class="bodyTextEmphasis">Interested in having me try out some of your hair products?</span> 
                <br />
            
                <br />
                <br />
                I'm more than happy to try out a new product.  However, please note the following:
                <br />
                <br />
                
         *Please do keep in mind one of my main goals is to simplify the process of caring for our curly hair. If you have a multiple-product system for hair care, chances are I will only recommend the product that works with the simplified routine outlined on this site.
         <br />
         <br />
         *I believe in being absolutely honest about what I think of a product. For an idea of how I might respond to a particular product, please check out the ingredients of your product with the hair products <a href="http://tightlycurly.com/Ingredients.aspx">Ingredients Dictionary</a>. If it contains ingredients I consider a "Caution" or "Avoid", this most likely will be how I regard a product that contains those ingredients.
         
            </p>     
        </asp:Panel>
    </asp:Panel>
</asp:Content>