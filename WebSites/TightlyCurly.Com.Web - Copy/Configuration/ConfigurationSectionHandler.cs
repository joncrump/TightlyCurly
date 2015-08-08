using System;
using System.Configuration;
using TightlyCurly.Com.Web.Common;

namespace TightlyCurly.Com.Web.Configuration
{
    public static class ConfigurationSectionHandler
    {
        #region Fields

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public static IngredientsConfigurationSection IngredientsConfigurationSection
        {
            get
            {
                return ConfigurationManager.GetSection(Constants.ConfigurationConstants.SectionConstants.IngredientsSectionName) as IngredientsConfigurationSection;
            }
        }

        #endregion
    }
}
