﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Common.Data.Mappings;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.Mappings.ReflectionBasedDataMapperTests
{
    [TestFixture]
    public class TheGetMappingForTypeMethod : MockTestBase<ReflectionBasedDataMapper>
    {
        [Test]
        public void WillThrowArgumentNullExceptionIfObjectTypeIsNull()
        {
            Asserter
                .AssertException<ArgumentNullException>(() => SystemUnderTest.GetMappingForType(null))
                .AndVerifyHasParameter("objectType");
        }

        [Test]
        public void WillReturnMappingBasedOnType()
        {
            var expected = GetExpected();

            var actual = SystemUnderTest.GetMappingForType(typeof(TestClass));

            Asserter.AssertEquality(expected, actual);
        }

        private TypeMapping GetExpected()
        {
            return new TypeMapping
            {
                DataSource = "dbo.FakeTable",
                Type = typeof(TestClass),
                CountField = "Id",
                CountAlias = "NumRows",
                PropertyMappings = GetPropertyMappings()
            };
        }

        private IEnumerable<PropertyMapping> GetPropertyMappings()
        {
            throw new NotImplementedException();
        }

        [Table("dbo.FakeTable")]
        public class TestClass
        {
            [CountMetadata("Id", "NumRows")]
            [FieldMetadata("Id", SqlDbType.Int, "@id", true, false, 0, null, true)]
            public int Id { get; set; }

            [FieldMetadata("Name", SqlDbType.NVarChar, "@name", false, false, 1)]
            public string Name { get; set; }

            [FieldMetadata("ForeignKey", SqlDbType.Int, "@foreignKey", false, false, 2, 
                null, false)]
            [Join(JoinType.Inner, typeof(int), "ForeignKey", "Id")]
            public int ForeignKey { get; set; }
        }
    }
}
