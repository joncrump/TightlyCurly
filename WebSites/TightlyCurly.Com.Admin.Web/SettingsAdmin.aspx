<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/MasterPages/Master.Master" CodeBehind="SettingsAdmin.aspx.cs" ValidateRequest="false" Inherits="TightlyCurly.Com.Admin.Web.SettingsAdmin" %>

<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <div style="text-align:center">
        Settings
    </div>
    <div style="width: 100%; height: 300px;" class="scrollableContainer"> 
        <asp:GridView ID="SettingsView" runat="server" 
            AutoGenerateColumns="false" 
            GridLines="None" 
            Width="100%" 
            DataKeyNames="Id"
            OnRowEditing="SettingsView_OnRowEditing" 
            OnRowUpdating="SettingsView_OnRowUpdating"
            OnRowCancelingEdit="SettingsView_OnRowCancelEdit" 
            OnRowDeleting="SettingsView_OnRowDeleting">
            <EmptyDataTemplate>
                <div style="text-align:center;width:100%">
                    <h3>No Settings Found</h3>
                </div>
            </EmptyDataTemplate>
            <Columns>
                <asp:TemplateField HeaderText="Key">
                    <ItemTemplate>
                        <asp:Literal ID="Key" runat="server" Text='<%# Eval("Key") %>' />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="KeyEdit" runat="server" CssClass="textBox" Text='<%# Eval("Key") %>' />
                    </EditItemTemplate>
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Value">
                    <ItemTemplate>          
                        <asp:Literal ID="Value" runat="server" Text='<%# Eval("Value") %>' />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="ValueEdit" runat="server" CssClass="textBox" Text='<%# Eval("Value") %>' TextMode="MultiLine" Width="400px" />
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="EditSetting" runat="server" 
                            CommandName="Edit" 
                            Text="Edit" 
                            CssClass="button" 
                            CommandArgument="<%# Container.DataItemIndex %>" 
                            OnClientClick="return confirm('Are you sure you want to edit this setting?');" 
                            Width="60px" />
                        <br />
                        <asp:Button ID="DeleteSetting" runat="server" 
                            CommandName="Delete" 
                            Text="Delete" CssClass="button" 
                            CommandArgument="<%# Container.DataItemIndex %>" 
                            OnClientClick="return confirm('Are you sure you want to delete this setting?');" 
                            Width="60px" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Button ID="SaveSetting" runat="server" 
                            CommandName="Update" 
                            Text="Save" 
                            CssClass="button" 
                            OnClientClick="return confirm('Are you sure you want to save this setting?');" 
                            Width="60px" />
                        <br />
                        <asp:Button ID="CancelSave" runat="server" 
                            CommandName="Cancel" 
                            Text="Cancel" 
                            CssClass="button" 
                            Width="60px" />
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <div width="60%" style="text-align:center">
            <hr />
            <p>
                Add New Setting:
            </p>
            <table>
                <tr>
                    <td valign="top">
                        <asp:Label ID="KeyLabel" runat="server" Text="Key: " AssociatedControlID="KeyText" />
                    </td>
                    <td valign="top">   
                        <asp:TextBox ID="KeyText" runat="server" CssClass="textBox" />
                    </td>
                    <td valign="top">
                        <asp:Label ID="ValueLabel" runat="server" Text="Value: " AssociatedControlID="ValueText" />
                    </td>
                    <td valign="top">    
                        <asp:TextBox ID="ValueText" runat="server" CssClass="textBox" TextMode="MultiLine" Width="400px" Height="100px" />
                    </td>  
                </tr>
            </table>  
            <asp:Button ID="NewSetting" runat="server" Text="New Setting" CssClass="button" OnClick="NewSetting_Click" />
            &nbsp;
            <asp:Button ID="SaveSetting" runat="server" Text="Save Setting" CssClass="button" OnClick="SaveSetting_Click" />
        </div>
    </div>
</asp:Content>