// TODO: Add mappings
[
    {
        "type": "TightlyCurly.Com.Common.Models.IProductRevisionHistory, TightlyCurly.Com.Common.Models",
            "dataSource": "dbo.ProductRevisionHistory",
            "countProperty": "Id",
            "propertyMappings:": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "ProductSafetyInfoId",
                "isPrimaryKey": true
            },
            {
                "propertyName": "PreviousVariantId",
                "fieldType": "guid",
                "field": "PreviousVariantId",
                "allowDbNull": true
            },
            {
                "propertyName": "CurrentVariantId",
                "fieldType": "guid",
                "field": "CurrentVariantId",
                "allowDbNull": true
            }]
        /*
        string Comments { get; set; }
        string Notes { get; set; }
        IProductVariant PreviousVariant { get; set; }
        IProductVariant CurrentVariant { get; set; }
        */
    }
]