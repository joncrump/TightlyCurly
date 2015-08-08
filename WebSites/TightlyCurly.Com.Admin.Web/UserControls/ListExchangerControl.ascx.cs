using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Common;
using System.Text;

namespace TightlyCurly.Com.Admin.Web.UserControls
{
    public partial class ListExchangerControl : System.Web.UI.UserControl
    {
        #region Fields

        public delegate void ClickHandler(object sender, ListExchangerEventArgs e);
        
        public event ClickHandler LeftClicked;
        public event ClickHandler RightClicked;

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public string DataTextField { get; set; }
        public string DataValueField { get; set; }
                
        public IEnumerable<object> LeftDataSource
        {
            get
            {
                List<object> values = new List<object>();

                if (Left.Items != null && Left.Items.Count > 0)
                {
                    foreach (var item in Left.Items)
                    {
                        values.Add(item);
                    }
                }

                return values;
            }
            set
            {
                Left.DataSource = value;
                Left.DataTextField = DataTextField;
                Left.DataValueField = DataValueField;
                Left.DataBind();
            }
        }

        public IEnumerable<object> RightDataSource
        {
            get
            {
                List<object> values = new List<object>();

                if (Right.Items != null && Right.Items.Count > 0)
                {
                    foreach (var item in Right.Items)
                    {
                        values.Add(item);
                    }
                }

                return values;
            }
            set
            {
                Right.DataSource = value;
                Right.DataTextField = DataTextField;
                Right.DataValueField = DataValueField;
                Right.DataBind();
            }
        }

        public string LeftText
        {
            set
            {
                LeftLabel.Text = value;
            }
        }

        public string RightText
        {
            set
            {
                RightLabel.Text = value;
            }
        }

        public Unit ListWidth
        {
            set
            {
                Left.Width = value;
                Right.Width = value;
            }
        }

        public string ButtonCssClass
        {
            set
            {
                SwitchLeft.CssClass = value;
                SwitchRight.CssClass = value;
            }
        }

        public int LeftSelectedIndex
        {
            get
            {
                return Left.SelectedIndex;
            }
        }

        public string LeftSelectedValue
        {
            get
            {
                return Left.SelectedValue;
            }
        }

        public ListItem LeftSelectedItem
        {
            get
            {
                return Left.SelectedItem;
            }
        }

        public int RightSelectedIndex
        {
            get
            {
                return Right.SelectedIndex;
            }
        }

        public string RightSelectedValue
        {
            get
            {
                return Right.SelectedValue;
            }
        }

        public ListItem RightSelectedItem
        {
            get
            {
                return Right.SelectedItem;
            }
        }

        public string LeftClientID
        {
            get
            {
                return Left.ClientID;
            }
        }

        public string RightClientID
        {
            get
            {
                return Right.ClientID;
            }
        }

        #endregion

        #region Methods

        protected void SwitchLeft_Click(object sender, EventArgs e)
        {
            if (Left.SelectedIndex >= 0)
            {
                var selectedItem = Left.SelectedItem;
                var exchangerEventArgs = new ListExchangerEventArgs(selectedItem);

                OnLeftClicked(new ListExchangerEventArgs(selectedItem));

                Left.Items.Remove(selectedItem);
                Right.Items.Add(selectedItem);
                Left.SelectedIndex = -1;
                Right.SelectedIndex = -1;
            }
        }

        protected void SwitchRight_Click(object sender, EventArgs e)
        {
            if (Right.SelectedIndex >= 0)
            {
                var selectedItem = Right.SelectedItem;
                var exchangerEventArgs = new ListExchangerEventArgs(selectedItem);
                
                OnRightClicked(exchangerEventArgs);

                Right.Items.Remove(selectedItem);
                Left.Items.Add(selectedItem);
                Right.SelectedIndex = -1;
                Left.SelectedIndex = -1;
            }
        }

        private void OnLeftClicked(ListExchangerEventArgs e)
        {
            if (LeftClicked != null)
            {
                LeftClicked(this, e);
            }
        }

        private void OnRightClicked(ListExchangerEventArgs e)
        {
            if (RightClicked != null)
            {
                RightClicked(this, e);
            }
        }

        #endregion
    }
}