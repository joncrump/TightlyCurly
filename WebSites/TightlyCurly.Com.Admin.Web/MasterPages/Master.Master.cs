using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
//using AjaxControlToolkit;
using TightlyCurly.Com.Admin.Web.UserControls;

namespace TightlyCurly.Com.Admin.Web.MasterPages
{
    public partial class Master : System.Web.UI.MasterPage
    {
        #region Fields

        #endregion

        #region Constructors

        public Master()
        {
            DisplayPicker = true;
        }

        #endregion

        #region Properties

        public bool DisplayPicker { get; set; }

        public MessageBox MessageBox
        {
            get
            {
                return MessageBoxControl;
            }
            set
            {
                MessageBoxControl = value;
            }
        }

        #endregion

        #region Methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetPageMetadata();
            FormatLeftRail();
        }

        private void FormatLeftRail()
        {
            this.LeftMenu.StaticEnableDefaultPopOutImage = false;
        }

        private void SetPageMetadata()
        {
            if (SiteMap.CurrentNode != null && !String.IsNullOrEmpty(SiteMap.CurrentNode.Description))
            {
                this.PageTitle.Text = SiteMap.CurrentNode.Description;
            }
        }

        #endregion
    }
}
