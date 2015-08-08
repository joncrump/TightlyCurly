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
    public class TheGetIngredientsByRatingMethod : MoqTestBase<DatabaseIngredientRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfIngredientRatingIsNull()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentNullException>(
            //            () => ItemUnderTest.GetIngredientsByRating(null, Mock.Of<Locale>()));

            //        AssertString("rating", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillThrowArgumentNullExceptionIfLocaleIsNull()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentNullException>(
            //            () => ItemUnderTest.GetIngredientsByRating(Mock.Of<IngredientRating>(), null));

            //        AssertString("locale", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.GetIngredientsByRating(ObjectCreator.CreateNew<IngredientRating>(),
            //            ObjectCreator.CreateNew<Locale>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.GetIngredientsByRating, QueryType.StoredProcedure), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillAddParameters()
        {
            throw new NotImplementedException();
            //IngredientRating rating = null;
            //Locale locale = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            rating = ObjectCreator.CreateNew<IngredientRating>();
            //            locale = ObjectCreator.CreateNew<Locale>();
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            ItemUnderTest.GetIngredientsByRating(rating, locale);

            //            var databaseMock = Mocks.Get<Mock<IDatabaseWrapper>>("database");

            //            databaseMock
            //                .Verify(x => x.WithParameter<int>(Parameters.IngredientRatingId, rating.Id, ParameterDirection.Input),
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<int>(Parameters.LocaleId, rating.Id, ParameterDirection.Input), 
            //                    Times.Once);
            //        });
        }

        [TestMethod]
        public void WillReturnIngredients()
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
            //    {
            //        var actual = ItemUnderTest.GetIngredientsByRating(ObjectCreator.CreateNew<IngredientRating>(),
            //            ObjectCreator.CreateNew<Locale>());

            //        AssertEnumerable(expected, actual, comparisonDelegate:
            //                (e, a) => AssertObject(e, a, propertiesToIgnore: new[] { "IngredientCategories", "Aliases", "Links", "IngredientRatings", "Notes", "Comments" }));
            //    });
        }
    }
}
