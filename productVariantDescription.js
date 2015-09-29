[
    {
        "type":"TightlyCurly.Com.Common.Models.IProductVariantDescription, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductVariantDescriptions",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantDescriptionId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ProductVariantId",
            "fieldType": "guid",
            "field": "ProductVariantId",
        },
        {
            "propertyName": "EnteredById",
            "fieldType": "guid",
            "field": "EnteredById"
        },
        {
            "propertyName": "LocaleId",
            "fieldType": "guid",
            "field": "LocaleId"
        },
        {
            "propertyName": "Description",
            "fieldType": "nvarchar",
            "field": "Description"
        },
        {
            "propertyName": "EnteredBy",
            "lazyLoader": "GetEnteredByProductVariantDescription",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "EnteredById",
                "rightKey": "UserId",
            }
        },
        {
            "propertyName": "ProductVariant",
            "lazyLoader": "GetProductVariantByProductVariantDescription",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantId",
                "rightKey": "ProductVariantId",
            }
        },
        {
            "propertyName": "Locale",
            "lazyLoader": "GetLocaleByProductVariantDescription",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "LocaleId",
                "rightKey": "LocaleId",
            }
        }]
    }
]