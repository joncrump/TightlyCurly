using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseContentItemRepositoryTests
{
    [TestClass]
    public class TheSaveContentItemMethod : MoqTestBase<DatabaseContentItemRepository>//RepositoryTestBase<DatabaseContentItemRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfContentItemIsNull()
        {
            TestRunner.ExecuteTest(() =>
                {
                    var exception = AssertException<ArgumentNullException>(
                        () => ItemUnderTest.SaveContentItem(null));

                    AssertString("contentItem", exception.ParamName);
                });
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.SaveContentItem(ObjectCreator.CreateNew<ContentItem>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.SaveContentItem, QueryType.StoredProcedure), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillAddParameters()
        {
            throw new NotImplementedException();
            //ContentItem expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            expected = ObjectCreator.CreateNew<ContentItem>();
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            ItemUnderTest.SaveContentItem(expected);

            //            var databaseMock = Mocks.Get<Mock<IDatabaseWrapper>>("database");

            //            databaseMock
            //                .Verify(x => x.WithParameter<int>(Parameters.Id, expected.Id, ParameterDirection.Input),
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<DateTime>(Parameters.EnteredDate, expected.EnteredDate, ParameterDirection.Input),
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<DateTime>(Parameters.UpdatedDate, expected.UpdatedDate, ParameterDirection.Input),
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<int>(Parameters.ViewStatus, (int)expected.ViewStatus, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.Title, expected.Title, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.MetaDescription, expected.MetaDescription, ParameterDirection.Input),
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.MetaKeywords, expected.MetaKeywords, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.Description, expected.Description, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<bool>(Parameters.IsActive, expected.IsActive, ParameterDirection.Input), 
            //                    Times.Once);
                        
            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.Uri, expected.Uri.ToString(), ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.Name, expected.Name, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.ArticleIds, It.IsAny<object>(), ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<int>(Parameters.LocaleId, It.IsAny<object>(), ParameterDirection.Input), 
            //                    Times.Once);
            //        });
        }

        [TestMethod]
        public void WillReturnValue()
        {
            throw new NotImplementedException();
            //ContentItem expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            expected = ObjectCreator.CreateNew<ContentItem>();

            //            Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //                .Setup(x => x.ExecuteSingle(It.IsAny<Func<IDataReader, ContentItem>>()))
            //                .Returns(expected);
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            var actual = ItemUnderTest.SaveContentItem(expected);

            //            AssertObject(expected, actual, propertiesToIgnore: new[] { "ViewStatus", "Articles", "Locale" });
            //        });
        }
    }
}
