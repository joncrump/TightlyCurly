using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Models;
using TightlyCurly.Com.Repositories.Builders;
using TightlyCurly.Com.Repositories.Models;
using TightlyCurly.Com.Tests.Common.MsTest.Data;

namespace TightlyCurly.Com.Repositories.Tests.Builders.DataReaderContactInfoBuilderTests
{
    [TestClass]
    public class TheBuildMethod : MsTestMoqDataReaderBuilderTestBase<DataReaderContactInfoBuilder, 
        IContactInfo>
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
        public void WillBuildMethod()
        {
            TestRunner.ExecuteTest(() =>
                {
                    WillBuildItem<ContactInfoDataModel>(
                        propertiesToIgnore: new[]
                            {
                                "ValueFactories",
                                "People",
                                "Addresses",
                                "PhoneNumbers",
                                "EmailAddresses",
                                "SocialMedia",
                                "CompanyPositions",
                                "Contacts"
                            });
                });
        }
    }
}
