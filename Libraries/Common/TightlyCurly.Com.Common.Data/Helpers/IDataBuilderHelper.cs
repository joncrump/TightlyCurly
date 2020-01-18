using System;
using System.Data;

namespace TightlyCurly.Com.Common.Data.Helpers
{
    public interface IDataBuilderHelper
    {
        SqlDbType InferDatabaseType(Type type);
        string GetParameterName(string name);
    }
}
