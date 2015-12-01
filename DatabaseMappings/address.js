[
    {
        "type":"TightlyCurly.Com.Common.Models.IAddress, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Addresses",
        "countProperty":"Id",
        "propertyMappings": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "AddressId",
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
                "propertyName": "Line1",
                "fieldType": "nvarchar",
                "field": "Line1"
            },
            {
                "propertyName": "Line2",
                "fieldType": "nvarchar",
                "parameterName": "line2",
                "allowDbNull": true
            },
            {
                "propertyName": "City",
                "fieldType": "nvarchar",
                "parameterName": "city",
                "allowDbNull": true
            },
            {
                "propertyName": "StateProvinceId",
                "fieldType": "guid",
                "parameterName": "stateProvinceId",
                "allowDbNull" : true
            },
            {
                "propertyName": "PostalCode",
                "fieldType": "nvarchar",
                "parameterName": "postalCode",
                "allowDbNull": true
            },
            {
                "propertyName": "CountryId",
                "fieldType": "nvarchar",
                "parameterName": "postalCode",
                "allowDbNull": true
            },
            {
                "propertyName": "Country",
                "lazyLoader": "GetCountryByAddress",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CountryId",
                    "rightKey" : "CountryId"
                }
            },
            {
                "propertyName": "StateProvince",
                "lazyLoader": "GetStateProvinceByAddress",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "StateProvinceId",
                    "rightKey": "StateProvinceId"
                }
            }]
    }
]