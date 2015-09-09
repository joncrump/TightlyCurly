// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IMessageTemplate, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.MessageTemplate",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "MessageTemplateId",
            "isPrimaryKey": true
        },
        {
            "propertyName": "TemplateName",
            "fieldType": "nvarchar",
            "field": "TemplateName"
        },
        {
            "propertyName": "Text",
            "fieldType": "nvarchar",
            "field": "Text"
        },
        {
            "propertyName": "ContentType",
            "fieldType": "int",
            "field": "ContentType",
            "allowDbNull": true
        },
        {
            "propertyName": "LocaleId",
            "fieldType": "guid",
            "field": "LocaleId"
        },
        {
            "propertyName": "EnteredDate",
            "fieldType": "smalldatetime",
            "field": "EnteredDate",
        },
        {
            "propertyName": "UpdatedDate",
            "fieldType": "smalldatetime",
            "field": "UpdatedDate"
        },
        {
            "propertyName": "Locale",
            "lazyLoader": "GetLocaleByMessageTemplate",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "LocaleId",
                "rightKey": "LocaleId"
            }
         },
         {
             "propertyName": "MessageTemplateTokens",
             "lazyLoader": "GetMessageTemplateTokensByMessageTemplate",
             "joinMapping": 
             {
                 "joinType": "left",
                 "leftKey": "Id",
                 "rightKey": "MessageTemplateId",
                 "joinTable": "dbo.MessageTemplates_MessageTemplateTokens",
                 "joinTableJoinType": "left",
                 "joinTableLeftKey": "MessageTemplateTokenId",
                 "joinTableRightKey": "MessageTemplateTokenId"
             }
         }]
    }
]