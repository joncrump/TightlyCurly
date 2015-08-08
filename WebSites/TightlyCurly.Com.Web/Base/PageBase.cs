using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Web.UserControls;

namespace TightlyCurly.Com.Web
{
    public abstract class PageBase<T, U> : Page where T : class
    {
        //protected IConfigurationHelper _configuration = Container.Resolve<IConfigurationHelper>();
        //private object _view;
        //private T _presenter;

        protected T Presenter
        {
            get 
            { 
                throw new NotImplementedException();
                //return _presenter ?? (_presenter = PresenterFactory.GetPresenter<T, U>(_view)); 
            }
        }

        public MessageBox MessageBox
        {
            get
            {
                return (MessageBox)Master.FindControl(TightlyCurly.Com.Web.Common.Constants.ControlConstants.MessageBox);
            }
        }

        protected void Initialize(object view)
        {
            //_view = view;
        }

        protected override void OnPreInit(EventArgs e)
        {
            SetBrowserCapabilities();
            base.OnPreInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            if (SiteMap.CurrentNode != null && !String.IsNullOrEmpty(SiteMap.CurrentNode.Title))
            {
                Title = SiteMap.CurrentNode.Title;
            }

            base.OnLoad(e);
        }

        protected void SetPageMetadata(string title)
        {
            var pageTitle = Master.FindControl("PageTitleText") as Literal;

            if (pageTitle != null && !String.IsNullOrEmpty(title))
            {
                pageTitle.Text = title;
                Title = title;
            }
        }

        private void SetBrowserCapabilities()
        {
            if (PageContext.Current.UserAgent.IndexOf("WebKit") >= 0
                || PageContext.Current.UserAgent.IndexOf("Chrome") >= 0)
            {
                Request.Browser.Adapters.Clear();
                Page.ClientTarget = "uplevel";
            }
        }
    }
}
