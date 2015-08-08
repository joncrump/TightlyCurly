using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.Common.Data.Mappers;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Framework.Exceptions;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseContentArticleRepositoryTests
{
    [TestClass]
    public class TheGetContentArticleByIdMethod : MoqTestBase<DatabaseContentArticleRepository>
    {
        [TestMethod]
        public void WillThrowArgumentInvalidExceptionIfIdIsNegative()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentInvalidException>(
            //            () => ItemUnderTest.GetContentArticleById(-1, Mock.Of<Locale>()));

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
            //            () => ItemUnderTest.GetContentArticleById(0, Mock.Of<Locale>()));

            //        AssertString("id", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillThrowArgumentNullExceptionIfLocaleIsNull()
        {
            TestRunner.ExecuteTest(() =>
            {
                var exception = AssertException<ArgumentNullException>(
                    () => ItemUnderTest.GetContentArticleById(DataGenerator.GenerateInteger(), null));

                AssertString("locale", exception.ParamName);
            });
        }


        [TestMethod]
        public void WillExecuteStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.GetContentArticleById(DataGenerator.GenerateInteger(), ObjectCreator.CreateNew<Locale>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.GetContentArticleById, QueryType.StoredProcedure), 
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
            //    {
            //        id = DataGenerator.GenerateInteger();
            //        locale = ObjectCreator.CreateNew<Locale>();
            //    })
            //    .ExecuteTest(() =>
            //    {
            //        ItemUnderTest.GetContentArticleById(id, locale);

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.WithParameter<int>(Parameters.Id, id, ParameterDirection.Input), 
            //                Times.Once);

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.WithParameter<int>(Parameters.LocaleId, locale.Id, ParameterDirection.Input), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillReturnValue()
        {
            throw new NotImplementedException();
            //ContentArticle expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //    {
            //        expected = ObjectCreator.CreateNew<ContentArticle>();

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Setup(x => x.ExecuteSingle(It.IsAny<Func<IDataReader, ContentArticle>>()))
            //            .Returns(expected);
            //    })
            //    .ExecuteTest(() =>
            //    {
            //        var actual = ItemUnderTest.GetContentArticleById(expected.Id, ObjectCreator.CreateNew<Locale>());

            //        AssertObject(expected, actual, propertiesToIgnore: new[] {"Locale"});
            //    });
        }
    }
}
