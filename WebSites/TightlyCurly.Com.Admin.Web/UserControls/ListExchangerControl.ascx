<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListExchangerControl.ascx.cs" Inherits="TightlyCurly.Com.Admin.Web.UserControls.ListExchangerControl" %>
<table>
    <tr>
        <td style="text-align:center">
            <asp:Label ID="LeftLabel" runat="server" />
        </td>
        <td>
        </td>
        <td style="text-align:center">
            <asp:Label ID="RightLabel" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:ListBox ID="Left" runat="server" />
        </td>
        <td>
            <asp:Button ID="SwitchLeft" runat="server" Text=">" OnClick="SwitchLeft_Click" />
            <br />
            <asp:Button ID="SwitchRight" runat="server" Text="<" OnClick="SwitchRight_Click" />
        </td>
        <td>
            <asp:ListBox ID="Right" runat="server" />
        </td>
    </tr>
</table>
