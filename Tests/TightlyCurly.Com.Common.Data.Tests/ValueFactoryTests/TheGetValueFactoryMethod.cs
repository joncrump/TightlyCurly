using System;
using System.Linq.Expressions;
using TightlyCurly.Com.Common.Exceptions;
using NUnit.Framework;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.ValueFactoryTests
{
    [TestFixture]
    public class TheGetValueFactoryMethod : MockTestBase<TestableValueFactory>
    {
        [Test]
        public void WillThrowArgumentNullExceptionIfKeyIsNull()
        {
            Asserter
                .AssertException<ArgumentNullException>(
                    () => ItemUnderTest.GetValueFactory(null))
                .AndVerifyHasParameter("key");
        }

        [Test]
        public void WillThrowArgumentEmptyExceptionIfKeyIsEmpty()
        {
            Asserter
                .AssertException<ArgumentEmptyException>(
                    () => ItemUnderTest.GetValueFactory(String.Empty))
                .AndVerifyHasParameter("key");
        }

        [Test]
        public void WillReturnExpressionIfParameterIsNull()
        {
            Expression<Func<object, object>> expected = null;
            var key = String.Empty;

            expected = e => null;
            key = DataGenerator.GenerateString();

            ItemUnderTest.Delegates
                .Add(key, expected);
            var actual = ItemUnderTest.GetValueFactory(key);

            Asserter.AssertEquality("() => e => null", actual.ToString());
        }

        [Test]
        public void WillReturnExpressionWithParameter()
        {
            string expected = null;
            var key = String.Empty;
            var random = String.Empty;

            key = DataGenerator.GenerateString();
            expected = DataGenerator.GenerateString();
            random = DataGenerator.GenerateString();

            Expression<Func<object, string>> expression = e => e.ToString() + random;

            ItemUnderTest.Delegates
                .Add(key, expression);
            var returnExpression = ItemUnderTest.GetValueFactory(key, new ParameterInfo(typeof(string), expected));
            var actual = returnExpression.Compile()();

            Asserter.AssertEquality(expected + random, actual.ToString());
        }
    }
}