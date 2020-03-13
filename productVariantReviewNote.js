[
    {
        "type":"Norml.Common.Models.IProductVariantReviewNote, Norml.Common.Models",
        "dataSource": "dbo.ProductVariantReviewNotes",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantReviewId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "Note",
            "fieldType": "nvarchar",
            "field": "Note"
        },
        {
            "propertyName": "ProductVariantReviewId",
            "fieldType": "guid",
            "field": "ProductVariantReviewId"
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
            "fieldType": "smalldatetime",
            "field": "UpdatedDate"
        },
        {
            "propertyName": "ProductVariantReview",
            "lazyLoader": "GetProductVariantReviewByProductVariantReviewNote",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantReviewId",
                "rightKey": "Id",
            }
        },
        {
            "propertyName": "EnteredBy",
            "lazyLoader": "GetEnteredByProductVariantReviewNote",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "EnteredById",
                "rightKey": "Id",
            }
        }]
    }
]
