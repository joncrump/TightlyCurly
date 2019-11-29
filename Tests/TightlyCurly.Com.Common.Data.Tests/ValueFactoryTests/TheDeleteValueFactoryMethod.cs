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
                    () => SystemUnderTest.DeleteValueFactory(null))
                .AndVerifyHasParameter("key");
        }

        [Test]
        public void WillThrowArgumentEmptyExceptionIfKeyIsEmpty()
        {
            Asserter
                .AssertException<ArgumentEmptyException>(
                    () => SystemUnderTest.DeleteValueFactory(String.Empty))
                .AndVerifyHasParameter("key");
        }

        [Test]
        public void WillThrowInvalidOperationExceptionIfKeyDoesNotExist()
        {
            Expression<Func<object, object>> expression = e => null;

            SystemUnderTest.Delegates.Add(DataGenerator.GenerateString(), expression);
            Asserter
                .AssertException<InvalidOperationException>(
                    () => SystemUnderTest.DeleteValueFactory(DataGenerator.GenerateString()))
                .AndVerifyMessageContains(ErrorMessages.CannotDeleteExpression);
        }

        [Test]
        public void WillDeleteValueFactory()
        {
            var key = String.Empty;

            key = DataGenerator.GenerateString();
            Expression<Func<object, object>> expression = e => null;

            SystemUnderTest.Delegates.Add(key, expression);
            SystemUnderTest.DeleteValueFactory(key);

            Assert.IsFalse(SystemUnderTest.Delegates.ContainsKey(key));
        }
    }
}