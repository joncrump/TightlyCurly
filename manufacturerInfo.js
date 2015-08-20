// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IManufacturerInfo, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ManufacturerInfos",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ManufacturerInfoId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ManufacturerId",
            "fieldType": "guid",
            "field": "ManufacturerId"
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
            "propertyName": "Manufacturer",
            "lazyLoader": "GetManufacturerByManufacturerInfo",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ManufacturerId",
                "rightKey": "ManufacturerId"
            }
        },
        {
            "propertyName": "ManufacturedBy",
            "lazyLoader": "GetManufacturedByManufacturerInfo",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ManufacturerInfoId",
                "joinTable": "dbo.ManufacturerInfos_Companies",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "CompanyId",
                "joinTableRightKey": "CompanyId"
            }
        },
        {
            "propertyName": "ManufacturedAt",
            "lazyLoader": "GetManufacturedByManufacturerInfo",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ManufacturerInfoId",
                "joinTable": "dbo.ManufacturerInfos_Locations",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "LocationId",
                "joinTableRightKey": "LocationId"
            }
        },
        {
            "propertyName": "ManufacturedForMarkets",
            "lazyLoader": "GetMarketsByManufacturerInfo",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ManufacturerInfoId",
                "joinTable": "dbo.ManufacturerInfos_Markets",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "MarketId",
                "joinTableRightKey": "MarketId"
            }
        }]
    }
]