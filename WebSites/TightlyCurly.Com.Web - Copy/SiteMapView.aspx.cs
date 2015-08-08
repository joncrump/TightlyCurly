using System;

namespace TightlyCurly.Com.Web
{
    public partial class SiteMapView //: PageBase<SiteMapPresenter, ISiteMapView>, ISiteMapView
    {
        public string SiteMapEntries
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                //Response.Clear();
                //Response.Write(value);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        //    Presenter.GetSiteMapEntries();
        }
    }
}