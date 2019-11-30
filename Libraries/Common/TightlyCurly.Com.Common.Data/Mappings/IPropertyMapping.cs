using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Data.Mappings
{
    public interface IPropertyMapping
    {
        string PropertyName { get; set; }
        string DatabaseType { get; set; }
        string ParameterName { get; set; }
        bool IsIdentity { get; set; }
        bool AllowDbNull { get; set; }
        int Order { get; set; }
        bool IsPrimaryKey { get; set; }
        IJoinMapping JoinMapping { get; set; }
        string SortColumn { get; set; }
        string Field { get; set; }
        bool IsPrimitive { get; set; }
        string LazyLoader { get; set; }
        IMethodCache MethodCache { get; set; }
    }

}
