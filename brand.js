[
    {
        "type": "Norml.Common.Models.IBrand, Norml.Common.Models",
        "dataSource": "dbo.Brands",
        "countProperty": "BrandId",
        "propertyMappings": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "BrandId",
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
                "field" : "UpdatedDate"
            },
            {
                "propertyName": "BrandName",
                "fieldType": "nvarchar",
                "field": "BrandName"
            },
            {
                "propertyName": "ManufacturerId",
                "fieldType": "guid",
                "field": "ManufacturerId",
                "allowDbNull": true
            },
            {
                "propertyName": "Manufacturer",
                "lazyLoader": "GetManufacturerByBrand",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "ManufacturerId",
                    "rightKey": "ManufacturerId"
                }
            },
            {
                "propertyName": "Copyrights",
                "lazyLoader": "GetCopyrightsByBrand",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "BrandId",
                    "rightKey": "CopyrightId",
                    "joinTable": "dbo.Brands_Copyrights",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "BrandId",
                    "joinTableRightKey": "CopyrightId"
                }
            },
            {
                "propertyName": "Trademarks",
                "lazyLoader": "GetTrademarksByBrand",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "BrandId",
                    "rightKey": "TrademarkId",
                    "joinTable": "dbo.Brands_Trademarks",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "BrandId",
                    "joinTableRightKey": "TrademarkId"
                }
            }
        ]
    }
]