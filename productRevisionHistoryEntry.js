// JavaScript source code
[
    {
        "type":"Norml.Common.Models.IProductRevisionHistoryEntry, Norml.Common.Models",
        "dataSource": "dbo.ProductRevisionHistoryEntries",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductRevisionHistoryId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ProductVariantId",
            "fieldType": "guid",
            "field": "ProductVariantId"
        },
        {
            "propertyName": "OldIngredients",
            "fieldType": "xml",
            "field": "OldIngredients"
        },
        {
            "propertyName": "NewIngredients",
            "fieldType": "xml",
            "field": "NewIngredients"
        },
        {
            "propertyName": "Comments",
            "fieldType": "nvarchar",
            "field": "Comments",
            "allowDbNull": true
        },
        {
            "propertyName": "Notes",
            "fieldType": "nvarchar",
            "field": "Notes",
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
            "lazyLoader": "GetProductVariantByProductRevisionHistoryEntry",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantId",
                "rightKey": "Id"
            }
        }]
    }
]