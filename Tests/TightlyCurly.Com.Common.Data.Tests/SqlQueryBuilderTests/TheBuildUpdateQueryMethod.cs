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
    [TestFixture]
    public class TheBuildUpdateQueryMethod : MsTestMockTestBase<SqlQueryBuilder>
    {
        public override void Setup()
        {
            base.Setup();

            Mocks.Get<IQueryBuilderStrategyFactory>()
                .Setup(x => x.GetBuilderStrategy(QueryKind.Update))
                .Returns(new Mock<IQueryBuilderStrategy>().Object);
        }

        [Test]
        public void WillThrowArgumentNullExceptionIfModelIsNull()
        {
            AssertExceptionIsThrown<ArgumentNullException>(
                () => ItemUnderTest.BuildUpdateQuery(null,
                    It.IsAny<Expression<Func<TestClass, bool>>>(),
                    It.IsAny<IEnumerable<string>>(), It.IsAny<string>()))
            .AndVerifyMessageContains("model");
        }

        [Test]
        public void WillThrowArgumentNullExceptionIfPredicateIsNull()
        {
            AssertExceptionIsThrown<ArgumentNullException>(
                () => ItemUnderTest.BuildUpdateQuery(Mock.Of<TestClass>(),
                    null,
                    It.IsAny<IEnumerable<string>>(), It.IsAny<string>()))
            .AndVerifyMessageContains("predicate");
        }

        [Test]
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
