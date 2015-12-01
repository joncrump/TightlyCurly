// Add mapping
[
    {
        "type":"TightlyCurly.Com.Common.Models.IProductVariantUserReview, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductVariantUserReviews",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantUserReviewId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "Order",
            "fieldType": "int",
            "field": "Order",
            "allowDbNull": true
        },
        {
            "propertyName": "ReviewedById",
            "fieldType": "guid",
            "field": "ReviewedById"
        },
        {
            "propertyName": "ProductVariantReviewId",
            "fieldType": "guid",
            "field": "ProductVariantReviewId"
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
            "propertyName": "LocaleId",
            "fieldType": "guid",
            "field": "LocaleId",
            "allowDbNull": true
        },
        {
            "propertyName": "EnteredDate",
            "fieldType": "smalldatime",
            "field": "EnteredDate"
        },
        {
            "propertyName": "UpdatedDate",
            "fieldType": "smalldatetime",
            "field": "UpdatedDate"
        }]

        /*
        IEnumerable<IAside> Asides { get; set; }
        IEnumerable<IProductVariantImageUri> ImageUris { get; set; }
        IUser ReviewedBy { get; set; }
        IProductVariantReview ProductVariantReview { get; set; }
        ILocale Locale { get; set; }
        */
    }
]