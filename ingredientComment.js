[
    {
        "type":"Norml.Common.Models.IIngredientComment, Norml.Common.Models",
        "dataSource": "dbo.IngredientComments",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "IngredientCommentId",
            "isPrimaryKey": true
        },
        {
            "propertyName":"EnteredDate",
            "fieldType": "smalldatetime",
            "field": "EnteredDate"
        },
        {
            "propertyName": "UpdatedDate",
            "fieldType": "smalldatetime",
            "field": "UpdatedDate"
        },
        {
            "propertyName": "Comment",
            "fieldType": "nvarchar",
            "field": "Comment"
        },
        {
            "propertyName" : "IngredientId",
            "fieldType": "guid",
            "field": "IngredientId"
        },
        {
            "propertyName": "LocaleId",
            "fieldType": "guid",
            "field": "LocaleId",
            "allowDbNull": true
        },
        {
            "propertyName": "ParentId",
            "fieldType": "guid",
            "field": "ParentId",
            "allowDbNull": true
        },
        {
            "propertyName": "UserId",
            "fieldType": "guid",
            "field": "UserId"
        },
        {
            "propertyName": "Locale",
            "lazyLoader": "GetLocaleByIngredientComment",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "LocaleId",
                "rightKey": "LocaleId"
            }
        },
        {
            "propertyName": "User",
            "lazyLoader": "GetUserByIngredientComment",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "UserId",
                "rightKey": "UserId"
            }
        },
        {
            "propertyName": "Parent",
            "lazyLoader": "GetParentByIngredientComment",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ParentId"
            }
        },
        {
            "propertyName": "Children",
            "lazyLoader": "GetChildrenByIngredientComment",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ParentId",
                "rightKey": "Id"
            }
        }]
    }
]