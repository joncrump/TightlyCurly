using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseContentItemRepositoryTests
{
    [TestClass]
    public class TheDeleteContentItemMethod : MoqTestBase<DatabaseContentItemRepository>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfContentItemIsNull()
        {
            TestRunner.ExecuteTest(() =>
                {
                    var exception = AssertException<ArgumentNullException>(
                        () => ItemUnderTest.DeleteContentItem(null));

                    AssertString("contentItem", exception.ParamName);
                });
        }

        [TestMethod]
        public void WillInvokeStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //    {
            //        ItemUnderTest.DeleteContentItem(ObjectCreator.CreateNew<ContentItem>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.CreateCommandText(StoredProcedures.DeleteContentItem, QueryType.StoredProcedure), 
            //                Times.Once);
            //    });
        }

        [TestMethod]
        public void WillParameters()
        {
            throw new NotImplementedException();
            //ContentItem expected = null;

            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            expected = ObjectCreator.CreateNew<ContentItem>();
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            ItemUnderTest.DeleteContentItem(expected);

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
            //        ItemUnderTest.DeleteContentItem(ObjectCreator.CreateNew<ContentItem>());

            //        Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //            .Verify(x => x.ExecuteNonQuery(), Times.Once);
            //    });
        }
    }
}
