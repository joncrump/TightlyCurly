[
    {
        "type":"TightlyCurly.Com.Common.Models.IPatentAuthor, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.PatentAuthors",
        "countProperty":"Id",
        "propertyMappings": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "PatentAuthorId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "FirstName",
            "fieldType": "nvarchar",
            "field": "FirstName",
            "allowDbNull": true
        },
        {
            "propertyName": "MiddleName",
            "fieldType": "nvarchar",
            "field": "MiddleName",
            "allowDbNull": true
        },
        {
            "propertyName": "LastName",
            "fieldType": "nvarchar",
            "field": "LastName",
            "allowDbNull": true
        },
        {
            "propertyName": "Gender",
            "fieldType": "nvarchar",
            "field": "Gender",
            "allowDbNull": true
        },
        {
            "propertyName": "Honorific",
            "fieldType": "nvarchar",
            "field": "Honorific",
            "allowDbNull": true
        },
        {
            "propertyName": "Suffix",
            "fieldType": "nvarchar",
            "field": "Suffix",
            "allowDbNull": true
        },
        {
            "propertyName": "PreferredLocaleId",
            "fieldType": "guid",
            "field": "PreferredLocaleId",
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
            "propertyName": "PreferredLocale",
            "lazyLoader": "GetPreferredLocaleByPatentAuthor",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "LocaleId",
                "rightKey": "LocaleId",
            }
        },
        {
            "propertyName": "SocialMediaInfo",
            "lazyLoader": "GetSocialMediaInfoByPatentAuthor",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "PatentAuthorId",
                "joinTable": "dbo.PatentAuthors_SocialMediaInfos",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "SocialMediaInfoId",
                "joinTableRightKey": "SocialMediaInfoId"
            }
        },
        {
            "propertyName": "ContactInfo",
            "lazyLoader": "GetContactInfoByPatentAuthor",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "PatentAuthorId",
                "joinTable": "dbo.PatentAuthors_ContactInfos",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "ContactInfoId",
                "joinTableRightKey": "ContactInfoId"
            }
        },
        {
            "propertyName": "Patents",
            "lazyLoader": "GetPatentsByPatentAuthor",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "PatentAuthorId",
                "joinTable": "dbo.PatentAuthors_Patents",
                "joinTableJoinType": "left",
                "joinTableLeftKey": "PatentId",
                "joinTableRightKey": "PatentId"
            }
        }]
    }
]