[
    {
        "type":"TightlyCurly.Com.Common.Models.IContentArticle, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ContentArticles",
        "countProperty":"Id",
        "propertyMappings:": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "ContentArticleDataId",
                "isPrimaryKey": true
            },
            {
                "propertyName": "IsActive",
                "fieldType": "bit",
                "field": "IsActive",
                "allowDbNull": true
            },
            {
                "propertyName": "ContentItemId",
                "fieldType": "guid",
                "field": "ContentItemId"
            },
            {
                "propertyName": "Title",
                "fieldType": "nvarchar",
                "field": "Title"
            },
            {
                "propertyName": "Data",
                "lazyLoader": "GetContentArticleDataByContentArticle",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "Id",
                    "rightKey": "ContentArticleId",
                }
            },
            {
                "propertyName": "Notes",
                "lazyLoader": "GetContentArticleNotesByContentArticle",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "Id",
                    "rightKey": "ContentArticleId"
                }
            },
            {
                "propertyName": "Revisions",
                "lazyLoader": "GetContentArticleRevisionsByContentArticle",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "Id",
                    "rightKey": "ContentArticleId"
                }
            }
        ]
    }
]