using System;
using System.Linq;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Model.Entities;
using TightlyCurly.Com.Framework.Extensions;
using System.Collections.Generic;

namespace TightlyCurly.Com.Web
{
    public partial class AnswerBank //: PageBase<AnswerBankPresenter, IAnswerBankView>, IAnswerBankView
    {
        private const string QuestionId = "questionId";

        public IEnumerable<QuestionCategory> MasterCategories
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                MasterCategoriesList.DataSource = value;
                MasterCategoriesList.DataValueField = "QuestionCategoryId";
                MasterCategoriesList.DataTextField = "Category";
                MasterCategoriesList.DataBind();
            }
        }

        public IEnumerable<QuestionCategory> Subcategories
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                if (value.IsNullOrEmpty())
                {
                    SubcategoriesList.Items.Add(new ListItem("Please select a master category.", "0"));
                }
                else
                {
                    SubcategoriesList.Items.Clear();
                    SubcategoriesList.DataSource = value;
                    SubcategoriesList.DataValueField = "QuestionCategoryID";
                    SubcategoriesList.DataTextField = "Category";
                    SubcategoriesList.DataBind();
                }
            }
        }

        public IEnumerable<Question> SelectedQuestions
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                QuestionsList.DataSource = value;
                QuestionsList.DataBind();
            }
        }

        public IEnumerable<Question> AllQuestions
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                AllQuestionsList.DataValueField = "QuestionId";
                AllQuestionsList.DataTextField = "Value";
                AllQuestionsList.DataSource = value ?? Enumerable.Empty<Question>();
                AllQuestionsList.DataBind();
            }
        }
        
        private void InitializeEvents()
        {
            QuestionSearchControl.SearchSelected += SearchSelected;
        }

        private void SearchSelected(object sender, SearchEventArgs e)
        {
            DataBindQuestions(e.SearchItem);
        }

        protected void MasterCategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MasterCategoriesList.SelectedIndex > -1)
            {
                DataBindSubcategories(Int32.Parse(MasterCategoriesList.SelectedValue));
            }
        }

        protected void ViewQuestions_Clicked(object sender, EventArgs e)
        {
            if (SubcategoriesList.SelectedIndex >= 0 && Int32.Parse(SubcategoriesList.SelectedValue) > 0)
            {
                DataBindQuestions(Int32.Parse(SubcategoriesList.SelectedValue));
            }
        }

        protected void ViewSelectedQuestion_Click(object sender, EventArgs e)
        {
            //if (AllQuestionsList.SelectedIndex >= 0)
            //{
            //    Presenter.GetQuestionById(Int32.Parse(AllQuestionsList.SelectedValue));
            //}
            //else
            //{
            //    MessageBox.Show("Please select a question.");
            //}
        }

        private void DataBindAllQuestions()
        {
            //Presenter.GetAllQuestions();
        }

        private void DataBindMasterCategories()
        {
            //Presenter.GetMasterCategories();
        }

        private void DataBindSelectedQuestion()
        {
            //var questionId = GetQuestionId();

            //if (questionId > 0)
            //{
            //    Presenter.GetQuestionById(questionId);
            //}
        }

        private int GetQuestionId()
        {
            throw new NotImplementedException();
            //var questionId = 0;
            
            //if (!String.IsNullOrEmpty(Request.QueryString[QuestionId]))
            //{
            //    Int32.TryParse(Request.QueryString[QuestionId], out questionId);
            //}
            //else if (Page.RouteData.Values.ContainsKey("questionName") &&
            //    !String.IsNullOrEmpty(Page.RouteData.Values["questionName"].ToString()))
            //{
            //    questionId = ParseRouteData(Page.RouteData.Values["questionName"].ToString());
            //}

            //return questionId;
        }

        private int ParseRouteData(string questionName)
        {
            throw new NotImplementedException();
            //var urlEntryDataProvider = Container.Resolve<IUrlEntryDataProvider>();
            //var questionDataProvider = Container.Resolve<IQuestionDataProvider>();
            //var urlEntry = urlEntryDataProvider.GetUrlEntryByKey(questionName);

            //if (urlEntry == null)
            //{
            //    return 0;
            //}

            //var question = questionDataProvider.GetQuestionById(urlEntry.ObjectId);

            //return question == null ? 0 : question.Id;
        }

        private void DataBindSubcategories(int parentCategoryId)
        {
            throw new NotImplementedException();
            //Presenter.GetSubcategoriesByParentId(parentCategoryId);
            //SubcategoriesList.Items.Insert(0, new ListItem { Value = "0", Text = Resources.TightlyCurly.Com.Web.selectSubTopicText });
        }

        private void DataBindQuestions(string searchText)
        {
            //Presenter.GetQuestionsByCriteria(searchText);
        }

        private void DataBindQuestions(int subcategoryId)
        {
            //Presenter.GetQuestionsBySubcategoryId(subcategoryId);
        }
    }
}