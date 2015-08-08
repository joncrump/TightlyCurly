<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListModifierControl.ascx.cs" Inherits="TightlyCurly.Com.Admin.Web.UserControls.ListModifierControl" %>
    <table>
        <tr>
            <td colspan="3">
                <asp:HiddenField ID="ValuesIndex" runat="server" />
                <p style="text-align:center;">
                    <asp:Label ID="TitleText" runat="server" CssClass="bodyTextEmphasis"/>
                </p>
            </td>
        </tr>
        <tr>
            <td>
                Items:
                <br />
                <asp:ListBox ID="ValuesList" runat="server" 
                    Width="150px" />
                <br />
                <asp:Button ID="Edit" runat="server" OnClick="Edit_Clicked" CssClass="button" Text="Edit" />
                <asp:Button ID="Remove" runat="server" OnClick="Remove_Clicked" CssClass="button" Text="Remove" /> 
            </td>
            <td style="width:15px;">
            </td>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="ItemValueText" runat="server" Text="Value: " />
                        </td>
                        <td>
                            <asp:TextBox ID="ItemValue" runat="server" 
                                CssClass="textBox" Width="100px" />
                        </td>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Button ID="Save" runat="server" 
                                OnClick="Save_Clicked" 
                                CssClass="button" 
                                Text="Add Item" /> 
                        </td>
                   </tr>
                </table>
            </td>
        </tr>
    </table>