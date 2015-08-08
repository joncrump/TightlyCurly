﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Models;
using TightlyCurly.Com.Repositories.Builders;
using TightlyCurly.Com.Repositories.Models;
using TightlyCurly.Com.Tests.Common.MsTest.Data;

namespace TightlyCurly.Com.Repositories.Tests.Builders.DataReaderContentArticleDataBuilderTests
{
    [TestClass]
    public class TheBuildMethod : MsTestMoqDataReaderBuilderTestBase<DataReaderContentArticleDataBuilder, IContentArticleData>
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
                    WillBuildItem<ContentArticleDataDataModel>(
                        propertiesToIgnore:new[] {"ValueFactories", "Notes", "Revisions", "ContentItem", 
                        "MetaKeywords", "Data", "Locale"});
                });
        }
    }
}
