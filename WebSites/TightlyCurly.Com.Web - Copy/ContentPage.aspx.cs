namespace TightlyCurly.Com.Web
{
    public partial class ContentPage //: PageBase<ContentPagePresenter, IContentPageView>, IContentPageView
    {
        public string MetaDescription
        {
            get;
            set;
            //get 
            //{ 
            //    throw new NotImplementedException(); 
            //}
            //set 
            //{
            //    if (!String.IsNullOrEmpty(value))
            //    {
            //        var htmlMeta = new HtmlMeta
            //            {
            //                Name = "description",
            //                Content = value
            //            };
            //        Header.Controls.Add(htmlMeta);
            //    }
            //}
        }

        public string MetaKeywords
        {
            get;
            set;
            //get 
            //{ 
            //    throw new NotImplementedException(); 
            //}
            //set 
            //{
            //    if (!String.IsNullOrEmpty(value))
            //    {
            //        var htmlMeta = new HtmlMeta
            //            {
            //                Name = "keywords",
            //                Content = value
            //            };
            //        Header.Controls.Add(htmlMeta);
            //    }
            //}
        }

        public string PageTitle
        {
            get;
            set;
            //get
            //{
            //    return Title;
            //}
            //set
            //{
            //    Title = value;
            //}
        }

        public string Description
        {
            get;
            set;
            //get
            //{
            //    var master = Master as Master;

            //    if (master != null)
            //    {
            //        var pageTitle = master.FindControl("PageTitleText") as Literal;

            //        if (pageTitle != null)
            //        {
            //            return pageTitle.Text;
            //        }
            //    }

            //    return String.Empty;
            //}
            //set
            //{
            //    var master = Master as Master;

            //    if (master != null)
            //    {
            //        var pageTitle = master.FindControl("PageTitleText") as Literal;

            //        if (pageTitle != null)
            //        {
            //            pageTitle.Text = value;
            //        }
            //    }
            //}
        }

        public string Content
        {
            get
            {
                return PageContent.Text;
            }
            set
            {
                PageContent.Text = value;
            }
        }
    }
}
