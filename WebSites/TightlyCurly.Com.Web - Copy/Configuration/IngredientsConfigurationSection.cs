using System;
using System.Configuration;

namespace TightlyCurly.Com.Web.Configuration
{
    public class IngredientsConfigurationSection : ConfigurationSection
    {
        #region Fields

        #endregion

        #region Constructors

        #endregion

        #region Properties

        [ConfigurationProperty("avoidStyle", IsRequired = true)]
        public string AvoidStyle
        {
            get
            {
                return this["avoidStyle"].ToString();
            }
            set
            {
                this["avoidStyle"] = value;
            }
        }

        [ConfigurationProperty("cautionStyle", IsRequired = true)]
        public string CautionStyle
        {
            get
            {
                return this["cautionStyle"].ToString();
            }
            set
            {
                this["cautionStyle"] = value;
            }
        }

        [ConfigurationProperty("acceptableStyle", IsRequired = true)]
        public string AcceptableStyle
        {
            get
            {
                return this["acceptableStyle"].ToString();
            }
            set
            {
                this["acceptableStyle"] = value;
            }
        }

        [ConfigurationProperty("goodStyle", IsRequired = true)]
        public string GoodStyle
        {
            get
            {
                return this["goodStyle"].ToString();
            }
            set
            {
                this["goodStyle"] = value;
            }
        }

        [ConfigurationProperty("linkUrl", IsRequired = true)]
        public string LinkUrl
        {
            get
            {
                return this["linkUrl"].ToString();
            }
            set
            {
                this["linkUrl"] = value;
            }
        }

        [ConfigurationProperty("autoCompleteEnabled", IsRequired = true)]
        public bool AutoCompleteEnabled
        {
            get
            {
                bool autoCompleteEnabled = Boolean.Parse(this["autoCompleteEnabled"].ToString());

                return autoCompleteEnabled;
            }
            set
            {
                this["autoCompleteEnabled"] = value;
            }
        }

        [ConfigurationProperty("searchCategoryElements", IsRequired = true)]
        public SearchCategoryElement SearchCategories
        {
            get
            {
                return this["searchCategoryElements"] as SearchCategoryElement;
            }
            set
            {
                this["searchCategoryElements"] = value;
            }
        }
        
        #endregion

        #region Methods

        #endregion
    }
}
