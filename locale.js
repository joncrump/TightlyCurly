[
    {
        "type":"TightlyCurly.Com.Common.Models.ILocale, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Locales",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "LocaleId",
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
            "propertyName": "Lcid",
            "fieldType": "int",
            "field": "Lcid",
            "allowDbNull": true
        },
        {
            "propertyName": "Code",
            "fieldType": "nvarchar",
            "field": "Code",
            "allowDbNull": true
        },
        {
            "propertyName": "LocaleName",
            "fieldType": "nvarchar",
            "field": "LocaleName"
        }]
    }
]