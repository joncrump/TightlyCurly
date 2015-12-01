[
    {
        "type":"TightlyCurly.Com.Common.Models.IRatingType, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.RatingTypes",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "RatingTypeId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "Type",
            "fieldType": "nvarchar",
            "field": "Type"
        },
        {
            "propertyName": "Description",
            "fieldType": "nvarchar",
            "field": "Description",
            "allowDbNull": true
        },
        {
            "propertyName": "LocaleId",
            "fieldType": "guid",
            "field": "LocaleId",
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
        },
        {
            "propertyName": "Locale",
            "lazyLoader": "GetLocaleByRatingType",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "LocaleId",
                "rightKey": "LocaleId"
            }
        }]
    }
]