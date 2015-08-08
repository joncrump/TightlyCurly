using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Web.Configuration;

namespace TightlyCurly.Com.Web.Configuration
{
    public class Category : ConfigurationElement
    {
        [ConfigurationProperty("categoryName")]
        public string CategoryName
        {
            get
            {
                return base["categoryName"].ToString();
            }
        }

        [ConfigurationProperty("arguments")]
        public string Arguments
        {
            get
            {
                return base["arguments"].ToString();
            }
        }
    }
}
