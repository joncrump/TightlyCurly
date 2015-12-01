[
    {
        "type":"TightlyCurly.Com.Common.Models.IIngredientRating, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.IngredientRatings",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "RatingTypeId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "IngredientId",
            "fieldType": "guid",
            "field": "IngredientId"
        },
        {
            "propertyName": "RatingTypeId",
            "fieldType": "guid",
            "field": "RatingTypeId"
        },
        {
            "propertyName": "RatingType",
            "lazyLoader": "GetRatingTypeByIngredientRatingId",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "RatingTypeId",
                "rightKey": "Id"
            }
        },
        {
            "propertyName": "Texts",
            "lazyLoader": "GetTextsByIngredientRatings",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "IngredientRatingId",
                "rightKey": "IngredientRatingId",
                "joinTable": "dbo.IngredientRatings_IngredientRatingTexts",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "IngredientRatingId",
                "joinTableRightKey": "IngredientRatingId"
            }
        }]
    }
]