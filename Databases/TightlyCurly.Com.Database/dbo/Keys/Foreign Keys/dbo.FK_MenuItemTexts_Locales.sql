ALTER TABLE [dbo].[MenuItemTexts]
	ADD CONSTRAINT [FK_MenuItemTexts_Locales]
	FOREIGN KEY (LocaleId)
	REFERENCES [dbo].[Locales] (LocaleId)
