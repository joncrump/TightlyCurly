[
    {
        "type":"TightlyCurly.Com.Common.Models.IMenuItemText, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.MenuItemTexts",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "MenuItemTextId",
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
            "propertyName": "Description",
            "fieldType": "nvarchar",
            "field": "Description",
            "allowDbNull": true
        },
        {
            "propertyName": "Locale",
            "lazyLoader": "GetLocaleByMenuItemText",
            "leftKey": "LocaleId",
            "rightKey": "LocaleId",
            "joinType": "left"
        }]
    }
]