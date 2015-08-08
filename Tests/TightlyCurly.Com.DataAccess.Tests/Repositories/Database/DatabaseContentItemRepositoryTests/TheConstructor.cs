using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.DataAccess.Builders;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseContentItemRepositoryTests
{
    [TestClass]
    public class TheConstructor : TestBase
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfDatabaseIsNull()
        {
            var exception = AssertException<ArgumentNullException>(
                () => new DatabaseContentItemRepository(null, Mock.Of<IBuilder<IDataReader>>()));

            AssertString("database", exception.ParamName);
        }

        [TestMethod]
        public void WillThrowArgumentNullExceptionIfBuilderIsNull()
        {
            var exception = AssertException<ArgumentNullException>(
                () => new DatabaseContentItemRepository(Mock.Of<IDatabaseWrapper>(), null));

            AssertString("builder", exception.ParamName);
        }
    }
}
