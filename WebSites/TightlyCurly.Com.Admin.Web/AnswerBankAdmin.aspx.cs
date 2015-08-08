using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Admin.Web.UserControls;
using TightlyCurly.Com.Common.Model.Entities;

namespace TightlyCurly.Com.Admin.Web
{
    public partial class AnswerBankAdmin //: PageBase<AnswerBankAdminPresenter, IAnswerBankAdminView>, IAnswerBankAdminView
    {
        // TODO: Fix this logic.  Too convoluted.
        public Question SelectedQuestion
        {
            get
            {
                throw new NotImplementedException();
                //int questionId;

                //Int32.TryParse(QuestionIdField.Value, out questionId);

                //return new Question
                //    {
                //        QuestionId = questionId,
                //        Value = QuestionText.Text,
                //        Answer = AnswerText.Text, 
                //        QuestionCategories = GetQuestionCategories()
                //    };
            }
            set
            {
                throw new NotImplementedException();
                //var question = value;

                //if (question != null)
                //{
                //    QuestionIdField.Value = question.QuestionId.ToString();
                //    QuestionText.Text = question.Value;
                //    AnswerText.Text = question.Answer;
                //    DataBindQuestionCategoryModels(question.QuestionCategories);
                //}
                //else
                //{
                //    QuestionIdField.Value = String.Empty;
                //    QuestionText.Text = String.Empty;
                //    AnswerText.Text = String.Empty;
                //    AllSubcategoriesList.Items.Clear();
                //}
            }
        }

        public IEnumerable<QuestionCategory> AvailableMasterCategories
        {
            get;
            set;
            //get
            //{
            //    if (MasterCategoriesListExchanger.LeftDataSource != null && MasterCategoriesListExchanger.LeftDataSource.Count() > 0)
            //    {
            //        var questionModelCategoryIds = MasterCategoriesListExchanger.LeftDataSource.OfType<ListItem>().Select(listItem => Int32.Parse(listItem.Value)).ToList();

            //        return Presenter.GetQuestionCategories(questionModelCategoryIds);
            //    }

            //    return new List<QuestionCategory>();
            //}
            //set
            //{
            //    if (value != null && value.Count() > 0)
            //    {
            //        var converter = new CollectionConverter<QuestionCategory, object>(value);
            //        MasterCategoriesListExchanger.LeftDataSource = converter.Convert();
            //    }
            //    else
            //    {
            //        MasterCategoriesListExchanger.LeftDataSource = new List<object>();
            //    }
            //}
        }

        public IEnumerable<QuestionCategory> AppliedMasterCategories
        {
            get;
            set;
            //get
            //{
            //    if (MasterCategoriesListExchanger.RightDataSource != null && MasterCategoriesListExchanger.RightDataSource.Count() > 0)
            //    {
            //        var questionModelCategoryIds = MasterCategoriesListExchanger.RightDataSource.OfType<ListItem>().Select(listItem => Int32.Parse(listItem.Value)).ToList();

            //        return Presenter.GetQuestionCategories(questionModelCategoryIds);
            //    }

            //    return new List<QuestionCategory>();
            //}
            //set
            //{
            //    if (value != null && value.Count() > 0)
            //    {
            //        var converter = new CollectionConverter<QuestionCategory, object>(value);
            //        MasterCategoriesListExchanger.RightDataSource = converter.Convert();
            //    }
            //    else
            //    {
            //        MasterCategoriesListExchanger.RightDataSource = new List<object>();
            //    }
            //}
        }

        public IEnumerable<QuestionCategory> AvailableSubcategories
        {
            get;
            set;
            //get
            //{
            //    if (SubCategoriesListExchanger.LeftDataSource != null && SubCategoriesListExchanger.LeftDataSource.Count() > 0)
            //    {
            //        var questionModelCategoryIds = SubCategoriesListExchanger.LeftDataSource.OfType<ListItem>().Select(listItem => Int32.Parse(listItem.Value)).ToList();

            //        return Presenter.GetQuestionCategories(questionModelCategoryIds);
            //    }

            //    return new List<QuestionCategory>();
            //}
            //set
            //{
            //    if (value != null && value.Count() > 0)
            //    {
            //        var converter = new CollectionConverter<QuestionCategory, object>(value);
            //        SubCategoriesListExchanger.LeftDataSource = converter.Convert();
            //    }
            //    else
            //    {
            //        SubCategoriesListExchanger.LeftDataSource = new List<object>();
            //    }
            //}
        }

