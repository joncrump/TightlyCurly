[
    {
        "type":"TightlyCurly.Com.Common.Models.IEmailAddress, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.EmailAddresses",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "EmailAddressId",
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
            "propertyName": "Address",
            "fieldType": "nvarchar",
            "field": "Address"
        },
        {
            "propertyName": "Verified",
            "fieldType": "bit",
            "field": "Verified",
            "allowDbNull": true
        },
        {
            "propertyName": "IsPrimary",
            "fieldType": "bit",
            "field": "IsPrimary",
            "allowDbNull":true
        },
        {
            "propertyName": "IsActive",
            "fieldType": "bit",
            "field": "IsActive",
            "allowDbNull": true
        }]
    }
]