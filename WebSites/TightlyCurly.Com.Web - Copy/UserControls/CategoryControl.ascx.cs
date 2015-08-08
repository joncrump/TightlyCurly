using System;
using System.Collections.Generic;
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
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Web.Configuration;

namespace TightlyCurly.Com.Web.UserControls
{
    public partial class CategoryControl : UserControl
    {
        #region Fields

        public event EventHandler<ItemSelectedEventArgs> ItemSelected;

        private CategoryElementCollection _categories;

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public CategoryElementCollection Categories//IEnumerable<Category> Categories
        {
            set
            {
                _categories = value;
            }
            get
            {
                return _categories;
            }
        }

        #endregion

        #region Methods

        protected override void OnLoad(EventArgs e)
        {
            foreach (Category category in Categories)
            {
                LinkButton button = new LinkButton();
                button.ID = category.CategoryName;
                button.Text = category.CategoryName;
                button.Click += SelectedClicked;
                button.CommandArgument = category.Arguments;

                Controls.Add(button);
                Controls.Add(new LiteralControl("&nbsp;"));
            }

            base.OnLoad(e);
        }

        protected void SelectedClicked(object sender, EventArgs e)
        {
            LinkButton button = sender as LinkButton;

            if (button != null)
            {
                OnItemSelected(button.CommandArgument);
            }
        }

        private void OnItemSelected(string selectedItem)
        {
            if (ItemSelected != null)
            {
                ItemSelected(this, new ItemSelectedEventArgs(selectedItem));
            }
        }

        #endregion
    }
}