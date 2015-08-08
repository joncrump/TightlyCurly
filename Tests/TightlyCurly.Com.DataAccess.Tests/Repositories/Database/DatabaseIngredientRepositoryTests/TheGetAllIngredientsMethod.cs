using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.Common.Data.Mappers;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseIngredientRepositoryTests
{
    [TestClass]
    public class TheGetAllIngredientsMethod : MoqTestBase<DatabaseIngredientRepository>
    {
        [TestMethod]
        public void WillInvokeStoredProcedures()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.GetAllIngredients();

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.GetAllIngredients, QueryType.StoredProcedure), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillReturnValues()
        {
            throw new NotImplementedException();
            //IEnumerable<Ingredient> expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            expected = CreateEnumerableOfItems(() => ObjectCreator.CreateNew<Ingredient>());

            //            Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //                .Setup(x => x.ExecuteMultiple(It.IsAny<Func<IDataReader, Ingredient>>()))
            //                .Returns(expected);
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            var actual = ItemUnderTest.GetAllIngredients();

            //            AssertEnumerable(expected, actual, comparisonDelegate: 
            //                (e, a) => AssertObject(e, a, propertiesToIgnore: new[] {"IngredientCategories", "Aliases", "Links", "IngredientRatings", "Notes", "Comments"}));
            //        });
        }
    }
}
