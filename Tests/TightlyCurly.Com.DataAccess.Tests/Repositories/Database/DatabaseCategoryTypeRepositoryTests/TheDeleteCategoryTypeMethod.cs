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

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseCategoryTypeRepositoryTests
{
    [TestClass]
    public class TheDeleteCategoryTypeMethod : MoqTestBase<DatabaseCategoryTypeRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfCategoryTypeIsNull()
        {
            TestRunner
                .WithTest(() =>
                {
                    var exception = AssertException<ArgumentNullException>(
                        () => ItemUnderTest.DeleteCategoryType(null));

                    AssertString("categoryType", exception.ParamName);
                })
                .Run();
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner
            //    .ExecuteTest(() =>
            //    {
            //        ItemUnderTest.DeleteCategoryType(ObjectCreator.CreateNew<CategoryType>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.DeleteCategoryType, QueryType.StoredProcedure), Times.Once);
            //    });
        }

        [TestMethod]
        public void WillAddParameter()
        {
            throw new NotImplementedException();
            //CategoryType categoryType = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //    {
            //        categoryType = ObjectCreator.CreateNew<CategoryType>();
            //    })
            //    .ExecuteTest(() =>
            //    {
            //        ItemUnderTest.DeleteCategoryType(categoryType);

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.WithParameter<int>(Parameters.Id, categoryType.Id, ParameterDirection.Input), Times.Once);
            //    });
        }

        [TestMethod]
        public void WillInvokeExecuteNonQuery()
        {
            throw new NotImplementedException();
            //TestRunner
            //    .ExecuteTest(() =>
            //    {
            //        ItemUnderTest.DeleteCategoryType(ObjectCreator.CreateNew<CategoryType>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.ExecuteNonQuery(), Times.Once);
            //    });
        }
    }
}
