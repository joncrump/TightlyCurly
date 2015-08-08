using System;

namespace TightlyCurly.Com.Admin.Web
{
    public static class Bootstrapper
    {
        public static void Initialize()
        {
            RegisterTypes();
        }

        private static void RegisterTypes()
        {
            throw new NotImplementedException();
            //Container.RegisterType<IConfigurationHelper, ConfigurationHelper>();
            //Container.RegisterType<IQuestionDataProvider, DatabaseQuestionDataProvider>();

            //Container.RegisterType<ISettingsDataProvider, DatabaseSettingDataProvider>();
            //Container.RegisterType<IContentItemDataProvider, DatabaseContentItemDataProvider>();
            //Container.RegisterType<IPageBuilder, DataReaderContentBuilderStrategy>();
            //Container.RegisterType<IContentDataAccess, DatabaseContentDataAccessStrategy>();
            //Container.RegisterType<IParameterMapper, SqlParameterMapper>();
            //Container.RegisterType<IUrlEntryBuilder, DataReaderUrlEntryBuilderStrategy>();
            //Container.RegisterType<IUrlEntryDataAccess, DatabaseUrlEntryDataAccessStrategy>();
            //Container.RegisterType<IUrlEntryDataProvider, DatabaseUrlEntryDataProvider>();
            //Container.RegisterType<IFormatter<string, string>, SeoFriendlyFormatter>();
        }
    }
}
