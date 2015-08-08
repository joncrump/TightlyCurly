using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Framework.Web.Utilities;

namespace TightlyCurly.Com.Web.UserControls
{
    public partial class SearchControl : UserControl
    {
        #region Fields

        public event EventHandler<SearchEventArgs> SearchSelected;

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public string CssClass
        {
            set
            {
                this.searchLabel.CssClass = value;
            }
        }

        public string LabelText
        {
            set
            {
                this.searchLabel.Text = value;
            }
        }

        public string TextCssClass
        {
            set
            {
                this.searchText.CssClass = value;
            }
        }

        public string Text
        {
            set
            {
                this.searchText.Text = value;
            }
        }

        public string ButtonCssClass
        {
            set
            {
                this.searchButton.CssClass = value;
            }
        }

        public string ButtonText
        {
            set
            {
                this.searchButton.Text = value;
            }
        }

        public bool CausesValidation
        {
            set
            {
                searchValidator.Enabled = value;
            }
        }

        public string ErrorMessage
        {
            set
            {
                searchValidator.ErrorMessage = value;
            }
        }

        public string ValidationGroup
        {
            set
            {
                searchText.ValidationGroup = value;
                searchValidator.ValidationGroup = value;
                searchButton.ValidationGroup = value;
            }
        }

        public Unit TextWidth
        {
            set
            {
                searchText.Width = value;
            }
        }

        public string ServicePath
        {
            set
            {
                searchAutoComplete.ServicePath = value;
            }
        }

        public string ServiceMethod
        {
            set
            {
                searchAutoComplete.ServiceMethod = value;
            }
        }

        public bool AutoCompleteEnabled
        {
            set
            {
                this.panel.Visible = value;
                searchAutoComplete.Enabled = value;
            }
        }

        private string SearchTextValue
        {
            get
            {
                return TextEncoder.SafeEncode(searchText.Text);
            }
            set
            {
                searchText.Text = value;
            }
        }

        public MessageBox MessageBox
        {
            get
            {
                return Page.Master.FindControl(Common.Constants.ControlConstants.MessageBox) as MessageBox;
            }
        }

        #endregion

        #region Methods

        protected override void OnLoad(EventArgs e)
        {
            SearchPanel.DefaultButton = searchButton.ID;
            base.OnLoad(e);
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            var searchText = SearchTextValue;

            if (!String.IsNullOrEmpty(searchText))
            {
                OnSearched(searchText);
                SearchTextValue = String.Empty;
            }
            else
            {
                MessageBox.Show(Resources.TightlyCurly.Com.Web.noSearchTermErrorMessage);
            }
        }

        private void OnSearched(string searchValue)
        {
            if (SearchSelected != null)
            {
                SearchSelected(this, new SearchEventArgs(searchValue));
            }
        }

        #endregion
    }
}