using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Repositories.Constants;
using TightlyCurly.Com.Repositories.Models;
using TightlyCurly.Com.Tests.Common.Helpers;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Repositories.Tests.Models.AddressDataModelTests
{
    [TestClass]
    public class AttributeTests : MsTestMoqTestBase<AddressDataModel>
    {
        [TestMethod]
        public void HasTypeAttributes()
        {
            TestRunner.ExecuteTest(() =>
            {
                Asserter.AssertHasClassAttributes(ItemUnderTest,
                    new[]
                    {
                        new AttributeInfo
                        {
                            AttributeType = typeof(TableAttribute),
                            AttributeValues = new Dictionary<string, object>
                            {
                                {"Name", Tables.Addresses}
                            }
                        }
                    });
            });
        }

        [TestMethod]
        public void HasPropertyAttributes()
        {
            Asserter.AssertHasPropertyAttributes(ItemUnderTest,
                new[]
                {
                    new PropertyAttributeInfo
                    {
                        Property = "Id",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.AddressId},
                            {"DbType", SqlDbType.UniqueIdentifier },
                            {"ParameterName", Parameters.AddressId}
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
                        Property = "Line1",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.Line1},
                            {"DbType", SqlDbType.NVarChar},
                            {"ParameterName", Parameters.Line1}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "Line2",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.Line2},
                            {"DbType", SqlDbType.NVarChar},
                            {"ParameterName", Parameters.Line2}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "City",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.City},
                            {"DbType", SqlDbType.NVarChar},
                            {"ParameterName", Parameters.City}
                        },
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "StateProvinceId",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.StateProvinceId},
                            {"DbType", SqlDbType.UniqueIdentifier},
                            {"ParameterName", Parameters.StateProvinceId}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "PostalCode",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.PostalCode},
                            {"DbType", SqlDbType.NVarChar},
                            {"ParameterName", Parameters.PostalCode}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "CountryId",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.CountryId},
                            {"DbType", SqlDbType.UniqueIdentifier},
                            {"ParameterName", Parameters.CountryId}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "Country",
                        AttributeType = typeof(ValueFactoryAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"ValueFactoryName", LoaderKeys.GetCountryByAddress}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "StateProvince",
                        AttributeType = typeof(ValueFactoryAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"ValueFactoryName", LoaderKeys.GetStateProvinceByAddress}
                        }
                    }
                });
        }
    }
}
