using System;
using System.Linq.Expressions;
using TightlyCurly.Com.Common.Data.Constants;
using TightlyCurly.Com.Common.Exceptions;
using NUnit.Framework;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.ValueFactoryTests
{
    [TestFixture]
    public class TheDeleteValueFactoryMethod : MockTestBase<TestableValueFactory>
    {
        [Test]
        public void WillThrowArgumentNullExceptionIfKeyIsNull()
        {
            Asserter
                .AssertException<ArgumentNullException>(
                    () => ItemUnderTest.DeleteValueFactory(null))
                .AndVerifyHasParameter("key");
        }

        [Test]
        public void WillThrowArgumentEmptyExceptionIfKeyIsEmpty()
        {
            Asserter
                .AssertException<ArgumentEmptyException>(
                    () => ItemUnderTest.DeleteValueFactory(String.Empty))
                .AndVerifyHasParameter("key");
        }

        [Test]
        public void WillThrowInvalidOperationExceptionIfKeyDoesNotExist()
        {
            Expression<Func<object, object>> expression = e => null;

            ItemUnderTest.Delegates.Add(DataGenerator.GenerateString(), expression);
            Asserter
                .AssertException<InvalidOperationException>(
                    () => ItemUnderTest.DeleteValueFactory(DataGenerator.GenerateString()))
                .AndVerifyMessageContains(ErrorMessages.CannotDeleteExpression);
        }

        [Test]
        public void WillDeleteValueFactory()
        {
            var key = String.Empty;

            key = DataGenerator.GenerateString();
            Expression<Func<object, object>> expression = e => null;

            ItemUnderTest.Delegates.Add(key, expression);
            ItemUnderTest.DeleteValueFactory(key);

            Assert.IsFalse(ItemUnderTest.Delegates.ContainsKey(key));
        }
    }
}