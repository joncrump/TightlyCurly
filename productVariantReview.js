[
    {
        "type":"TightlyCurly.Com.Common.Models.IProductVariantReview, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductVariantReviews",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantReviewId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ProductVariantId",
            "fieldType": "guid",
            "field": "ProductVariantId"
        },
        {
            "propertyName": "OverallRating",
            "fieldType": "decimal",
            "field": "OverallRating"
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
            "propertyName": "ProductVariantId",
            "lazyLoader": "GetProductVariantByProductVariantReview",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantId",
                "rightKey": "ProductVariantId",
            }
        },
        {
            "propertyName": "EditorialReviews",
            "lazyLoader": "GetEditorialReviewsByProductVariantReview",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantId",
                "rightKey": "ProductVariantId",
            }
        },
        {
            "propertyName": "UserReviews",
            "lazyLoader": "GetUserReviewsByProductVariantReview",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductVariantId",
                "rightKey": "ProductVariantId",
            }
        },
        {
            "propertyName": "Comments",
            "lazyLoader": "GetCommentsByProductVariantReview",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantReviewId"
            }
        },
        {
            "propertyName": "Notes",
            "lazyLoader": "GetNotesByProductVariantReview",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantReviewId"
            }
        }]
    }
]