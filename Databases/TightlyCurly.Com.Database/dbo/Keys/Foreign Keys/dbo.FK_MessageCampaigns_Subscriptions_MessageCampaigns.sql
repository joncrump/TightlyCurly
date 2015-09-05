ALTER TABLE [dbo].[MessageCampaigns_Subscriptions]
	ADD CONSTRAINT [FK_MessageCampaigns_Subscriptions_MessageCampaigns]
	FOREIGN KEY (MessageCampaignId)
	REFERENCES [dbo].[MessageCampaigns] (MessageCampaignId)
