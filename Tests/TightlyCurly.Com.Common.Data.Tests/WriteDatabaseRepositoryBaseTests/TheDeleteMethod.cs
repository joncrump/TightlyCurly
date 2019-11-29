using System;
using System.Linq.Expressions;
using Moq;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.QueryBuilders;
using TightlyCurly.Com.Tests.Common.Base;


namespace TightlyCurly.Com.Common.Data.Tests.WriteDatabaseRepositoryBaseTests
{
    [TestFixture]
    public class TheDeleteMethod : MockTestBase<TestableWriteDatabaseRepository>
    {
        protected override void Setup()
        {
            base.Setup();

            Mocks.Get<IQueryBuilder>()
                .Setup(x => x.BuildDeleteQuery(It.IsAny<Expression<Func<TestModel, bool>>>(), 
                    It.IsAny<string>()))
                .Returns(Mock.Of<QueryInfo>());
        }

        [Test]
        public void WillThrowArgumentNullExceptionIfModelIsNull()
        {
            Asserter
                .AssertException<ArgumentNullException>(
                    () => ItemUnderTest.Delete(null, It.IsAny<Expression<Func<TestModel, bool>>>()))
                .AndVerifyHasParameter("model");
        }

        [Test]
        public void WillInvokeQueryBuilderDeleteQuery()
        {
            ItemUnderTest.Delete(Mock.Of<ITestModel>());

            Mocks.Get<IQueryBuilder>()
                .Verify(x => x.BuildDeleteQuery<ITestModel>(null, null), Times.Once);
        }
    }
}
