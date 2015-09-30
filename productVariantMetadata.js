[
    {
        "type":"TightlyCurly.Com.Common.Models.IProductVariantMetadata, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductVariantMetadata",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantMetadataId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "Key",
            "fieldType": "nvarchar",
            "field": "Key"
        },
        {
            "propertyName": "Value",
            "fieldType": "nvarchar",
            "field": "Value"
        },
        {
            "propertyName": "ProductVariantId",
            "fieldType": "guid",
            "field": "ProductVariantId"
        },
        {
            "propertyName": "EnteredById",
            "fieldType": "guid",
            "field": "EnteredById"
        },
        {
            "propertyName": "EnteredDate",
            "fieldType": "smalldatetime",
            "field": "EnteredDate"
        },
        {
            "propertyName": "UpdatedDate",
            "fieldType": "guid",
            "field": "UpdatedDate"
        },
        {
             "propertyName": "EnteredBy",
             "lazyLoader": "GetEnteredByProductVariantMetadata",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "UserId",
                 "rightKey": "UserId",
             }
        },
        {
            "propertyName": "ProductVariant",
            "lazyLoader": "GetProductVariantByProductVariantMetadata",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantId",
                "rightKey": "Id",
            }
        }]
    }
]
