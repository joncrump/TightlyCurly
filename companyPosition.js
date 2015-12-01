[
    {
        "type":"TightlyCurly.Com.Common.Models.ICompanyPosition, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.CompanyPositions",
        "countProperty":"Id",
        "propertyMappings": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "CompanyPositionId",
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
                "propertyName": "CompanyId",
                "fieldType": "guid",
                "field": "CompanyId",
                "allowDbNull": true
            },
            {
                "propertyName": "Title",
                "fieldType": "nvarchar",
                "field": "Title"
            },
            {
                "propertyName": "StartDate",
                "fieldType": "smalldatetime",
                "field": "StartDate",
                "allowDbNull" : true
            },
            {
                "propertyName": "EndDate",
                "fieldType": "smalldatetime",
                "field": "EndDate",
                "allowDbNull" : true
            },
            {
                "propertyName": "IsActive",
                "fieldType": "bit",
                "field": "IsActive",
                "allowDbNull" : true
            },
            {
                "propertyName": "Description",
                "fieldType": "nvarchar",
                "field": "Description",
                "allowDbNull": true
            },
            {
                "propertyName": "Notes",
                "fieldType": "nvarchar",
                "field": "Notes",
                "allowDbNull" : true
            },
            {
                "propertyName": "Department",
                "fieldType": "nvarchar",
                "field": "Department",
                "allowDbNull" : true
            },
            {
                "propertyName": "PositionCategory",
                "fieldType": "smallint",
                "field": "PositionCategoryId",
                "allowDbNull": true
            },
            {
                "propertyName": "Company",
                "lazyLoader": "GetCompanyByCompanyPosition",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CompanyId",
                    "rightKey": "CompanyId",
                    "joinTable": "dbo.Companies"
                }
            },
            {
                "propertyName": "Person",
                "lazyLoader": "GetPersonByCompanyPosition",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CompanyPositionId",
                    "rightKey": "CompanyPositionId",
                    "joinTable": "dbo.CompanyPositions_People",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "PersonId",
                    "joinTableRightKey": "PersonId"
                }
            }
        ]
    }
]