// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IIngredient, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Ingredients",
        "countProperty":"Id",
        "propertyMappings:": [
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
        }]

        /*
        IEnumerable<IIngredientAlias> Aliases { get; set; }
        IEnumerable<IIngredientUri> Links { get; set; }
        IEnumerable<IIngredientRating> IngredientRatings { get; set; }
        IEnumerable<IIngredientNote> Notes { get; set; }
        IEnumerable<IIngredientComment> Comments { get; set; }
        IEnumerable<IContentArticle> ContentArticles { get; set; }
        */
    }
]