using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Data.Repositories.Strategies;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Common.Data.Tests.Strategies.DictionaryBasedDataReaderJoinedBuilderStrategyTests
{
    [TestFixture]
    public class TheConstructor : MsTestBase
    {
        [Test]
        public void WillPassConstructorTests()
        {
            DoConstructorTests<DictionaryBasedDataReaderJoinedBuilderStrategy>();
        }
    }
}
