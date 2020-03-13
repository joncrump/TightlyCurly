[
    {
        "type":"Norml.Common.Models.IManufacturer, Norml.Common.Models",
        "dataSource": "dbo.Manufacturers",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ManufacturerId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "Name",
            "fieldType": "nvarchar",
            "field": "Name"
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
            "propertyName": "Companies",
            "lazyLoader": "GetCompaniesByManufacturer",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ManufacturerId",
                "joinTable": "dbo.Manufacturers_Companies",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "CompanyId",
                "joinTableRightKey": "CompanyId"
            }
        },
        {
            "propertyName": "Locations",
            "lazyLoader": "GetLocationsByManufacturer",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ManufacturerId",
                "joinTable": "dbo.Manufacturers_Locations",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "LocationId",
                "joinTableRightKey": "LocationId"
            }
        }]
    }
]