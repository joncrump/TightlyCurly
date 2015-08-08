using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace TightlyCurly.Com.Web.Configuration
{
    public class SearchCategoryElement : ConfigurationElement
    {
        [ConfigurationProperty("categories")]
        [ConfigurationCollection(typeof(CategoryElementCollection), AddItemName = "category")]
        public CategoryElementCollection Categories
        {
            get
            {
                return (CategoryElementCollection)base["categories"];
            }
        }

    }
}
