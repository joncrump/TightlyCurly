[
    {
        "type":"Norml.Common.Models.IContentItem, Norml.Common.Models",
        "dataSource": "dbo.ContentItems",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ContentItemId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "EnteredDate",
            "fieldType": "smalldatetime",
            "field": "EnteredDate"
        },
        {
            "propertyName": "MetaDescription",
            "fieldType": "nvarchar",
            "field": "MetaDescription",
            "allowDbNull": true
        },
        {
            "propertyName": "MetaKeywords",
            "fieldType": "nvarchar",
            "field": "MetaKeywords",
            "allowDbNull": true
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
            "propertyName": "IsActive",
            "fieldType": "bit",
            "field": "IsActive",
            "allowDbNull": true
        },
        {
            "propertyName": "Uri",
            "fieldType": "nvarchar",
            "field": "Uri"
        },
        {
            "propertyName": "Name",
            "fieldType": "nvarchar",
            "field": "Name"
        },
        {
            "propertyName": "Articles",
            "lazyLoader": "GetArticlesByContentItem",
            "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "Id",
                    "rightKey": "ContentItemId"
                }
        }]
    }
]