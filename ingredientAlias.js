// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IIngredientAlias, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.IngredientAliases",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "IngredientAliasId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "IngredientId",
            "fieldType": "guid",
            "field": "IngredientId"
        },
        {
            "propertyName": "Alias",
            "fieldType": "nvarchar",
            "field": "Alias"
        },
        {
            "propertyName": "LocaleId",
            "fieldType": "guid",
            "field": "LocaleId"
        },
        {
            "propertyName": "Locale",
            "lazyLoader": "GetLocaleByIngredient",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "LocaleId",
                "rightKey": "LocaleId"
            }
        }]
    }
]