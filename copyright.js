[
    {
        "type":"Norml.Common.Models.ICopyright, Norml.Common.Models",
        "dataSource": "dbo.Copyrights",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "CopyrightId",
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
            "propertyName": "Copyright",
            "fieldType": "nvarchar",
            "field": "Copyright"
        },
        {
            "propertyName": "IsActive",
            "fieldType": "bit",
            "field": "IsActive",
            "allowDbNull": true
        },
        {
            "propertyName": "RegisteredDate",
            "fieldType": "smalldatetime",
            "field": "RegisteredDate",
            "allowDbNull": true
        },
        {
            "propertyName": "ExpirationDate",
            "fieldType": "smalldatetime",
            "field": "ExpirationDate",
            "allowDbNull": true
        },
        {
            "propertyName": "Owners",
            "lazyLoader": "GetOwnersByCopyright",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "CopyrightId",
                "joinTable": "dbo.Copyrights_Owners",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "CompanyId",
                "joinTableRightKey": "CompanyId"
            }
        },
        {
            "propertyName": "Countries",
            "lazyLoader": "GetCountriesByCopyright",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "CopyrightId",
                "joinTable": "dbo.Copyrights_Countries",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "CountryId",
                "joinTableRightKey": "CountryId"
            }
        }]
    }
]