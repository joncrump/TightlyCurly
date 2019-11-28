﻿using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.QueryBuilders;
using TightlyCurly.Com.Common.Data.QueryBuilders.Strategies;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.SqlQueryBuilderTests
{
    [TestFixture]
    public class TheBuildInsertQueryMethod : MockTestBase<SqlQueryBuilder>
    {
        protected override void Setup()
        {
            base.Setup();

            Mocks.Get<IQueryBuilderStrategyFactory>()
                .Setup(x => x.GetBuilderStrategy(QueryKind.Insert))
                .Returns(new Mock<IQueryBuilderStrategy>().Object);
        }

        [Test]
        public void WillThrowArgumentNullExceptionIfModelIsNull()
        {
            Asserter
                .AssertException<ArgumentNullException>(
                    () => ItemUnderTest.BuildInsertQuery<TestClass>(null, It.IsAny<bool>(), It.IsAny<bool>(),
                        It.IsAny<IEnumerable<string>>(), It.IsAny<string>()))
                .AndVerifyHasParameter("model");
        }

        [Test]
        public void WillInvokeQueryBuilderStrategyFactory()
        {
            ItemUnderTest.BuildInsertQuery(Mock.Of<TestClass>(), It.IsAny<bool>(),
                It.IsAny<bool>(), It.IsAny<IEnumerable<string>>(), It.IsAny<string>());

            Mocks.Get<IQueryBuilderStrategyFactory>()
                .Verify(x => x.GetBuilderStrategy(QueryKind.Insert), Times.Once);
        }
    }
}
