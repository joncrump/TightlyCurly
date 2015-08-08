using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseIngredientRepositoryTests
{
    [TestClass]
    public class TheSaveIngredientMethod : MoqTestBase<DatabaseIngredientRepository> //RepositoryTestBase<DatabaseIngredientRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfIngredientIsNull()
        {
            TestRunner.ExecuteTest(() =>
                {
                    var exception = AssertException<ArgumentNullException>(
                        () => ItemUnderTest.SaveIngredient(null));

                    AssertString("ingredient", exception.ParamName);
                });
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.SaveIngredient(ObjectCreator.CreateNew<Ingredient>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.SaveIngredient, QueryType.StoredProcedure), 
            //                Times.Once);
            //    });
        }          

        [TestMethod]
        public void WillAddParameters()
        {
            throw new NotImplementedException();
            //Ingredient expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            expected = ObjectCreator.CreateNew<Ingredient>();
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            ItemUnderTest.SaveIngredient(expected);

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
            //                .Verify(x => x.WithParameter<String>(Parameters.IngredientCategoryIds, It.IsAny<object>(), ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.Title, expected.Title, ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.Aliases, It.IsAny<object>(), ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.Description, expected.Description, ParameterDirection.Input), 
            //                    Times.Once);
                    
            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.LinkIds, It.IsAny<object>(), ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.IngredientRatingIds, It.IsAny<object>(), ParameterDirection.Input),
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.NoteIds, It.IsAny<object>(), ParameterDirection.Input), 
            //                    Times.Once);

            //            databaseMock
            //                .Verify(x => x.WithParameter<String>(Parameters.IngredientCommentIds, It.IsAny<object>(), ParameterDirection.Input), 
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
            //            var actual = ItemUnderTest.SaveIngredient(expected);

            //            AssertObject(expected, actual, propertiesToIgnore:
            //                new[] { "IngredientCategories", "Aliases", "Links", "IngredientRatings", "Notes", "Comments" });
            //        });
        }
    }
}
