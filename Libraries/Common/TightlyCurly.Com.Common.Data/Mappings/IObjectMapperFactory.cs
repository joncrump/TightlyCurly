using System;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public interface IObjectMapperFactory
    {
        IDataMapper GetMapper(MappingKind mappingKind);
    }
}
