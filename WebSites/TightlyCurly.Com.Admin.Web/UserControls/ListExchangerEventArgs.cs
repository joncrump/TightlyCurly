using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TightlyCurly.Com.Admin.Web.UserControls
{
    public class ListExchangerEventArgs : EventArgs
    {
        public ListExchangerEventArgs(object value)
        {
            Data = value;
        }

        public object Data { get; set; }
    }
}
