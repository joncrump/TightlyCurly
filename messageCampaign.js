// JavaScript source code
[
    {
        "type":"TightlyCurly.Com.Common.Models.IMessageCampaign, TightlyCurly.Com.Common.Models",
        "dataSource": "dbo.MessageCampaigns",
        "countProperty":"Id",
        "propertyMappings:": [
        {
            "propertyName": "Id",
            "fieldType": "guid",
            "field": "MessageCampaignId",
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
            "propertyName": "CampaignName",
            "fieldType": "nvarchar",
            "field": "CampaignName"
        },
        {
            "propertyName": "Description",
            "fieldType": "nvarchar",
            "field": "Description",
            "allowDbNull": true
        },
        {
            "propertyName": "MessageTemplates",
            "lazyLoader": "GetMessageTemplatesByMessageCampaign",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "MessageCampaignId",
                "joinTable": "dbo.MessageCampaigns_MessageTemplates",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "MessageTemplateId",
                "joinTableRightKey": "MessageTemplateId"
            }
        },
        {
            "propertyName": "Subscriptions",
            "lazyLoader": "GetSubscriptionsByMessageCampaign",
            "joinMapping":
            {
                "joinType": "left",
                "leftKey": "Id",
                "rightKey": "MessageCampaignId",
                "joinTable": "dbo.MessageCampaigns_Subscriptions",
                "jonTableJoinType": "left",
                "joinTableLeftKey": "SubscriptionId",
                "joinTableRightKey": "SubscriptionId"
            }
        }]
    }
]