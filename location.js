[
    {
        "type":"Norml.Common.Models.ILocation, Norml.Common.Models",
        "dataSource": "dbo.Locations",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "LocationId",
            "isPrimaryKey": true
        },
        {
            "prpertyName": "Name",
            "fieldTpe": "nvarchar",
            "field": "Name"
        },
        {
            "propertyName": "AddressId",
            "fieldType": "guid",
            "field": "AddressId"
        },
        {
            "propertyName": "CoordinatesId",
            "fieldType": "guid",
            "field": "CoordinatesId"
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
            "propertyName": "Address",
            "lazyLoader": "GetAddressByLocation",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "AddressId",
                "rightKey": "Id"
            }
        },
        {
            "propertyName": "Coordinates",
            "lazyLoader": "GetCoordinatesByLocation",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "CoordinatesId",
                "rightKey": "Id"
            }
        }]
    }
]