using System;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public interface IDataMapper
    {
        TypeMapping GetMappingFor<TValue>();
        TypeMapping GetMappingForType(Type objectType);
    }
}