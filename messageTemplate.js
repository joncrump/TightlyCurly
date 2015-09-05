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
        /*
        	[Id] INT NOT NULL IDENTITY(1,1),
	[MessageTemplateId] UNIQUEIDENTIFIER NOT NULL,
	[TemplateName] NVARCHAR(255) NOT NULL,
	[Text] NVARCHAR(MAX) NOT NULL,
	[ContentType] INT NULL,
	[LocaleId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL

                ILocale Locale { get; set; }
        string Text { get; set; }
        ContentType? ContentType { get; set; }
        Guid LocaleId { get; set; }
        string TemplateName { get; set; }
        IEnumerable<IMessageTemplateToken> MessageTemplateTokens { get; set; }
        */
    }
]