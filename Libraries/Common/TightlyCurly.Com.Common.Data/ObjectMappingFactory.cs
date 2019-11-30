using System;
using TightlyCurly.Com.Common.Data.Mappings;

namespace TightlyCurly.Com.Common.Data
{
    public class ObjectMappingFactory : IObjectMappingFactory
    {
        public IMapping GetMappingForType(Type objectType, MappingKind mappingKind)
        {
            objectType.EnsureIsNotNull(nameof(objectType));

            throw new NotImplementedException();
        }
    }
}
