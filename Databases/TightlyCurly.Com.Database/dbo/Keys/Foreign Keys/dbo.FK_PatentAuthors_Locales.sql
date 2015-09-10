ALTER TABLE [dbo].[PatentAuthors]
	ADD CONSTRAINT [FK_PatentAuthors_Locales]
	FOREIGN KEY (PreferredLocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
