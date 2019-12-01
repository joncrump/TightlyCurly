using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    [DataContract]
    [KnownType(typeof(JoinMapping))]
    public class PropertyMapping
    {
        public PropertyMapping()
        {

        }

        [JsonConstructor()]
        public PropertyMapping(JoinMapping joinMapping)
        {
            JoinMapping = joinMapping;
        }

        [DataMember(Name = "propertyName", IsRequired = false)]
        public string PropertyName { get; set; }

        [DataMember(Name = "databaseType", IsRequired = false)]
        [JsonConverter(typeof(StringEnumConverter))]
        public string DatabaseType { get; set; }

        [DataMember(Name = "parameterName", IsRequired = false)]
        public string ParameterName { get; set; }

        [DataMember(Name = "isIdentity", IsRequired = false)]
        public bool IsIdentity { get; set; }

        [DataMember(Name = "allowDbNull", IsRequired = false)]
        public bool AllowDbNull { get; set; }

        [DataMember(Name = "order", IsRequired = false)]
        public int Order { get; set; }

        [DataMember(Name = "isPrimaryKey", IsRequired = false)]
        public bool IsPrimaryKey { get; set; }

        [DataMember(Name = "joinMapping", IsRequired = false)]
        public IJoinMapping JoinMapping { get; set; }

        [DataMember(Name = "sortColumn")]
        public string SortColumn { get; set; }

        [DataMember(Name = "field", IsRequired = false)]
        public string Field { get; set; }

        [DataMember(Name = "isPrimitive", IsRequired = false)]
        public bool IsPrimitive { get; set; }

        [DataMember(Name = "lazyLoader", IsRequired = false)]
        public string LazyLoader { get; set; }

        public IMethodCache MethodCache { get; set; }
    }
}