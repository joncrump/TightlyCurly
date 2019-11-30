using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TightlyCurly.Com.Common.Data.Mappings;

namespace TightlyCurly.Com.Common.Data
{
    public class ObjectMappingFactory : IObjectMappingFactory
    {
        public IMapping GetMappingForType(Type objectType, MappingKind mappingKind = MappingKind.Attribute)
        {
            throw new NotImplementedException();
        }
    }
}
