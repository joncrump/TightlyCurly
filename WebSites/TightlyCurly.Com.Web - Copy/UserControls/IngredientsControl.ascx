<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="IngredientsControl.ascx.cs" Inherits="TightlyCurly.Com.Web.UserControls.IngredientsControl" %>
<%@ Register Src="~/UserControls/CategoryControl.ascx" TagName="Category" TagPrefix="Alligoshee" %>
<table width="100%">
    <tr>
        <td>
            <div style="text-align:center;">
                <asp:Label ID="chooseCategory" runat="server" CssClass="bodyHeader" Text="<% $Resources:TightlyCurly.Com.Web,chooseCategoryText %>" />
                <br />
                <br />
                <Alligoshee:Category ID="categories" runat="server" />
                <br />
                <br />
            </div>
        </td>
   </tr>
   <tr>
        <td>
            <asp:GridView ID="grdIngredients" runat="server" 
                AutoGenerateColumns="false" 
                OnRowDataBound="grdIngredients_RowDataBound" 
                GridLines="None" Width="100%" DataKeyNames="Id">
                <EmptyDataTemplate>
                    <div style="text-align:center;width:100%">
                        <h3>No Items Found</h3>
                    </div>
                </EmptyDataTemplate>
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div style="text-align:left;">
                                <asp:Label ID="title" runat="server" CssClass="bodyTextEmphasis" />
                                &nbsp;&nbsp;
                                <asp:Label ID="alias" runat="server" CssClass="bodyTextItalic" Visible="false" />
                                <br />
                                <asp:Label ID="ingredientRating" runat="server" />
                                <br />
                                <asp:Literal ID="description" runat="server" Text='<%# Eval("Description") %>' />
                                <br />
                                <asp:Label ID="relatedLinksLabel" runat="server" CssClass="bodyTextItalic" Visible="false" Text="<%$Resources:TightlyCurly.Com.Web,relatedLinksText %>" />
                                <asp:Literal ID="relatedLinks" runat="server" Visible="false" />
                                <asp:Label ID="externalLinksLabel" runat="server" CssClass="bodyText" Visible="false" Text="<%$Resources:TightlyCurly.Com.Web,externalLinksText %>" />
                                <asp:Literal ID="externalLinks" runat="server" Visible="false" />
                                <br />
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>