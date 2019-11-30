using System;
using TightlyCurly.Com.Common.Data.Mappings;

namespace TightlyCurly.Com.Common.Data
{
    public interface IObjectMappingFactory
    {
        IMapping GetMappingForType(Type objectType, MappingKind mappingKind);
    }
}
