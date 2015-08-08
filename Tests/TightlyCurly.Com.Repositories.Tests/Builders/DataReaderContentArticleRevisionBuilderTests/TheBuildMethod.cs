using System;using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Models;
using TightlyCurly.Com.Repositories.Builders;
using TightlyCurly.Com.Tests.Common.MsTest.Data;

namespace TightlyCurly.Com.Repositories.Tests.Builders.DataReaderContentArticleRevisionBuilderTests
{
    [TestClass]
    public class TheBuildMethod : MsTestMoqDataReaderBuilderTestBase<DataReaderContentArticleRevisionBuilder, 
        IContentArticleRevision>
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfDataSourceIsNull()
        {
            //throw new NotImplementedException();
        }
    }
}
