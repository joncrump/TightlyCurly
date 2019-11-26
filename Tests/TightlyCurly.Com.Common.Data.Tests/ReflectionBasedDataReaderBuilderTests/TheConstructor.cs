using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Common.Data.Tests.ReflectionBasedDataReaderBuilderTests
{
    [TestFixture]
    public class TheConstructor : MsTestBase
    {
        [Test]
        public void WillPassConstructorTests()
        {
            DoConstructorTests<ReflectionBasedDataReaderBuilder>();
        }
    }
}
