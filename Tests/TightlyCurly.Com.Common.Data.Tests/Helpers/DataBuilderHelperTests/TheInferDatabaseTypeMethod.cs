using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Helpers;
using TightlyCurly.Com.Tests.Common.Base;

namespace TightlyCurly.Com.Common.Data.Tests.Helpers.DataBuilderHelperTests
{
    [TestFixture]
    public class TheInferDatabaseTypeMethod : MockTestBase<DataBuilderHelper>
    {
    
        [TestCase(typeof(long), SqlDbType.BigInt)]
        [TestCase(typeof(bool), SqlDbType.Bit)]
        [TestCase(typeof(DateTime), SqlDbType.DateTime)]
        [TestCase(typeof(decimal), SqlDbType.Decimal)]
        [TestCase(typeof(float), SqlDbType.Float)]
        [TestCase(typeof(object), SqlDbType.Image)]
        [TestCase(typeof(int), SqlDbType.Int)]
        [TestCase(typeof(char), SqlDbType.NChar)]
        [TestCase(typeof(string), SqlDbType.NVarChar)]
        [TestCase(typeof(Guid), SqlDbType.UniqueIdentifier)]
        [TestCase(typeof(short), SqlDbType.SmallInt)]
        [TestCase(typeof(byte), SqlDbType.TinyInt)]
        [TestCase(typeof(DateTimeOffset), SqlDbType.DateTimeOffset)]
        public void WillReturnExpectedMappings(Type type, SqlDbType expected)
        {
            var actual = SystemUnderTest.InferDatabaseType(type);
            Asserter.AssertEquality(expected, actual);
        }
        
    }
}
