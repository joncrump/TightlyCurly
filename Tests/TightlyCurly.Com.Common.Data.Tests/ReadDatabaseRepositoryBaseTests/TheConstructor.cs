using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Tests.Common.Base;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Common.Data.Tests.ReadDatabaseRepositoryBaseTests
{
    [TestFixture]
    public class TheConstructor : TestBase
    {
        [Test]
        public void WillPassConstructorTests()
        {
            DoConstructorTests<TestableReadDatabaseRepository>();
        }
    }
}
