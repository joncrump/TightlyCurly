using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Helpers;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.Helpers.DataBuilderHelperTests
{
    [TestFixture]
    public class TheGetParameterNameMethod : MockTestBase<DataBuilderHelper>
    {
        [Test]
        public void WillReturnParameterBasedOnName()
        {
            var parameterName = "SomeProperty";
            var expected = "@someProperty";

            var actual = SystemUnderTest.GetParameterName(parameterName);

            Asserter.AssertEquality(expected, actual);
        }
    }
}
