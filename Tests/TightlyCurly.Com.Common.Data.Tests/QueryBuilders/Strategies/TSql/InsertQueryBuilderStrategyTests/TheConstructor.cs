using TightlyCurly.Com.Common.Data.QueryBuilders.Strategies.TSql;
using NUnit.Framework;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.QueryBuilders.Strategies.TSql.InsertQueryBuilderStrategyTests
{
    [TestFixture]
    public class TheConstructor : TestBase
    {
        [Test]
        public void WillPassConstructorTests()
        {
            DoConstructorTests<InsertQueryBuilderStrategy>();
        }
    }
}
