using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Repositories.Constants;
using TightlyCurly.Com.Repositories.Models;
using TightlyCurly.Com.Tests.Common.Helpers;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Repositories.Tests.Models.AsideDataModelTests
{
    [TestFixture]
    public class AttributeTests : MsTestMoqTestBase<AsideDataModel>
    {
        [Test]
        public void TypeIsDecorated()
        {
            TestRunner.ExecuteTest(() =>
            {
                Asserter.AssertHasClassAttributes(ItemUnderTest, new []
                {
                    new AttributeInfo
                    {
                        AttributeType = typeof(TableAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"Name", Tables.Asides}
                        }
                    }
                });
            });
        }

        [Test]
        public void PropertiesAreDecorated()
        {
            TestRunner.ExecuteTest(() =>
            {
                Asserter.AssertHasPropertyAttributes(ItemUnderTest, new[]
                {
                    new PropertyAttributeInfo
                    {
                        Property = "Id",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.AsideId},
                            {"DbType", SqlDbType.UniqueIdentifier },
                            {"ParameterName", Parameters.AsideId}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "EnteredDate",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.EnteredDate},
                            {"DbType", SqlDbType.SmallDateTime},
                            {"ParameterName", Parameters.EnteredDate}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "UpdatedDate",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.UpdatedDate},
                            {"DbType", SqlDbType.SmallDateTime},
                            {"ParameterName", Parameters.UpdatedDate}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "Order",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.Order},
                            {"DbType", SqlDbType.Int},
                            {"ParameterName", Parameters.Order},
                            {"AllowDbNull", true}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "Text",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.Text},
                            {"DbType", SqlDbType.NVarChar},
                            {"ParameterName", Parameters.Text}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "IsActive",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.IsActive},
                            {"DbType", SqlDbType.Bit},
                            {"ParameterName", Parameters.IsActive}
                        }
                    }
                });
            });
        }
    }
}
