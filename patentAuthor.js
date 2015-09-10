// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IPatentAuthor, TightlyCurly.Com.Common.Models",
            "dataSource": "dbo.PatentAuthors",
            "countProperty":"Id",
            "propertyMappings:": [
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
            }]
        /*
        ILocale PreferredLocale { get; set; }
        IEnumerable<ISocialMediaInfo> SocialMediaInfo { get; set; }
                Guid? PreferredLocaleId { get; set; }
        IEnumerable<IContactInfo> ContactInfo { get; set; }
        IEnumerable<IPersonRelationship> Relationships { get; set; } 
                IEnumerable<IPatent> Patents { get; set; } 
        */
    }
]