CREATE TABLE [dbo].[MessageCampaigns_MessageTemplates]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[MessageCampaignId] UNIQUEIDENTIFIER NOT NULL,
	[MessageTemplateId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
