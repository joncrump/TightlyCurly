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

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseIngredientRepositoryTests
{
    [TestClass]
    public class TheDeleteIngredientMethod : MoqTestBase<DatabaseIngredientRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfIngredientIsNull()
        {
            TestRunner.ExecuteTest(() =>
                {
                    var exception = AssertException<ArgumentNullException>(() => ItemUnderTest.DeleteIngredient(null));

                    AssertString("ingredient", exception.ParamName);
                });
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.DeleteIngredient(ObjectCreator.CreateNew<Ingredient>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.DeleteIngredient, QueryType.StoredProcedure), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillAddParameter()
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
            //            ItemUnderTest.DeleteIngredient(expected);

            //            Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //                .Verify(x => x.WithParameter<int>(Parameters.Id, expected.Id, ParameterDirection.Input), 
            //                    Times.Once);
            //        });
        }

        [TestMethod]
        public void WillExecuteNonQuery()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.DeleteIngredient(ObjectCreator.CreateNew<Ingredient>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.ExecuteNonQuery(), Times.Once);
            //    });
        }
    }
}