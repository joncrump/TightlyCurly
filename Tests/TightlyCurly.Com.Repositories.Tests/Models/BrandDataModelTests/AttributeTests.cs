using System;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Repositories.Constants;
using TightlyCurly.Com.Tests.Common.Helpers;


namespace TightlyCurly.Com.Repositories.Tests.Models.BrandDataModelTests
{
    [TestFixture]
    public class AttributeTests //: MockTestBase<BrandDataModel>
    {
        [Test]
        public void TypeIsDecorated()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //{
            //    Asserter.AssertHasClassAttributes(SystemUnderTest, new[]
            //    {
            //        new AttributeInfo
            //        {
            //            AttributeType = typeof(TableAttribute),
            //            AttributeValues = new Dictionary<string, object>
            //            {
            //                {"Name", Tables.Brands}
            //            }
            //        }
            //    });
            //});
        }

        [Test]
        public void PropertiesAreDecorated()
        {
            throw new NotImplementedException();
            //Asserter.AssertHasPropertyAttributes(SystemUnderTest, new []
            //{
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Id",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.BrandId},
            //            {"DbType", SqlDbType.UniqueIdentifier},
            //            {"ParameterName", Parameters.BrandId}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "EnteredDate",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.EnteredDate},
            //            {"DbType", SqlDbType.SmallDateTime},
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
            //            {"DbType", SqlDbType.SmallDateTime},
            //            {"ParameterName", Parameters.UpdatedDate}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "BrandName",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.BrandName},
            //            {"DbType", SqlDbType.NVarChar},
            //            {"ParameterName", Parameters.BrandName}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "ManufacturerId",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.ManufacturerId},
            //            {"DbType", SqlDbType.UniqueIdentifier},
            //            {"ParameterName", Parameters.ManufacturerId}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Manufacturer",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetManufacturerByBrand}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Copyrights",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetCopyrightsByBrand}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Trademarks",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetTrademarksByBrand}
            //        }
            //    }
            //});
        }
    }
}
