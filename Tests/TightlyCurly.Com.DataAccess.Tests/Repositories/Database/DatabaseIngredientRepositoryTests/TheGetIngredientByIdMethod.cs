using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.Common.Data.Mappers;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Framework.Exceptions;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseIngredientRepositoryTests
{
    [TestClass]
    public class TheGetIngredientByIdMethod : MoqTestBase<DatabaseIngredientRepository>
    {
        [TestMethod]
        public void WillThrowArgumentInvalidExceptionIfIdIsNegative()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentInvalidException>(
            //            () => ItemUnderTest.GetIngredientById(-1, Mock.Of<Locale>()));

            //        AssertString("id", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillThrowArgumentInvalidExceptionIfIdIsZero()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentInvalidException>(
            //            () => ItemUnderTest.GetIngredientById(0, Mock.Of<Locale>()));

            //        AssertString("id", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillThrowArgumentNullExceptionIfLocaleIsNull()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentNullException>(
            //            () => ItemUnderTest.GetIngredientById(DataGenerator.GenerateInteger(), null));

            //        AssertString("locale", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.GetIngredientById(DataGenerator.GenerateInteger(), ObjectCreator.CreateNew<Locale>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.GetIngredientById, QueryType.StoredProcedure), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillAddParameters()
        {
            throw new NotImplementedException();
            //var id = 0;
            //Locale locale = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            id = DataGenerator.GenerateInteger();
            //            locale = ObjectCreator.CreateNew<Locale>();
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            ItemUnderTest.GetIngredientById(id, locale);

            //            var databaseMock = Mocks.Get<Mock<IDatabaseWrapper>>("database");

            //            databaseMock
            //                .Verify(x => x.WithParameter<int>(Parameters.Id, id, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<int>(Parameters.LocaleId, locale.Id, ParameterDirection.Input), 
            //                    Times.Once);
            //        });
        }

        [TestMethod]
        public void WillReturnValue()
        {
            throw new NotImplementedException();
            //Ingredient expected = null;

            //TestRunner.DoCustomSetup(() =>
            //    {
            //        expected = ObjectCreator.CreateNew<Ingredient>();

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Setup(x => x.ExecuteSingle(It.IsAny<Func<IDataReader, Ingredient>>()))
            //            .Returns(expected);
            //    })
            //    .ExecuteTest(() =>
            //    {
            //        var actual = ItemUnderTest.GetIngredientById(DataGenerator.GenerateInteger(), ObjectCreator.CreateNew<Locale>());

            //        AssertObject(expected, actual, propertiesToIgnore:
            //            new[] { "IngredientCategories", "Aliases", "Links", "IngredientRatings", "Notes", "Comments" });
            //    });
        }
    }
}
