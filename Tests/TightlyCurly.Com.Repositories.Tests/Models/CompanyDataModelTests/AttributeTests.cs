using System;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Repositories.Constants;
using TightlyCurly.Com.Tests.Common.Base;
using TightlyCurly.Com.Tests.Common.Helpers;


namespace TightlyCurly.Com.Repositories.Tests.Models.CompanyDataModelTests
{
    [TestFixture]
    public class AttributeTests //: MockTestBase<CompanyDataModel>
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
            //            {"Name", Tables.Companies}
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
            //            {"FieldName", Columns.CompanyId},
            //            {"DbType", SqlDbType.UniqueIdentifier},
            //            {"ParameterName", Parameters.CompanyId}
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
            //        Property = "ParentCompanyId",
            //        AttributeType = typeof(FieldMetadataAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"FieldName", Columns.ParentCompanyId},
            //            {"DbType", SqlDbType.UniqueIdentifier},
            //            {"ParameterName", Parameters.ParentCompanyId}
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
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Countries",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetCountriesByCompany}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "ContactInfos",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetContactInfosByCompany}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "ParentCompany",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetParentCompanyByCompany}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "ChildCompanies",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetChildCompaniesByCompany}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "Relationships", 
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetRelationshipsByCompany}
            //        }
            //    },
            //    new PropertyAttributeInfo
            //    {
            //        Property = "CompanyType",
            //        AttributeType = typeof(ValueFactoryAttribute),
            //        AttributeValues = new Dictionary<string, object>
            //        {
            //            {"ValueFactoryName", LoaderKeys.GetCompanyTypesByCompany}
            //        }
            //    }
            //});
        }
    }
}
