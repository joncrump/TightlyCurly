using System;
using System.Web.UI;

namespace TightlyCurly.Com.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.RedirectToRoute("Content Route", new { pageName = "welcome"});
        }
    }
}
