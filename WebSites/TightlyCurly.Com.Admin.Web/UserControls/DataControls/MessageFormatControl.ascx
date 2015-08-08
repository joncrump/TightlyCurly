<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MessageFormatControl.ascx.cs" Inherits="Alligoshee.Hair.Web.UserControls.DataControls.MessageFormatControl" %>
<asp:DropDownList ID="cmbMessageFormat" runat="server">
    <asp:ListItem Selected="True" Value="Text" />
    <asp:ListItem Value="HTML" />
</asp:DropDownList>