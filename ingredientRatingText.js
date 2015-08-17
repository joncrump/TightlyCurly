// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IIngredientRatingText, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.IngredientRatingTexts",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "IngredientRatingTextId",
            "isPrimaryKey": true
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
            "propertyName": "IngredientRatingId",
            "fieldType": "guid",
            "field": "IngredientRatingId"
        },
        {
            "propertyName": "LocaleId",
            "fieldType": "guid",
            "field": "LocaleId",
            "allowDbNull": true
        },
        {
            "propertyName": "Loocale",
            "lazyLoader": "GetLocaleByIngredientRatingText",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "LocaleId",
                "rightKey": "LocaleId"
            }
        }]
    }
]