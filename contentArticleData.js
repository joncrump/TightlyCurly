[
    {
        "type":"Norml.Common.Models.IContentArticleData, Norml.Common.Models",
        "dataSource": "dbo.ContentArticleData",
        "countProperty":"Id",
        "propertyMappings": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "ContentArticleDataId",
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
                "propertyName": "Description",
                "fieldType": "nvarchar",
                "field": "Description",
                "allowDbNull": true
            },
            {
                "propertyName": "Text",
                "fieldType": "nvarchar",
                "field": "Text"
            },
            {
                "propertyName": "LocaleId",
                "fieldType": "guid",
                "field": "LocaleId"
            },
            {
                "propertyName": "Locale",
                "lazyLoader": "GetLocaleByContentArticleData",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "LocaleId",
                    "rightKey": "LocaleId",
                    "joinTable": "dbo.Locales"
                }
            }
        ]
    }
]