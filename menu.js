[
    {
        "type":"TightlyCurly.Com.Common.Models.IMenu, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Menus",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "MenuId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "Name",
            "fieldType": "nvarchar",
            "field": "Name"
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
             "propertyName": "ContentItems",
             "lazyLoader": "GetContentItemsByMenu",
             "joinMapping":
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "MenuId",
                 "joinTable": "dbo.Menus_ContentItems",
                 "jonTableJoinType": "left",
                 "joinTableLeftKey": "ContentItemId",
                 "joinTableRightKey": "ContentItemId"
             }
        },
        {
            "propertyName": "MenuItems",
            "lazyLoader": "GetMenuItemsByMenu",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "MenuId",
                "joinTable": "dbo.Menus_ContentItems",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "ContentItemId",
                "joinTableRightKey": "ContentItemId"
            }
        },
        {
            "propertyName": "MenuTexts",
            "lazyLoader": "GetMenuTextsByMenu",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "MenuId"
            }
        }]
    }
]