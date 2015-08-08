using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using TightlyCurly.Com.Common;
using TightlyCurly.Com.Web.UserControls;
using Constants=TightlyCurly.Com.Web.Common.Constants;

namespace TightlyCurly.Com.Web
{
    public abstract class UserControlBase<T, U> : UserControl where T : class
    {
        private object _view;
        private T _presenter;

        protected T Presenter
        {
            get
            {
                throw new NotImplementedException();
                //if (_presenter == null)
                //{
                //    _presenter = PresenterFactory.GetPresenter<T, U>(_view);
                //}

                //return _presenter;
            }
        }

        protected void Initialize(object view)
        {
            _view = view;
        }
    }
}
