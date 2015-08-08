ALTER TABLE [dbo].[People]
	ADD CONSTRAINT [FK_People_Locales]
	FOREIGN KEY (PreferredLocale)
	REFERENCES [Locales] (LocaleId)
