using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
