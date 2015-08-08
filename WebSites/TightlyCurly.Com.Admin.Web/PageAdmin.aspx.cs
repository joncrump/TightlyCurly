using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Common.Model.Entities;
using TightlyCurly.Com.Framework.Extensions;
using TightlyCurly.Com.Framework.Utilities;
using TightlyCurly.Com.Framework.Web.Utilities;

namespace TightlyCurly.Com.Admin.Web
{
    public partial class PageAdmin //: PageBase<PageAdminPresenter, IPageAdminView>, IPageAdminView
    {
        public IEnumerable<ContentItem> Pages
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                AllPagesList.DataValueField = "Id";
                AllPagesList.DataTextField = "Name";

                if (value != null && value.Any())
                {
                    AllPagesList.DataSource = value;
                }
                else
                {
                    AllPagesList.DataSource = Enumerable.Empty<ContentItem>();
                }

                AllPagesList.DataBind();
            }
        }

        public ContentItem SelectedPage
        {
            get 
            {
                return GetSelectedPage();
            }
            set 
            {
                SetSelectedPage(value);
            }
        }

        public ContentArticle SelectedPageContent
        {
            get 
            {
                return GetSelectedPageContent();
            }
            set 
            {
                SetSelectedPageContent(value);
            }
        }

        
        public Uri SelectedUri
        {
            get
            {
                Uri uri;

                Uri.TryCreate(UriText.Text, UriKind.RelativeOrAbsolute, out uri);

                return uri;
            }
            set
            {
                if (value == null)
                {
                    UriText.Text = String.Empty;
                    return;
                }

                UriText.Text = value.ToString();
            }
        }

        public IEnumerable<UrlRoute> UrlRoutes
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        protected void EditPage_Clicked(object sender, EventArgs e)
        {
            //if (AllPagesList.SelectedIndex >= 0)
            //{
            //    Presenter.GetPageById(Int32.Parse(AllPagesList.SelectedValue));
            //    SelectedPageContent = null;
            //}
            //else
            //{
            //    MessageBox.Show("Please select a page to edit");
            //}
        }

        protected void DeletePage_Clicked(object sender, EventArgs e)
        {
            //if (AllPagesList.SelectedIndex >= 0)
            //{
            //    Presenter.DeletePage(Int32.Parse(AllPagesList.SelectedValue));
            //    MessageBox.Show("Deleted page successfully.");
            //}
            //else
            //{
            //    MessageBox.Show("Please select a page to delete.");
            //}
        }

        protected void EditPageContent_Clicked(object sender, EventArgs e)
        {
            //if (PageContentList.SelectedIndex >= 0)
            //{
            //    Presenter.GetPageContentById(Int32.Parse(PageContentList.SelectedValue));
            //}
            //else
            //{
            //    MessageBox.Show("Please select a page content item.");
            //}
        }

        protected void DeletePageContent_Clicked(object sender, EventArgs e)
        {
            //if (PageContentList.SelectedIndex >= 0)
            //{
            //    Presenter.DeletePageContent(Int32.Parse(PageContentList.SelectedValue));
            //    MessageBox.Show("The page content item has been deleted.");
            //}
            //else
            //{
            //    MessageBox.Show("Please select a page content item to delete.");
            //}
        }

        protected void NewPage_Clicked(object sender, EventArgs e)
        {
            SelectedPage = null;
        }

        protected void SavePage_Clicked(object sender, EventArgs e)
        {
            //Presenter.SavePage(SelectedPage);
            //MessageBox.Show(String.Format("Saved page {0} successfully.", PageNameText.Text));
        }

        protected void NewPageContent_Clicked(object sender, EventArgs e)
        {
            SelectedPageContent = null;
        }

        protected void SavePageContent_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        //    if (SelectedPage.Id > 0)
        //    {
        //        Presenter.SavePageContent(SelectedPageContent, SelectedPage);
        //        MessageBox.Show("Saved page content");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a page before saving page content.");
        //    }
        }

        private int GetId()
        {
            int Id;
            Int32.TryParse(IdField.Value, out Id);
            return Id;
        }

        protected int GetPageContentId()
        {
            int pageContentId;
            Int32.TryParse(PageContentIdField.Value, out pageContentId);
            return pageContentId;
        }

        private ViewStatus GetViewStatus()
        {
            return EnumParser.Parse<ViewStatus>(ViewStatusList.SelectedValue);
        }

        private void SetViewStatus(ViewStatus viewStatus)
        {
            switch (viewStatus)
            {
                case ViewStatus.Normal:
                    ViewStatusList.SelectedIndex = 0;
                    break;
                case ViewStatus.UnderConstruction:
                    ViewStatusList.SelectedIndex = 1;
                    break;
                case ViewStatus.NotFound:
                    ViewStatusList.SelectedIndex = 2;
                    break;
                case ViewStatus.NotAuthorized:
                    ViewStatusList.SelectedIndex = 3;
                    break;
                default:
                    throw new ArgumentException("Unknown view status.", "viewStatus");
            }
        }

        private void DataBindPages()
        {
            //Presenter.GetAllPages();
        }

        private void DataBindPageContent(IEnumerable<ContentArticle> pageContent)
        {
            PageContentList.DataValueField = "PageContentId";
            PageContentList.DataTextField = "Title";
            PageContentList.DataSource = pageContent != null && pageContent.Any() ? pageContent : Enumerable.Empty<ContentArticle>();
            PageContentList.DataBind();

            MarkActiveContent(pageContent);
        }

        private void MarkActiveContent(IEnumerable<ContentArticle> pageContent)
        {
            if (pageContent.IsNullOrEmpty())
            {
                return;
            }

            var activePageContentId = pageContent
                .Where(pc => pc.IsActive)
                .Select(pc => pc.Id).SingleOrDefault();

            foreach (ListItem listItem in PageContentList.Items)
            {
                if (activePageContentId == Int32.Parse(listItem.Value))
                {
                    listItem.Attributes.Add("style", "background-color:#DCDCDC;");
                }
                else
                {
                    listItem.Attributes.Remove("style");
                }
            }
        }

        private void SetSelectedPage(ContentItem value)
        {
            throw new NotImplementedException();
            //if (value != null)
            //{
            //    IdField.Value = value.Id.ToString();
            //    PageNameText.Text = TextEncoder.SafeEncode(value.Name);
            //    DataBindPageContent(value.Content);
            //    SetViewStatus(value.ViewStatus);
            //    //SelectedUri = value.Uri;
            //    PageEnteredDateField.Value = value.EnteredDate.ToString();
            //    PageUpdatedDateField.Value = value.UpdatedDate.ToString();
            //}
            //else
            //{
            //    IdField.Value = String.Empty;
            //    PageNameText.Text = String.Empty;
            //    DataBindPageContent(null);
            //    SelectedUri = null;
            //    PageEnteredDateField.Value = String.Empty;
            //    PageUpdatedDateField.Value = String.Empty;
            //}
        }

        private ContentItem GetSelectedPage()
        {
            DateTime enteredDate;
            DateTime updatedDate;

            DateTime.TryParse(PageEnteredDateField.Value, out enteredDate);
            DateTime.TryParse(PageUpdatedDateField.Value, out updatedDate);

            return new ContentItem
            {
                Id = GetId(),
                Name = TextEncoder.SafeEncode(PageNameText.Text),
                ViewStatus = GetViewStatus(),
                Uri = SelectedUri,
                EnteredDate = enteredDate,
                UpdatedDate = updatedDate
            };
        }

        private void SetSelectedPageContent(ContentArticle value)
        {
            if (value != null)
            {
                PageContentIdField.Value = value.Id.ToString();
                PageContentText.Text = value.Content;
                PageContentDescriptionText.Text = value.Description;
                PageContentIsActive.Checked = value.IsActive;
                PageContentTitleText.Text = value.Title;
                PageContentMetaKeywordsText.Text = value.MetaKeywords;
                PageContentMetaDescriptionText.Text = value.MetaDescription;
                PageContentEnteredDateField.Value = value.EnteredDate.ToString();
                PageContentUpdatedDateField.Value = value.UpdatedDate.ToString();
            }
            else
            {
                PageContentIdField.Value = String.Empty;
                PageContentText.Text = String.Empty;
                PageContentDescriptionText.Text = String.Empty;
                PageContentIsActive.Checked = false;
                PageContentTitleText.Text = String.Empty;
                PageContentMetaKeywordsText.Text = String.Empty;
                PageContentMetaDescriptionText.Text = String.Empty;
                PageContentEnteredDateField.Value = String.Empty;
                PageContentUpdatedDateField.Value = String.Empty;
            }
        }

        private ContentArticle GetSelectedPageContent()
        {
            throw new NotImplementedException();
            //DateTime enteredDate;
            //DateTime updatedDate;

            //DateTime.TryParse(PageContentEnteredDateField.Value, out enteredDate);
            //DateTime.TryParse(PageContentUpdatedDateField.Value, out updatedDate);

            //return new PageContent
            //{
            //    Id = GetPageContentId(),
            //    Content = PageContentText.Text,
            //    Description = PageContentDescriptionText.Text,
            //    IsActive = PageContentIsActive.Checked,
            //    Title = PageContentTitleText.Text,
            //    LocaleId = null,
            //    MetaDescription = PageContentMetaDescriptionText.Text,
            //    MetaKeywords = PageContentMetaKeywordsText.Text,
            //    EnteredDate = enteredDate,
            //    UpdatedDate = updatedDate
            //};
        }
    }
}
