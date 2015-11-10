// TODO: Add mappings
[
    {
        "type": "TightlyCurly.Com.Common.Models.IProductSafetyInfo, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductSafetyInfos",
        "countProperty": "Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductSafetyInfoId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ProductSafetyInfoType",
            "fieldType": "nvarchar",
            "field": "ProductSafetyInfoType",
            "allowDbNull": true
        },
        {
            "propertyName": "Text",
            "fieldType": "nvarchar",
            "field": "Text"
        },
        {
            "propertyName": "Order",
            "fieldType": "int",
            "field": "Order",
            "allowDbNull": true
        },
        {
            "propertyName": "Source",
            "fieldType": "nvarchar",
            "field": "Source",
            "allowDbNull": true
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
            "propertyName": "LocaleId",
            "fieldType": "guid",
            "field": "LocaleId"
        },
        {
            "propertyName": "Notes",
            "fieldType": "nvarchar",
            "field": "Notes",
            "allowDbNull": true
        },
        {
            "propertyName": "IsActive",
            "fieldType": "bool",
            "field": "IsActive",
            "allowDbNull": true
        },
        {
            "propertyName": "EffectiveDate",
            "fieldType": "smalldatetime",
            "field": "EffectiveDate",
            "allowDbNull": true
        },
        {
            "propertyName": "StopDate",
            "fieldType": "smalldatetime",
            "field": "StopDate",
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
             "propertyName": "ProductVariant",
             "lazyLoader": "GetProductVariantByProductSafetyInfo",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "ProductSafetyInfoId",
                 "joinTable": "dbo.ProductSafetyInfos_ProductVariants",
                 "joinTableJoinType": "left",
                 "joinTableLeftKey": "ProductVariantId",
                 "joinTableRightKey": "ProductVariantId"
             }
        },
        {
             "propertyName": "EnteredBy",
             "lazyLoader": "GetEnteredByByProductSafetyInfo",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "EnteredById",
                 "rightKey": "Id",
             }
        },
        {
            "propertyName": "Locale",
            "lazyLoader": "GetLocaleByProductSafetyInfo",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "LocaleId",
                "rightKey": "Id",
            }
        }]
    }
]