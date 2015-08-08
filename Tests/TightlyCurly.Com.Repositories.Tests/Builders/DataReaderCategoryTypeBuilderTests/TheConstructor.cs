﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Repositories.Builders;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Repositories.Tests.Builders.DataReaderCategoryTypeBuilderTests
{
    [TestClass]
    public class TheConstructor : MsTestBase
    {
        [TestMethod]
        public void WillPassConstructorTests()
        {
            DoConstructorTests<DataReaderCategoryTypeBuilder>();
        }
    }
}
