using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.Common.Data.Mappers;
using TightlyCurly.Com.Common.Model.Entities;
using TightlyCurly.Com.DataAccess.Repositories.Common;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseContentArticleRepositoryTests
{
    [TestClass]
    public class TheDeleteContentArticleMethod : MoqTestBase<DatabaseContentArticleRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfContentArticleIsNull()
        {
            TestRunner.WithTest(() =>
                {
                    var exception = AssertException<ArgumentNullException>(
                        () => ItemUnderTest.DeleteContentArticle(null));

                    AssertString("contentArticle", exception.ParamName);
                }).Run();
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.WithTest(() =>
            //    {
            //        ItemUnderTest.DeleteContentArticle(ObjectCreator.CreateNew<ContentArticle>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.DeleteContentArticle, QueryType.StoredProcedure),
            //                Times.Once);
            //    }).Run();        
        }

        [TestMethod]
        public void WillAddParameters()
        {
            throw new NotImplementedException();
            //ContentArticle expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            expected = ObjectCreator.CreateNew<ContentArticle>();
            //        })
            //    .WithTest(()  =>
            //        {
            //            ItemUnderTest.DeleteContentArticle(expected);

            //            Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //                .Verify(x => x.WithParameter<int>(Parameters.Id, expected.Id, ParameterDirection.Input), 
            //                    Times.Once);
            //        })
            //    .Run();
        }

        [TestMethod]
        public void WillExecuteNonQuery()
        {
            TestRunner
                .WithTest(() =>
                    {
                        ItemUnderTest.DeleteContentArticle(ObjectCreator.CreateNew<ContentArticle>());

                        Mocks.Get<Mock<IDatabaseWrapper>>("database")
                            .Verify(x => x.ExecuteNonQuery(), Times.Once);
                    })
                .Run();
        }
    }
}