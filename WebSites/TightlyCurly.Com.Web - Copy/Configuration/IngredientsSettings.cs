namespace TightlyCurly.Com.Web.Configuration
{
    public static class IngredientsSettings
    {
        public static string AvoidStyle
        {
            get
            {
                return ConfigurationSectionHandler.IngredientsConfigurationSection.AvoidStyle;
            }
        }

        public static string AcceptableStyle
        {
            get
            {
                return ConfigurationSectionHandler.IngredientsConfigurationSection.AcceptableStyle;
            }
        }

        public static string CautionStyle
        {
            get
            {
                return ConfigurationSectionHandler.IngredientsConfigurationSection.CautionStyle;
            }
        }

        public static string GoodStyle
        {
            get
            {
                return ConfigurationSectionHandler.IngredientsConfigurationSection.GoodStyle;
            }
        }

        public static string LinkUrl
        {
            get
            {
                return ConfigurationSectionHandler.IngredientsConfigurationSection.LinkUrl;
            }
        }

        public static bool AutoCompleteEnabled
        {
            get
            {
                return ConfigurationSectionHandler.IngredientsConfigurationSection.AutoCompleteEnabled;
            }
        }

        public static CategoryElementCollection SearchCategories
        {
            get
            {
                return ConfigurationSectionHandler.IngredientsConfigurationSection.SearchCategories.Categories;
            }
        }
    }
}
