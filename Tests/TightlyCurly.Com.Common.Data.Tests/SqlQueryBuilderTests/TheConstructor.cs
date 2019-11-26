using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Data.QueryBuilders;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Common.Data.Tests.SqlQueryBuilderTests
{
    [TestFixture]
    public class TheConstructor : MsTestBase
    {
        [Test]
        public void WillPassConstructorTests()
        {
            DoConstructorTests<SqlQueryBuilder>();
        }
    }
}
