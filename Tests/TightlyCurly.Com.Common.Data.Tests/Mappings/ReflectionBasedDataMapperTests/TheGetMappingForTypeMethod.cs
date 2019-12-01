using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
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

        }
        /*
         * public TypeMapping GetMappingForType(Type objectType)
        {
            throw new NotImplementedException();
        }
         */
    }
}
