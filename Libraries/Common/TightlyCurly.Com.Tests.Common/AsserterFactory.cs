using System;
using TightlyCurly.Com.Tests.Common.Helpers;

namespace TightlyCurly.Com.Tests.Common
{
    public static class AsserterFactory
    {
        public static IAssertAdapter GetAssertAdapter(UnitTestFrameworkType frameworkType)
        {
            switch (frameworkType)
            {
                case UnitTestFrameworkType.Nunit:
                    return new NUnitAssertAdapter();
                    break;
                default:
                    throw new NotSupportedException($"The framework type {frameworkType} is not supported.");
            }
        }
    }
}