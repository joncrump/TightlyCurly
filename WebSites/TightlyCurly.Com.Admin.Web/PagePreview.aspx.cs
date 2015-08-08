using System;
using System.Web;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Admin.Web.MasterPages;

namespace TightlyCurly.Com.Admin.Web
{
    public partial class PagePreview //: PageBase<PagePreviewPresenter, IPagePreviewView>, IPagePreviewView
    {
        public PagePreview() 
        {
            //Initialize(this);
        }

        public string PageTitle
        {
            get; set;
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
            get; set;
            //get
            //{
            //    var master = Master as Master;
                
            //    if (master != null)
            //    {
            //        var pageTitle = master.FindControl("pageTitle") as Literal;

            //        if (pageTitle != null)
            //        {
            //            return pageTitle.Text;
            //        }
            //    }

            //    return String.Empty;
            //}
            //set
            //{
            //    var master = Master as PreviewMaster;

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
                return PreviewContent.Text;
            }
            set
            {
                PreviewContent.Text = value;
            }
        }

        //protected override void OnLoad(EventArgs e)
        //{
        //    if (!String.IsNullOrEmpty(HttpContext.Current.Request.QueryString["pageContentId"]))
        //    {
        //        Presenter.GetPageContentById(Int32.Parse(HttpContext.Current.Request.QueryString["pageContentId"]));
        //    }

        //    base.OnLoad(e);
        //}

    }
}
