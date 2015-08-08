using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TightlyCurly.Com.Common.Data.Builders;
using TightlyCurly.Com.DataAccess.Builders;
using TightlyCurly.Com.Framework.Helpers;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.DataAccess.Tests.Builders.ReflectionBasedDataReaderBuilderTests
{
    [TestClass]
    public class TheConstructor : TestBase
    {
        [TestMethod]
        public void WillThrowArgumentNullExceptionIfDelegateFactoryIsNull()
        {
            var exception = AssertException<ArgumentNullException>(
                () => new ReflectionBasedDataReaderBuilder(null, It.IsAny<IEnumParser>()));

            AssertString("delegateFactory", exception.ParamName);
        }

        [TestMethod]
        public void WillThrowArgumentNullExceptionIfEnumParserIsNull()
        {
            var exception = AssertException<ArgumentNullException>(
                () => new ReflectionBasedDataReaderBuilder(new Mock<ILoaderDelegateFactory>().Object, null));

            AssertString("enumParser", exception.ParamName);
        }
    }
}
