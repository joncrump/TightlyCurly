using System;
using System.Collections.Generic;
using System.Reflection;

namespace TightlyCurly.Com.Tests.Common
{
    public interface IConstructorTester
    {
        void TestConstructorsForNullParameters<TItem>() where TItem : class;
        IEnumerable<string> TestConstructorForNullParameter(Type itemType, ConstructorInfo constructor);
        IEnumerable<object> InitializeParameters(IList<ParameterInfo> parameters);
        object GetObjectFromMock(object mock, Type propertyType);
    }
}