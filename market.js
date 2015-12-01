[
    {
        "type":"TightlyCurly.Com.Common.Models.IMarket, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Markets",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "MarketId",
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
            "propertyName": "Name",
            "fieldType": "nvarchar",
            "field": "Name"
        },
        {
            "propertyName": "Countries",
            "lazyLoader": "GetCountriesByMarket",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "MarketId",
                "joinTable": "dbo.Markets_Companies",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "CompanyId",
                "joinTableRightKey": "CompanyId"
            }
        },
         {
             "propertyName": "Verticies",
             "lazyLoader": "GetVerticiesByMarket",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "MarketId",
                 "joinTable": "dbo.Markets_Coordinates",
                 "jonTableJoinType": "left",
                 "joinTableLeftKey": "CoordinateId",
                 "joinTableRightKey": "CoordinateId"
             }
         }]
    }
]