ALTER TABLE [dbo].[MessageCampaigns_MessageTemplates]
	ADD CONSTRAINT [FK_MessageCampaigns_MessageTemplates_MessageTemplates]
	FOREIGN KEY (MessageTemplateId)
	REFERENCES [dbo].[MessageTemplates] (MessageTemplateId)
