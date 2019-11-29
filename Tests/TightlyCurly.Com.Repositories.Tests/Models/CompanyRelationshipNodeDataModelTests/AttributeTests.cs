﻿using System;
using System.Collections.Generic;
using System.Data;
using NUnit.Framework;
using TightlyCurly.Com.Common.Data.Attributes;
using TightlyCurly.Com.Repositories.Constants;
using TightlyCurly.Com.Tests.Common.Base;
using TightlyCurly.Com.Tests.Common.Helpers;


namespace TightlyCurly.Com.Repositories.Tests.Models.CompanyRelationshipNodeDataModelTests
{
    [TestFixture]
    public class AttributeTests //: MockTestBase<CompanyRelationshipNodeDataModel>
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
            //            {"Name", Tables.CompanyRelationships}
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
                //            {"FieldName", Columns.RelationshipNodeId},
                //            {"DbType", SqlDbType.UniqueIdentifier},
                //            {"ParameterName", Parameters.RelationshipNodeId}
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
                //        Property = "UpdateDate",
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
                //        Property = "RelationshipType",
                //        AttributeType = typeof(FieldMetadataAttribute),
                //        AttributeValues = new Dictionary<string, object>
                //        {
                //            {"FieldName", Columns.RelationshipType},
                //            {"DbType", SqlDbType.Int},
                //            {"ParameterName", Parameters.RelationshipType}
                //        }
                //    },
                //    new PropertyAttributeInfo
                //    {
                //        Property = "Parents",
                //        AttributeType = typeof(ValueFactoryAttribute),
                //        AttributeValues = new Dictionary<string, object>
                //        {
                //            {"ValueFactoryName", LoaderKeys.GetParentsByRelationshipNode}
                //        }
                //    },
                //    new PropertyAttributeInfo
                //    {
                //        Property = "Children",
                //        AttributeType = typeof(ValueFactoryAttribute),
                //        AttributeValues = new Dictionary<string, object>
                //        {
                //            {"ValueFactoryName", LoaderKeys.GetChildrenByRelationshipNode}
                //        }
                //    }
                //});
        }
    }
}
