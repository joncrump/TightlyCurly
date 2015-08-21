// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IMenu, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Menus",
        "countProperty":"Id",
        "propertyMappings:": [
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
        }]
        /*
                IEnumerable<IContentItem> ContentItems { get; set; }
        IEnumerable<IMenuItem> MenuItems { get; set; }
        IEnumerable<IMenuText> MenuTexts { get; set; } 
        */
    }
]