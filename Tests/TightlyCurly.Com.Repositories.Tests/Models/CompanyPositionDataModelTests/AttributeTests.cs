using System;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Repositories.Constants;
using TightlyCurly.Com.Tests.Common.Base;
using TightlyCurly.Com.Tests.Common.Helpers;


namespace TightlyCurly.Com.Repositories.Tests.Models.CompanyPositionDataModelTests
{
    [TestFixture]
    public class AttributeTests //: MockTestBase<CompanyPositionDataModel>
    {
        [Test]
        public void TypeIsDecorated()
        {
            throw new NotImplementedException();
            //Asserter.AssertHasClassAttributes(ItemUnderTest, new[]
            //{
            //    new AttributeInfo
            //    {
            //        AttributeType = typeof(TableAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"Name", Tables.CompanyPositions}
            //        }
            //    }
            //});
        }

        [Test]
        public void PropertiesAreDecorated()
        {
            throw new NotImplementedException();
            //Asserter.AssertHasPropertyAttributes(ItemUnderTest, new[]
            //{
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Id",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.CompanyPositionId},
            //            {"DbType", SqlDbType.UniqueIdentifier},
            //            {"ParameterName", Parameters.CompanyPositionId}
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
            //      new PropertyAttributeInfo
            //    {
            //        Property = "CompanyId",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.CompanyId},
            //            {"DbType", SqlDbType.UniqueIdentifier},
            //            {"ParameterName", Parameters.CompanyId}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Title",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.Title},
            //            {"DbType", SqlDbType.NVarChar},
            //            {"ParameterName", Parameters.Title}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "StartDate",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.StartDate},
            //            {"DbType", SqlDbType.SmallDateTime},
            //            {"ParameterName", Parameters.StartDate}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "EndDate",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.EndDate},
            //            {"DbType", SqlDbType.SmallDateTime},
            //            {"ParameterName", Parameters.EndDate}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "IsActive",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.IsActive},
            //            {"DbType", SqlDbType.Bit},
            //            {"ParameterName", Parameters.IsActive}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Description",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.Description},
            //            {"DbType", SqlDbType.NVarChar},
            //            {"ParameterName", Parameters.Description}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Notes",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.Notes},
            //            {"DbType", SqlDbType.NVarChar},
            //            {"ParameterName", Parameters.Notes}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Department",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.Department},
            //            {"DbType", SqlDbType.NVarChar},
            //            {"ParameterName", Parameters.Department}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "PositionCategory",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.PositionCategory},
            //            {"DbType", SqlDbType.SmallInt},
            //            {"ParameterName", Parameters.PositionCategory}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Company",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetCompanyByCompanyPosition}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Person",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetPersonByCompanyPosition}
            //        }
            //    }
            //});
        }
    }
}
