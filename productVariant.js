[    
    {
        "type":"TightlyCurly.Com.Common.Models.IProductVariant, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.ProductVariants",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "ProductVariantId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "ProductId",
            "fieldType": "guid",
            "field": "ProductId"
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
            "propertyName": "Product",
            "lazyLoader": "GetProductByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "ProductId",
                "rightKey": "Id",
            }
        },
        {
            "propertyName": "Manufacturers",
            "lazyLoader": "GetManufacturersByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_Manufacturers",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "ManufacturerId",
                "joinTableRightKey": "ManufacturerId"
            }
        },
        {
            "propertyName": "Brands",
            "lazyLoader": "GetBrandsByProductVariant",
            "joinMapping": 
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_Brands",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "BrandId",
                "joinTableRightKey": "BrandId"
            }
        },
        {
            "propertyName": "Skus",
            "lazyLoader": "GetSkusByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
            }
        },
        {
            "propertyName": "Markets",
            "lazyLoader": "GetMarketsByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_Markets",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "MarketId",
                "joinTableRightKey": "MarketId"
            }
        },
        {
            "propertyName": "Ingredients",
            "lazyLoader": "GetIngredientsByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_IngredientInfos",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "IngredientInfoId",
                "joinTableRightKey": "IngredientInfoId"
            }
        },
        {
            "propertyName": "RevisionHistory",
            "lazyLoader": "GetRevisionHistoryByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
            }
        },
        {
            "propertyName": "LocationsSoldAt",
            "lazyLoader": "GetLocationsSoldAtByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_LocationsSoldAt",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "LocationId",
                "joinTableRightKey": "LocationId"
            }
        },
        {
            "propertyName": "ProductCategories",
            "lazyLoader": "GetProductCategoriesByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_ProductCategories",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "ProductCategoryId",
                "joinTableRightKey": "ProductCategoryId"
            }
        },
        {
            "propertyName": "ProductReviews",
            "lazyLoader": "GetProductReviewsByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
            }
        },
        {
            "propertyName": "ProductCategories",
            "lazyLoader": "GetProductCategoriesByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductSafetyInfos_ProductVariants",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "ProductSafetyInfoId",
                "joinTableRightKey": "ProductSafetyInfoId"
            }
        },
        {
            "propertyName": "ProductTypes",
            "lazyLoader": "GetProductTypesByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_ProductTypes",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "ProductTypeId",
                "joinTableRightKey": "ProductTypeId"
            }
        },
        {
            "propertyName": "ProductVariantImageUris",
            "lazyLoader": "GetProductImageUrisByProductVariant",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_ProductVariantImageUris",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "ProductVariantImageUriId",
                "joinTableRightKey": "ProductVariantImageUriId"
            }
        },
        {
            "propertyName": "Copyrights",
            "lazyLoader": "GetCopyrightsByProductVariants",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_Copyrights",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "CopyrightId",
                "joinTableRightKey": "CopyrightId"
            }
        },
        {
            "propertyName": "Trademarks",
            "lazyLoader": "GetTrademarksByProductVariants",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_Trademarks",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "TrademarkId",
                "joinTableRightKey": "TrademarkId"
            }
        },
        {
            "propertyName": "Patents",
            "lazyLoader": "GetPatentsByProductVariants",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
                "joinTable": "dbo.ProductVariants_Patents",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "PatentId",
                "joinTableRightKey": "PatentId"
            }
        },
        {
            "propertyName": "Notes",
            "lazyLoader": "GetNotesByProductVariants",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
            }
        },
        {
            "propertyName": "Descriptions",
            "lazyLoader": "GetDescriptionsByProductVariants",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
            }
        },
        {
            "propertyName": "Metadata",
            "lazyLoader": "GetMetadataByProductVariants",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "ProductVariantId",
            }
        }]
    }
]