using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseCategoryTypeRepositoryTests
{
    [TestClass]
    public class TheGetAllCategoryTypesMethod  : MoqTestBase<DatabaseCategoryTypeRepository>
    {
        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner
            //    .ExecuteTest(() =>
            //    {
            //        ItemUnderTest.GetAllCategoryTypes();

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.GetAllCategoryTypes, QueryType.StoredProcedure), Times.Once);
            //    });
        }

        [TestMethod]
        public void WillReturnValues()
        {
            throw new NotImplementedException();
            //IEnumerable<CategoryType> expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //    {
            //        expected = CreateEnumerableOfItems(() => ObjectCreator.CreateNew<CategoryType>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Setup(x => x.ExecuteMultiple(It.IsAny<Func<IDataReader, CategoryType>>()))
            //            .Returns(expected);
            //    })
            //    .ExecuteTest(() =>
            //    {
            //        var actual = ItemUnderTest.GetAllCategoryTypes();

            //        AssertEnumerable(expected, actual, comparisonDelegate:(e, a) => AssertObject(e, a, propertiesToIgnore:new[] {"Locale"}));
            //    });
        }
    }
}
