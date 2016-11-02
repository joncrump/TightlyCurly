using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TightlyCurly.Com.Common.Data.QueryBuilders;
using TightlyCurly.Com.Common.Data.QueryBuilders.Strategies;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Common.Data.Tests.SqlQueryBuilderTests
{
    [TestClass]
    public class TheBuildUpdateQueryMethod : MsTestMockTestBase<SqlQueryBuilder>
    {
        public override void Setup()
        {
            base.Setup();

            Mocks.Get<IQueryBuilderStrategyFactory>()
                .Setup(x => x.GetBuilderStrategy(QueryKind.Update))
                .Returns(new Mock<IQueryBuilderStrategy>().Object);
        }

        [TestMethod]
        public void WillThrowArgumentNullExceptionIfModelIsNull()
        {
            AssertExceptionIsThrown<ArgumentNullException>(
                () => ItemUnderTest.BuildUpdateQuery(null,
                    It.IsAny<Expression<Func<TestClass, bool>>>(),
                    It.IsAny<IEnumerable<string>>(), It.IsAny<string>()))
            .AndVerifyMessageContains("model");
        }

        [TestMethod]
        public void WillThrowArgumentNullExceptionIfPredicateIsNull()
        {
            AssertExceptionIsThrown<ArgumentNullException>(
                () => ItemUnderTest.BuildUpdateQuery(Mock.Of<TestClass>(),
                    null,
                    It.IsAny<IEnumerable<string>>(), It.IsAny<string>()))
            .AndVerifyMessageContains("predicate");
        }

        [TestMethod]
        public void WillInvokeQueryBuilderStrategyFactory()
        {
            Expression<Func<TestClass, bool>> predicate = t => t.Id == 5;

            ItemUnderTest.BuildUpdateQuery(Mock.Of<TestClass>(), predicate,
                It.IsAny<IEnumerable<string>>(), It.IsAny<string>());

            Mocks.Get<IQueryBuilderStrategyFactory>()
                .Verify(x => x.GetBuilderStrategy(QueryKind.Update), Times.Once);
        }
    }
}
