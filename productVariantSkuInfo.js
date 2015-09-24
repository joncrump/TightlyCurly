// TODO: Add mappings
[
    {
        "type":"TightlyCurly.Com.Common.Models.ITProductVariantSkuInfo, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductVariantSkus",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantSkuId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ProductVariantId",
            "fieldType": "guid",
            "field": "ProductVariantId"
        },
        {
            "propertyName": "Sku",
            "fieldType": "nvarchar",
            "field": "Sku"
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
             "propertyName": "ProductVariant",
             "lazyLoader": "GetProductVariantByProductVariantSku",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "ProductVariantId",
             }
         }]
    }
]