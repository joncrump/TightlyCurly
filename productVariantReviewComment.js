[
    {
        "type":"TightlyCurly.Com.Common.Models.IProductVariantReviewComment, TightlyCurly.Com.Common.Models",
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
            "propertyName": "Comment",
            "fieldType": "nvarchar",
            "field": "Comment"
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
            "fieldType" : "smalldatetime",
            "field": "EnteredDate"
        },
        {
            "propertyName": "UpdatedDate",
            "fieldType": "smalldatetime",
            "field": "UpdatedDate"
        },
        {
            "propertyName": "ProductVariantReview",
            "lazyLoader": "GetProductVariantReviewByProductVariantReviewComment",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantReviewId",
                "rightKey": "Id",
            }
        },
        {
            "propertyName": "EnteredBy",
            "lazyLoader": "GetEnteredByProductVariantReviewComment",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "EnteredById",
                "rightKey": "Id",
            }
        }]
    }
]