using System;
using Moq;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.QueryBuilders.Strategies.TSql;
using TightlyCurly.Com.Common.Extensions;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.QueryBuilders.Strategies.TSql.CountQueryBuilderStrategyTests
{
    [TestFixture]
    public class TheBuildQueryMethod : MockTestBase<CountQueryBuilderStrategy>
    {
        [Test]
        public void WillThrowInvalidOperationExceptionIfTypeHasNoCountMetadataAttribute()
        {
            Asserter
                .AssertException<InvalidOperationException>(
                    () => ItemUnderTest.BuildQuery<DummyCountClassWithNoCountAttributes>(It.IsAny<dynamic>()))
                .AndVerifyMessageContains("Could not build query. Type {0} does not have a count attribute."
                    .FormatString(typeof (DummyCountClassWithNoCountAttributes).ToString()));
        }

        [TestMethod]
        public void WillThrowInvalidOperationExceptionIfTypeHasNoTableAttribute()
        {
            TestRunner.ExecuteTest(() =>
            {
                Asserter
                    .AssertExceptionIsThrown<InvalidOperationException>(
                        () => ItemUnderTest.BuildQuery<DummyCountClassWithNoAttributes>(It.IsAny<dynamic>()))
                    .AndVerifyMessageContains("Could not build query. Type {0} does not have a table attribute."
                        .FormatString(typeof (DummyCountClassWithNoAttributes)));
            });
        }

        [TestMethod]
        public void WillBuildCountQuery()
        {
            QueryInfo expected = null;

            TestRunner
                .DoCustomSetup(() =>
                {
                    const string query = "SELECT COUNT(Id) AS IdCount FROM dbo.SomeTable;";

                    expected = new QueryInfo(query);
                })
                .ExecuteTest(() =>
                {
                    var actual = ItemUnderTest.BuildQuery<DummyCountClassWithCountAttributes>(It.IsAny<dynamic>());

                    Assert.IsNotNull(actual);
                    Asserter.AssertEquality(expected.Query, actual.Query);
                    Assert.IsNull(actual.Parameters);
                });
        }

        public class DummyCountClassWithNoAttributes
        {
        }

        [Table("dbo.SomeTable")]
        public class DummyCountClassWithCountAttributes
        {
            [CountMetadata("Id", "IdCount")]
            public int Id { get; set; }
        }

        [Table("dbo.SomeTable")]
        public class DummyCountClassWithNoCountAttributes
        {
            public int Id { get; set; }
        }
    }
}
