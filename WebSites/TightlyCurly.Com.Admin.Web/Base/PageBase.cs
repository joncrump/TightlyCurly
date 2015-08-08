using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Admin.Web.UserControls;

namespace TightlyCurly.Com.Admin.Web.Base
{
    public abstract class PageBase<T, U> : Page where T : class
    {
        private object _view;
        private T _presenter;

        protected T Presenter
        {
            get 
            {
                throw new NotImplementedException();
                //if (_presenter == null)
                //{
                //    _presenter = PresenterFactory.GetPresenter<T, U>(_view);
                //}

                //return _presenter;
            }
        }

        public MessageBox MessageBox
        {
            get
            {
                return (MessageBox)Master.FindControl(Constants.ControlConstants.MessageBox);
            }
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
                this.Title = SiteMap.CurrentNode.Title;
            }

            base.OnLoad(e);
        }

        protected void Initialize(object view)
        {
            _view = view;
        }

        protected void SetPageMetadata(string title)
        {
            Literal pageTitle = this.Master.FindControl("pageTitle") as Literal;

            if (pageTitle != null && !String.IsNullOrEmpty(title))
            {
                pageTitle.Text = title;
                Title = title;
            }
        }

        private void SetBrowserCapabilities()
        {
            if (PageContext.Current.UserAgent.IndexOf("WebKit") >= 0)
            {
                Page.ClientTarget = "uplevel";
            }
        }
    }
}
