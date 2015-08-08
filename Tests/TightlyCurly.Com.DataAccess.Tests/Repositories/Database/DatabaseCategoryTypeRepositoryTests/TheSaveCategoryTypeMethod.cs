using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using TightlyCurly.Com.Common.Data.DataAccess;
using TightlyCurly.Com.Common.Data.Mappers;
using TightlyCurly.Com.Common.Model.Entities;
using TightlyCurly.Com.DataAccess.Repositories.Common;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Framework;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseCategoryTypeRepositoryTests
{
    [TestClass]
    public class TheSaveCategoryTypeMethod : MoqTestBase<DatabaseCategoryTypeRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfCategoryTypeIsNull()
        {
            throw new NotImplementedException();
            //TestRunner
            //    .ExecuteTest(() =>
            //    {
            //        var exception = AssertException<ArgumentNullException>(() => ItemUnderTest.SaveCategoryType(null));

            //        AssertString("categoryType", exception.ParamName);
            //    });
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner
            //    .ExecuteTest(() =>
            //    {
            //        ItemUnderTest.SaveCategoryType(ObjectCreator.CreateNew<CategoryType>(new Dictionary<string, object>
            //            {
            //                {"Locale", new Loadable<Locale>(null, e => ObjectCreator.CreateNew<Locale>())}
            //            }));

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.SaveCategoryType, QueryType.StoredProcedure), Times.Once);
            //    });
        }

        [TestMethod]
        public void WillAddParameters()
        {
            throw new NotImplementedException();
            //CategoryType categoryType = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //    {
            //        var locale = ObjectCreator.CreateNew<Locale>();

            //        categoryType = ObjectCreator.CreateNew<CategoryType>(new Dictionary<string, object>
            //            {
            //                {"Locale", new Loadable<Locale>(null, e => locale)}
            //            });
            //    })
            //    .ExecuteTest(() =>
            //    {
            //        ItemUnderTest.SaveCategoryType(categoryType);

            //        var databaseMock = Mocks.Get<Mock<IDatabaseWrapper>>("database");

            //        databaseMock
            //            .Verify(x => x.WithParameter<int>(Parameters.Id, categoryType.Id, ParameterDirection.Input), Times.Once);

            //        databaseMock
            //            .Verify(x => x.WithParameter<DateTime>(Parameters.EnteredDate, categoryType.EnteredDate, ParameterDirection.Input), 
            //                Times.Once);

            //        databaseMock
            //            .Verify(x => x.WithParameter<DateTime>(Parameters.UpdatedDate, categoryType.UpdatedDate, ParameterDirection.Input), 
            //                Times.Once);

            //        databaseMock
            //            .Verify(x => x.WithParameter<String>(Parameters.Name, categoryType.Name, ParameterDirection.Input), 
            //                Times.Once);

            //        databaseMock
            //            .Verify(x => x.WithParameter<int>(Parameters.LocaleId, categoryType.Locale.Value.Id, ParameterDirection.Input), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillReturnValue()
        {
            throw new NotImplementedException();
            //CategoryType expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //    {
            //        var locale = ObjectCreator.CreateNew<Locale>();
            //        expected = ObjectCreator.CreateNew<CategoryType>(new Dictionary<string, object>
            //            {
            //                {"Locale", new Loadable<Locale>(null, e => locale)}
            //            });

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Setup(x => x.ExecuteSingle(It.IsAny<Func<IDataReader, CategoryType>>()))
            //            .Returns(expected);
            //    })
            //    .ExecuteTest(() =>
            //    {
            //        var actual = ItemUnderTest.SaveCategoryType(expected);

            //        AssertObject(expected, actual, propertiesToIgnore:new[] {"Locale"});
            //        AssertObject(expected.Locale.Value, actual.Locale.Value);
            //    });
        }
    }
}
