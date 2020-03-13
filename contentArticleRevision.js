[
    {
        "type":"Norml.Common.Models.IContentArticleRevision, Norml.Common.Models",
        "dataSource": "dbo.ContentArticleRevisions",
        "countProperty":"Id",
        "propertyMappings": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "ContentArticleRevisionId",
                "isPrimaryKey": true
            },
            {
                "propertyName": "ContentArticleId",
                "fieldType": "guid",
                "field": "ContentArticleId"
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
                "propertyName": "VersionNumber",
                "fieldType": "nvarchar",
                "field": "VersionNumber"
            },
            {
                "propertyName": "IsCurrent",
                "fieldType": "bit",
                "field": "IsCurrent"
            },
            {
                "propertyName": "Notes",
                "fieldType": "nvarchar",
                "field": "Notes",
                "allowDbNull": true
            },
            {
                "propertyName": "ContentArticle",
                "lazyLoader": "GetContentArticleByContentArticleRevision",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "ContentArticleId",
                    "rightKey": "ContentArticleId"
                }   
            }
        ]
    }
]