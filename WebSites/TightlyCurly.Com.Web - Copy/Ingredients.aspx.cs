using System.Web.UI;
using TightlyCurly.Com.Web.MasterPages;

namespace TightlyCurly.Com.Web
{
    public partial class Ingredients : Page
    {
        #region Fields

        #endregion

        #region Constructors

        #endregion

        #region Properties

        #endregion

        #region Methods

        protected override void OnLoad(System.EventArgs e)
        {
            var master = this.Master as Master;

            if (master != null)
            {
                master.PageTitle = Resources.TightlyCurly.Com.Web.ingredientsDescription;
            }

            base.OnLoad(e);
        }

        #endregion
    }
}
