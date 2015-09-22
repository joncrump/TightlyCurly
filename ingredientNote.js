[
    {
        "type":"TightlyCurly.Com.Common.Models.IIngredientNote, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.IngredientNotes",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "IngredientNoteId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "IngredientId",
            "fieldType": "guid",
            "field": "IngredientId"
        },
        {
            "propertyName": "Note",
            "fieldType": "nvarchar",
            "field": "Note"
        },
        {
            "propertyName": "EnteredByUserId",
            "fieldType": "guid",
            "field": "UserId"
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
            "propertyName": "EnteredBy",
            "lazyLoader": "GetEnteredByByIngredientNote",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "EnteredByUserId",
                "rightKey": "UserId"
            }
        }]
    }
]