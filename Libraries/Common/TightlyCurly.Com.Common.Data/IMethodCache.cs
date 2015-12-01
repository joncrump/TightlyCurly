using System;
using System.Reflection;

namespace TightlyCurly.Com.Common.Data
{
    public interface IMethodCache
    {
        Type Type { get; set; }
        PropertyInfo PropertyInfo { get; set; }
        Func<string, object, object> GetPropertyValue { get; } 
    }
}
