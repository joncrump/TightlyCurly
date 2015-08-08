<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MessageBox.ascx.cs" Inherits="TightlyCurly.Com.Admin.Web.UserControls.MessageBox" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>    

<script type="text/javascript">
    function changeToHover()
    {
        document.getElementById('closeButton').src = "images/navigation/closeButtonHover.jpg";
    }
    
    function changeBackToClose()
    {
        document.getElementById('closeButton').src = "images/navigation/closeButton.jpg";
    }
    
    function hideMessageBox() 
    {
        //debugger;
        var modalpopup = $find('modalBehavior');
        modalpopup.hide();
    }
    
</script>

<asp:Panel ID="pnlMessageBox" runat="server" style="display:none;" CssClass="messageBox">
    <table>
        <tr id="titleRow" runat="server">
            <td width="100%" style="text-align:center;">
                <asp:Label ID="lblTitle" runat="server" CssClass="messageBoxTitle" />
                <asp:HiddenField ID="close" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="text-align:center;">
                <input id="btnClose" class="button" type="button" value="Click to Close" onclick="hideMessageBox();"/>
            </td>
        </tr>
    </table>
</asp:Panel>
<ajaxToolkit:ModalPopupExtender ID="messageBoxPopUp" runat="server"
    TargetControlID="close"
    PopupControlID="pnlMessageBox" 
    RepositionMode="RepositionOnWindowResizeAndScroll" 
    BehaviorID="modalBehavior" 
    BackgroundCssClass="modalBackground"/>

