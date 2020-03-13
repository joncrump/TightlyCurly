[
    {
        "type":"Norml.Common.Models.IMenuText, Norml.Common.Models",
        "dataSource": "dbo.MenuTexts",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "MenuTextId",
            "allowDbNull": false,
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
            "propertyName": "MenuId",
            "fieldType": "guid",
            "field": "MenuId"
        },
        {
            "propertyName": "LocaleId",
            "fieldType": "guid",
            "field": "LocaleId"
        },
        {
            "propertyName": "Text",
            "fieldType": "nvarchar",
            "field": "Text"
        },
        {
            "propertyName": "Menu",
            "lazyLoader": "GetMenuByMenuText",
            "leftKey": "MenuId",
            "rightKey": "Id",
            "joinType": "left"
        },
        {
            "propertyName": "Locale",
            "lazyLoader": "GetLocaleByMenuText",
            "leftKey": "LocaleId",
            "rightKey": "Id",
            "joinType": "left"
        }]
    }
]