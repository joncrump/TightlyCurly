[
    {
        "type": "Norml.Common.Models.IAside, Norml.Common.Models",
        "dataSource": "dbo.Asides",
        "countProperty": "Id",
        "propertyMappings": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "AsideId",
                "isPrimaryKey": true
            },
            {
                "propertyName": "EnteredDate",
                "fieldType": "smalldatetime",
                "field": "EnteredDate",
            },
            {
                "propertyName": "UpdatedDate",
                "fieldType": "smalldatetime",
                "field": "UpdatedDate"
            },
            {
                "propertyName": "Order",
                "fieldType": "int",
                "field": "Order",
                "allowDbNull": true
            },
            {
                "propertyName": "Text",
                "fieldType": "nvarchar",
                "field": "Text"
            },
            {
                "propertyName": "IsActive",
                "fieldType": "bit",
                "field": "IsActive",
                "allowDbNull": true
            }
        ]
    }
]