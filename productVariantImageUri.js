[
    {
        "type":"TightlyCurly.Com.Common.Models.IProductVariantImageUri, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductVariantImageUris",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantImageId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ProductVariantId",
            "fieldType": "guid",
            "field": "ProductVariantId"
        },
        {
            "propertyName": "Uri",
            "fieldType": "nvarchar",
            "field": "Uri"
        },
        {
            "propertyName": "Description",
            "fieldType": "nvarchar",
            "field": "Description",
            "allowDbNull": true
        },
        {
            "propertyName": "AltText",
            "fieldType": "nvarchar",
            "field": "AltText",
            "allowDbNull": true
        },
        {
            "propertyName": "IsPrimary",
            "fieldType": "bit",
            "field": "IsPrimary",
            "allowDbNull": true
        },
        {
            "propertyName": "Order",
            "fieldType": "int",
            "field": "Order",
            "allowDbNull": true
        },
        {
            "propertyName": "IsActive",
            "fieldType": "bool",
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
            "propertyName": "ProductVariant",
            "lazyLoader": "GetProductVariantByProductVariantImageUri",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantId",
                "rightKey": "ProductVariantId",
            }
        }]
    }
]