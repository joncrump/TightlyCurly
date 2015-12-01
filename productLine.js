[
    {
        "type":"TightlyCurly.Com.Common.Models.ICompany, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Companies",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductLineId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "Name",
            "fieldType": "nvarchar",
            "field": "Name"
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
             "propertyName": "Companies",
             "lazyLoader": "GetCompaniesByProductLine",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "ProductLineId",
                 "joinTable": "dbo.ProductLines_Companies",
                 "joinTableJoinType": "left",
                 "joinTableLeftKey": "CompanyId",
                 "joinTableRightKey": "CompanyId"
             }
        },
        {
             "propertyName": "Copyrights",
             "lazyLoader": "GetCopyrightsByProductLine",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "ProductLineId",
                 "joinTable": "dbo.ProductLines_Copyrights",
                 "joinTableJoinType": "left",
                 "joinTableLeftKey": "CopyrightId",
                 "joinTableRightKey": "CopyrightId"
             }
        },
        {
            "propertyName": "Patents",
            "lazyLoader": "GetPatentsByProductLine",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductLineId",
                "joinTable": "dbo.ProductLines_Patents",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "PatentId",
                "joinTableRightKey": "PatentId"
            }
        },
        {
            "propertyName": "Products",
            "lazyLoader": "GetProductsByProductLine",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductLineId",
                "joinTable": "dbo.ProductMetadata",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "ProductId",
                "joinTableRightKey": "ProductId"
            }
        },
        {
            "propertyName": "Trademarks",
            "lazyLoader": "GetTrademarksByProductLine",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductLineId",
                "joinTable": "dbo.ProductLines_Trademarks",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "TrademarkId",
                "joinTableRightKey": "TrademarkId"
            }
        }]
    }
]