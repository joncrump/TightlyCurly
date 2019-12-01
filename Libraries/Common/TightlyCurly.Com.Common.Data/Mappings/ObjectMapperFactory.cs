using System;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public class ObjectMapperFactory : IObjectMapperFactory
    {
        public IDataMapper GetMapperFor<TValue>(MappingKind mappingKind)
        {
            throw new NotImplementedException();
        }

        public IDataMapper GetMapperForType(Type objectType, MappingKind mappingKind)
        {
            throw new NotImplementedException();
        }
    }
}
