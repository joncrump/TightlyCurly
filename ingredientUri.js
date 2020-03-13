[
    {
        "type":"Norml.Common.Models.IIngredientUri, Norml.Common.Models",
        "dataSource": "dbo.IngredientUris",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "IngredientUriId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "IngredientId",
            "fieldType": "guid",
            "field": "IngredientId"
        },
        {
            "propertyName": "Uri",
            "fieldType": "nvarchar",
            "field": "Uri"
        },
        {
            "propertyName": "Comment",
            "fieldType": "nvarchar",
            "field": "Comment",
            "allowDbNull": true
        },
        {
            "propertyName": "Description",
            "fieldType": "nvarchar",
            "field": "Description",
            "allowDbNull": true
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
    }
]