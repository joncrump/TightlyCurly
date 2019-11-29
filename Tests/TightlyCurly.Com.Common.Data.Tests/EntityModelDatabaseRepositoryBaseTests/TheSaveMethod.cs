using System;
using NUnit.Framework;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.EntityModelDatabaseRepositoryBaseTests
{
    [TestFixture]
    public class TheSaveMethod : MockTestBase<TestableEntityDatabaseRepository>
    {
        [Test]
        public void WillThrowArgumentNullExceptionIfModelIsNull()
        {
            Asserter
                .AssertException<ArgumentNullException>(
                    () => SystemUnderTest.Save(null, true))
                .AndVerifyHasParameter("model");
        }
    }
}
