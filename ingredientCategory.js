// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IIngredientCategory, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.IngredientCategories",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "IngredientCategoryId",
            "isPrimaryKey": true
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
            "propertyName": "Name",
            "fieldType": "nvarchar",
            "field": "Name"
        },
        {
            "propertyName": "CategoryTypes",
            "lazyLoader": "GetCategoryTypesByIngredientCategory",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "IngredientCategoryId",
                "joinTable": "dbo.IngredientCategories_CategoryTypes",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "CategoryTypeId",
                "joinTableRightKey": "CategoryTypeId"
            }
        }]
    }
]