using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    [DataContract]
    [KnownType(typeof(PropertyMapping))]
    public class ClassMapping : IClassMapping
    {
        public ClassMapping()
        {
            PropertyMappings = new List<IPropertyMapping>();
        }

        [JsonConstructor]
        public ClassMapping(IEnumerable<PropertyMapping> propertyMappings)
        {
            PropertyMappings = propertyMappings;
        }

        [DataMember(Name = "dataSource")]
        public string DataSource { get; set; }
        
        [DataMember(Name = "countProperty", IsRequired = false)]
        public string CountProperty { get; set; }
        
        [DataMember(Name = "type")]
        public string Type { get; set; }
        
        [DataMember(Name = "propertyMappings", IsRequired = true)]
        public IEnumerable<IPropertyMapping> PropertyMappings { get; set; }
    }
}
