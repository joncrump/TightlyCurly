using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.Common.Data.Mappers;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseContentArticleRepositoryTests
{
    [TestClass]
    public class TheSaveContentArticleMethod : MoqTestBase<DatabaseContentArticleRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfContentArticleIsNull()
        {
            TestRunner
                .WithTest(() =>
                    {
                        var exception = AssertException<ArgumentNullException>(
                            () => ItemUnderTest.SaveContentArticle(null));

                        AssertString("contentArticle", exception.ParamName);
                    })
                .Run();
        }

        [TestMethod]
        public void WillExecuteStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner
            //    .WithTest(() =>
            //        {
            //            ItemUnderTest.SaveContentArticle(ObjectCreator.CreateNew<ContentArticle>());

            //            Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //                .Verify(x => x.CreateCommandText(StoredProcedures.SaveContentArticle, QueryType.StoredProcedure), 
            //                    Times.Once);
            //        })
            //    .Run();
        }

        [TestMethod]
        public void WillAddParameters()
        {
            throw new NotImplementedException();
            //ContentArticle expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            var locale = ObjectCreator.CreateNew<Locale>();

            //            expected = ObjectCreator.CreateNew<ContentArticle>(new Dictionary<string, object>
            //                {
            //                    {"Locale", new Loadable<Locale>(null, e => locale)}
            //                });
            //        })
            //    .WithTest(() =>
            //        {
            //            ItemUnderTest.SaveContentArticle(expected);

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
            //                .Verify(x => x.WithParameter<string>(Parameters.MetaDescription, expected.MetaDescription, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<string>(Parameters.MetaKeywords, expected.MetaKeywords, ParameterDirection.Input),
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<string>(Parameters.Description, expected.Description, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<int>(Parameters.LocaleId, expected.Locale.Value.Id, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<string>(Parameters.Title, expected.Title, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<bool>(Parameters.IsActive, expected.IsActive, ParameterDirection.Input),
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<string>(Parameters.Text, expected.Text, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<int>(Parameters.ContentItemId, expected.ContentItemId, ParameterDirection.Input),
            //                    Times.Once);
            //        })
            //    .Run();
        }

        [TestMethod]
        public void WillReturnValue()
        {
            ContentArticle expected = null;

            TestRunner
                .DoCustomSetup(() =>
                    {
                        expected = ObjectCreator.CreateNew<ContentArticle>();

                        Mocks.Get<Mock<IDatabaseWrapper>>("database")
                            .Setup(x => x.ExecuteSingle(It.IsAny<Func<IDataReader, ContentArticle>>()))
                            .Returns(expected);
                    })
                .WithTest(() =>
                    {
                        var actual = ItemUnderTest.SaveContentArticle(expected);

                        AssertObject(expected, actual, propertiesToIgnore: new[] {"Locale"});
                    })
                .Run();
        }
    }
}
