using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Common.Model.Entities;
using TightlyCurly.Com.Framework.Web.Utilities;

namespace TightlyCurly.Com.Admin.Web
{
    public partial class SettingsAdmin //: PageBase<SettingsAdminPresenter, ISettingsAdminView>, ISettingsAdminView
    {
        public IEnumerable<Setting> Settings
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                IEnumerable<Setting> settings = new List<Setting>();

                if (value != null && value.Any())
                {
                    settings = value;
                }

                SettingsView.DataSource = settings;
                SettingsView.DataBind();
            }
        }

        public string Key
        {
            get
            {
                return TextEncoder.SafeEncode(KeyText.Text);
            }
            set
            {
                KeyText.Text = value;
            }
        }

        public string Value
        {
            get
            {
                return TextEncoder.SafeEncode(ValueText.Text);
            }
            set
            {
                ValueText.Text = value;
            }
        }

        protected void SettingsView_OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            SettingsView.EditIndex = e.NewEditIndex;
            DataBindSettings();
        }

        protected void SettingsView_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            throw new NotImplementedException();
            //var Id = Int32.Parse(SettingsView.DataKeys[e.RowIndex].Value.ToString());

            //Presenter.DeleteSettingById(Id);

            //SettingsView.EditIndex = -1;
            //DataBindSettings();
        }

        protected void SettingsView_OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            throw new NotImplementedException();
            //var Id = Int32.Parse(SettingsView.DataKeys[e.RowIndex].Value.ToString());
            
            //var key = ((TextBox)SettingsView.Rows[e.RowIndex].FindControl("KeyEdit")).Text;
            //var value = ((TextBox)SettingsView.Rows[e.RowIndex].FindControl("ValueEdit")).Text;

            //Presenter.SaveSetting(Id, key, value, true);

            //SettingsView.EditIndex = -1;
            //DataBindSettings();
        }

        protected void SettingsView_OnRowCancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            e.Cancel = true;
            SettingsView.EditIndex = -1;
            DataBindSettings();
        }

        protected void NewSetting_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        protected void SaveSetting_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //try
            //{
            //    Presenter.SaveSetting(0, Key, Value, true);
            //    ClearFields();
            //    MessageBox.Show("Saved setting.");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    if (ex.Message == "Cannot save setting. Setting already exists.")
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
        }

        private void ClearFields()
        {
            KeyText.Text = String.Empty;
            ValueText.Text = String.Empty;
        }

        private void DataBindSettings()
        {
            //Presenter.GetAllSettings();
        }
    }
}
