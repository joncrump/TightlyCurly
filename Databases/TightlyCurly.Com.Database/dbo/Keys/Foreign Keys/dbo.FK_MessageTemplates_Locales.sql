ALTER TABLE [dbo].[MessageTemplates]
	ADD CONSTRAINT [FK_MessageTemplates_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
