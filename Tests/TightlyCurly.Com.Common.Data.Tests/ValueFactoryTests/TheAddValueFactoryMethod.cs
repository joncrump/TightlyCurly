using System;
using System.Linq.Expressions;
using TightlyCurly.Com.Common.Data.Constants;
using TightlyCurly.Com.Common.Exceptions;
using NUnit.Framework;
using TightlyCurly.Com.Tests.Common.Base;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TightlyCurly.Com.Common.Data.Tests.ValueFactoryTests
{
    [TestFixture]
    public class TheAddValueFactoryMethod : MockTestBase<TestableValueFactory>
    {
        [Test]
        public void WillThrowArgumentNullExceptionIfKeyIsNull()
        {
            Asserter
                .AssertException<ArgumentNullException>(
                    () => ItemUnderTest.AddValueFactory(null, e => new object()))
                .AndVerifyHasParameter("key");
        }

        [Test]
        public void WillThrowArgumentEmptyExceptionIfKeyIsEmpty()
        {
            Asserter
                .AssertException<ArgumentEmptyException>(
                    () => ItemUnderTest.AddValueFactory(String.Empty, e => new object()))
                .AndVerifyHasParameter("key");
        }

        [Test]
        public void WillThrowArgumentNullExceptionIfValueFactoryIsNull()
        {
            Asserter
                .AssertException<ArgumentNullException>(
                    () => ItemUnderTest.AddValueFactory(DataGenerator.GenerateString(), (Expression<Action>) null))
                .AndVerifyHasParameter("valueFactory");
        }

        [Test]
        public void WillThrowInvalidOperationExceptionIfValueFactoryAlreadyExists()
        {
            var key = String.Empty;

            Expression<Func<object, object>> expression = e => null;
            key = DataGenerator.GenerateString();

            ItemUnderTest.Delegates.Add(key, expression);
            Asserter
                .AssertException<InvalidOperationException>(
                    () => ItemUnderTest.AddValueFactory(key, e => (Expression<Action>)null))
                .AndVerifyMessageContains(ErrorMessages.CannotAddExpression);
        }

        [Test]
        public void WillAddDelegate()
        {
            var key = String.Empty;

            key = DataGenerator.GenerateString();
            Expression<Func<object, object>> expression = e => null;

            ItemUnderTest.Delegates.Add(DataGenerator.GenerateString(), expression);
            Expression<Func<object, object>> param = e => DataGenerator.GenerateInteger(1, 5);

            ItemUnderTest.AddValueFactory(key, param);

            Assert.IsTrue(ItemUnderTest.Delegates.ContainsKey(key));
        }
    }
}
