using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TightlyCurly.Com.Common.Data.Attributes;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public class ReflectionBasedDataMapper : IDataMapper
    {
        public TypeMapping GetMappingFor<TValue>()
        {
            return GetMappingForType(typeof(TValue));
        }

        public TypeMapping GetMappingForType(Type objectType)
        {
            objectType.ThrowIfNull(nameof(objectType));

            var tableAttribute = objectType.GetCustomAttribute(typeof(TableAttribute));
            
            throw new NotImplementedException();
        }
    }
}
