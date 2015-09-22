[
    {
        "type":"TightlyCurly.Com.Common.Models.IMenuItem, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.MenuItems",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "MenuItemId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ParentId",
            "fieldType": "guid",
            "field": "ParentId",
            "allowDbNull": true
        },
        {
            "propertyName": "Order",
            "fieldType": "int",
            "field": "Order",
            "allowDbNull": true
        },
        {
            "propertyName": "Uri",
            "fieldType": "nvarchar",
            "field": "Uri"
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
            "propertyName": "Parent",
            "lazyLoader": "GetParentByMenuItem",
            "joinType": "left",
            "leftKey": "ParentId",
            "rightKey": "Id"
        },
        {
            "propertyName": "Children",
            "lazyLoader": "GetChildrenByMenuItem",
            "joinType": "left",
            "leftKey": "Id",
            "rightKey": "ParentId"
        },
        {
            "propertyName": "MenuItemTexts",
            "lazyLoader": "GetMenuItemTextsByMenuItem",
            "joinType": "left",
            "leftKey": "Id",
            "rightKey": "MenuItemId"
        },
        {
            "propertyName": "Menus",
            "lazyLoader": "GetMenusByMenuItems",
            "joinType": "left",
            "leftKey": "Id",
            "rightKey": "MenuItemId",
            "joinTable": "dbo.Menus_MenuItems",
            "joinTableLeftKey": "MenuId",
            "joinTableRightKey": "MenuId",
            "joinTableJoinType": "left"
        }]
    }
]