        public IEnumerable<QuestionCategory> AppliedSubcategories
        {
            get;
            set;
            //get
            //{
            //    if (SubCategoriesListExchanger.RightDataSource != null && SubCategoriesListExchanger.RightDataSource.Count() > 0)
            //    {
            //        var questionModelCategoryIds = SubCategoriesListExchanger.RightDataSource.OfType<ListItem>().Select(listItem => Int32.Parse(listItem.Value)).ToList();

            //        return Presenter.GetQuestionCategories(questionModelCategoryIds);
            //    }

            //    return new List<QuestionCategory>();
            //}
            //set
            //{
            //    if (value != null && value.Count() > 0)
            //    {
            //        var converter = new CollectionConverter<QuestionCategory, object>(value);
            //        SubCategoriesListExchanger.RightDataSource = converter.Convert();
            //    }
            //    else
            //    {
            //        SubCategoriesListExchanger.RightDataSource = new List<object>();
            //    }
            //}
        }

        public IEnumerable<Question> Questions
        {
            get
            {
                return null;
            }
            set
            {
                QuestionsList.DataSource = value;
                QuestionsList.DataValueField = "QuestionId";
                QuestionsList.DataTextField = "Value";
                QuestionsList.DataBind();
            }
        }

        public Uri SelectedUri
        {
            get
            {
                Uri uri;

                Uri.TryCreate(SelectedUriText.Text, UriKind.RelativeOrAbsolute, out uri);

                return uri;
            }
            set 
            {
                SelectedUriText.Text = value == null ? String.Empty : value.ToString();
            }
        }

        protected void NewQuestion_Click(object sender, EventArgs e)
        {
            SelectedQuestion = null;
            AvailableMasterCategories = null;
            AppliedMasterCategories = null;
            AvailableSubcategories = null;
            AppliedSubcategories = null;
            AllSubcategoriesList.Items.Clear();
            NewMasterCategory.Text = String.Empty;
            NewSubcategory.Text = String.Empty;
            DataBindQuestions();
        }

        protected void DeleteQuestion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //if (QuestionsList.SelectedIndex >= 0)
            //{
            //    var questionId = Int32.Parse(QuestionsList.SelectedValue);
            //    Presenter.DeleteQuestion(questionId);
            //    MessageBox.Show("Question deleted");
            //    DataBindQuestions();
            //}
            //else
            //{
            //    MessageBox.Show("Please select a question");
            //}
        }

        protected void EditQuestion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //if (QuestionsList.SelectedIndex >= 0)
            //{
            //    var questionId = Int32.Parse(QuestionsList.SelectedValue);
            //    var masterCategoryId = 0;
            //    var selected = false;

            //    Presenter.GetQuestionById(questionId);

            //    if (MasterCategoriesListExchanger.RightDataSource != null && MasterCategoriesListExchanger.RightDataSource.Count() > 0)
            //    {
            //        foreach (var item in MasterCategoriesListExchanger.RightDataSource)
            //        {
            //            var listItem = item as ListItem;

            //            if (listItem != null)
            //            {
            //                if (listItem.Selected)
            //                {
            //                    masterCategoryId = Int32.Parse(listItem.Value);
            //                    selected = true;
            //                    break;
            //                }
            //            }
            //        }

            //        if (!selected)
            //        {
            //            var listItem = MasterCategoriesListExchanger.RightDataSource.Take(1).SingleOrDefault() as ListItem;

            //            if (listItem != null)
            //            {
            //                masterCategoryId = Int32.Parse(listItem.Value);
            //            }
            //        }
            //    }

