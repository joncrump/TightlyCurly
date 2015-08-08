using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Models;
using TightlyCurly.Com.Repositories.Builders;
using TightlyCurly.Com.Repositories.Models;
using TightlyCurly.Com.Tests.Common;
using TightlyCurly.Com.Tests.Common.MsTest.Data;

namespace TightlyCurly.Com.Repositories.Tests.Builders.DataReaderAddressBuilderTests
{
    [TestClass]
    public class TheBuildMethod : MsTestMoqDataReaderBuilderTestBase<DataReaderAddressBuilder, IAddress>
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
        public void WillBuildModel()
        {
            TestRunner.ExecuteTest(() =>
                {
                    WillBuildItem<AddressDataModel>(
                        typeMappings: new[]
                            {
                                new MappedType(typeof(ICountry), typeof(CountryDataModel)),
                                new MappedType(typeof(IStateProvince), typeof(StateProvinceDataModel)) 
                            },
                        childPropertiesToIgnore: new Dictionary<string, IEnumerable<string>>
                            {
                                {"StateProvince", new[] {"Country"}}
                            },
                        propertiesToIgnore: new[]
                            {
                                "ValueFactories", "Country", "StateProvince"
                            }, 
                        modelParameters: new Dictionary<string, object>
                            {
                                {"StateProvinceId", Guid.NewGuid()}
                            });
                });
        }
    }
}
