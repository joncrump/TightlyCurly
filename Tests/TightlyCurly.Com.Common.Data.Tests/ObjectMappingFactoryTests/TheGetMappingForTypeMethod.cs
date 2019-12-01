﻿using System;
using Moq;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Mappings;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.ObjectMappingFactoryTests
{
    [TestFixture]
    public class TheGetMappingForTypeMethod : MockTestBase<ObjectMapperFactory>
    {
        [Test]
        public void WillThrowArgumentNullExceptionIfObjectTypeIsNull()
        {
            throw new NotImplementedException();
            //Asserter.AssertException<ArgumentNullException>(() =>
            //        SystemUnderTest.GetMappingForType(null, It.IsAny<MappingKind>()))
            //    .AndVerifyHasParameter("objectType");
        }

        /*
         * public IMapping GetMappingForType(Type objectType, MappingKind mappingKind)
        {
            throw new NotImplementedException();
        }
         */
    }
}
