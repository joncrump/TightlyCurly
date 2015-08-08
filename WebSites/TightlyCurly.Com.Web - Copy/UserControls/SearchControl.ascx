<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchControl.ascx.cs" Inherits="TightlyCurly.Com.Web.UserControls.SearchControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxToolkit" %>  
<asp:Panel ID="SearchPanel" runat="server">
    <asp:Label ID="searchLabel" runat="server" AssociatedControlID="searchText" Text="Search"/>
    <asp:TextBox ID="searchText" runat="server"
        ValidationGroup="SearchValidationGroup" />
    <asp:RequiredFieldValidator 
        ID="searchValidator" 
        runat="server" 
        Display="Dynamic" 
        Enabled="false" 
        EnableClientScript="true"
        ControlToValidate="searchText" 
        ValidationGroup="SearchValidationGroup" />
    &nbsp;
    <asp:Button ID="searchButton" runat="server" 
        OnClick="searchButton_Click" 
        Text="Search" 
        ValidationGroup="SearchValidationGroup" />
</asp:Panel>
<asp:Panel ID="panel" runat="server" ScrollBars="Vertical" />
<AjaxToolkit:AutoCompleteExtender ID="searchAutoComplete" runat="server" TargetControlID="searchText" 
    CompletionSetCount="100" MinimumPrefixLength="1" CompletionInterval="1" 
    CompletionListItemCssClass="completionListItem" CompletionListElementID="panel"/>