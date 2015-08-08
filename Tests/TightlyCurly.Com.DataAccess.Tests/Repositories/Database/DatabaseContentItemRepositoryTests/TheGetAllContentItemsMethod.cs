using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.DataAccess.Repositories.Database;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Repositories.Database.DatabaseContentItemRepositoryTests
{
    [TestClass]
    public class TheGetAllContentItemsMethod : MoqTestBase<DatabaseContentItemRepository>
    {
        [TestMethod]
        public void WillExecuteStoredProcedure()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(
            //    () =>
            //        {
            //            ItemUnderTest.GetAllContentItems();

            //            Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //                .Verify(x => x.CreateCommandText(StoredProcedures.GetAllContentItems, QueryType.StoredProcedure), 
            //                    Times.Once);
            //        });
        }

        [TestMethod]
        public void WillReturnValues()
        {
            throw new NotImplementedException();
            //IEnumerable<ContentItem> expected = null;
    
            //TestRunner
            //    .DoCustomSetup(() =>
            //        {
            //            expected = CreateEnumerableOfItems(() => ObjectCreator.CreateNew<ContentItem>());

            //            Mocks.Get<Mock<IDatabaseWrapper>>("database")
            //                .Setup(x => x.ExecuteMultiple(It.IsAny<Func<IDataReader, ContentItem>>()))
            //                .Returns(expected);
            //        })
            //    .ExecuteTest(() =>
            //        {
            //            var actual = ItemUnderTest.GetAllContentItems();

            //            AssertEnumerable(expected, actual, comparisonDelegate: (e, a) =>
            //                {
            //                    AssertObject(e, a, propertiesToIgnore: new[] {"ViewStatus", "Articles", "Locale"});
            //                });
            //        });
        }
    }
}
