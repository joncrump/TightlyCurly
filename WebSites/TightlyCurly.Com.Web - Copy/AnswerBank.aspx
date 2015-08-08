<%@ Page Language="C#" AutoEventWireup="true" Culture="auto:en-US" MasterPageFile="~/MasterPages/Master.Master" CodeBehind="AnswerBank.aspx.cs" Inherits="TightlyCurly.Com.Web.AnswerBank" 
     EnableViewState="true" %>
<%@ Register Src="~/UserControls/SearchControl.ascx" TagName="Search" TagPrefix="Alligoshee" %>

<asp:Content ID="pageContent" ContentPlaceHolderID="contentArea" Runat="Server">
    <script type="text/javascript">
        jQuery(document).ready(function() {
            jQuery("[id$='AllQuestionsList']").bind("dblclick", function() {
                var selectedValue = jQuery("[id$='AllQuestionsList']").val();
                window.location = 'AnswerBank.aspx?questionId=' + selectedValue;
            });
        });
    </script>
    <div>
        <p>
            Here are some of the questions I get asked the most, and what my answers have been.  
            This way you can get your answers immediately, without having to wait on me. 
            And you never know, you might find answers to a few questions you didn't even know you had yet.
        </p>
        <p>
            *This is still a work in progress. I'm continuing to add many more questions, and we are still ironing out a few quirks. 
            But we wanted to make this available as soon as possible. 
        </p>
        <p>
		 <span style="font-weight:bold">There are several ways to choose the question(s) you'd like answered:</span>
        </p>
    </div>
    <div>
        <div>
            <span style="font-weight:bold"><asp:Label ID="AllQuestionsLabel" runat="server" 
                Text="You can choose from all the questions:"
                AssociatedControlID="AllQuestionsList" />
			</span>
            <br />
            <asp:ListBox ID="AllQuestionsList" runat="server"
                 CssClass="textBox" Width="625px" />
            <br />
            <asp:Button ID="ViewSelectedQuestion" runat="server" 
                CssClass="button" Text="View Question"
                OnClick="ViewSelectedQuestion_Click" />
            <br />

        </div>
        <div>
			<p>
			<span style="margin-left:auto;margin-right:auto;text-align:center;font-weight:bold">... or you can ...</span>
			</p>
           <div>
            <Alligoshee:Search ID="QuestionSearchControl" runat="server" 
                ButtonCssClass="button"  
	            TextCssClass="textBox" 
	            LabelText="Search By Keyword:" 
	            TextWidth="150" 
	            ValidationGroup="QuestionSearch" 
	            ServiceMethod="GetQuestionsList" />
	        <br />
        </div>      
            <br />
			<span style="text-align:center;font-weight:bold">... or you can ...</span>
			<br/>
			<br />
        </div>
    </div>
    <asp:Panel ID="TopicsContainer" runat="server">
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td style="width:190px">
                    <asp:Label ID="MasterCategoriesLabel" runat="server" 
                        Text="First select a category: "
                        AssociatedControlID = "MasterCategoriesList" />
                    &nbsp;
                </td>
                <td>
                    <asp:DropDownList ID="MasterCategoriesList" runat="server" AutoPostBack="true"
                        OnSelectedIndexChanged="MasterCategoriesList_SelectedIndexChanged" AppendDataBoundItems="true" Width="200px">
                            <asp:ListItem Text="<%$ Resources:TightlyCurly.Com.Web,selectTopicText %>" Value="0" />
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Panel ID="SubcategoriesListContainer" runat="server">
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td style="width:190px">
                                    <asp:Label ID="SubcategoriesLabel" runat="server" 
                                        Text="Then select its subcategory: "
                                        AssociatedControlID = "SubcategoriesList" />
                                </td>
                                <td>
                                    <asp:DropDownList ID="SubcategoriesList" runat="server" Width="200px">
                                        <asp:ListItem Text="<%$ Resources:TightlyCurly.Com.Web,selectTopicText %>" Value="0" />
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:130px">
                                </td>
                                <td>
                                    <asp:Button ID="ViewQuestions" runat="server" Text="View Questions" OnClick="ViewQuestions_Clicked" CssClass="button" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:GridView ID="QuestionsList" runat="server"
        AutoGenerateColumns="false" GridLines="None"
        Width="100%"> 
        <EmptyDataTemplate>
            <h2>
                 <asp:Literal ID="NoQuestionsFoundLiteral" runat="server" 
                    Text="<%$ Resources:TightlyCurly.Com.Web,noQuestionsFoundForTopicText %>" />
            </h2>
        </EmptyDataTemplate>
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="questionContainer">
                        <div class="question">
                            <asp:Literal ID="QuestionLiteral" runat="server" 
                                Text="<%$ Resources:TightlyCurly.Com.Web,questionText %>" />
                        </div>
                        <div class="questionText">
                            <asp:Literal ID="QuestionText" runat="server"
                                Text='<%# Eval("Value") %>' />
                        </div>
                        <div class="answer">
                            <asp:Literal ID="AnswerLiteral" runat="server" 
                                Text="<%$ Resources:TightlyCurly.Com.Web,answerText %>" />
                        </div>
                        <div class="answerText">
                            <asp:Literal ID="AnswerText" runat="server"        
                                Text='<%# Eval("Answer") %>' />
                        </div>
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
