[
    {
        "type":"TightlyCurly.Com.Common.Models.IProductVariantNote, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductVariantNotes",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantNoteId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ProductVariantId",
            "fieldType": "guid",
            "field": "ProductVariantId"
        },
        {
            "propertyName": "EnteredById",
            "fieldType": "guid",
            "field": "EnteredBy"
        },
        {
            "propertyName": "Text",
            "fieldType": "nvarchar",
            "field": "Text"
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
            "lazyLoader": "GetProductVariantByProductVariantNote",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantId",
                "rightKey": "Id",
            }
        },
        {
            "propertyName": "EnteredBy",
            "lazyLoader": "GetEnteredByByProductVariantMetadata",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "EnteredById",
                "rightKey": "Id",
            }
        }]
    }
]