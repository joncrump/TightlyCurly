// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.ICompanyRelationshipNode, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.CompanyRelationships",
        "countProperty":"Id",
        "propertyMappings:": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "CompanyRelationshipId",
                "isPrimaryKey": true
            },
            {
                "propertyName": "EnteredDate",
                "fieldType": "smalldatetime",
                "field": "EnteredDate"
            },
            {
                "propertyName": "UpdatedDate",
                "fieldType": "smalldatetime",
                "field": "UpdatedDate"
            },
            {
                "propertyName": "StartDate",
                "fieldType": "smalldatetime",
                "field": "StartDate",
                "allowDbNull": true
            },
            {
                "propertyName": "EndDate",
                "fieldType": "smalldatetime",
                "field": "EndDate",
                "allowDbNull": true
            },
            {
                "propertyName": "Name",
                "fieldType": "nvarchar",
                "field": "Name"
            },
            {
                "propertyName": "Notes",
                "fieldType": "nvarchar",
                "field": "Notes",
                "allowDbNull": true
            },
            {
                "propertyName": "RelationshipTypes",
                "lazyLoader": "GetRelationshipTypesByCompanyRelationship",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CompanyRelationshipId",
                    "rightKey": "CompanyRelationshipId",
                    "joinTable": "dbo.CompanyRelationships_RelationshipTypes",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "RelationshipTypeId",
                    "joinTableRightKey": "RelationshipTypeId"
                }
            },
            {
                "propertyName": "Parents",
                "lazyLoader": "GetParentsByCompanyRelationship",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CompanyRelationshipId",
                    "rightKey" : "ParentId"
                }
            },
            {
                "propertyName": "Children",
                "lazyLoader": "GetChildByCompanyRelationship",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "ParentId",
                    "rightKey": "CompanyRelationshipId"
                }
            }
        ]
    }
]