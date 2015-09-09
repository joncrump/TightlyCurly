// patent mappings
[
    {
        "type": "TightlyCurly.Com.Common.Models.IPatent, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Patents",
        "countProperty": "Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "PatentId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "PatentNumber",
            "fieldType": "nvarchar",
            "field": "PatentNumber"
        },
        {
            "propertyName": "RegisteredDate",
            "fieldType": "smalldatetime",
            "field": "RegisteredDate",
            "allowDbNull": true
        },
        {
            "propertyName": "ExpirationDate",
            "fieldType": "smalldatetime",
            "field": "ExpirationDate",
            "allowDbNull": true
        },
        {
            "propertyName": "IsActive",
            "fieldType": "bit",
            "field": "IsActive",
            "allowDbNull": true
        },
        {
            "propertyName": "IsPending",
            "fieldType": "bit",
            "field": "IsActive",
            "allowDbNull": true
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
            "propertyName": "Authors",
            "lazyLoader": "GetAuthorsByPatent",
            "joinMapping":
              {
                  "joinType": "left",
                  "leftKey": "Id",
                  "rightKey": "PatentId",
                  "joinTable": "dbo.PatentAuthors_Patents",
                  "joinTableJoinType": "left",
                  "joinTableLeftKey": "PatentAuthorId",
                  "joinTableRightKey": "PatentAuthorId"
              }
        },
        {
            "propertyName": "Owners",
            "lazyLoader": "GetOwnersByPatent",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "PatentId",
                "joinTable": "dbo.Patents_Companies",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "CompanyId",
                "joinTableRightKey": "CompanyId"
            }
        },
        {
            "propertyName": "Countries",
            "lazyLoader": "GetCountriesByPatent",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "PatentId",
                "joinTable": "dbo.Patents_Countries",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "CountryId",
                "joinTableRightKey": "CountryId"
            }
        }]
    }
]