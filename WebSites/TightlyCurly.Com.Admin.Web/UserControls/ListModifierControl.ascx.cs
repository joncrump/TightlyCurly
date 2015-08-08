using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TightlyCurly.Com.Admin.Web.UserControls
{
    public partial class ListModifierControl : System.Web.UI.UserControl
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
                TitleText.Text = value;
            }
        }

        public IEnumerable<string> Values
        {
            get
            {
                return GetValues();
            }
            set
            {
                DataBindValues(value);
            }
        }

        #endregion

        #region Methods

        private void DataBindValues(IEnumerable<string> values)
        {
            if (values != null && values.Count() >= 0)
            {
                ValuesList.DataSource = values;
                ValuesList.DataBind();
            }
        }

        private IEnumerable<string> GetValues()
        {
            List<string> values = new List<string>();

            foreach (ListItem item in ValuesList.Items)
            {
                values.Add(item.Text);
            }

            return values;
        }

        public void Reset()
        {
            Reset(true);
        }

        private void Reset(bool clearList)
        {
            ItemValue.Text = null;

            if (clearList)
            {
                ValuesList.Items.Clear();
            }
        }

        protected void Edit_Clicked(object sender, EventArgs e)
        {
            if (ValuesList.SelectedIndex >= 0)
            {
                ValuesIndex.Value = ValuesList.SelectedIndex.ToString();
                ItemValue.Text = ValuesList.SelectedItem.Text;
                Save.Text = "Save Item";
            }
        }
        
        protected void Remove_Clicked(object sender, EventArgs e)
        {
            if (ValuesList.SelectedIndex >= 0)
            {
                ValuesList.Items.RemoveAt(ValuesList.SelectedIndex);
                Reset(false);
            }
        }

        protected void Save_Clicked(object sender, EventArgs e)
        {
            int valueId = 0;

            if (!String.IsNullOrEmpty(ItemValue.Text))
            {
                if (Int32.TryParse(ValuesIndex.Value, out valueId))
                {
                    ValuesList.Items[valueId].Value = ItemValue.Text;
                    ValuesList.Items[valueId].Text = ItemValue.Text;
                }
                else
                {
                    ValuesList.Items.Add(new ListItem(ItemValue.Text));
                }

                ValuesIndex.Value = null;
                ValuesList.SelectedIndex = -1;
                Save.Text = "Add Item";
                Reset(false);
            }
        }

        #endregion
    }
}