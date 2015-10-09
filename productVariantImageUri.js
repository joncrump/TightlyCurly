// TODO: Add mappings
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
        ]
        /*
 * 	
[IsPrimary] BIT NULL,
[Order] INT NULL,
[IsActive] BIT NULL,
 */
    }
]