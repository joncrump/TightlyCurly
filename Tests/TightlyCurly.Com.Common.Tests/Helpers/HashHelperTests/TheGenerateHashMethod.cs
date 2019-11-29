﻿using System;
using NUnit.Framework;
using TightlyCurly.Com.Common.Helpers;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Tests.Helpers.HashHelperTests
{
    [TestFixture]
    public class TheGenerateHashMethod : MockTestBase<HashHelper>
    {
        [Test]
        public void WillThrowArgumentNullExceptionIfValueIsNull()
        {
            Asserter
                .AssertException<ArgumentNullException>(
                    () => SystemUnderTest.GenerateHash(null))
                .AndVerifyHasParameter("value");
        }

        [Test]
        public void WillReturnHashIfValueIsHashable()
        {
            var actual = SystemUnderTest.GenerateHash(new HashableTestClass());

            Asserter.AssertEquality("TestingHash", actual);
        }

        [Test]
        public void WillReturnHashCodeOfObject()
        {
            string value = null;
            string expected = null;

            value = DataGenerator.GenerateString();
            expected = value.GetHashCode().ToString();
            var actual = SystemUnderTest.GenerateHash(value);

            Asserter.AssertEquality(expected, actual);
        }

        public class HashableTestClass : IHashable
        {
            public string Hash
            {
                get { return "TestingHash"; }
            }
        }
    }
}
