<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/PreviewMaster.Master" CodeBehind="PagePreview.aspx.cs" Inherits="TightlyCurly.Com.Admin.Web.PagePreview" %>
<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <asp:Literal ID="PreviewContent" runat="server" Text="No page is selected." />
</asp:Content>