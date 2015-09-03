ALTER TABLE [dbo].[MessageCampaigns_MessageTemplates]
	ADD CONSTRAINT [FK_MessageCampaigns_MessageTemplates_MessageCampaigns]
	FOREIGN KEY (MessageCampaignId)
	REFERENCES [dbo].[MessageCampaigns] (MessageCampaignId)
