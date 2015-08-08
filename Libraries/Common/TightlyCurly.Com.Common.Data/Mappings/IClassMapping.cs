using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public interface IClassMapping
    {
        string DataSource { get; set; }
        string CountProperty { get; set; }
        string Type { get; set; }
        IEnumerable<IPropertyMapping> PropertyMappings { get; set; }
    }
}
