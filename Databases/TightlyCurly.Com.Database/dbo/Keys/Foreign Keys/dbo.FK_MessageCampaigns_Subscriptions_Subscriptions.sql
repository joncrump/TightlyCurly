ALTER TABLE [dbo].[MessageCampaigns_Subscriptions]
	ADD CONSTRAINT [FK_MessageCampaigns_Subscriptions_Subscriptions]
	FOREIGN KEY (SubscriptionId)
	REFERENCES [dbo].[Subscriptions] (SubscriptionId)
