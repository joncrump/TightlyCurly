CREATE TABLE [dbo].[MessageCampaigns_Subscriptions]
(
	[Id] INT NOT NULL IDENTITY(1,1),
	[MessageCampaignId] UNIQUEIDENTIFIER NOT NULL,
	[SubscriptionId] UNIQUEIDENTIFIER NOT NULL,
	[EnteredDate] SMALLDATETIME NOT NULL,
	[UpdatedDate] SMALLDATETIME NOT NULL
)
