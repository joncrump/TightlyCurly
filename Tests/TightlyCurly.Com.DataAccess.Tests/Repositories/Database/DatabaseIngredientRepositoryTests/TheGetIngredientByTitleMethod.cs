using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.Common.Data.Mappers;
using TightlyCurly.Com.Common.Model.Entities;
using TightlyCurly.Com.DataAccess.Repositories.Common;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Framework.Exceptions;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseIngredientRepositoryTests
{
    [TestClass]
    public class TheGetIngredientByTitleMethod : MoqTestBase<DatabaseIngredientRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfTitleIsNull()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentNullException>(
            //            () => ItemUnderTest.GetIngredientByTitle(null, Mock.Of<Locale>()));

            //        AssertString("title", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillThrowArgumentEmptyExceptionIfTitleIsEmpty()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentEmptyException>(
            //            () => ItemUnderTest.GetIngredientByTitle(String.Empty, Mock.Of<Locale>()));

            //        AssertString("title", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillThrowArgumentNullExceptionIfLocaleIsNull()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentNullException>(
            //            () => ItemUnderTest.GetIngredientByTitle(DataGenerator.GenerateString(),
            //                null));

            //        AssertString("locale", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.GetIngredientByTitle(DataGenerator.GenerateString(), ObjectCreator.CreateNew<Locale>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.GetIngredientByTitle, QueryType.StoredProcedure), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillAddParameters()
        {
            throw new NotImplementedException();
            //var title = String.Empty;
            //Locale locale = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            title = DataGenerator.GenerateString();
            //            locale = ObjectCreator.CreateNew<Locale>();
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            ItemUnderTest.GetIngredientByTitle(title, locale);

            //            var databaseMock = Mocks.Get<Mock<IDatabaseWrapper>>("database");

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.Title, title, ParameterDirection.Input), 
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

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            expected = ObjectCreator.CreateNew<Ingredient>();

            //            Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //                .Setup(x => x.ExecuteSingle(It.IsAny<Func<IDataReader, Ingredient>>()))
            //                .Returns(expected);
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            var actual = ItemUnderTest.GetIngredientByTitle(DataGenerator.GenerateString(),
            //                ObjectCreator.CreateNew<Locale>());

            //            AssertObject(expected, actual, propertiesToIgnore:
            //                new[] { "IngredientCategories", "Aliases", "Links", "IngredientRatings", "Notes", "Comments" });
            //        });
        }
    }
}
