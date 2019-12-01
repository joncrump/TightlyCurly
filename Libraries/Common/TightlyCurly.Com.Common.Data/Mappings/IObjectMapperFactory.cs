using System;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public interface IObjectMapperFactory
    {
        IDataMapper GetMapperFor<TValue>(MappingKind mappingKind);
        IDataMapper GetMapperForType(Type objectType, MappingKind mappingKind);
    }
}
