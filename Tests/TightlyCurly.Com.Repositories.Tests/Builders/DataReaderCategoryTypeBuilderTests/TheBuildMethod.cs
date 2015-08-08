using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Models;
using TightlyCurly.Com.Repositories.Builders;
using TightlyCurly.Com.Repositories.Models;
using TightlyCurly.Com.Tests.Common.MsTest.Data;

namespace TightlyCurly.Com.Repositories.Tests.Builders.DataReaderCategoryTypeBuilderTests
{
    [TestClass]
    public class TheBuildMethod : MsTestMoqDataReaderBuilderTestBase<DataReaderCategoryTypeBuilder, ICategoryType>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfDataSourceIsNull()
        {
            TestRunner.ExecuteTest(() =>
                {
                    ExceptionAsserter
                        .AssertExceptionIsThrown<ArgumentNullException>(
                            () => ItemUnderTest.Build(null))
                        .AndVerifyHasParameter("dataSource");
                });

        }

        [TestMethod]
        public void WillBuildItem()
        {
            TestRunner.ExecuteTest(() =>
                {
                    WillBuildItem<CategoryTypeDataModel>(
                        propertiesToIgnore:new[] {"Names", "ValueFactories"});
                });
        }
    }
}
