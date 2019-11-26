using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Data.QueryBuilders.Strategies.TSql;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Common.Data.Tests.QueryBuilders.Strategies.TSql.UpdateQueryBuilderStrategyTests
{
    [TestFixture]
    public class TheConstructor : MsTestBase
    {
        [Test]
        public void WillPassConstructorTests()
        {
            DoConstructorTests<UpdateQueryBuilderStrategy>();
        }
    }
}