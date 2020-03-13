[
    {
        "type":"Norml.Common.Models.ICompanyType, Norml.Common.Models",
        "dataSource": "dbo.CompanyTypes",
        "countProperty":"Id",
        "propertyMappings": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "CompanyTypeId",
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
                "propertyName": "Name",
                "fieldType": "nvarchar",
                "field": "Name"
            }
        ]
    }
]