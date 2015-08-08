using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Repositories.Constants;
using TightlyCurly.Com.Repositories.Models;
using TightlyCurly.Com.Tests.Common.Helpers;
using TightlyCurly.Com.Tests.Common.MsTest;

namespace TightlyCurly.Com.Repositories.Tests.Models.CompanyRelationshipNodeDataModelTests
{
    [TestClass]
    public class AttributeTests : MsTestMoqTestBase<CompanyRelationshipNodeDataModel>
    {
        [TestMethod]
        public void TypeIsDecorated()
        {
            TestRunner.ExecuteTest(() =>
            {
                Asserter.AssertHasClassAttributes(ItemUnderTest, new[]
                {
                    new AttributeInfo
                    {
                        AttributeType = typeof(TableAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"Name", Tables.CompanyRelationships}
                        }
                    }
                });
            });
        }

        [TestMethod]
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
                            {"FieldName", Columns.RelationshipNodeId},
                            {"DbType", SqlDbType.UniqueIdentifier},
                            {"ParameterName", Parameters.RelationshipNodeId}
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
                        Property = "UpdateDate",
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
                        Property = "StartDate",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.StartDate},
                            {"DbType", SqlDbType.SmallDateTime},
                            {"ParameterName", Parameters.StartDate}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "EndDate",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.EndDate},
                            {"DbType", SqlDbType.SmallDateTime},
                            {"ParameterName", Parameters.EndDate}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "Name",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.Name},
                            {"DbType", SqlDbType.NVarChar},
                            {"ParameterName", Parameters.Name}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "Notes",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.Notes},
                            {"DbType", SqlDbType.NVarChar},
                            {"ParameterName", Parameters.Notes}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "RelationshipType",
                        AttributeType = typeof(FieldMetadataAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"FieldName", Columns.RelationshipType},
                            {"DbType", SqlDbType.Int},
                            {"ParameterName", Parameters.RelationshipType}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "Parents",
                        AttributeType = typeof(ValueFactoryAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"ValueFactoryName", LoaderKeys.GetParentsByRelationshipNode}
                        }
                    },
                    new PropertyAttributeInfo
                    {
                        Property = "Children",
                        AttributeType = typeof(ValueFactoryAttribute),
                        AttributeValues = new Dictionary<string, object>
                        {
                            {"ValueFactoryName", LoaderKeys.GetChildrenByRelationshipNode}
                        }
                    }
                });
            });
        }
    }
}
