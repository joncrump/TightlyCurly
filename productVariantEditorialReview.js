// Add mapping
[
    {
        "type":"TightlyCurly.Com.Common.Models.IProductVariantEditorialReview, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductVariantEditorialReviews",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantEditorialReviewId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "Order",
            "fieldType": "int",
            "field": "Order",
            "allowDbNull": true
        },
        {
            "propertyName": "ProductVariantReviewId",
            "fieldType": "guid",
            "field": "ProductVariantReviewId"
        },
        {
            "propertyName": "ReviewedById",
            "fieldType": "guid",
            "field": "ReviewedById"
        },
        {
            "propertyName": "ReviewDate",
            "fieldType": "smalldatetime",
            "field": "ReviewDate"
        },
        {
            "propertyName": "IsActive",
            "fieldType": "bool",
            "field": "IsActive",
            "allowDbNull": true
        },
        {
            "propertyName": "Review",
            "fieldType": "nvarchar",
            "field": "Review"
        },
        {
            "propertyName": "Rating",
            "fieldType": "decimal",
            "field": "Rating",
            "allowDbNull": true
        },
        {
            "propertyName": "Asides",
            "lazyLoader": "GetAsidesByProductVariantEditorialReview",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantEditorialReviewId",
                "joinTable": "dbo.ProductVariantEditorialReviews_Asides",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "AsideId",
                "joinTableRightKey": "AsideId"
            }
        }, ]
        /*

        IEnumerable<IImageUri> ImageUris { get; set; }
        IUser ReviewedBy { get; set; }
        IProductVariantReview ProductVariantReview { get; set; }
    }
        */
    }
]