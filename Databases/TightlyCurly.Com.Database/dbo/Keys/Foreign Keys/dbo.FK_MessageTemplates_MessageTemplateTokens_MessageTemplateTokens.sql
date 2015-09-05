ALTER TABLE [dbo].[MessageTemplates_MessageTemplateTokens]
	ADD CONSTRAINT [FK_MessageTemplates_MessageTemplateTokens_MessageTemplateTokens]
	FOREIGN KEY (MessageTemplateTokenId)
	REFERENCES [dbo].[MessageTemplateTokens] (MessageTemplateTokenId)
