using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public class TypeMapping
    {
        public TypeMapping()
        {
            PropertyMappings = new List<PropertyMapping>();
        }

        public Type Type { get; set; }
        public string DataSource { get; set; }
        public string CountField { get; }
        public IEnumerable<PropertyMapping> PropertyMappings { get; set; } 
    }
}
