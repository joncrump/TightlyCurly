[
    {
        "type":"Norml.Common.Models.IProductType, Norml.Common.Models",
        "dataSource": "dbo.ProductTypes",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductTypeId",
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
            "propertyName": "EnteredDate",
            "fieldType": "smalldatetime",
            "field": "EnteredDate"
        },
        {
            "propertyName": "UpdatedDate",
            "fieldType": "smalldatetime",
            "field": "UpdatedDate"
        }]
    }
]