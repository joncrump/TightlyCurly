using System;
using System.Web.UI;
using TightlyCurly.Com.Framework.Web.Utilities;

namespace TightlyCurly.Com.Web
{
    public partial class Contact : Page
    {
        public string FirstName
        {
            get
            {
                return TextEncoder.SafeEncode(FirstNameText.Text);
            }
            set
            {
                FirstNameText.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return TextEncoder.SafeEncode(LastNameText.Text);
            }
            set
            {
                LastNameText.Text = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return TextEncoder.SafeEncode(EmailAddressText.Text);
            }
            set
            {
                EmailAddressText.Text = value;
            }
        }

        public string Comments
        {
            get
            {
                return TextEncoder.SafeEncode(CommentsText.Text);
            }
            set
            {
                CommentsText.Text = value;
            }
        }

        // TODO: Remove when contact page is rewritten.
        public bool AddToBookUpdates
        {
            get
            {
                return SignUpBookUpdates.Checked;
            }
            set
            {
                SignUpBookUpdates.Checked = value;
            }
        }

        public bool Enabled { get; set;}
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //    set
        //    {
        //        if (MessageContainer != null && ContactContainer != null)
        //        {
        //            MessageContainer.Visible = !value;
        //            ContactContainer.Visible = value;
        //        }
        //    }
        //}

        public string DisabledMessage { get; set;}
        //{
        //    get
        //    {
        //        throw new NotImplementedException();
        //    }
        //    set
        //    {
        //        if (MessageContainerText != null)
        //        {
        //            MessageContainerText.Text = value;
        //        }
        //    }
        //}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            MessageContainer.Visible = !Enabled;
            ContactContainer.Visible = Enabled;
            MessageContainerText.Text = DisabledMessage;
        }

        protected void AddComments_Click(object sender, EventArgs e)
        {
            try
            {
                //Presenter.SubmitComment(FirstName, LastName, EmailAddress, Comments, AddToBookUpdates);
                ResetFields();
            }
            catch (ArgumentException ex)
            {
                if (ex.Message.Contains("The email address is invalid."))
                {
                }
                else
                {
                    throw;
                }
            }
        }

        public void ResetFields()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
            Comments = String.Empty;
            EmailAddress = String.Empty;
        }
    }
}


