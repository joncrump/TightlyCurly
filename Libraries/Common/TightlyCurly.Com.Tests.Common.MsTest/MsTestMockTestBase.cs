using TightlyCurly.Com.Tests.Common.Base;
using TightlyCurly.Com.Tests.Common.Helpers;

namespace TightlyCurly.Com.Tests.Common.MsTest
{
    public class MsTestMockTestBase<TItemUnderTest> : MockTestBase<TItemUnderTest> where TItemUnderTest : class
    {
        public MsTestMockTestBase() : base(new MsTestAssertAdapter())
        {
        }

        public MsTestMockTestBase(IDataGenerator dataGenerator) 
            : base(dataGenerator, new MsTestAssertAdapter())
        {
        }

        public MsTestMockTestBase(IObjectCreator objectCreator) : base(objectCreator, new MsTestAssertAdapter())
        {
        }

        public MsTestMockTestBase(IDataGenerator dataGenerator, IObjectCreator objectCreator)
            : base(dataGenerator, objectCreator, new MsTestAssertAdapter())
        {
        }
    }
}
