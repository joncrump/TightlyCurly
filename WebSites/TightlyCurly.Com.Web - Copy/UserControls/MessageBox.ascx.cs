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
using AjaxControlToolkit;

namespace TightlyCurly.Com.Web.UserControls
{
    public partial class MessageBox : System.Web.UI.UserControl
    {
        #region Fields

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public string Title
        {
            set
            {
                this.lblTitle.Text = value;
            }
            private get
            {
                return this.lblTitle.Text;
            }
        }

        public string Message
        {
            set
            {
                this.lblMessage.Text = value;
            }
        }

        #endregion

        #region Methods

        public void Show()
        {
            this.lblTitle.Visible = !String.IsNullOrEmpty(Title);
            this.messageBoxPopUp.Show();
        }

        public void Show(string message)
        {
            Show(String.Empty, message);
        }

        public void Show(string title, string message)
        {
            if (String.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException("message");
            }

            Title = title;
            Message = message;
            Show();
        }

        #endregion
    }
}