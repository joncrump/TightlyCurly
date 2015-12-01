using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Data
{
    public interface IMapping
    {
        Type Type { get; set; }
        string DataSource { get; set; }
        string CountProperty { get; set; }
        IEnumerable<IPropertyMapping> PropertyMappings { get; set; } 
    }
}
