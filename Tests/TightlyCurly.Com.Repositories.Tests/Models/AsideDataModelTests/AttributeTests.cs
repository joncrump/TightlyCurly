using System;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Repositories.Constants;
using TightlyCurly.Com.Tests.Common.Helpers;


namespace TightlyCurly.Com.Repositories.Tests.Models.AsideDataModelTests
{
    [TestFixture]
    public class AttributeTests //: MockTestBase<AsideDataModel>
    {
        [Test]
        public void TypeIsDecorated()
        {
            throw new NotImplementedException();
            //Asserter.AssertHasClassAttributes(ItemUnderTest, new []
            //{
            //    new AttributeInfo
            //    {
            //        AttributeType = typeof(TableAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"Name", Tables.Asides}
            //        }
            //    }
            //});
        }

        [Test]
        public void PropertiesAreDecorated()
        {
            throw new NotImplementedException();
            //TestRunner.ExecuteTest(() =>
            //{
            //    Asserter.AssertHasPropertyAttributes(ItemUnderTest, new[]
            //    {
            //        new PropertyAttributeInfo
            //        {
            //            Property = "Id",
            //            AttributeType = typeof(FieldMetadataAttribute),
            //            AttributeValues = new Dictionary<string, object>
            //            {
            //                {"FieldName", Columns.AsideId},
            //                {"DbType", SqlDbType.UniqueIdentifier },
            //                {"ParameterName", Parameters.AsideId}
            //            }
            //        },
            //        new PropertyAttributeInfo
            //        {
            //            Property = "EnteredDate",
            //            AttributeType = typeof(FieldMetadataAttribute),
            //            AttributeValues = new Dictionary<string, object>
            //            {
            //                {"FieldName", Columns.EnteredDate},
            //                {"DbType", SqlDbType.SmallDateTime},
            //                {"ParameterName", Parameters.EnteredDate}
            //            }
            //        },
            //        new PropertyAttributeInfo
            //        {
            //            Property = "UpdatedDate",
            //            AttributeType = typeof(FieldMetadataAttribute),
            //            AttributeValues = new Dictionary<string, object>
            //            {
            //                {"FieldName", Columns.UpdatedDate},
            //                {"DbType", SqlDbType.SmallDateTime},
            //                {"ParameterName", Parameters.UpdatedDate}
            //            }
            //        },
            //        new PropertyAttributeInfo
            //        {
            //            Property = "Order",
            //            AttributeType = typeof(FieldMetadataAttribute),
            //            AttributeValues = new Dictionary<string, object>
            //            {
            //                {"FieldName", Columns.Order},
            //                {"DbType", SqlDbType.Int},
            //                {"ParameterName", Parameters.Order},
            //                {"AllowDbNull", true}
            //            }
            //        },
            //        new PropertyAttributeInfo
            //        {
            //            Property = "Text",
            //            AttributeType = typeof(FieldMetadataAttribute),
            //            AttributeValues = new Dictionary<string, object>
            //            {
            //                {"FieldName", Columns.Text},
            //                {"DbType", SqlDbType.NVarChar},
            //                {"ParameterName", Parameters.Text}
            //            }
            //        },
            //        new PropertyAttributeInfo
            //        {
            //            Property = "IsActive",
            //            AttributeType = typeof(FieldMetadataAttribute),
            //            AttributeValues = new Dictionary<string, object>
            //            {
            //                {"FieldName", Columns.IsActive},
            //                {"DbType", SqlDbType.Bit},
            //                {"ParameterName", Parameters.IsActive}
            //            }
            //        }
            //    });
            //});
        }
    }
}
