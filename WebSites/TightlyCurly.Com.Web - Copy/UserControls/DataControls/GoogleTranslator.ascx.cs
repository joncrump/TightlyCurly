using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TightlyCurly.Com.Web.UserControls.DataControls
{
    public partial class GoogleTranslator : System.Web.UI.UserControl
    {
        #region Fields

        private const string Script = "<script type=\"text/javascript\">function translate(pattern){if(pattern&&pattern!='undefined'){var destination='http://www.google.com/translate?u='+window.location.href+'&langpair='+pattern+'&hl=en&ie=UTF8';window.open(dest,'subwindow','toolbar=yes,location=yes, directories=yes,status=yes,scrollbars=yes,menubar=yes,resizable=yes,left=0,top=0');}}</script>";
        private const string ScriptKey = "translate";

        #endregion

        protected override void OnLoad(EventArgs e)
        {
            if (!Page.ClientScript.IsStartupScriptRegistered(ScriptKey))
            {
                Page.ClientScript.RegisterStartupScript(this.Page.GetType(), ScriptKey, Script);
            }

            base.OnLoad(e);
        }
    }
}