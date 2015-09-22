[
    {
        "type":"TightlyCurly.Com.Common.Models.IContactInfo, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.CompanyInfos",
        "countProperty":"Id",
        "propertyMappings:": [
            {
                "propertyName": "Id",
                "fieldType": "guid",
                "field": "ContactInfoId",
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
                "propertyName": "Notes",
                "fieldType": "nvarchar",
                "field": "Notes",
                "allowDbNull": true
            },
            {
                "propertyName": "Description",
                "fieldType": "nvarchar",
                "field": "Description",
                "allowDbNull": true
            },
            {
                "propertyName": "IsActive",
                "fieldType": "bit",
                "field": "IsActive",
                "allowDbNull": true
            },
            {
                "propertyName": "Title",
                "fieldType": "nvarchar",
                "field": "Title",
                "allowDbNull": true
            },
            {
                "propertyName": "People",
                "lazyLoader": "GetPeopleByContactInfo",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "ContactInfoId",
                    "rightKey": "ContactInfoId",
                    "joinTable": "dbo.ContactInfos_People",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "PersonId",
                    "joinTableRightKey": "PersonId"
                }
            },
            {
                "propertyName": "Addresses",
                "lazyLoader": "GetAddressesByContactInfo",
                "joinMapping": 
                {
                    "joinType": "left",
                    "leftKey": "ContactInfoId",
                    "rightKey": "ContactInfoId",
                    "joinTable": "dbo.ContactInfos_Addresses",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "AddressId",
                    "joinTableRightKey": "AddressId"
                }
            },
            {
                "propertyName": "PhoneNumbers",
                "lazyLoader": "GetPhoneNumbersByContactInfo",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "ContactInfoId",
                    "rightKey": "ContactInfoId",
                    "joinTable": "dbo.ContactInfos_PhoneNumbers",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "PhoneNumberId",
                    "joinTableRightKey": "PhoneNumberId"
                }
            },
            {
                "propertyName": "EmailAddresses",
                "lazyLoader": "GetEmailsByContactInfo",
                "joinMapping":
                {
                    "joinType": "left",
                    "leftKey": "ContactInfoId",
                    "rightKey": "ContactInfoId",
                    "joinTable": "dbo.ContactInfos_EmailAddresses",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "EmailAddressId",
                    "joinTableRightKey": "EmailAddressId"
                }
            },
            {
                "propertyName": "SocialMedia",
                "lazyLoader": "GetSocialMediaByContactInfo",
                "joinMapping":
                {
                    "leftKey": "ContactInfoId",
                    "rightKey": "ContactInfoId",
                    "joinTable": "dbo.ContactInfos_SocialMediaInfos",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "SocialMediaInfoId",
                    "joinTableRightKey": "SocialMediaInfoId"
                }
            },
            {
                "propertyName": "CompanyPositions",
                "lazyLoader": "GetCompanyPositionsByContactInfo",
                "joinMapping":
                {
                    "leftKey": "ContactInfoId",
                    "rightKey": "ContactInfoId",
                    "joinTable": "dbo.ContactInfos_CompanyPositions",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "CompanyPositionId",
                    "joinTableRightKey": "CompanyPositionId"
                }
            },
            {
                "propertyName": "Contacts",
                "lazyLoader": "GetContactsByContactInfo",
                "joinMapping":
                {
                    "leftKey": "ContactInfoId",
                    "rightKey": "ContactInfoId",
                    "joinTable": "dbo.ContactInfos_PeopleId",
                    "joinTableJoinType": "left",
                    "joinTableLeftKey": "PersonId",
                    "joinTableRightKey": "PersonId"
                }
            }
        ]
    }
]