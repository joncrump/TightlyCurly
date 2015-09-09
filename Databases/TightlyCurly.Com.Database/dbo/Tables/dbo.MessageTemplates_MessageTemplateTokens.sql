CREATE TABLE [dbo].[MessageTemplates_MessageTemplateTokens]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[MessageTemplateId] UNIQUEIDENTIFIER NOT NULL,
	[MessageTemplateTokenId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
