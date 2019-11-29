using System;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Repositories.Constants;
using TightlyCurly.Com.Tests.Common.Base;
using TightlyCurly.Com.Tests.Common.Helpers;


namespace TightlyCurly.Com.Repositories.Tests.Models.CategoryTypeDataModelTests
{
    [TestFixture]
    public class AttributeTests //: MockTestBase<CategoryTypeDataModel>
    {
        [Test]
        public void TypeIsDecorated()
        {
            throw new NotImplementedException();
            //Asserter.AssertHasClassAttributes(SystemUnderTest, new[]
            //{
            //    new AttributeInfo
            //    {
            //        AttributeType = typeof(TableAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"Name", Tables.CategoryTypes}
            //        }
            //    }
            //});
        }

        [Test]
        public void PropertiesAreDecorated()
        {
            throw new NotImplementedException();
                //Asserter.AssertHasPropertyAttributes(SystemUnderTest, new[]
                //{
                //    new PropertyAttributeInfo
                //    {
                //        Property = "Id",
                //        AttributeType = typeof(FieldMetadataAttribute),
                //        AttributeValues = new Dictionary<string, object>
                //        {
                //            {"FieldName", Columns.CategoryTypeId},
                //            {"DbType", SqlDbType.UniqueIdentifier},
                //            {"ParameterName", Parameters.CategoryTypeId}
                //        }
                //    },
                //    new PropertyAttributeInfo
                //    {
                //        Property = "EnteredDate",
                //        AttributeType = typeof(FieldMetadataAttribute),
                //        AttributeValues = new Dictionary<string, object>
                //        {
                //            {"FieldName", Columns.EnteredDate},
                //            {"DbType", SqlDbType.DateTime},
                //            {"ParameterName", Parameters.EnteredDate}
                //        }
                //    },
                //    new PropertyAttributeInfo
                //    {
                //        Property = "UpdatedDate",
                //        AttributeType = typeof(FieldMetadataAttribute),
                //        AttributeValues = new Dictionary<string, object>
                //        {
                //            {"FieldName", Columns.UpdatedDate},
                //            {"DbType", SqlDbType.DateTime},
                //            {"ParameterName", Parameters.UpdatedDate}
                //        }
                //    },
                //    new PropertyAttributeInfo
                //    {
                //        Property = "Name",
                //        AttributeType = typeof(FieldMetadataAttribute),
                //        AttributeValues = new Dictionary<string, object>
                //        {
                //            {"FieldName", Columns.Name},
                //            {"DbType", SqlDbType.NVarChar},
                //            {"ParameterName", Parameters.Name}
                //        }
                //    }
                //});
        }
    }
}
