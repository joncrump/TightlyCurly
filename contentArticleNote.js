[
    {
        "type":"Norml.Common.Models.IContentArticleNote, Norml.Common.Models",
        "dataSource": "dbo.ContentArticleNotes",
        "countProperty":"Id",
        "propertyMappings": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "ContentArticleNoteId",
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
                "propertyName": "Note",
                "fieldType": "nvarchar",
                "field": "Note"
            },
            {
                "propertyName": "ContentArticleId",
                "fieldType": "guid",
                "field": "ContentArticleId"
            },
            {
                "propertyName": "EnteredByUserId",
                "fieldType": "guid",
                "field": "EnteredByUserId"
            },
            {
                "propertyName": "EnteredBy",
                "lazyLoader": "GetEnteredByContentArticleNote",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "EnteredByUserId",
                    "rightKey": "UserId"
                }
            }
        ]                            
    }
]