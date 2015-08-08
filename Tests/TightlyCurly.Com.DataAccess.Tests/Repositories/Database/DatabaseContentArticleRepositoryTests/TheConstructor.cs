using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.DataAccess.Builders;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseContentArticleRepositoryTests
{
    [TestClass]
    public class TheConstructor : TestBase
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfDatabaseIsNull()
        {
            TestRunner.WithTest(() =>
                {
                    var exception = AssertException<ArgumentNullException>(
                        () => new DatabaseContentArticleRepository(null, Mock.Of<IBuilder<IDataReader>>()));

                    AssertString("database", exception.ParamName);
                }).Run();
        }

        [TestMethod]
        public void WillThrowArgumentNullExceptionIfBuilderIsNull()
        {
            TestRunner.WithTest(() =>
                {
                    var exception = AssertException<ArgumentNullException>(
                        () => new DatabaseContentArticleRepository(Mock.Of<IDatabaseWrapper>(), null));

                    AssertString("builder", exception.ParamName);
                }).Run();
        }
    }
}
