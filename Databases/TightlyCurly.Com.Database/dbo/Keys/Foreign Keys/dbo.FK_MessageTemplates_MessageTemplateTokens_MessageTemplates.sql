ALTER TABLE [dbo].[MessageTemplates_MessageTemplateTokens]
	ADD CONSTRAINT [FK_MessageTemplates_MessageTemplateTokens_MessageTemplates]
	FOREIGN KEY (MessageTemplateId)
	REFERENCES [dbo].[MessageTemplates] (MessageTemplateId)
