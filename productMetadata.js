[
    {
        "type": "Norml.Common.Models.IProductMetadata, Norml.Common.Models",
        "dataSource": "dbo.ProductMetadata",
        "countProperty": "Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductMetadataId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ProductId",
            "fieldType": "guid",
            "field": "ProductId"
        },
        {
            "propertyName": "Title",
            "fieldType": "nvarchar",
            "field": "Title"
        },
        {
            "propertyName": "Product",
            "lazyLoader": "GetProductByProductMetadata",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductId",
                "rightKey": "Id",
            }
        },
        {
            "propertyName": "Brands",
            "lazyLoader": "GetBrandsByProductMetadata",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductMetadataId",
                "joinTable": "dbo.ProductMetadata_Brands",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "BrandId",
                "joinTableRightKey": "BrandId"
            }
        },
        {
            "propertyName": "ProductLines",
            "lazyLoader": "GetProductLinesByProductMetadata",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductMetadataId",
                "joinTable": "dbo.ProductMetadata_ProductLines",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "ProductLineId",
                "joinTableRightKey": "ProductLineId"
            }
        },
        {
            "propertyName": "ImageUris",
            "lazyLoader": "GetImageUrisByProductMetadata",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductMetadataId",
                "joinTable": "dbo.ProductMetadata_ProductImageUris",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "ProductImageUriId",
                "joinTableRightKey": "ProductImageUriId"
            }
        }]
    }
]