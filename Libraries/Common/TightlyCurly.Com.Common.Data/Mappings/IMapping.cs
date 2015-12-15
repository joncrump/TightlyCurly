using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public interface IMapping
    {
        Type Type { get; set; }
        string DataSource { get; set; }
        string CountField { get; }
        IEnumerable<IPropertyMapping> PropertyMappings { get; set; } 
    }
}
