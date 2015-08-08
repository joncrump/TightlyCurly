using System;

namespace TightlyCurly.Com.Web.MasterPages
{
    public partial class Master : System.Web.UI.MasterPage
    {
        //private readonly MasterPresenter _masterPresenter;

        public Master()
        {
            //DisplayPicker = true;
          
            //_masterPresenter = new MasterPresenter(this,
            //    Container.Resolve<IConfigurationHelper>(),
            //    Container.Resolve<ISettingsHelper>(),
            //    Container.Resolve<ISiteMapWrapper>());
        }

        public bool DisplayPicker { get; set; }
        
        public string PageTitle
        {
            get 
            {
				throw new NotImplementedException();
                //return PageTitleText.Text;
            }
            set 
            { 
				throw new NotImplementedException();
                //PageTitleText.Text = value; 
            }
        }

        public bool EnableAnalytics
        {
            get 
            {
                return GoogleAnalytics.Visible;
            }
            set 
            { 
                GoogleAnalytics.Visible = value; 
            }
        }

        public string SiteBulletin
        {
            get 
            {
				throw new NotImplementedException();
                //return SiteBulletinContainerText.Text;
            }
            set 
            {
				throw new NotImplementedException();
                //SiteBulletinContainer.Visible = !String.IsNullOrEmpty(value);
                //SiteBulletinContainerText.Text = value;
            }
        }

        public string SiteBulletinCssClass
        {
            get
            {
				throw new NotImplementedException();
                //return SiteBulletinContainer.CssClass;
            }
            set
            {
				throw new NotImplementedException();
                //SiteBulletinContainer.CssClass = value;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetPageOptions();
        }

        private void FormatLeftRail()
        {
			throw new NotImplementedException();
            //LeftMenu.StaticEnableDefaultPopOutImage = false;
        }

        private void SetPageOptions()
        {
			throw new NotImplementedException();
            //_masterPresenter.SetViewProperties();
            //FormatLeftRail();
        }
    }
}
