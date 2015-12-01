[
    {
        "type":"TightlyCurly.Com.Common.Models.IIngredient, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Ingredients",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "IngredientId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "EnteredDate",
            "fieldType": "smalldatetime",
            "field": "EnteredDate"
        },
        {
            "propertyName": "UpdatedDate",
            "fieldType": "smalldatime",
            "field": "UpdatedDate"
        },
        {
            "propertyName": "Title",
            "fieldType": "nvarchar",
            "field": "Title"
        },
        {
            "propertyName": "Description",
            "fieldType": "nvarchar",
            "field": "Description",
            "allowDbNull": true
        },
        {
            "propertyName": "IngredientCategories",
            "lazyLoader": "GetIngredientCategoriesByIngredient",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "IngredientId",
                "joinTable": "dbo.Ingredients_IngredientCategories",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "IngredientCategoryId",
                "joinTableRightKey": "IngredientCategoryId"
            }
        },
        {
            "propertyName": "Aliases",
            "lazyLoader": "GetAliasesByIngredient",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "IngredientId",
            }
        },
        {
            "propertyName": "Links",
            "lazyLoader": "GetLinksByIngredient",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "IngredientId"
            }
        },
        {
            "propertyName": "IngredientRatings",
            "lazyLoader": "GetIngredientRatingsByIngredient",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "IngredientId"
            }
        },
        {
            "propertyName": "Notes",
            "lazyLoader": "GetIngredientNotesByIngredient",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "IngredientId"
            }
        },
        {
            "propertyName": "Comments",
            "lazyLoader": "GetCommentsByIngredient",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "IngredientId"
            }
        },
        {
             "propertyName": "ContactArticles",
             "lazyLoader": "GetContentArticlesByIngredient",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "IngredientId",
                 "joinTable": "dbo.Ingredients_ContentArticles",
                 "jonTableJoinType": "left",
                 "joinTableLeftKey": "ContentArticleId",
                 "joinTableRightKey": "ContentArticleId"
             }
        }]
    }
]