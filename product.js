// JavaScript source code
[
    {
        "type": "TightlyCurly.Com.Common.Models.IProduct, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Products",
        "countProperty": "Id",
        "propertyMappings:": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "ProductId",
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
                "propertyName": "ProductMetadata",
                "lazyLoader": "GetProductMetaByProduct",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "Id",
                    "rightKey": "ProductId",
                }
            },
            {
                "propertyName": "Variants",
                "lazyLoader": "GetVariantsByProduct",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "Id",
                    "rightKey": "ProductId",
                }
            }
        ]
    }
]