using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseContentArticleRepositoryTests
{
    [TestClass]
    public class TheGetContentArticlesByContentItemMethod : MoqTestBase<DatabaseContentArticleRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfContentItemIsNull()
        {
            TestRunner.ExecuteTest(() =>
                {
                    var exception = AssertException<ArgumentNullException>(
                        () => ItemUnderTest.GetContentArticlesByContentItem(null));

                    AssertString("contentItem", exception.ParamName);
                });
        }

        [TestMethod]
        public void WillExecuteStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner
            //    .ExecuteTest(() =>
            //    {
            //        ItemUnderTest.GetContentArticlesByContentItem(ObjectCreator.CreateNew<ContentItem>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.GetContentArticlesByContentItemId, QueryType.StoredProcedure), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillAddParameter()
        {
            throw new NotImplementedException();
            //ContentItem expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //    {
            //        expected = ObjectCreator.CreateNew<ContentItem>();
            //    })
            //    .ExecuteTest(() =>
            //    {
            //        ItemUnderTest.GetContentArticlesByContentItem(expected);

            //        var databaseMock = Mocks.Get<Mock<IDatabaseWrapper>>("database");

            //        databaseMock
            //            .Verify(x => x.WithParameter<int>(Parameters.ContentItemId, expected.Id, ParameterDirection.Input), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillReturnValue()
        {
            throw new NotImplementedException();
            //IEnumerable<ContentArticle> expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //    {
            //        expected = CreateEnumerableOfItems(() => ObjectCreator.CreateNew<ContentArticle>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Setup(x => x.ExecuteMultiple(It.IsAny<Func<IDataReader, ContentArticle>>()))
            //            .Returns(expected);
            //    })
            //    .ExecuteTest(() =>
            //    {
            //        var actual = ItemUnderTest.GetContentArticlesByContentItem(ObjectCreator.CreateNew<ContentItem>());

            //        AssertEnumerable(expected, actual, 
            //            comparisonDelegate: (e, a) => AssertObject(e, a, propertiesToIgnore:new[] {"Locale"}));
            //    });
        }
    }
}
