using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Tests.Common.Base;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Common.Data.Tests.ReadDatabaseRepositoryBaseTests
{
    [TestClass]
    public class TheConstructor : TestBase
    {
        [TestMethod]
        public void WillPassConstructorTests()
        {
            DoConstructorTests<TestableReadDatabaseRepository>();
        }
    }
}
