
using Moq;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.QueryBuilders;
using TightlyCurly.Com.Common.Data.QueryBuilders.Strategies;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.SqlQueryBuilderTests
{
    [TestFixture]
    public class TheBuildPagedQueryMethod : MockTestBase<SqlQueryBuilder>
    {
        protected override void Setup()
        {
            base.Setup();

            Mocks.Get<IQueryBuilderStrategyFactory>()
                .Setup(x => x.GetBuilderStrategy(It.IsAny<QueryKind>()))
                .Returns(new Mock<IQueryBuilderStrategy>().Object);
        }

        [Test]
        public void WillInvokeSelectSingleStrategyIfPagingInfoIsNull()
        {
            ItemUnderTest.BuildPagedQuery<TestClass>(null);

            Mocks.Get<IQueryBuilderStrategyFactory>()
                .Verify(x => x.GetBuilderStrategy(QueryKind.SelectSingleTable), Times.Once);
        }

        [Test]
        public void WillNotInvokeSelectSingleStrategyIfPagingInfoIsNotNull()
        {
            ItemUnderTest.BuildPagedQuery<TestClass>(ObjectCreator.CreateNew<PagingInfo>());

            Mocks.Get<IQueryBuilderStrategyFactory>()
               .Verify(x => x.GetBuilderStrategy(QueryKind.SelectSingleTable), Times.Never());
        }

        [Test]
        public void WillInvokePagedSingleStrategy()
        {
            ItemUnderTest.BuildPagedQuery<TestClass>(ObjectCreator.CreateNew<PagingInfo>());

            Mocks.Get<IQueryBuilderStrategyFactory>()
                .Verify(x => x.GetBuilderStrategy(QueryKind.PagedSingle), Times.Once);
        }
    }
}
