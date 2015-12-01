using System;

namespace TightlyCurly.Com.Common.Data
{
    public interface IObjectMappingFactory
    {
        IMapping GetMappingFor<TModel>();
        IMapping GetMappingForType(Type objectType);
    }
}
