[
    {
        "type":"TightlyCurly.Com.Common.Models.ICompany, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.Companies",
        "countProperty":"Id",
        "propertyMappings:": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "CompanyId",
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
                "propertyName": "ParentCompanyId",
                "fieldType": "guid",
                "field": "ParentCompanyId",
                "allowDbNull": true
            },
            {
                "propertyName": "Name",
                "fieldType": "nvarchar",
                "field": "nvarchar"
            },
            {
                "propertyName": "Countries",
                "lazyLoader": "GetCountriesByCompany",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CompanyId",
                    "rightKey": "CompanyId",
                    "joinTable": "dbo.Companies_Countries",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "CountryId",
                    "joinTableRightKey": "CountryId"
                }
            },
            {
                "propertyName": "ContactInfos",
                "lazyLoader": "GetContactInfosByCompany",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CompanyId",
                    "rightKey": "CompanyId",
                    "joinTable": "dbo.Companies_ContactInfos",
                    "jonTableJoinType": "left",
                    "joinTableLeftKey": "ContactInfoId",
                    "joinTableRightKey": "ContactInfoId"
                }
            },
            {
                "propertyName": "ParentCompany",
                "lazyLoader": "GetParentCompanyByCompany",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "ParentCompanyId",
                    "rightKey":"CompanyId"
                }

            },
            {
                "propertyName": "ChildCompanies",
                "lazyLoader": "GetChildCompaniesByCompany",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CompanyId",
                    "rightKey": "PazrentCompanyId"
                }
            },
            {
                "propertyName": "Relationships",
                "lazyLoader": "GetRelationshipsByCompany",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CompanyId",
                    "rightKey": "CompanyId",
                    "joinTable": "dbo.Companies_CompanyRelationships",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "CompanyRelationshipId",
                    "joinTableRightKey": "CompanyRelationshipId"
                }
            },
            {
                "propertyName": "CompanyTypes",
                "lazyLoader": "GetCompanyTypesByCompany",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "CompanyId",
                    "rightKey": "CompanyId",
                    "joinTable": "dbo.Companies_CompanyTypes",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "CompanyTypeId",
                    "joinTableRightKey": "CompanyTypeId"
                }
            }
        ]
    }
]