            //    if (masterCategoryId >= 0 && questionId >= 0)
            //    {
            //        Presenter.GetSubcategoriesByQuestionIdAndParentCategoryId(questionId, masterCategoryId);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a question.");
            //}
        }

        protected void SaveQuestion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //try
            //{
            //    if (SelectedQuestion != null)
            //    {
            //        if (ValidateMasterCategories())
            //        {
            //            Presenter.SaveQuestion(SelectedQuestion.QuestionId, SelectedQuestion.Value, SelectedQuestion.Answer, SelectedQuestion.QuestionCategories);
            //            MessageBox.Show("Saved question successfully.");
            //            SelectedIndexField.Value = QuestionsList.SelectedIndex.ToString();
            //            DataBindQuestions();
            //        }
            //        else
            //        {
            //            MessageBox.Show(
            //                "Cannot save question.  One or more master categories do not have subcategories attached.");
            //        }
            //    }
            //}
            //catch (ArgumentNullException ex)
            //{
            //    if (ex.ParamName == "questionCategories")
            //    {
            //        MessageBox.Show("You cannot save a question without a subcategory!  Please select a subcategory.");
            //    }
            //}
        }

        protected void AddMasterCategory_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //try
            //{
            //    Presenter.AddMasterCategory(NewMasterCategory.Text);
            //    MessageBox.Show(String.Format("Added category {0}", NewMasterCategory.Text));
            //    NewMasterCategory.Text = String.Empty;
            //}
            //catch (DuplicateItemException ex)
            //{
            //    MessageBox.Show("Cannot add category. " + ex.Message);
            //}
        }

        protected void ViewSubcategories_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //if (MasterCategoriesListExchanger.RightSelectedIndex >= 0)
            //{
            //    int selectedMasterCategoryId;

            //    if (Int32.TryParse(MasterCategoriesListExchanger.RightSelectedValue, out selectedMasterCategoryId))
            //    {
            //        Presenter.GetSubcategoriesByQuestionIdAndParentCategoryId(SelectedQuestion.QuestionId, selectedMasterCategoryId);
            //    }
            //}
        }

        protected void AddSubcategory_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //try
            //{
            //    if (MasterCategoriesListExchanger.RightSelectedIndex >= 0)
            //    {
            //        int selectedMasterCategoryId;

            //        Int32.TryParse(MasterCategoriesListExchanger.RightSelectedValue, out selectedMasterCategoryId);
            //        Presenter.AddSubcategory(NewSubcategory.Text, selectedMasterCategoryId);
            //        NewSubcategory.Text = String.Empty;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please select a master category.");
            //    }
            //}
            //catch (DuplicateItemException ex)
            //{
            //    MessageBox.Show("Cannot add subcategory. " + ex.Message);
            //}
        }

        protected void DeleteMasterCategory_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //try
            //{
            //    if (MasterCategoriesListExchanger.LeftSelectedIndex >= 0)
            //    {
            //        var questionCategoryId = Int32.Parse(MasterCategoriesListExchanger.LeftSelectedValue);

            //        var questionCategory = Presenter.GetQuestionCategories(new[] { questionCategoryId }).SingleOrDefault();

            //        if (questionCategory != null)
            //        {
            //            Presenter.RemoveCategory(questionCategory);

            //            var availableMasterCategories = AvailableMasterCategories;

            //            AvailableMasterCategories = from qc in availableMasterCategories
            //                                        where qc.QuestionCategoryId != questionCategoryId
            //                                        orderby qc.Category
            //                                        select qc;

            //            MessageBox.Show("Deleted master category successfully.");
            //        }
            //        else
            //        {
            //            throw new InvalidOperationException("Could not delete question category.  Category doesn't exist.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please select a master category to delete.");
            //    }
            //}
            //catch (InvalidOperationException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        protected void DeleteSubcategory_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //try
            //{
            //    if (SubCategoriesListExchanger.LeftSelectedIndex >= 0)
            //    {
            //        var questionCategoryId = Int32.Parse(SubCategoriesListExchanger.LeftSelectedValue);

            //        var questionCategory = Presenter.GetQuestionCategories(new[] { questionCategoryId }).SingleOrDefault();

            //        if (questionCategory != null)
            //        {
            //            Presenter.RemoveCategory(questionCategory);

            //            var availableSubcategories = AvailableSubcategories;

            //            AvailableSubcategories = from qc in availableSubcategories
            //                                        where qc.QuestionCategoryId != questionCategoryId
            //                                        orderby qc.Category
            //                                        select qc;

            //            MessageBox.Show("Deleted subcategory successfully.");
            //        }
            //        else
            //        {
            //            throw new InvalidOperationException("Could not delete question category.  Category doesn't exist.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please select a subcategory to delete.");
            //    }
            //}
            //catch (InvalidOperationException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        //  TODO: Refactor arrow code
        protected void DeleteSubcategoryFromQuestion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //if (AllSubcategoriesList.SelectedIndex >= 0)
            //{
            //    int questionCategoryId;

            //    if (Int32.TryParse(AllSubcategoriesList.SelectedValue, out questionCategoryId) && questionCategoryId > 0)
            //    {
            //        var questionCategory = Presenter.GetQuestionCategories(new List<int> { questionCategoryId }).SingleOrDefault();

            //        if (questionCategory != null)
            //        {
            //            Presenter.RemoveSubcategoryFromQuestion(questionCategory);

            //            var items = SubCategoriesListExchanger.RightDataSource;

            //            if (items != null && items.Count() > 0)
            //            {
            //                foreach (var item in items)
            //                {
            //                    var listItem = item as ListItem;

            //                    if (listItem != null)
            //                    {
            //                        var selectedQuestionCategoryId = Int32.Parse(listItem.Value);
            //                        if (selectedQuestionCategoryId == questionCategoryId)
            //                        {
            //                            var appliedSubcategories = AppliedSubcategories;

            //                            AppliedSubcategories = from qc in appliedSubcategories
            //                                                   where qc.QuestionCategoryId != selectedQuestionCategoryId
            //                                                   select qc;

            //                            var availableSubcategories = AvailableSubcategories.ToList();
            //                            availableSubcategories.Add(Presenter.GetQuestionCategories(new[] { selectedQuestionCategoryId }).Single());
            //                            AvailableSubcategories = availableSubcategories;
            //                            break;
            //                        }
            //                    }
            //                }
            //            }

            //            MessageBox.Show(String.Format("Deleted subcategory {0}", questionCategory.Category));
            //        }
            //        else
            //        {
            //            throw new InvalidOperationException("Could not delete subcategory.");
            //        }
            //    }
            //    else
            //    {
            //        throw new InvalidOperationException("Could not delete subcategory.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please select a subcategory");
            //}
        }

        private void OnSubcategoryAdded(object sender, ListExchangerEventArgs e)
        {
            throw new NotImplementedException();
            //var questionCategoryModelItem = e.Data as ListItem;

            //if (questionCategoryModelItem != null)
            //{
            //    AllSubcategoriesList.Items.Add(questionCategoryModelItem);
            //}
        }

        private void OnSubcategoryRemoved(object sender, ListExchangerEventArgs e)
        {
            throw new NotImplementedException();
            //var questionCategoryModelItem = e.Data as ListItem;

            //if (questionCategoryModelItem != null)
            //{
            //    AllSubcategoriesList.Items.Remove(questionCategoryModelItem);
            //}
        }

        private void OnMasterCategoryRemoved(object sender, ListExchangerEventArgs e)
        {
            throw new NotImplementedException();
            //var masterCategory = e.Data as ListItem;

            //if (masterCategory != null)
            //{
            //    var question = SelectedQuestion;

            //    var removedSubcategories = question.QuestionCategories.Where(qc => qc.ParentId == Int32.Parse(masterCategory.Value));

            //    var availableSubcategories = AvailableSubcategories;
            //    AvailableSubcategories = availableSubcategories.Concat(removedSubcategories);

            //    var appliedSubcategories = AppliedSubcategories;

            //    AppliedSubcategories =
            //        appliedSubcategories.Where(
            //            qc => !(removedSubcategories.Select(q => q.QuestionCategoryId)).Contains(qc.QuestionCategoryId));

            //    var allSubcategoryItems = AllSubcategoriesList.Items.Cast<ListItem>().ToArray();
                                         
            //    for (var index = 0; index < allSubcategoryItems.Length; index++)
            //    {
            //        foreach (var removedSubcategory in removedSubcategories)
            //        {
            //            if (Int32.Parse(allSubcategoryItems[index].Value) == removedSubcategory.QuestionCategoryId)
            //            {
            //                AllSubcategoriesList.Items.RemoveAt(index);
            //            }
            //        }
            //    }
            //}
        }

        private void Initialize()
        {
            DataBindQuestions();
        }

        private void DataBindQuestions()
        {
            //Presenter.GetAllQuestions();

            //int questionId;
            //Int32.TryParse(QuestionIdField.Value, out questionId);
            //Presenter.GetMasterCategoriesByQuestionId(questionId);

            //int selectedIndex;

            //if (Int32.TryParse(SelectedIndexField.Value, out selectedIndex))
            //{
            //    QuestionsList.SelectedIndex = selectedIndex;
            //}
        }

        private void DataBindQuestionCategoryModels(IEnumerable<QuestionCategory> questionCategories)
        {
            if (questionCategories != null && questionCategories.Count() > 0)
            {
                AllSubcategoriesList.DataValueField = "QuestionCategoryId";
                AllSubcategoriesList.DataTextField = "Category";
                AllSubcategoriesList.DataSource = questionCategories;
                AllSubcategoriesList.DataBind();
            }
            else
            {
                AllSubcategoriesList.Items.Clear();
            }
        }

        private IEnumerable<QuestionCategory> GetQuestionCategories()
        {
            throw new NotImplementedException();
            //if (AllSubcategoriesList.Items.Count > 0)
            //{
            //    var questionCategoryIds = (AllSubcategoriesList.Items.Cast<ListItem>().Select(
            //        item => Int32.Parse(item.Value))).ToList();

            //    return Presenter.GetQuestionCategories(questionCategoryIds);
            //}

            //return new List<QuestionCategory>();
        }

        private bool ValidateMasterCategories()
        {
            throw new NotImplementedException();
            //var appliedMasterCategories = AppliedMasterCategories;
            //var appliedSubcategories = SelectedQuestion.QuestionCategories;
            //var isValid = false;

            //foreach (var appliedMasterCategory in appliedMasterCategories)
            //{
            //    foreach (var appliedSubcategory in appliedSubcategories)
            //    {
            //        if (appliedSubcategory.ParentId == appliedMasterCategory.QuestionCategoryId)
            //        {
            //            isValid = true;
            //            break;
            //        }

            //        isValid = false;
            //    }
            //}

            //return isValid;
        }
    }
}