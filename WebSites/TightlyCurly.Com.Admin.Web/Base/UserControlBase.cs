using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Admin.Web.UserControls;

namespace TightlyCurly.Com.Admin.Web
{
    public abstract class UserControlBase : UserControl
    {
        #region Fields

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public MessageBox MessageBox
        {
            get
            {
                return Page.Master.FindControl(Constants.ControlConstants.MessageBox) as MessageBox;
            }
        }

        #endregion

        #region Methods

        #endregion
    }
}
