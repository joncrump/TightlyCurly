[
    {
        "type":"TightlyCurly.Com.Common.Models.ITrademark, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Trademarks",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "TrademarkId",
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
            "propertyName": "Trademark",
            "fieldType": "nvarchar",
            "field": "Trademark"
        },
        {
            "propertyName": "IsActive",
            "fieldType": "bit",
            "field": "IsActive",
            "allowDbNull": true
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
             "propertyName": "Companies",
             "lazyLoader": "GetCompaniesByTrademark",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "TrademarkId",
                 "joinTable": "dbo.Trademarks_Companies",
                 "joinTableJoinType": "left",
                 "joinTableLeftKey": "CompanyId",
                 "joinTableRightKey": "CompanyId"
             }
        },
        {
             "propertyName": "Countries",
             "lazyLoader": "GetCountriesByTrademark",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "TrademarkId",
                 "joinTable": "dbo.Trademarks_Countries",
                 "joinTableJoinType": "left",
                 "joinTableLeftKey": "CountryId",
                 "joinTableRightKey": "CountryId"
             }
         }]
    }
]