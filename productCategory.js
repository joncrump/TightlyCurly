[
    {
        "type":"TightlyCurly.Com.Common.Models.IProductCategory, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductCategories",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductCategoryId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "Name",
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