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

            return BuildMapping(objectType);
        }

        private TypeMapping BuildMapping(Type objectType)
        {
            var mapping = new TypeMapping();

            BuildTableMapping(objectType, mapping);
            BuildPropertyMappings(objectType, mapping);

            return mapping;
        }

        private void BuildPropertyMappings(Type objectType, TypeMapping mapping)
        {
            var propertyInfos = objectType.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                BuildPropertyMapping(propertyInfo, mapping);
            }

            throw new NotImplementedException();
        }

        private void BuildPropertyMapping(PropertyInfo propertyInfo, TypeMapping mapping)
        {
            throw new NotImplementedException();
        }

        private void BuildTableMapping(Type objectType, TypeMapping mapping)
        {
            var tableAttribute = (TableAttribute)objectType.GetCustomAttribute(typeof(TableAttribute));

            mapping.DataSource = tableAttribute.Name;
            mapping.Type = objectType;
        }
    }
}
