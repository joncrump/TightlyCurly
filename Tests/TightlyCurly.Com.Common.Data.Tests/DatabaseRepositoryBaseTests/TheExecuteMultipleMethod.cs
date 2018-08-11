using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Moq;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Repositories.Strategies;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.DatabaseRepositoryBaseTests
{
    [TestFixture]
    public class TheExecuteMultipleMethod : MockTestBase<TestableDatabaseRepository>
    {
        public override void Setup()
        {
            base.Setup();

            var strategy = new Mock<IBuilderStrategy>();

            Mocks.Get<Mock<IBuilderStrategyFactory>>()
                .Setup(x => x.GetStrategy(It.IsAny<BuildMode>()))
                .Returns(strategy.Object);
        }

        [Test]
        public void WillThrowArgumentNullExceptionIfQueryInfoIsNull()
        {
                Asserter
                    .AssertException<ArgumentNullException>(
                        () => ItemUnderTest.ExecuteMultiple<object>(null, It.IsAny<BuildMode>()))
                    .AndVerifyHasParameter("queryInfo");
        }

        [TestMethod]
        public void WillInvokeDatabaseCreateCommandText()
        {
            TestRunner.ExecuteTest(() =>
            {
                ItemUnderTest.ExecuteMultiple<object>(Mock.Of<QueryInfo>(), BuildMode.Joined);

                MockDatabase
                    .Verify(x => x.CreateCommandText(It.IsAny<string>(), QueryType.Text), 
                        Times.Once);
            });
        }

        [TestMethod]
        public void WillInvokeTheDatabaseWithParametersMethod()
        {
            TestRunner.ExecuteTest(() =>
            {
                ItemUnderTest.ExecuteMultiple<object>(Mock.Of<QueryInfo>(), It.IsAny<BuildMode>());

                MockDatabase
                    .Verify(x => x.WithParameters(It.IsAny<IEnumerable<IDbDataParameter>>()), 
                        Times.Once);
            });
        }

        [TestMethod]
        public void WillInvokeDatabaseExecuteMultipleMethod()
        {
            TestRunner.ExecuteTest(() =>
            {
                ItemUnderTest.ExecuteMultiple<object>(Mock.Of<QueryInfo>(), It.IsAny<BuildMode>());

                MockDatabase
                    .Verify(x => x.ExecuteMultiple<object>(It.IsAny<IBuilderStrategy>(), 
                        It.IsAny<IEnumerable<TableObjectMapping>>()), Times.Once);
            });
        }

        [TestMethod]
        public void WillInvokeBuilderStrategyFactory()
        {
            TestRunner.ExecuteTest(() =>
            {
                ItemUnderTest.ExecuteMultiple<object>(Mock.Of<QueryInfo>(), BuildMode.Joined);

                Mocks.Get<Mock<IBuilderStrategyFactory>>()
                    .Verify(x => x.GetStrategy(BuildMode.Joined), Times.Once);
            });
        }
    }
}