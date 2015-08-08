<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Master.Master" CodeBehind="Default.aspx.cs" Inherits="TightlyCurly.Com.Admin.Web._Default" %>

<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <div>
        <asp:Login ID="Login" runat="server" DestinationPageURL="Landing.aspx" 
            TextBoxStyle-CssClass="textBox"
            LoginButtonStyle-CssClass="button"  
            BorderStyle="Solid" 
            DisplayRememberMe="false"/>
    </div>
</asp:Content>
