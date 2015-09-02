ALTER TABLE [dbo].[MenuTexts]
	ADD CONSTRAINT [FK_MenuTexts_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
