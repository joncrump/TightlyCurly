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

namespace TightlyCurly.Com.Admin.Web
{
    public partial class _Default : Page//PageBase
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //SetPageMetadata(Resources.TightlyCurly.Com.Admin.Web.loginTitle);
            Menu menu = Master.FindControl("LeftMenu") as Menu;

            if (menu != null)
            {
                menu.Visible = false;
            }
        }
    }
}
